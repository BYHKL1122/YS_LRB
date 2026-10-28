using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using YSOS.Framework;
using YSOS.Module;
namespace YSOS.RunThread
{
    class PickPlace4 : PickPlace
    {
        public PickPlace4(string name, String display, int prefix) : base(name, display, prefix)
        {

            outZ = new Output("PP4_Z");
            inUp = new Input("PP4_Up");
            inDown = new Input("PP4_Down");
            Z = new AirCylinder(this, outZ, inUp, inDown);

            outVacuum1 = new Output("PP4_Vacuum");

            inLFDetect1 = new Input("PP4_LFDetect1");

            outClamp = null;
            inOpen = null;
            inClose = null;
            CLAMP = null;





            PPX = Motor.ioFindName("PP4");
            PPX.Creater = this;
            PPX.AlCode = (int)AL_MotorMoveError;

            PPZ = null;

            reqPick = new Request(this, "reqPick");
            reqPlace = new Request(this, "reqPlace");



        }
        public override Boolean safetyCheck()
        {
            StackTrace stackTrace = new StackTrace();
            if (Global.SBRD.isPlace())
            {
                setErrorMessage(AL_SBRDnotAtPicknoPlace, stackTrace.GetFrame(1).GetMethod().ToString(), "");
                return false;
            }
            return true;
        }

        public override Boolean PickLF()
        {
            Boolean flag1 = false;

            ClearError();

            if (isLFDetect1())
            {
                VacuumOn();
                setErrorMessage(AL_HasLF_noPick);
                return false;
            }
            if (Global.WH3.isUnload())
            {
                flag1 = Global.WH3.isLFDetect1();
            }

            if (!Up()) return false;
            if (!gotoPick()) return false;
            if (!Down()) return false;
            Global.WH3.VacuumOff();
            if (!MainFrame.dryRun) VacuumOn();
            Sleep(m_VacuumDelay);
            if (!Up()) return false;
            Sleep(200);
            inLFDetect1.m_State = Global.WH3.inLFDetect1.m_State;   // dryrun      
            Global.WH3.inLFDetect1.m_State = false;
            if ((flag1 && !isLFDetect1()) || Global.WH3.isLFDetect1())
            {
                Sleep(100);
                if ((flag1 && !isLFDetect1()) || Global.WH3.isLFDetect1())
                {
                    VacuumOff();
                    setErrorMessage(AL_PickFail);
                    return false;
                }
            }
            m_LFDetect1 = true;
            return true;
        }

        public override Boolean PlaceLF()
        {
            Boolean flag = isLFDetect1();

            ClearError();

            if (!isInitialized()) return false;

            if (flag && !Global.OIT.isLeftSBDetect())
            {
                setErrorMessage(AL_OIANohasTraynoPlace);
                return false;
            }
            if (flag && Global.OIT.m_HasDownFrame)
            {
                setErrorMessage(AL_OIAhasLFnoPlace);
                return false;
            }
            if (!safetyCheck()) return false;
            if (!Up()) return false;
            if (!gotoPlace()) return false;
            if (!Down()) return false;
            VacuumOff();
            m_LFDetect1 = false;
            Sleep(m_PurgeDelay);
            if (!Up()) return false;
            inLFDetect1.m_State = false;   // dryrun
            if (flag)
                Global.OIT.m_HasDownFrame = true;
            for (int i = 0; i < 3; i++)
            {
                if (!isLFDetect1()) return true;
                Sleep(100);
            }
            setErrorMessage(AL_PlaceFail);
            return false;

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
                    if (!gotoStandby())
                    {
                        rtState = RunThreadState.ALARM;
                        continue;
                    }
                    m_LFDetect1 = isLFDetect1();
                    reqRelease.Done();
                }
                //----------- hold
                if (reqHold.isSet())
                {
                    reqHold.Doing();

                    gotoStandby();
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

                if (m_LFDetect1 && !isLFDetect1())
                {
                    setErrorMessage(AL_LF_Drop);
                    if (isRunning())
                        rtState = RunThreadState.ALARM;
                    m_LFDetect1 = isLFDetect1();
                    continue;
                }
                //------------------------------------------------------
                if (isStop() || isAlarm()) continue;
                //------------------------------------------------------

                if (reqPick.isSet() && !isLFDetect1())
                {
                    reqPick.Doing();
                    if (!PickLF())
                    {
                        rtState = RunThreadState.ALARM;
                        continue;
                    }
                    reqPick.Done();
                    if (!gotoStandby())
                    {
                        rtState = RunThreadState.ALARM;
                        continue;
                    }
                }

                if (isLFDetect1() && Global.OIT.isLeftSBDetect() && !Global.OIT.m_HasDownFrame && Global.SBRD.isPick())
                {
                    reqPlace.Doing();
                    if (!PlaceLF())
                    {
                        rtState = RunThreadState.ALARM;
                        continue;
                    }
                    reqPlace.Done();
                    if (!gotoPick())
                    {
                        rtState = RunThreadState.ALARM;
                        continue;
                    }
                    continue;
                }

            }

        }  // while

        #region ------------- Alarm Code -------------------
        //------------------------------------------
        public const int AL_OIANohasTraynoPlace = 401;
        public const int AL_OIAhasLFnoPlace = 402;
        public const int AL_SBRDnotAtPicknoPlace = 403;
        #endregion 
    }

}
