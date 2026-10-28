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

namespace YS_6000
{
    public partial class frmCycleStop : Form
    {
        public frmCycleStop()
        {
            InitializeComponent();
            KeyPreview = true;
            TopMost = true;
        }

        Boolean cycle = false;

        private void frmCycleStop_Load(object sender, EventArgs e)
        {
            cycle = false;
            label1.Text = "停止";
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            btnStart.Visible = true;
            btnStop.Visible = false;
            label1.Text = "停止";
            if (Global.MF.cycleObj == Global.MO)
            {
                Global.OFF.reqMOCycle.Done();
            }



            cycle = false;

        }

        private void frmCycleStop_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Global.MF.cycleObj == Global.MO)
            {
                Global.OFF.reqMOCycle.Done();
            }

            cycle = false;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            cycle = true;
            label1.Text = "循环中....";
            btnStart.Visible = false;
            btnStop.Visible = true;
            Cycling();
        }

        void Cycling()
        {
           if (Global.MF.cycleObj == Global.MO)
            {
                Global.OFF.reqMOCycle.Set();

            }

        }
    }
}
