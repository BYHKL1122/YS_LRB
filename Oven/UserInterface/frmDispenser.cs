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
using YSOS.Framework;

namespace YSOS.UserInterface
{
    public partial class frmDispenser : frmBaseDialog
    {
        Dispenser obj;


        public frmDispenser()
        {
            InitializeComponent();
            obj = Global.DP;
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGotoStandby_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            obj.gotoStandby();
            Cursor = Cursors.Default;

        }

        private void btnGotoUp_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            obj.gotoUp();
            Cursor = Cursors.Default;
        }


        private void btnDispense1_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            obj.Dispense(1);
            Cursor = Cursors.Default;
        }

        private void btnDispense2_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            obj.Dispense(2);
            Cursor = Cursors.Default;
        }

        private void btnDispense_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            obj.Dispense(0);
            Cursor = Cursors.Default;
        }

        private void btnStandbyPositionUp_Click(object sender, EventArgs e)
        {
            setIntValueDown(ref obj.m_StandbyPosition);
            obj.setStandbyPosition(obj.m_StandbyPosition);

        }

        private void btnStandbyPositionDown_Click(object sender, EventArgs e)
        {
            setIntValueUp(ref obj.m_StandbyPosition);
            obj.setStandbyPosition(obj.m_StandbyPosition);

        }

        private void btnUpPositionUp_Click(object sender, EventArgs e)
        {
            setIntValueDown(ref obj.m_UpPosition);
            obj.setUpPosition(obj.m_UpPosition);
        }

        private void btnUpPositionDown_Click(object sender, EventArgs e)
        {
            setIntValueUp(ref obj.m_UpPosition);
            obj.setUpPosition(obj.m_UpPosition);


        }

        private void txtDown1PositionUp_Click(object sender, EventArgs e)
        {
            setIntValueDown(ref obj.m_Down1Position);
            obj.setDown1Position(obj.m_Down1Position);

        }

        private void txtDown1PositionDown_Click(object sender, EventArgs e)
        {
            setIntValueUp(ref obj.m_Down1Position);
            obj.setDown1Position(obj.m_Down1Position);

        }






        private void btnDownDelayUp_Click(object sender, EventArgs e)
        {
            setIntValueUp(ref obj.m_DownDelay);
        }

        private void btnDownDelayDown_Click(object sender, EventArgs e)
        {
            setIntValueDown(ref obj.m_DownDelay);
            if (obj.m_DownDelay < 0) obj.m_DownDelay = 0;
        }









        private void btnDispenseOn1_Click(object sender, EventArgs e)
        {
            if (obj.isDP_On1())
                obj.DP_Off(1);
            else
                obj.DP_On(1);
        }

        private void btnDispenseOn2_Click(object sender, EventArgs e)
        {
            if (obj.isDP_On2())
                obj.DP_Off(2);
            else
                obj.DP_On(2);
        }







        private void btnGotoDown1_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            obj.gotoDown();
            Cursor = Cursors.Default;
            txtDown1Position.Focus();
        }













        private void frmDispenser_FormClosed(object sender, FormClosedEventArgs e)
        {


            if (obj.fwInitialized)
                obj.gotoStandby();


        }



        private void btnClearTrimCount_Click(object sender, EventArgs e)
        {
       
        }

        private void txtDisLimitUp_Click(object sender, EventArgs e)
        {
            setIntValueUp(ref obj.m_DisLimit);
        }

        private void txtDisLimitDown_Click(object sender, EventArgs e)
        {
            setIntValueDown(ref obj.m_DisLimit);
            if (obj.m_DisLimit < 0) obj.m_DisLimit = 0;
        }

        private void BtnSetSpeed_Click(object sender, EventArgs e)
        {
            setSpeedButton(Speed, BtnSetSpeed);
        }

        private void chkDispenseOn1_CheckedChanged(object sender, EventArgs e)
        {
            if (obj.isDP_Done1())
                obj.DP_Off(1);
            else
                obj.DP_On(1);
        }

        private void chkDispenseOn2_CheckedChanged(object sender, EventArgs e)
        {
            if (obj.isDP_Done2())
                obj.DP_Off(2);
            else
                obj.DP_On(2);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Enabled = Global.MF.isSystemRun() ? false : true;
            setLabel(lblDispenseDone1, obj.isDP_Done1());
            setLabel(lblDispenseDone2, obj.isDP_Done2());
            setButton(btnInitialize, obj.fwInitialized);
            setButton(btnDispenseOn1, obj.isDP_On1());
            setButton(btnDispenseOn2, obj.isDP_On2()); 
            txtStandbyPosition.Text = obj.m_StandbyPosition.ToString();
            txtUpPosition.Text = obj.m_UpPosition.ToString();
            txtDown1Position.Text = obj.m_Down1Position.ToString();
            txtDownDelay.Text = obj.m_DownDelay.ToString();
            txtDisLimit.Text = obj.m_DisLimit.ToString();

        }
    }
}
