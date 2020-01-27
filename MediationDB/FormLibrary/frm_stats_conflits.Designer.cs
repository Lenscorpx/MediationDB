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
            this.SuspendLayout();
            // 
            // bunifuGauge1
            // 
            this.bunifuGauge1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGauge1.BackgroundImage")));
            this.bunifuGauge1.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuGauge1.ForeColor = System.Drawing.Color.White;
            this.bunifuGauge1.Location = new System.Drawing.Point(226, 71);
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
            this.bunifuProgressBar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuProgressBar1.MaximumValue = 100;
            this.bunifuProgressBar1.Name = "bunifuProgressBar1";
            this.bunifuProgressBar1.ProgressColor = System.Drawing.Color.Teal;
            this.bunifuProgressBar1.Size = new System.Drawing.Size(433, 10);
            this.bunifuProgressBar1.TabIndex = 2;
            this.bunifuProgressBar1.Value = 0;
            // 
            // frm_stats_conflits
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(1300, 714);
            this.Controls.Add(this.bunifuProgressBar1);
            this.Controls.Add(this.bunifuGauge1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_stats_conflits";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGauge bunifuGauge1;
        private Bunifu.Framework.UI.BunifuProgressBar bunifuProgressBar1;
    }
}