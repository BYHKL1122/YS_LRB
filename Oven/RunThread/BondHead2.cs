using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YSOS.Framework;
using YSOS.Module;
namespace YSOS.RunThread
{
    class BondHead2 : BondHead
    {
        public BondHead2(string name, String display, int prefix) : base(name, display, prefix)
        {
            inSensor1 = new Input("BH2_DieSensor1");
            inSensor2 = new Input("BH2_DieSensor2");


            outVacuum1 = new Output("BH2_Vacuum1");
            outVacuum2 = new Output("BH2_Vacuum2");

            outPurge1 = new Output("BH2_Purge1");
            outPurge2 = new Output("BH2_Purge2");

            inUp1 = new Input("BH2_Z1UP");
            inUp2 = new Input("BH2_Z2UP");
            outBHCL1 = new Output("BH2_Z1");
            outBHCL2 = new Output("BH2_Z2");


            BHCL1 = new AirCylinder(this, outBHCL1, inUp1);
            BHCL2 = new AirCylinder(this, outBHCL2, inUp2);

            BHY = Motor.ioFindName("BH2Y");
            BHY.Creater = this;
            BHY.AlCode = (int)AL_BHY_MoveError;
            BHZ = Motor.ioFindName("BH2Z");
            BHZ.Creater = this;
            BHZ.AlCode = (int)AL_BHZ_MoveError;


            doneArray = new Boolean[1];
            clearDone();
            reqPlace = new Request(this, "reqPlace");
  

            m_DieName = "跳线";

        }

        public override Boolean PickDie()
        {
            ClearError();


            if (!isInitialized()) return false;

            if (isSensor1() || isSensor2())
            {
                setErrorMessage(AL_DieSensorOn);
                return false;
            }
            if (!MainFrame.dryRun)
            {
                VacuumOn(0);
                PurgeOff(0);
            }
            if (!gotoPick()) return false;
            Sleep(m_GotoPickDelay);
            if (!Global.TM1.gotoTrim())return false;

            Sleep(m_VacuumDelay);
            if (!BHZ.MoveAbs(m_SetPosition.Z)) return false;
            m_Location = Location.PICKUP;
            inSensor1.m_State = true;
            inSensor2.m_State = true;
            if (!isSensor1() || !isSensor2())
            {
                Sleep(200);
                if (!isSensor1() || !isSensor2())
                {
                    m_PickFailCount++;
                    if (m_PickFailCount >= 1 || isHolding())
                    {
                        if (!gotoSet()) return false;
                        setErrorMessage(AL_PickFail);
                        return false;
                    }
                }
                else
                    m_PickFailCount = 0;
            }
            else
                m_PickFailCount = 0;

            return true;
        }

        public override Boolean PlaceDie(int no)
        {
            ClearError();

            if (no == 2)
            {
                if (!gotoPlace2()) return false;
            }
            else
            {
                if (!gotoPlace1()) return false;
            }

            Sleep(m_GotoPlaceDelay);
            VacuumOff(1);
            PurgeOn(1);
            Sleep(m_PurgeDelay);

            inSensor1.m_State = false;
            inSensor2.m_State = false;
            if (!BHZ.MoveAbs(m_SetPosition.Z)) return false;
            m_Location = Location.PLACEUP;

            for (int i = 0; i < 3; i++)
            {
                if (!isSensor1() && !isSensor2()) return true;
                Sleep(100);
            }
            setErrorMessage(AL_PlaceFail);
            return false;
        }
        public void runThread()
        {

            WH = Global.WH4;

            while (!evtEnd.WaitOne(1))
            {

                //--------- release event
                if (reqRelease.isSet())
                {
                    rtState = RunThreadState.RUNING;
                    reqRelease.Doing();

                    if (!gotoSet())
                    {
                        rtState = RunThreadState.ALARM;
                        continue;
                    }

                    if (m_PickFailCount > 0 && !isSensor1() && !MainFrame.transferOnly)
                    {
                        if (!DropOut())
                        {
                            rtState = RunThreadState.ALARM;
                            continue;
                        }
                        Global.TM1.m_nextClipReady = false;
                    }
                    m_PickFailCount = 0;
                    if (!gotoSet())
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
                    gotoSet();
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

                if (isStop() || isAlarm() || MainFrame.transferOnly || !fwEnable || MainFrame.PreHeaterOnly) continue;




                //--------- Move buffer for align
                if (!isSensor1() && !noMore() && WH.isLFDetect1())
                {
                    if (Global.TM1.m_nextClipReady && !Global.TM1.isMisAligned())
                    {
                        if (!PickDie())
                        {
                            rtState = RunThreadState.ALARM;
                            continue;
                        }
                        m_PickCount++;
                        Global.TM1.m_nextClipReady = false;
                    }
                    continue;
                }
                //---------------------------------------------
                if (!reqPlace.isDone() && isSensor1())
                {
                    reqPlace.Doing();
                    if (!doneArray[0])
                    {
                        if (!PlaceDie(1))
                        {
                            rtState = RunThreadState.ALARM;
                            continue;
                        }
                        m_DieCount = m_DieCount + 12;
                        doneArray[0] = true;
                    }
                    if (allDone())
                    {
                        reqPlace.Done();
                        continue;
                    }
                    continue;

                }
                //------------------
                if (WH.Indexer.endofIndex && !gotoSet())
                {
                    rtState = RunThreadState.ALARM;
                    continue;
                }
            }  //--- while
        }
    }
}
