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
    public partial class frmClipTrimmer : frmBaseDialog
    {
        Trimmer obj;
        public frmClipTrimmer()
        {
            InitializeComponent();
            obj = Global.TM1;
            OperateControls(this);
        }

        private void btnLoadPar_Click(object sender, EventArgs e)
        {
            obj.loadParameter();
        }

        private void btnSavePar_Click(object sender, EventArgs e)
        {
            obj.saveParameter();
        }

        private void btnInitialize_Click(object sender, EventArgs e)
        {
              obj.Initialize();          
        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Enabled = Global.MF.isSystemRun() ? false : true;


            setLabel(lblMisAligned, obj.isMisAligned());
            setLabel(lblReelPresent, obj.isReelPresent());
            setLabel(lblCanJam, obj.isCanJam());
            setLabel(lblCanPresent, obj.isCanPresent());
            setButton(btnInitialize, obj.fwInitialized);
            //setButton(btnGotoTrim, obj.isTrim());
            //setButton(btnGotoReadyTrim, obj.isReadyTrim());
            //setButton(btnGotoFeed, obj.isFeed());
            //setButton(btnGotoLow, obj.isLow());


            txtFeedPosition.Text = obj.m_FeedPosition.ToString();
            txtTrimPosition.Text = obj.m_TrimPosition.ToString();
            txtReadyTrimPosition.Text = obj.m_ReadyTrimPosition.ToString();
            txtLowPosition.Text = obj.m_LowPosition.ToString();
            txtFeedDelay.Text = obj.m_FeedDelay.ToString();
            txtTMZDelay.Text = obj.m_TMZDelay.ToString();
            txtAdjustStep.Text = obj.m_AdjustStep.ToString();
            txtTrimLimit.Text = obj.m_TrimLimit.ToString();




        }






        private void btnInitializeTrimmer_Click(object sender, EventArgs e)
        {
            obj.initializeTrimmer();
        }

        private void btnInitializeFeeder_Click(object sender, EventArgs e)
        {
            DialogResult result;

            result = MessageBox.Show("归零(棘轮需上抬!!!)", "喂料归零",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
                obj.initializeFeeder();
   
        }

        private void btnGotoTrim_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            obj.gotoTrim();
            txtTrimPosition.Focus();
        }

        private void btnGotoReadyTrim_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            obj.gotoReadyTrim();
            txtReadyTrimPosition.Focus();
        }

        private void btnGotoFeed_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            obj.gotoFeed();
            txtFeedPosition.Focus();
        }

        private void btnGotoLow_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            obj.gotoLow();
            txtLowPosition.Focus();

        }

        private void btnTrimFeed_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            obj.Down_Feed();
            Cursor = Cursors.Default;
        }

        private void btnFeedClip_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            obj.FeedClip();
            Cursor = Cursors.Default;
        }

        private void btnTrimPositionUp_Click(object sender, EventArgs e)
        {
            setIntValueUp(ref obj.m_TrimPosition);
            obj.setTrimPosition(obj.m_TrimPosition);


        }

        private void btnTrimPositionDown_Click(object sender, EventArgs e)
        {
            setIntValueDown(ref obj.m_TrimPosition);
            obj.setTrimPosition(obj.m_TrimPosition);
        }

        private void btnReadyTrimPositionUp_Click(object sender, EventArgs e)
        {
            setIntValueUp(ref obj.m_ReadyTrimPosition);
            obj.setReadyTrimPosition(obj.m_ReadyTrimPosition);
     

        }

        private void btnReadyTrimPositionDown_Click(object sender, EventArgs e)
        {
            setIntValueDown(ref obj.m_ReadyTrimPosition);
            obj.setReadyTrimPosition(obj.m_ReadyTrimPosition);

        }

        private void btnFeedPositionUp_Click(object sender, EventArgs e)
        {
            setIntValueUp(ref obj.m_FeedPosition);
            obj.setFeedPosition(obj.m_FeedPosition);
        }

        private void btnFeedPositionDown_Click(object sender, EventArgs e)
        {
            setIntValueDown(ref obj.m_FeedPosition);
            obj.setFeedPosition(obj.m_FeedPosition);
        }

        private void btnLowPositionUp_Click(object sender, EventArgs e)
        {
            setIntValueUp(ref obj.m_LowPosition);
            obj.setLowPosition(obj.m_LowPosition);
        }

        private void btnLowPositionDown_Click(object sender, EventArgs e)
        {
            setIntValueDown(ref obj.m_LowPosition);
            obj.setLowPosition(obj.m_LowPosition);
        }

        private void btnAdjustStepUp_Click(object sender, EventArgs e)
        {
            setIntValueUp(ref obj.m_AdjustStep);
            obj.setAdjustStep(obj.m_AdjustStep);
        }

        private void btnAdjustStepDown_Click(object sender, EventArgs e)
        {
            setIntValueDown(ref obj.m_AdjustStep);
            obj.setAdjustStep(obj.m_AdjustStep);
        }

        private void btnFeedDelayUp_Click(object sender, EventArgs e)
        {
   
            setIntValueUp(ref obj.m_FeedDelay);
        }

        private void btnFeedDelayDown_Click(object sender, EventArgs e)
        {
            setIntValueDown(ref obj.m_FeedDelay);
        }



  

        private void btnReleaseReel_Click(object sender, EventArgs e)
        {

            Global.CL1.ReleaseReel();

        }

        private void btnSpacerRoll_Click(object sender, EventArgs e)
        {

            Global.CL1.SpacerRoll();

        }

   



        private void txtTrimLimitUp_Click(object sender, EventArgs e)
        {
            setIntValueUp(ref obj.m_TrimLimit);
        }

        private void txtTrimLimitDown_Click(object sender, EventArgs e)
        {
            setIntValueDown(ref obj.m_TrimLimit);
            if (obj.m_TrimLimit < 0) obj.m_TrimLimit = 0;
        }





        private void txtTMZDelayUp_Click(object sender, EventArgs e)
        {
            setIntValueUp(ref obj.m_TMZDelay);
        }

        private void txtTMZDelayDown_Click(object sender, EventArgs e)
        {
            setIntValueDown(ref obj.m_TMZDelay);
        }

        private void BtnSetSpeed_Click(object sender, EventArgs e)
        {
            setSpeedButton(Speed, BtnSetSpeed);
        }
    }
}
