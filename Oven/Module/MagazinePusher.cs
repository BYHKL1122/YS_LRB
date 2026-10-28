using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YS_6000.Framework;
namespace YS_6000.Module
{
    class MagazinePusher : BaseModule
    {

        public Input inJam;
        public Input inLFDetect;


        public Motor MPX;

        public MagazinePusher(string name, String display, int prefix) : base(name, display, prefix)
        {

        }


        public int m_StartPosition = 0;
        public int m_EndPosition = 0;

        public override Boolean loadParameter()
        {

            readParameter("StartPosition", ref m_StartPosition);
            readParameter("EndPosition", ref m_EndPosition);

            return true;
        }

        public override Boolean saveParameter()
        {

            writeParameter("StartPosition", m_StartPosition);
            writeParameter("EndPosition", m_EndPosition);

            return true;
        }
        enum Location
        {
            UNKNOWN,
            START,
            END
        }

        private Location m_Location = Location.UNKNOWN;
        public Boolean isUnknown() { return m_Location == Location.UNKNOWN; }
        public Boolean isStart() { return (m_Location == Location.START); }
        public Boolean isEnd() { return (m_Location == Location.END); }


        Boolean waitForMotors()
        {
            if (MPX != null && !MPX.waitForMotor())
            {
                setErrorMessage(AL_MotorMoveError, MPX.Name, MPX.stopReason);
                m_Location = Location.UNKNOWN;
                fwInitialized = false;
                return false;
            }
            return true;
        }
        public Boolean isLFDetect()
        {
            if(inLFDetect != null)
            {
                if (MainFrame.dryRun)
                    return inLFDetect.m_State;
                return inLFDetect.getLogical();

            }
            return false;
        }
        public Boolean isJam()
        {
            if (inJam != null)
            {
                return inJam.getLogical();
            }
            return false;
        }


        public Boolean setStartPosition(int nValue)
        {
            m_StartPosition = nValue;
            if (fwInitialized && isStart())
            {
                if (!MPX.MoveAbs(m_StartPosition)) return false;
            }
            return true;
        }

        public Boolean setEndPosition(int nValue)
        {
            m_EndPosition = nValue;
            if (fwInitialized && isEnd())
            {
                if (!MPX.MoveAbs(m_EndPosition)) return false;
            }
            return true;
        }
        public virtual Boolean safetyCheck()
        {
            return true;
        }
        public Boolean gotoStart()
        {
            if (!isInitialized()) return false;
            if (!safetyCheck()) return false;
            if (!MPX.MoveAbs(m_StartPosition)) return false;
            m_Location = Location.START;
            return true;
        }

        public Boolean gotoEnd(Boolean bWait = true)
        {
            ClearError();
            if (!isInitialized()) return false;
            if (!safetyCheck()) return false;
            if (!MPX.startMoveAbs(m_EndPosition)) return false;
            if (bWait)
            {

                if (!waitForMotors()) return false;
            }
            m_Location = Location.END;
            return true;
        }

        public override bool Initialize()
        {
            base.Initialize();
            ClearError();
            m_Location = Location.UNKNOWN;



            if (!MPX.HomeORG()) return false;


            fwInitialized = true;
            gotoStart();
            inLFDetect.m_State = false;    // dryrun


            return true;

        }

        public virtual Boolean UnloadFrame()
        {

            ClearError();

            return false;
        }

        #region ------------- Alarm Code -------------------
        //------------------------------------------
        public const int AL_NotInitialized = 001;
        public const int AL_MotorHomingError = 002;
        public const int AL_MotorMoveError = 003;
        public const int AL_UnloadLFFail = 004;
        public const int AL_MOnotReady = 005;
        public const int AL_SBFDAtUnsafeLocation = 006;

        #endregion
    }
}
