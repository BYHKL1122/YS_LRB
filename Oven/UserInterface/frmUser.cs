using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Framework;
using YS_6000.Module;
namespace YS_6000.UserInterface
{
    public partial class frmUser : frmBaseDialog
    {
        int text_index;
        public const int Number = 2;
        Label[] lblSeting = new Label[Number];
        TextBox[] txtSeting = new TextBox[Number];
        public frmUser()
        {
            InitializeComponent();
            initComponent();
        }
        void initComponent()
        {
            int i;

            lblSeting[0] = lblPassWord;
            lblSeting[1] = lblTimeOut;

            txtSeting[0] = txtPassword;
            txtSeting[1] = txtTimeOut;

            for (i = 0; i < Number; i++)
            {
                lblSeting[i].Name = i.ToString();
                txtSeting[i].Name = i.ToString();
                lblSeting[i].Click += new EventHandler(lblSetTextClick);
                txtSeting[i].Click += new EventHandler(txtSetValueClick);
            }

        }


        private void lblSetTextClick(object sender, EventArgs e)
        {
            int i;

            i = Convert.ToInt16(((Control)sender).Name);
            lblSeting[text_index].ForeColor = Color.White;
            lblSeting[i].ForeColor = Color.Yellow;
            txtSeting[i].Focus();
            text_index = i;
        }
  


        private void txtSetValueClick(object sender, EventArgs e)
        {
            int i;

            i = Convert.ToInt16(((Control)sender).Name);
            lblSeting[text_index].ForeColor = Color.White;
            lblSeting[i].ForeColor = Color.White;
            txtSeting[i].Focus();
            text_index = i;
        }


        private void cmdKeyNum0_Click(object sender, EventArgs e)
        {

            if (txtSeting[text_index].Text.Length < txtPassword.MaxLength)
            {

                //TextBox txt = txtSeting[text_index];
                //List<char> lstText = new List<char>();
                //lstText = txt.Text.ToList();
                //char cKey = ((Control)sender).Text.ToCharArray()[0];

                //if (txt.SelectionLength == 0)
                //{
                //    lstText.Insert(txt.SelectionStart, cKey);

                //}
                //else
                //{
                //    lstText.RemoveRange(txt.SelectionStart, txt.SelectionLength);
                //    lstText.Insert(txt.SelectionStart, cKey);

                //}
                //txt.Text = new string(lstText.ToArray());
                //txt.Select(txt.SelectionStart + 1, 0);

                 txtSeting[text_index].Text += ((Control)sender).Text;
            }


        }

        public OpUserMode GetSelectedUser()
        {
            if (0 == cmbJurisdiction.SelectedIndex)
                return OpUserMode.User_Operator;
            else if (1 == cmbJurisdiction.SelectedIndex)
                return OpUserMode.User_Engineer;
            else if (2 == cmbJurisdiction.SelectedIndex)
                return OpUserMode.User_Admin;

            return OpUserMode.User_Operator;
        }

        public void UpDateCtl()
        {


            if (OpUserMode.User_Operator == PassWord.GetUserMode())
                cmbJurisdiction.SelectedIndex = 0;
            else if (OpUserMode.User_Engineer == PassWord.GetUserMode())
                cmbJurisdiction.SelectedIndex = 1;
            else
                cmbJurisdiction.SelectedIndex = 2;

            if (PassWord.GetUserMode() == GetSelectedUser())
            {
                BtnLogin.Visible = false;
                BtnLogout.Visible = true;

            }
            else
            {
                BtnLogin.Visible = true;
                BtnLogout.Visible = false;

            }

            if (OpUserMode.User_Engineer == PassWord.GetUserMode() ||
                OpUserMode.User_Admin == PassWord.GetUserMode())
            {
                BtnLogin.Visible = false;
                BtnLogout.Visible = true;      
                BtnReset.Visible = true;
                txtTimeOut.Visible = true;
                txtPassword.Visible = true;
            }
            else
            {
                BtnLogin.Visible = true;
                BtnLogout.Visible = false;
                BtnReset.Visible = false;
                txtPassword.Visible = true;
                txtTimeOut.Visible = false;

            }

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            int iPassword = 0;
            if (txtPassword.Text.Length <= 0) return;
            iPassword = int.Parse(txtPassword.Text);
            txtPassword.Text = "";


            if (PassWord.LogIn(iPassword, GetSelectedUser()) == -1)
            {
                MessageBox.Show("密码错误");
                return;
            }
            UpDateCtl();

        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            PassWord.LogOut();
            UpDateCtl();
            txtPassword.Text = "";
            fmKeyPad.Visible = false;
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            String cs;
            DialogResult result;
            if (OpUserMode.User_Engineer == PassWord.GetUserMode())
                cs = String.Format("是否重新设置工程师密码？");
            else
                cs = String.Format("是否重新设置管理员密码？");



 
            result = MessageBox.Show(cs, "密码管理",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question,
              MessageBoxDefaultButton.Button2, MessageBoxOptions.DefaultDesktopOnly);
            if (result != DialogResult.Yes)
                return;
            if (txtPassword.Text.Length <= 0)
                return;
            int iNew;
            iNew = int.Parse(txtPassword.Text);

            PassWord.ResetPassword(iNew, PassWord.GetUserMode());
            PassWord.Save();

           // gLogNormal.LogMessage("密码修改成功！");
        }

        private void frmFnLevelSet_Load(object sender, EventArgs e)
        {

            cmbJurisdiction.Items.Clear();
            cmbJurisdiction.Items.Add("操作员");
            cmbJurisdiction.Items.Add("工程师");
            cmbJurisdiction.Items.Add("管理员");
            txtTimeOut.Text = PassWord.GetAutoLogOutTime().ToString();
            UpDateCtl();
     
        }

        private void frmFnLevelSet_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void cmdKeyPad_Click(object sender, EventArgs e)
        {

            fmKeyPad.Visible = !fmKeyPad.Visible;

        }


        private void cmdKeyBackspace_Click(object sender, EventArgs e)
        {
            if (txtSeting[text_index].Text == "") return;
            //TextBox txt = txtSeting[text_index];
            //if (txt.SelectionLength == 0)
            //{
            //    if (txt.SelectionStart == 0) return;
            //    txt.Text = txt.Text.Remove(txt.SelectionStart - 1, 1);

            //}
            //else
            //{
            //    txt.Text = txt.Text.Remove(txt.SelectionStart, txt.SelectionLength);
            //}

            //txt.Select(txt.SelectionStart, 0);
             txtSeting[text_index].Text = txtSeting[text_index].Text.Substring(0, txtSeting[text_index].Text.Length - 1);
        }

        private void cmdKeyEnter_Click(object sender, EventArgs e)
        {
            if(text_index == 1)
            {
                ushort lDelay;
                lDelay = ushort.Parse(txtTimeOut.Text);
                PassWord.SetAutoLogOutTime(lDelay);
                PassWord.Save();
            }
        }
    }
}
