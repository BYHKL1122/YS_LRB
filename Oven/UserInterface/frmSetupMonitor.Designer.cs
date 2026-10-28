namespace YS_6000.UserInterface
{
    partial class frmSetupMonitor
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
            this.btnAlarm = new System.Windows.Forms.Button();
            this.btnParamter = new System.Windows.Forms.Button();
            this.pnlSetup = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnAlarm
            // 
            this.btnAlarm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(84)))), ((int)(((byte)(94)))));
            this.btnAlarm.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAlarm.Font = new System.Drawing.Font("楷体", 12F);
            this.btnAlarm.ForeColor = System.Drawing.Color.White;
            this.btnAlarm.Location = new System.Drawing.Point(3, 4);
            this.btnAlarm.Name = "btnAlarm";
            this.btnAlarm.Size = new System.Drawing.Size(75, 23);
            this.btnAlarm.TabIndex = 428;
            this.btnAlarm.Tag = "1";
            this.btnAlarm.Text = "报警";
            this.btnAlarm.UseVisualStyleBackColor = false;
            this.btnAlarm.Click += new System.EventHandler(this.btnAlarm_Click);
            // 
            // btnParamter
            // 
            this.btnParamter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(84)))), ((int)(((byte)(94)))));
            this.btnParamter.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnParamter.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnParamter.ForeColor = System.Drawing.Color.White;
            this.btnParamter.Location = new System.Drawing.Point(84, 3);
            this.btnParamter.Name = "btnParamter";
            this.btnParamter.Size = new System.Drawing.Size(75, 23);
            this.btnParamter.TabIndex = 427;
            this.btnParamter.Tag = "1";
            this.btnParamter.Text = "参数";
            this.btnParamter.UseVisualStyleBackColor = false;
            this.btnParamter.Click += new System.EventHandler(this.btnParamter_Click);
            // 
            // pnlSetup
            // 
            this.pnlSetup.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlSetup.Location = new System.Drawing.Point(2, 31);
            this.pnlSetup.Name = "pnlSetup";
            this.pnlSetup.Size = new System.Drawing.Size(981, 614);
            this.pnlSetup.TabIndex = 426;
            // 
            // frmSetupMonitor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 691);
            this.Controls.Add(this.btnAlarm);
            this.Controls.Add(this.btnParamter);
            this.Controls.Add(this.pnlSetup);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmSetupMonitor";
            this.Text = "frmSetupMonitor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAlarm;
        private System.Windows.Forms.Button btnParamter;
        private System.Windows.Forms.Panel pnlSetup;
    }
}