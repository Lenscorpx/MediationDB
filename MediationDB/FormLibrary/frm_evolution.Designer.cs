namespace MediationDB.FormLibrary
{
    partial class frm_evolution
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_nombre_menages = new System.Windows.Forms.Label();
            this.lbl_nombre_membre = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_date = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_conflits = new System.Windows.Forms.Label();
            this.lbl_resolu = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_encours = new System.Windows.Forms.Label();
            this.labelxf = new System.Windows.Forms.Label();
            this.lbl_classed = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_referes = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.lbl_sensibilisations = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_garcons = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_filles = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lbl_femme = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lbl_homme = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
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
            this.panel1.Size = new System.Drawing.Size(1300, 49);
            this.panel1.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(400, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(489, 30);
            this.label1.TabIndex = 8;
            this.label1.Text = "Etat d\'evolution du travail en temps reel";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(651, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(292, 42);
            this.label2.TabIndex = 9;
            this.label2.Text = "Menages entrés";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(982, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(290, 42);
            this.label3.TabIndex = 35;
            this.label3.Text = "Membres entrés";
            // 
            // lbl_nombre_menages
            // 
            this.lbl_nombre_menages.AutoSize = true;
            this.lbl_nombre_menages.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre_menages.ForeColor = System.Drawing.Color.White;
            this.lbl_nombre_menages.Location = new System.Drawing.Point(757, 122);
            this.lbl_nombre_menages.Name = "lbl_nombre_menages";
            this.lbl_nombre_menages.Size = new System.Drawing.Size(37, 42);
            this.lbl_nombre_menages.TabIndex = 36;
            this.lbl_nombre_menages.Text = "0";
            // 
            // lbl_nombre_membre
            // 
            this.lbl_nombre_membre.AutoSize = true;
            this.lbl_nombre_membre.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre_membre.ForeColor = System.Drawing.Color.White;
            this.lbl_nombre_membre.Location = new System.Drawing.Point(1120, 122);
            this.lbl_nombre_membre.Name = "lbl_nombre_membre";
            this.lbl_nombre_membre.Size = new System.Drawing.Size(37, 42);
            this.lbl_nombre_membre.TabIndex = 37;
            this.lbl_nombre_membre.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.ForeColor = System.Drawing.Color.White;
            this.lbl_date.Location = new System.Drawing.Point(30, 69);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(21, 30);
            this.lbl_date.TabIndex = 38;
            this.lbl_date.Text = "-";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(28, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(254, 42);
            this.label4.TabIndex = 39;
            this.label4.Text = "Conflits entrés";
            // 
            // lbl_conflits
            // 
            this.lbl_conflits.AutoSize = true;
            this.lbl_conflits.Font = new System.Drawing.Font("Century Gothic", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_conflits.ForeColor = System.Drawing.Color.White;
            this.lbl_conflits.Location = new System.Drawing.Point(151, 213);
            this.lbl_conflits.Name = "lbl_conflits";
            this.lbl_conflits.Size = new System.Drawing.Size(37, 42);
            this.lbl_conflits.TabIndex = 40;
            this.lbl_conflits.Text = "0";
            // 
            // lbl_resolu
            // 
            this.lbl_resolu.AutoSize = true;
            this.lbl_resolu.Font = new System.Drawing.Font("Century Gothic", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_resolu.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_resolu.Location = new System.Drawing.Point(159, 363);
            this.lbl_resolu.Name = "lbl_resolu";
            this.lbl_resolu.Size = new System.Drawing.Size(37, 42);
            this.lbl_resolu.TabIndex = 42;
            this.lbl_resolu.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Yellow;
            this.label6.Location = new System.Drawing.Point(103, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 42);
            this.label6.TabIndex = 41;
            this.label6.Text = "Resolus";
            // 
            // lbl_encours
            // 
            this.lbl_encours.AutoSize = true;
            this.lbl_encours.Font = new System.Drawing.Font("Century Gothic", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_encours.ForeColor = System.Drawing.Color.White;
            this.lbl_encours.Location = new System.Drawing.Point(443, 363);
            this.lbl_encours.Name = "lbl_encours";
            this.lbl_encours.Size = new System.Drawing.Size(37, 42);
            this.lbl_encours.TabIndex = 44;
            this.lbl_encours.Text = "0";
            // 
            // labelxf
            // 
            this.labelxf.AutoSize = true;
            this.labelxf.Font = new System.Drawing.Font("Century Gothic", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelxf.ForeColor = System.Drawing.Color.White;
            this.labelxf.Location = new System.Drawing.Point(382, 284);
            this.labelxf.Name = "labelxf";
            this.labelxf.Size = new System.Drawing.Size(160, 42);
            this.labelxf.TabIndex = 43;
            this.labelxf.Text = "En cours";
            // 
            // lbl_classed
            // 
            this.lbl_classed.AutoSize = true;
            this.lbl_classed.Font = new System.Drawing.Font("Century Gothic", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_classed.ForeColor = System.Drawing.Color.White;
            this.lbl_classed.Location = new System.Drawing.Point(739, 363);
            this.lbl_classed.Name = "lbl_classed";
            this.lbl_classed.Size = new System.Drawing.Size(37, 42);
            this.lbl_classed.TabIndex = 46;
            this.lbl_classed.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(686, 284);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(141, 42);
            this.label10.TabIndex = 45;
            this.label10.Text = "Classés";
            // 
            // lbl_referes
            // 
            this.lbl_referes.AutoSize = true;
            this.lbl_referes.Font = new System.Drawing.Font("Century Gothic", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_referes.ForeColor = System.Drawing.Color.White;
            this.lbl_referes.Location = new System.Drawing.Point(1028, 363);
            this.lbl_referes.Name = "lbl_referes";
            this.lbl_referes.Size = new System.Drawing.Size(37, 42);
            this.lbl_referes.TabIndex = 48;
            this.lbl_referes.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(973, 284);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(144, 42);
            this.label12.TabIndex = 47;
            this.label12.Text = "Referés";
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
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // lbl_sensibilisations
            // 
            this.lbl_sensibilisations.AutoSize = true;
            this.lbl_sensibilisations.Font = new System.Drawing.Font("Century Gothic", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sensibilisations.ForeColor = System.Drawing.Color.White;
            this.lbl_sensibilisations.Location = new System.Drawing.Point(151, 489);
            this.lbl_sensibilisations.Name = "lbl_sensibilisations";
            this.lbl_sensibilisations.Size = new System.Drawing.Size(37, 42);
            this.lbl_sensibilisations.TabIndex = 50;
            this.lbl_sensibilisations.Text = "0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(28, 428);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(259, 42);
            this.label7.TabIndex = 49;
            this.label7.Text = "Sensibilisations";
            // 
            // lbl_garcons
            // 
            this.lbl_garcons.AutoSize = true;
            this.lbl_garcons.Font = new System.Drawing.Font("Century Gothic", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_garcons.ForeColor = System.Drawing.Color.White;
            this.lbl_garcons.Location = new System.Drawing.Point(1037, 627);
            this.lbl_garcons.Name = "lbl_garcons";
            this.lbl_garcons.Size = new System.Drawing.Size(37, 42);
            this.lbl_garcons.TabIndex = 58;
            this.lbl_garcons.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(982, 548);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(165, 42);
            this.label8.TabIndex = 57;
            this.label8.Text = "Garcons";
            // 
            // lbl_filles
            // 
            this.lbl_filles.AutoSize = true;
            this.lbl_filles.Font = new System.Drawing.Font("Century Gothic", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_filles.ForeColor = System.Drawing.Color.White;
            this.lbl_filles.Location = new System.Drawing.Point(748, 627);
            this.lbl_filles.Name = "lbl_filles";
            this.lbl_filles.Size = new System.Drawing.Size(37, 42);
            this.lbl_filles.TabIndex = 56;
            this.lbl_filles.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(715, 548);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 42);
            this.label11.TabIndex = 55;
            this.label11.Text = "Filles";
            // 
            // lbl_femme
            // 
            this.lbl_femme.AutoSize = true;
            this.lbl_femme.Font = new System.Drawing.Font("Century Gothic", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_femme.ForeColor = System.Drawing.Color.White;
            this.lbl_femme.Location = new System.Drawing.Point(452, 627);
            this.lbl_femme.Name = "lbl_femme";
            this.lbl_femme.Size = new System.Drawing.Size(37, 42);
            this.lbl_femme.TabIndex = 54;
            this.lbl_femme.Text = "0";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(391, 548);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(159, 42);
            this.label14.TabIndex = 53;
            this.label14.Text = "Femmes";
            // 
            // lbl_homme
            // 
            this.lbl_homme.AutoSize = true;
            this.lbl_homme.Font = new System.Drawing.Font("Century Gothic", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_homme.ForeColor = System.Drawing.Color.White;
            this.lbl_homme.Location = new System.Drawing.Point(168, 627);
            this.lbl_homme.Name = "lbl_homme";
            this.lbl_homme.Size = new System.Drawing.Size(37, 42);
            this.lbl_homme.TabIndex = 52;
            this.lbl_homme.Text = "0";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Century Gothic", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(112, 548);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(166, 42);
            this.label16.TabIndex = 51;
            this.label16.Text = "Hommes";
            // 
            // frm_evolution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(1300, 714);
            this.Controls.Add(this.lbl_garcons);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbl_filles);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lbl_femme);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lbl_homme);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.lbl_sensibilisations);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl_referes);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lbl_classed);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbl_encours);
            this.Controls.Add(this.labelxf);
            this.Controls.Add(this.lbl_resolu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_conflits);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.lbl_nombre_membre);
            this.Controls.Add(this.lbl_nombre_menages);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frm_evolution";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_evolution_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_nombre_menages;
        private System.Windows.Forms.Label lbl_nombre_membre;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_conflits;
        private System.Windows.Forms.Label lbl_resolu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_encours;
        private System.Windows.Forms.Label labelxf;
        private System.Windows.Forms.Label lbl_classed;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_referes;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbl_sensibilisations;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_garcons;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbl_filles;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbl_femme;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lbl_homme;
        private System.Windows.Forms.Label label16;
    }
}