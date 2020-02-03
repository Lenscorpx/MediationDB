namespace MediationDB.FormLibrary
{
    partial class frm_stats_conflits
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_stats_conflits));
            this.bunifuGauge1 = new Bunifu.Framework.UI.BunifuGauge();
            this.bunifuProgressBar1 = new Bunifu.Framework.UI.BunifuProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_nbre_conflits = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuGauge1
            // 
            this.bunifuGauge1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGauge1.BackgroundImage")));
            this.bunifuGauge1.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuGauge1.ForeColor = System.Drawing.Color.White;
            this.bunifuGauge1.Location = new System.Drawing.Point(140, 251);
            this.bunifuGauge1.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuGauge1.Name = "bunifuGauge1";
            this.bunifuGauge1.ProgressBgColor = System.Drawing.Color.White;
            this.bunifuGauge1.ProgressColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.bunifuGauge1.ProgressColor2 = System.Drawing.Color.Yellow;
            this.bunifuGauge1.Size = new System.Drawing.Size(161, 111);
            this.bunifuGauge1.TabIndex = 1;
            this.bunifuGauge1.Thickness = 30;
            this.bunifuGauge1.Value = 78;
            // 
            // bunifuProgressBar1
            // 
            this.bunifuProgressBar1.BackColor = System.Drawing.Color.Silver;
            this.bunifuProgressBar1.BorderRadius = 5;
            this.bunifuProgressBar1.Location = new System.Drawing.Point(585, 352);
            this.bunifuProgressBar1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuProgressBar1.MaximumValue = 100;
            this.bunifuProgressBar1.Name = "bunifuProgressBar1";
            this.bunifuProgressBar1.ProgressColor = System.Drawing.Color.Teal;
            this.bunifuProgressBar1.Size = new System.Drawing.Size(433, 10);
            this.bunifuProgressBar1.TabIndex = 2;
            this.bunifuProgressBar1.Value = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1300, 49);
            this.panel1.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(501, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 30);
            this.label1.TabIndex = 8;
            this.label1.Text = "Statistiques instantanées";
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuImageButton1.Image = global::MediationDB.Properties.Resources.multiply_96px;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(1246, 7);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(42, 34);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 7;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(32, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(302, 30);
            this.label2.TabIndex = 9;
            this.label2.Text = "Statistiques instantanées";
            // 
            // lbl_nbre_conflits
            // 
            this.lbl_nbre_conflits.AutoSize = true;
            this.lbl_nbre_conflits.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nbre_conflits.ForeColor = System.Drawing.Color.White;
            this.lbl_nbre_conflits.Location = new System.Drawing.Point(349, 143);
            this.lbl_nbre_conflits.Name = "lbl_nbre_conflits";
            this.lbl_nbre_conflits.Size = new System.Drawing.Size(26, 30);
            this.lbl_nbre_conflits.TabIndex = 36;
            this.lbl_nbre_conflits.Text = "0";
            this.lbl_nbre_conflits.Click += new System.EventHandler(this.lbl_nbre_conflits_Click);
            // 
            // frm_stats_conflits
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(1300, 714);
            this.Controls.Add(this.lbl_nbre_conflits);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bunifuProgressBar1);
            this.Controls.Add(this.bunifuGauge1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_stats_conflits";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGauge bunifuGauge1;
        private Bunifu.Framework.UI.BunifuProgressBar bunifuProgressBar1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_nbre_conflits;
    }
}