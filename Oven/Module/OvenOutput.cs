using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Framework;

namespace YS_6000.Module
{
    class OvenOutput : BaseModule
    {
        public Input inJamLFDetect;

        public Input inUp;
        public Input inDown;
        public Output outZ;
        public AirCylinder Z;

        public Input inOpen;
        public Input inClose;
        public Output outClamp;
        public AirCylinder CLAMP;


        public Motor OOX;
        public Request reqUnloadFar;
        public Request reqUnloadNear;


        public OvenOutput(string name, String display, int prefix) : base(name, display, prefix)
        {


        }

        // parameters and local vairables
        public int m_UnloadDelay = 500;
        public int m_DownDelay = 300;
        public int m_Start1Position = 0;
        public int m_Start2Position = 0;
        public int m_End1Position = 0;
        public int m_End2Position = 0;

        public override Boolean loadParameter()
        {
            readParameter("UnloadDelay", ref m_UnloadDelay);
            readParameter("DownDelay", ref m_DownDelay);
            readParameter("Start1Position", ref m_Start1Position);
            readParameter("Start2Position", ref m_Start2Position);
            readParameter("End1Position", ref m_End1Position);
            return true;
        }

        public override Boolean saveParameter()
        {
            writeParameter("UnloadDelay", m_UnloadDelay);
            writeParameter("DownDelay", m_DownDelay);
            writeParameter("Start1Position", m_Start1Position);
            writeParameter("Start2Position", m_Start2Position);
            writeParameter("End1Position", m_End1Position);
            return true;
        }

        enum Location
        {
            UNKNOWN,
            START1,
            START2,
            END1,
            END2,
        };

        private Location m_Location = Location.UNKNOWN;
        public Boolean isUnknown() { return (m_Location == Location.UNKNOWN) && OOX.isCommandStop(); }
        public Boolean isStart1() { return (m_Location == Location.START1) && OOX.isCommandStop(); }

        public Boolean isStart2() { return (m_Location == Location.START2 && OOX.isCommandStop()); }
        public Boolean isEnd1() { return (m_Location == Location.END1 && OOX.isCommandStop()); }

        public Boolean isEnd2() { return (m_Location == Location.END2 && OOX.isCommandStop()); }




        public Boolean isUp()
        {
            if(inUp != null)
            {
                return inUp.getLogical();
            }
            return false;
        }
        public Boolean isDown()
        {
            if (inDown != null)
            {
                return inDown.getLogical();
            }
            return false;
        }

        public Boolean isOpen()
        {
            if (inOpen != null)
            {
                return inOpen.getLogical();
            }
            return false;
        }
        public Boolean isClose()
        {
            if (inClose != null)
            {
                return inClose.getLogical();
            }
            return false;
        }


        public Boolean setStart1Position(int nValue)
        {
            m_Start1Position = nValue;
            if (fwInitialized && isStart1())
            {
                if(OOX != null)
                {
                    if(!OOX.MoveAbs(m_Start1Position)) return false;
                }
            }
            return true;
        }
        public Boolean setStart2Position(int nValue)
        {
            m_Start2Position = nValue;
            if (fwInitialized && isStart2())
            {
                if (OOX != null)
                {
                    if (!OOX.MoveAbs(m_Start2Position)) return false;
                }
            }
            return true;
        }
        public Boolean setEnd1Position(int nValue)
        {
            m_End1Position = nValue;
            if (fwInitialized && isEnd1())
            {
                if (OOX != null)
                {
                    if (!OOX.MoveAbs(m_End1Position)) return false;
                }
            }
            return true;
        }
        public Boolean setEnd2Position(int nValue)
        {
            m_End2Position = nValue;
            if (fwInitialized && isEnd2())
            {
                if (OOX != null)
                {
                    if (!OOX.MoveAbs(m_End2Position)) return false;
                }
            }
            return true;
        }


        public Boolean Down()
        {
            ClearError();
            if(Z != null)
            {
                return Z.PushOut(AL_DownError);
            }
            return true;
        }

        public Boolean Up()
        {
            ClearError();
            if (Z != null)
            {
                return Z.PullBack(AL_UpError);
            }
            return true;
        }

        public Boolean Close()
        {
            ClearError();
            if (outClamp != null)
            {
                outClamp.setOff();
                if (!inOpen.WaitForNegative(5000))
                {
                    setErrorMessage(AL_CloseError);
                    return false;
                }
            }
            return true;
        }
        public Boolean Open()
        {
            ClearError();
            if (outClamp != null)
            {
                outClamp.setOn();
                if (!inOpen.WaitFor(4000))
                {
                    setErrorMessage(AL_OpenError);
                    return false;
                }
            }
            return true;
        }
        public Boolean gotoStart1(Boolean bArmUp = true)
        {
            ClearError();
            if (!isInitialized()) return false;
            if (bArmUp && !Up()) return false;
            m_Location = Location.START1;
            if (OOX != null)
            {
                if (!OOX.MoveAbs(m_Start1Position)) return false;
            }


            return true;
        }

        public Boolean gotoStart2(Boolean bArmUp = true)
        {
            ClearError();
            if (!isInitialized()) return false;
            if (bArmUp && !Up()) return false;
            m_Location = Location.START2;
            if (OOX != null)
            {
                if (!OOX.MoveAbs(m_Start2Position)) return false;
            }

            return true;
        }
        public Boolean gotoEnd1(Boolean bArmUp = true)
        {
            ClearError();
            if (!isInitialized()) return false;
            if (!safetyCheck()) return false;
            if (bArmUp && !Up()) return false;
            m_Location = Location.END1;
            if (OOX != null)
            {
                if (!OOX.MoveAbs(m_End1Position, OOX.SlowSpeed)) return false;
            }

            return true;
        }


        public Boolean gotoEnd2(Boolean bArmUp = true)
        {
            ClearError();
            if (!isInitialized()) return false;
            if (!safetyCheck()) return false;
            if (bArmUp && !Up()) return false;
            m_Location = Location.END2;
            if (OOX != null)
            {
                if (!OOX.MoveAbs(m_End2Position, OOX.SlowSpeed)) return false;
            }
     
            return true;
        }

        public override bool Initialize()
        {
            base.Initialize();
            ClearError();
            m_Location = Location.UNKNOWN;
            if (!Up()) return false;
            if (OOX != null && !OOX.HomeORG())
            {
                setErrorMessage(AL_MotorHomingError, OOX.Name, OOX.stopReason);
                return false;
            }

            fwInitialized = true;
            gotoStart1();
            return true;

        }

        public virtual Boolean safetyCheck()
        {
            return true;
        }


        public virtual Boolean UnloadFar()
        {
            return false;
        }

        public virtual Boolean UnloadNear()
        {
            return false;
        }

        #region ------------- Alarm Code -------------------
        //------------------------------------------
        public const int AL_NotInitialized = 001;
        public const int AL_MotorHomingError = 002;
        public const int AL_MotorMoveError = 003;
        public const int AL_UpError = 004;
        public const int AL_DownError = 005;
        public const int AL_OVisNotDownNoAction = 006;
        public const int AL_OVUnLoadNearFail = 007;
        public const int AL_OVUnLoadFarFail = 008;

        public const int AL_OpenError = 014;
        public const int AL_CloseError = 015;

        public const int AL_OOTHasUpSBNoLoad = 020;
        public const int AL_OOTAtStart = 021;


        #endregion
    }
}
