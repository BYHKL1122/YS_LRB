using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YSOS.Module;

namespace YSOS.UserInterface
{
    public partial class frmClipReel : frmBaseDialog
    {
        ClipReel obj;

        public frmClipReel()
        {
            InitializeComponent();
            obj = Global.CL1;
            OperateControls(this);
        }


        private void btnInitialize_Click(object sender, EventArgs e)
        {
            obj.Initialize();
        }



        private void btnReleaseDelayUp_Click(object sender, EventArgs e)
        {

            obj.m_ReleaseDelay += 1;

        }

        private void btnReleaseDelayDown_Click(object sender, EventArgs e)
        {

            obj.m_ReleaseDelay -= 1;

            if (obj.m_ReleaseDelay < 0) obj.m_ReleaseDelay = 0;

        }



        private void btnReleaseReel_Click(object sender, EventArgs e)
        {

            obj.ReleaseReel();

        }

        private void btnSpacerRoll_Click(object sender, EventArgs e)
        {

            obj.SpacerRoll();

        }

        private void btnReelTimeOutUp_Click(object sender, EventArgs e)
        {
            obj.m_ReelTimeOut += 1;
        }

        private void btnReelTimeOutDown_Click(object sender, EventArgs e)
        {
            obj.m_ReelTimeOut -= 1;
            if (obj.m_ReelTimeOut < 0) obj.m_ReelTimeOut = 0;

        }

        private void btnSpacerTimeOutUp_Click(object sender, EventArgs e)
        {
            obj.m_SpacerTimeOut += 1;
            if (obj.m_SpacerTimeOut < 0) obj.m_SpacerTimeOut = 0;

        }

        private void btnSpacerTimeOutDown_Click(object sender, EventArgs e)
        {

            obj.m_SpacerTimeOut -= 1;
            if (obj.m_SpacerTimeOut < 0) obj.m_SpacerTimeOut = 0;

        }



        private void btnReelOff_Click(object sender, EventArgs e)
        {
            obj.ReelOff();
        }

        private void btSpacerOff_Click(object sender, EventArgs e)
        {
            obj.SpacerOff();
        }

        private void BtnSetSpeed_Click(object sender, EventArgs e)
        {
            setSpeedButton(Speed, BtnSetSpeed);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            this.Enabled = Global.MF.isSystemRun() ? false : true;

            setLabel(lblReelStart, obj.isReelStart());
            setLabel(lblReelStop, obj.isReelStop());
            setLabel(lblSpacerUp, obj.isSpacerUp()); ;
            setLabel(lblSpacerDown, obj.isSpacerDown());
            setButton(btnInitialize, obj.fwInitialized);

            txtReelTimeOut.Text = obj.m_ReelTimeOut.ToString();
            txtSpacerTimeOut.Text = obj.m_SpacerTimeOut.ToString();
            txtReleaseDelay.Text = obj.m_ReleaseDelay.ToString();




        }
    }
}
