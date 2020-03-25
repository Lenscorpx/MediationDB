namespace MediationDB.FormLibrary
{
    partial class frm_bailleurs
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomDataGrid2 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.txt_telephone = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_adresse = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbx_vulnerabilite = new MetroFramework.Controls.MetroComboBox();
            this.dt_date_distribution = new MetroFramework.Controls.MetroDateTime();
            this.cbx_sexe = new MetroFramework.Controls.MetroComboBox();
            this.txt_noms = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_id_bailleurs = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btn_supprimer = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_enregistrer = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.bunifuImageButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1300, 49);
            this.panel1.TabIndex = 35;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MediationDB.Properties.Resources.UNHABITAT_svg;
            this.pictureBox1.Location = new System.Drawing.Point(7, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 147;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(428, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(454, 30);
            this.label1.TabIndex = 8;
            this.label1.Text = "Informations sur les bailleurs de fonds";
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuImageButton1.Image = global::MediationDB.Properties.Resources.multiply_96px;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(1250, 7);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(42, 34);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 7;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
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
            this.bunifuCustomDataGrid2.Location = new System.Drawing.Point(0, 218);
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
            this.bunifuCustomDataGrid2.Size = new System.Drawing.Size(1300, 496);
            this.bunifuCustomDataGrid2.TabIndex = 102;
            // 
            // txt_telephone
            // 
            this.txt_telephone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_telephone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_telephone.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_telephone.ForeColor = System.Drawing.Color.White;
            this.txt_telephone.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_telephone.HintText = "Numero de telephone";
            this.txt_telephone.isPassword = false;
            this.txt_telephone.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.txt_telephone.LineIdleColor = System.Drawing.Color.White;
            this.txt_telephone.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.txt_telephone.LineThickness = 4;
            this.txt_telephone.Location = new System.Drawing.Point(882, 109);
            this.txt_telephone.Margin = new System.Windows.Forms.Padding(4);
            this.txt_telephone.Name = "txt_telephone";
            this.txt_telephone.Size = new System.Drawing.Size(373, 44);
            this.txt_telephone.TabIndex = 101;
            this.txt_telephone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_adresse
            // 
            this.txt_adresse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_adresse.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_adresse.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_adresse.ForeColor = System.Drawing.Color.White;
            this.txt_adresse.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_adresse.HintText = "Completez l\'adresse ici!";
            this.txt_adresse.isPassword = false;
            this.txt_adresse.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.txt_adresse.LineIdleColor = System.Drawing.Color.White;
            this.txt_adresse.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.txt_adresse.LineThickness = 4;
            this.txt_adresse.Location = new System.Drawing.Point(405, 109);
            this.txt_adresse.Margin = new System.Windows.Forms.Padding(4);
            this.txt_adresse.Name = "txt_adresse";
            this.txt_adresse.Size = new System.Drawing.Size(444, 44);
            this.txt_adresse.TabIndex = 100;
            this.txt_adresse.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(878, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 19);
            this.label3.TabIndex = 99;
            this.label3.Text = "Date de naissance";
            // 
            // cbx_vulnerabilite
            // 
            this.cbx_vulnerabilite.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbx_vulnerabilite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.cbx_vulnerabilite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbx_vulnerabilite.ForeColor = System.Drawing.Color.White;
            this.cbx_vulnerabilite.FormattingEnabled = true;
            this.cbx_vulnerabilite.ItemHeight = 23;
            this.cbx_vulnerabilite.Location = new System.Drawing.Point(609, 72);
            this.cbx_vulnerabilite.Name = "cbx_vulnerabilite";
            this.cbx_vulnerabilite.PromptText = "Vulnerabilite";
            this.cbx_vulnerabilite.Size = new System.Drawing.Size(254, 29);
            this.cbx_vulnerabilite.Style = MetroFramework.MetroColorStyle.Blue;
            this.cbx_vulnerabilite.TabIndex = 98;
            this.cbx_vulnerabilite.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbx_vulnerabilite.UseSelectable = true;
            // 
            // dt_date_distribution
            // 
            this.dt_date_distribution.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dt_date_distribution.Location = new System.Drawing.Point(1023, 67);
            this.dt_date_distribution.MinimumSize = new System.Drawing.Size(0, 29);
            this.dt_date_distribution.Name = "dt_date_distribution";
            this.dt_date_distribution.Size = new System.Drawing.Size(232, 29);
            this.dt_date_distribution.Style = MetroFramework.MetroColorStyle.Blue;
            this.dt_date_distribution.TabIndex = 95;
            this.dt_date_distribution.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // cbx_sexe
            // 
            this.cbx_sexe.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbx_sexe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.cbx_sexe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbx_sexe.ForeColor = System.Drawing.Color.White;
            this.cbx_sexe.FormattingEnabled = true;
            this.cbx_sexe.ItemHeight = 23;
            this.cbx_sexe.Items.AddRange(new object[] {
            "Feminin",
            "Masculin"});
            this.cbx_sexe.Location = new System.Drawing.Point(405, 72);
            this.cbx_sexe.Name = "cbx_sexe";
            this.cbx_sexe.PromptText = "Choisissez le genre ici";
            this.cbx_sexe.Size = new System.Drawing.Size(198, 29);
            this.cbx_sexe.Style = MetroFramework.MetroColorStyle.Blue;
            this.cbx_sexe.TabIndex = 94;
            this.cbx_sexe.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbx_sexe.UseSelectable = true;
            // 
            // txt_noms
            // 
            this.txt_noms.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_noms.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_noms.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_noms.ForeColor = System.Drawing.Color.White;
            this.txt_noms.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_noms.HintText = "Nom ou raison sociale du bailleur";
            this.txt_noms.isPassword = false;
            this.txt_noms.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.txt_noms.LineIdleColor = System.Drawing.Color.White;
            this.txt_noms.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.txt_noms.LineThickness = 4;
            this.txt_noms.Location = new System.Drawing.Point(26, 109);
            this.txt_noms.Margin = new System.Windows.Forms.Padding(4);
            this.txt_noms.Name = "txt_noms";
            this.txt_noms.Size = new System.Drawing.Size(359, 44);
            this.txt_noms.TabIndex = 93;
            this.txt_noms.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_id_bailleurs
            // 
            this.txt_id_bailleurs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_id_bailleurs.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_id_bailleurs.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_id_bailleurs.ForeColor = System.Drawing.Color.White;
            this.txt_id_bailleurs.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_id_bailleurs.HintText = "ID du bailleur";
            this.txt_id_bailleurs.isPassword = false;
            this.txt_id_bailleurs.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.txt_id_bailleurs.LineIdleColor = System.Drawing.Color.White;
            this.txt_id_bailleurs.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.txt_id_bailleurs.LineThickness = 4;
            this.txt_id_bailleurs.Location = new System.Drawing.Point(26, 57);
            this.txt_id_bailleurs.Margin = new System.Windows.Forms.Padding(4);
            this.txt_id_bailleurs.Name = "txt_id_bailleurs";
            this.txt_id_bailleurs.Size = new System.Drawing.Size(359, 44);
            this.txt_id_bailleurs.TabIndex = 92;
            this.txt_id_bailleurs.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.btn_supprimer.Location = new System.Drawing.Point(1091, 163);
            this.btn_supprimer.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btn_supprimer.Name = "btn_supprimer";
            this.btn_supprimer.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.btn_supprimer.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_supprimer.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_supprimer.selected = false;
            this.btn_supprimer.Size = new System.Drawing.Size(164, 44);
            this.btn_supprimer.TabIndex = 97;
            this.btn_supprimer.Text = "Supprimer";
            this.btn_supprimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_supprimer.Textcolor = System.Drawing.Color.White;
            this.btn_supprimer.TextFont = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btn_enregistrer.Location = new System.Drawing.Point(917, 163);
            this.btn_enregistrer.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btn_enregistrer.Name = "btn_enregistrer";
            this.btn_enregistrer.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.btn_enregistrer.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_enregistrer.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_enregistrer.selected = false;
            this.btn_enregistrer.Size = new System.Drawing.Size(164, 44);
            this.btn_enregistrer.TabIndex = 96;
            this.btn_enregistrer.Text = "Enregistrer";
            this.btn_enregistrer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_enregistrer.Textcolor = System.Drawing.Color.White;
            this.btn_enregistrer.TextFont = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // frm_bailleurs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(1300, 714);
            this.Controls.Add(this.bunifuCustomDataGrid2);
            this.Controls.Add(this.txt_telephone);
            this.Controls.Add(this.txt_adresse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbx_vulnerabilite);
            this.Controls.Add(this.btn_supprimer);
            this.Controls.Add(this.btn_enregistrer);
            this.Controls.Add(this.dt_date_distribution);
            this.Controls.Add(this.cbx_sexe);
            this.Controls.Add(this.txt_noms);
            this.Controls.Add(this.txt_id_bailleurs);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_bailleurs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_bailleurs";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid2;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txt_telephone;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txt_adresse;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroComboBox cbx_vulnerabilite;
        private Bunifu.Framework.UI.BunifuFlatButton btn_supprimer;
        private Bunifu.Framework.UI.BunifuFlatButton btn_enregistrer;
        private MetroFramework.Controls.MetroDateTime dt_date_distribution;
        private MetroFramework.Controls.MetroComboBox cbx_sexe;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txt_noms;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txt_id_bailleurs;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}