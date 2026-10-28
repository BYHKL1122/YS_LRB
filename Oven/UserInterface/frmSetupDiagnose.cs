using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YS_6000.UserInterface;
namespace YS_6000.UserInterface
{
    public partial class frmSetupDiagnose : frmBaseDialog
    {

        frmIODiagnosis frmIODiagnosis;
        frmMotorDiagnosis frmMotorDiagnosis;
        frmModuleStatus frmModuleStatus;
        public frmSetupDiagnose()
        {
            InitializeComponent();
            frmIODiagnosis = null;
            frmMotorDiagnosis = null;
            frmModuleStatus = null;
            OperateControls(this);
        }



        void AllBtnFocusOff()
        {
            btnIO.BackColor = Color.FromArgb(66, 84, 94);
            btnMotor.BackColor = Color.FromArgb(66, 84, 94);
            btnInitialize.BackColor = Color.FromArgb(66, 84, 94);
        }

        void DeleteAllSubDialog()
        {

            AllBtnFocusOff();
            pnlSetup.Controls.Clear();
            if (frmIODiagnosis != null)
            {
                frmIODiagnosis.Close();
                frmIODiagnosis = null;
            }

            if (frmMotorDiagnosis != null)
            {
                frmMotorDiagnosis.Close();
                frmMotorDiagnosis = null;
            }
            if (frmModuleStatus != null)
            {
                frmModuleStatus.Close();
                frmModuleStatus = null;
            }
        }

        private void btnIO_Click(object sender, EventArgs e)
        {
            DeleteAllSubDialog();
            btnIO.BackColor = Color.FromArgb(28, 121, 196);
            frmIODiagnosis = new frmIODiagnosis();
            frmIODiagnosis.TopLevel = false;
            frmIODiagnosis.Dock = DockStyle.Fill;                   //指定控件停靠的位置和方式
            frmIODiagnosis.FormBorderStyle = FormBorderStyle.None;  //指定窗体边框样式
            pnlSetup.Controls.Add(frmIODiagnosis);
            frmIODiagnosis.Show();
        }

        private void btnMotor_Click(object sender, EventArgs e)
        {
            DeleteAllSubDialog();
            btnMotor.BackColor = Color.FromArgb(28, 121, 196);
            frmMotorDiagnosis = new frmMotorDiagnosis();
            frmMotorDiagnosis.TopLevel = false;
            frmMotorDiagnosis.Dock = DockStyle.Fill;                   //指定控件停靠的位置和方式
            frmMotorDiagnosis.FormBorderStyle = FormBorderStyle.None;  //指定窗体边框样式
            pnlSetup.Controls.Add(frmMotorDiagnosis);
            frmMotorDiagnosis.Show();
        }



        private void btnInitialize_Click(object sender, EventArgs e)
        {
            DeleteAllSubDialog();
            btnInitialize.BackColor = Color.FromArgb(28, 121, 196);
            frmModuleStatus = new frmModuleStatus();
            frmModuleStatus.TopLevel = false;
            frmModuleStatus.Dock = DockStyle.Fill;                   //指定控件停靠的位置和方式
            frmModuleStatus.FormBorderStyle = FormBorderStyle.None;  //指定窗体边框样式
            pnlSetup.Controls.Add(frmModuleStatus);
            frmModuleStatus.Show();
        }

        private void frmSetupDiagnose_Load(object sender, EventArgs e)
        {
            btnInitialize_Click(sender, e);
        }
    }
}
