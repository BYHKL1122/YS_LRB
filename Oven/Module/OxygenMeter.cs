using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Xml;

namespace YS_6000.Module
{
    /// <summary>
    /// Modbus RTU 含氧仪通讯类。一个实例只允许一个未完成请求。
    /// </summary>
    public class OxygenMeter : IDisposable
    {
        public class SerialConfig
        {
            public string PortName { get; set; } = "COM1";
            public int BaudRate { get; set; } = 9600;
            public int DataBits { get; set; } = 8;
            public StopBits StopBits { get; set; } = StopBits.One;
            public Parity Parity { get; set; } = Parity.None;
            public int SlaveAddress { get; set; } = 1;
            public string StartAddress { get; set; } = "002A";
            public int RegisterCount { get; set; } = 2;
            public bool RtsControl { get; set; } = true;
            public int SendDelay { get; set; } = 50;
            public int ReadTimeout { get; set; } = 1000;
            public int WriteTimeout { get; set; } = 1000;
            public int MaxRetry { get; set; } = 3;
            public int ResponseTimeout { get; set; } = 2500;
            public float ScaleFactor { get; set; } = 1f; //10000f

            public SerialConfig Clone()
            {
                return new SerialConfig
                {
                    PortName = PortName,
                    BaudRate = BaudRate,
                    DataBits = DataBits,
                    StopBits = StopBits,
                    Parity = Parity,
                    SlaveAddress = SlaveAddress,
                    StartAddress = StartAddress,
                    RegisterCount = RegisterCount,
                    RtsControl = RtsControl,
                    SendDelay = SendDelay,
                    ReadTimeout = ReadTimeout,
                    WriteTimeout = WriteTimeout,
                    MaxRetry = MaxRetry,
                    ResponseTimeout = ResponseTimeout,

                    ScaleFactor = ScaleFactor
                };
            }
        }

        public event EventHandler<bool> ConnectionChanged;
        public event EventHandler<float> OxygenValueReceived;
        public event EventHandler<ushort> DeviceAddressReceived;
        public event EventHandler<byte[]> RawFrameReceived;
        public event EventHandler<string> LogMessage;
        public event EventHandler<Exception> ErrorOccurred;
        public event EventHandler TimeoutOccurred;

        private readonly object _portLock = new object();
        private readonly object _rxLock = new object();
        private readonly object _configLock = new object();
        private readonly List<byte> _rxBuffer = new List<byte>();

        private SerialPort _serialPort;
        private Timer _timeoutTimer;
        private Timer _autoReadTimer;
        private volatile bool _isDisposed;
        private bool _isBusy;
        private int _retryCount;
        private int _requestToken;
        private ushort _pendingStartAddress;
        private ushort _pendingRegisterCount;

        public SerialConfig Config { get; private set; } = new SerialConfig();

        public bool IsConnected
        {
            get
            {
                lock (_portLock)
                {
                    return _serialPort != null && _serialPort.IsOpen;
                }
            }
        }

        public bool IsBusy
        {
            get { lock (_portLock) { return _isBusy; } }
        }

        public bool LoadConfig(string xmlPath)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(xmlPath))
                    throw new ArgumentException("配置文件路径不能为空。", nameof(xmlPath));

                if (!File.Exists(xmlPath))
                {
                    CreateDefaultXml(xmlPath);
                    OnLog("配置文件不存在，已创建默认配置: " + xmlPath);
                }

                XmlDocument doc = new XmlDocument();
                doc.Load(xmlPath);
                XmlElement root = doc.DocumentElement;
                if (root == null || !string.Equals(root.Name, "SerialConfig", StringComparison.OrdinalIgnoreCase))
                    throw new FormatException("Xml 根节点必须是 <SerialConfig>。");

                SerialConfig loaded = new SerialConfig
                {
                    PortName = GetXmlValue(root, "PortName", "COM1"),
                    BaudRate = GetXmlInt(root, "BaudRate", 9600),
                    DataBits = GetXmlInt(root, "DataBits", 8),
                    StopBits = ParseEnum(GetXmlValue(root, "StopBits", "One"), StopBits.One),
                    Parity = ParseEnum(GetXmlValue(root, "Parity", "None"), Parity.None),
                    SlaveAddress = GetXmlInt(root, "SlaveAddress", 1),
                    StartAddress = GetXmlValue(root, "StartAddress", "002A"),
                    RegisterCount = GetXmlInt(root, "RegisterCount", 2),
                    RtsControl = GetXmlBool(root, "RtsControl", true),
                    SendDelay = GetXmlInt(root, "SendDelay", 50),
                    ReadTimeout = GetXmlInt(root, "ReadTimeout", 1000),
                    WriteTimeout = GetXmlInt(root, "WriteTimeout", 1000),
                    MaxRetry = GetXmlInt(root, "MaxRetry", 3),
                    ResponseTimeout = GetXmlInt(root, "ResponseTimeout", 2500),
                    ScaleFactor = GetXmlFloat(root, "ScaleFactor", 1f)//10000
                };

                ValidateConfig(loaded);

                if (IsConnected)
                    Disconnect();

                lock (_configLock)
                {
                    Config = loaded;
                }

                OnLog("配置加载成功: " + xmlPath);
                return true;
            }
            catch (Exception ex)
            {
                OnError(ex);
                return false;
            }
        }

        public bool Load()
        {
            return LoadConfig(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "OxygenMeterConfig.xml"));
        }

        private static void CreateDefaultXml(string path)
        {
            string fullPath = Path.GetFullPath(path);
            string directory = Path.GetDirectoryName(fullPath);
            if (!string.IsNullOrEmpty(directory))
                Directory.CreateDirectory(directory);

            string xml = @"<?xml version=""1.0"" encoding=""utf-8""?>
<SerialConfig>
  <PortName>COM1</PortName>
  <BaudRate>9600</BaudRate>
  <DataBits>8</DataBits>
  <StopBits>One</StopBits>
  <Parity>None</Parity>
  <SlaveAddress>1</SlaveAddress>
  <StartAddress>002A</StartAddress>
  <RegisterCount>2</RegisterCount>
  <RtsControl>true</RtsControl>
  <SendDelay>50</SendDelay>
  <ReadTimeout>1000</ReadTimeout>
  <WriteTimeout>1000</WriteTimeout>
  <MaxRetry>3</MaxRetry>
  <ResponseTimeout>2500</ResponseTimeout>
  <ScaleFactor>10000</ScaleFactor>
</SerialConfig>";
            File.WriteAllText(fullPath, xml, Encoding.UTF8);
        }

        public bool Connect()
        {
            SerialConfig config = GetConfigSnapshot();
            Exception error = null;
            bool connected = false;

            lock (_portLock)
            {
                if (_isDisposed)
                    return false;
                if (_serialPort != null && _serialPort.IsOpen)
                    return true;

                try
                {
                    ValidateConfig(config);
                    SerialPort port = new SerialPort(config.PortName, config.BaudRate)
                    {
                        DataBits = config.DataBits,
                        StopBits = config.StopBits,
                        Parity = config.Parity,
                        ReadTimeout = config.ReadTimeout,
                        WriteTimeout = config.WriteTimeout,
                        Handshake = Handshake.None
                    };

                    if (config.RtsControl)
                        port.RtsEnable = false;

                    port.DataReceived += OnDataReceived;
                    port.Open();
                    _serialPort = port;
                    connected = true;
                }
                catch (Exception ex)
                {
                    error = ex;
                    if (_serialPort != null)
                    {
                        _serialPort.Dispose();
                        _serialPort = null;
                    }
                }
            }

            if (error != null)
            {
                OnError(error);
                return false;
            }

            if (connected)
            {
                OnLog(string.Format("串口已连接: {0}@{1}", config.PortName, config.BaudRate));
                OnConnectionChanged(true);
            }
            return connected;
        }

        public void Disconnect()
        {
            StopAutoRead();

            SerialPort portToDispose = null;
            Timer timerToDispose = null;
            bool wasConnected;

            lock (_portLock)
            {
                wasConnected = _serialPort != null;
                portToDispose = _serialPort;
                _serialPort = null;
                _isBusy = false;
                _requestToken++;
                timerToDispose = TakeTimeoutTimerLocked();
            }

            timerToDispose?.Dispose();

            if (portToDispose != null)
            {
                try
                {
                    SerialConfig config = GetConfigSnapshot();
                    if (config.RtsControl && portToDispose.IsOpen)
                        portToDispose.RtsEnable = false;
                    if (portToDispose.IsOpen)
                        portToDispose.Close();
                }
                catch (Exception ex)
                {
                    OnError(ex);
                }
                finally
                {
                    try { portToDispose.DataReceived -= OnDataReceived; } catch { }
                    portToDispose.Dispose();
                }
            }

            ClearRxBuffer();
            if (wasConnected)
            {
                OnConnectionChanged(false);
                OnLog("串口已断开");
            }
        }

        public void StartAutoRead(int intervalMs)
        {
            if (intervalMs < 100)
                intervalMs = 100;

            Timer oldTimer;
            lock (_portLock)
            {
                if (_isDisposed)
                    return;
                oldTimer = _autoReadTimer;
                _autoReadTimer = new Timer(AutoReadCallback, null, intervalMs, intervalMs);
            }

            oldTimer?.Dispose();
            OnLog("自动读取已启动，间隔 " + intervalMs + "ms");
        }

        public void StopAutoRead()
        {
            Timer timer;
            lock (_portLock)
            {
                timer = _autoReadTimer;
                _autoReadTimer = null;
            }
            timer?.Dispose();
        }

        private void AutoReadCallback(object state)
        {
            if (_isDisposed)
                return;

            bool connected;
            bool busy;
            lock (_portLock)
            {
                connected = _serialPort != null && _serialPort.IsOpen;
                busy = _isBusy;
            }

            if (connected && !busy)
                ReadOxygen();
        }

        public bool ReadOxygen()
        {
            SerialConfig config = GetConfigSnapshot();
            ushort startAddress;
            if (!TryParseHex(config.StartAddress, out startAddress))
            {
                OnLog("错误: StartAddress 不是有效的十六进制地址。");
                return false;
            }
            return SendReadCommand(startAddress, (ushort)config.RegisterCount);
        }

        public bool ReadDeviceAddress()
        {
            return SendReadCommand(0x0000, 1);
        }

        public bool ReadRegister(ushort startAddr, ushort regCount)
        {
            return SendReadCommand(startAddr, regCount);
        }

        private bool SendReadCommand(ushort startAddr, ushort regCount)
        {
            return SendReadCommandInternal(startAddr, regCount, false, 0);
        }

        private bool SendReadCommandInternal(ushort startAddr, ushort regCount, bool retry, int expectedToken)
        {
            Timer timerToDispose = null;
            byte[] frame = null;
            string message = null;
            Exception error = null;
            SerialConfig config = GetConfigSnapshot();

            if (regCount < 1 || regCount > 125)
            {
                OnLog("错误: Modbus 寄存器数量必须在 1 到 125 之间。");
                return false;
            }

            lock (_portLock)
            {
                if (_isDisposed)
                    return false;
                if (_serialPort == null || !_serialPort.IsOpen)
                {
                    message = "错误: 串口未连接";
                }
                else if (retry && (!_isBusy || expectedToken != _requestToken))
                {
                    return false;
                }
                else if (!retry && _isBusy)
                {
                    message = "警告: 前一条指令未响应，跳过本次发送";
                }
                else
                {
                    if (!retry)
                    {
                        _pendingStartAddress = startAddr;
                        _pendingRegisterCount = regCount;
                        _retryCount = 0;
                        _requestToken++;
                    }

                    int token = _requestToken;
                    try
                    {
                        frame = BuildReadFrame((byte)config.SlaveAddress, startAddr, regCount);
                        ClearRxBufferLocked();
                        _serialPort.DiscardInBuffer();
                        _serialPort.DiscardOutBuffer();

                        // 先标记忙，再写串口，避免设备快速响应时被误判为旧响应。
                        _isBusy = true;
                        if (config.RtsControl)
                        {
                            _serialPort.RtsEnable = true;
                            Thread.Sleep(5);
                        }

                        _serialPort.Write(frame, 0, frame.Length);

                        if (config.RtsControl)
                        {
                            Thread.Sleep(config.SendDelay);
                            _serialPort.RtsEnable = false;
                        }
                        timerToDispose = ReplaceTimeoutTimerLocked(token, config.ResponseTimeout);
                    }
                    catch (Exception ex)
                    {
                        _isBusy = false;
                        _requestToken++;
                        timerToDispose = TakeTimeoutTimerLocked();
                        error = ex;
                    }
                }
            }

            timerToDispose?.Dispose();
            if (error != null)
            {
                OnError(error);
                return false;
            }
            if (message != null)
            {
                OnLog(message);
                return false;
            }
            if (frame == null)
                return false;

            OnLog(string.Format("发送: {0} [地址=0x{1:X4}, 数量={2}{3}]",
                BytesToHex(frame), startAddr, regCount, retry ? ", 重试" : string.Empty));
            return true;
        }

        private void OnDataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (_isDisposed)
                return;

            byte[] received = null;
            int receivedLength = 0;
            try
            {
                // 与发送、关闭共用同一把端口锁，避免 Read 与 Discard/Close 交叉执行。
                lock (_portLock)
                {
                    SerialPort port = _serialPort;
                    if (port == null || !port.IsOpen)
                        return;

                    int available = port.BytesToRead;
                    if (available <= 0)
                        return;

                    byte[] buffer = new byte[available];
                    receivedLength = port.Read(buffer, 0, buffer.Length);
                    if (receivedLength > 0)
                    {
                        received = buffer;
                        if (receivedLength != buffer.Length)
                            Array.Resize(ref received, receivedLength);
                    }
                }

                if (received == null || received.Length == 0)
                    return;

                lock (_rxLock)
                {
                    _rxBuffer.AddRange(received);
                }

                OnLog("收到 " + received.Length + " 字节: " + BytesToHex(received));
                ProcessRxData();
            }
            catch (Exception ex)
            {
                OnError(ex);
            }
        }

        private void ProcessRxData()
        {
            byte expectedSlave;
            bool busy;
            lock (_portLock)
            {
                busy = _isBusy;
                expectedSlave = (byte)GetConfigSnapshot().SlaveAddress;
            }

            if (!busy)
                return;

            List<string> parserLogs = new List<string>();
            List<byte[]> frames = ExtractFrames(expectedSlave, parserLogs);
            foreach (string log in parserLogs)
                OnLog(log);
            foreach (byte[] frame in frames)
                HandleFrame(frame);
        }

        private List<byte[]> ExtractFrames(byte expectedSlave, List<string> parserLogs)
        {
            List<byte[]> frames = new List<byte[]>();
            lock (_rxLock)
            {
                while (_rxBuffer.Count >= 5)
                {
                    if (_rxBuffer[0] != expectedSlave)
                    {
                        _rxBuffer.RemoveAt(0);
                        continue;
                    }

                    byte function = _rxBuffer[1];
                    if (function == 0x83)
                    {
                        byte[] exceptionFrame = _rxBuffer.Take(5).ToArray();
                        if (!HasValidCrc(exceptionFrame))
                        {
                            parserLogs.Add("异常响应 CRC 错误，丢弃一个字节。");
                            _rxBuffer.RemoveAt(0);
                            continue;
                        }
                        _rxBuffer.RemoveRange(0, 5);
                        frames.Add(exceptionFrame);
                        continue;
                    }

                    if (function != 0x03)
                    {
                        parserLogs.Add(string.Format("忽略未知 Modbus 功能码: 0x{0:X2}", function));
                        _rxBuffer.RemoveAt(0);
                        continue;
                    }

                    int byteCount = _rxBuffer[2];
                    if (byteCount <= 0 || byteCount > 250 || (byteCount & 1) != 0)
                    {
                        parserLogs.Add("收到非法的 Modbus 字节数: " + byteCount);
                        _rxBuffer.RemoveAt(0);
                        continue;
                    }

                    int frameLength = 5 + byteCount;
                    if (_rxBuffer.Count < frameLength)
                        break;

                    byte[] frame = _rxBuffer.Take(frameLength).ToArray();
                    if (!HasValidCrc(frame))
                    {
                        ushort receivedCrc = (ushort)((frame[frame.Length - 1] << 8) | frame[frame.Length - 2]);
                        ushort calculatedCrc = CalcCRC16(frame, frame.Length - 2);
                        parserLogs.Add(string.Format("CRC错误: 接收=0x{0:X4}, 计算=0x{1:X4}", receivedCrc, calculatedCrc));
                        _rxBuffer.RemoveAt(0);
                        continue;
                    }
                    _rxBuffer.RemoveRange(0, frameLength);
                    frames.Add(frame);
                }
            }
            return frames;
        }

        private void HandleFrame(byte[] frame)
        {
            Timer timerToDispose = null;
            bool accepted = false;
            bool exception = frame[1] == 0x83;
            ushort expectedByteCount = 0;
            float scaleFactor = 1f;
            string mismatchMessage = null;

            lock (_portLock)
            {
                if (!_isBusy)
                    return;

                if (exception)
                {
                    _retryCount = GetConfigSnapshot().MaxRetry;
                    _isBusy = false;
                    _requestToken++;
                    timerToDispose = TakeTimeoutTimerLocked();
                }
                else
                {
                    expectedByteCount = (ushort)(_pendingRegisterCount * 2);
                    if (frame[2] != expectedByteCount)
                    {
                        // 不匹配的帧不能结束当前请求，继续等待正确响应或超时重试。
                        mismatchMessage = string.Format("响应字节数不匹配: 收到={0}, 期望={1}", frame[2], expectedByteCount);
                    }
                    else
                    {
                        scaleFactor = GetConfigSnapshot().ScaleFactor;
                        _retryCount = 0;
                        _isBusy = false;
                        _requestToken++;
                        timerToDispose = TakeTimeoutTimerLocked();
                        accepted = true;
                    }
                }
            }

            timerToDispose?.Dispose();

            if (mismatchMessage != null)
            {
                OnLog(mismatchMessage);
                return;
            }

            if (exception)
            {
                ParseException(frame);
                return;
            }
            if (!accepted)
                return;

            OnLog("接收完整帧: " + BytesToHex(frame) + " [CRC OK]");
            OnRawFrameReceived(frame);

            int byteCount = frame[2];
            if (byteCount == 2)
            {
                ushort value = (ushort)((frame[3] << 8) | frame[4]);
                OnLog(">> 返回Word值: " + value);
                if (value >= 1 && value <= 247)
                    OnDeviceAddressReceived(value);
            }
            else if (byteCount >= 4)
            {
                byte[] floatBytes = { frame[6], frame[5], frame[4], frame[3] };
                float rawValue = BitConverter.ToSingle(floatBytes, 0);
                float scaledValue = rawValue / scaleFactor;
                OnLog(string.Format(">> 含氧量原始值: {0:F4}, 缩放后: {1:F4}%", rawValue, scaledValue));
                OnOxygenValueReceived(scaledValue);
            }
        }

        private void ParseException(byte[] data)
        {
            string text;
            switch (data[2])
            {
                case 0x01: text = "非法功能码"; break;
                case 0x02: text = "非法数据地址"; break;
                case 0x03: text = "非法数据值"; break;
                case 0x04: text = "从机设备故障"; break;
                default: text = string.Format("未知异常码 0x{0:X2}", data[2]); break;
            }
            OnLog("设备异常: " + text);
        }

        private void TimeoutCallback(object state)
        {
            if (_isDisposed)
                return;

            int token = (int)state;
            Timer timerToDispose = null;
            ushort startAddress = 0;
            ushort registerCount = 0;
            bool retry = false;

            lock (_portLock)
            {
                if (_isDisposed || !_isBusy || token != _requestToken)
                    return;

                timerToDispose = TakeTimeoutTimerLocked();
                if (_retryCount < GetConfigSnapshot().MaxRetry)
                {
                    _retryCount++;
                    startAddress = _pendingStartAddress;
                    registerCount = _pendingRegisterCount;
                    retry = true;
                }
                else
                {
                    _isBusy = false;
                    _requestToken++;
                }
            }

            timerToDispose?.Dispose();

            if (retry)
            {
                OnLog(string.Format("超时未响应，第{0}次重试...", _retryCount));
                SendReadCommandInternal(startAddress, registerCount, true, token);
            }
            else
            {
                OnLog("重试次数已达上限，通讯超时");
                OnTimeoutOccurred();
            }
        }

        public void Dispose()
        {
            lock (_portLock)
            {
                if (_isDisposed)
                    return;
                _isDisposed = true;
            }

            // Disconnect 会先停止并移除 Timer，避免对已释放 Timer 再次 Change。
            Disconnect();
            StopAutoRead();
            GC.SuppressFinalize(this);
        }

        private SerialConfig GetConfigSnapshot()
        {
            lock (_configLock)
            {
                return Config.Clone();
            }
        }

        private Timer ReplaceTimeoutTimerLocked(int token, int dueTime)
        {
            Timer oldTimer = _timeoutTimer;
            _timeoutTimer = new Timer(TimeoutCallback, token, dueTime, Timeout.Infinite);
            return oldTimer;
        }

        private Timer TakeTimeoutTimerLocked()
        {
            Timer timer = _timeoutTimer;
            _timeoutTimer = null;
            return timer;
        }

        private void ClearRxBuffer()
        {
            lock (_rxLock) { _rxBuffer.Clear(); }
        }

        private void ClearRxBufferLocked()
        {
            lock (_rxLock) { _rxBuffer.Clear(); }
        }

        private static byte[] BuildReadFrame(byte slaveId, ushort startAddr, ushort regCount)
        {
            byte[] frame = new byte[8];
            frame[0] = slaveId;
            frame[1] = 0x03;
            frame[2] = (byte)(startAddr >> 8);
            frame[3] = (byte)(startAddr & 0xFF);
            frame[4] = (byte)(regCount >> 8);
            frame[5] = (byte)(regCount & 0xFF);
            ushort crc = CalcCRC16(frame, 6);
            frame[6] = (byte)(crc & 0xFF);
            frame[7] = (byte)(crc >> 8);
            return frame;
        }

        private static bool HasValidCrc(byte[] frame)
        {
            if (frame == null || frame.Length < 5)
                return false;
            ushort received = (ushort)((frame[frame.Length - 1] << 8) | frame[frame.Length - 2]);
            return received == CalcCRC16(frame, frame.Length - 2);
        }

        private static ushort CalcCRC16(byte[] data, int length)
        {
            ushort crc = 0xFFFF;
            for (int i = 0; i < length; i++)
            {
                crc ^= data[i];
                for (int j = 0; j < 8; j++)
                    crc = (ushort)(((crc & 1) == 1) ? ((crc >> 1) ^ 0xA001) : (crc >> 1));
            }
            return crc;
        }

        private static bool TryParseHex(string text, out ushort result)
        {
            result = 0;
            if (string.IsNullOrWhiteSpace(text))
                return false;
            text = text.Trim();
            if (text.StartsWith("0x", StringComparison.OrdinalIgnoreCase))
                text = text.Substring(2);
            return ushort.TryParse(text, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out result);
        }

        private static string GetXmlValue(XmlNode parent, string nodeName, string defaultValue)
        {
            XmlNode node = parent.SelectSingleNode(nodeName);
            return node == null || string.IsNullOrWhiteSpace(node.InnerText) ? defaultValue : node.InnerText.Trim();
        }

        private static int GetXmlInt(XmlNode parent, string nodeName, int defaultValue)
        {
            string value = GetXmlValue(parent, nodeName, defaultValue.ToString(CultureInfo.InvariantCulture));
            int result;
            if (int.TryParse(value, NumberStyles.Integer, CultureInfo.InvariantCulture, out result))
                return result;
            throw new FormatException(nodeName + " 不是有效的整数。");
        }

        private static float GetXmlFloat(XmlNode parent, string nodeName, float defaultValue)
        {
            string value = GetXmlValue(parent, nodeName, defaultValue.ToString(CultureInfo.InvariantCulture));
            float result;
            if (!float.TryParse(value, NumberStyles.Float, CultureInfo.InvariantCulture, out result))
                throw new FormatException(nodeName + " 不是有效的浮点数。");
            return result;
        }

        private static bool GetXmlBool(XmlNode parent, string nodeName, bool defaultValue)
        {
            string value = GetXmlValue(parent, nodeName, defaultValue ? "true" : "false");
            bool result;
            if (bool.TryParse(value, out result))
                return result;
            if (value == "1" || value.Equals("yes", StringComparison.OrdinalIgnoreCase))
                return true;
            if (value == "0" || value.Equals("no", StringComparison.OrdinalIgnoreCase))
                return false;
            throw new FormatException(nodeName + " 不是有效的布尔值。");
        }

        private static T ParseEnum<T>(string value, T defaultValue) where T : struct
        {
            T result;
            if (Enum.TryParse(value, true, out result) && Enum.IsDefined(typeof(T), result))
                return result;
            throw new FormatException(value + " 不是有效的 " + typeof(T).Name + " 值。");
        }

        private static void ValidateConfig(SerialConfig config)
        {
            ushort ignored;
            if (string.IsNullOrWhiteSpace(config.PortName)) throw new FormatException("PortName 不能为空。");
            if (config.BaudRate <= 0) throw new FormatException("BaudRate 必须大于 0。");
            if (config.DataBits < 5 || config.DataBits > 8) throw new FormatException("DataBits 必须在 5 到 8 之间。");
            if (config.StopBits == StopBits.None) throw new FormatException("StopBits 不能为 None。");
            if (config.SlaveAddress < 1 || config.SlaveAddress > 247) throw new FormatException("SlaveAddress 必须在 1 到 247 之间。");
            if (!TryParseHex(config.StartAddress, out ignored)) throw new FormatException("StartAddress 不是有效的十六进制地址。");
            if (config.RegisterCount < 1 || config.RegisterCount > 125) throw new FormatException("RegisterCount 必须在 1 到 125 之间。");
            if (config.SendDelay < 0 || config.ReadTimeout < 1 || config.WriteTimeout < 1) throw new FormatException("串口超时和延时参数无效。");
            if (config.MaxRetry < 0 || config.ResponseTimeout < 1) throw new FormatException("重试和响应超时参数无效。");
            if (config.ScaleFactor == 0 || float.IsNaN(config.ScaleFactor) || float.IsInfinity(config.ScaleFactor)) throw new FormatException("ScaleFactor 无效。");
        }

        private static string BytesToHex(byte[] data)
        {
            return data == null || data.Length == 0 ? "(空)" : string.Join(" ", data.Select(b => b.ToString("X2")));
        }

        private void OnConnectionChanged(bool value) { try { ConnectionChanged?.Invoke(this, value); } catch { } }
        private void OnOxygenValueReceived(float value) { try { OxygenValueReceived?.Invoke(this, value); } catch { } }
        private void OnDeviceAddressReceived(ushort value) { try { DeviceAddressReceived?.Invoke(this, value); } catch { } }
        private void OnRawFrameReceived(byte[] value) { try { RawFrameReceived?.Invoke(this, value); } catch { } }
        private void OnLog(string value) { try { LogMessage?.Invoke(this, value); } catch { } }
        private void OnError(Exception value) { try { ErrorOccurred?.Invoke(this, value); } catch { } }
        private void OnTimeoutOccurred() { try { TimeoutOccurred?.Invoke(this, EventArgs.Empty); } catch { } }
    }
}
