namespace YS_6000
{
    partial class frmIODiagnosis
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.cmbModuleOutput = new System.Windows.Forms.ComboBox();
            this.dgvOutput = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbModuleInput = new System.Windows.Forms.ComboBox();
            this.dgvInput = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInput)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(596, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "模组";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cmbModuleOutput
            // 
            this.cmbModuleOutput.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbModuleOutput.FormattingEnabled = true;
            this.cmbModuleOutput.Location = new System.Drawing.Point(651, 12);
            this.cmbModuleOutput.Name = "cmbModuleOutput";
            this.cmbModuleOutput.Size = new System.Drawing.Size(139, 24);
            this.cmbModuleOutput.TabIndex = 4;
            this.cmbModuleOutput.SelectedIndexChanged += new System.EventHandler(this.cmbModuleOutput_SelectedIndexChanged);
            // 
            // dgvOutput
            // 
            this.dgvOutput.AllowUserToAddRows = false;
            this.dgvOutput.AllowUserToDeleteRows = false;
            this.dgvOutput.AllowUserToOrderColumns = true;
            this.dgvOutput.AllowUserToResizeRows = false;
            this.dgvOutput.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(65)))), ((int)(((byte)(72)))));
            this.dgvOutput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOutput.Location = new System.Drawing.Point(493, 54);
            this.dgvOutput.Name = "dgvOutput";
            this.dgvOutput.ReadOnly = true;
            this.dgvOutput.RowTemplate.Height = 30;
            this.dgvOutput.Size = new System.Drawing.Size(501, 525);
            this.dgvOutput.TabIndex = 3;
            this.dgvOutput.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOutput_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(65)))), ((int)(((byte)(72)))));
            this.label1.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(53, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "模组";
            // 
            // cmbModuleInput
            // 
            this.cmbModuleInput.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbModuleInput.FormattingEnabled = true;
            this.cmbModuleInput.Location = new System.Drawing.Point(108, 12);
            this.cmbModuleInput.Name = "cmbModuleInput";
            this.cmbModuleInput.Size = new System.Drawing.Size(131, 24);
            this.cmbModuleInput.TabIndex = 1;
            this.cmbModuleInput.SelectedIndexChanged += new System.EventHandler(this.cmbModuleInput_SelectedIndexChanged);
            // 
            // dgvInput
            // 
            this.dgvInput.AllowUserToAddRows = false;
            this.dgvInput.AllowUserToDeleteRows = false;
            this.dgvInput.AllowUserToOrderColumns = true;
            this.dgvInput.AllowUserToResizeRows = false;
            this.dgvInput.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(65)))), ((int)(((byte)(72)))));
            this.dgvInput.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInput.Location = new System.Drawing.Point(4, 53);
            this.dgvInput.Name = "dgvInput";
            this.dgvInput.ReadOnly = true;
            this.dgvInput.RowTemplate.Height = 30;
            this.dgvInput.Size = new System.Drawing.Size(483, 525);
            this.dgvInput.TabIndex = 0;
            // 
            // frmIODiagnosis
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(65)))), ((int)(((byte)(72)))));
            this.ClientSize = new System.Drawing.Size(1009, 609);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbModuleOutput);
            this.Controls.Add(this.dgvOutput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbModuleInput);
            this.Controls.Add(this.dgvInput);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Name = "frmIODiagnosis";
            this.Text = "IO诊断";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmIODiagnosis_FormClosed);
            this.Load += new System.EventHandler(this.frmIODiagnosis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOutput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInput;
        private System.Windows.Forms.ComboBox cmbModuleInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvOutput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbModuleOutput;
        private System.Windows.Forms.Timer timer1;
    }
}