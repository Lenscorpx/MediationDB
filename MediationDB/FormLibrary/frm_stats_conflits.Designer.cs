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
            this.pnl_header = new System.Windows.Forms.Panel();
            this.bunifuGauge1 = new Bunifu.Framework.UI.BunifuGauge();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_search_period = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dt_resol_2 = new MetroFramework.Controls.MetroDateTime();
            this.dt_resol_1 = new MetroFramework.Controls.MetroDateTime();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_localite = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txt_id_localite = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cbx_resolutions = new MetroFramework.Controls.MetroComboBox();
            this.txt_nombre_conflit = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.bunifuGauge2 = new Bunifu.Framework.UI.BunifuGauge();
            this.label6 = new System.Windows.Forms.Label();
            this.bunifuGauge3 = new Bunifu.Framework.UI.BunifuGauge();
            this.label7 = new System.Windows.Forms.Label();
            this.bunifuGauge4 = new Bunifu.Framework.UI.BunifuGauge();
            this.label8 = new System.Windows.Forms.Label();
            this.bunifuGauge5 = new Bunifu.Framework.UI.BunifuGauge();
            this.label9 = new System.Windows.Forms.Label();
            this.bunifuGauge6 = new Bunifu.Framework.UI.BunifuGauge();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txt_conflit_resolus = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_conflits_encours = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_conflits_referes = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_conflits_classes = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.pnl_header.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_header
            // 
            this.pnl_header.Controls.Add(this.bunifuImageButton1);
            this.pnl_header.Controls.Add(this.label1);
            this.pnl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_header.Location = new System.Drawing.Point(0, 0);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.Size = new System.Drawing.Size(1300, 53);
            this.pnl_header.TabIndex = 37;
            // 
            // bunifuGauge1
            // 
            this.bunifuGauge1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGauge1.BackgroundImage")));
            this.bunifuGauge1.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.bunifuGauge1.ForeColor = System.Drawing.Color.White;
            this.bunifuGauge1.Location = new System.Drawing.Point(84, 517);
            this.bunifuGauge1.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuGauge1.Name = "bunifuGauge1";
            this.bunifuGauge1.ProgressBgColor = System.Drawing.Color.White;
            this.bunifuGauge1.ProgressColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.bunifuGauge1.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.bunifuGauge1.Size = new System.Drawing.Size(165, 112);
            this.bunifuGauge1.TabIndex = 39;
            this.bunifuGauge1.Thickness = 30;
            this.bunifuGauge1.Value = 78;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(87, 482);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 30);
            this.label4.TabIndex = 43;
            this.label4.Text = "Total conflits";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.txt_conflits_classes);
            this.panel1.Controls.Add(this.txt_conflits_referes);
            this.panel1.Controls.Add(this.txt_conflits_encours);
            this.panel1.Controls.Add(this.txt_conflit_resolus);
            this.panel1.Controls.Add(this.bunifuFlatButton1);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.bunifuGauge6);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.bunifuGauge5);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.bunifuGauge4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.bunifuGauge3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.bunifuGauge2);
            this.panel1.Controls.Add(this.txt_nombre_conflit);
            this.panel1.Controls.Add(this.cbx_resolutions);
            this.panel1.Controls.Add(this.btn_search_period);
            this.panel1.Controls.Add(this.dt_resol_2);
            this.panel1.Controls.Add(this.dt_resol_1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_localite);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Controls.Add(this.txt_id_localite);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.bunifuGauge1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1300, 661);
            this.panel1.TabIndex = 38;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuImageButton1.Image = global::MediationDB.Properties.Resources.Fermer_window;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(1246, 7);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(46, 40);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuImageButton1.TabIndex = 8;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(472, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 36);
            this.label1.TabIndex = 7;
            this.label1.Text = "Statistiques sur les conflits";
            // 
            // btn_search_period
            // 
            this.btn_search_period.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.btn_search_period.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_search_period.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.btn_search_period.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_search_period.BorderRadius = 0;
            this.btn_search_period.ButtonText = "Rechercher";
            this.btn_search_period.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_search_period.DisabledColor = System.Drawing.Color.Gray;
            this.btn_search_period.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search_period.ForeColor = System.Drawing.Color.White;
            this.btn_search_period.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_search_period.Iconimage = global::MediationDB.Properties.Resources.search_more_96px;
            this.btn_search_period.Iconimage_right = null;
            this.btn_search_period.Iconimage_right_Selected = null;
            this.btn_search_period.Iconimage_Selected = null;
            this.btn_search_period.IconMarginLeft = 0;
            this.btn_search_period.IconMarginRight = 0;
            this.btn_search_period.IconRightVisible = true;
            this.btn_search_period.IconRightZoom = 0D;
            this.btn_search_period.IconVisible = true;
            this.btn_search_period.IconZoom = 80D;
            this.btn_search_period.IsTab = true;
            this.btn_search_period.Location = new System.Drawing.Point(1137, 56);
            this.btn_search_period.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btn_search_period.Name = "btn_search_period";
            this.btn_search_period.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.btn_search_period.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_search_period.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_search_period.selected = false;
            this.btn_search_period.Size = new System.Drawing.Size(141, 40);
            this.btn_search_period.TabIndex = 83;
            this.btn_search_period.Text = "Rechercher";
            this.btn_search_period.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_search_period.Textcolor = System.Drawing.Color.White;
            this.btn_search_period.TextFont = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // dt_resol_2
            // 
            this.dt_resol_2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dt_resol_2.Location = new System.Drawing.Point(949, 61);
            this.dt_resol_2.MinimumSize = new System.Drawing.Size(0, 29);
            this.dt_resol_2.Name = "dt_resol_2";
            this.dt_resol_2.Size = new System.Drawing.Size(180, 29);
            this.dt_resol_2.Style = MetroFramework.MetroColorStyle.Blue;
            this.dt_resol_2.TabIndex = 82;
            this.dt_resol_2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // dt_resol_1
            // 
            this.dt_resol_1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dt_resol_1.Location = new System.Drawing.Point(763, 61);
            this.dt_resol_1.MinimumSize = new System.Drawing.Size(0, 29);
            this.dt_resol_1.Name = "dt_resol_1";
            this.dt_resol_1.Size = new System.Drawing.Size(180, 29);
            this.dt_resol_1.Style = MetroFramework.MetroColorStyle.Blue;
            this.dt_resol_1.TabIndex = 81;
            this.dt_resol_1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(874, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(188, 17);
            this.label3.TabIndex = 80;
            this.label3.Text = "Recherche entre deux dates";
            // 
            // txt_localite
            // 
            this.txt_localite.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_localite.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_localite.Enabled = false;
            this.txt_localite.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_localite.ForeColor = System.Drawing.Color.White;
            this.txt_localite.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_localite.HintText = "Localite ou se trouve le conflit";
            this.txt_localite.isPassword = false;
            this.txt_localite.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.txt_localite.LineIdleColor = System.Drawing.Color.White;
            this.txt_localite.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.txt_localite.LineThickness = 4;
            this.txt_localite.Location = new System.Drawing.Point(256, 7);
            this.txt_localite.Margin = new System.Windows.Forms.Padding(4);
            this.txt_localite.Name = "txt_localite";
            this.txt_localite.Size = new System.Drawing.Size(296, 44);
            this.txt_localite.TabIndex = 78;
            this.txt_localite.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 17;
            this.listBox1.Location = new System.Drawing.Point(5, 52);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(243, 187);
            this.listBox1.TabIndex = 76;
            // 
            // txt_id_localite
            // 
            this.txt_id_localite.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_id_localite.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_id_localite.ForeColor = System.Drawing.Color.White;
            this.txt_id_localite.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_id_localite.HintText = "Recherchez une localité";
            this.txt_id_localite.isPassword = false;
            this.txt_id_localite.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.txt_id_localite.LineIdleColor = System.Drawing.Color.White;
            this.txt_id_localite.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.txt_id_localite.LineThickness = 4;
            this.txt_id_localite.Location = new System.Drawing.Point(5, 6);
            this.txt_id_localite.Margin = new System.Windows.Forms.Padding(4);
            this.txt_id_localite.Name = "txt_id_localite";
            this.txt_id_localite.Size = new System.Drawing.Size(243, 44);
            this.txt_id_localite.TabIndex = 77;
            this.txt_id_localite.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cbx_resolutions
            // 
            this.cbx_resolutions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.cbx_resolutions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbx_resolutions.ForeColor = System.Drawing.Color.White;
            this.cbx_resolutions.FormattingEnabled = true;
            this.cbx_resolutions.ItemHeight = 23;
            this.cbx_resolutions.Location = new System.Drawing.Point(256, 66);
            this.cbx_resolutions.Name = "cbx_resolutions";
            this.cbx_resolutions.PromptText = "Completez la résolution pour ce conflit";
            this.cbx_resolutions.Size = new System.Drawing.Size(296, 29);
            this.cbx_resolutions.Style = MetroFramework.MetroColorStyle.Blue;
            this.cbx_resolutions.TabIndex = 119;
            this.cbx_resolutions.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbx_resolutions.UseSelectable = true;
            // 
            // txt_nombre_conflit
            // 
            this.txt_nombre_conflit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_nombre_conflit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_nombre_conflit.Enabled = false;
            this.txt_nombre_conflit.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_nombre_conflit.ForeColor = System.Drawing.Color.White;
            this.txt_nombre_conflit.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_nombre_conflit.HintText = "Total conflits";
            this.txt_nombre_conflit.isPassword = false;
            this.txt_nombre_conflit.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.txt_nombre_conflit.LineIdleColor = System.Drawing.Color.White;
            this.txt_nombre_conflit.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.txt_nombre_conflit.LineThickness = 4;
            this.txt_nombre_conflit.Location = new System.Drawing.Point(281, 129);
            this.txt_nombre_conflit.Margin = new System.Windows.Forms.Padding(4);
            this.txt_nombre_conflit.Name = "txt_nombre_conflit";
            this.txt_nombre_conflit.Size = new System.Drawing.Size(224, 44);
            this.txt_nombre_conflit.TabIndex = 120;
            this.txt_nombre_conflit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(284, 482);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 30);
            this.label5.TabIndex = 123;
            this.label5.Text = "Total conflits";
            // 
            // bunifuGauge2
            // 
            this.bunifuGauge2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGauge2.BackgroundImage")));
            this.bunifuGauge2.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.bunifuGauge2.ForeColor = System.Drawing.Color.White;
            this.bunifuGauge2.Location = new System.Drawing.Point(281, 517);
            this.bunifuGauge2.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuGauge2.Name = "bunifuGauge2";
            this.bunifuGauge2.ProgressBgColor = System.Drawing.Color.White;
            this.bunifuGauge2.ProgressColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.bunifuGauge2.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.bunifuGauge2.Size = new System.Drawing.Size(165, 112);
            this.bunifuGauge2.TabIndex = 122;
            this.bunifuGauge2.Thickness = 30;
            this.bunifuGauge2.Value = 78;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(481, 482);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 30);
            this.label6.TabIndex = 125;
            this.label6.Text = "Total conflits";
            // 
            // bunifuGauge3
            // 
            this.bunifuGauge3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGauge3.BackgroundImage")));
            this.bunifuGauge3.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.bunifuGauge3.ForeColor = System.Drawing.Color.White;
            this.bunifuGauge3.Location = new System.Drawing.Point(478, 517);
            this.bunifuGauge3.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuGauge3.Name = "bunifuGauge3";
            this.bunifuGauge3.ProgressBgColor = System.Drawing.Color.White;
            this.bunifuGauge3.ProgressColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.bunifuGauge3.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.bunifuGauge3.Size = new System.Drawing.Size(165, 112);
            this.bunifuGauge3.TabIndex = 124;
            this.bunifuGauge3.Thickness = 30;
            this.bunifuGauge3.Value = 78;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(679, 482);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 30);
            this.label7.TabIndex = 127;
            this.label7.Text = "Total conflits";
            // 
            // bunifuGauge4
            // 
            this.bunifuGauge4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGauge4.BackgroundImage")));
            this.bunifuGauge4.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.bunifuGauge4.ForeColor = System.Drawing.Color.White;
            this.bunifuGauge4.Location = new System.Drawing.Point(676, 517);
            this.bunifuGauge4.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuGauge4.Name = "bunifuGauge4";
            this.bunifuGauge4.ProgressBgColor = System.Drawing.Color.White;
            this.bunifuGauge4.ProgressColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.bunifuGauge4.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.bunifuGauge4.Size = new System.Drawing.Size(165, 112);
            this.bunifuGauge4.TabIndex = 126;
            this.bunifuGauge4.Thickness = 30;
            this.bunifuGauge4.Value = 78;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(867, 482);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(162, 30);
            this.label8.TabIndex = 129;
            this.label8.Text = "Total conflits";
            // 
            // bunifuGauge5
            // 
            this.bunifuGauge5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGauge5.BackgroundImage")));
            this.bunifuGauge5.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.bunifuGauge5.ForeColor = System.Drawing.Color.White;
            this.bunifuGauge5.Location = new System.Drawing.Point(864, 517);
            this.bunifuGauge5.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuGauge5.Name = "bunifuGauge5";
            this.bunifuGauge5.ProgressBgColor = System.Drawing.Color.White;
            this.bunifuGauge5.ProgressColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.bunifuGauge5.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.bunifuGauge5.Size = new System.Drawing.Size(165, 112);
            this.bunifuGauge5.TabIndex = 128;
            this.bunifuGauge5.Thickness = 30;
            this.bunifuGauge5.Value = 78;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(1053, 482);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(162, 30);
            this.label9.TabIndex = 131;
            this.label9.Text = "Total conflits";
            // 
            // bunifuGauge6
            // 
            this.bunifuGauge6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGauge6.BackgroundImage")));
            this.bunifuGauge6.Font = new System.Drawing.Font("Century Gothic", 10F);
            this.bunifuGauge6.ForeColor = System.Drawing.Color.White;
            this.bunifuGauge6.Location = new System.Drawing.Point(1050, 517);
            this.bunifuGauge6.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuGauge6.Name = "bunifuGauge6";
            this.bunifuGauge6.ProgressBgColor = System.Drawing.Color.White;
            this.bunifuGauge6.ProgressColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.bunifuGauge6.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.bunifuGauge6.Size = new System.Drawing.Size(165, 112);
            this.bunifuGauge6.TabIndex = 130;
            this.bunifuGauge6.Thickness = 30;
            this.bunifuGauge6.Value = 78;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(797, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 17);
            this.label10.TabIndex = 132;
            this.label10.Text = "Date de debut";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(984, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(80, 17);
            this.label11.TabIndex = 133;
            this.label11.Text = "Date de fin";
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.bunifuFlatButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Rechercher";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = global::MediationDB.Properties.Resources.search_more_96px;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 80D;
            this.bunifuFlatButton1.IsTab = true;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(560, 61);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(141, 40);
            this.bunifuFlatButton1.TabIndex = 134;
            this.bunifuFlatButton1.Text = "Rechercher";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txt_conflit_resolus
            // 
            this.txt_conflit_resolus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_conflit_resolus.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_conflit_resolus.Enabled = false;
            this.txt_conflit_resolus.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_conflit_resolus.ForeColor = System.Drawing.Color.White;
            this.txt_conflit_resolus.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_conflit_resolus.HintText = "Conflits resolus";
            this.txt_conflit_resolus.isPassword = false;
            this.txt_conflit_resolus.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.txt_conflit_resolus.LineIdleColor = System.Drawing.Color.White;
            this.txt_conflit_resolus.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.txt_conflit_resolus.LineThickness = 4;
            this.txt_conflit_resolus.Location = new System.Drawing.Point(281, 200);
            this.txt_conflit_resolus.Margin = new System.Windows.Forms.Padding(4);
            this.txt_conflit_resolus.Name = "txt_conflit_resolus";
            this.txt_conflit_resolus.Size = new System.Drawing.Size(224, 44);
            this.txt_conflit_resolus.TabIndex = 135;
            this.txt_conflit_resolus.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_conflits_encours
            // 
            this.txt_conflits_encours.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_conflits_encours.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_conflits_encours.Enabled = false;
            this.txt_conflits_encours.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_conflits_encours.ForeColor = System.Drawing.Color.White;
            this.txt_conflits_encours.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_conflits_encours.HintText = "Conflits en cours";
            this.txt_conflits_encours.isPassword = false;
            this.txt_conflits_encours.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.txt_conflits_encours.LineIdleColor = System.Drawing.Color.White;
            this.txt_conflits_encours.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.txt_conflits_encours.LineThickness = 4;
            this.txt_conflits_encours.Location = new System.Drawing.Point(281, 271);
            this.txt_conflits_encours.Margin = new System.Windows.Forms.Padding(4);
            this.txt_conflits_encours.Name = "txt_conflits_encours";
            this.txt_conflits_encours.Size = new System.Drawing.Size(224, 44);
            this.txt_conflits_encours.TabIndex = 136;
            this.txt_conflits_encours.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_conflits_referes
            // 
            this.txt_conflits_referes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_conflits_referes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_conflits_referes.Enabled = false;
            this.txt_conflits_referes.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_conflits_referes.ForeColor = System.Drawing.Color.White;
            this.txt_conflits_referes.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_conflits_referes.HintText = "Conflits reférés";
            this.txt_conflits_referes.isPassword = false;
            this.txt_conflits_referes.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.txt_conflits_referes.LineIdleColor = System.Drawing.Color.White;
            this.txt_conflits_referes.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.txt_conflits_referes.LineThickness = 4;
            this.txt_conflits_referes.Location = new System.Drawing.Point(281, 342);
            this.txt_conflits_referes.Margin = new System.Windows.Forms.Padding(4);
            this.txt_conflits_referes.Name = "txt_conflits_referes";
            this.txt_conflits_referes.Size = new System.Drawing.Size(224, 44);
            this.txt_conflits_referes.TabIndex = 137;
            this.txt_conflits_referes.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_conflits_classes
            // 
            this.txt_conflits_classes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_conflits_classes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_conflits_classes.Enabled = false;
            this.txt_conflits_classes.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_conflits_classes.ForeColor = System.Drawing.Color.White;
            this.txt_conflits_classes.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_conflits_classes.HintText = "Conflits classés";
            this.txt_conflits_classes.isPassword = false;
            this.txt_conflits_classes.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.txt_conflits_classes.LineIdleColor = System.Drawing.Color.White;
            this.txt_conflits_classes.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.txt_conflits_classes.LineThickness = 4;
            this.txt_conflits_classes.Location = new System.Drawing.Point(281, 413);
            this.txt_conflits_classes.Margin = new System.Windows.Forms.Padding(4);
            this.txt_conflits_classes.Name = "txt_conflits_classes";
            this.txt_conflits_classes.Size = new System.Drawing.Size(224, 44);
            this.txt_conflits_classes.TabIndex = 138;
            this.txt_conflits_classes.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(255, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 19);
            this.label2.TabIndex = 41;
            this.label2.Text = "Total conflits";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(255, 177);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 19);
            this.label12.TabIndex = 139;
            this.label12.Text = "Conflits résolus";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(255, 248);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(120, 19);
            this.label13.TabIndex = 140;
            this.label13.Text = "Conflits en cours";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(255, 319);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(120, 19);
            this.label14.TabIndex = 141;
            this.label14.Text = "Conflits en cours";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(255, 390);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(108, 19);
            this.label15.TabIndex = 142;
            this.label15.Text = "Conflits classés";
            // 
            // frm_stats_conflits
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(1300, 714);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_header);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_stats_conflits";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnl_header.ResumeLayout(false);
            this.pnl_header.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnl_header;
        private Bunifu.Framework.UI.BunifuGauge bunifuGauge1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_search_period;
        private MetroFramework.Controls.MetroDateTime dt_resol_2;
        private MetroFramework.Controls.MetroDateTime dt_resol_1;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_localite;
        private System.Windows.Forms.ListBox listBox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_id_localite;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private Bunifu.Framework.UI.BunifuGauge bunifuGauge6;
        private System.Windows.Forms.Label label8;
        private Bunifu.Framework.UI.BunifuGauge bunifuGauge5;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuGauge bunifuGauge4;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuGauge bunifuGauge3;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuGauge bunifuGauge2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_nombre_conflit;
        private MetroFramework.Controls.MetroComboBox cbx_resolutions;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_conflits_classes;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_conflits_referes;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_conflits_encours;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_conflit_resolus;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
    }
}