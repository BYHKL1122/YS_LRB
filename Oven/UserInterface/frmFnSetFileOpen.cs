using System;
using System.IO;
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
using System.Runtime.InteropServices;
namespace YS_6000.UserInterface
{
    public partial class frmFnSetFileOpen : frmBaseDialog
    {

        [DllImport("kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
        private static extern bool WritePrivateProfileString(
    string lpAppName, string lpKeyName, string lpString, string lpFileName);
        [DllImport("kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
        private static extern int GetPrivateProfileString(
            string lpAppName, string lpKeyName, string lpDefault, StringBuilder lpReturnedString,
            int nSize, string lpFileName);
        byte show_flag;
        int delay_count;
        bool keyPad_case_flag = false;
        List<string> Paramlist = new List<string>();
        public frmFnSetFileOpen()
        {
            InitializeComponent();

        }



        void initFileList()
        {
            Paramlist.Clear();
            cmbFileList.Items.Clear();
            DirectorName(Common.envParameterFolder, Paramlist);
            for (int i = 0; i < Paramlist.Count; i++)
            {
                cmbFileList.Items.Add(Paramlist[i]);
            }
        }

        private void frmFnSetFileOpen_Load(object sender, EventArgs e)
        {
            Text = Name;
            KeyPreview = true;
            TopMost = true;
            initFileList();
        }

        private void frmFnSetFileOpen_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void cmdNewFile_Click(object sender, EventArgs e)
        {
            int i;

            if (show_flag == 2) return;

            txtSetValue.Text = (txtSetValue.Text).Trim();

            if (txtSetValue.Text == "")
            {
                lblStatusBar.ForeColor = Color.Red;
                lblStatusBar.Text = "您必须输入档案名";
                show_flag = 1;
            }
            else
            {
                for (i = 0; i < Paramlist.Count; i++)
                {
                    if (txtSetValue.Text.ToLower() == Paramlist[i].ToLower())
                    {
                        lblStatusBar.ForeColor = Color.Red;
                        lblStatusBar.Text = "档案名称已存在, 请重新命名!";
                        show_flag = 1;
                        return;
                    }
                }
                Common.parameterFile = String.Format("{0}.par", txtSetValue.Text);
                txtSetValue.Text = "";
                for (i = 0; i < Global.moduleList.Count; i++)
                {
                    Global.moduleList[i].saveParameter();
                }
                WritePrivateProfileString("Files", "LatestParameterFile", Common.parameterFile, Common.envEnvironmentFile);

                initFileList();
                txtSetValue.Focus();

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (show_flag == 1)
            {
                delay_count++;

                if (delay_count >= 2)    //about 2 second
                {
                    delay_count = 0;
                    show_flag = 0;
                    lblStatusBar.Text = "";
                }
            }
            else if (show_flag == 2)
            {
                delay_count++;

                if (delay_count >= 2)    //about 2 second
                {
                    delay_count = 0;
                    show_flag = 0;
                    txtSetValue.Text = "";
                    lblStatusBar.Text = "";
                }
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            cmbFileList.Text = (cmbFileList.Text).Trim();

            if (cmbFileList.Text == "")
            {
                lblStatusBar.ForeColor = Color.Red;
                lblStatusBar.Text = "您必须输入档案名";
                show_flag = 1;
                return;
            }
            if (cmbFileList.Text == SubFileName(Common.parameterFile))
            {
                lblStatusBar.ForeColor = Color.Red;
                lblStatusBar.Text = "档案正在使用!";
                show_flag = 1;
                return;
            }

            Common.parameterFile = String.Format("{0}.par", cmbFileList.Text);
            cmbFileList.Text = "";
            for (int i = 0; i < Global.moduleList.Count; i++)
            {
                Global.moduleList[i].loadParameter();
            }
            WritePrivateProfileString("Files", "LatestParameterFile", Common.parameterFile, Common.envEnvironmentFile);

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string file;
            DialogResult result;
            cmbFileList.Text = (cmbFileList.Text).Trim();

            if (cmbFileList.Text == "")
            {
                lblStatusBar.ForeColor = Color.Red;
                lblStatusBar.Text = "您必须输入档案名";
                show_flag = 1;
                return;
            }
            if (cmbFileList.Text == SubFileName(Common.parameterFile))
            {
                lblStatusBar.ForeColor = Color.Red;
                lblStatusBar.Text = "档案正在使用!";
                show_flag = 1;
                return;
            }

            result = MessageBox.Show(String.Format("删除档案{0}", cmbFileList.Text), "档案管理",
            MessageBoxButtons.YesNo, MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button2, MessageBoxOptions.DefaultDesktopOnly);
            if (result == DialogResult.Yes)
            {
                file = Common.envParameterFolder + @"\" + cmbFileList.Text + ".par";
                DeleteFile(file);
                file = Common.envIndexFolder + @"\" + cmbFileList.Text + ".txt";
                DeleteFile(file);
                cmbFileList.Text = "";
                initFileList();
            }

        }


        private void txtSetValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = Char.ToUpper(e.KeyChar);

            switch (ch)
            {
                case '\\':
                case '/':
                case ':':
                case '*':
                case '?':
                case '\"':
                case '<':
                case '>':
                case '|':
                    lblStatusBar.ForeColor = Color.Red;
                    lblStatusBar.Text = "档案名称不可包含下列字元: \\ / : * ? \" < > |。";
                    show_flag = 2;
                    break;
            }
        }
        private void cmdKey_0_Click(object sender, EventArgs e)
        {
            string str;

            if (((Button)sender).Name != cmdKey_6.Name)
                str = ((Button)sender).Text;
            else
                str = "&";

            if (txtSetValue.Text.Length < txtSetValue.MaxLength)
                txtSetValue.Text += str;
        }

        private void cmdKey_A_Click(object sender, EventArgs e)
        {
            string str;

            str = ((Button)sender).Text;

            str = keyPad_case_flag ? str.ToUpper() : str.ToLower();

            if (txtSetValue.Text.Length < txtSetValue.MaxLength)
                txtSetValue.Text += str;
        }
        private void cmdKeyPad_Click(object sender, EventArgs e)
        {

            pnlKeyPad.Visible = !pnlKeyPad.Visible;
            txtSetValue.Focus();
        }

        private void cmdKeyCaps_Click(object sender, EventArgs e)
        {
            keyPad_case_flag = keyPad_case_flag == false ? true : false;

            if (keyPad_case_flag)
                cmdKeyCaps.ForeColor = Color.Red;
            else
                cmdKeyCaps.ForeColor = Color.Black;
        }

        private void cmdKeyBackspace_Click(object sender, EventArgs e)
        {
            string str;

            str = ((Button)sender).Text;

            if (txtSetValue.Text.Trim() != "")
                txtSetValue.Text = txtSetValue.Text.Substring(0, txtSetValue.Text.Length - 1);
        }

        private void cmdKeyEnter_Click(object sender, EventArgs e)
        {
            cmdNewFile_Click(null, e);
        }
    }
}
