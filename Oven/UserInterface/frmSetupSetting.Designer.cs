namespace YS_6000.UserInterface
{
    partial class frmSetupSeting
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
            this.btnMagazine = new System.Windows.Forms.Button();
            this.btnOvenOutputTrack = new System.Windows.Forms.Button();
            this.btnOven = new System.Windows.Forms.Button();
            this.btnOvenInputTrack = new System.Windows.Forms.Button();
            this.pnlSetup = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnMagazine
            // 
            this.btnMagazine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(84)))), ((int)(((byte)(94)))));
            this.btnMagazine.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMagazine.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnMagazine.ForeColor = System.Drawing.Color.White;
            this.btnMagazine.Location = new System.Drawing.Point(300, 2);
            this.btnMagazine.Name = "btnMagazine";
            this.btnMagazine.Size = new System.Drawing.Size(90, 28);
            this.btnMagazine.TabIndex = 429;
            this.btnMagazine.Text = "弹匣";
            this.btnMagazine.UseVisualStyleBackColor = false;
            this.btnMagazine.Click += new System.EventHandler(this.btnMagazine_Click);
            // 
            // btnOvenOutputTrack
            // 
            this.btnOvenOutputTrack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(84)))), ((int)(((byte)(94)))));
            this.btnOvenOutputTrack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOvenOutputTrack.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOvenOutputTrack.ForeColor = System.Drawing.Color.White;
            this.btnOvenOutputTrack.Location = new System.Drawing.Point(204, 2);
            this.btnOvenOutputTrack.Name = "btnOvenOutputTrack";
            this.btnOvenOutputTrack.Size = new System.Drawing.Size(90, 28);
            this.btnOvenOutputTrack.TabIndex = 428;
            this.btnOvenOutputTrack.Text = "出炉轨道";
            this.btnOvenOutputTrack.UseVisualStyleBackColor = false;
            this.btnOvenOutputTrack.Click += new System.EventHandler(this.btnOvenOutputTrack_Click);
            // 
            // btnOven
            // 
            this.btnOven.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(84)))), ((int)(((byte)(94)))));
            this.btnOven.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOven.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOven.ForeColor = System.Drawing.Color.White;
            this.btnOven.Location = new System.Drawing.Point(108, 2);
            this.btnOven.Name = "btnOven";
            this.btnOven.Size = new System.Drawing.Size(90, 28);
            this.btnOven.TabIndex = 426;
            this.btnOven.Text = "烤炉";
            this.btnOven.UseVisualStyleBackColor = false;
            this.btnOven.Click += new System.EventHandler(this.btnOven_Click);
            // 
            // btnOvenInputTrack
            // 
            this.btnOvenInputTrack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(84)))), ((int)(((byte)(94)))));
            this.btnOvenInputTrack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOvenInputTrack.Font = new System.Drawing.Font("楷体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOvenInputTrack.ForeColor = System.Drawing.Color.White;
            this.btnOvenInputTrack.Location = new System.Drawing.Point(12, 2);
            this.btnOvenInputTrack.Name = "btnOvenInputTrack";
            this.btnOvenInputTrack.Size = new System.Drawing.Size(90, 28);
            this.btnOvenInputTrack.TabIndex = 425;
            this.btnOvenInputTrack.Text = "入炉轨道";
            this.btnOvenInputTrack.UseVisualStyleBackColor = false;
            this.btnOvenInputTrack.Click += new System.EventHandler(this.btnOvenInputArm_Click);
            // 
            // pnlSetup
            // 
            this.pnlSetup.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlSetup.Location = new System.Drawing.Point(6, 36);
            this.pnlSetup.Name = "pnlSetup";
            this.pnlSetup.Size = new System.Drawing.Size(1000, 654);
            this.pnlSetup.TabIndex = 417;
            // 
            // frmSetupSeting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(65)))), ((int)(((byte)(72)))));
            this.ClientSize = new System.Drawing.Size(1017, 702);
            this.Controls.Add(this.btnMagazine);
            this.Controls.Add(this.btnOvenOutputTrack);
            this.Controls.Add(this.btnOven);
            this.Controls.Add(this.btnOvenInputTrack);
            this.Controls.Add(this.pnlSetup);
            this.Name = "frmSetupSeting";
            this.Text = "frmSetupSeting";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSetup;
        private System.Windows.Forms.Button btnOvenInputTrack;
        private System.Windows.Forms.Button btnOven;
        private System.Windows.Forms.Button btnOvenOutputTrack;
        private System.Windows.Forms.Button btnMagazine;
    }
}