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
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
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
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lb_hommes_resolus = new System.Windows.Forms.Label();
            this.lbl_femmes_resolus = new System.Windows.Forms.Label();
            this.lbl_filles_resolus = new System.Windows.Forms.Label();
            this.lblgars_resolus = new System.Windows.Forms.Label();
            this.lbl_hommes_encours = new System.Windows.Forms.Label();
            this.lbl_femmes_encours = new System.Windows.Forms.Label();
            this.lbl_filles_encours = new System.Windows.Forms.Label();
            this.lbl_gars_encours = new System.Windows.Forms.Label();
            this.lbl_hommes_classe = new System.Windows.Forms.Label();
            this.lbl_femme_classe = new System.Windows.Forms.Label();
            this.lbl_filles_classe = new System.Windows.Forms.Label();
            this.lbl_gars_classe = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Controls.Add(this.lbl_date);
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
            this.label1.Location = new System.Drawing.Point(496, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(489, 30);
            this.label1.TabIndex = 8;
            this.label1.Text = "Etat d\'evolution du travail en temps reel";
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
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
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
            this.lbl_date.Location = new System.Drawing.Point(12, 9);
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
            this.label4.Location = new System.Drawing.Point(23, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 42);
            this.label4.TabIndex = 39;
            this.label4.Text = "Conflits";
            // 
            // lbl_conflits
            // 
            this.lbl_conflits.AutoSize = true;
            this.lbl_conflits.Font = new System.Drawing.Font("Century Gothic", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_conflits.ForeColor = System.Drawing.Color.White;
            this.lbl_conflits.Location = new System.Drawing.Point(192, 65);
            this.lbl_conflits.Name = "lbl_conflits";
            this.lbl_conflits.Size = new System.Drawing.Size(37, 42);
            this.lbl_conflits.TabIndex = 40;
            this.lbl_conflits.Text = "0";
            // 
            // lbl_resolu
            // 
            this.lbl_resolu.AutoSize = true;
            this.lbl_resolu.Font = new System.Drawing.Font("Century Gothic", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_resolu.ForeColor = System.Drawing.Color.Gold;
            this.lbl_resolu.Location = new System.Drawing.Point(188, 137);
            this.lbl_resolu.Name = "lbl_resolu";
            this.lbl_resolu.Size = new System.Drawing.Size(37, 42);
            this.lbl_resolu.TabIndex = 42;
            this.lbl_resolu.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Gold;
            this.label6.Location = new System.Drawing.Point(23, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 42);
            this.label6.TabIndex = 41;
            this.label6.Text = "Resolus";
            // 
            // lbl_encours
            // 
            this.lbl_encours.AutoSize = true;
            this.lbl_encours.Font = new System.Drawing.Font("Century Gothic", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_encours.ForeColor = System.Drawing.Color.Red;
            this.lbl_encours.Location = new System.Drawing.Point(199, 254);
            this.lbl_encours.Name = "lbl_encours";
            this.lbl_encours.Size = new System.Drawing.Size(37, 42);
            this.lbl_encours.TabIndex = 44;
            this.lbl_encours.Text = "0";
            // 
            // labelxf
            // 
            this.labelxf.AutoSize = true;
            this.labelxf.Font = new System.Drawing.Font("Century Gothic", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelxf.ForeColor = System.Drawing.Color.Red;
            this.labelxf.Location = new System.Drawing.Point(23, 254);
            this.labelxf.Name = "labelxf";
            this.labelxf.Size = new System.Drawing.Size(160, 42);
            this.labelxf.TabIndex = 43;
            this.labelxf.Text = "En cours";
            // 
            // lbl_classed
            // 
            this.lbl_classed.AutoSize = true;
            this.lbl_classed.Font = new System.Drawing.Font("Century Gothic", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_classed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_classed.Location = new System.Drawing.Point(199, 372);
            this.lbl_classed.Name = "lbl_classed";
            this.lbl_classed.Size = new System.Drawing.Size(37, 42);
            this.lbl_classed.TabIndex = 46;
            this.lbl_classed.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label10.Location = new System.Drawing.Point(23, 372);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(141, 42);
            this.label10.TabIndex = 45;
            this.label10.Text = "Classés";
            // 
            // lbl_referes
            // 
            this.lbl_referes.AutoSize = true;
            this.lbl_referes.Font = new System.Drawing.Font("Century Gothic", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_referes.ForeColor = System.Drawing.Color.DarkGray;
            this.lbl_referes.Location = new System.Drawing.Point(183, 493);
            this.lbl_referes.Name = "lbl_referes";
            this.lbl_referes.Size = new System.Drawing.Size(37, 42);
            this.lbl_referes.TabIndex = 48;
            this.lbl_referes.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DarkGray;
            this.label12.Location = new System.Drawing.Point(23, 493);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(144, 42);
            this.label12.TabIndex = 47;
            this.label12.Text = "Referés";
            // 
            // lbl_sensibilisations
            // 
            this.lbl_sensibilisations.AutoSize = true;
            this.lbl_sensibilisations.Font = new System.Drawing.Font("Century Gothic", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sensibilisations.ForeColor = System.Drawing.Color.White;
            this.lbl_sensibilisations.Location = new System.Drawing.Point(307, 577);
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
            this.label7.Location = new System.Drawing.Point(10, 577);
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
            this.lbl_garcons.Location = new System.Drawing.Point(1179, 647);
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
            this.label8.Location = new System.Drawing.Point(1008, 647);
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
            this.lbl_filles.Location = new System.Drawing.Point(864, 647);
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
            this.label11.Location = new System.Drawing.Point(757, 647);
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
            this.lbl_femme.Location = new System.Drawing.Point(574, 647);
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
            this.label14.Location = new System.Drawing.Point(400, 647);
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
            this.lbl_homme.Location = new System.Drawing.Point(244, 647);
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
            this.label16.Location = new System.Drawing.Point(62, 647);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(166, 42);
            this.label16.TabIndex = 51;
            this.label16.Text = "Hommes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Gold;
            this.label5.Location = new System.Drawing.Point(1010, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(165, 42);
            this.label5.TabIndex = 62;
            this.label5.Text = "Garcons";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Gold;
            this.label9.Location = new System.Drawing.Point(759, 195);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 42);
            this.label9.TabIndex = 61;
            this.label9.Text = "Filles";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Gold;
            this.label13.Location = new System.Drawing.Point(402, 195);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(159, 42);
            this.label13.TabIndex = 60;
            this.label13.Text = "Femmes";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.Gold;
            this.label15.Location = new System.Drawing.Point(64, 195);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(166, 42);
            this.label15.TabIndex = 59;
            this.label15.Text = "Hommes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(1010, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 42);
            this.label2.TabIndex = 66;
            this.label2.Text = "Garcons";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(759, 313);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 42);
            this.label3.TabIndex = 65;
            this.label3.Text = "Filles";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Century Gothic", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Red;
            this.label17.Location = new System.Drawing.Point(402, 313);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(159, 42);
            this.label17.TabIndex = 64;
            this.label17.Text = "Femmes";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Century Gothic", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.Red;
            this.label18.Location = new System.Drawing.Point(64, 313);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(166, 42);
            this.label18.TabIndex = 63;
            this.label18.Text = "Hommes";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Century Gothic", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label19.Location = new System.Drawing.Point(1010, 432);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(165, 42);
            this.label19.TabIndex = 70;
            this.label19.Text = "Garcons";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Century Gothic", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label20.Location = new System.Drawing.Point(759, 432);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(91, 42);
            this.label20.TabIndex = 69;
            this.label20.Text = "Filles";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Century Gothic", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label21.Location = new System.Drawing.Point(402, 432);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(159, 42);
            this.label21.TabIndex = 68;
            this.label21.Text = "Femmes";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Century Gothic", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label22.Location = new System.Drawing.Point(64, 432);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(166, 42);
            this.label22.TabIndex = 67;
            this.label22.Text = "Hommes";
            // 
            // lb_hommes_resolus
            // 
            this.lb_hommes_resolus.AutoSize = true;
            this.lb_hommes_resolus.Font = new System.Drawing.Font("Century Gothic", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_hommes_resolus.ForeColor = System.Drawing.Color.Gold;
            this.lb_hommes_resolus.Location = new System.Drawing.Point(236, 195);
            this.lb_hommes_resolus.Name = "lb_hommes_resolus";
            this.lb_hommes_resolus.Size = new System.Drawing.Size(37, 42);
            this.lb_hommes_resolus.TabIndex = 71;
            this.lb_hommes_resolus.Text = "0";
            // 
            // lbl_femmes_resolus
            // 
            this.lbl_femmes_resolus.AutoSize = true;
            this.lbl_femmes_resolus.Font = new System.Drawing.Font("Century Gothic", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_femmes_resolus.ForeColor = System.Drawing.Color.Gold;
            this.lbl_femmes_resolus.Location = new System.Drawing.Point(567, 195);
            this.lbl_femmes_resolus.Name = "lbl_femmes_resolus";
            this.lbl_femmes_resolus.Size = new System.Drawing.Size(37, 42);
            this.lbl_femmes_resolus.TabIndex = 72;
            this.lbl_femmes_resolus.Text = "0";
            // 
            // lbl_filles_resolus
            // 
            this.lbl_filles_resolus.AutoSize = true;
            this.lbl_filles_resolus.Font = new System.Drawing.Font("Century Gothic", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_filles_resolus.ForeColor = System.Drawing.Color.Gold;
            this.lbl_filles_resolus.Location = new System.Drawing.Point(856, 195);
            this.lbl_filles_resolus.Name = "lbl_filles_resolus";
            this.lbl_filles_resolus.Size = new System.Drawing.Size(37, 42);
            this.lbl_filles_resolus.TabIndex = 73;
            this.lbl_filles_resolus.Text = "0";
            // 
            // lblgars_resolus
            // 
            this.lblgars_resolus.AutoSize = true;
            this.lblgars_resolus.Font = new System.Drawing.Font("Century Gothic", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgars_resolus.ForeColor = System.Drawing.Color.Gold;
            this.lblgars_resolus.Location = new System.Drawing.Point(1179, 195);
            this.lblgars_resolus.Name = "lblgars_resolus";
            this.lblgars_resolus.Size = new System.Drawing.Size(37, 42);
            this.lblgars_resolus.TabIndex = 74;
            this.lblgars_resolus.Text = "0";
            // 
            // lbl_hommes_encours
            // 
            this.lbl_hommes_encours.AutoSize = true;
            this.lbl_hommes_encours.Font = new System.Drawing.Font("Century Gothic", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hommes_encours.ForeColor = System.Drawing.Color.Red;
            this.lbl_hommes_encours.Location = new System.Drawing.Point(236, 313);
            this.lbl_hommes_encours.Name = "lbl_hommes_encours";
            this.lbl_hommes_encours.Size = new System.Drawing.Size(37, 42);
            this.lbl_hommes_encours.TabIndex = 75;
            this.lbl_hommes_encours.Text = "0";
            // 
            // lbl_femmes_encours
            // 
            this.lbl_femmes_encours.AutoSize = true;
            this.lbl_femmes_encours.Font = new System.Drawing.Font("Century Gothic", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_femmes_encours.ForeColor = System.Drawing.Color.Red;
            this.lbl_femmes_encours.Location = new System.Drawing.Point(567, 313);
            this.lbl_femmes_encours.Name = "lbl_femmes_encours";
            this.lbl_femmes_encours.Size = new System.Drawing.Size(37, 42);
            this.lbl_femmes_encours.TabIndex = 76;
            this.lbl_femmes_encours.Text = "0";
            // 
            // lbl_filles_encours
            // 
            this.lbl_filles_encours.AutoSize = true;
            this.lbl_filles_encours.Font = new System.Drawing.Font("Century Gothic", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_filles_encours.ForeColor = System.Drawing.Color.Red;
            this.lbl_filles_encours.Location = new System.Drawing.Point(856, 313);
            this.lbl_filles_encours.Name = "lbl_filles_encours";
            this.lbl_filles_encours.Size = new System.Drawing.Size(37, 42);
            this.lbl_filles_encours.TabIndex = 77;
            this.lbl_filles_encours.Text = "0";
            // 
            // lbl_gars_encours
            // 
            this.lbl_gars_encours.AutoSize = true;
            this.lbl_gars_encours.Font = new System.Drawing.Font("Century Gothic", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gars_encours.ForeColor = System.Drawing.Color.Red;
            this.lbl_gars_encours.Location = new System.Drawing.Point(1179, 313);
            this.lbl_gars_encours.Name = "lbl_gars_encours";
            this.lbl_gars_encours.Size = new System.Drawing.Size(37, 42);
            this.lbl_gars_encours.TabIndex = 78;
            this.lbl_gars_encours.Text = "0";
            // 
            // lbl_hommes_classe
            // 
            this.lbl_hommes_classe.AutoSize = true;
            this.lbl_hommes_classe.Font = new System.Drawing.Font("Century Gothic", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hommes_classe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_hommes_classe.Location = new System.Drawing.Point(236, 432);
            this.lbl_hommes_classe.Name = "lbl_hommes_classe";
            this.lbl_hommes_classe.Size = new System.Drawing.Size(37, 42);
            this.lbl_hommes_classe.TabIndex = 79;
            this.lbl_hommes_classe.Text = "0";
            // 
            // lbl_femme_classe
            // 
            this.lbl_femme_classe.AutoSize = true;
            this.lbl_femme_classe.Font = new System.Drawing.Font("Century Gothic", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_femme_classe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_femme_classe.Location = new System.Drawing.Point(574, 432);
            this.lbl_femme_classe.Name = "lbl_femme_classe";
            this.lbl_femme_classe.Size = new System.Drawing.Size(37, 42);
            this.lbl_femme_classe.TabIndex = 80;
            this.lbl_femme_classe.Text = "0";
            // 
            // lbl_filles_classe
            // 
            this.lbl_filles_classe.AutoSize = true;
            this.lbl_filles_classe.Font = new System.Drawing.Font("Century Gothic", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_filles_classe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_filles_classe.Location = new System.Drawing.Point(856, 432);
            this.lbl_filles_classe.Name = "lbl_filles_classe";
            this.lbl_filles_classe.Size = new System.Drawing.Size(37, 42);
            this.lbl_filles_classe.TabIndex = 81;
            this.lbl_filles_classe.Text = "0";
            // 
            // lbl_gars_classe
            // 
            this.lbl_gars_classe.AutoSize = true;
            this.lbl_gars_classe.Font = new System.Drawing.Font("Century Gothic", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gars_classe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_gars_classe.Location = new System.Drawing.Point(1179, 432);
            this.lbl_gars_classe.Name = "lbl_gars_classe";
            this.lbl_gars_classe.Size = new System.Drawing.Size(37, 42);
            this.lbl_gars_classe.TabIndex = 82;
            this.lbl_gars_classe.Text = "0";
            // 
            // frm_evolution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(1300, 714);
            this.Controls.Add(this.lbl_gars_classe);
            this.Controls.Add(this.lbl_filles_classe);
            this.Controls.Add(this.lbl_femme_classe);
            this.Controls.Add(this.lbl_hommes_classe);
            this.Controls.Add(this.lbl_gars_encours);
            this.Controls.Add(this.lbl_filles_encours);
            this.Controls.Add(this.lbl_femmes_encours);
            this.Controls.Add(this.lbl_hommes_encours);
            this.Controls.Add(this.lblgars_resolus);
            this.Controls.Add(this.lbl_filles_resolus);
            this.Controls.Add(this.lbl_femmes_resolus);
            this.Controls.Add(this.lb_hommes_resolus);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label15);
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
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lb_hommes_resolus;
        private System.Windows.Forms.Label lbl_femmes_resolus;
        private System.Windows.Forms.Label lbl_filles_resolus;
        private System.Windows.Forms.Label lblgars_resolus;
        private System.Windows.Forms.Label lbl_hommes_encours;
        private System.Windows.Forms.Label lbl_femmes_encours;
        private System.Windows.Forms.Label lbl_filles_encours;
        private System.Windows.Forms.Label lbl_gars_encours;
        private System.Windows.Forms.Label lbl_hommes_classe;
        private System.Windows.Forms.Label lbl_femme_classe;
        private System.Windows.Forms.Label lbl_filles_classe;
        private System.Windows.Forms.Label lbl_gars_classe;
    }
}