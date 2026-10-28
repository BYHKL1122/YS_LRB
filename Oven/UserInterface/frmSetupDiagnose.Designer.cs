namespace YS_6000.UserInterface
{
    partial class frmSetupDiagnose
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
            this.btnMotor = new System.Windows.Forms.Button();
            this.btnIO = new System.Windows.Forms.Button();
            this.pnlSetup = new System.Windows.Forms.Panel();
            this.btnInitialize = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMotor
            // 
            this.btnMotor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(84)))), ((int)(((byte)(94)))));
            this.btnMotor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMotor.Font = new System.Drawing.Font("楷体", 12F);
            this.btnMotor.ForeColor = System.Drawing.Color.White;
            this.btnMotor.Location = new System.Drawing.Point(84, 2);
            this.btnMotor.Name = "btnMotor";
            this.btnMotor.Size = new System.Drawing.Size(75, 23);
            this.btnMotor.TabIndex = 425;
            this.btnMotor.Tag = "1";
            this.btnMotor.Text = "电机";
            this.btnMotor.UseVisualStyleBackColor = false;
            this.btnMotor.Click += new System.EventHandler(this.btnMotor_Click);
            // 
            // btnIO
            // 
            this.btnIO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(84)))), ((int)(((byte)(94)))));
            this.btnIO.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIO.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnIO.ForeColor = System.Drawing.Color.White;
            this.btnIO.Location = new System.Drawing.Point(3, 2);
            this.btnIO.Name = "btnIO";
            this.btnIO.Size = new System.Drawing.Size(75, 23);
            this.btnIO.TabIndex = 424;
            this.btnIO.Tag = "1";
            this.btnIO.Text = "点位";
            this.btnIO.UseVisualStyleBackColor = false;
            this.btnIO.Click += new System.EventHandler(this.btnIO_Click);
            // 
            // pnlSetup
            // 
            this.pnlSetup.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlSetup.Location = new System.Drawing.Point(3, 30);
            this.pnlSetup.Name = "pnlSetup";
            this.pnlSetup.Size = new System.Drawing.Size(981, 641);
            this.pnlSetup.TabIndex = 423;
            // 
            // btnInitialize
            // 
            this.btnInitialize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(84)))), ((int)(((byte)(94)))));
            this.btnInitialize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInitialize.Font = new System.Drawing.Font("楷体", 12F);
            this.btnInitialize.ForeColor = System.Drawing.Color.White;
            this.btnInitialize.Location = new System.Drawing.Point(165, 2);
            this.btnInitialize.Name = "btnInitialize";
            this.btnInitialize.Size = new System.Drawing.Size(75, 23);
            this.btnInitialize.TabIndex = 426;
            this.btnInitialize.Text = "归零";
            this.btnInitialize.UseVisualStyleBackColor = false;
            this.btnInitialize.Click += new System.EventHandler(this.btnInitialize_Click);
            // 
            // frmSetupDiagnose
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 683);
            this.Controls.Add(this.btnInitialize);
            this.Controls.Add(this.btnMotor);
            this.Controls.Add(this.btnIO);
            this.Controls.Add(this.pnlSetup);
            this.Name = "frmSetupDiagnose";
            this.Text = "frmSetupDiagnose";
            this.Load += new System.EventHandler(this.frmSetupDiagnose_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMotor;
        private System.Windows.Forms.Button btnIO;
        private System.Windows.Forms.Panel pnlSetup;
        private System.Windows.Forms.Button btnInitialize;
    }
}