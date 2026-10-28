namespace YS_6000.UserInterface
{
    partial class frmMagazineOutput
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMagazineOutput));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label15 = new System.Windows.Forms.Label();
            this.BtnSetSpeed = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtSlotNoUp = new System.Windows.Forms.Button();
            this.txtSlotNoDown = new System.Windows.Forms.Button();
            this.txtSlotNo = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGotoUnload = new System.Windows.Forms.Button();
            this.btnGotoLoad = new System.Windows.Forms.Button();
            this.btnUnloadDown = new System.Windows.Forms.Button();
            this.btnUnloadPositionUp = new System.Windows.Forms.Button();
            this.btnUnloadPositionDown = new System.Windows.Forms.Button();
            this.txtUnloadPosition = new System.Windows.Forms.TextBox();
            this.btnLoadPositionUp = new System.Windows.Forms.Button();
            this.btnLoadPositionDown = new System.Windows.Forms.Button();
            this.txtLoadPosition = new System.Windows.Forms.TextBox();
            this.btnUnloadDownPositionUp = new System.Windows.Forms.Button();
            this.btnUnloadDownPositionDown = new System.Windows.Forms.Button();
            this.txtUnloadDownPosition = new System.Windows.Forms.TextBox();
            this.btnGotoFirst = new System.Windows.Forms.Button();
            this.btnGotoLast = new System.Windows.Forms.Button();
            this.btnFirstPositionUp = new System.Windows.Forms.Button();
            this.btnFirstPositionDown = new System.Windows.Forms.Button();
            this.txtLastPosition = new System.Windows.Forms.TextBox();
            this.txtFirstPosition = new System.Windows.Forms.TextBox();
            this.btnLastPositionDown = new System.Windows.Forms.Button();
            this.btnLastPositionUp = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblHolderBack = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblHolderOut = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnHolderOutBack = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.lblClampDown = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lblClampUp = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnClampUpDown = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMagOn = new System.Windows.Forms.Label();
            this.lblFull = new System.Windows.Forms.Label();
            this.lblJam = new System.Windows.Forms.Label();
            this.btnGotoNext = new System.Windows.Forms.Button();
            this.btnGotoPrev = new System.Windows.Forms.Button();
            this.btnCycle = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnUnloadMagazine = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCurrentIndex = new System.Windows.Forms.TextBox();
            this.btnLoadMagazine = new System.Windows.Forms.Button();
            this.btnInitialize = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(349, 7);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 19);
            this.label15.TabIndex = 166;
            this.label15.Tag = "1";
            this.label15.Text = "速度";
            // 
            // BtnSetSpeed
            // 
            this.BtnSetSpeed.BackColor = System.Drawing.Color.White;
            this.BtnSetSpeed.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold);
            this.BtnSetSpeed.ForeColor = System.Drawing.Color.Black;
            this.BtnSetSpeed.Location = new System.Drawing.Point(402, 0);
            this.BtnSetSpeed.Name = "BtnSetSpeed";
            this.BtnSetSpeed.Size = new System.Drawing.Size(36, 35);
            this.BtnSetSpeed.TabIndex = 165;
            this.BtnSetSpeed.Tag = "1";
            this.BtnSetSpeed.Text = "慢";
            this.BtnSetSpeed.UseVisualStyleBackColor = false;
            this.BtnSetSpeed.Click += new System.EventHandler(this.BtnSetSpeed_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.txtSlotNoUp);
            this.groupBox4.Controls.Add(this.txtSlotNoDown);
            this.groupBox4.Controls.Add(this.txtSlotNo);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.btnGotoUnload);
            this.groupBox4.Controls.Add(this.btnGotoLoad);
            this.groupBox4.Controls.Add(this.btnUnloadDown);
            this.groupBox4.Controls.Add(this.btnUnloadPositionUp);
            this.groupBox4.Controls.Add(this.btnUnloadPositionDown);
            this.groupBox4.Controls.Add(this.txtUnloadPosition);
            this.groupBox4.Controls.Add(this.btnLoadPositionUp);
            this.groupBox4.Controls.Add(this.btnLoadPositionDown);
            this.groupBox4.Controls.Add(this.txtLoadPosition);
            this.groupBox4.Controls.Add(this.btnUnloadDownPositionUp);
            this.groupBox4.Controls.Add(this.btnUnloadDownPositionDown);
            this.groupBox4.Controls.Add(this.txtUnloadDownPosition);
            this.groupBox4.Controls.Add(this.btnGotoFirst);
            this.groupBox4.Controls.Add(this.btnGotoLast);
            this.groupBox4.Controls.Add(this.btnFirstPositionUp);
            this.groupBox4.Controls.Add(this.btnFirstPositionDown);
            this.groupBox4.Controls.Add(this.txtLastPosition);
            this.groupBox4.Controls.Add(this.txtFirstPosition);
            this.groupBox4.Controls.Add(this.btnLastPositionDown);
            this.groupBox4.Controls.Add(this.btnLastPositionUp);
            this.groupBox4.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(1, 47);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(310, 481);
            this.groupBox4.TabIndex = 95;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "位置";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label16.Location = new System.Drawing.Point(207, 379);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 16);
            this.label16.TabIndex = 138;
            this.label16.Text = "槽位数";
            // 
            // txtSlotNoUp
            // 
            this.txtSlotNoUp.ForeColor = System.Drawing.Color.Black;
            this.txtSlotNoUp.Location = new System.Drawing.Point(199, 429);
            this.txtSlotNoUp.Margin = new System.Windows.Forms.Padding(2);
            this.txtSlotNoUp.Name = "txtSlotNoUp";
            this.txtSlotNoUp.Size = new System.Drawing.Size(40, 34);
            this.txtSlotNoUp.TabIndex = 135;
            this.txtSlotNoUp.Tag = "1";
            this.txtSlotNoUp.Text = "+";
            this.txtSlotNoUp.UseVisualStyleBackColor = true;
            this.txtSlotNoUp.Click += new System.EventHandler(this.txtSlotNoUp_Click);
            // 
            // txtSlotNoDown
            // 
            this.txtSlotNoDown.ForeColor = System.Drawing.Color.Black;
            this.txtSlotNoDown.Location = new System.Drawing.Point(243, 429);
            this.txtSlotNoDown.Margin = new System.Windows.Forms.Padding(2);
            this.txtSlotNoDown.Name = "txtSlotNoDown";
            this.txtSlotNoDown.Size = new System.Drawing.Size(40, 34);
            this.txtSlotNoDown.TabIndex = 136;
            this.txtSlotNoDown.Tag = "1";
            this.txtSlotNoDown.Text = "-";
            this.txtSlotNoDown.UseVisualStyleBackColor = true;
            this.txtSlotNoDown.Click += new System.EventHandler(this.txtSlotNoDown_Click);
            // 
            // txtSlotNo
            // 
            this.txtSlotNo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtSlotNo.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSlotNo.Location = new System.Drawing.Point(199, 400);
            this.txtSlotNo.Margin = new System.Windows.Forms.Padding(2);
            this.txtSlotNo.Name = "txtSlotNo";
            this.txtSlotNo.ReadOnly = true;
            this.txtSlotNo.Size = new System.Drawing.Size(85, 26);
            this.txtSlotNo.TabIndex = 137;
            this.txtSlotNo.Tag = "1";
            this.txtSlotNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.Location = new System.Drawing.Point(26, 379);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(76, 16);
            this.label14.TabIndex = 133;
            this.label14.Text = "载入下位";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(26, 285);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 16);
            this.label13.TabIndex = 132;
            this.label13.Text = "最后槽位";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(28, 196);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 16);
            this.label7.TabIndex = 131;
            this.label7.Text = "第一槽位";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(26, 108);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 16);
            this.label3.TabIndex = 130;
            this.label3.Text = "载出下位";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(17, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 129;
            this.label2.Text = "载出上位";
            // 
            // btnGotoUnload
            // 
            this.btnGotoUnload.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnGotoUnload.ForeColor = System.Drawing.Color.Black;
            this.btnGotoUnload.Location = new System.Drawing.Point(106, 41);
            this.btnGotoUnload.Margin = new System.Windows.Forms.Padding(2);
            this.btnGotoUnload.Name = "btnGotoUnload";
            this.btnGotoUnload.Size = new System.Drawing.Size(60, 26);
            this.btnGotoUnload.TabIndex = 95;
            this.btnGotoUnload.Text = "移至";
            this.btnGotoUnload.UseVisualStyleBackColor = true;
            this.btnGotoUnload.Click += new System.EventHandler(this.btnGotoUnload_Click);
            // 
            // btnGotoLoad
            // 
            this.btnGotoLoad.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnGotoLoad.ForeColor = System.Drawing.Color.Black;
            this.btnGotoLoad.Location = new System.Drawing.Point(106, 400);
            this.btnGotoLoad.Margin = new System.Windows.Forms.Padding(2);
            this.btnGotoLoad.Name = "btnGotoLoad";
            this.btnGotoLoad.Size = new System.Drawing.Size(60, 26);
            this.btnGotoLoad.TabIndex = 94;
            this.btnGotoLoad.Text = "移至";
            this.btnGotoLoad.UseVisualStyleBackColor = true;
            this.btnGotoLoad.Click += new System.EventHandler(this.btnGotoLoad_Click);
            // 
            // btnUnloadDown
            // 
            this.btnUnloadDown.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUnloadDown.ForeColor = System.Drawing.Color.Black;
            this.btnUnloadDown.Location = new System.Drawing.Point(106, 126);
            this.btnUnloadDown.Margin = new System.Windows.Forms.Padding(2);
            this.btnUnloadDown.Name = "btnUnloadDown";
            this.btnUnloadDown.Size = new System.Drawing.Size(60, 26);
            this.btnUnloadDown.TabIndex = 96;
            this.btnUnloadDown.Text = "移至";
            this.btnUnloadDown.UseVisualStyleBackColor = true;
            this.btnUnloadDown.Click += new System.EventHandler(this.btnUnloadDown_Click);
            // 
            // btnUnloadPositionUp
            // 
            this.btnUnloadPositionUp.Image = global::YS_6000.Properties.Resources.icons8_double_up_30;
            this.btnUnloadPositionUp.Location = new System.Drawing.Point(18, 68);
            this.btnUnloadPositionUp.Margin = new System.Windows.Forms.Padding(2);
            this.btnUnloadPositionUp.Name = "btnUnloadPositionUp";
            this.btnUnloadPositionUp.Size = new System.Drawing.Size(40, 34);
            this.btnUnloadPositionUp.TabIndex = 97;
            this.btnUnloadPositionUp.Tag = "1";
            this.btnUnloadPositionUp.UseVisualStyleBackColor = true;
            this.btnUnloadPositionUp.Click += new System.EventHandler(this.btnUnloadPositionUp_Click);
            // 
            // btnUnloadPositionDown
            // 
            this.btnUnloadPositionDown.Image = ((System.Drawing.Image)(resources.GetObject("btnUnloadPositionDown.Image")));
            this.btnUnloadPositionDown.Location = new System.Drawing.Point(62, 68);
            this.btnUnloadPositionDown.Margin = new System.Windows.Forms.Padding(2);
            this.btnUnloadPositionDown.Name = "btnUnloadPositionDown";
            this.btnUnloadPositionDown.Size = new System.Drawing.Size(40, 34);
            this.btnUnloadPositionDown.TabIndex = 98;
            this.btnUnloadPositionDown.Tag = "1";
            this.btnUnloadPositionDown.UseVisualStyleBackColor = true;
            this.btnUnloadPositionDown.Click += new System.EventHandler(this.btnUnloadPositionDown_Click);
            // 
            // txtUnloadPosition
            // 
            this.txtUnloadPosition.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtUnloadPosition.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtUnloadPosition.Location = new System.Drawing.Point(18, 41);
            this.txtUnloadPosition.Margin = new System.Windows.Forms.Padding(2);
            this.txtUnloadPosition.Name = "txtUnloadPosition";
            this.txtUnloadPosition.ReadOnly = true;
            this.txtUnloadPosition.Size = new System.Drawing.Size(84, 26);
            this.txtUnloadPosition.TabIndex = 99;
            this.txtUnloadPosition.Tag = "1";
            this.txtUnloadPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnLoadPositionUp
            // 
            this.btnLoadPositionUp.Image = ((System.Drawing.Image)(resources.GetObject("btnLoadPositionUp.Image")));
            this.btnLoadPositionUp.Location = new System.Drawing.Point(18, 427);
            this.btnLoadPositionUp.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoadPositionUp.Name = "btnLoadPositionUp";
            this.btnLoadPositionUp.Size = new System.Drawing.Size(40, 34);
            this.btnLoadPositionUp.TabIndex = 100;
            this.btnLoadPositionUp.Tag = "1";
            this.btnLoadPositionUp.UseVisualStyleBackColor = true;
            this.btnLoadPositionUp.Click += new System.EventHandler(this.btnLoadPositionUp_Click);
            // 
            // btnLoadPositionDown
            // 
            this.btnLoadPositionDown.Image = ((System.Drawing.Image)(resources.GetObject("btnLoadPositionDown.Image")));
            this.btnLoadPositionDown.Location = new System.Drawing.Point(62, 427);
            this.btnLoadPositionDown.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoadPositionDown.Name = "btnLoadPositionDown";
            this.btnLoadPositionDown.Size = new System.Drawing.Size(40, 34);
            this.btnLoadPositionDown.TabIndex = 101;
            this.btnLoadPositionDown.Tag = "1";
            this.btnLoadPositionDown.UseVisualStyleBackColor = true;
            this.btnLoadPositionDown.Click += new System.EventHandler(this.btnLoadPositionDown_Click);
            // 
            // txtLoadPosition
            // 
            this.txtLoadPosition.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtLoadPosition.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtLoadPosition.Location = new System.Drawing.Point(19, 400);
            this.txtLoadPosition.Margin = new System.Windows.Forms.Padding(2);
            this.txtLoadPosition.Name = "txtLoadPosition";
            this.txtLoadPosition.ReadOnly = true;
            this.txtLoadPosition.Size = new System.Drawing.Size(85, 26);
            this.txtLoadPosition.TabIndex = 102;
            this.txtLoadPosition.Tag = "1";
            this.txtLoadPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnUnloadDownPositionUp
            // 
            this.btnUnloadDownPositionUp.Image = ((System.Drawing.Image)(resources.GetObject("btnUnloadDownPositionUp.Image")));
            this.btnUnloadDownPositionUp.Location = new System.Drawing.Point(18, 156);
            this.btnUnloadDownPositionUp.Margin = new System.Windows.Forms.Padding(2);
            this.btnUnloadDownPositionUp.Name = "btnUnloadDownPositionUp";
            this.btnUnloadDownPositionUp.Size = new System.Drawing.Size(40, 34);
            this.btnUnloadDownPositionUp.TabIndex = 103;
            this.btnUnloadDownPositionUp.Tag = "1";
            this.btnUnloadDownPositionUp.UseVisualStyleBackColor = true;
            this.btnUnloadDownPositionUp.Click += new System.EventHandler(this.btnUnloadDownPositionUp_Click);
            // 
            // btnUnloadDownPositionDown
            // 
            this.btnUnloadDownPositionDown.Image = ((System.Drawing.Image)(resources.GetObject("btnUnloadDownPositionDown.Image")));
            this.btnUnloadDownPositionDown.Location = new System.Drawing.Point(62, 156);
            this.btnUnloadDownPositionDown.Margin = new System.Windows.Forms.Padding(2);
            this.btnUnloadDownPositionDown.Name = "btnUnloadDownPositionDown";
            this.btnUnloadDownPositionDown.Size = new System.Drawing.Size(40, 34);
            this.btnUnloadDownPositionDown.TabIndex = 104;
            this.btnUnloadDownPositionDown.Tag = "1";
            this.btnUnloadDownPositionDown.UseVisualStyleBackColor = true;
            this.btnUnloadDownPositionDown.Click += new System.EventHandler(this.btnUnloadDownPositionDown_Click);
            // 
            // txtUnloadDownPosition
            // 
            this.txtUnloadDownPosition.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtUnloadDownPosition.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtUnloadDownPosition.Location = new System.Drawing.Point(18, 128);
            this.txtUnloadDownPosition.Margin = new System.Windows.Forms.Padding(2);
            this.txtUnloadDownPosition.Name = "txtUnloadDownPosition";
            this.txtUnloadDownPosition.ReadOnly = true;
            this.txtUnloadDownPosition.Size = new System.Drawing.Size(84, 26);
            this.txtUnloadDownPosition.TabIndex = 105;
            this.txtUnloadDownPosition.Tag = "1";
            this.txtUnloadDownPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnGotoFirst
            // 
            this.btnGotoFirst.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnGotoFirst.ForeColor = System.Drawing.Color.Black;
            this.btnGotoFirst.Location = new System.Drawing.Point(106, 215);
            this.btnGotoFirst.Margin = new System.Windows.Forms.Padding(2);
            this.btnGotoFirst.Name = "btnGotoFirst";
            this.btnGotoFirst.Size = new System.Drawing.Size(60, 26);
            this.btnGotoFirst.TabIndex = 106;
            this.btnGotoFirst.Text = "移至";
            this.btnGotoFirst.UseVisualStyleBackColor = true;
            this.btnGotoFirst.Click += new System.EventHandler(this.btnGotoFirst_Click);
            // 
            // btnGotoLast
            // 
            this.btnGotoLast.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnGotoLast.ForeColor = System.Drawing.Color.Black;
            this.btnGotoLast.Location = new System.Drawing.Point(106, 309);
            this.btnGotoLast.Margin = new System.Windows.Forms.Padding(2);
            this.btnGotoLast.Name = "btnGotoLast";
            this.btnGotoLast.Size = new System.Drawing.Size(60, 26);
            this.btnGotoLast.TabIndex = 107;
            this.btnGotoLast.Text = "移至";
            this.btnGotoLast.UseVisualStyleBackColor = true;
            this.btnGotoLast.Click += new System.EventHandler(this.btnGotoLast_Click);
            // 
            // btnFirstPositionUp
            // 
            this.btnFirstPositionUp.Image = ((System.Drawing.Image)(resources.GetObject("btnFirstPositionUp.Image")));
            this.btnFirstPositionUp.Location = new System.Drawing.Point(18, 245);
            this.btnFirstPositionUp.Margin = new System.Windows.Forms.Padding(2);
            this.btnFirstPositionUp.Name = "btnFirstPositionUp";
            this.btnFirstPositionUp.Size = new System.Drawing.Size(40, 34);
            this.btnFirstPositionUp.TabIndex = 108;
            this.btnFirstPositionUp.Tag = "1";
            this.btnFirstPositionUp.UseVisualStyleBackColor = true;
            this.btnFirstPositionUp.Click += new System.EventHandler(this.btnFirstPositionUp_Click);
            // 
            // btnFirstPositionDown
            // 
            this.btnFirstPositionDown.Image = ((System.Drawing.Image)(resources.GetObject("btnFirstPositionDown.Image")));
            this.btnFirstPositionDown.Location = new System.Drawing.Point(62, 245);
            this.btnFirstPositionDown.Margin = new System.Windows.Forms.Padding(2);
            this.btnFirstPositionDown.Name = "btnFirstPositionDown";
            this.btnFirstPositionDown.Size = new System.Drawing.Size(40, 34);
            this.btnFirstPositionDown.TabIndex = 109;
            this.btnFirstPositionDown.Tag = "1";
            this.btnFirstPositionDown.UseVisualStyleBackColor = true;
            this.btnFirstPositionDown.Click += new System.EventHandler(this.btnFirstPositionDown_Click);
            // 
            // txtLastPosition
            // 
            this.txtLastPosition.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtLastPosition.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtLastPosition.Location = new System.Drawing.Point(18, 309);
            this.txtLastPosition.Margin = new System.Windows.Forms.Padding(2);
            this.txtLastPosition.Name = "txtLastPosition";
            this.txtLastPosition.ReadOnly = true;
            this.txtLastPosition.Size = new System.Drawing.Size(83, 26);
            this.txtLastPosition.TabIndex = 113;
            this.txtLastPosition.Tag = "1";
            this.txtLastPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtFirstPosition
            // 
            this.txtFirstPosition.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtFirstPosition.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtFirstPosition.Location = new System.Drawing.Point(18, 217);
            this.txtFirstPosition.Margin = new System.Windows.Forms.Padding(2);
            this.txtFirstPosition.Name = "txtFirstPosition";
            this.txtFirstPosition.ReadOnly = true;
            this.txtFirstPosition.Size = new System.Drawing.Size(84, 26);
            this.txtFirstPosition.TabIndex = 110;
            this.txtFirstPosition.Tag = "1";
            this.txtFirstPosition.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnLastPositionDown
            // 
            this.btnLastPositionDown.Image = ((System.Drawing.Image)(resources.GetObject("btnLastPositionDown.Image")));
            this.btnLastPositionDown.Location = new System.Drawing.Point(62, 337);
            this.btnLastPositionDown.Margin = new System.Windows.Forms.Padding(2);
            this.btnLastPositionDown.Name = "btnLastPositionDown";
            this.btnLastPositionDown.Size = new System.Drawing.Size(40, 34);
            this.btnLastPositionDown.TabIndex = 112;
            this.btnLastPositionDown.Tag = "1";
            this.btnLastPositionDown.UseVisualStyleBackColor = true;
            this.btnLastPositionDown.Click += new System.EventHandler(this.btnLastPositionDown_Click);
            // 
            // btnLastPositionUp
            // 
            this.btnLastPositionUp.Image = ((System.Drawing.Image)(resources.GetObject("btnLastPositionUp.Image")));
            this.btnLastPositionUp.Location = new System.Drawing.Point(18, 337);
            this.btnLastPositionUp.Margin = new System.Windows.Forms.Padding(2);
            this.btnLastPositionUp.Name = "btnLastPositionUp";
            this.btnLastPositionUp.Size = new System.Drawing.Size(40, 34);
            this.btnLastPositionUp.TabIndex = 111;
            this.btnLastPositionUp.Tag = "1";
            this.btnLastPositionUp.UseVisualStyleBackColor = true;
            this.btnLastPositionUp.Click += new System.EventHandler(this.btnLastPositionUp_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblHolderBack);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lblHolderOut);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.btnHolderOutBack);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.lblClampDown);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.lblClampUp);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.btnClampUpDown);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lblMagOn);
            this.groupBox2.Controls.Add(this.lblFull);
            this.groupBox2.Controls.Add(this.lblJam);
            this.groupBox2.Controls.Add(this.btnGotoNext);
            this.groupBox2.Controls.Add(this.btnGotoPrev);
            this.groupBox2.Controls.Add(this.btnCycle);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.btnUnloadMagazine);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtCurrentIndex);
            this.groupBox2.Controls.Add(this.btnLoadMagazine);
            this.groupBox2.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(317, 47);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(440, 481);
            this.groupBox2.TabIndex = 94;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "测试";
            // 
            // lblHolderBack
            // 
            this.lblHolderBack.BackColor = System.Drawing.Color.Gray;
            this.lblHolderBack.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblHolderBack.ForeColor = System.Drawing.Color.White;
            this.lblHolderBack.Location = new System.Drawing.Point(164, 418);
            this.lblHolderBack.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHolderBack.Name = "lblHolderBack";
            this.lblHolderBack.Size = new System.Drawing.Size(35, 35);
            this.lblHolderBack.TabIndex = 204;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(208, 428);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 203;
            this.label4.Text = "缩回检";
            // 
            // lblHolderOut
            // 
            this.lblHolderOut.BackColor = System.Drawing.Color.Gray;
            this.lblHolderOut.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblHolderOut.ForeColor = System.Drawing.Color.White;
            this.lblHolderOut.Location = new System.Drawing.Point(83, 418);
            this.lblHolderOut.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblHolderOut.Name = "lblHolderOut";
            this.lblHolderOut.Size = new System.Drawing.Size(35, 35);
            this.lblHolderOut.TabIndex = 202;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(7, 428);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 16);
            this.label8.TabIndex = 201;
            this.label8.Text = "伸出检";
            // 
            // btnHolderOutBack
            // 
            this.btnHolderOutBack.ForeColor = System.Drawing.Color.Black;
            this.btnHolderOutBack.Location = new System.Drawing.Point(122, 418);
            this.btnHolderOutBack.Margin = new System.Windows.Forms.Padding(2);
            this.btnHolderOutBack.Name = "btnHolderOutBack";
            this.btnHolderOutBack.Size = new System.Drawing.Size(38, 38);
            this.btnHolderOutBack.TabIndex = 200;
            this.btnHolderOutBack.UseVisualStyleBackColor = true;
            this.btnHolderOutBack.Click += new System.EventHandler(this.btnHolderOutBack_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(118, 397);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 16);
            this.label12.TabIndex = 199;
            this.label12.Text = "夹紧";
            // 
            // lblClampDown
            // 
            this.lblClampDown.BackColor = System.Drawing.Color.Gray;
            this.lblClampDown.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblClampDown.ForeColor = System.Drawing.Color.White;
            this.lblClampDown.Location = new System.Drawing.Point(12, 289);
            this.lblClampDown.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClampDown.Name = "lblClampDown";
            this.lblClampDown.Size = new System.Drawing.Size(35, 35);
            this.lblClampDown.TabIndex = 198;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(56, 299);
            this.label19.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(42, 16);
            this.label19.TabIndex = 197;
            this.label19.Text = "下检";
            // 
            // lblClampUp
            // 
            this.lblClampUp.BackColor = System.Drawing.Color.Gray;
            this.lblClampUp.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblClampUp.ForeColor = System.Drawing.Color.White;
            this.lblClampUp.Location = new System.Drawing.Point(12, 209);
            this.lblClampUp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClampUp.Name = "lblClampUp";
            this.lblClampUp.Size = new System.Drawing.Size(35, 35);
            this.lblClampUp.TabIndex = 196;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(56, 217);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 16);
            this.label11.TabIndex = 195;
            this.label11.Text = "上检";
            // 
            // btnClampUpDown
            // 
            this.btnClampUpDown.ForeColor = System.Drawing.Color.Black;
            this.btnClampUpDown.Location = new System.Drawing.Point(11, 249);
            this.btnClampUpDown.Margin = new System.Windows.Forms.Padding(2);
            this.btnClampUpDown.Name = "btnClampUpDown";
            this.btnClampUpDown.Size = new System.Drawing.Size(38, 38);
            this.btnClampUpDown.TabIndex = 194;
            this.btnClampUpDown.UseVisualStyleBackColor = true;
            this.btnClampUpDown.Click += new System.EventHandler(this.btnClampUpDown_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(56, 255);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 16);
            this.label1.TabIndex = 193;
            this.label1.Text = "夹紧";
            // 
            // lblMagOn
            // 
            this.lblMagOn.BackColor = System.Drawing.Color.Gray;
            this.lblMagOn.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMagOn.ForeColor = System.Drawing.Color.White;
            this.lblMagOn.Location = new System.Drawing.Point(12, 111);
            this.lblMagOn.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMagOn.Name = "lblMagOn";
            this.lblMagOn.Size = new System.Drawing.Size(35, 35);
            this.lblMagOn.TabIndex = 186;
            // 
            // lblFull
            // 
            this.lblFull.BackColor = System.Drawing.Color.Gray;
            this.lblFull.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblFull.ForeColor = System.Drawing.Color.White;
            this.lblFull.Location = new System.Drawing.Point(12, 71);
            this.lblFull.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFull.Name = "lblFull";
            this.lblFull.Size = new System.Drawing.Size(35, 35);
            this.lblFull.TabIndex = 185;
            // 
            // lblJam
            // 
            this.lblJam.BackColor = System.Drawing.Color.Gray;
            this.lblJam.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblJam.ForeColor = System.Drawing.Color.White;
            this.lblJam.Location = new System.Drawing.Point(12, 30);
            this.lblJam.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblJam.Name = "lblJam";
            this.lblJam.Size = new System.Drawing.Size(35, 35);
            this.lblJam.TabIndex = 184;
            // 
            // btnGotoNext
            // 
            this.btnGotoNext.BackColor = System.Drawing.Color.White;
            this.btnGotoNext.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnGotoNext.ForeColor = System.Drawing.Color.Black;
            this.btnGotoNext.Location = new System.Drawing.Point(307, 236);
            this.btnGotoNext.Margin = new System.Windows.Forms.Padding(2);
            this.btnGotoNext.Name = "btnGotoNext";
            this.btnGotoNext.Size = new System.Drawing.Size(108, 43);
            this.btnGotoNext.TabIndex = 134;
            this.btnGotoNext.Text = "下一槽位";
            this.btnGotoNext.UseVisualStyleBackColor = false;
            this.btnGotoNext.Click += new System.EventHandler(this.btnGotoNext_Click);
            // 
            // btnGotoPrev
            // 
            this.btnGotoPrev.BackColor = System.Drawing.Color.White;
            this.btnGotoPrev.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnGotoPrev.ForeColor = System.Drawing.Color.Black;
            this.btnGotoPrev.Location = new System.Drawing.Point(307, 103);
            this.btnGotoPrev.Margin = new System.Windows.Forms.Padding(2);
            this.btnGotoPrev.Name = "btnGotoPrev";
            this.btnGotoPrev.Size = new System.Drawing.Size(108, 43);
            this.btnGotoPrev.TabIndex = 133;
            this.btnGotoPrev.Text = "上一槽位";
            this.btnGotoPrev.UseVisualStyleBackColor = false;
            this.btnGotoPrev.Click += new System.EventHandler(this.btnGotoPrev_Click);
            // 
            // btnCycle
            // 
            this.btnCycle.BackColor = System.Drawing.Color.White;
            this.btnCycle.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnCycle.ForeColor = System.Drawing.Color.Black;
            this.btnCycle.Location = new System.Drawing.Point(307, 410);
            this.btnCycle.Margin = new System.Windows.Forms.Padding(2);
            this.btnCycle.Name = "btnCycle";
            this.btnCycle.Size = new System.Drawing.Size(108, 43);
            this.btnCycle.TabIndex = 132;
            this.btnCycle.Text = "循环";
            this.btnCycle.UseVisualStyleBackColor = false;
            this.btnCycle.Click += new System.EventHandler(this.btnCycle_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(47, 84);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 16);
            this.label9.TabIndex = 128;
            this.label9.Text = "弹匣满料";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(47, 39);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 16);
            this.label6.TabIndex = 128;
            this.label6.Text = "料口有料";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(47, 123);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 16);
            this.label10.TabIndex = 126;
            this.label10.Text = "弹匣侦测";
            // 
            // btnUnloadMagazine
            // 
            this.btnUnloadMagazine.BackColor = System.Drawing.Color.White;
            this.btnUnloadMagazine.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUnloadMagazine.ForeColor = System.Drawing.Color.Black;
            this.btnUnloadMagazine.Location = new System.Drawing.Point(307, 41);
            this.btnUnloadMagazine.Margin = new System.Windows.Forms.Padding(2);
            this.btnUnloadMagazine.Name = "btnUnloadMagazine";
            this.btnUnloadMagazine.Size = new System.Drawing.Size(108, 43);
            this.btnUnloadMagazine.TabIndex = 123;
            this.btnUnloadMagazine.Text = "载出弹匣";
            this.btnUnloadMagazine.UseVisualStyleBackColor = false;
            this.btnUnloadMagazine.Click += new System.EventHandler(this.btnUnloadMagazine_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(321, 164);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 120;
            this.label5.Text = "当前槽位";
            // 
            // txtCurrentIndex
            // 
            this.txtCurrentIndex.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtCurrentIndex.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtCurrentIndex.Location = new System.Drawing.Point(316, 186);
            this.txtCurrentIndex.Margin = new System.Windows.Forms.Padding(2);
            this.txtCurrentIndex.Name = "txtCurrentIndex";
            this.txtCurrentIndex.ReadOnly = true;
            this.txtCurrentIndex.Size = new System.Drawing.Size(99, 26);
            this.txtCurrentIndex.TabIndex = 119;
            this.txtCurrentIndex.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnLoadMagazine
            // 
            this.btnLoadMagazine.BackColor = System.Drawing.Color.White;
            this.btnLoadMagazine.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnLoadMagazine.ForeColor = System.Drawing.Color.Black;
            this.btnLoadMagazine.Location = new System.Drawing.Point(307, 292);
            this.btnLoadMagazine.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoadMagazine.Name = "btnLoadMagazine";
            this.btnLoadMagazine.Size = new System.Drawing.Size(108, 43);
            this.btnLoadMagazine.TabIndex = 118;
            this.btnLoadMagazine.Text = "载入弹匣";
            this.btnLoadMagazine.UseVisualStyleBackColor = false;
            this.btnLoadMagazine.Click += new System.EventHandler(this.btnLoadMagazine_Click);
            // 
            // btnInitialize
            // 
            this.btnInitialize.BackColor = System.Drawing.Color.White;
            this.btnInitialize.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnInitialize.ForeColor = System.Drawing.Color.Black;
            this.btnInitialize.Location = new System.Drawing.Point(178, 0);
            this.btnInitialize.Margin = new System.Windows.Forms.Padding(2);
            this.btnInitialize.Name = "btnInitialize";
            this.btnInitialize.Size = new System.Drawing.Size(107, 39);
            this.btnInitialize.TabIndex = 41;
            this.btnInitialize.Text = "归零";
            this.btnInitialize.UseVisualStyleBackColor = false;
            this.btnInitialize.Click += new System.EventHandler(this.btnInitialize_Click);
            // 
            // frmMagazineOutput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(65)))), ((int)(((byte)(72)))));
            this.ClientSize = new System.Drawing.Size(852, 573);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.BtnSetSpeed);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnInitialize);
            this.KeyPreview = true;
            this.Name = "frmMagazineOutput";
            this.Tag = "1";
            this.Text = "弹仓输出";
            this.TopMost = true;
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnInitialize;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtLastPosition;
        private System.Windows.Forms.Button btnLastPositionDown;
        private System.Windows.Forms.Button btnLastPositionUp;
        private System.Windows.Forms.TextBox txtFirstPosition;
        private System.Windows.Forms.Button btnFirstPositionDown;
        private System.Windows.Forms.Button btnFirstPositionUp;
        private System.Windows.Forms.Button btnGotoLast;
        private System.Windows.Forms.Button btnGotoFirst;
        private System.Windows.Forms.TextBox txtUnloadDownPosition;
        private System.Windows.Forms.Button btnUnloadDownPositionDown;
        private System.Windows.Forms.Button btnUnloadDownPositionUp;
        private System.Windows.Forms.TextBox txtLoadPosition;
        private System.Windows.Forms.Button btnLoadPositionDown;
        private System.Windows.Forms.Button btnLoadPositionUp;
        private System.Windows.Forms.TextBox txtUnloadPosition;
        private System.Windows.Forms.Button btnUnloadPositionDown;
        private System.Windows.Forms.Button btnUnloadPositionUp;
        private System.Windows.Forms.Button btnUnloadDown;
        private System.Windows.Forms.Button btnGotoUnload;
        private System.Windows.Forms.Button btnGotoLoad;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnUnloadMagazine;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCurrentIndex;
        private System.Windows.Forms.Button btnLoadMagazine;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnCycle;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button BtnSetSpeed;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnGotoNext;
        private System.Windows.Forms.Button btnGotoPrev;
        private System.Windows.Forms.Label lblMagOn;
        private System.Windows.Forms.Label lblFull;
        private System.Windows.Forms.Label lblJam;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button txtSlotNoUp;
        private System.Windows.Forms.Button txtSlotNoDown;
        private System.Windows.Forms.TextBox txtSlotNo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblHolderBack;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblHolderOut;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnHolderOutBack;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblClampDown;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblClampUp;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnClampUpDown;
        private System.Windows.Forms.Label label1;
    }
}