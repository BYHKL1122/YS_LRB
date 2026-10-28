using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YSOS.Framework;
using YSOS.Module;
namespace YSOS.RunThread
{
    class Trimmer1 : Trimmer
    {

        public Trimmer1(string name, String display, int prefix) : base(name, display, prefix)
        {
            inReelPresent = new Input("TM_ReelPresent");
            inMisAligned = new Input("TM_MisAligned");
            inCanJam = new Input("TM_CanJam");
            inCanPresent = new Input("TM_CanPresent");


            TM = Motor.ioFindName("TM");
            TM.Creater = this;
            TM.AlCode = (int)AL_TM_MoveError;

            FD = Motor.ioFindName("FD");
            FD.Creater = this;
            FD.AlCode = (int)AL_FD_MoveError;
        }

        public void runThread()
        {

            while (!evtEnd.WaitOne(10))
            {

                //--------- release event
                if (reqRelease.isSet())
                {
                    rtState = RunThreadState.RUNING;
                    reqRelease.Doing();


                    //if (!Common.dryRun && !MainFrame.PreHeaterOnly && !MainFrame.transferOnly)
                    //{
                    //    if (!isWheelDown())
                    //    {
                    //        setErrorMessage(AL_WheelNoAtDown);
                    //        rtState = RunThreadState.ALARM;
                    //        continue;
                    //    }
                    //}
                    if (!gotoFeed())
                    {
                        rtState = RunThreadState.ALARM;
                        continue;
                    }
                    m_CanFullCount = 0;
                    reqRelease.Done();
                }
                //----------- hold
                if (reqHold.isSet())
                {
                    reqHold.Doing();
                    if (isAlarm()) fwIsError = true;
                    rtState = RunThreadState.STOP;
                    reqHold.Done();
                }
                //----------- initialize
                if (reqInit.isSet())
                {
                    reqInit.Doing();
                    //rtState = RunThreadState.INITIALIZING;

                    Initialize();
                    reqInit.Done();
                }

                if (isStop() || isAlarm() || MainFrame.transferOnly || !Global.BH2.fwEnable) continue;



                if (m_TrimCount >= m_TrimLimit && m_TrimLimit > 0)
                {
                    setErrorMessage(AL_TrimUsedCount);
                    rtState = RunThreadState.ALARM;
                    continue;
                }

                if (m_FullCount >= m_FullLimit && m_FullLimit > 0)
                {
                    setErrorMessage(AL_CanFull);
                    rtState = RunThreadState.ALARM;
                    continue;
                }

                if (!isCanPresent())
                {
                    if (!m_CanPresentLatch)
                    {
                        m_CanPresentLatch = true;
                        setWarnMessage(AL_ReelPresent);
                    }
                }
                else
                {
                    m_CanPresentLatch = false;
                }

                if (isCanJam())
                {
                    if (!m_CanFullLatch)
                    {
                        m_CanFullLatch = true;
                        setWarnMessage(AL_ReelPresent);
                    }
                }
                else
                {
                    m_CanFullLatch = false;

                }

                if (!m_nextClipReady)
                {
                    if (!Down_Feed())
                    {
                        m_nextClipReady = true;
                        rtState = RunThreadState.ALARM;
                        continue;
                    }
                    m_nextClipReady = true;
                    m_TrimCount++;
                    continue;
                }



            }
            gotoFeed();
        }


    }
}
