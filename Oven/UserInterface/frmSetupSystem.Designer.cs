namespace YS_6000.UserInterface
{
    partial class frmSetupSystem
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
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnParamFile = new System.Windows.Forms.Button();
            this.pnlSetup = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(84)))), ((int)(((byte)(94)))));
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegister.Font = new System.Drawing.Font("楷体", 12F);
            this.btnRegister.ForeColor = System.Drawing.Color.White;
            this.btnRegister.Location = new System.Drawing.Point(171, 2);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 419;
            this.btnRegister.Text = "注册";
            this.btnRegister.UseVisualStyleBackColor = false;
            // 
            // btnUser
            // 
            this.btnUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(84)))), ((int)(((byte)(94)))));
            this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUser.Font = new System.Drawing.Font("楷体", 12F);
            this.btnUser.ForeColor = System.Drawing.Color.White;
            this.btnUser.Location = new System.Drawing.Point(90, 2);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(75, 23);
            this.btnUser.TabIndex = 418;
            this.btnUser.Text = "用户";
            this.btnUser.UseVisualStyleBackColor = false;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnParamFile
            // 
            this.btnParamFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(84)))), ((int)(((byte)(94)))));
            this.btnParamFile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnParamFile.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnParamFile.ForeColor = System.Drawing.Color.White;
            this.btnParamFile.Location = new System.Drawing.Point(9, 2);
            this.btnParamFile.Name = "btnParamFile";
            this.btnParamFile.Size = new System.Drawing.Size(75, 23);
            this.btnParamFile.TabIndex = 417;
            this.btnParamFile.Text = "档案";
            this.btnParamFile.UseVisualStyleBackColor = false;
            this.btnParamFile.Click += new System.EventHandler(this.btnParamFile_Click);
            // 
            // pnlSetup
            // 
            this.pnlSetup.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlSetup.Location = new System.Drawing.Point(5, 27);
            this.pnlSetup.Name = "pnlSetup";
            this.pnlSetup.Size = new System.Drawing.Size(812, 579);
            this.pnlSetup.TabIndex = 416;
            // 
            // frmSetupSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(65)))), ((int)(((byte)(72)))));
            this.ClientSize = new System.Drawing.Size(829, 622);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnUser);
            this.Controls.Add(this.btnParamFile);
            this.Controls.Add(this.pnlSetup);
            this.Name = "frmSetupSystem";
            this.Text = "frmSetupSystem";
            this.Load += new System.EventHandler(this.frmSetupSystem_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSetup;
        private System.Windows.Forms.Button btnParamFile;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Button btnRegister;
    }
}