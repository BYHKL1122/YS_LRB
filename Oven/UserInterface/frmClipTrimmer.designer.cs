namespace YSOS.UserInterface
{
    partial class frmClipTrimmer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClipTrimmer));
            this.btnInitialize = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtAdjustStep = new System.Windows.Forms.TextBox();
            this.btnAdjustStepUp = new System.Windows.Forms.Button();
            this.btnAdjustStepDown = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFeedClip = new System.Windows.Forms.Button();
            this.btnInitializeFeeder = new System.Windows.Forms.Button();
            this.txtFeedDelay = new System.Windows.Forms.TextBox();
            this.btnFeedDelayUp = new System.Windows.Forms.Button();
            this.btnFeedDelayDown = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblCanPresent = new System.Windows.Forms.Label();
            this.txtTMZDelayUp = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.lblCanJam = new System.Windows.Forms.Label();
            this.txtTMZDelayDown = new System.Windows.Forms.Button();
            this.txtTMZDelay = new System.Windows.Forms.TextBox();
            this.lblReelPresent = new System.Windows.Forms.Label();
            this.lblMisAligned = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnReleaseReel = new System.Windows.Forms.Button();
            this.btnSpacerRoll = new System.Windows.Forms.Button();
            this.btnGotoTrim = new System.Windows.Forms.Button();
            this.btnTrimPositionUp = new System.Windows.Forms.Button();
            this.btnTrimPositionDown = new System.Windows.Forms.Button();
            this.txtTrimPosition = new System.Windows.Forms.TextBox();
            this.btnGotoReadyTrim = new System.Windows.Forms.Button();
            this.btnReadyTrimPositionUp = new System.Windows.Forms.Button();
            this.btnReadyTrimPositionDown = new System.Windows.Forms.Button();
            this.txtReadyTrimPosition = new System.Windows.Forms.TextBox();
            this.btnGotoFeed = new System.Windows.Forms.Button();
            this.btnFeedPositionUp = new System.Windows.Forms.Button();
            this.btnFeedPositionDown = new System.Windows.Forms.Button();
            this.txtFeedPosition = new System.Windows.Forms.TextBox();
            this.btnGotoLow = new System.Windows.Forms.Button();
            this.btnLowPositionUp = new System.Windows.Forms.Button();
            this.btnLowPositionDown = new System.Windows.Forms.Button();
            this.txtLowPosition = new System.Windows.Forms.TextBox();
            this.btnInitializeTrimmer = new System.Windows.Forms.Button();
            this.btnTrimFeed = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTrimLimitDown = new System.Windows.Forms.Button();
            this.txtTrimLimitUp = new System.Windows.Forms.Button();
            this.txtTrimLimit = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.BtnSetSpeed = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnInitialize
            // 
            this.btnInitialize.BackColor = System.Drawing.Color.White;
            this.btnInitialize.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnInitialize.Location = new System.Drawing.Point(245, 12);
            this.btnInitialize.Margin = new System.Windows.Forms.Padding(2);
            this.btnInitialize.Name = "btnInitialize";
            this.btnInitialize.Size = new System.Drawing.Size(93, 39);
            this.btnInitialize.TabIndex = 41;
            this.btnInitialize.Text = "归零";
            this.btnInitialize.UseVisualStyleBackColor = false;
            this.btnInitialize.Click += new System.EventHandler(this.btnInitialize_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtAdjustStep
            // 
            this.txtAdjustStep.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtAdjustStep.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtAdjustStep.Location = new System.Drawing.Point(13, 251);
            this.txtAdjustStep.Margin = new System.Windows.Forms.Padding(2);
            this.txtAdjustStep.Name = "txtAdjustStep";
            this.txtAdjustStep.ReadOnly = true;
            this.txtAdjustStep.Size = new System.Drawing.Size(84, 26);
            this.txtAdjustStep.TabIndex = 90;
            this.txtAdjustStep.Tag = "1";
            this.txtAdjustStep.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAdjustStepUp
            // 
            this.btnAdjustStepUp.Image = ((System.Drawing.Image)(resources.GetObject("btnAdjustStepUp.Image")));
            this.btnAdjustStepUp.Location = new System.Drawing.Point(13, 281);
            this.btnAdjustStepUp.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdjustStepUp.Name = "btnAdjustStepUp";
            this.btnAdjustStepUp.Size = new System.Drawing.Size(40, 34);
            this.btnAdjustStepUp.TabIndex = 91;
            this.btnAdjustStepUp.Tag = "1";
            this.btnAdjustStepUp.UseVisualStyleBackColor = true;
            this.btnAdjustStepUp.Click += new System.EventHandler(this.btnAdjustStepUp_Click);
            // 
            // btnAdjustStepDown
            // 
            this.btnAdjustStepDown.Image = ((System.Drawing.Image)(resources.GetObject("btnAdjustStepDown.Image")));
            this.btnAdjustStepDown.Location = new System.Drawing.Point(57, 281);
            this.btnAdjustStepDown.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdjustStepDown.Name = "btnAdjustStepDown";
            this.btnAdjustStepDown.Size = new System.Drawing.Size(40, 34);
            this.btnAdjustStepDown.TabIndex = 92;
            this.btnAdjustStepDown.Tag = "1";
            this.btnAdjustStepDown.UseVisualStyleBackColor = true;
            this.btnAdjustStepDown.Click += new System.EventHandler(this.btnAdjustStepDown_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(10, 226);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 93;
            this.label3.Text = "归零调整";
            // 
            // btnFeedClip
            // 
            this.btnFeedClip.BackColor = System.Drawing.Color.White;
            this.btnFeedClip.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnFeedClip.ForeColor = System.Drawing.Color.Black;
            this.btnFeedClip.Location = new System.Drawing.Point(198, 90);
            this.btnFeedClip.Margin = new System.Windows.Forms.Padding(2);
            this.btnFeedClip.Name = "btnFeedClip";
            this.btnFeedClip.Size = new System.Drawing.Size(93, 39);
            this.btnFeedClip.TabIndex = 94;
            this.btnFeedClip.Text = "喂料";
            this.btnFeedClip.UseVisualStyleBackColor = false;
            this.btnFeedClip.Click += new System.EventHandler(this.btnFeedClip_Click);
            // 
            // btnInitializeFeeder
            // 
            this.btnInitializeFeeder.BackColor = System.Drawing.Color.White;
            this.btnInitializeFeeder.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnInitializeFeeder.ForeColor = System.Drawing.Color.Black;
            this.btnInitializeFeeder.Location = new System.Drawing.Point(198, 27);
            this.btnInitializeFeeder.Margin = new System.Windows.Forms.Padding(2);
            this.btnInitializeFeeder.Name = "btnInitializeFeeder";
            this.btnInitializeFeeder.Size = new System.Drawing.Size(93, 39);
            this.btnInitializeFeeder.TabIndex = 95;
            this.btnInitializeFeeder.Text = "归零";
            this.btnInitializeFeeder.UseVisualStyleBackColor = false;
            this.btnInitializeFeeder.Click += new System.EventHandler(this.btnInitializeFeeder_Click);
            // 
            // txtFeedDelay
            // 
            this.txtFeedDelay.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtFeedDelay.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtFeedDelay.Location = new System.Drawing.Point(215, 251);
            this.txtFeedDelay.Margin = new System.Windows.Forms.Padding(2);
            this.txtFeedDelay.Name = "txtFeedDelay";
            this.txtFeedDelay.ReadOnly = true;
            this.txtFeedDelay.Size = new System.Drawing.Size(84, 26);
            this.txtFeedDelay.TabIndex = 96;
            this.txtFeedDelay.Tag = "1";
            this.txtFeedDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnFeedDelayUp
            // 
            this.btnFeedDelayUp.Image = ((System.Drawing.Image)(resources.GetObject("btnFeedDelayUp.Image")));
            this.btnFeedDelayUp.Location = new System.Drawing.Point(215, 283);
            this.btnFeedDelayUp.Margin = new System.Windows.Forms.Padding(2);
            this.btnFeedDelayUp.Name = "btnFeedDelayUp";
            this.btnFeedDelayUp.Size = new System.Drawing.Size(40, 34);
            this.btnFeedDelayUp.TabIndex = 97;
            this.btnFeedDelayUp.Tag = "1";
            this.btnFeedDelayUp.UseVisualStyleBackColor = true;
            this.btnFeedDelayUp.Click += new System.EventHandler(this.btnFeedDelayUp_Click);
            // 
            // btnFeedDelayDown
            // 
            this.btnFeedDelayDown.Image = ((System.Drawing.Image)(resources.GetObject("btnFeedDelayDown.Image")));
            this.btnFeedDelayDown.Location = new System.Drawing.Point(259, 283);
            this.btnFeedDelayDown.Margin = new System.Windows.Forms.Padding(2);
            this.btnFeedDelayDown.Name = "btnFeedDelayDown";
            this.btnFeedDelayDown.Size = new System.Drawing.Size(40, 34);
            this.btnFeedDelayDown.TabIndex = 98;
            this.btnFeedDelayDown.Tag = "1";
            this.btnFeedDelayDown.UseVisualStyleBackColor = true;
            this.btnFeedDelayDown.Click += new System.EventHandler(this.btnFeedDelayDown_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(211, 226);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 99;
            this.label2.Text = "喂料延迟";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCanPresent);
            this.groupBox1.Controls.Add(this.txtTMZDelayUp);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblCanJam);
            this.groupBox1.Controls.Add(this.txtTMZDelayDown);
            this.groupBox1.Controls.Add(this.txtTMZDelay);
            this.groupBox1.Controls.Add(this.lblReelPresent);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblMisAligned);
            this.groupBox1.Controls.Add(this.txtAdjustStep);
            this.groupBox1.Controls.Add(this.btnFeedDelayDown);
            this.groupBox1.Controls.Add(this.btnAdjustStepUp);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.btnFeedDelayUp);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btnAdjustStepDown);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.txtFeedDelay);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.btnInitializeFeeder);
            this.groupBox1.Controls.Add(this.btnFeedClip);
            this.groupBox1.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(334, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 355);
            this.groupBox1.TabIndex = 89;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "喂料";
            // 
            // lblCanPresent
            // 
            this.lblCanPresent.BackColor = System.Drawing.Color.Gray;
            this.lblCanPresent.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCanPresent.ForeColor = System.Drawing.Color.White;
            this.lblCanPresent.Location = new System.Drawing.Point(10, 142);
            this.lblCanPresent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCanPresent.Name = "lblCanPresent";
            this.lblCanPresent.Size = new System.Drawing.Size(35, 35);
            this.lblCanPresent.TabIndex = 187;
            // 
            // txtTMZDelayUp
            // 
            this.txtTMZDelayUp.Image = ((System.Drawing.Image)(resources.GetObject("txtTMZDelayUp.Image")));
            this.txtTMZDelayUp.Location = new System.Drawing.Point(112, 283);
            this.txtTMZDelayUp.Margin = new System.Windows.Forms.Padding(2);
            this.txtTMZDelayUp.Name = "txtTMZDelayUp";
            this.txtTMZDelayUp.Size = new System.Drawing.Size(40, 34);
            this.txtTMZDelayUp.TabIndex = 143;
            this.txtTMZDelayUp.Tag = "1";
            this.txtTMZDelayUp.UseVisualStyleBackColor = true;
            this.txtTMZDelayUp.Click += new System.EventHandler(this.txtTMZDelayUp_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(111, 226);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 16);
            this.label7.TabIndex = 142;
            this.label7.Text = "下降延迟";
            // 
            // lblCanJam
            // 
            this.lblCanJam.BackColor = System.Drawing.Color.Gray;
            this.lblCanJam.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCanJam.ForeColor = System.Drawing.Color.White;
            this.lblCanJam.Location = new System.Drawing.Point(10, 104);
            this.lblCanJam.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCanJam.Name = "lblCanJam";
            this.lblCanJam.Size = new System.Drawing.Size(35, 35);
            this.lblCanJam.TabIndex = 186;
            // 
            // txtTMZDelayDown
            // 
            this.txtTMZDelayDown.Image = ((System.Drawing.Image)(resources.GetObject("txtTMZDelayDown.Image")));
            this.txtTMZDelayDown.Location = new System.Drawing.Point(156, 283);
            this.txtTMZDelayDown.Margin = new System.Windows.Forms.Padding(2);
            this.txtTMZDelayDown.Name = "txtTMZDelayDown";
            this.txtTMZDelayDown.Size = new System.Drawing.Size(40, 34);
            this.txtTMZDelayDown.TabIndex = 141;
            this.txtTMZDelayDown.Tag = "1";
            this.txtTMZDelayDown.UseVisualStyleBackColor = true;
            this.txtTMZDelayDown.Click += new System.EventHandler(this.txtTMZDelayDown_Click);
            // 
            // txtTMZDelay
            // 
            this.txtTMZDelay.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTMZDelay.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtTMZDelay.Location = new System.Drawing.Point(112, 251);
            this.txtTMZDelay.Margin = new System.Windows.Forms.Padding(2);
            this.txtTMZDelay.Name = "txtTMZDelay";
            this.txtTMZDelay.ReadOnly = true;
            this.txtTMZDelay.Size = new System.Drawing.Size(84, 26);
            this.txtTMZDelay.TabIndex = 140;
            this.txtTMZDelay.Tag = "1";
            this.txtTMZDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblReelPresent
            // 
            this.lblReelPresent.BackColor = System.Drawing.Color.Gray;
            this.lblReelPresent.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblReelPresent.ForeColor = System.Drawing.Color.White;
            this.lblReelPresent.Location = new System.Drawing.Point(10, 66);
            this.lblReelPresent.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReelPresent.Name = "lblReelPresent";
            this.lblReelPresent.Size = new System.Drawing.Size(35, 35);
            this.lblReelPresent.TabIndex = 185;
            // 
            // lblMisAligned
            // 
            this.lblMisAligned.BackColor = System.Drawing.Color.Gray;
            this.lblMisAligned.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMisAligned.ForeColor = System.Drawing.Color.White;
            this.lblMisAligned.Location = new System.Drawing.Point(10, 28);
            this.lblMisAligned.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMisAligned.Name = "lblMisAligned";
            this.lblMisAligned.Size = new System.Drawing.Size(35, 35);
            this.lblMisAligned.TabIndex = 184;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(50, 36);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 16);
            this.label12.TabIndex = 133;
            this.label12.Text = "错位侦测";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(52, 155);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 139;
            this.label4.Text = "废料桶";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(49, 74);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 16);
            this.label13.TabIndex = 134;
            this.label13.Text = "料带侦测";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(49, 114);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 16);
            this.label14.TabIndex = 135;
            this.label14.Text = "卡料侦测";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnReleaseReel);
            this.groupBox3.Controls.Add(this.btnSpacerRoll);
            this.groupBox3.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(334, 426);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(309, 116);
            this.groupBox3.TabIndex = 133;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "料卷";
            // 
            // btnReleaseReel
            // 
            this.btnReleaseReel.BackColor = System.Drawing.Color.White;
            this.btnReleaseReel.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnReleaseReel.ForeColor = System.Drawing.Color.Black;
            this.btnReleaseReel.Location = new System.Drawing.Point(198, 35);
            this.btnReleaseReel.Margin = new System.Windows.Forms.Padding(2);
            this.btnReleaseReel.Name = "btnReleaseReel";
            this.btnReleaseReel.Size = new System.Drawing.Size(93, 39);
            this.btnReleaseReel.TabIndex = 136;
            this.btnReleaseReel.Text = "放料";
            this.btnReleaseReel.UseVisualStyleBackColor = false;
            this.btnReleaseReel.Click += new System.EventHandler(this.btnReleaseReel_Click);
            // 
            // btnSpacerRoll
            // 
            this.btnSpacerRoll.BackColor = System.Drawing.Color.White;
            this.btnSpacerRoll.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSpacerRoll.ForeColor = System.Drawing.Color.Black;
            this.btnSpacerRoll.Location = new System.Drawing.Point(13, 35);
            this.btnSpacerRoll.Margin = new System.Windows.Forms.Padding(2);
            this.btnSpacerRoll.Name = "btnSpacerRoll";
            this.btnSpacerRoll.Size = new System.Drawing.Size(93, 39);
            this.btnSpacerRoll.TabIndex = 137;
            this.btnSpacerRoll.Text = "收纸";
            this.btnSpacerRoll.UseVisualStyleBackColor = false;
            this.btnSpacerRoll.Click += new System.EventHandler(this.btnSpacerRoll_Click);
            // 
            // btnGotoTrim
            // 
            this.btnGotoTrim.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnGotoTrim.ForeColor = System.Drawing.Color.Black;
            this.btnGotoTrim.Location = new System.Drawing.Point(109, 41);
            this.btnGotoTrim.Margin = new System.Windows.Forms.Padding(2);
            this.btnGotoTrim.Name = "btnGotoTrim";
            this.btnGotoTrim.Size = new System.Drawing.Size(76, 26);
            this.btnGotoTrim.TabIndex = 67;
            this.btnGotoTrim.Text = "移至";
            this.btnGotoTrim.UseVisualStyleBackColor = true;
            this.btnGotoTrim.Click += new System.EventHandler(this.btnGotoTrim_Click);
            // 
            // btnTrimPositionUp
            // 
            this.btnTrimPositionUp.ForeColor = System.Drawing.Color.Black;
            this.btnTrimPositionUp.Image = global::YSOS.Properties.Resources.icons8_double_up_30;
            this.btnTrimPositionUp.Location = new System.Drawing.Point(21, 69);
            this.btnTrimPositionUp.Margin = new System.Windows.Forms.Padding(2);
            this.btnTrimPositionUp.Name = "btnTrimPositionUp";
            this.btnTrimPositionUp.Size = new System.Drawing.Size(40, 34);
            this.btnTrimPositionUp.TabIndex = 68;
            this.btnTrimPositionUp.Tag = "1";
            this.btnTrimPositionUp.UseVisualStyleBackColor = true;
            this.btnTrimPositionUp.Click += new System.EventHandler(this.btnTrimPositionUp_Click);
            // 
            // btnTrimPositionDown
            // 
            this.btnTrimPositionDown.ForeColor = System.Drawing.Color.Black;
            this.btnTrimPositionDown.Image = ((System.Drawing.Image)(resources.GetObject("btnTrimPositionDown.Image")));
            this.btnTrimPositionDown.Location = new System.Drawing.Point(65, 69);
            this.btnTrimPositionDown.Margin = new System.Windows.Forms.Padding(2);
            this.btnTrimPositionDown.Name = "btnTrimPositionDown";
            this.btnTrimPositionDown.Size = new System.Drawing.Size(40, 34);
            this.btnTrimPositionDown.TabIndex = 69;
            this.btnTrimPositionDown.Tag = "1";
            this.btnTrimPositionDown.UseVisualStyleBackColor = true;
            this.btnTrimPositionDown.Click += new System.EventHandler(this.btnTrimPositionDown_Click);
            // 
            // txtTrimPosition
            // 
            this.txtTrimPosition.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTrimPosition.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtTrimPosition.Location = new System.Drawing.Point(21, 39);
            this.txtTrimPosition.Margin = new System.Windows.Forms.Padding(2);
            this.txtTrimPosition.Name = "txtTrimPosition";
            this.txtTrimPosition.ReadOnly = true;
            this.txtTrimPosition.Size = new System.Drawing.Size(84, 26);
            this.txtTrimPosition.TabIndex = 70;
            this.txtTrimPosition.Tag = "1";
            this.txtTrimPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnGotoReadyTrim
            // 
            this.btnGotoReadyTrim.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnGotoReadyTrim.ForeColor = System.Drawing.Color.Black;
            this.btnGotoReadyTrim.Location = new System.Drawing.Point(110, 128);
            this.btnGotoReadyTrim.Margin = new System.Windows.Forms.Padding(2);
            this.btnGotoReadyTrim.Name = "btnGotoReadyTrim";
            this.btnGotoReadyTrim.Size = new System.Drawing.Size(76, 26);
            this.btnGotoReadyTrim.TabIndex = 73;
            this.btnGotoReadyTrim.Text = "移至";
            this.btnGotoReadyTrim.UseVisualStyleBackColor = true;
            this.btnGotoReadyTrim.Click += new System.EventHandler(this.btnGotoReadyTrim_Click);
            // 
            // btnReadyTrimPositionUp
            // 
            this.btnReadyTrimPositionUp.Image = ((System.Drawing.Image)(resources.GetObject("btnReadyTrimPositionUp.Image")));
            this.btnReadyTrimPositionUp.Location = new System.Drawing.Point(22, 159);
            this.btnReadyTrimPositionUp.Margin = new System.Windows.Forms.Padding(2);
            this.btnReadyTrimPositionUp.Name = "btnReadyTrimPositionUp";
            this.btnReadyTrimPositionUp.Size = new System.Drawing.Size(40, 34);
            this.btnReadyTrimPositionUp.TabIndex = 74;
            this.btnReadyTrimPositionUp.Tag = "1";
            this.btnReadyTrimPositionUp.UseVisualStyleBackColor = true;
            this.btnReadyTrimPositionUp.Click += new System.EventHandler(this.btnReadyTrimPositionUp_Click);
            // 
            // btnReadyTrimPositionDown
            // 
            this.btnReadyTrimPositionDown.Image = ((System.Drawing.Image)(resources.GetObject("btnReadyTrimPositionDown.Image")));
            this.btnReadyTrimPositionDown.Location = new System.Drawing.Point(66, 159);
            this.btnReadyTrimPositionDown.Margin = new System.Windows.Forms.Padding(2);
            this.btnReadyTrimPositionDown.Name = "btnReadyTrimPositionDown";
            this.btnReadyTrimPositionDown.Size = new System.Drawing.Size(40, 34);
            this.btnReadyTrimPositionDown.TabIndex = 75;
            this.btnReadyTrimPositionDown.Tag = "1";
            this.btnReadyTrimPositionDown.UseVisualStyleBackColor = true;
            this.btnReadyTrimPositionDown.Click += new System.EventHandler(this.btnReadyTrimPositionDown_Click);
            // 
            // txtReadyTrimPosition
            // 
            this.txtReadyTrimPosition.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtReadyTrimPosition.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtReadyTrimPosition.Location = new System.Drawing.Point(22, 128);
            this.txtReadyTrimPosition.Margin = new System.Windows.Forms.Padding(2);
            this.txtReadyTrimPosition.Name = "txtReadyTrimPosition";
            this.txtReadyTrimPosition.ReadOnly = true;
            this.txtReadyTrimPosition.Size = new System.Drawing.Size(84, 26);
            this.txtReadyTrimPosition.TabIndex = 76;
            this.txtReadyTrimPosition.Tag = "1";
            this.txtReadyTrimPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnGotoFeed
            // 
            this.btnGotoFeed.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnGotoFeed.ForeColor = System.Drawing.Color.Black;
            this.btnGotoFeed.Location = new System.Drawing.Point(109, 217);
            this.btnGotoFeed.Margin = new System.Windows.Forms.Padding(2);
            this.btnGotoFeed.Name = "btnGotoFeed";
            this.btnGotoFeed.Size = new System.Drawing.Size(76, 26);
            this.btnGotoFeed.TabIndex = 77;
            this.btnGotoFeed.Text = "移至";
            this.btnGotoFeed.UseVisualStyleBackColor = true;
            this.btnGotoFeed.Click += new System.EventHandler(this.btnGotoFeed_Click);
            // 
            // btnFeedPositionUp
            // 
            this.btnFeedPositionUp.Image = ((System.Drawing.Image)(resources.GetObject("btnFeedPositionUp.Image")));
            this.btnFeedPositionUp.Location = new System.Drawing.Point(21, 250);
            this.btnFeedPositionUp.Margin = new System.Windows.Forms.Padding(2);
            this.btnFeedPositionUp.Name = "btnFeedPositionUp";
            this.btnFeedPositionUp.Size = new System.Drawing.Size(40, 34);
            this.btnFeedPositionUp.TabIndex = 78;
            this.btnFeedPositionUp.Tag = "1";
            this.btnFeedPositionUp.UseVisualStyleBackColor = true;
            this.btnFeedPositionUp.Click += new System.EventHandler(this.btnFeedPositionUp_Click);
            // 
            // btnFeedPositionDown
            // 
            this.btnFeedPositionDown.Image = ((System.Drawing.Image)(resources.GetObject("btnFeedPositionDown.Image")));
            this.btnFeedPositionDown.Location = new System.Drawing.Point(65, 250);
            this.btnFeedPositionDown.Margin = new System.Windows.Forms.Padding(2);
            this.btnFeedPositionDown.Name = "btnFeedPositionDown";
            this.btnFeedPositionDown.Size = new System.Drawing.Size(40, 34);
            this.btnFeedPositionDown.TabIndex = 79;
            this.btnFeedPositionDown.Tag = "1";
            this.btnFeedPositionDown.UseVisualStyleBackColor = true;
            this.btnFeedPositionDown.Click += new System.EventHandler(this.btnFeedPositionDown_Click);
            // 
            // txtFeedPosition
            // 
            this.txtFeedPosition.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtFeedPosition.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtFeedPosition.Location = new System.Drawing.Point(21, 217);
            this.txtFeedPosition.Margin = new System.Windows.Forms.Padding(2);
            this.txtFeedPosition.Name = "txtFeedPosition";
            this.txtFeedPosition.ReadOnly = true;
            this.txtFeedPosition.Size = new System.Drawing.Size(84, 26);
            this.txtFeedPosition.TabIndex = 80;
            this.txtFeedPosition.Tag = "1";
            this.txtFeedPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnGotoLow
            // 
            this.btnGotoLow.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnGotoLow.ForeColor = System.Drawing.Color.Black;
            this.btnGotoLow.Location = new System.Drawing.Point(109, 317);
            this.btnGotoLow.Margin = new System.Windows.Forms.Padding(2);
            this.btnGotoLow.Name = "btnGotoLow";
            this.btnGotoLow.Size = new System.Drawing.Size(76, 26);
            this.btnGotoLow.TabIndex = 81;
            this.btnGotoLow.Text = "移至";
            this.btnGotoLow.UseVisualStyleBackColor = true;
            this.btnGotoLow.Click += new System.EventHandler(this.btnGotoLow_Click);
            // 
            // btnLowPositionUp
            // 
            this.btnLowPositionUp.Image = ((System.Drawing.Image)(resources.GetObject("btnLowPositionUp.Image")));
            this.btnLowPositionUp.Location = new System.Drawing.Point(21, 347);
            this.btnLowPositionUp.Margin = new System.Windows.Forms.Padding(2);
            this.btnLowPositionUp.Name = "btnLowPositionUp";
            this.btnLowPositionUp.Size = new System.Drawing.Size(40, 34);
            this.btnLowPositionUp.TabIndex = 82;
            this.btnLowPositionUp.Tag = "1";
            this.btnLowPositionUp.UseVisualStyleBackColor = true;
            this.btnLowPositionUp.Click += new System.EventHandler(this.btnLowPositionUp_Click);
            // 
            // btnLowPositionDown
            // 
            this.btnLowPositionDown.Image = ((System.Drawing.Image)(resources.GetObject("btnLowPositionDown.Image")));
            this.btnLowPositionDown.Location = new System.Drawing.Point(65, 347);
            this.btnLowPositionDown.Margin = new System.Windows.Forms.Padding(2);
            this.btnLowPositionDown.Name = "btnLowPositionDown";
            this.btnLowPositionDown.Size = new System.Drawing.Size(40, 34);
            this.btnLowPositionDown.TabIndex = 83;
            this.btnLowPositionDown.Tag = "1";
            this.btnLowPositionDown.UseVisualStyleBackColor = true;
            this.btnLowPositionDown.Click += new System.EventHandler(this.btnLowPositionDown_Click);
            // 
            // txtLowPosition
            // 
            this.txtLowPosition.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtLowPosition.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtLowPosition.Location = new System.Drawing.Point(21, 317);
            this.txtLowPosition.Margin = new System.Windows.Forms.Padding(2);
            this.txtLowPosition.Name = "txtLowPosition";
            this.txtLowPosition.ReadOnly = true;
            this.txtLowPosition.Size = new System.Drawing.Size(84, 26);
            this.txtLowPosition.TabIndex = 84;
            this.txtLowPosition.Tag = "1";
            this.txtLowPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnInitializeTrimmer
            // 
            this.btnInitializeTrimmer.BackColor = System.Drawing.Color.White;
            this.btnInitializeTrimmer.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnInitializeTrimmer.ForeColor = System.Drawing.Color.Black;
            this.btnInitializeTrimmer.Location = new System.Drawing.Point(218, 22);
            this.btnInitializeTrimmer.Margin = new System.Windows.Forms.Padding(2);
            this.btnInitializeTrimmer.Name = "btnInitializeTrimmer";
            this.btnInitializeTrimmer.Size = new System.Drawing.Size(93, 39);
            this.btnInitializeTrimmer.TabIndex = 96;
            this.btnInitializeTrimmer.Text = "归零";
            this.btnInitializeTrimmer.UseVisualStyleBackColor = false;
            this.btnInitializeTrimmer.Click += new System.EventHandler(this.btnInitializeTrimmer_Click);
            // 
            // btnTrimFeed
            // 
            this.btnTrimFeed.BackColor = System.Drawing.Color.White;
            this.btnTrimFeed.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnTrimFeed.ForeColor = System.Drawing.Color.Black;
            this.btnTrimFeed.Location = new System.Drawing.Point(209, 317);
            this.btnTrimFeed.Margin = new System.Windows.Forms.Padding(2);
            this.btnTrimFeed.Name = "btnTrimFeed";
            this.btnTrimFeed.Size = new System.Drawing.Size(102, 39);
            this.btnTrimFeed.TabIndex = 97;
            this.btnTrimFeed.Text = "下降进料";
            this.btnTrimFeed.UseVisualStyleBackColor = false;
            this.btnTrimFeed.Click += new System.EventHandler(this.btnTrimFeed_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnTrimFeed);
            this.groupBox2.Controls.Add(this.btnInitializeTrimmer);
            this.groupBox2.Controls.Add(this.txtLowPosition);
            this.groupBox2.Controls.Add(this.btnLowPositionDown);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtTrimLimitDown);
            this.groupBox2.Controls.Add(this.btnLowPositionUp);
            this.groupBox2.Controls.Add(this.txtTrimLimitUp);
            this.groupBox2.Controls.Add(this.btnGotoLow);
            this.groupBox2.Controls.Add(this.txtFeedPosition);
            this.groupBox2.Controls.Add(this.txtTrimLimit);
            this.groupBox2.Controls.Add(this.btnFeedPositionDown);
            this.groupBox2.Controls.Add(this.btnFeedPositionUp);
            this.groupBox2.Controls.Add(this.btnGotoFeed);
            this.groupBox2.Controls.Add(this.txtReadyTrimPosition);
            this.groupBox2.Controls.Add(this.btnReadyTrimPositionDown);
            this.groupBox2.Controls.Add(this.btnReadyTrimPositionUp);
            this.groupBox2.Controls.Add(this.btnGotoReadyTrim);
            this.groupBox2.Controls.Add(this.txtTrimPosition);
            this.groupBox2.Controls.Add(this.btnTrimPositionDown);
            this.groupBox2.Controls.Add(this.btnTrimPositionUp);
            this.groupBox2.Controls.Add(this.btnGotoTrim);
            this.groupBox2.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(12, 56);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(316, 486);
            this.groupBox2.TabIndex = 90;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "裁刀";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(25, 294);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 16);
            this.label9.TabIndex = 139;
            this.label9.Text = "低位";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(25, 199);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 16);
            this.label8.TabIndex = 138;
            this.label8.Text = "喂料位";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(25, 110);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 137;
            this.label5.Text = "裁切备位";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(25, 21);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 16);
            this.label1.TabIndex = 136;
            this.label1.Text = "裁切上位";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(223, 199);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 16);
            this.label6.TabIndex = 123;
            this.label6.Text = "裁切上限";
            // 
            // txtTrimLimitDown
            // 
            this.txtTrimLimitDown.Image = ((System.Drawing.Image)(resources.GetObject("txtTrimLimitDown.Image")));
            this.txtTrimLimitDown.Location = new System.Drawing.Point(267, 253);
            this.txtTrimLimitDown.Margin = new System.Windows.Forms.Padding(2);
            this.txtTrimLimitDown.Name = "txtTrimLimitDown";
            this.txtTrimLimitDown.Size = new System.Drawing.Size(40, 34);
            this.txtTrimLimitDown.TabIndex = 135;
            this.txtTrimLimitDown.Tag = "1";
            this.txtTrimLimitDown.UseVisualStyleBackColor = true;
            this.txtTrimLimitDown.Click += new System.EventHandler(this.txtTrimLimitDown_Click);
            // 
            // txtTrimLimitUp
            // 
            this.txtTrimLimitUp.Image = ((System.Drawing.Image)(resources.GetObject("txtTrimLimitUp.Image")));
            this.txtTrimLimitUp.Location = new System.Drawing.Point(223, 253);
            this.txtTrimLimitUp.Margin = new System.Windows.Forms.Padding(2);
            this.txtTrimLimitUp.Name = "txtTrimLimitUp";
            this.txtTrimLimitUp.Size = new System.Drawing.Size(40, 34);
            this.txtTrimLimitUp.TabIndex = 134;
            this.txtTrimLimitUp.Tag = "1";
            this.txtTrimLimitUp.UseVisualStyleBackColor = true;
            this.txtTrimLimitUp.Click += new System.EventHandler(this.txtTrimLimitUp_Click);
            // 
            // txtTrimLimit
            // 
            this.txtTrimLimit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtTrimLimit.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtTrimLimit.Location = new System.Drawing.Point(223, 220);
            this.txtTrimLimit.Margin = new System.Windows.Forms.Padding(2);
            this.txtTrimLimit.Name = "txtTrimLimit";
            this.txtTrimLimit.ReadOnly = true;
            this.txtTrimLimit.Size = new System.Drawing.Size(84, 26);
            this.txtTrimLimit.TabIndex = 122;
            this.txtTrimLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(394, 25);
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
            this.BtnSetSpeed.Location = new System.Drawing.Point(447, 17);
            this.BtnSetSpeed.Name = "BtnSetSpeed";
            this.BtnSetSpeed.Size = new System.Drawing.Size(36, 35);
            this.BtnSetSpeed.TabIndex = 165;
            this.BtnSetSpeed.Text = "慢";
            this.BtnSetSpeed.UseVisualStyleBackColor = false;
            this.BtnSetSpeed.Click += new System.EventHandler(this.BtnSetSpeed_Click);
            // 
            // frmClipTrimmer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(65)))), ((int)(((byte)(72)))));
            this.ClientSize = new System.Drawing.Size(677, 554);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.BtnSetSpeed);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnInitialize);
            this.ForeColor = System.Drawing.Color.Black;
            this.KeyPreview = true;
            this.Name = "frmClipTrimmer";
            this.Text = "frmClipTrimmer";
            this.TopMost = true;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnInitialize;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtAdjustStep;
        private System.Windows.Forms.Button btnAdjustStepUp;
        private System.Windows.Forms.Button btnAdjustStepDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFeedClip;
        private System.Windows.Forms.Button btnInitializeFeeder;
        private System.Windows.Forms.TextBox txtFeedDelay;
        private System.Windows.Forms.Button btnFeedDelayUp;
        private System.Windows.Forms.Button btnFeedDelayDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnGotoTrim;
        private System.Windows.Forms.Button btnTrimPositionUp;
        private System.Windows.Forms.Button btnTrimPositionDown;
        private System.Windows.Forms.TextBox txtTrimPosition;
        private System.Windows.Forms.Button btnGotoReadyTrim;
        private System.Windows.Forms.Button btnReadyTrimPositionUp;
        private System.Windows.Forms.Button btnReadyTrimPositionDown;
        private System.Windows.Forms.TextBox txtReadyTrimPosition;
        private System.Windows.Forms.Button btnGotoFeed;
        private System.Windows.Forms.Button btnFeedPositionUp;
        private System.Windows.Forms.Button btnFeedPositionDown;
        private System.Windows.Forms.TextBox txtFeedPosition;
        private System.Windows.Forms.Button btnGotoLow;
        private System.Windows.Forms.Button btnLowPositionUp;
        private System.Windows.Forms.Button btnLowPositionDown;
        private System.Windows.Forms.TextBox txtLowPosition;
        private System.Windows.Forms.Button btnInitializeTrimmer;
        private System.Windows.Forms.Button btnTrimFeed;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnReleaseReel;
        private System.Windows.Forms.Button btnSpacerRoll;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button txtTrimLimitDown;
        private System.Windows.Forms.Button txtTrimLimitUp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTrimLimit;
        private System.Windows.Forms.Button txtTMZDelayUp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button txtTMZDelayDown;
        private System.Windows.Forms.TextBox txtTMZDelay;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button BtnSetSpeed;
        private System.Windows.Forms.Label lblCanPresent;
        private System.Windows.Forms.Label lblCanJam;
        private System.Windows.Forms.Label lblReelPresent;
        private System.Windows.Forms.Label lblMisAligned;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
    }
}