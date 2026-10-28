using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YS_6000.UserInterface
{
    public partial class frmSetupOven : frmBaseDialog
    {

        frmOvenInput frmOvenInput;
        frmOven frmOven;
        frmOvenOutput frmOvenOutput;
        frmOvenTemperature frmOvenTemperature;
        frmChamber frmChamber;
        public frmSetupOven()
        {
            InitializeComponent();
            frmOvenInput = null;
            frmOven = null;
            frmChamber = null;
            frmOvenOutput = null;
            frmOvenTemperature = null;
            OperateControls(this);
            btnOven_Click(null,null);
        }

        void AllBtnFocusOff()
        {
            btnInput.BackColor = Color.FromArgb(66, 84, 94);
            btnOven.BackColor = Color.FromArgb(66, 84, 94);
            btnOutput.BackColor = Color.FromArgb(66, 84, 94);
            btnSV.BackColor = Color.FromArgb(66, 84, 94);
            btnAH.BackColor = Color.FromArgb(66, 84, 94);
            btnAL.BackColor = Color.FromArgb(66, 84, 94);
            btnSC.BackColor = Color.FromArgb(66, 84, 94);
            btnChamber1.BackColor = Color.FromArgb(66, 84, 94);
            btnChamber2.BackColor = Color.FromArgb(66, 84, 94);
        }

        void DeleteAllSubDialog()
        {

            AllBtnFocusOff();
            pnlSetup.Controls.Clear();
            if (frmOvenInput != null)
            {
                frmOvenInput.Close();
                frmOvenInput = null;
            }

            if (frmOven != null)
            {
                frmOven.Close();
                frmOven = null;
            }
            if (frmOvenOutput != null)
            {
                frmOvenOutput.Close();
                frmOvenOutput = null;
            }
            if (frmOvenTemperature != null)
            {
                frmOvenTemperature.Close();
                frmOvenTemperature = null;
            }

            if (frmChamber != null)
            {
                frmChamber.Close();
                frmChamber = null;
            }
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            DeleteAllSubDialog();
            btnInput.BackColor = Color.FromArgb(28, 121, 196);

            frmOvenInput = new frmOvenInput();
            frmOvenInput.TopLevel = false;
            frmOvenInput.Dock = DockStyle.Fill;                   //指定控件停靠的位置和方式
            frmOvenInput.FormBorderStyle = FormBorderStyle.None;  //指定窗体边框样式
            pnlSetup.Controls.Add(frmOvenInput);
            frmOvenInput.Show();
        }

        private void btnOven_Click(object sender, EventArgs e)
        {
            DeleteAllSubDialog();
            btnOven.BackColor = Color.FromArgb(28, 121, 196);

            frmOven = new frmOven();
            frmOven.TopLevel = false;
            frmOven.Dock = DockStyle.Fill;                   //指定控件停靠的位置和方式
            frmOven.FormBorderStyle = FormBorderStyle.None;  //指定窗体边框样式
            pnlSetup.Controls.Add(frmOven);
            frmOven.Show();
        }

        private void btnOutput_Click(object sender, EventArgs e)
        {
            DeleteAllSubDialog();
            btnOutput.BackColor = Color.FromArgb(28, 121, 196);

            frmOvenOutput = new frmOvenOutput();
            frmOvenOutput.TopLevel = false;
            frmOvenOutput.Dock = DockStyle.Fill;                   //指定控件停靠的位置和方式
            frmOvenOutput.FormBorderStyle = FormBorderStyle.None;  //指定窗体边框样式
            pnlSetup.Controls.Add(frmOvenOutput);
            frmOvenOutput.Show();
        }

        private void btnSV_Click(object sender, EventArgs e)
        {
            DeleteAllSubDialog();
            btnSV.BackColor = Color.FromArgb(28, 121, 196);
            Seting_Mode = Seting_SV;
            frmOvenTemperature = new frmOvenTemperature();
            frmOvenTemperature.TopLevel = false;
            frmOvenTemperature.Dock = DockStyle.Fill;                   //指定控件停靠的位置和方式
            frmOvenTemperature.FormBorderStyle = FormBorderStyle.None;  //指定窗体边框样式
            pnlSetup.Controls.Add(frmOvenTemperature);
            frmOvenTemperature.Show();
        }

        private void btnAH_Click(object sender, EventArgs e)
        {
            DeleteAllSubDialog();
            btnAH.BackColor = Color.FromArgb(28, 121, 196);
            Seting_Mode = Seting_AH;
            frmOvenTemperature = new frmOvenTemperature();
            frmOvenTemperature.TopLevel = false;
            frmOvenTemperature.Dock = DockStyle.Fill;                   //指定控件停靠的位置和方式
            frmOvenTemperature.FormBorderStyle = FormBorderStyle.None;  //指定窗体边框样式
            pnlSetup.Controls.Add(frmOvenTemperature);
            frmOvenTemperature.Show();
        }

        private void btnAL_Click(object sender, EventArgs e)
        {
            DeleteAllSubDialog();
            btnAL.BackColor = Color.FromArgb(28, 121, 196);
            Seting_Mode = Seting_AL;
            frmOvenTemperature = new frmOvenTemperature();
            frmOvenTemperature.TopLevel = false;
            frmOvenTemperature.Dock = DockStyle.Fill;                   //指定控件停靠的位置和方式
            frmOvenTemperature.FormBorderStyle = FormBorderStyle.None;  //指定窗体边框样式
            pnlSetup.Controls.Add(frmOvenTemperature);
            frmOvenTemperature.Show();
        }

        private void btnSC_Click(object sender, EventArgs e)
        {
            DeleteAllSubDialog();
            btnSC.BackColor = Color.FromArgb(28, 121, 196);
            Seting_Mode = Seting_SC;
            frmOvenTemperature = new frmOvenTemperature();
            frmOvenTemperature.TopLevel = false;
            frmOvenTemperature.Dock = DockStyle.Fill;                   //指定控件停靠的位置和方式
            frmOvenTemperature.FormBorderStyle = FormBorderStyle.None;  //指定窗体边框样式
            pnlSetup.Controls.Add(frmOvenTemperature);
            frmOvenTemperature.Show();
        }

        private void btnChamber1_Click(object sender, EventArgs e)
        {
            DeleteAllSubDialog();
            btnChamber1.BackColor = Color.FromArgb(28, 121, 196);
            Global.CB = Global.CB1;
            frmChamber = new frmChamber();
            frmChamber.TopLevel = false;
            frmChamber.Dock = DockStyle.Fill;                   //指定控件停靠的位置和方式
            frmChamber.FormBorderStyle = FormBorderStyle.None;  //指定窗体边框样式
            pnlSetup.Controls.Add(frmChamber);
            frmChamber.Show();
        }

        private void btnChamber2_Click(object sender, EventArgs e)
        {
            DeleteAllSubDialog();
            btnChamber2.BackColor = Color.FromArgb(28, 121, 196);
            Global.CB = Global.CB2;
            frmChamber = new frmChamber();
            frmChamber.TopLevel = false;
            frmChamber.Dock = DockStyle.Fill;                   //指定控件停靠的位置和方式
            frmChamber.FormBorderStyle = FormBorderStyle.None;  //指定窗体边框样式
            pnlSetup.Controls.Add(frmChamber);
            frmChamber.Show();
        }

        private void frmSetupOven_FormClosed(object sender, FormClosedEventArgs e)
        {
            DeleteAllSubDialog();
        }
    }
}
