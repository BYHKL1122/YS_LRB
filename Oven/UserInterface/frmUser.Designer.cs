namespace YS_6000.UserInterface
{
    partial class frmUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUser));
            this.cmdKeyPad = new System.Windows.Forms.Button();
            this.fmKeyPad = new System.Windows.Forms.GroupBox();
            this.cmdKeyEnter = new System.Windows.Forms.Button();
            this.cmdKeyBackspace = new System.Windows.Forms.Button();
            this.cmdKeyNum0 = new System.Windows.Forms.Button();
            this.cmdKeyNum3 = new System.Windows.Forms.Button();
            this.cmdKeyNum2 = new System.Windows.Forms.Button();
            this.cmdKeyNum1 = new System.Windows.Forms.Button();
            this.cmdKeyNum6 = new System.Windows.Forms.Button();
            this.cmdKeyNum5 = new System.Windows.Forms.Button();
            this.cmdKeyNum9 = new System.Windows.Forms.Button();
            this.cmdKeyNum8 = new System.Windows.Forms.Button();
            this.cmdKeyNum4 = new System.Windows.Forms.Button();
            this.cmdKeyNum7 = new System.Windows.Forms.Button();
            this.txtTimeOut = new System.Windows.Forms.TextBox();
            this.lblTimeOut = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnLogout = new System.Windows.Forms.Button();
            this.BtnReset = new System.Windows.Forms.Button();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassWord = new System.Windows.Forms.Label();
            this.cmbJurisdiction = new System.Windows.Forms.ComboBox();
            this.fmKeyPad.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdKeyPad
            // 
            this.cmdKeyPad.Image = ((System.Drawing.Image)(resources.GetObject("cmdKeyPad.Image")));
            this.cmdKeyPad.Location = new System.Drawing.Point(454, 12);
            this.cmdKeyPad.Name = "cmdKeyPad";
            this.cmdKeyPad.Size = new System.Drawing.Size(54, 37);
            this.cmdKeyPad.TabIndex = 109;
            this.cmdKeyPad.UseVisualStyleBackColor = true;
            this.cmdKeyPad.Click += new System.EventHandler(this.cmdKeyPad_Click);
            // 
            // fmKeyPad
            // 
            this.fmKeyPad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(65)))), ((int)(((byte)(72)))));
            this.fmKeyPad.Controls.Add(this.cmdKeyEnter);
            this.fmKeyPad.Controls.Add(this.cmdKeyBackspace);
            this.fmKeyPad.Controls.Add(this.cmdKeyNum0);
            this.fmKeyPad.Controls.Add(this.cmdKeyNum3);
            this.fmKeyPad.Controls.Add(this.cmdKeyNum2);
            this.fmKeyPad.Controls.Add(this.cmdKeyNum1);
            this.fmKeyPad.Controls.Add(this.cmdKeyNum6);
            this.fmKeyPad.Controls.Add(this.cmdKeyNum5);
            this.fmKeyPad.Controls.Add(this.cmdKeyNum9);
            this.fmKeyPad.Controls.Add(this.cmdKeyNum8);
            this.fmKeyPad.Controls.Add(this.cmdKeyNum4);
            this.fmKeyPad.Controls.Add(this.cmdKeyNum7);
            this.fmKeyPad.Location = new System.Drawing.Point(157, 70);
            this.fmKeyPad.Name = "fmKeyPad";
            this.fmKeyPad.Size = new System.Drawing.Size(230, 181);
            this.fmKeyPad.TabIndex = 108;
            this.fmKeyPad.TabStop = false;
            // 
            // cmdKeyEnter
            // 
            this.cmdKeyEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(65)))), ((int)(((byte)(72)))));
            this.cmdKeyEnter.Font = new System.Drawing.Font("楷体", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdKeyEnter.ForeColor = System.Drawing.Color.White;
            this.cmdKeyEnter.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmdKeyEnter.Location = new System.Drawing.Point(174, 11);
            this.cmdKeyEnter.Name = "cmdKeyEnter";
            this.cmdKeyEnter.Size = new System.Drawing.Size(50, 158);
            this.cmdKeyEnter.TabIndex = 16;
            this.cmdKeyEnter.Text = "登 出 保 存";
            this.cmdKeyEnter.UseVisualStyleBackColor = false;
            this.cmdKeyEnter.Click += new System.EventHandler(this.cmdKeyEnter_Click);
            // 
            // cmdKeyBackspace
            // 
            this.cmdKeyBackspace.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(65)))), ((int)(((byte)(72)))));
            this.cmdKeyBackspace.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdKeyBackspace.ForeColor = System.Drawing.Color.White;
            this.cmdKeyBackspace.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmdKeyBackspace.Location = new System.Drawing.Point(62, 134);
            this.cmdKeyBackspace.Name = "cmdKeyBackspace";
            this.cmdKeyBackspace.Size = new System.Drawing.Size(106, 35);
            this.cmdKeyBackspace.TabIndex = 12;
            this.cmdKeyBackspace.Text = "backspace";
            this.cmdKeyBackspace.UseVisualStyleBackColor = false;
            this.cmdKeyBackspace.Click += new System.EventHandler(this.cmdKeyBackspace_Click);
            // 
            // cmdKeyNum0
            // 
            this.cmdKeyNum0.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(65)))), ((int)(((byte)(72)))));
            this.cmdKeyNum0.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdKeyNum0.ForeColor = System.Drawing.Color.White;
            this.cmdKeyNum0.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmdKeyNum0.Location = new System.Drawing.Point(6, 134);
            this.cmdKeyNum0.Name = "cmdKeyNum0";
            this.cmdKeyNum0.Size = new System.Drawing.Size(50, 35);
            this.cmdKeyNum0.TabIndex = 11;
            this.cmdKeyNum0.Text = "0";
            this.cmdKeyNum0.UseVisualStyleBackColor = false;
            this.cmdKeyNum0.Click += new System.EventHandler(this.cmdKeyNum0_Click);
            // 
            // cmdKeyNum3
            // 
            this.cmdKeyNum3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(65)))), ((int)(((byte)(72)))));
            this.cmdKeyNum3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdKeyNum3.ForeColor = System.Drawing.Color.White;
            this.cmdKeyNum3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmdKeyNum3.Location = new System.Drawing.Point(118, 93);
            this.cmdKeyNum3.Name = "cmdKeyNum3";
            this.cmdKeyNum3.Size = new System.Drawing.Size(50, 35);
            this.cmdKeyNum3.TabIndex = 10;
            this.cmdKeyNum3.Text = "3";
            this.cmdKeyNum3.UseVisualStyleBackColor = false;
            this.cmdKeyNum3.Click += new System.EventHandler(this.cmdKeyNum0_Click);
            // 
            // cmdKeyNum2
            // 
            this.cmdKeyNum2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(65)))), ((int)(((byte)(72)))));
            this.cmdKeyNum2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdKeyNum2.ForeColor = System.Drawing.Color.White;
            this.cmdKeyNum2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmdKeyNum2.Location = new System.Drawing.Point(62, 93);
            this.cmdKeyNum2.Name = "cmdKeyNum2";
            this.cmdKeyNum2.Size = new System.Drawing.Size(50, 35);
            this.cmdKeyNum2.TabIndex = 9;
            this.cmdKeyNum2.Text = "2";
            this.cmdKeyNum2.UseVisualStyleBackColor = false;
            this.cmdKeyNum2.Click += new System.EventHandler(this.cmdKeyNum0_Click);
            // 
            // cmdKeyNum1
            // 
            this.cmdKeyNum1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(65)))), ((int)(((byte)(72)))));
            this.cmdKeyNum1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdKeyNum1.ForeColor = System.Drawing.Color.White;
            this.cmdKeyNum1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmdKeyNum1.Location = new System.Drawing.Point(6, 93);
            this.cmdKeyNum1.Name = "cmdKeyNum1";
            this.cmdKeyNum1.Size = new System.Drawing.Size(50, 35);
            this.cmdKeyNum1.TabIndex = 8;
            this.cmdKeyNum1.Text = "1";
            this.cmdKeyNum1.UseVisualStyleBackColor = false;
            this.cmdKeyNum1.Click += new System.EventHandler(this.cmdKeyNum0_Click);
            // 
            // cmdKeyNum6
            // 
            this.cmdKeyNum6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(65)))), ((int)(((byte)(72)))));
            this.cmdKeyNum6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdKeyNum6.ForeColor = System.Drawing.Color.White;
            this.cmdKeyNum6.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmdKeyNum6.Location = new System.Drawing.Point(118, 52);
            this.cmdKeyNum6.Name = "cmdKeyNum6";
            this.cmdKeyNum6.Size = new System.Drawing.Size(50, 35);
            this.cmdKeyNum6.TabIndex = 7;
            this.cmdKeyNum6.Text = "6";
            this.cmdKeyNum6.UseVisualStyleBackColor = false;
            this.cmdKeyNum6.Click += new System.EventHandler(this.cmdKeyNum0_Click);
            // 
            // cmdKeyNum5
            // 
            this.cmdKeyNum5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(65)))), ((int)(((byte)(72)))));
            this.cmdKeyNum5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdKeyNum5.ForeColor = System.Drawing.Color.White;
            this.cmdKeyNum5.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmdKeyNum5.Location = new System.Drawing.Point(62, 52);
            this.cmdKeyNum5.Name = "cmdKeyNum5";
            this.cmdKeyNum5.Size = new System.Drawing.Size(50, 35);
            this.cmdKeyNum5.TabIndex = 6;
            this.cmdKeyNum5.Text = "5";
            this.cmdKeyNum5.UseVisualStyleBackColor = false;
            this.cmdKeyNum5.Click += new System.EventHandler(this.cmdKeyNum0_Click);
            // 
            // cmdKeyNum9
            // 
            this.cmdKeyNum9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(65)))), ((int)(((byte)(72)))));
            this.cmdKeyNum9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdKeyNum9.ForeColor = System.Drawing.Color.White;
            this.cmdKeyNum9.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmdKeyNum9.Location = new System.Drawing.Point(118, 11);
            this.cmdKeyNum9.Name = "cmdKeyNum9";
            this.cmdKeyNum9.Size = new System.Drawing.Size(50, 35);
            this.cmdKeyNum9.TabIndex = 5;
            this.cmdKeyNum9.Text = "9";
            this.cmdKeyNum9.UseVisualStyleBackColor = false;
            this.cmdKeyNum9.Click += new System.EventHandler(this.cmdKeyNum0_Click);
            // 
            // cmdKeyNum8
            // 
            this.cmdKeyNum8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(65)))), ((int)(((byte)(72)))));
            this.cmdKeyNum8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdKeyNum8.ForeColor = System.Drawing.Color.White;
            this.cmdKeyNum8.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmdKeyNum8.Location = new System.Drawing.Point(62, 11);
            this.cmdKeyNum8.Name = "cmdKeyNum8";
            this.cmdKeyNum8.Size = new System.Drawing.Size(50, 35);
            this.cmdKeyNum8.TabIndex = 4;
            this.cmdKeyNum8.Text = "8";
            this.cmdKeyNum8.UseVisualStyleBackColor = false;
            this.cmdKeyNum8.Click += new System.EventHandler(this.cmdKeyNum0_Click);
            // 
            // cmdKeyNum4
            // 
            this.cmdKeyNum4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(65)))), ((int)(((byte)(72)))));
            this.cmdKeyNum4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdKeyNum4.ForeColor = System.Drawing.Color.White;
            this.cmdKeyNum4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmdKeyNum4.Location = new System.Drawing.Point(6, 52);
            this.cmdKeyNum4.Name = "cmdKeyNum4";
            this.cmdKeyNum4.Size = new System.Drawing.Size(50, 35);
            this.cmdKeyNum4.TabIndex = 3;
            this.cmdKeyNum4.Text = "4";
            this.cmdKeyNum4.UseVisualStyleBackColor = false;
            this.cmdKeyNum4.Click += new System.EventHandler(this.cmdKeyNum0_Click);
            // 
            // cmdKeyNum7
            // 
            this.cmdKeyNum7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(65)))), ((int)(((byte)(72)))));
            this.cmdKeyNum7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdKeyNum7.ForeColor = System.Drawing.Color.White;
            this.cmdKeyNum7.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cmdKeyNum7.Location = new System.Drawing.Point(6, 11);
            this.cmdKeyNum7.Name = "cmdKeyNum7";
            this.cmdKeyNum7.Size = new System.Drawing.Size(50, 35);
            this.cmdKeyNum7.TabIndex = 2;
            this.cmdKeyNum7.Text = "7";
            this.cmdKeyNum7.UseVisualStyleBackColor = false;
            this.cmdKeyNum7.Click += new System.EventHandler(this.cmdKeyNum0_Click);
            // 
            // txtTimeOut
            // 
            this.txtTimeOut.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTimeOut.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtTimeOut.Location = new System.Drawing.Point(269, 39);
            this.txtTimeOut.Margin = new System.Windows.Forms.Padding(2);
            this.txtTimeOut.Name = "txtTimeOut";
            this.txtTimeOut.Size = new System.Drawing.Size(118, 26);
            this.txtTimeOut.TabIndex = 107;
            this.txtTimeOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTimeOut
            // 
            this.lblTimeOut.AutoSize = true;
            this.lblTimeOut.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTimeOut.ForeColor = System.Drawing.Color.White;
            this.lblTimeOut.Location = new System.Drawing.Point(278, 12);
            this.lblTimeOut.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTimeOut.Name = "lblTimeOut";
            this.lblTimeOut.Size = new System.Drawing.Size(109, 19);
            this.lblTimeOut.TabIndex = 106;
            this.lblTimeOut.Text = "登出(分钟)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(46, 12);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 19);
            this.label1.TabIndex = 105;
            this.label1.Text = "用户";
            // 
            // BtnLogout
            // 
            this.BtnLogout.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnLogout.Location = new System.Drawing.Point(417, 197);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.Size = new System.Drawing.Size(91, 33);
            this.BtnLogout.TabIndex = 104;
            this.BtnLogout.Text = "登出";
            this.BtnLogout.UseVisualStyleBackColor = true;
            this.BtnLogout.Click += new System.EventHandler(this.BtnLogout_Click);
            // 
            // BtnReset
            // 
            this.BtnReset.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnReset.Location = new System.Drawing.Point(417, 130);
            this.BtnReset.Margin = new System.Windows.Forms.Padding(2);
            this.BtnReset.Name = "BtnReset";
            this.BtnReset.Size = new System.Drawing.Size(91, 39);
            this.BtnReset.TabIndex = 103;
            this.BtnReset.Text = "修改";
            this.BtnReset.UseVisualStyleBackColor = true;
            this.BtnReset.Click += new System.EventHandler(this.BtnReset_Click);
            // 
            // BtnLogin
            // 
            this.BtnLogin.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BtnLogin.Location = new System.Drawing.Point(417, 70);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(91, 33);
            this.BtnLogin.TabIndex = 102;
            this.BtnLogin.Text = "登录";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtPassword.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtPassword.Location = new System.Drawing.Point(134, 39);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(118, 26);
            this.txtPassword.TabIndex = 101;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblPassWord
            // 
            this.lblPassWord.AutoSize = true;
            this.lblPassWord.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblPassWord.ForeColor = System.Drawing.Color.White;
            this.lblPassWord.Location = new System.Drawing.Point(159, 12);
            this.lblPassWord.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassWord.Name = "lblPassWord";
            this.lblPassWord.Size = new System.Drawing.Size(49, 19);
            this.lblPassWord.TabIndex = 100;
            this.lblPassWord.Text = "密码";
            // 
            // cmbJurisdiction
            // 
            this.cmbJurisdiction.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbJurisdiction.FormattingEnabled = true;
            this.cmbJurisdiction.ItemHeight = 19;
            this.cmbJurisdiction.Location = new System.Drawing.Point(12, 37);
            this.cmbJurisdiction.Name = "cmbJurisdiction";
            this.cmbJurisdiction.Size = new System.Drawing.Size(114, 27);
            this.cmbJurisdiction.TabIndex = 22;
            // 
            // frmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(65)))), ((int)(((byte)(72)))));
            this.ClientSize = new System.Drawing.Size(600, 302);
            this.Controls.Add(this.cmdKeyPad);
            this.Controls.Add(this.fmKeyPad);
            this.Controls.Add(this.txtTimeOut);
            this.Controls.Add(this.lblTimeOut);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnLogout);
            this.Controls.Add(this.BtnReset);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.lblPassWord);
            this.Controls.Add(this.cmbJurisdiction);
            this.Name = "frmUser";
            this.Text = "等级设定";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmFnLevelSet_FormClosed);
            this.Load += new System.EventHandler(this.frmFnLevelSet_Load);
            this.fmKeyPad.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbJurisdiction;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassWord;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Button BtnReset;
        private System.Windows.Forms.Button BtnLogout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTimeOut;
        private System.Windows.Forms.Label lblTimeOut;
        public System.Windows.Forms.GroupBox fmKeyPad;
        public System.Windows.Forms.Button cmdKeyEnter;
        public System.Windows.Forms.Button cmdKeyBackspace;
        public System.Windows.Forms.Button cmdKeyNum0;
        public System.Windows.Forms.Button cmdKeyNum3;
        public System.Windows.Forms.Button cmdKeyNum2;
        public System.Windows.Forms.Button cmdKeyNum1;
        public System.Windows.Forms.Button cmdKeyNum6;
        public System.Windows.Forms.Button cmdKeyNum5;
        public System.Windows.Forms.Button cmdKeyNum9;
        public System.Windows.Forms.Button cmdKeyNum8;
        public System.Windows.Forms.Button cmdKeyNum4;
        public System.Windows.Forms.Button cmdKeyNum7;
        private System.Windows.Forms.Button cmdKeyPad;
    }
}