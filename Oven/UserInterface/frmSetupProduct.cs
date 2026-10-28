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
    public partial class frmSetupProduct : frmBaseDialog
    {


        frmRunParameter frmRunParameter;
        frmProduct frmProduct;
        public frmSetupProduct()
        {
            InitializeComponent();
            frmRunParameter = null;
            frmProduct = null;


        }


        void AllBtnFocusOff()
        {
            btnSwitch.BackColor = Color.FromArgb(66, 84, 94);
            btnData.BackColor = Color.FromArgb(66, 84, 94);
        }

        void DeleteAllSubDialog()
        {

            AllBtnFocusOff();
            pnlSetup.Controls.Clear();
            if (frmRunParameter != null)
            {
                frmRunParameter.Close();
                frmRunParameter = null;
            }

            if (frmProduct != null)
            {
                frmProduct.Close();
                frmProduct = null;
            }

        }

        private void frmSetupProduct_Load(object sender, EventArgs e)
        {
            btnData_Click(sender,e);
        }

        private void btnSwitch_Click(object sender, EventArgs e)
        {
            DeleteAllSubDialog();
            btnSwitch.BackColor = Color.FromArgb(28, 121, 196);
            frmRunParameter = new frmRunParameter();
            frmRunParameter.TopLevel = false;
            frmRunParameter.Dock = DockStyle.Fill;                   //指定控件停靠的位置和方式
            frmRunParameter.FormBorderStyle = FormBorderStyle.None;  //指定窗体边框样式
            pnlSetup.Controls.Add(frmRunParameter);
            frmRunParameter.Show();
        }

        private void btnData_Click(object sender, EventArgs e)
        {
            DeleteAllSubDialog();
            btnData.BackColor = Color.FromArgb(28, 121, 196);
            frmProduct = new frmProduct();
            frmProduct.TopLevel = false;
            frmProduct.Dock = DockStyle.Fill;                   //指定控件停靠的位置和方式
            frmProduct.FormBorderStyle = FormBorderStyle.None;  //指定窗体边框样式
            pnlSetup.Controls.Add(frmProduct);
            frmProduct.Show();
        }
    }
}
