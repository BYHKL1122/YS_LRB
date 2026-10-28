using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YSOS.Framework;
using YSOS.Module;
namespace YSOS.RunThread
{
    class ClipReel1 : ClipReel
    {

        public ClipReel1(string name, String display, int prefix) : base(name, display, prefix)
        {
            inReelStart = new Input("CL_ReelStart");
            inReelStop = new Input("CL_ReelStop");
            //inSpacerDown = new Input("CL_SpacerDown");
            //inSpacerUp = new Input("CL_SpacerUp");

            //outSpacer = new Output("CL_Spacer");
            outReel = new Output("CL_Reel");

        }

        public void runThread()
        {
            while (!evtEnd.WaitOne(10))
            {

                //--------- release event
                if (reqRelease.isSet())
                {
                    reqRelease.Doing();
                    rtState = RunThreadState.RUNING;

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


                if (isStop() || isAlarm() || MainFrame.transferOnly || !Global.BH1.fwEnable) continue;


                //--------------------------------------------


                if (!isReelStop() && !ReleaseReel())
                {
                    rtState = RunThreadState.ALARM;
                    continue;
                }

                //if (isSpacerDown() && !SpacerRoll())
                //{
                //    rtState = RunThreadState.ALARM;
                //    continue;
                //}
            }
        }

    }
}
