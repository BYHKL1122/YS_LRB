namespace YS_6000.UserInterface
{
    partial class frmSetupOven
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
            this.btnSV = new System.Windows.Forms.Button();
            this.btnOven = new System.Windows.Forms.Button();
            this.btnOutput = new System.Windows.Forms.Button();
            this.btnInput = new System.Windows.Forms.Button();
            this.pnlSetup = new System.Windows.Forms.Panel();
            this.btnAH = new System.Windows.Forms.Button();
            this.btnAL = new System.Windows.Forms.Button();
            this.btnSC = new System.Windows.Forms.Button();
            this.btnChamber2 = new System.Windows.Forms.Button();
            this.btnChamber1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSV
            // 
            this.btnSV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(84)))), ((int)(((byte)(94)))));
            this.btnSV.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSV.Font = new System.Drawing.Font("楷体", 12F);
            this.btnSV.ForeColor = System.Drawing.Color.White;
            this.btnSV.Location = new System.Drawing.Point(256, 3);
            this.btnSV.Name = "btnSV";
            this.btnSV.Size = new System.Drawing.Size(75, 23);
            this.btnSV.TabIndex = 435;
            this.btnSV.Tag = "1";
            this.btnSV.Text = "炉温";
            this.btnSV.UseVisualStyleBackColor = false;
            this.btnSV.Click += new System.EventHandler(this.btnSV_Click);
            // 
            // btnOven
            // 
            this.btnOven.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(84)))), ((int)(((byte)(94)))));
            this.btnOven.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOven.Font = new System.Drawing.Font("楷体", 12F);
            this.btnOven.ForeColor = System.Drawing.Color.White;
            this.btnOven.Location = new System.Drawing.Point(94, 3);
            this.btnOven.Name = "btnOven";
            this.btnOven.Size = new System.Drawing.Size(75, 23);
            this.btnOven.TabIndex = 434;
            this.btnOven.Text = "烤炉";
            this.btnOven.UseVisualStyleBackColor = false;
            this.btnOven.Click += new System.EventHandler(this.btnOven_Click);
            // 
            // btnOutput
            // 
            this.btnOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(84)))), ((int)(((byte)(94)))));
            this.btnOutput.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOutput.Font = new System.Drawing.Font("楷体", 12F);
            this.btnOutput.ForeColor = System.Drawing.Color.White;
            this.btnOutput.Location = new System.Drawing.Point(175, 3);
            this.btnOutput.Name = "btnOutput";
            this.btnOutput.Size = new System.Drawing.Size(75, 23);
            this.btnOutput.TabIndex = 431;
            this.btnOutput.Text = "出炉";
            this.btnOutput.UseVisualStyleBackColor = false;
            this.btnOutput.Click += new System.EventHandler(this.btnOutput_Click);
            // 
            // btnInput
            // 
            this.btnInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(84)))), ((int)(((byte)(94)))));
            this.btnInput.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInput.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnInput.ForeColor = System.Drawing.Color.White;
            this.btnInput.Location = new System.Drawing.Point(12, 3);
            this.btnInput.Name = "btnInput";
            this.btnInput.Size = new System.Drawing.Size(75, 23);
            this.btnInput.TabIndex = 430;
            this.btnInput.Text = "进炉";
            this.btnInput.UseVisualStyleBackColor = false;
            this.btnInput.Click += new System.EventHandler(this.btnInput_Click);
            // 
            // pnlSetup
            // 
            this.pnlSetup.Location = new System.Drawing.Point(8, 30);
            this.pnlSetup.Name = "pnlSetup";
            this.pnlSetup.Size = new System.Drawing.Size(962, 651);
            this.pnlSetup.TabIndex = 429;
            // 
            // btnAH
            // 
            this.btnAH.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(84)))), ((int)(((byte)(94)))));
            this.btnAH.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAH.Font = new System.Drawing.Font("楷体", 12F);
            this.btnAH.ForeColor = System.Drawing.Color.White;
            this.btnAH.Location = new System.Drawing.Point(337, 3);
            this.btnAH.Name = "btnAH";
            this.btnAH.Size = new System.Drawing.Size(75, 23);
            this.btnAH.TabIndex = 436;
            this.btnAH.Tag = "1";
            this.btnAH.Text = "上限";
            this.btnAH.UseVisualStyleBackColor = false;
            this.btnAH.Click += new System.EventHandler(this.btnAH_Click);
            // 
            // btnAL
            // 
            this.btnAL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(84)))), ((int)(((byte)(94)))));
            this.btnAL.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAL.Font = new System.Drawing.Font("楷体", 12F);
            this.btnAL.ForeColor = System.Drawing.Color.White;
            this.btnAL.Location = new System.Drawing.Point(418, 3);
            this.btnAL.Name = "btnAL";
            this.btnAL.Size = new System.Drawing.Size(75, 23);
            this.btnAL.TabIndex = 437;
            this.btnAL.Tag = "1";
            this.btnAL.Text = "下限";
            this.btnAL.UseVisualStyleBackColor = false;
            this.btnAL.Click += new System.EventHandler(this.btnAL_Click);
            // 
            // btnSC
            // 
            this.btnSC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(84)))), ((int)(((byte)(94)))));
            this.btnSC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSC.Font = new System.Drawing.Font("楷体", 12F);
            this.btnSC.ForeColor = System.Drawing.Color.White;
            this.btnSC.Location = new System.Drawing.Point(499, 3);
            this.btnSC.Name = "btnSC";
            this.btnSC.Size = new System.Drawing.Size(75, 23);
            this.btnSC.TabIndex = 438;
            this.btnSC.Tag = "1";
            this.btnSC.Text = "补偿";
            this.btnSC.UseVisualStyleBackColor = false;
            this.btnSC.Click += new System.EventHandler(this.btnSC_Click);
            // 
            // btnChamber2
            // 
            this.btnChamber2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(84)))), ((int)(((byte)(94)))));
            this.btnChamber2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChamber2.Font = new System.Drawing.Font("楷体", 12F);
            this.btnChamber2.ForeColor = System.Drawing.Color.White;
            this.btnChamber2.Location = new System.Drawing.Point(661, 3);
            this.btnChamber2.Name = "btnChamber2";
            this.btnChamber2.Size = new System.Drawing.Size(75, 23);
            this.btnChamber2.TabIndex = 442;
            this.btnChamber2.Text = "外腔";
            this.btnChamber2.UseVisualStyleBackColor = false;
            this.btnChamber2.Click += new System.EventHandler(this.btnChamber2_Click);
            // 
            // btnChamber1
            // 
            this.btnChamber1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(84)))), ((int)(((byte)(94)))));
            this.btnChamber1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChamber1.Font = new System.Drawing.Font("楷体", 12F);
            this.btnChamber1.ForeColor = System.Drawing.Color.White;
            this.btnChamber1.Location = new System.Drawing.Point(580, 3);
            this.btnChamber1.Name = "btnChamber1";
            this.btnChamber1.Size = new System.Drawing.Size(75, 23);
            this.btnChamber1.TabIndex = 441;
            this.btnChamber1.Text = "内腔";
            this.btnChamber1.UseVisualStyleBackColor = false;
            this.btnChamber1.Click += new System.EventHandler(this.btnChamber1_Click);
            // 
            // frmSetupOven
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 693);
            this.Controls.Add(this.btnChamber2);
            this.Controls.Add(this.btnChamber1);
            this.Controls.Add(this.btnSC);
            this.Controls.Add(this.btnAL);
            this.Controls.Add(this.btnAH);
            this.Controls.Add(this.btnSV);
            this.Controls.Add(this.btnOven);
            this.Controls.Add(this.btnOutput);
            this.Controls.Add(this.btnInput);
            this.Controls.Add(this.pnlSetup);
            this.Name = "frmSetupOven";
            this.Text = "frmSetupOven";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSetupOven_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOven;
        private System.Windows.Forms.Button btnOutput;
        private System.Windows.Forms.Button btnInput;
        private System.Windows.Forms.Panel pnlSetup;
        private System.Windows.Forms.Button btnSV;
        private System.Windows.Forms.Button btnAH;
        private System.Windows.Forms.Button btnAL;
        private System.Windows.Forms.Button btnSC;
        private System.Windows.Forms.Button btnChamber2;
        private System.Windows.Forms.Button btnChamber1;
    }
}