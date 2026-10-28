using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Framework;
namespace YS_6000.UserInterface
{
    public partial class frmInfoVersion : frmBaseDialog
    {        
        public frmInfoVersion()
        {
            InitializeComponent();
        }

        private void frmInfoVersion_Load(object sender, EventArgs e)
        {
            Text = Name;
            //Location = new Point((dConst.frmMainWidth - this.Width) / 3, (dConst.frmMainHeight - this.Height) / 3);
           // Location = new Point(dConst.frmSubMenuLeft, dConst.frmSubMenuTop);
            //Width = txtInfo.Left + txtInfo.Width + dConst.gridUnit;
            //Height = txtInfo.Top + txtInfo.Height + dConst.gridUnit;
           // Width = dConst.frmSubMenuWidth;
            //Height = dConst.frmSubMenuHeight;

            lblLine1.Width = Width - lblLine1.Left ;
            lblLine2.Width = Width - lblLine2.Left;    
            lblTitle.Text = Program.projectName;
            lblAddress.Text = "上海赢朔电子科技股份有限公司\n\n" + "上海市青浦区久远路389号"; ;


            //txtInfo.Width = Width - dConst.gridUnit * 2;
            //txtInfo.Height = Height - txtInfo.Top - dConst.gridUnit;

            KeyPreview = true;
            txtInfo.ReadOnly = true;
            //txtInfo.Visible = false;

            displayInfo();
        }





        private void displayInfo()
        {
            string[] text = new string[2];

            //summary
            text[0] = "目前机台编号版本" + "   " + Program.projectNo + "  " + Program.projectVersion + "\r\n" +
                      Program.projectNo + " " + "-" + "目前机台程式版本。" + "\r\n" +
                      "Va.b.c" + " " + "-" + "版本编号 a.b.c" + "\r\n" +
                      "a:代表机台 IO 点有更新或者增加, 使用时需要检查, IO 点是否已更改完成。" + "\r\n" +
                      "b:代表软体, 机台动作, 設定功能有修改或增加, 需立即更新, 并请检查定值是否输入正确。" + "\r\n" +
                      "c:代表软体细节修改或增加机台设定与画面功能, 无立即更新的必要, 不影响生产。" + "\r\n\r\n";
            
            //info of version
            text[1] = "based on YS_6000 V1.0.0" + "\r\n" +
                      "";

            txtInfo.AppendText(text[0] + text[1]);
        }



    }
}
