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
    public partial class frmSetupMonitor : frmBaseDialog
    {

        frmHistoryRecord frmHistoryRecord;
        public frmSetupMonitor()
        {
            InitializeComponent();
            frmHistoryRecord = null;
            btnAlarm_Click(null, null);
        }

        void AllBtnFocusOff()
        {
            btnAlarm.BackColor = Color.FromArgb(66, 84, 94);
            btnParamter.BackColor = Color.FromArgb(66, 84, 94);

        }

        void DeleteAllSubDialog()
        {

            AllBtnFocusOff();
            pnlSetup.Controls.Clear();
            if (frmHistoryRecord != null)
            {
                frmHistoryRecord.Close();
                frmHistoryRecord = null;
            }
        }

        private void btnAlarm_Click(object sender, EventArgs e)
        {
            DeleteAllSubDialog();
            btnAlarm.BackColor = Color.FromArgb(28, 121, 196);
            Inquire_Mode = Inquire_Alarm;
            frmHistoryRecord = new frmHistoryRecord();
            frmHistoryRecord.TopLevel = false;
            frmHistoryRecord.Dock = DockStyle.Fill;                   //指定控件停靠的位置和方式
            frmHistoryRecord.FormBorderStyle = FormBorderStyle.None;  //指定窗体边框样式
            pnlSetup.Controls.Add(frmHistoryRecord);
            frmHistoryRecord.Show();
        }

        private void btnParamter_Click(object sender, EventArgs e)
        {
            DeleteAllSubDialog();
            btnParamter.BackColor = Color.FromArgb(28, 121, 196);
            Inquire_Mode = Inquire_Param;
            frmHistoryRecord = new frmHistoryRecord();
            frmHistoryRecord.TopLevel = false;
            frmHistoryRecord.Dock = DockStyle.Fill;                   //指定控件停靠的位置和方式
            frmHistoryRecord.FormBorderStyle = FormBorderStyle.None;  //指定窗体边框样式
            pnlSetup.Controls.Add(frmHistoryRecord);
            frmHistoryRecord.Show();
        }
    }
}
