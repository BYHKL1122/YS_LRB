namespace YSOS.UserInterface
{
    partial class frmDispenser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDispenser));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label15 = new System.Windows.Forms.Label();
            this.BtnSetSpeed = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGotoDown1 = new System.Windows.Forms.Button();
            this.txtDown1Position = new System.Windows.Forms.TextBox();
            this.txtDown1PositionDown = new System.Windows.Forms.Button();
            this.btnGotoStandby = new System.Windows.Forms.Button();
            this.txtDown1PositionUp = new System.Windows.Forms.Button();
            this.btnDownDelayUp = new System.Windows.Forms.Button();
            this.btnGotoUp = new System.Windows.Forms.Button();
            this.btnStandbyPositionUp = new System.Windows.Forms.Button();
            this.btnUpPositionUp = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDisLimitDown = new System.Windows.Forms.Button();
            this.btnStandbyPositionDown = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtStandbyPosition = new System.Windows.Forms.TextBox();
            this.btnUpPositionDown = new System.Windows.Forms.Button();
            this.txtDisLimitUp = new System.Windows.Forms.Button();
            this.btnDownDelayDown = new System.Windows.Forms.Button();
            this.txtDownDelay = new System.Windows.Forms.TextBox();
            this.txtDisLimit = new System.Windows.Forms.TextBox();
            this.txtUpPosition = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDispenseOn2 = new System.Windows.Forms.Button();
            this.btnDispenseOn1 = new System.Windows.Forms.Button();
            this.lblDispenseDone2 = new System.Windows.Forms.Label();
            this.btnDispense2 = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.lblDispenseDone1 = new System.Windows.Forms.Label();
            this.btnDispense = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDispense1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnInitialize = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
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
            this.label15.Location = new System.Drawing.Point(234, 29);
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
            this.BtnSetSpeed.Location = new System.Drawing.Point(288, 22);
            this.BtnSetSpeed.Name = "BtnSetSpeed";
            this.BtnSetSpeed.Size = new System.Drawing.Size(36, 35);
            this.BtnSetSpeed.TabIndex = 165;
            this.BtnSetSpeed.Text = "慢";
            this.BtnSetSpeed.UseVisualStyleBackColor = false;
            this.BtnSetSpeed.Click += new System.EventHandler(this.BtnSetSpeed_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnGotoDown1);
            this.groupBox1.Controls.Add(this.txtDown1Position);
            this.groupBox1.Controls.Add(this.txtDown1PositionDown);
            this.groupBox1.Controls.Add(this.btnGotoStandby);
            this.groupBox1.Controls.Add(this.txtDown1PositionUp);
            this.groupBox1.Controls.Add(this.btnDownDelayUp);
            this.groupBox1.Controls.Add(this.btnGotoUp);
            this.groupBox1.Controls.Add(this.btnStandbyPositionUp);
            this.groupBox1.Controls.Add(this.btnUpPositionUp);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtDisLimitDown);
            this.groupBox1.Controls.Add(this.btnStandbyPositionDown);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtStandbyPosition);
            this.groupBox1.Controls.Add(this.btnUpPositionDown);
            this.groupBox1.Controls.Add(this.txtDisLimitUp);
            this.groupBox1.Controls.Add(this.btnDownDelayDown);
            this.groupBox1.Controls.Add(this.txtDownDelay);
            this.groupBox1.Controls.Add(this.txtDisLimit);
            this.groupBox1.Controls.Add(this.txtUpPosition);
            this.groupBox1.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(12, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(296, 321);
            this.groupBox1.TabIndex = 143;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "参数";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(20, 220);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 16);
            this.label7.TabIndex = 145;
            this.label7.Text = "下位";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(18, 131);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 144;
            this.label4.Text = "上位";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(16, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 143;
            this.label1.Text = "备位";
            // 
            // btnGotoDown1
            // 
            this.btnGotoDown1.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnGotoDown1.ForeColor = System.Drawing.Color.Black;
            this.btnGotoDown1.Location = new System.Drawing.Point(97, 243);
            this.btnGotoDown1.Margin = new System.Windows.Forms.Padding(2);
            this.btnGotoDown1.Name = "btnGotoDown1";
            this.btnGotoDown1.Size = new System.Drawing.Size(68, 26);
            this.btnGotoDown1.TabIndex = 103;
            this.btnGotoDown1.Text = "移至";
            this.btnGotoDown1.UseVisualStyleBackColor = true;
            this.btnGotoDown1.Click += new System.EventHandler(this.btnGotoDown1_Click);
            // 
            // txtDown1Position
            // 
            this.txtDown1Position.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtDown1Position.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtDown1Position.Location = new System.Drawing.Point(6, 243);
            this.txtDown1Position.Margin = new System.Windows.Forms.Padding(2);
            this.txtDown1Position.Name = "txtDown1Position";
            this.txtDown1Position.ReadOnly = true;
            this.txtDown1Position.Size = new System.Drawing.Size(87, 26);
            this.txtDown1Position.TabIndex = 106;
            this.txtDown1Position.Tag = "1";
            this.txtDown1Position.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDown1PositionDown
            // 
            this.txtDown1PositionDown.Image = ((System.Drawing.Image)(resources.GetObject("txtDown1PositionDown.Image")));
            this.txtDown1PositionDown.Location = new System.Drawing.Point(54, 273);
            this.txtDown1PositionDown.Margin = new System.Windows.Forms.Padding(2);
            this.txtDown1PositionDown.Name = "txtDown1PositionDown";
            this.txtDown1PositionDown.Size = new System.Drawing.Size(40, 34);
            this.txtDown1PositionDown.TabIndex = 105;
            this.txtDown1PositionDown.Tag = "1";
            this.txtDown1PositionDown.UseVisualStyleBackColor = true;
            this.txtDown1PositionDown.Click += new System.EventHandler(this.txtDown1PositionDown_Click);
            // 
            // btnGotoStandby
            // 
            this.btnGotoStandby.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnGotoStandby.ForeColor = System.Drawing.Color.Black;
            this.btnGotoStandby.Location = new System.Drawing.Point(97, 44);
            this.btnGotoStandby.Margin = new System.Windows.Forms.Padding(2);
            this.btnGotoStandby.Name = "btnGotoStandby";
            this.btnGotoStandby.Size = new System.Drawing.Size(68, 26);
            this.btnGotoStandby.TabIndex = 87;
            this.btnGotoStandby.Text = "移至";
            this.btnGotoStandby.UseVisualStyleBackColor = true;
            this.btnGotoStandby.Click += new System.EventHandler(this.btnGotoStandby_Click);
            // 
            // txtDown1PositionUp
            // 
            this.txtDown1PositionUp.Image = ((System.Drawing.Image)(resources.GetObject("txtDown1PositionUp.Image")));
            this.txtDown1PositionUp.Location = new System.Drawing.Point(7, 273);
            this.txtDown1PositionUp.Margin = new System.Windows.Forms.Padding(2);
            this.txtDown1PositionUp.Name = "txtDown1PositionUp";
            this.txtDown1PositionUp.Size = new System.Drawing.Size(40, 34);
            this.txtDown1PositionUp.TabIndex = 104;
            this.txtDown1PositionUp.Tag = "1";
            this.txtDown1PositionUp.UseVisualStyleBackColor = true;
            this.txtDown1PositionUp.Click += new System.EventHandler(this.txtDown1PositionUp_Click);
            // 
            // btnDownDelayUp
            // 
            this.btnDownDelayUp.Image = ((System.Drawing.Image)(resources.GetObject("btnDownDelayUp.Image")));
            this.btnDownDelayUp.Location = new System.Drawing.Point(190, 74);
            this.btnDownDelayUp.Margin = new System.Windows.Forms.Padding(2);
            this.btnDownDelayUp.Name = "btnDownDelayUp";
            this.btnDownDelayUp.Size = new System.Drawing.Size(40, 34);
            this.btnDownDelayUp.TabIndex = 91;
            this.btnDownDelayUp.Tag = "1";
            this.btnDownDelayUp.UseVisualStyleBackColor = true;
            this.btnDownDelayUp.Click += new System.EventHandler(this.btnDownDelayUp_Click);
            // 
            // btnGotoUp
            // 
            this.btnGotoUp.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnGotoUp.ForeColor = System.Drawing.Color.Black;
            this.btnGotoUp.Location = new System.Drawing.Point(97, 152);
            this.btnGotoUp.Margin = new System.Windows.Forms.Padding(2);
            this.btnGotoUp.Name = "btnGotoUp";
            this.btnGotoUp.Size = new System.Drawing.Size(68, 26);
            this.btnGotoUp.TabIndex = 88;
            this.btnGotoUp.Text = "移至";
            this.btnGotoUp.UseVisualStyleBackColor = true;
            this.btnGotoUp.Click += new System.EventHandler(this.btnGotoUp_Click);
            // 
            // btnStandbyPositionUp
            // 
            this.btnStandbyPositionUp.Image = global::YSOS.Properties.Resources.icons8_double_up_30;
            this.btnStandbyPositionUp.Location = new System.Drawing.Point(6, 74);
            this.btnStandbyPositionUp.Margin = new System.Windows.Forms.Padding(2);
            this.btnStandbyPositionUp.Name = "btnStandbyPositionUp";
            this.btnStandbyPositionUp.Size = new System.Drawing.Size(40, 34);
            this.btnStandbyPositionUp.TabIndex = 97;
            this.btnStandbyPositionUp.Tag = "1";
            this.btnStandbyPositionUp.UseVisualStyleBackColor = true;
            this.btnStandbyPositionUp.Click += new System.EventHandler(this.btnStandbyPositionUp_Click);
            // 
            // btnUpPositionUp
            // 
            this.btnUpPositionUp.Image = ((System.Drawing.Image)(resources.GetObject("btnUpPositionUp.Image")));
            this.btnUpPositionUp.Location = new System.Drawing.Point(5, 182);
            this.btnUpPositionUp.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpPositionUp.Name = "btnUpPositionUp";
            this.btnUpPositionUp.Size = new System.Drawing.Size(40, 34);
            this.btnUpPositionUp.TabIndex = 94;
            this.btnUpPositionUp.Tag = "1";
            this.btnUpPositionUp.UseVisualStyleBackColor = true;
            this.btnUpPositionUp.Click += new System.EventHandler(this.btnUpPositionUp_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(195, 131);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 16);
            this.label9.TabIndex = 140;
            this.label9.Text = "点胶上限";
            // 
            // txtDisLimitDown
            // 
            this.txtDisLimitDown.Image = ((System.Drawing.Image)(resources.GetObject("txtDisLimitDown.Image")));
            this.txtDisLimitDown.Location = new System.Drawing.Point(234, 184);
            this.txtDisLimitDown.Margin = new System.Windows.Forms.Padding(2);
            this.txtDisLimitDown.Name = "txtDisLimitDown";
            this.txtDisLimitDown.Size = new System.Drawing.Size(40, 34);
            this.txtDisLimitDown.TabIndex = 142;
            this.txtDisLimitDown.Tag = "1";
            this.txtDisLimitDown.UseVisualStyleBackColor = true;
            this.txtDisLimitDown.Click += new System.EventHandler(this.txtDisLimitDown_Click);
            // 
            // btnStandbyPositionDown
            // 
            this.btnStandbyPositionDown.Image = global::YSOS.Properties.Resources.icons8_double_down_30;
            this.btnStandbyPositionDown.Location = new System.Drawing.Point(53, 74);
            this.btnStandbyPositionDown.Margin = new System.Windows.Forms.Padding(2);
            this.btnStandbyPositionDown.Name = "btnStandbyPositionDown";
            this.btnStandbyPositionDown.Size = new System.Drawing.Size(40, 34);
            this.btnStandbyPositionDown.TabIndex = 98;
            this.btnStandbyPositionDown.Tag = "1";
            this.btnStandbyPositionDown.UseVisualStyleBackColor = true;
            this.btnStandbyPositionDown.Click += new System.EventHandler(this.btnStandbyPositionDown_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(195, 23);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 93;
            this.label2.Text = "下位延迟";
            // 
            // txtStandbyPosition
            // 
            this.txtStandbyPosition.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtStandbyPosition.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtStandbyPosition.Location = new System.Drawing.Point(5, 44);
            this.txtStandbyPosition.Margin = new System.Windows.Forms.Padding(2);
            this.txtStandbyPosition.Name = "txtStandbyPosition";
            this.txtStandbyPosition.ReadOnly = true;
            this.txtStandbyPosition.Size = new System.Drawing.Size(88, 26);
            this.txtStandbyPosition.TabIndex = 99;
            this.txtStandbyPosition.Tag = "1";
            this.txtStandbyPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnUpPositionDown
            // 
            this.btnUpPositionDown.Image = ((System.Drawing.Image)(resources.GetObject("btnUpPositionDown.Image")));
            this.btnUpPositionDown.Location = new System.Drawing.Point(52, 182);
            this.btnUpPositionDown.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpPositionDown.Name = "btnUpPositionDown";
            this.btnUpPositionDown.Size = new System.Drawing.Size(40, 34);
            this.btnUpPositionDown.TabIndex = 95;
            this.btnUpPositionDown.Tag = "1";
            this.btnUpPositionDown.UseVisualStyleBackColor = true;
            this.btnUpPositionDown.Click += new System.EventHandler(this.btnUpPositionDown_Click);
            // 
            // txtDisLimitUp
            // 
            this.txtDisLimitUp.Image = ((System.Drawing.Image)(resources.GetObject("txtDisLimitUp.Image")));
            this.txtDisLimitUp.Location = new System.Drawing.Point(190, 184);
            this.txtDisLimitUp.Margin = new System.Windows.Forms.Padding(2);
            this.txtDisLimitUp.Name = "txtDisLimitUp";
            this.txtDisLimitUp.Size = new System.Drawing.Size(40, 34);
            this.txtDisLimitUp.TabIndex = 141;
            this.txtDisLimitUp.Tag = "1";
            this.txtDisLimitUp.UseVisualStyleBackColor = true;
            this.txtDisLimitUp.Click += new System.EventHandler(this.txtDisLimitUp_Click);
            // 
            // btnDownDelayDown
            // 
            this.btnDownDelayDown.Image = ((System.Drawing.Image)(resources.GetObject("btnDownDelayDown.Image")));
            this.btnDownDelayDown.Location = new System.Drawing.Point(234, 74);
            this.btnDownDelayDown.Margin = new System.Windows.Forms.Padding(2);
            this.btnDownDelayDown.Name = "btnDownDelayDown";
            this.btnDownDelayDown.Size = new System.Drawing.Size(40, 34);
            this.btnDownDelayDown.TabIndex = 92;
            this.btnDownDelayDown.Tag = "1";
            this.btnDownDelayDown.UseVisualStyleBackColor = true;
            this.btnDownDelayDown.Click += new System.EventHandler(this.btnDownDelayDown_Click);
            // 
            // txtDownDelay
            // 
            this.txtDownDelay.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtDownDelay.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtDownDelay.Location = new System.Drawing.Point(190, 44);
            this.txtDownDelay.Margin = new System.Windows.Forms.Padding(2);
            this.txtDownDelay.Name = "txtDownDelay";
            this.txtDownDelay.ReadOnly = true;
            this.txtDownDelay.Size = new System.Drawing.Size(84, 26);
            this.txtDownDelay.TabIndex = 90;
            this.txtDownDelay.Tag = "1";
            this.txtDownDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDisLimit
            // 
            this.txtDisLimit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtDisLimit.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtDisLimit.Location = new System.Drawing.Point(190, 154);
            this.txtDisLimit.Margin = new System.Windows.Forms.Padding(2);
            this.txtDisLimit.Name = "txtDisLimit";
            this.txtDisLimit.ReadOnly = true;
            this.txtDisLimit.Size = new System.Drawing.Size(84, 26);
            this.txtDisLimit.TabIndex = 139;
            this.txtDisLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtUpPosition
            // 
            this.txtUpPosition.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtUpPosition.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtUpPosition.Location = new System.Drawing.Point(5, 152);
            this.txtUpPosition.Margin = new System.Windows.Forms.Padding(2);
            this.txtUpPosition.Name = "txtUpPosition";
            this.txtUpPosition.ReadOnly = true;
            this.txtUpPosition.Size = new System.Drawing.Size(88, 26);
            this.txtUpPosition.TabIndex = 96;
            this.txtUpPosition.Tag = "1";
            this.txtUpPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDispenseOn2);
            this.groupBox2.Controls.Add(this.btnDispenseOn1);
            this.groupBox2.Controls.Add(this.lblDispenseDone2);
            this.groupBox2.Controls.Add(this.btnDispense2);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.lblDispenseDone1);
            this.groupBox2.Controls.Add(this.btnDispense);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnDispense1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(314, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(319, 320);
            this.groupBox2.TabIndex = 103;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "测试";
            // 
            // btnDispenseOn2
            // 
            this.btnDispenseOn2.ForeColor = System.Drawing.Color.Black;
            this.btnDispenseOn2.Location = new System.Drawing.Point(25, 77);
            this.btnDispenseOn2.Margin = new System.Windows.Forms.Padding(2);
            this.btnDispenseOn2.Name = "btnDispenseOn2";
            this.btnDispenseOn2.Size = new System.Drawing.Size(38, 38);
            this.btnDispenseOn2.TabIndex = 187;
            this.btnDispenseOn2.UseVisualStyleBackColor = true;
            // 
            // btnDispenseOn1
            // 
            this.btnDispenseOn1.ForeColor = System.Drawing.Color.Black;
            this.btnDispenseOn1.Location = new System.Drawing.Point(182, 75);
            this.btnDispenseOn1.Margin = new System.Windows.Forms.Padding(2);
            this.btnDispenseOn1.Name = "btnDispenseOn1";
            this.btnDispenseOn1.Size = new System.Drawing.Size(38, 38);
            this.btnDispenseOn1.TabIndex = 186;
            this.btnDispenseOn1.UseVisualStyleBackColor = true;
            // 
            // lblDispenseDone2
            // 
            this.lblDispenseDone2.BackColor = System.Drawing.Color.Gray;
            this.lblDispenseDone2.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDispenseDone2.ForeColor = System.Drawing.Color.White;
            this.lblDispenseDone2.Location = new System.Drawing.Point(28, 25);
            this.lblDispenseDone2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDispenseDone2.Name = "lblDispenseDone2";
            this.lblDispenseDone2.Size = new System.Drawing.Size(35, 35);
            this.lblDispenseDone2.TabIndex = 185;
            // 
            // btnDispense2
            // 
            this.btnDispense2.BackColor = System.Drawing.Color.White;
            this.btnDispense2.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDispense2.ForeColor = System.Drawing.Color.Black;
            this.btnDispense2.Location = new System.Drawing.Point(21, 144);
            this.btnDispense2.Margin = new System.Windows.Forms.Padding(2);
            this.btnDispense2.Name = "btnDispense2";
            this.btnDispense2.Size = new System.Drawing.Size(94, 39);
            this.btnDispense2.TabIndex = 76;
            this.btnDispense2.Text = "点胶2";
            this.btnDispense2.UseVisualStyleBackColor = false;
            this.btnDispense2.Click += new System.EventHandler(this.btnDispense2_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(63, 87);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 16);
            this.label13.TabIndex = 149;
            this.label13.Text = "启动2";
            // 
            // lblDispenseDone1
            // 
            this.lblDispenseDone1.BackColor = System.Drawing.Color.Gray;
            this.lblDispenseDone1.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDispenseDone1.ForeColor = System.Drawing.Color.White;
            this.lblDispenseDone1.Location = new System.Drawing.Point(185, 25);
            this.lblDispenseDone1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDispenseDone1.Name = "lblDispenseDone1";
            this.lblDispenseDone1.Size = new System.Drawing.Size(35, 35);
            this.lblDispenseDone1.TabIndex = 184;
            // 
            // btnDispense
            // 
            this.btnDispense.BackColor = System.Drawing.Color.White;
            this.btnDispense.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDispense.ForeColor = System.Drawing.Color.Black;
            this.btnDispense.Location = new System.Drawing.Point(106, 237);
            this.btnDispense.Margin = new System.Windows.Forms.Padding(2);
            this.btnDispense.Name = "btnDispense";
            this.btnDispense.Size = new System.Drawing.Size(114, 39);
            this.btnDispense.TabIndex = 105;
            this.btnDispense.Text = "同步点胶";
            this.btnDispense.UseVisualStyleBackColor = false;
            this.btnDispense.Click += new System.EventHandler(this.btnDispense_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(63, 34);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 16);
            this.label6.TabIndex = 125;
            this.label6.Text = "完成2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(220, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 148;
            this.label3.Text = "启动1";
            // 
            // btnDispense1
            // 
            this.btnDispense1.BackColor = System.Drawing.Color.White;
            this.btnDispense1.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDispense1.ForeColor = System.Drawing.Color.Black;
            this.btnDispense1.Location = new System.Drawing.Point(176, 142);
            this.btnDispense1.Margin = new System.Windows.Forms.Padding(2);
            this.btnDispense1.Name = "btnDispense1";
            this.btnDispense1.Size = new System.Drawing.Size(94, 39);
            this.btnDispense1.TabIndex = 76;
            this.btnDispense1.Text = "点胶1";
            this.btnDispense1.UseVisualStyleBackColor = false;
            this.btnDispense1.Click += new System.EventHandler(this.btnDispense1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(220, 32);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 16);
            this.label5.TabIndex = 124;
            this.label5.Text = "完成1";
            // 
            // btnInitialize
            // 
            this.btnInitialize.BackColor = System.Drawing.Color.White;
            this.btnInitialize.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnInitialize.Location = new System.Drawing.Point(66, 18);
            this.btnInitialize.Margin = new System.Windows.Forms.Padding(2);
            this.btnInitialize.Name = "btnInitialize";
            this.btnInitialize.Size = new System.Drawing.Size(94, 39);
            this.btnInitialize.TabIndex = 79;
            this.btnInitialize.Text = "归零";
            this.btnInitialize.UseVisualStyleBackColor = false;
            this.btnInitialize.Click += new System.EventHandler(this.btnInitialize_Click);
            // 
            // frmDispenser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(65)))), ((int)(((byte)(72)))));
            this.ClientSize = new System.Drawing.Size(684, 398);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.BtnSetSpeed);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnInitialize);
            this.KeyPreview = true;
            this.Name = "frmDispenser";
            this.Text = "点胶";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDispenser_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDispense;
        private System.Windows.Forms.Button btnDispense2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDispense1;
        private System.Windows.Forms.TextBox txtStandbyPosition;
        private System.Windows.Forms.Button btnStandbyPositionDown;
        private System.Windows.Forms.Button btnStandbyPositionUp;
        private System.Windows.Forms.TextBox txtUpPosition;
        private System.Windows.Forms.Button btnUpPositionDown;
        private System.Windows.Forms.Button btnUpPositionUp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDownDelayDown;
        private System.Windows.Forms.Button btnDownDelayUp;
        private System.Windows.Forms.TextBox txtDownDelay;
        private System.Windows.Forms.Button btnGotoUp;
        private System.Windows.Forms.Button btnGotoStandby;
        private System.Windows.Forms.Button btnInitialize;
        private System.Windows.Forms.TextBox txtDown1Position;
        private System.Windows.Forms.Button txtDown1PositionDown;
        private System.Windows.Forms.Button txtDown1PositionUp;
        private System.Windows.Forms.Button btnGotoDown1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button txtDisLimitUp;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDisLimit;
        private System.Windows.Forms.Button txtDisLimitDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button BtnSetSpeed;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDispenseDone2;
        private System.Windows.Forms.Label lblDispenseDone1;
        private System.Windows.Forms.Button btnDispenseOn2;
        private System.Windows.Forms.Button btnDispenseOn1;
    }
}