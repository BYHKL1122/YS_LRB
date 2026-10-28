using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Framework;
using YS_6000.Module;
using YS_6000.UserInterface;
using System.Runtime.InteropServices;

namespace YS_6000.UserInterface
{
    public partial class frmModuleStatus : frmBaseDialog
    {
        Button[] btn = new Button[Global.moduleList.Count];
        Label[] lbl = new Label[Global.moduleList.Count];


        public frmModuleStatus()
        {
            InitializeComponent();


            for (int i = 0; i < Global.moduleList.Count; i++)
            {
                btn[i] = new Button();
                btn[i].Top = (i % 10) * 50 ;
                btn[i].Left = (i / 10) * (150 + 40 + 30) ;
                btn[i].Width = 150;
                btn[i].Height = 40;
                btn[i].Text = Global.moduleList[i].fwDisplayName;
                btn[i].BackColor = Color.White;
                btn[i].ForeColor = Color.Black;
                btn[i].Tag = i;
                btn[i].Click += new System.EventHandler(this.btn_Click);
                this.Controls.Add(btn[i]);
                lbl[i] = new Label();

                lbl[i].Top = btn[i].Top;
                lbl[i].Left = btn[i].Left + btn[i].Width + 10;
                lbl[i].Width = 40;
                lbl[i].Height = 40;
                lbl[i].BackColor = Color.Gray;
                this.Controls.Add(lbl[i]);
            }

        }
        void btn_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            int i = int.Parse(clickedButton.Tag.ToString());
            DialogResult result;
            result = MessageBox.Show(Global.moduleList[i].fwDisplayName, "归零",
           MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.DefaultDesktopOnly);
            if (result == DialogResult.Yes)
            {

                Global.moduleList[i].Initialize();
            }

        }





        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < Global.moduleList.Count; i++)
            {
                setLabel(lbl[i], Global.moduleList[i].fwInitialized);
            }
            for (int i = 0; i < Global.moduleList.Count; i++)
            {
                 btn[i].Enabled = Global.OFF.reqInitAll.isDone();
            }
        }


        private void frmModuleStatus_Load(object sender, EventArgs e)
        {

            initForm();

        }

        void initForm()
        {

            Boolean enable = true;
            for (int i = 0; i < Global.moduleList.Count; i++)
            {
                setLabel(lbl[i], Global.moduleList[i].fwInitialized);
                btn[i].Enabled = !Global.moduleList[i].isRunning();
                enable &= btn[i].Enabled;
            }
        }

    }
}
