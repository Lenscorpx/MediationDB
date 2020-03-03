namespace MediationDB.FormLibrary
{
    partial class frm_accueil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_accueil));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_beneficiaires = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_executants = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_projets = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_fonciers = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1300, 78);
            this.panel1.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(305, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(753, 49);
            this.label1.TabIndex = 8;
            this.label1.Text = "ONU Habitat - Land Datas Dashboard";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(273, 134);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 215);
            this.groupBox1.TabIndex = 84;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conflits fonciers";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(273, 374);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(347, 215);
            this.groupBox2.TabIndex = 85;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sensibilisations et ateliers";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(904, 134);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(358, 215);
            this.groupBox3.TabIndex = 86;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Activités génératrices de revenus";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox4.ForeColor = System.Drawing.Color.White;
            this.groupBox4.Location = new System.Drawing.Point(904, 374);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(358, 215);
            this.groupBox4.TabIndex = 86;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Paramètres de l\'application";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(327, 68);
            this.label2.TabIndex = 0;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(331, 102);
            this.label3.TabIndex = 1;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(335, 68);
            this.label4.TabIndex = 1;
            this.label4.Text = resources.GetString("label4.Text");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(263, 68);
            this.label5.TabIndex = 2;
            this.label5.Text = "Ici se trouvent les paramètres et autres \r\nconfigurations nécessaires à l\'utilisa" +
    "tion \r\ndes données et aux générations des \r\nimprimables";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MediationDB.Properties.Resources.UNHABITAT_svg;
            this.pictureBox1.Location = new System.Drawing.Point(406, 622);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(549, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 143;
            this.pictureBox1.TabStop = false;
            // 
            // btn_beneficiaires
            // 
            this.btn_beneficiaires.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_beneficiaires.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(142)))));
            this.btn_beneficiaires.color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(142)))));
            this.btn_beneficiaires.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.btn_beneficiaires.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_beneficiaires.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btn_beneficiaires.ForeColor = System.Drawing.Color.White;
            this.btn_beneficiaires.Image = global::MediationDB.Properties.Resources.settings;
            this.btn_beneficiaires.ImagePosition = 14;
            this.btn_beneficiaires.ImageZoom = 50;
            this.btn_beneficiaires.LabelPosition = 27;
            this.btn_beneficiaires.LabelText = "Paramètres de l\'application";
            this.btn_beneficiaires.Location = new System.Drawing.Point(648, 374);
            this.btn_beneficiaires.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_beneficiaires.Name = "btn_beneficiaires";
            this.btn_beneficiaires.Size = new System.Drawing.Size(249, 215);
            this.btn_beneficiaires.TabIndex = 82;
            // 
            // btn_executants
            // 
            this.btn_executants.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_executants.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(142)))));
            this.btn_executants.color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(142)))));
            this.btn_executants.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.btn_executants.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_executants.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btn_executants.ForeColor = System.Drawing.Color.White;
            this.btn_executants.Image = global::MediationDB.Properties.Resources.distribution;
            this.btn_executants.ImagePosition = 14;
            this.btn_executants.ImageZoom = 50;
            this.btn_executants.LabelPosition = 27;
            this.btn_executants.LabelText = "AGRs";
            this.btn_executants.Location = new System.Drawing.Point(648, 134);
            this.btn_executants.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_executants.Name = "btn_executants";
            this.btn_executants.Size = new System.Drawing.Size(249, 215);
            this.btn_executants.TabIndex = 81;
            // 
            // btn_projets
            // 
            this.btn_projets.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_projets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(142)))));
            this.btn_projets.color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(142)))));
            this.btn_projets.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.btn_projets.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_projets.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btn_projets.ForeColor = System.Drawing.Color.White;
            this.btn_projets.Image = global::MediationDB.Properties.Resources.sensibilisation;
            this.btn_projets.ImagePosition = 14;
            this.btn_projets.ImageZoom = 50;
            this.btn_projets.LabelPosition = 27;
            this.btn_projets.LabelText = "Sensibilisations";
            this.btn_projets.Location = new System.Drawing.Point(17, 374);
            this.btn_projets.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_projets.Name = "btn_projets";
            this.btn_projets.Size = new System.Drawing.Size(249, 215);
            this.btn_projets.TabIndex = 80;
            // 
            // btn_fonciers
            // 
            this.btn_fonciers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_fonciers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(142)))));
            this.btn_fonciers.color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(142)))));
            this.btn_fonciers.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.btn_fonciers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_fonciers.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btn_fonciers.ForeColor = System.Drawing.Color.White;
            this.btn_fonciers.Image = global::MediationDB.Properties.Resources.conflits;
            this.btn_fonciers.ImagePosition = 14;
            this.btn_fonciers.ImageZoom = 50;
            this.btn_fonciers.LabelPosition = 27;
            this.btn_fonciers.LabelText = "Conflits Fonciers";
            this.btn_fonciers.Location = new System.Drawing.Point(17, 134);
            this.btn_fonciers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_fonciers.Name = "btn_fonciers";
            this.btn_fonciers.Size = new System.Drawing.Size(249, 215);
            this.btn_fonciers.TabIndex = 79;
            this.btn_fonciers.Click += new System.EventHandler(this.btn_fonciers_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuImageButton1.Image = global::MediationDB.Properties.Resources.multiply_96px;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(1233, 9);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(55, 55);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 7;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // frm_accueil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(1300, 690);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_beneficiaires);
            this.Controls.Add(this.btn_executants);
            this.Controls.Add(this.btn_projets);
            this.Controls.Add(this.btn_fonciers);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_accueil";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        public Bunifu.Framework.UI.BunifuTileButton btn_beneficiaires;
        public Bunifu.Framework.UI.BunifuTileButton btn_executants;
        public Bunifu.Framework.UI.BunifuTileButton btn_fonciers;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        public Bunifu.Framework.UI.BunifuTileButton btn_projets;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}