namespace YS_6000.UserInterface
{
    partial class frmSetupProduct
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
            this.btnData = new System.Windows.Forms.Button();
            this.btnSwitch = new System.Windows.Forms.Button();
            this.pnlSetup = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnData
            // 
            this.btnData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(84)))), ((int)(((byte)(94)))));
            this.btnData.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnData.Font = new System.Drawing.Font("楷体", 12F);
            this.btnData.ForeColor = System.Drawing.Color.White;
            this.btnData.Location = new System.Drawing.Point(97, 2);
            this.btnData.Name = "btnData";
            this.btnData.Size = new System.Drawing.Size(75, 23);
            this.btnData.TabIndex = 422;
            this.btnData.Text = "数据";
            this.btnData.UseVisualStyleBackColor = false;
            this.btnData.Click += new System.EventHandler(this.btnData_Click);
            // 
            // btnSwitch
            // 
            this.btnSwitch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(84)))), ((int)(((byte)(94)))));
            this.btnSwitch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSwitch.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSwitch.ForeColor = System.Drawing.Color.White;
            this.btnSwitch.Location = new System.Drawing.Point(16, 2);
            this.btnSwitch.Name = "btnSwitch";
            this.btnSwitch.Size = new System.Drawing.Size(75, 23);
            this.btnSwitch.TabIndex = 421;
            this.btnSwitch.Text = "开关";
            this.btnSwitch.UseVisualStyleBackColor = false;
            this.btnSwitch.Click += new System.EventHandler(this.btnSwitch_Click);
            // 
            // pnlSetup
            // 
            this.pnlSetup.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlSetup.Location = new System.Drawing.Point(12, 29);
            this.pnlSetup.Name = "pnlSetup";
            this.pnlSetup.Size = new System.Drawing.Size(1024, 643);
            this.pnlSetup.TabIndex = 420;
            // 
            // frmSetupProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(65)))), ((int)(((byte)(72)))));
            this.ClientSize = new System.Drawing.Size(1082, 704);
            this.Controls.Add(this.btnData);
            this.Controls.Add(this.btnSwitch);
            this.Controls.Add(this.pnlSetup);
            this.Name = "frmSetupProduct";
            this.Text = "frmSetupProduct";
            this.Load += new System.EventHandler(this.frmSetupProduct_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnData;
        private System.Windows.Forms.Button btnSwitch;
        private System.Windows.Forms.Panel pnlSetup;
    }
}