namespace YS_6000.UserInterface
{
    partial class frmProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProfile));
            this.toolIconBar = new System.Windows.Forms.ToolStrip();
            this.toolResetPlot = new System.Windows.Forms.ToolStripButton();
            this.toolCompute = new System.Windows.Forms.ToolStripButton();
            this.toolExit = new System.Windows.Forms.ToolStripButton();
            this.toolSave = new System.Windows.Forms.ToolStripButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabProfile = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTotalSecond = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEndSSplus = new System.Windows.Forms.Button();
            this.btnEndMMminus = new System.Windows.Forms.Button();
            this.btnEndMMplus = new System.Windows.Forms.Button();
            this.btnEndSSminus = new System.Windows.Forms.Button();
            this.btnBeginSSplus = new System.Windows.Forms.Button();
            this.btnBeginMMminus = new System.Windows.Forms.Button();
            this.btnBeginMMplus = new System.Windows.Forms.Button();
            this.btnBeginSSminus = new System.Windows.Forms.Button();
            this.dateEndTime = new System.Windows.Forms.DateTimePicker();
            this.dateBeginTime = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateBeginDate = new System.Windows.Forms.DateTimePicker();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dgvStd = new System.Windows.Forms.DataGridView();
            this.pnlTime = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dgvSummary = new System.Windows.Forms.DataGridView();
            this.tabProfileList = new System.Windows.Forms.TabPage();
            this.dgvProfiles = new System.Windows.Forms.DataGridView();
            this.toolIconBar.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabProfile.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStd)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSummary)).BeginInit();
            this.tabProfileList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfiles)).BeginInit();
            this.SuspendLayout();
            // 
            // toolIconBar
            // 
            this.toolIconBar.ImageScalingSize = new System.Drawing.Size(36, 36);
            this.toolIconBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolResetPlot,
            this.toolCompute,
            this.toolExit,
            this.toolSave});
            this.toolIconBar.Location = new System.Drawing.Point(0, 0);
            this.toolIconBar.Name = "toolIconBar";
            this.toolIconBar.Size = new System.Drawing.Size(900, 43);
            this.toolIconBar.TabIndex = 164;
            this.toolIconBar.Text = "toolStrip1";
            // 
            // toolResetPlot
            // 
            this.toolResetPlot.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolResetPlot.Image = ((System.Drawing.Image)(resources.GetObject("toolResetPlot.Image")));
            this.toolResetPlot.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolResetPlot.Name = "toolResetPlot";
            this.toolResetPlot.Size = new System.Drawing.Size(40, 40);
            this.toolResetPlot.Text = "Reset Chart";
            this.toolResetPlot.Click += new System.EventHandler(this.toolResetPlot_Click);
            // 
            // toolCompute
            // 
            this.toolCompute.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolCompute.Image = ((System.Drawing.Image)(resources.GetObject("toolCompute.Image")));
            this.toolCompute.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolCompute.Name = "toolCompute";
            this.toolCompute.Size = new System.Drawing.Size(40, 40);
            this.toolCompute.Text = "計算";
            this.toolCompute.Click += new System.EventHandler(this.toolCompute_Click);
            // 
            // toolExit
            // 
            this.toolExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolExit.Image = ((System.Drawing.Image)(resources.GetObject("toolExit.Image")));
            this.toolExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolExit.Name = "toolExit";
            this.toolExit.Size = new System.Drawing.Size(40, 40);
            this.toolExit.Text = "離開";
            this.toolExit.Click += new System.EventHandler(this.toolExit_Click);
            // 
            // toolSave
            // 
            this.toolSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolSave.Image = ((System.Drawing.Image)(resources.GetObject("toolSave.Image")));
            this.toolSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolSave.Name = "toolSave";
            this.toolSave.Size = new System.Drawing.Size(40, 40);
            this.toolSave.Text = "toolStripButton1";
            this.toolSave.Click += new System.EventHandler(this.toolSave_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabProfile);
            this.tabControl1.Controls.Add(this.tabProfileList);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 43);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(900, 518);
            this.tabControl1.TabIndex = 165;
            // 
            // tabProfile
            // 
            this.tabProfile.Controls.Add(this.tableLayoutPanel1);
            this.tabProfile.Location = new System.Drawing.Point(4, 22);
            this.tabProfile.Margin = new System.Windows.Forms.Padding(2);
            this.tabProfile.Name = "tabProfile";
            this.tabProfile.Padding = new System.Windows.Forms.Padding(2);
            this.tabProfile.Size = new System.Drawing.Size(892, 492);
            this.tabProfile.TabIndex = 0;
            this.tabProfile.Text = "Profile";
            this.tabProfile.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.98503F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80.01497F));
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.pnlTime, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 139F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(888, 488);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.tableLayoutPanel1.SetRowSpan(this.panel1, 3);
            this.panel1.Size = new System.Drawing.Size(173, 484);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtTotalSecond);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnEndSSplus);
            this.panel2.Controls.Add(this.btnEndMMminus);
            this.panel2.Controls.Add(this.btnEndMMplus);
            this.panel2.Controls.Add(this.btnEndSSminus);
            this.panel2.Controls.Add(this.btnBeginSSplus);
            this.panel2.Controls.Add(this.btnBeginMMminus);
            this.panel2.Controls.Add(this.btnBeginMMplus);
            this.panel2.Controls.Add(this.btnBeginSSminus);
            this.panel2.Controls.Add(this.dateEndTime);
            this.panel2.Controls.Add(this.dateBeginTime);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.dateBeginDate);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(173, 484);
            this.panel2.TabIndex = 0;
            // 
            // txtTotalSecond
            // 
            this.txtTotalSecond.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtTotalSecond.Location = new System.Drawing.Point(81, 51);
            this.txtTotalSecond.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotalSecond.Name = "txtTotalSecond";
            this.txtTotalSecond.ReadOnly = true;
            this.txtTotalSecond.Size = new System.Drawing.Size(68, 26);
            this.txtTotalSecond.TabIndex = 333;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(22, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 332;
            this.label2.Text = "总秒数";
            // 
            // btnEndSSplus
            // 
            this.btnEndSSplus.BackColor = System.Drawing.Color.Transparent;
            this.btnEndSSplus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEndSSplus.BackgroundImage")));
            this.btnEndSSplus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEndSSplus.Location = new System.Drawing.Point(95, 340);
            this.btnEndSSplus.Margin = new System.Windows.Forms.Padding(2);
            this.btnEndSSplus.Name = "btnEndSSplus";
            this.btnEndSSplus.Size = new System.Drawing.Size(33, 33);
            this.btnEndSSplus.TabIndex = 330;
            this.btnEndSSplus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEndSSplus.UseVisualStyleBackColor = false;
            this.btnEndSSplus.Click += new System.EventHandler(this.btnEndSSplus_Click);
            // 
            // btnEndMMminus
            // 
            this.btnEndMMminus.BackColor = System.Drawing.Color.Transparent;
            this.btnEndMMminus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEndMMminus.BackgroundImage")));
            this.btnEndMMminus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEndMMminus.Location = new System.Drawing.Point(7, 340);
            this.btnEndMMminus.Margin = new System.Windows.Forms.Padding(2);
            this.btnEndMMminus.Name = "btnEndMMminus";
            this.btnEndMMminus.Size = new System.Drawing.Size(33, 33);
            this.btnEndMMminus.TabIndex = 328;
            this.btnEndMMminus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEndMMminus.UseVisualStyleBackColor = false;
            this.btnEndMMminus.Click += new System.EventHandler(this.btnEndMMminus_Click);
            // 
            // btnEndMMplus
            // 
            this.btnEndMMplus.BackColor = System.Drawing.Color.Transparent;
            this.btnEndMMplus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEndMMplus.BackgroundImage")));
            this.btnEndMMplus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEndMMplus.Location = new System.Drawing.Point(132, 340);
            this.btnEndMMplus.Margin = new System.Windows.Forms.Padding(2);
            this.btnEndMMplus.Name = "btnEndMMplus";
            this.btnEndMMplus.Size = new System.Drawing.Size(33, 33);
            this.btnEndMMplus.TabIndex = 331;
            this.btnEndMMplus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEndMMplus.UseVisualStyleBackColor = false;
            this.btnEndMMplus.Click += new System.EventHandler(this.btnEndMMplus_Click);
            // 
            // btnEndSSminus
            // 
            this.btnEndSSminus.BackColor = System.Drawing.Color.Transparent;
            this.btnEndSSminus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEndSSminus.BackgroundImage")));
            this.btnEndSSminus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEndSSminus.Location = new System.Drawing.Point(43, 340);
            this.btnEndSSminus.Margin = new System.Windows.Forms.Padding(2);
            this.btnEndSSminus.Name = "btnEndSSminus";
            this.btnEndSSminus.Size = new System.Drawing.Size(33, 33);
            this.btnEndSSminus.TabIndex = 329;
            this.btnEndSSminus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEndSSminus.UseVisualStyleBackColor = false;
            this.btnEndSSminus.Click += new System.EventHandler(this.btnEndSSminus_Click);
            // 
            // btnBeginSSplus
            // 
            this.btnBeginSSplus.BackColor = System.Drawing.Color.Transparent;
            this.btnBeginSSplus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBeginSSplus.BackgroundImage")));
            this.btnBeginSSplus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBeginSSplus.Location = new System.Drawing.Point(95, 208);
            this.btnBeginSSplus.Margin = new System.Windows.Forms.Padding(2);
            this.btnBeginSSplus.Name = "btnBeginSSplus";
            this.btnBeginSSplus.Size = new System.Drawing.Size(33, 33);
            this.btnBeginSSplus.TabIndex = 326;
            this.btnBeginSSplus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBeginSSplus.UseVisualStyleBackColor = false;
            this.btnBeginSSplus.Click += new System.EventHandler(this.btnBeginSSplus_Click);
            // 
            // btnBeginMMminus
            // 
            this.btnBeginMMminus.BackColor = System.Drawing.Color.Transparent;
            this.btnBeginMMminus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBeginMMminus.BackgroundImage")));
            this.btnBeginMMminus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBeginMMminus.Location = new System.Drawing.Point(7, 208);
            this.btnBeginMMminus.Margin = new System.Windows.Forms.Padding(2);
            this.btnBeginMMminus.Name = "btnBeginMMminus";
            this.btnBeginMMminus.Size = new System.Drawing.Size(33, 33);
            this.btnBeginMMminus.TabIndex = 324;
            this.btnBeginMMminus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBeginMMminus.UseVisualStyleBackColor = false;
            this.btnBeginMMminus.Click += new System.EventHandler(this.btnBeginMMminus_Click);
            // 
            // btnBeginMMplus
            // 
            this.btnBeginMMplus.BackColor = System.Drawing.Color.Transparent;
            this.btnBeginMMplus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBeginMMplus.BackgroundImage")));
            this.btnBeginMMplus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBeginMMplus.Location = new System.Drawing.Point(132, 208);
            this.btnBeginMMplus.Margin = new System.Windows.Forms.Padding(2);
            this.btnBeginMMplus.Name = "btnBeginMMplus";
            this.btnBeginMMplus.Size = new System.Drawing.Size(33, 33);
            this.btnBeginMMplus.TabIndex = 327;
            this.btnBeginMMplus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBeginMMplus.UseVisualStyleBackColor = false;
            this.btnBeginMMplus.Click += new System.EventHandler(this.btnBeginMMplus_Click);
            // 
            // btnBeginSSminus
            // 
            this.btnBeginSSminus.BackColor = System.Drawing.Color.Transparent;
            this.btnBeginSSminus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBeginSSminus.BackgroundImage")));
            this.btnBeginSSminus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBeginSSminus.Location = new System.Drawing.Point(43, 208);
            this.btnBeginSSminus.Margin = new System.Windows.Forms.Padding(2);
            this.btnBeginSSminus.Name = "btnBeginSSminus";
            this.btnBeginSSminus.Size = new System.Drawing.Size(33, 33);
            this.btnBeginSSminus.TabIndex = 325;
            this.btnBeginSSminus.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnBeginSSminus.UseVisualStyleBackColor = false;
            this.btnBeginSSminus.Click += new System.EventHandler(this.btnBeginSSminus_Click);
            // 
            // dateEndTime
            // 
            this.dateEndTime.CustomFormat = "HH:mm:ss";
            this.dateEndTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dateEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateEndTime.Location = new System.Drawing.Point(29, 304);
            this.dateEndTime.Margin = new System.Windows.Forms.Padding(2);
            this.dateEndTime.Name = "dateEndTime";
            this.dateEndTime.ShowUpDown = true;
            this.dateEndTime.Size = new System.Drawing.Size(107, 26);
            this.dateEndTime.TabIndex = 14;
            this.dateEndTime.ValueChanged += new System.EventHandler(this.dateEndTime_ValueChanged);
            // 
            // dateBeginTime
            // 
            this.dateBeginTime.CustomFormat = "HH:mm:ss";
            this.dateBeginTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dateBeginTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateBeginTime.Location = new System.Drawing.Point(30, 170);
            this.dateBeginTime.Margin = new System.Windows.Forms.Padding(2);
            this.dateBeginTime.Name = "dateBeginTime";
            this.dateBeginTime.ShowUpDown = true;
            this.dateBeginTime.Size = new System.Drawing.Size(107, 26);
            this.dateBeginTime.TabIndex = 12;
            this.dateBeginTime.ValueChanged += new System.EventHandler(this.dateBeginTime_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(33, 145);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "起始";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(33, 279);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "結束";
            // 
            // dateBeginDate
            // 
            this.dateBeginDate.CustomFormat = "yyyy-MM-dd";
            this.dateBeginDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dateBeginDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateBeginDate.Location = new System.Drawing.Point(30, 96);
            this.dateBeginDate.Margin = new System.Windows.Forms.Padding(2);
            this.dateBeginDate.Name = "dateBeginDate";
            this.dateBeginDate.Size = new System.Drawing.Size(107, 26);
            this.dateBeginDate.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgvStd);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(179, 2);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(707, 84);
            this.panel3.TabIndex = 1;
            // 
            // dgvStd
            // 
            this.dgvStd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStd.Location = new System.Drawing.Point(0, 0);
            this.dgvStd.Margin = new System.Windows.Forms.Padding(2);
            this.dgvStd.Name = "dgvStd";
            this.dgvStd.RowTemplate.Height = 31;
            this.dgvStd.Size = new System.Drawing.Size(707, 84);
            this.dgvStd.TabIndex = 0;
            // 
            // pnlTime
            // 
            this.pnlTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTime.Location = new System.Drawing.Point(179, 90);
            this.pnlTime.Margin = new System.Windows.Forms.Padding(2);
            this.pnlTime.Name = "pnlTime";
            this.pnlTime.Size = new System.Drawing.Size(707, 257);
            this.pnlTime.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.dgvSummary);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(179, 351);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(707, 135);
            this.panel5.TabIndex = 3;
            // 
            // dgvSummary
            // 
            this.dgvSummary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSummary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSummary.Location = new System.Drawing.Point(0, 0);
            this.dgvSummary.Margin = new System.Windows.Forms.Padding(2);
            this.dgvSummary.Name = "dgvSummary";
            this.dgvSummary.RowTemplate.Height = 31;
            this.dgvSummary.Size = new System.Drawing.Size(707, 135);
            this.dgvSummary.TabIndex = 0;
            this.dgvSummary.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSummary_CellDoubleClick);
            // 
            // tabProfileList
            // 
            this.tabProfileList.Controls.Add(this.dgvProfiles);
            this.tabProfileList.Location = new System.Drawing.Point(4, 22);
            this.tabProfileList.Margin = new System.Windows.Forms.Padding(2);
            this.tabProfileList.Name = "tabProfileList";
            this.tabProfileList.Padding = new System.Windows.Forms.Padding(2);
            this.tabProfileList.Size = new System.Drawing.Size(892, 492);
            this.tabProfileList.TabIndex = 1;
            this.tabProfileList.Text = "历史记录";
            this.tabProfileList.UseVisualStyleBackColor = true;
            // 
            // dgvProfiles
            // 
            this.dgvProfiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProfiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProfiles.Location = new System.Drawing.Point(2, 2);
            this.dgvProfiles.Margin = new System.Windows.Forms.Padding(2);
            this.dgvProfiles.Name = "dgvProfiles";
            this.dgvProfiles.RowTemplate.Height = 31;
            this.dgvProfiles.Size = new System.Drawing.Size(888, 488);
            this.dgvProfiles.TabIndex = 0;
            this.dgvProfiles.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvProfiles_CellMouseClick);
            this.dgvProfiles.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvProfiles_CellMouseDoubleClick);
            // 
            // frmProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 561);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolIconBar);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmProfile";
            this.Text = "frmProfile";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolIconBar.ResumeLayout(false);
            this.toolIconBar.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabProfile.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStd)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSummary)).EndInit();
            this.tabProfileList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfiles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolIconBar;
        private System.Windows.Forms.ToolStripButton toolExit;
        private System.Windows.Forms.ToolStripButton toolResetPlot;
        private System.Windows.Forms.ToolStripButton toolCompute;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabProfile;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgvStd;
        private System.Windows.Forms.Panel pnlTime;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView dgvSummary;
        private System.Windows.Forms.TabPage tabProfileList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateEndTime;
        private System.Windows.Forms.DateTimePicker dateBeginTime;
        private System.Windows.Forms.DateTimePicker dateBeginDate;
        private System.Windows.Forms.Button btnEndSSplus;
        private System.Windows.Forms.Button btnEndMMminus;
        private System.Windows.Forms.Button btnEndMMplus;
        private System.Windows.Forms.Button btnEndSSminus;
        private System.Windows.Forms.Button btnBeginSSplus;
        private System.Windows.Forms.Button btnBeginMMminus;
        private System.Windows.Forms.Button btnBeginMMplus;
        private System.Windows.Forms.Button btnBeginSSminus;
        private System.Windows.Forms.ToolStripButton toolSave;
        private System.Windows.Forms.DataGridView dgvProfiles;
        private System.Windows.Forms.TextBox txtTotalSecond;
        private System.Windows.Forms.Label label2;
    }
}