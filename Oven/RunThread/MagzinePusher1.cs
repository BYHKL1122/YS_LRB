using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YS_6000.Module;
using YS_6000.Framework;
namespace YS_6000.RunThread
{
    class MagzinePusher1 : MagazinePusher
    {


        public MagzinePusher1(string name, String display, int prefix) : base(name, display, prefix)
        {



            inLFDetect = new Input("MP_LFDetect");
            inJam = new Input("MP_Jam");




            MPX = Motor.ioFindName("MPX");
            MPX.Creater = this;
            MPX.AlCode = (int)AL_MotorMoveError;

        }
        public override Boolean UnloadFrame()
        {

            ClearError();
            if (!isInitialized()) return false;

            Boolean flag1 = isLFDetect();
            if (flag1 && (!Global.MO.isWork() || !Global.MO.isMagOn()))
            {
                setErrorMessage(AL_MOnotReady);
                return false;
            }
            if (!safetyCheck()) return false;


            if (!gotoStart()) return false;


            if (!gotoEnd(false)) return false;
            while (!MPX.isCommandStop() && !isJam())
            {
                Sleep(1);
            }

            if (isJam())
            {
                MPX.stopMove();
                gotoStart();
                setErrorMessage(AL_UnloadLFFail);
                return false;
            }
            if (!gotoStart()) return false;
            inLFDetect.m_State = false;//dryrun
            if (isLFDetect())//
            {
                setErrorMessage(AL_UnloadLFFail);
                return false;
            }
            return true;
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
                    gotoStart();
                    reqRelease.Done();
                }
                //----------- hold
                if (reqHold.isSet())
                {
                    reqHold.Doing();
                    if (isAlarm()) fwIsError = true;
                    gotoStart();
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

                if (Global.MO.isMagOn() && Global.MO.isWork() && !Global.MO.m_EndofMagazine && Global.MO.m_gotoNextDone &&
                    isLFDetect() && (Global.SBFD.isPickLF() || Global.SBFD.isPlaceSB() || Global.SBFD.isStandby()))                    
                {
                    if (!UnloadFrame())
                    {
                        rtState = RunThreadState.ALARM;
                        continue;
                    }
                    Global.MO.m_gotoNextDone = false;
                }

                if (isStop() || isAlarm()) continue;




            }  //--- while

            rtState = RunThreadState.END;
        }


    }
}
