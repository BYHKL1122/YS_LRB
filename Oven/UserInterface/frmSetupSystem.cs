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
    public partial class frmSetupSystem : frmBaseDialog
    {


        frmFnSetFileOpen frmFnSetFileOpen;
        frmUser frmUser;
    //    frmLockMachine frmLockMachine;
        public frmSetupSystem()
        {
            InitializeComponent();
            frmFnSetFileOpen = null;
            frmUser = null;
         ///   frmLockMachine = null;

        }




        void AllBtnFocusOff()
        {
            btnParamFile.BackColor = Color.FromArgb(66, 84, 94);
            btnUser.BackColor = Color.FromArgb(66, 84, 94);
            btnRegister.BackColor = Color.FromArgb(66, 84, 94);
        }

        void DeleteAllSubDialog()
        {

            AllBtnFocusOff();
            pnlSetup.Controls.Clear();
            if (frmUser != null)
            {
                frmUser.Close();
                frmUser = null;
            }
            //if (frmLockMachine != null)
            //{
            //    frmLockMachine.Close();
            //    frmLockMachine = null;
            //}
            if (frmFnSetFileOpen != null)
            {
                frmFnSetFileOpen.Close();
                frmFnSetFileOpen = null;
            }

        }

        private void frmSetupSystem_Load(object sender, EventArgs e)
        {
           btnParamFile_Click(sender, e);
        }

        private void btnParamFile_Click(object sender, EventArgs e)
        {
            DeleteAllSubDialog();
            btnParamFile.BackColor = Color.FromArgb(28, 121, 196);
            frmFnSetFileOpen = new frmFnSetFileOpen();
            frmFnSetFileOpen.TopLevel = false;
            frmFnSetFileOpen.Dock = DockStyle.Fill;                   //指定控件停靠的位置和方式
            frmFnSetFileOpen.FormBorderStyle = FormBorderStyle.None;  //指定窗体边框样式
            pnlSetup.Controls.Add(frmFnSetFileOpen);
            frmFnSetFileOpen.Show();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            DeleteAllSubDialog();
            btnUser.BackColor = Color.FromArgb(28, 121, 196);
            frmUser = new frmUser();
            frmUser.TopLevel = false;
            frmUser.Dock = DockStyle.Fill;                   //指定控件停靠的位置和方式
            frmUser.FormBorderStyle = FormBorderStyle.None;  //指定窗体边框样式
            pnlSetup.Controls.Add(frmUser);
            frmUser.Show();
        }
    }
}
