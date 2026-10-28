using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using OxyPlot;
using OxyPlot.Axes;
using OxyPlot.Series;
using OxyPlot.WindowsForms;
using OxyPlot.Annotations;
using Framework;
using YS_6000.Module;
using YS_6000.UserInterface;
using System.Runtime.InteropServices;
using System.Threading;

namespace YS_6000.UserInterface
{
    public partial class frmProfile : Form
    {
        ProfileChartCls ProfileChart = new ProfileChartCls("時間軸", "度數");

        Profile profileNode = new Profile();

        string selectpath;

        ContextMenu cm = new ContextMenu();
        MenuItem DeleteMenu = new MenuItem("刪除");
        MenuItem UpdateMenu = new MenuItem("查看");

        Boolean reload;

        public frmProfile()
        {
            InitializeComponent();

            cm.MenuItems.Add(DeleteMenu);
            cm.MenuItems.Add(UpdateMenu);
            DeleteMenu.Click += new System.EventHandler(this.DeleteMenu_Click);
            UpdateMenu.Click += new System.EventHandler(this.UpdateMenu_Click);

            DisplayOven();
            CreateChart();
            CreateSummary();
            dateEndTime.Value = DateTime.Now;
            dateBeginTime.Value = DateTime.Now.AddHours(-1);
            reload = true;
            QueryData();
            ResetChart();
            CreateProfileTable();
            RefreshProfiles();
        }

        void CreateProfileTable()
        {
            DataGridView dgv = dgvProfiles;
            int width = 0;


            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("宋体", 9);
            dgv.RowsDefaultCellStyle.Font = new Font("宋体", 12);
            dgv.RowsDefaultCellStyle.BackColor = Color.Ivory;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.PaleTurquoise;
            dgv.ReadOnly = true;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            //dgvTotalDoseTable.RowTemplate.Height += 4;

            dgv.ReadOnly = true;

            DataGridViewCheckBoxColumn columncb;
            DataGridViewButtonColumn columnbtn;
            DataGridViewTextBoxColumn textcb;

            textcb = new DataGridViewTextBoxColumn();
            dgv.Columns.Add(textcb);
            textcb.HeaderText = "量测时间";
            textcb.Name = "ProfileTime";
            textcb.Width = 300;
        }

        void RefreshProfiles()
        {
            String folderPath = string.Format(@"{0}\Profiles", Common.envAppPath);

            dgvProfiles.Rows.Clear();
            if (Directory.Exists(folderPath))
            {
                string[] files = Directory.GetFiles(folderPath, "*.xml");
                foreach (var file in files)
                {
                    int index = dgvProfiles.Rows.Add();
                    dgvProfiles.Rows[index].Cells["ProfileTime"].Value = Path.GetFileName(file);
                    dgvProfiles.Rows[index].Tag = file;
                }
            }

        }

        void DisplayOven()
        {
            DataGridView dgv = dgvStd;
            int width = 0;


            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("宋体", 9);
            dgv.RowsDefaultCellStyle.Font = new Font("宋体", 12);
            dgv.RowsDefaultCellStyle.BackColor = Color.Ivory;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.PaleTurquoise;
            dgv.ReadOnly = true;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            //dgvTotalDoseTable.RowTemplate.Height += 4;

            dgv.ReadOnly = true;

            DataGridViewCheckBoxColumn columncb;
            DataGridViewButtonColumn columnbtn;
            DataGridViewTextBoxColumn textcb;

            foreach (Channel ch in Channel.Channels)
            {
                textcb = new DataGridViewTextBoxColumn();
                dgv.Columns.Add(textcb);
                textcb.HeaderText = ch.Name;
                textcb.Name = ch.Name;
                textcb.Width = 100;
            }

            int index = dgv.Rows.Add();
            
            foreach (Channel ch in Channel.Channels)
            {
                if (ch.Function=="Heating")
                    dgv.Rows[index].Cells[ch.Name].Value = String.Format("{0} {1}", ch.Set_Value, ch.Bias);
            }
            index = dgv.Rows.Add();

            foreach (Channel ch in Channel.Channels)
            {
                if (ch.Function == "Heating")
                    dgv.Rows[index].Cells[ch.Name].Value = String.Format("{0}", Math.Round(ch.Present_Value));
            }
        }

        void CreateSummary()
        {
            DataGridView dgv = dgvSummary;
            int width = 0;


            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("宋体", 9);
            dgv.RowsDefaultCellStyle.Font = new Font("宋体", 12);
            dgv.RowsDefaultCellStyle.BackColor = Color.Ivory;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.PaleTurquoise;
            dgv.ReadOnly = true;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            //dgvTotalDoseTable.RowTemplate.Height += 4;

            dgv.ReadOnly = true;

            DataGridViewCheckBoxColumn columncb;
            DataGridViewButtonColumn columnbtn;
            DataGridViewTextBoxColumn textcb;

            textcb = new DataGridViewTextBoxColumn();
            dgv.Columns.Add(textcb);
            textcb.HeaderText = "探头";
            textcb.Name = "Channel";
            textcb.Width = 150;

            foreach (ProfileZone pf in Profile.GoldenProfileZones)
            {
                textcb = new DataGridViewTextBoxColumn();
                dgv.Columns.Add(textcb);
                textcb.HeaderText = pf.Name;
                textcb.Name = pf.Id;
                textcb.Width = 150;
            }

            textcb = new DataGridViewTextBoxColumn();
            dgv.Columns.Add(textcb);
            textcb.HeaderText = "峰值温度";
            textcb.Name = "Max";
            textcb.Width = 150;


        }

        void DisplayProfile()
        {
            dgvSummary.Rows.Clear();
            foreach (Channel ch in Channel.Channels)
            {
                if (ch.Function != "Profile") continue;
                int index = dgvSummary.Rows.Add();
                dgvSummary.Rows[index].Cells[0].Value = ch.Name;
                dgvSummary.Rows[index].Tag = ch;
                for (int zone=0; zone<ch.ProfileZones.Count; zone++)
                {
                    ProfileZone pfz = ch.ProfileZones[zone];
                    switch (zone)
                    {
                        case 0:
                        case 3:
                            dgvSummary.Rows[index].Cells[zone + 1].Value = string.Format("{0:F1}/{1}", pfz.Rate, pfz.Second);
                            break;
                        case 1:
                        case 2:
                            dgvSummary.Rows[index].Cells[zone + 1].Value = pfz.Second.ToString();
                            break;

                    }
                }

                dgvSummary.Rows[index].Cells[ch.ProfileZones.Count+1].Value = ch.Highest.ToString("F1");

            }


        }

        void DisplayZone(Channel ch)
        {
            Color color = color = Color.LightBlue;
            ProfileChart.chartModel.Annotations.Clear();

            for (int i = 0; i < ch.ProfileZones.Count; i++)
            {
                ProfileZone pfz = ch.ProfileZones[i];
                if (pfz.Second != 0)
                {
                    switch (i)
                    {
                        case 0:
                            color = Color.LightBlue;
                            break;
                        case 1:
                            color = Color.LightGreen;
                            break;
                        case 2:
                            color = Color.LightPink;
                            break;
                        case 3:
                            color = Color.LightYellow;
                            break;
                    }
                    PlotBoundary(pfz.tBegin, pfz.tEnd, 0, ch.Highest, color, LineStyle.Dot);
                }
            }
            ProfileChart.chartModel.InvalidatePlot(true);
        }

        void CreateChart()
        {
            pnlTime.Controls.Add(ProfileChart.chartView);
        }

        private void toolCompute_Click(object sender, EventArgs e)
        {
            profileNode.Compute();
            DisplayProfile();
            if (profileNode.pChannels.Count == 1)
                DisplayZone(profileNode.pChannels[0]);

        }

        private void QueryData(String exportfile = "")
        {
            String begin = String.Format("{0:yyyy-MM-dd} {1:HH:mm:ss}", dateBeginDate.Value, dateBeginTime.Value);
            string end = String.Format("{0:yyyy-MM-dd} {1:HH:mm:ss}", dateBeginDate.Value, dateEndTime.Value);
            DateTime selectdate = Convert.ToDateTime(begin);
            DateTime selectend = Convert.ToDateTime(end);
            Boolean exporting = exportfile != "";

            profileNode.BeginTime = selectdate;
            profileNode.EndTime = selectend;

            profileNode.QueryData(Server.ServerPath);
            RefreshChart();

        }

        void RefreshChart()
        {
            ProfileChart.clearPoints();
            foreach (QueueNode mdata in profileNode.pData)
            {
                ProfileChart.AppendPoint(mdata);
            }
            ProfileChart.chartModel.InvalidatePlot(true);
            txtTotalSecond.Text = (profileNode.EndTime - profileNode.BeginTime).TotalSeconds.ToString("F0");

        }

        private void ResetChart()
        {
            ProfileChart.chartModel.ResetAllAxes();
            ProfileChart.chartModel.InvalidatePlot(false);
        }

        private void dateBeginTime_ValueChanged(object sender, EventArgs e)
        {
            if (!reload) return;
            QueryData();
            ResetChart();
        }

        private void dateEndTime_ValueChanged(object sender, EventArgs e)
        {
            if (!reload) return;
            QueryData();
            ResetChart();
        }

        private void PlotBoundary( DateTime start, DateTime end, float min, float max, Color color, LineStyle linstyle)
        {
            String t = start.ToString("HH:mm:ss");
            if (t == "00:00:00") return;

            var rect1 = new RectangleAnnotation();
            rect1.Fill = OxyColor.FromArgb(50, color.R, color.G, color.B);
            rect1.StrokeThickness = 1;
            rect1.MinimumX = DateTimeAxis.ToDouble(start);
            rect1.MaximumX = DateTimeAxis.ToDouble(end);
            rect1.MinimumY = min;
            rect1.MaximumY = max;
            ProfileChart.chartModel.Annotations.Add(rect1);
            return;


        }

        private void dgvSummary_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            Channel ch = (Channel)(dgvSummary.Rows[e.RowIndex].Tag);

            DisplayZone(ch);


        }

        private void btnBeginMMplus_Click(object sender, EventArgs e)
        {
            dateBeginTime.Value = dateBeginTime.Value.AddMinutes(1);
        }

        private void btnBeginSSplus_Click(object sender, EventArgs e)
        {
            dateBeginTime.Value = dateBeginTime.Value.AddSeconds(1);
        }

        private void btnBeginSSminus_Click(object sender, EventArgs e)
        {
            dateBeginTime.Value = dateBeginTime.Value.AddSeconds(-1);
        }

        private void btnBeginMMminus_Click(object sender, EventArgs e)
        {
            dateBeginTime.Value = dateBeginTime.Value.AddMinutes(-1);
        }

        private void btnEndMMplus_Click(object sender, EventArgs e)
        {
            dateEndTime.Value = dateEndTime.Value.AddMinutes(1);
        }

        private void btnEndSSplus_Click(object sender, EventArgs e)
        {
            dateEndTime.Value = dateEndTime.Value.AddSeconds(1);
        }

        private void btnEndSSminus_Click(object sender, EventArgs e)
        {
            dateEndTime.Value = dateEndTime.Value.AddSeconds(-1);
        }

        private void btnEndMMminus_Click(object sender, EventArgs e)
        {
            dateEndTime.Value = dateEndTime.Value.AddMinutes(-1);
        }

        private void toolResetPlot_Click(object sender, EventArgs e)
        {
            ProfileChart.chartModel.ResetAllAxes();
            ProfileChart.chartModel.InvalidatePlot(false);
        }

        private void toolExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolSave_Click(object sender, EventArgs e)
        {
            profileNode.Save();
            RefreshProfiles();
        }


        private void dgvProfiles_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;

            // Make sure this is the right button.
            if (e.Button != MouseButtons.Right) return;
            if (e.RowIndex == -1 || e.ColumnIndex == -1) return;
            DataGridViewCell clickedCell = dgv.Rows[e.RowIndex].Cells[e.ColumnIndex];

            // Here you can do whatever you want with the cell
            dgv.CurrentCell = clickedCell;  // Select the clicked cell, for instance
            selectpath = (string)dgv.Rows[e.RowIndex].Tag;

            // Get mouse position relative to the vehicles grid
            var relativeMousePosition = dgv.PointToClient(Cursor.Position);

            // Show the context menu
            cm.Show(dgv, relativeMousePosition);
        }

        private void dgvProfiles_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return;

            selectpath = (string)(dgvProfiles.Rows[e.RowIndex].Tag);
            LoadProfile();
        }

        void DeleteMenu_Click(object sender, System.EventArgs e)
        {
            if (File.Exists(selectpath))
            {
                File.Delete(selectpath);
                MessageBox.Show("删除成功");
                RefreshProfiles();
            }
        }

        void UpdateMenu_Click(object sender, System.EventArgs e)
        {
            LoadProfile();
        }

        void LoadProfile()
        {
            tabControl1.SelectedTab = tabProfile;
            profileNode.Load(selectpath);

            profileNode.QueryData(Server.ServerPath);
            RefreshChart();
            toolCompute.PerformClick();

            reload = false;
            dateBeginDate.Value = profileNode.BeginTime;
            dateBeginTime.Value = profileNode.BeginTime;
            dateEndTime.Value = profileNode.EndTime;
            reload = true;
        }
    }
}
