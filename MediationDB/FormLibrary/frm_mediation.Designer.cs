﻿namespace MediationDB.FormLibrary
{
    partial class frm_mediation
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.txt_num_conflit = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.dt_debut_mediation = new MetroFramework.Controls.MetroDateTime();
            this.cbx_mediateur = new MetroFramework.Controls.MetroComboBox();
            this.txt_localite = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_num_mediation = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txt_id_localite = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_noms_mediateur = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_appreciation = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dt_fin_mediation = new MetroFramework.Controls.MetroDateTime();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuCustomDataGrid2 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btn_supprimer = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_enregistrer = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid2)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(1247, 49);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(382, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Formulaire de mediation";
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuImageButton1.Image = global::MediationDB.Properties.Resources.multiply_96px;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(1196, 8);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(42, 34);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 7;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // txt_num_conflit
            // 
            this.txt_num_conflit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_num_conflit.Enabled = false;
            this.txt_num_conflit.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_num_conflit.ForeColor = System.Drawing.Color.White;
            this.txt_num_conflit.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_num_conflit.HintText = "Num. cnft";
            this.txt_num_conflit.isPassword = false;
            this.txt_num_conflit.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.txt_num_conflit.LineIdleColor = System.Drawing.Color.White;
            this.txt_num_conflit.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.txt_num_conflit.LineThickness = 1;
            this.txt_num_conflit.Location = new System.Drawing.Point(626, 56);
            this.txt_num_conflit.Margin = new System.Windows.Forms.Padding(4);
            this.txt_num_conflit.Name = "txt_num_conflit";
            this.txt_num_conflit.Size = new System.Drawing.Size(293, 44);
            this.txt_num_conflit.TabIndex = 47;
            this.txt_num_conflit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // dt_debut_mediation
            // 
            this.dt_debut_mediation.Location = new System.Drawing.Point(352, 218);
            this.dt_debut_mediation.MinimumSize = new System.Drawing.Size(0, 29);
            this.dt_debut_mediation.Name = "dt_debut_mediation";
            this.dt_debut_mediation.Size = new System.Drawing.Size(251, 29);
            this.dt_debut_mediation.Style = MetroFramework.MetroColorStyle.Blue;
            this.dt_debut_mediation.TabIndex = 46;
            this.dt_debut_mediation.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // cbx_mediateur
            // 
            this.cbx_mediateur.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.cbx_mediateur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbx_mediateur.ForeColor = System.Drawing.Color.White;
            this.cbx_mediateur.FormattingEnabled = true;
            this.cbx_mediateur.ItemHeight = 23;
            this.cbx_mediateur.Location = new System.Drawing.Point(225, 117);
            this.cbx_mediateur.Name = "cbx_mediateur";
            this.cbx_mediateur.PromptText = "Choisissez le partenaire de mediation";
            this.cbx_mediateur.Size = new System.Drawing.Size(319, 29);
            this.cbx_mediateur.Style = MetroFramework.MetroColorStyle.Blue;
            this.cbx_mediateur.TabIndex = 45;
            this.cbx_mediateur.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbx_mediateur.UseSelectable = true;
            // 
            // txt_localite
            // 
            this.txt_localite.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_localite.Enabled = false;
            this.txt_localite.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_localite.ForeColor = System.Drawing.Color.White;
            this.txt_localite.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_localite.HintText = "Localite ou se passe la mediation";
            this.txt_localite.isPassword = false;
            this.txt_localite.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.txt_localite.LineIdleColor = System.Drawing.Color.White;
            this.txt_localite.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.txt_localite.LineThickness = 1;
            this.txt_localite.Location = new System.Drawing.Point(225, 56);
            this.txt_localite.Margin = new System.Windows.Forms.Padding(4);
            this.txt_localite.Name = "txt_localite";
            this.txt_localite.Size = new System.Drawing.Size(378, 44);
            this.txt_localite.TabIndex = 44;
            this.txt_localite.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_num_mediation
            // 
            this.txt_num_mediation.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_num_mediation.Enabled = false;
            this.txt_num_mediation.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_num_mediation.ForeColor = System.Drawing.Color.White;
            this.txt_num_mediation.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_num_mediation.HintText = "Num. Mediation";
            this.txt_num_mediation.isPassword = false;
            this.txt_num_mediation.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.txt_num_mediation.LineIdleColor = System.Drawing.Color.White;
            this.txt_num_mediation.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.txt_num_mediation.LineThickness = 1;
            this.txt_num_mediation.Location = new System.Drawing.Point(927, 56);
            this.txt_num_mediation.Margin = new System.Windows.Forms.Padding(4);
            this.txt_num_mediation.Name = "txt_num_mediation";
            this.txt_num_mediation.Size = new System.Drawing.Size(307, 44);
            this.txt_num_mediation.TabIndex = 48;
            this.txt_num_mediation.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.ForeColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 17;
            this.listBox1.Location = new System.Drawing.Point(0, 107);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(217, 187);
            this.listBox1.TabIndex = 49;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // txt_id_localite
            // 
            this.txt_id_localite.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_id_localite.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_id_localite.ForeColor = System.Drawing.Color.White;
            this.txt_id_localite.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_id_localite.HintText = "Recherchez une localité";
            this.txt_id_localite.isPassword = false;
            this.txt_id_localite.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.txt_id_localite.LineIdleColor = System.Drawing.Color.White;
            this.txt_id_localite.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.txt_id_localite.LineThickness = 1;
            this.txt_id_localite.Location = new System.Drawing.Point(0, 56);
            this.txt_id_localite.Margin = new System.Windows.Forms.Padding(4);
            this.txt_id_localite.Name = "txt_id_localite";
            this.txt_id_localite.Size = new System.Drawing.Size(217, 44);
            this.txt_id_localite.TabIndex = 50;
            this.txt_id_localite.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_id_localite.OnValueChanged += new System.EventHandler(this.txt_id_localite_OnValueChanged);
            // 
            // txt_noms_mediateur
            // 
            this.txt_noms_mediateur.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_noms_mediateur.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_noms_mediateur.ForeColor = System.Drawing.Color.White;
            this.txt_noms_mediateur.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_noms_mediateur.HintText = "Completez le nom du responsable de mediation";
            this.txt_noms_mediateur.isPassword = false;
            this.txt_noms_mediateur.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.txt_noms_mediateur.LineIdleColor = System.Drawing.Color.White;
            this.txt_noms_mediateur.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.txt_noms_mediateur.LineThickness = 1;
            this.txt_noms_mediateur.Location = new System.Drawing.Point(626, 102);
            this.txt_noms_mediateur.Margin = new System.Windows.Forms.Padding(4);
            this.txt_noms_mediateur.Name = "txt_noms_mediateur";
            this.txt_noms_mediateur.Size = new System.Drawing.Size(608, 44);
            this.txt_noms_mediateur.TabIndex = 51;
            this.txt_noms_mediateur.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_appreciation
            // 
            this.txt_appreciation.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_appreciation.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_appreciation.ForeColor = System.Drawing.Color.White;
            this.txt_appreciation.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_appreciation.HintText = "Completez votre commentaire ici!";
            this.txt_appreciation.isPassword = false;
            this.txt_appreciation.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.txt_appreciation.LineIdleColor = System.Drawing.Color.White;
            this.txt_appreciation.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.txt_appreciation.LineThickness = 1;
            this.txt_appreciation.Location = new System.Drawing.Point(224, 153);
            this.txt_appreciation.Margin = new System.Windows.Forms.Padding(4);
            this.txt_appreciation.Name = "txt_appreciation";
            this.txt_appreciation.Size = new System.Drawing.Size(1010, 44);
            this.txt_appreciation.TabIndex = 52;
            this.txt_appreciation.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(227, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 53;
            this.label2.Text = "Debut mediation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(227, 265);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 17);
            this.label3.TabIndex = 55;
            this.label3.Text = "Fin mediation";
            // 
            // dt_fin_mediation
            // 
            this.dt_fin_mediation.Location = new System.Drawing.Point(352, 257);
            this.dt_fin_mediation.MinimumSize = new System.Drawing.Size(0, 29);
            this.dt_fin_mediation.Name = "dt_fin_mediation";
            this.dt_fin_mediation.Size = new System.Drawing.Size(251, 29);
            this.dt_fin_mediation.Style = MetroFramework.MetroColorStyle.Blue;
            this.dt_fin_mediation.TabIndex = 54;
            this.dt_fin_mediation.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panel1;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuCustomDataGrid2
            // 
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.bunifuCustomDataGrid2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bunifuCustomDataGrid2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.bunifuCustomDataGrid2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuCustomDataGrid2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.bunifuCustomDataGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid2.ColumnHeadersVisible = false;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid2.DefaultCellStyle = dataGridViewCellStyle13;
            this.bunifuCustomDataGrid2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunifuCustomDataGrid2.DoubleBuffered = true;
            this.bunifuCustomDataGrid2.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuCustomDataGrid2.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuCustomDataGrid2.HeaderForeColor = System.Drawing.Color.White;
            this.bunifuCustomDataGrid2.Location = new System.Drawing.Point(0, 324);
            this.bunifuCustomDataGrid2.Name = "bunifuCustomDataGrid2";
            this.bunifuCustomDataGrid2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid2.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid2.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.bunifuCustomDataGrid2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bunifuCustomDataGrid2.Size = new System.Drawing.Size(1247, 306);
            this.bunifuCustomDataGrid2.TabIndex = 75;
            this.bunifuCustomDataGrid2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuCustomDataGrid2_CellContentClick);
            // 
            // btn_supprimer
            // 
            this.btn_supprimer.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.btn_supprimer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_supprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.btn_supprimer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_supprimer.BorderRadius = 0;
            this.btn_supprimer.ButtonText = "Supprimer";
            this.btn_supprimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_supprimer.DisabledColor = System.Drawing.Color.Gray;
            this.btn_supprimer.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_supprimer.ForeColor = System.Drawing.Color.White;
            this.btn_supprimer.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_supprimer.Iconimage = global::MediationDB.Properties.Resources.add_trash_96px;
            this.btn_supprimer.Iconimage_right = null;
            this.btn_supprimer.Iconimage_right_Selected = null;
            this.btn_supprimer.Iconimage_Selected = null;
            this.btn_supprimer.IconMarginLeft = 0;
            this.btn_supprimer.IconMarginRight = 0;
            this.btn_supprimer.IconRightVisible = true;
            this.btn_supprimer.IconRightZoom = 0D;
            this.btn_supprimer.IconVisible = true;
            this.btn_supprimer.IconZoom = 50D;
            this.btn_supprimer.IsTab = true;
            this.btn_supprimer.Location = new System.Drawing.Point(1069, 218);
            this.btn_supprimer.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btn_supprimer.Name = "btn_supprimer";
            this.btn_supprimer.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.btn_supprimer.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_supprimer.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_supprimer.selected = false;
            this.btn_supprimer.Size = new System.Drawing.Size(169, 40);
            this.btn_supprimer.TabIndex = 89;
            this.btn_supprimer.Text = "Supprimer";
            this.btn_supprimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_supprimer.Textcolor = System.Drawing.Color.White;
            this.btn_supprimer.TextFont = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_supprimer.Click += new System.EventHandler(this.btn_supprimer_Click_1);
            // 
            // btn_enregistrer
            // 
            this.btn_enregistrer.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.btn_enregistrer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_enregistrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.btn_enregistrer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_enregistrer.BorderRadius = 0;
            this.btn_enregistrer.ButtonText = "Enregistrer";
            this.btn_enregistrer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_enregistrer.DisabledColor = System.Drawing.Color.Gray;
            this.btn_enregistrer.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enregistrer.ForeColor = System.Drawing.Color.White;
            this.btn_enregistrer.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_enregistrer.Iconimage = global::MediationDB.Properties.Resources.add_96px;
            this.btn_enregistrer.Iconimage_right = null;
            this.btn_enregistrer.Iconimage_right_Selected = null;
            this.btn_enregistrer.Iconimage_Selected = null;
            this.btn_enregistrer.IconMarginLeft = 0;
            this.btn_enregistrer.IconMarginRight = 0;
            this.btn_enregistrer.IconRightVisible = true;
            this.btn_enregistrer.IconRightZoom = 0D;
            this.btn_enregistrer.IconVisible = true;
            this.btn_enregistrer.IconZoom = 50D;
            this.btn_enregistrer.IsTab = true;
            this.btn_enregistrer.Location = new System.Drawing.Point(890, 218);
            this.btn_enregistrer.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btn_enregistrer.Name = "btn_enregistrer";
            this.btn_enregistrer.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.btn_enregistrer.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_enregistrer.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_enregistrer.selected = false;
            this.btn_enregistrer.Size = new System.Drawing.Size(169, 40);
            this.btn_enregistrer.TabIndex = 88;
            this.btn_enregistrer.Text = "Enregistrer";
            this.btn_enregistrer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_enregistrer.Textcolor = System.Drawing.Color.White;
            this.btn_enregistrer.TextFont = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enregistrer.Click += new System.EventHandler(this.btn_enregistrer_Click_1);
            // 
            // frm_mediation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(1247, 630);
            this.ControlBox = false;
            this.Controls.Add(this.btn_supprimer);
            this.Controls.Add(this.btn_enregistrer);
            this.Controls.Add(this.bunifuCustomDataGrid2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dt_fin_mediation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_appreciation);
            this.Controls.Add(this.txt_noms_mediateur);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txt_id_localite);
            this.Controls.Add(this.txt_num_mediation);
            this.Controls.Add(this.txt_num_conflit);
            this.Controls.Add(this.dt_debut_mediation);
            this.Controls.Add(this.cbx_mediateur);
            this.Controls.Add(this.txt_localite);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_mediation";
            this.Opacity = 0.9D;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_mediation";
            this.Load += new System.EventHandler(this.frm_mediation_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private MetroFramework.Controls.MetroDateTime dt_debut_mediation;
        private MetroFramework.Controls.MetroComboBox cbx_mediateur;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_localite;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_num_mediation;
        private System.Windows.Forms.ListBox listBox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_id_localite;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_noms_mediateur;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_appreciation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroDateTime dt_fin_mediation;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txt_num_conflit;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid2;
        private Bunifu.Framework.UI.BunifuFlatButton btn_supprimer;
        private Bunifu.Framework.UI.BunifuFlatButton btn_enregistrer;
    }
}