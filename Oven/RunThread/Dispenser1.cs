using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YSOS.Framework;
using YSOS.Module;
namespace YSOS.RunThread
{
    class Dispenser1 : Dispenser
    {

        public Dispenser1(string name, String display, int prefix) : base(name, display, prefix)
        {
            inDone1 = new Input("DP_Done1");
            inDone2 = new Input("DP_Done2");


            //inPasteDetect1 = new Input("DP_PasteDetect1");
            //inPasteDetect2 = new Input("DP_PasteDetect2");

            outOn1 = new Output("DP_On1");
            outOn2 = new Output("DP_On2");

            DPZ = Motor.ioFindName("DPZ");
            DPZ.Creater = this;
            DPZ.AlCode = (int)AL_DPZ_MoveError;


            reqDispense = new Request(this, "reqDispense");
        }

        public void runThread()
        {


            while (!evtEnd.WaitOne(1))
            {

                //--------- release event
                if (reqRelease.isSet())
                {
                    rtState = RunThreadState.RUNING;
                    reqRelease.Doing();
                    DP_Off(0);

                    if (!gotoStandby())
                    {
                        rtState = RunThreadState.ALARM;
                        continue;
                    }
                    reqRelease.Done();

                }
                //----------- hold
                if (reqHold.isSet())
                {
                    reqHold.Doing();
                    DP_Off(0);

                    gotoUp();
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
                //------------
                if (isStop() || isAlarm() || MainFrame.transferOnly || !fwEnable) continue;

                //=============================================

                if (isDispensLimit())
                {
                    rtState = RunThreadState.ALARM;
                    continue;
                }
                if (reqDispense.isSet())
                {
                    reqDispense.Doing();
                    if (!Dispense(0))
                    {
                        rtState = RunThreadState.ALARM;
                        continue;
                    }
                    m_DisCount++;
                    reqDispense.Done();
                }
            }
        }

    }
}
