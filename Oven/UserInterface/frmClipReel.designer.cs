namespace YSOS.UserInterface
{
    partial class frmClipReel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClipReel));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label15 = new System.Windows.Forms.Label();
            this.BtnSetSpeed = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblSpacerDown = new System.Windows.Forms.Label();
            this.lblSpacerUp = new System.Windows.Forms.Label();
            this.btSpacerOff = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSpacerTimeOutDown = new System.Windows.Forms.Button();
            this.btnSpacerTimeOutUp = new System.Windows.Forms.Button();
            this.txtSpacerTimeOut = new System.Windows.Forms.TextBox();
            this.btnSpacerRoll = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblReelStop = new System.Windows.Forms.Label();
            this.lblReelStart = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnReelOff = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReleaseDelayDown = new System.Windows.Forms.Button();
            this.btnReleaseDelayUp = new System.Windows.Forms.Button();
            this.txtReleaseDelay = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnReelTimeOutDown = new System.Windows.Forms.Button();
            this.btnReelTimeOutUp = new System.Windows.Forms.Button();
            this.txtReelTimeOut = new System.Windows.Forms.TextBox();
            this.btnReleaseReel = new System.Windows.Forms.Button();
            this.btnInitialize = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(162, 9);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 19);
            this.label15.TabIndex = 166;
            this.label15.Text = "速度";
            // 
            // BtnSetSpeed
            // 
            this.BtnSetSpeed.BackColor = System.Drawing.Color.White;
            this.BtnSetSpeed.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold);
            this.BtnSetSpeed.ForeColor = System.Drawing.Color.Black;
            this.BtnSetSpeed.Location = new System.Drawing.Point(226, 2);
            this.BtnSetSpeed.Name = "BtnSetSpeed";
            this.BtnSetSpeed.Size = new System.Drawing.Size(36, 35);
            this.BtnSetSpeed.TabIndex = 165;
            this.BtnSetSpeed.Text = "慢";
            this.BtnSetSpeed.UseVisualStyleBackColor = false;
            this.BtnSetSpeed.Click += new System.EventHandler(this.BtnSetSpeed_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblSpacerDown);
            this.groupBox3.Controls.Add(this.lblSpacerUp);
            this.groupBox3.Controls.Add(this.btSpacerOff);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.btnSpacerTimeOutDown);
            this.groupBox3.Controls.Add(this.btnSpacerTimeOutUp);
            this.groupBox3.Controls.Add(this.txtSpacerTimeOut);
            this.groupBox3.Controls.Add(this.btnSpacerRoll);
            this.groupBox3.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(294, 40);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(253, 289);
            this.groupBox3.TabIndex = 77;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "纸卷";
            // 
            // lblSpacerDown
            // 
            this.lblSpacerDown.BackColor = System.Drawing.Color.Gray;
            this.lblSpacerDown.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSpacerDown.ForeColor = System.Drawing.Color.White;
            this.lblSpacerDown.Location = new System.Drawing.Point(151, 76);
            this.lblSpacerDown.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSpacerDown.Name = "lblSpacerDown";
            this.lblSpacerDown.Size = new System.Drawing.Size(35, 35);
            this.lblSpacerDown.TabIndex = 186;
            // 
            // lblSpacerUp
            // 
            this.lblSpacerUp.BackColor = System.Drawing.Color.Gray;
            this.lblSpacerUp.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSpacerUp.ForeColor = System.Drawing.Color.White;
            this.lblSpacerUp.Location = new System.Drawing.Point(151, 35);
            this.lblSpacerUp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSpacerUp.Name = "lblSpacerUp";
            this.lblSpacerUp.Size = new System.Drawing.Size(35, 35);
            this.lblSpacerUp.TabIndex = 185;
            // 
            // btSpacerOff
            // 
            this.btSpacerOff.BackColor = System.Drawing.Color.White;
            this.btSpacerOff.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btSpacerOff.ForeColor = System.Drawing.Color.Black;
            this.btSpacerOff.Location = new System.Drawing.Point(154, 186);
            this.btSpacerOff.Margin = new System.Windows.Forms.Padding(2);
            this.btSpacerOff.Name = "btSpacerOff";
            this.btSpacerOff.Size = new System.Drawing.Size(91, 37);
            this.btSpacerOff.TabIndex = 139;
            this.btSpacerOff.Text = "停止";
            this.btSpacerOff.UseVisualStyleBackColor = false;
            this.btSpacerOff.Click += new System.EventHandler(this.btSpacerOff_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(185, 89);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 16);
            this.label13.TabIndex = 138;
            this.label13.Text = "下位";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(185, 41);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 16);
            this.label12.TabIndex = 137;
            this.label12.Text = "上位";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(30, 30);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 16);
            this.label3.TabIndex = 80;
            this.label3.Text = "收纸时间(s)";
            // 
            // btnSpacerTimeOutDown
            // 
            this.btnSpacerTimeOutDown.Image = ((System.Drawing.Image)(resources.GetObject("btnSpacerTimeOutDown.Image")));
            this.btnSpacerTimeOutDown.Location = new System.Drawing.Point(76, 85);
            this.btnSpacerTimeOutDown.Margin = new System.Windows.Forms.Padding(2);
            this.btnSpacerTimeOutDown.Name = "btnSpacerTimeOutDown";
            this.btnSpacerTimeOutDown.Size = new System.Drawing.Size(40, 34);
            this.btnSpacerTimeOutDown.TabIndex = 79;
            this.btnSpacerTimeOutDown.Tag = "1";
            this.btnSpacerTimeOutDown.UseVisualStyleBackColor = true;
            this.btnSpacerTimeOutDown.Click += new System.EventHandler(this.btnSpacerTimeOutDown_Click);
            // 
            // btnSpacerTimeOutUp
            // 
            this.btnSpacerTimeOutUp.Image = global::YSOS.Properties.Resources.icons8_double_up_30;
            this.btnSpacerTimeOutUp.Location = new System.Drawing.Point(32, 85);
            this.btnSpacerTimeOutUp.Margin = new System.Windows.Forms.Padding(2);
            this.btnSpacerTimeOutUp.Name = "btnSpacerTimeOutUp";
            this.btnSpacerTimeOutUp.Size = new System.Drawing.Size(40, 34);
            this.btnSpacerTimeOutUp.TabIndex = 78;
            this.btnSpacerTimeOutUp.Tag = "1";
            this.btnSpacerTimeOutUp.UseVisualStyleBackColor = true;
            this.btnSpacerTimeOutUp.Click += new System.EventHandler(this.btnSpacerTimeOutUp_Click);
            // 
            // txtSpacerTimeOut
            // 
            this.txtSpacerTimeOut.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtSpacerTimeOut.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSpacerTimeOut.Location = new System.Drawing.Point(32, 50);
            this.txtSpacerTimeOut.Margin = new System.Windows.Forms.Padding(2);
            this.txtSpacerTimeOut.Name = "txtSpacerTimeOut";
            this.txtSpacerTimeOut.ReadOnly = true;
            this.txtSpacerTimeOut.Size = new System.Drawing.Size(84, 26);
            this.txtSpacerTimeOut.TabIndex = 77;
            this.txtSpacerTimeOut.Tag = "1";
            this.txtSpacerTimeOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSpacerRoll
            // 
            this.btnSpacerRoll.BackColor = System.Drawing.Color.White;
            this.btnSpacerRoll.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSpacerRoll.ForeColor = System.Drawing.Color.Black;
            this.btnSpacerRoll.Location = new System.Drawing.Point(154, 133);
            this.btnSpacerRoll.Margin = new System.Windows.Forms.Padding(2);
            this.btnSpacerRoll.Name = "btnSpacerRoll";
            this.btnSpacerRoll.Size = new System.Drawing.Size(91, 37);
            this.btnSpacerRoll.TabIndex = 76;
            this.btnSpacerRoll.Text = "收纸";
            this.btnSpacerRoll.UseVisualStyleBackColor = false;
            this.btnSpacerRoll.Visible = false;
            this.btnSpacerRoll.Click += new System.EventHandler(this.btnSpacerRoll_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblReelStop);
            this.groupBox2.Controls.Add(this.lblReelStart);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnReelOff);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnReleaseDelayDown);
            this.groupBox2.Controls.Add(this.btnReleaseDelayUp);
            this.groupBox2.Controls.Add(this.txtReleaseDelay);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnReelTimeOutDown);
            this.groupBox2.Controls.Add(this.btnReelTimeOutUp);
            this.groupBox2.Controls.Add(this.txtReelTimeOut);
            this.groupBox2.Controls.Add(this.btnReleaseReel);
            this.groupBox2.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(4, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(284, 289);
            this.groupBox2.TabIndex = 76;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "料卷";
            // 
            // lblReelStop
            // 
            this.lblReelStop.BackColor = System.Drawing.Color.Gray;
            this.lblReelStop.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblReelStop.ForeColor = System.Drawing.Color.White;
            this.lblReelStop.Location = new System.Drawing.Point(154, 73);
            this.lblReelStop.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReelStop.Name = "lblReelStop";
            this.lblReelStop.Size = new System.Drawing.Size(35, 35);
            this.lblReelStop.TabIndex = 185;
            // 
            // lblReelStart
            // 
            this.lblReelStart.BackColor = System.Drawing.Color.Gray;
            this.lblReelStart.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblReelStart.ForeColor = System.Drawing.Color.White;
            this.lblReelStart.Location = new System.Drawing.Point(154, 25);
            this.lblReelStart.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReelStart.Name = "lblReelStart";
            this.lblReelStart.Size = new System.Drawing.Size(35, 35);
            this.lblReelStart.TabIndex = 184;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(193, 76);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 16);
            this.label5.TabIndex = 140;
            this.label5.Text = "停检";
            // 
            // btnReelOff
            // 
            this.btnReelOff.BackColor = System.Drawing.Color.White;
            this.btnReelOff.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnReelOff.ForeColor = System.Drawing.Color.Black;
            this.btnReelOff.Location = new System.Drawing.Point(158, 189);
            this.btnReelOff.Margin = new System.Windows.Forms.Padding(2);
            this.btnReelOff.Name = "btnReelOff";
            this.btnReelOff.Size = new System.Drawing.Size(91, 37);
            this.btnReelOff.TabIndex = 138;
            this.btnReelOff.Text = "停止";
            this.btnReelOff.UseVisualStyleBackColor = false;
            this.btnReelOff.Click += new System.EventHandler(this.btnReelOff_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(193, 33);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 16);
            this.label14.TabIndex = 137;
            this.label14.Text = "动检";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(6, 133);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 85;
            this.label2.Text = "放料延迟(s)";
            // 
            // btnReleaseDelayDown
            // 
            this.btnReleaseDelayDown.Image = ((System.Drawing.Image)(resources.GetObject("btnReleaseDelayDown.Image")));
            this.btnReleaseDelayDown.Location = new System.Drawing.Point(53, 189);
            this.btnReleaseDelayDown.Margin = new System.Windows.Forms.Padding(2);
            this.btnReleaseDelayDown.Name = "btnReleaseDelayDown";
            this.btnReleaseDelayDown.Size = new System.Drawing.Size(40, 34);
            this.btnReleaseDelayDown.TabIndex = 84;
            this.btnReleaseDelayDown.Tag = "1";
            this.btnReleaseDelayDown.UseVisualStyleBackColor = true;
            this.btnReleaseDelayDown.Click += new System.EventHandler(this.btnReleaseDelayDown_Click);
            // 
            // btnReleaseDelayUp
            // 
            this.btnReleaseDelayUp.Image = global::YSOS.Properties.Resources.icons8_double_up_30;
            this.btnReleaseDelayUp.Location = new System.Drawing.Point(9, 189);
            this.btnReleaseDelayUp.Margin = new System.Windows.Forms.Padding(2);
            this.btnReleaseDelayUp.Name = "btnReleaseDelayUp";
            this.btnReleaseDelayUp.Size = new System.Drawing.Size(40, 34);
            this.btnReleaseDelayUp.TabIndex = 83;
            this.btnReleaseDelayUp.Tag = "1";
            this.btnReleaseDelayUp.UseVisualStyleBackColor = true;
            this.btnReleaseDelayUp.Click += new System.EventHandler(this.btnReleaseDelayUp_Click);
            // 
            // txtReleaseDelay
            // 
            this.txtReleaseDelay.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtReleaseDelay.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtReleaseDelay.Location = new System.Drawing.Point(9, 154);
            this.txtReleaseDelay.Margin = new System.Windows.Forms.Padding(2);
            this.txtReleaseDelay.Name = "txtReleaseDelay";
            this.txtReleaseDelay.ReadOnly = true;
            this.txtReleaseDelay.Size = new System.Drawing.Size(84, 26);
            this.txtReleaseDelay.TabIndex = 82;
            this.txtReleaseDelay.Tag = "1";
            this.txtReleaseDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(6, 28);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 16);
            this.label4.TabIndex = 80;
            this.label4.Text = "放料时间(s)";
            // 
            // btnReelTimeOutDown
            // 
            this.btnReelTimeOutDown.Image = global::YSOS.Properties.Resources.icons8_double_down_30;
            this.btnReelTimeOutDown.Location = new System.Drawing.Point(52, 83);
            this.btnReelTimeOutDown.Margin = new System.Windows.Forms.Padding(2);
            this.btnReelTimeOutDown.Name = "btnReelTimeOutDown";
            this.btnReelTimeOutDown.Size = new System.Drawing.Size(40, 34);
            this.btnReelTimeOutDown.TabIndex = 79;
            this.btnReelTimeOutDown.Tag = "1";
            this.btnReelTimeOutDown.UseVisualStyleBackColor = true;
            this.btnReelTimeOutDown.Click += new System.EventHandler(this.btnReelTimeOutDown_Click);
            // 
            // btnReelTimeOutUp
            // 
            this.btnReelTimeOutUp.Image = global::YSOS.Properties.Resources.icons8_double_up_30;
            this.btnReelTimeOutUp.Location = new System.Drawing.Point(8, 83);
            this.btnReelTimeOutUp.Margin = new System.Windows.Forms.Padding(2);
            this.btnReelTimeOutUp.Name = "btnReelTimeOutUp";
            this.btnReelTimeOutUp.Size = new System.Drawing.Size(40, 34);
            this.btnReelTimeOutUp.TabIndex = 78;
            this.btnReelTimeOutUp.Tag = "1";
            this.btnReelTimeOutUp.UseVisualStyleBackColor = true;
            this.btnReelTimeOutUp.Click += new System.EventHandler(this.btnReelTimeOutUp_Click);
            // 
            // txtReelTimeOut
            // 
            this.txtReelTimeOut.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtReelTimeOut.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtReelTimeOut.Location = new System.Drawing.Point(8, 48);
            this.txtReelTimeOut.Margin = new System.Windows.Forms.Padding(2);
            this.txtReelTimeOut.Name = "txtReelTimeOut";
            this.txtReelTimeOut.ReadOnly = true;
            this.txtReelTimeOut.Size = new System.Drawing.Size(84, 26);
            this.txtReelTimeOut.TabIndex = 77;
            this.txtReelTimeOut.Tag = "1";
            this.txtReelTimeOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnReleaseReel
            // 
            this.btnReleaseReel.BackColor = System.Drawing.Color.White;
            this.btnReleaseReel.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnReleaseReel.ForeColor = System.Drawing.Color.Black;
            this.btnReleaseReel.Location = new System.Drawing.Point(158, 133);
            this.btnReleaseReel.Margin = new System.Windows.Forms.Padding(2);
            this.btnReleaseReel.Name = "btnReleaseReel";
            this.btnReleaseReel.Size = new System.Drawing.Size(91, 37);
            this.btnReleaseReel.TabIndex = 76;
            this.btnReleaseReel.Text = "放料";
            this.btnReleaseReel.UseVisualStyleBackColor = false;
            this.btnReleaseReel.Click += new System.EventHandler(this.btnReleaseReel_Click);
            // 
            // btnInitialize
            // 
            this.btnInitialize.BackColor = System.Drawing.Color.White;
            this.btnInitialize.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnInitialize.ForeColor = System.Drawing.Color.Black;
            this.btnInitialize.Location = new System.Drawing.Point(57, 4);
            this.btnInitialize.Margin = new System.Windows.Forms.Padding(2);
            this.btnInitialize.Name = "btnInitialize";
            this.btnInitialize.Size = new System.Drawing.Size(91, 37);
            this.btnInitialize.TabIndex = 41;
            this.btnInitialize.Text = "归零";
            this.btnInitialize.UseVisualStyleBackColor = false;
            this.btnInitialize.Click += new System.EventHandler(this.btnInitialize_Click);
            // 
            // frmClipReel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(65)))), ((int)(((byte)(72)))));
            this.ClientSize = new System.Drawing.Size(668, 345);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.BtnSetSpeed);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnInitialize);
            this.KeyPreview = true;
            this.Name = "frmClipReel";
            this.Text = "料卷";
            this.TopMost = true;
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnInitialize;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnReelTimeOutDown;
        private System.Windows.Forms.Button btnReelTimeOutUp;
        private System.Windows.Forms.TextBox txtReelTimeOut;
        private System.Windows.Forms.Button btnReleaseReel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSpacerTimeOutDown;
        private System.Windows.Forms.Button btnSpacerTimeOutUp;
        private System.Windows.Forms.TextBox txtSpacerTimeOut;
        private System.Windows.Forms.Button btnSpacerRoll;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnReleaseDelayDown;
        private System.Windows.Forms.Button btnReleaseDelayUp;
        private System.Windows.Forms.TextBox txtReleaseDelay;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnReelOff;
        private System.Windows.Forms.Button btSpacerOff;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button BtnSetSpeed;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblSpacerDown;
        private System.Windows.Forms.Label lblSpacerUp;
        private System.Windows.Forms.Label lblReelStop;
        private System.Windows.Forms.Label lblReelStart;
    }
}