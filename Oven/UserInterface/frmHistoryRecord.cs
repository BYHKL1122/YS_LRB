using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Framework;
namespace YS_6000.UserInterface
{
    public partial class frmHistoryRecord : frmBaseDialog
    {
        DataTable dt;
        public frmHistoryRecord()
        {
            InitializeComponent();
            DateTimeChoser.AddTo(TimeStart);
            DateTimeChoser.AddTo(TimeEnd);
        }

        private void btnInquire_Click(object sender, EventArgs e)
        {
            DataTable ds = new DataTable();

            DateTime st = DateTime.Parse(TimeStart.Text);
            DateTime et = DateTime.Parse(TimeEnd.Text);


            TimeSpan ts = et - st;
            if (ts.Ticks <= 0 || ts.TotalDays > 31)
            {
                MessageBox.Show("日期选择错误，或选择时间太大(<1月)");
                return;
            }
            if (Inquire_Mode == Inquire_Alarm)
                OleDataBase.SelectDataAlarm(ref ds, st, et);
            else
                OleDataBase.SelectDataParam(ref ds, st, et);
            if (ds.Rows.Count <= 0 || ds.Rows.Count > 10000)
            {
                MessageBox.Show("查询无条目或过多，请重新选择！");
                return;
            }
            dgvHistory.DataSource = ds;
            //dgvHistory.Columns[0].Width = 50;
            //dgvHistory.Columns[1].Width = 200;
            //dgvHistory.Columns[2].Width = 100;
            //dgvHistory.Columns[3].Width = 800;
            //dgvHistory.Columns[4].Width = 200;
        }

        public Boolean dataGridViewToCSV(DataGridView dataGridView)
        {
            if (dataGridView.Rows.Count == 0)
            {
                MessageBox.Show("没有数据可以导出！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "csv files(*.csv)|!.csv";      //获取或设置当前文件名筛选器字符串，该字符串决定对话框的“另存为文件类型”或“文件类型”框中出现的选择内容。
            saveFileDialog.FilterIndex = 0;                        //获取或设置文件对话框中当前选定筛选器的索引。
            saveFileDialog.RestoreDirectory = true;                //获取或设置一个值，该值指示对话框在关闭前是否还原当前目录。
            saveFileDialog.CreatePrompt = true;                    //获取或设置一个值，该值指示如果用户指定不存在的文件，对话框是否提示用户允许创建该文件
            saveFileDialog.FileName = null;                        //获取或设置一个包含在文件对话框中选定的文件名的字符串。
            saveFileDialog.Title = "保存";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Stream stream = saveFileDialog.OpenFile();
                StreamWriter sw = new StreamWriter(stream, System.Text.Encoding.GetEncoding(-0));
                string strLine = "";
                try
                {
                    for (int i = 0; i < dataGridView.ColumnCount; i++)
                    {
                        if (i > 0)
                            strLine += "，";
                        strLine += dataGridView.Columns[i].HeaderText;
                    }
                    strLine.Remove(strLine.Length - 1);
                    sw.WriteLine(strLine);
                    strLine = "";
                    for (int j = 0; j < dataGridView.Rows.Count; j++)
                    {
                        strLine = "";
                        int colCount = dataGridView.Columns.Count;
                        for (int k = 0; k < colCount; k++)
                        {
                            if (k > 0 && k < colCount)
                                strLine += ",";
                            if (dataGridView.Rows[j].Cells[k].Value == null)
                                strLine += "";
                            else
                            {
                                string cell = dataGridView.Rows[j].Cells[k].Value.ToString().Trim();
                                cell = cell.Replace("\"", "\"\"");
                                cell = "\"" + cell + "\"";
                                strLine += cell;
                            }
                        }
                        sw.WriteLine(strLine);
                    }
                    sw.Close();
                    stream.Close();
                   // MessageBox.Show("数据被导出到：" + saveFileDialog.FileName.ToString(), "导出完毕", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "导出错误", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
            }
            return true;
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            dataGridViewToCSV(dgvHistory);
        }
    }
}
