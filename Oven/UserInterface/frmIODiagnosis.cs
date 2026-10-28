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
using YS_6000.UserInterface;
namespace YS_6000
{
    public partial class frmIODiagnosis : frmBaseDialog
    {

        IO output;

        public frmIODiagnosis()
        {
            InitializeComponent();

            dgvInput.ColumnHeadersDefaultCellStyle.Font = new Font("楷体", 12);
            dgvInput.RowsDefaultCellStyle.Font = new Font("楷体", 12);
            //dgvInput.RowsDefaultCellStyle.BackColor = Color.Ivory;
            //dgvInput.AlternatingRowsDefaultCellStyle.BackColor = Color.PaleTurquoise;
            dgvInput.ColumnCount = 4;
            dgvInput.Columns[0].Name = "点位";
            dgvInput.Columns[0].Width = 60;
            dgvInput.Columns[1].Name = "Name";
            dgvInput.Columns[1].Width = 160;
            dgvInput.Columns[2].Name = "名称";
            dgvInput.Columns[2].Width = 150;
            dgvInput.Columns[3].Name = "逻辑";
            dgvInput.Columns[3].Width = 70;
            dgvInput.Columns[3].ValueType = typeof(Boolean);
            dgvInput.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;




            //------------------------- 
            dgvOutput.ColumnHeadersDefaultCellStyle.Font = new Font("楷体", 12);
            dgvOutput.RowsDefaultCellStyle.Font = new Font("楷体", 12);
            //dgvOutput.RowsDefaultCellStyle.BackColor = Color.Ivory;
            //dgvOutput.AlternatingRowsDefaultCellStyle.BackColor = Color.PaleTurquoise;
            dgvOutput.ColumnCount = 3;
            dgvOutput.Columns[0].Name = "点位";
            dgvOutput.Columns[0].Width = 60;
            dgvOutput.Columns[1].Name = "Name";
            dgvOutput.Columns[1].Width = 160;
            dgvOutput.Columns[2].Name = "名称";
            dgvOutput.Columns[2].Width = 150;

            DataGridViewButtonColumn columncb = new DataGridViewButtonColumn();
            columncb.HeaderText = "状态";
            columncb.Name = "状态";
            columncb.DefaultCellStyle.NullValue = true;
            columncb.UseColumnTextForButtonValue = false;
            columncb.Width = 70;
            dgvOutput.Columns.Add(columncb);

        }

        private void frmIODiagnosis_Load(object sender, EventArgs e)
        {

            KeyPreview = true;
            TopMost = true;
     

            initForm();
        }


        void initForm()
        {
            cmbModuleInput.Items.Clear();
            cmbModuleInput.Items.Add("All");
            cmbModuleOutput.Items.Clear();
            cmbModuleOutput.Items.Add("All");
            for (int i = 0; i < Assembly.moduleList.Count; i++)
            {
                cmbModuleInput.Items.Add(Assembly.moduleList[i].Name);
                cmbModuleOutput.Items.Add(Assembly.moduleList[i].Name);
            }
            cmbModuleInput.Text = Assembly.moduleList[0].Name;
            cmbModuleOutput.Text = Assembly.moduleList[0].Name;

        }
        private void cmbModuleOutput_SelectedIndexChanged(object sender, EventArgs e)
        {
            String module = cmbModuleOutput.Text;

            dgvOutput.Rows.Clear();
            for (int i=0; i<IO.Outputs.Count; i++)
            {
                if ((IO.Outputs[i].Module== module || module=="All"))
                {

                    var index = dgvOutput.Rows.Add();
                    dgvOutput.Rows[index].Cells["点位"].Value = IO.Outputs[i].Address;
                    dgvOutput.Rows[index].Cells["Name"].Value = IO.Outputs[i].Name;
                    dgvOutput.Rows[index].Cells["名称"].Value = IO.Outputs[i].Description;
                    dgvOutput.Rows[index].Cells["状态"].Value = IO.Outputs[i].getState() ? "●" : "";

                }
            }


        }

        private void txtInterval_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }

        private void cmbModuleInput_SelectedIndexChanged(object sender, EventArgs e)
        {
            String module = cmbModuleInput.Text;

            dgvInput.Rows.Clear();
            for (int i = 0; i < IO.Inputs.Count; i++)
            {
                if ((IO.Inputs[i].Module == module || module == "All") )
                {

                    var index = dgvInput.Rows.Add();
                    dgvInput.Rows[index].Cells["点位"].Value = IO.Inputs[i].Address;
                    dgvInput.Rows[index].Cells["Name"].Value = IO.Inputs[i].Name;
                    dgvInput.Rows[index].Cells["名称"].Value = IO.Inputs[i].Description;
                    dgvInput.Rows[index].Cells["逻辑"].Value = IO.Inputs[i].getLogical() ? "●" : "";

                }
            }

        }



        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int index = 0; index < dgvInput.RowCount; index++)
            {
                String addr = dgvInput.Rows[index].Cells["点位"].Value.ToString();
                IO p = IO.FindAddress(addr);
                dgvInput.Rows[index].Cells["逻辑"].Value = p.getLogical() ? "●" : "";

            }

            for (int index = 0; index < dgvOutput.RowCount; index++)
            {
                String addr = dgvOutput.Rows[index].Cells["点位"].Value.ToString();
                IO p = IO.FindAddress(addr);
                dgvOutput.Rows[index].Cells["状态"].Value = p.getState() ? "●" : "";
            }
        }



        private void dgvOutput_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int r=e.RowIndex;
            int row = dgvOutput.SelectedCells[0].RowIndex;
            string addr = dgvOutput.Rows[row].Cells["点位"].Value.ToString();
            output = IO.FindAddress(addr);
        }

        private void dgvOutput_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            //注释：

            //dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn 说明点击的列是DataGridViewButtonColumn列

            //当然你也根据e.ColumnIndex == 你的按钮列的索引来做// e.RowIndex > -1 ，说明点击的不是列头

            if (dgvOutput.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex > -1)

            {

                //获取当前被点击的单元格

                DataGridViewButtonCell vCell = (DataGridViewButtonCell)dgvOutput.CurrentCell;


                //if (this.dgvOutput.CurrentCell.Value.ToString() == "On")
                //{
                //    this.dgvOutput.CurrentCell.Value = "Off";
                //}
                //else
                //{               
                //    this.dgvOutput.CurrentCell.Value = "On";
                //}
                string addr = dgvOutput.Rows[e.RowIndex].Cells["点位"].Value.ToString();
                output = IO.FindAddress(addr);
                if (output.getState())
                {
                    output.setOff();
                    this.dgvOutput.CurrentCell.Value = "";
                }
                else
                {
                    output.setOn();
                    this.dgvOutput.CurrentCell.Value = "●";
                }
            }
        }

        private void frmIODiagnosis_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
