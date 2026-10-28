using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YSOS.Framework;

namespace YSOS.Module
{
    class Dispenser : BaseModule
    {
        // IO

        public Input inDone1;
        public Input inDone2;


        public Input inPasteDetect1;
        public Input inPasteDetect2;

        public Output outOn1;
        public Output outOn2;

        public Motor DPZ;


        public Boolean m_PasteDetect = true;

        public int m_DisCount = 0;
        public int m_DisLimit = 20;

        public Request reqDispense;
        public Dispenser(string name, String display, int prefix) : base(name, display, prefix)
        {



        }
        public Boolean isPasteDetect1()
        {
            if (MainFrame.dryRun|| !m_PasteDetect) return true;
            return inPasteDetect1.getLogical();

        }

        public Boolean isPasteDetect2()
        {
            if (MainFrame.dryRun || !m_PasteDetect) return true;
            return inPasteDetect2.getLogical();

        }
        public Boolean isDP_Done1()
        {
            if(MainFrame.dryRun) return true;
            return inDone1.getLogical();
        }
        public Boolean isDP_Done2()
        {
            if (MainFrame.dryRun) return true;
            return inDone2.getLogical();
        }

        public Boolean isDP_On1()
        {
            return outOn1.getState();
        }

        public Boolean isDP_On2()
        {
            return outOn2.getState();
        }

        public void DP_On(int no)
        {
            switch (no)
            {
                case 0:
                    outOn1.setOn();
                    outOn2.setOn();
                    break;
                case 1:
                    outOn1.setOn();
                    break;
                case 2:
                    outOn2.setOn();
                    break;
            }

        }

        public void DP_Off(int no)
        {
            switch (no)
            {
                case 0:
                    outOn1.setOff();
                    outOn2.setOff();
                    break;
                case 1:
                    outOn1.setOff();
                    break;
                case 2:
                    outOn2.setOff();
                    break;
            }

        }

        // Parameters
        public int m_DownDelay = 100;
        public int m_DispenseDelay = 100;
        public int m_StandbyPosition = 0;
        public int m_UpPosition = 0;
        public int m_Down1Position = 0;
        public int m_Down2Position = 0;

        public int m_First1Position = 0;
        public int m_First2Position = 0;
        public float m_SingleWidth = 0;


        // location
        enum Location
        {
            UNKNOWN,
            STANDBY,
            UP,
            DOWN
        };

        private Location m_Location = Location.UNKNOWN;
        public Boolean isUnknown() { return (m_Location == Location.UNKNOWN); }
        public Boolean isStandby() { return (m_Location == Location.STANDBY) && DPZ.isCommandStop(); }
        public Boolean isUp() { return (m_Location == Location.UP) && DPZ.isCommandStop(); }
        public Boolean isDown() { return (m_Location == Location.DOWN) && DPZ.isCommandStop(); }


 



        public override Boolean loadParameter()
        {
            readParameter("DownDelay", ref m_DownDelay);
            readParameter("DispenseDelay", ref m_DispenseDelay);
            readParameter("StandbyPosition", ref m_StandbyPosition);
            readParameter("UpPosition", ref m_UpPosition);
            readParameter("Down1Position", ref m_Down1Position);
            readParameter("Down2Position", ref m_Down2Position);
            readParameter("DisLimit", ref m_DisLimit);
            return true;
        }

        public override Boolean saveParameter()
        {
            writeParameter("DownDelay", m_DownDelay);
            writeParameter("DispenseDelay", m_DispenseDelay);
            writeParameter("StandbyPosition", m_StandbyPosition);
            writeParameter("UpPosition", m_UpPosition);
            writeParameter("Down1Position", m_Down1Position);
            writeParameter("Down2Position", m_Down2Position);
            writeParameter("DisLimit",  m_DisLimit);
            return true;
        }

        Boolean waitForMotors()
        {
            if (!DPZ.waitForMotor())
            {
                DPZ.stopMove();
                setErrorMessage(AL_DPZ_MoveError, DPZ.Name, DPZ.stopReason);
                m_Location = Location.UNKNOWN;
                fwInitialized = false;
                return false;
            }
            return true;
        }

        public Boolean setStandbyPosition(int nValue)
        {
            m_StandbyPosition = nValue;
            if (fwInitialized && isStandby())
            {
                if (!DPZ.MoveAbs(m_StandbyPosition)) return false;
            }
            return true;
        }

        public Boolean setUpPosition(int nValue)
        {
            m_UpPosition = nValue;
            if (fwInitialized && isUp())
            {
                if (!DPZ.MoveAbs(m_UpPosition)) return false;
            }
            return true;
        }


        public Boolean setDown1Position(int nValue)
        {
            m_Down1Position = nValue;
            if (fwInitialized && isDown())
            {
                if (!DPZ.MoveAbs(m_Down1Position)) return false;
            }
            return true;
        }






        public Boolean gotoStandby()
        {
            ClearError();
            if (!isInitialized()) return false;
 
            if (!DPZ.MoveAbs(m_StandbyPosition)) return false;
            m_Location = Location.STANDBY;
            return true;
        }

        public Boolean gotoUp()
        {
            ClearError();
            if (!isInitialized()) return false;
        
            if (!DPZ.MoveAbs(m_UpPosition)) return false;
            m_Location = Location.UP;
            return true;
        }

        public Boolean gotoDown()
        {
            ClearError();
            if (!isInitialized()) return false;

           
            if (!DPZ.MoveAbs(m_Down1Position)) return false;
            m_Location = Location.DOWN;
            return true;
        }
















        public override Boolean Initialize()
        {
            base.Initialize();
            ClearError();
            DP_Off(0);
            if (!DPZ.HomeORG()) return false;
            fwInitialized = true;
            if (!gotoStandby()) return false;
            return true;
        }

        public Boolean Dispense(int station)
        {
            ClearError();

            if ((station == 0 || station == 1) && isDP_On1()) DP_Off(1);
            if ((station == 0 || station == 2) && isDP_On2()) DP_Off(2);

            if (!gotoDown()) return false;

            Sleep(m_DownDelay);

            if (station == 0 || station == 1) DP_On(1);
            if (station == 0 || station == 2) DP_On(2);
            if (station == 0 || station == 1)
            {
       
                inDone1.WaitFor(3000);
                if (!isDP_Done1())
                {
                    DP_Off(0);
                    gotoUp();
                    setErrorMessage(AL_DP1NoResponse);
                    return false;
                }
            }
            if (station == 0 || station == 2)
            {
      
                 inDone2.WaitFor(3000);
                if (!isDP_Done2())
                {
                    DP_Off(0);
                    gotoUp();
                    setErrorMessage(AL_DP2NoResponse);
                    return false;
                }
            }
            DP_Off(0);
            Sleep(m_DispenseDelay);
            gotoStandby();
            return true;
        }



        public Boolean isDispensLimit()
        {
            if (m_DisCount >= m_DisLimit && m_DisLimit > 0)
            {
                setErrorMessage(AL_DispenserLimit);
                return false;
            }
            return true;
        }


        //===================================================





        #region ------------- Alarm Code -------------------
        //------------------------------------------
        public const int AL_NotInitialized = 001;
        public const int AL_DPZ_HomingError = 002;
        public const int AL_DPZ_MoveError = 003;
        public const int AL_DP1NoResponse = 004;
        public const int AL_DP2NoResponse = 005;
        public const int AL_HasNoDispenser = 006;
        public const int AL_DispenserLimit = 007;

        #endregion 

    }

}
