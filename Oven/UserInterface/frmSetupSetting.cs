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
    public partial class frmSetupSeting : frmBaseDialog
    {



        frmSetupOvenInputTrack frmSetupOvenInputTrack;
        frmSetupOvenOutputTrack frmSetupOvenOutputTrack;

        frmSetupOven frmSetupOven;
        frmSetupMagazine frmSetupMagazine;

        public frmSetupSeting()
        {
            InitializeComponent();

            frmSetupOvenInputTrack = null;
            frmSetupOvenOutputTrack = null;
            frmSetupOven = null;
            frmSetupMagazine = null;
            btnOven_Click(null,null);
        }





        void AllBtnFocusOff()
        {

            btnOvenInputTrack.BackColor = Color.FromArgb(66, 84, 94);
            btnOvenOutputTrack.BackColor = Color.FromArgb(66, 84, 94);
            btnOven.BackColor = Color.FromArgb(66, 84, 94);
            btnMagazine.BackColor = Color.FromArgb(66, 84, 94);

        }
        void DeleteAllSubDialog()
        {
            AllBtnFocusOff();
            pnlSetup.Controls.Clear();


            if (frmSetupOvenInputTrack != null)
            {
                frmSetupOvenInputTrack.Close();
                frmSetupOvenInputTrack = null;
            }
            if (frmSetupOven != null)
            {
                frmSetupOven.Close();
                frmSetupOven = null;
            }

            if (frmSetupOvenOutputTrack != null)
            {
                frmSetupOvenOutputTrack.Close();
                frmSetupOvenOutputTrack = null;
            }
            if (frmSetupMagazine != null)
            {
                frmSetupMagazine.Close();
                frmSetupMagazine = null;
            }

        }
















        private void btnOvenInputArm_Click(object sender, EventArgs e)
        {
            DeleteAllSubDialog();
            btnOvenInputTrack.BackColor = Color.FromArgb(28, 121, 196);
            frmSetupOvenInputTrack = new frmSetupOvenInputTrack();
            frmSetupOvenInputTrack.TopLevel = false;
            frmSetupOvenInputTrack.Dock = DockStyle.Fill;
            frmSetupOvenInputTrack.FormBorderStyle = FormBorderStyle.None;
            pnlSetup.Controls.Add(frmSetupOvenInputTrack);
            frmSetupOvenInputTrack.Show();
        }

        private void btnOven_Click(object sender, EventArgs e)
        {
            DeleteAllSubDialog();
            btnOven.BackColor = Color.FromArgb(28, 121, 196);
            frmSetupOven = new frmSetupOven();
            frmSetupOven.TopLevel = false;
            frmSetupOven.Dock = DockStyle.Fill;
            frmSetupOven.FormBorderStyle = FormBorderStyle.None;
            pnlSetup.Controls.Add(frmSetupOven);
            frmSetupOven.Show();
        }

        private void btnOvenOutputTrack_Click(object sender, EventArgs e)
        {
            DeleteAllSubDialog();
            btnOvenOutputTrack.BackColor = Color.FromArgb(28, 121, 196);
            frmSetupOvenOutputTrack = new frmSetupOvenOutputTrack();
            frmSetupOvenOutputTrack.TopLevel = false;
            frmSetupOvenOutputTrack.Dock = DockStyle.Fill;
            frmSetupOvenOutputTrack.FormBorderStyle = FormBorderStyle.None;
            pnlSetup.Controls.Add(frmSetupOvenOutputTrack);
            frmSetupOvenOutputTrack.Show();
        }

        private void btnMagazine_Click(object sender, EventArgs e)
        {
            DeleteAllSubDialog();
            btnMagazine.BackColor = Color.FromArgb(28, 121, 196);
            frmSetupMagazine = new frmSetupMagazine();
            frmSetupMagazine.TopLevel = false;
            frmSetupMagazine.Dock = DockStyle.Fill;
            frmSetupMagazine.FormBorderStyle = FormBorderStyle.None;
            pnlSetup.Controls.Add(frmSetupMagazine);
            frmSetupMagazine.Show();
        }




    }
}
