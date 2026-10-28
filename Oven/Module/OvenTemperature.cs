using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YS_6000.Framework;
namespace YS_6000.Module
{
    class OvenTemperature : BaseModule
    {

        public const int MAX_NO = 12;
        public OvenTemperature(string name, String display, int prefix) : base(name, display, prefix)
        {




        }
        // parameters and local vairables
        public int m_CollectDelay = 500;


        public int[] m_PV = new int[MAX_NO];
        public int[] m_SV = new int[MAX_NO];
        public int[] m_AH = new int[MAX_NO];
        public int[] m_AL = new int[MAX_NO];
        public int[] m_SC = new int[MAX_NO];



        public override Boolean loadParameter()
        {
            int i;
            String name;
            readParameter("CollectDelay", ref m_CollectDelay);

            for (i = 0; i < MAX_NO; i++)
            {
                name = String.Format("PV{0}", i);
                readParameter(name, ref m_PV[i]);
                name = String.Format("SV{0}", i);
                readParameter(name, ref m_SV[i]);
                name = String.Format("AH{0}", i);
                readParameter(name, ref m_AH[i]);
                name = String.Format("AL{0}", i);
                readParameter(name, ref m_AL[i]);
                name = String.Format("SC{0}", i);
                readParameter(name, ref m_SC[i]);
            }

            return true;
        }

        public override Boolean saveParameter()
        {
            int i;
            String name;
            writeParameter("CollectDelay", m_CollectDelay);
            for (i = 0; i < MAX_NO; i++)
            {
                name = String.Format("PV{0}", i);
                writeParameter(name,  m_PV[i]);
                name = String.Format("SV{0}", i);
                writeParameter(name,  m_SV[i]);
                name = String.Format("AH{0}", i);
                writeParameter(name,  m_AH[i]);
                name = String.Format("AL{0}", i);
                writeParameter(name,  m_AL[i]);
                name = String.Format("SC{0}", i);
                writeParameter(name,  m_SC[i]);
            }
            return true;
        }


        #region ------------- Alarm Code -------------------
        //------------------------------------------
        public const int AL_NotInitialized = 001;
        public const int AL_HomingError = 002;
        public const int AL_MoveError = 003;



        #endregion
    }
}
