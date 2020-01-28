namespace MediationDB.FormLibrary
{
    partial class frm_membres
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_id_menage = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_noms_membre = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_code_membre = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cbx_etat_civil = new MetroFramework.Controls.MetroComboBox();
            this.dt_date_naissance = new MetroFramework.Controls.MetroDateTime();
            this.label2 = new System.Windows.Forms.Label();
            this.dt_date_enregistrement = new MetroFramework.Controls.MetroDateTime();
            this.cbx_vulnerabilite = new MetroFramework.Controls.MetroComboBox();
            this.txt_provenance = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_telephone = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_adresse = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_profession = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label6 = new System.Windows.Forms.Label();
            this.rd_btn_yes = new System.Windows.Forms.RadioButton();
            this.rd_btn_no = new System.Windows.Forms.RadioButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuCustomDataGrid2 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.cbx_sexe = new MetroFramework.Controls.MetroComboBox();
            this.btn_supprimer = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_enregistrer = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid2)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(1256, 49);
            this.panel1.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(411, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Informations sur les membres";
            // 
            // txt_id_menage
            // 
            this.txt_id_menage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_id_menage.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_id_menage.ForeColor = System.Drawing.Color.White;
            this.txt_id_menage.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_id_menage.HintText = "Id. Menage";
            this.txt_id_menage.isPassword = false;
            this.txt_id_menage.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.txt_id_menage.LineIdleColor = System.Drawing.Color.White;
            this.txt_id_menage.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.txt_id_menage.LineThickness = 1;
            this.txt_id_menage.Location = new System.Drawing.Point(13, 56);
            this.txt_id_menage.Margin = new System.Windows.Forms.Padding(4);
            this.txt_id_menage.Name = "txt_id_menage";
            this.txt_id_menage.Size = new System.Drawing.Size(128, 44);
            this.txt_id_menage.TabIndex = 44;
            this.txt_id_menage.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_id_menage.OnValueChanged += new System.EventHandler(this.txt_id_menage_OnValueChanged);
            // 
            // txt_noms_membre
            // 
            this.txt_noms_membre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_noms_membre.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_noms_membre.ForeColor = System.Drawing.Color.White;
            this.txt_noms_membre.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_noms_membre.HintText = "Entrez les noms du membre de menage";
            this.txt_noms_membre.isPassword = false;
            this.txt_noms_membre.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.txt_noms_membre.LineIdleColor = System.Drawing.Color.White;
            this.txt_noms_membre.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.txt_noms_membre.LineThickness = 1;
            this.txt_noms_membre.Location = new System.Drawing.Point(13, 108);
            this.txt_noms_membre.Margin = new System.Windows.Forms.Padding(4);
            this.txt_noms_membre.Name = "txt_noms_membre";
            this.txt_noms_membre.Size = new System.Drawing.Size(406, 44);
            this.txt_noms_membre.TabIndex = 45;
            this.txt_noms_membre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_noms_membre.OnValueChanged += new System.EventHandler(this.txt_noms_membre_OnValueChanged);
            // 
            // txt_code_membre
            // 
            this.txt_code_membre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_code_membre.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_code_membre.ForeColor = System.Drawing.Color.White;
            this.txt_code_membre.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_code_membre.HintText = "Entrez l\'identifiant du membre";
            this.txt_code_membre.isPassword = false;
            this.txt_code_membre.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.txt_code_membre.LineIdleColor = System.Drawing.Color.White;
            this.txt_code_membre.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.txt_code_membre.LineThickness = 1;
            this.txt_code_membre.Location = new System.Drawing.Point(149, 56);
            this.txt_code_membre.Margin = new System.Windows.Forms.Padding(4);
            this.txt_code_membre.Name = "txt_code_membre";
            this.txt_code_membre.Size = new System.Drawing.Size(270, 44);
            this.txt_code_membre.TabIndex = 46;
            this.txt_code_membre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_code_membre.OnValueChanged += new System.EventHandler(this.txt_code_membre_OnValueChanged);
            // 
            // cbx_etat_civil
            // 
            this.cbx_etat_civil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.cbx_etat_civil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbx_etat_civil.ForeColor = System.Drawing.Color.White;
            this.cbx_etat_civil.FormattingEnabled = true;
            this.cbx_etat_civil.ItemHeight = 23;
            this.cbx_etat_civil.Items.AddRange(new object[] {
            "Marié",
            "Célibataire",
            "Veuf(ve)",
            "Divorcé(e)",
            "Union libre"});
            this.cbx_etat_civil.Location = new System.Drawing.Point(895, 95);
            this.cbx_etat_civil.Name = "cbx_etat_civil";
            this.cbx_etat_civil.PromptText = "Etat Civil";
            this.cbx_etat_civil.Size = new System.Drawing.Size(349, 29);
            this.cbx_etat_civil.Style = MetroFramework.MetroColorStyle.Blue;
            this.cbx_etat_civil.TabIndex = 48;
            this.cbx_etat_civil.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbx_etat_civil.UseSelectable = true;
            // 
            // dt_date_naissance
            // 
            this.dt_date_naissance.Location = new System.Drawing.Point(1035, 170);
            this.dt_date_naissance.MinimumSize = new System.Drawing.Size(0, 29);
            this.dt_date_naissance.Name = "dt_date_naissance";
            this.dt_date_naissance.Size = new System.Drawing.Size(209, 33);
            this.dt_date_naissance.Style = MetroFramework.MetroColorStyle.Blue;
            this.dt_date_naissance.TabIndex = 51;
            this.dt_date_naissance.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(901, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 17);
            this.label2.TabIndex = 50;
            this.label2.Text = "Date de naissance";
            // 
            // dt_date_enregistrement
            // 
            this.dt_date_enregistrement.Location = new System.Drawing.Point(445, 67);
            this.dt_date_enregistrement.MinimumSize = new System.Drawing.Size(0, 29);
            this.dt_date_enregistrement.Name = "dt_date_enregistrement";
            this.dt_date_enregistrement.Size = new System.Drawing.Size(431, 33);
            this.dt_date_enregistrement.Style = MetroFramework.MetroColorStyle.Blue;
            this.dt_date_enregistrement.TabIndex = 53;
            this.dt_date_enregistrement.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // cbx_vulnerabilite
            // 
            this.cbx_vulnerabilite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.cbx_vulnerabilite.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbx_vulnerabilite.ForeColor = System.Drawing.Color.White;
            this.cbx_vulnerabilite.FormattingEnabled = true;
            this.cbx_vulnerabilite.ItemHeight = 23;
            this.cbx_vulnerabilite.Location = new System.Drawing.Point(895, 130);
            this.cbx_vulnerabilite.Name = "cbx_vulnerabilite";
            this.cbx_vulnerabilite.PromptText = "Choisissez un facteur de marginalisation";
            this.cbx_vulnerabilite.Size = new System.Drawing.Size(349, 29);
            this.cbx_vulnerabilite.Style = MetroFramework.MetroColorStyle.Blue;
            this.cbx_vulnerabilite.TabIndex = 54;
            this.cbx_vulnerabilite.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbx_vulnerabilite.UseSelectable = true;
            // 
            // txt_provenance
            // 
            this.txt_provenance.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_provenance.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_provenance.ForeColor = System.Drawing.Color.White;
            this.txt_provenance.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_provenance.HintText = "Quelle est la provenance du membre de menage?";
            this.txt_provenance.isPassword = false;
            this.txt_provenance.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.txt_provenance.LineIdleColor = System.Drawing.Color.White;
            this.txt_provenance.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.txt_provenance.LineThickness = 1;
            this.txt_provenance.Location = new System.Drawing.Point(13, 160);
            this.txt_provenance.Margin = new System.Windows.Forms.Padding(4);
            this.txt_provenance.Name = "txt_provenance";
            this.txt_provenance.Size = new System.Drawing.Size(406, 44);
            this.txt_provenance.TabIndex = 56;
            this.txt_provenance.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_telephone
            // 
            this.txt_telephone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_telephone.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_telephone.ForeColor = System.Drawing.Color.White;
            this.txt_telephone.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_telephone.HintText = "Téléphone du membre de menage";
            this.txt_telephone.isPassword = false;
            this.txt_telephone.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.txt_telephone.LineIdleColor = System.Drawing.Color.White;
            this.txt_telephone.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.txt_telephone.LineThickness = 1;
            this.txt_telephone.Location = new System.Drawing.Point(445, 111);
            this.txt_telephone.Margin = new System.Windows.Forms.Padding(4);
            this.txt_telephone.Name = "txt_telephone";
            this.txt_telephone.Size = new System.Drawing.Size(431, 44);
            this.txt_telephone.TabIndex = 57;
            this.txt_telephone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_adresse
            // 
            this.txt_adresse.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_adresse.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_adresse.ForeColor = System.Drawing.Color.White;
            this.txt_adresse.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_adresse.HintText = "Completez l\'adresse du membre de ce menage ici";
            this.txt_adresse.isPassword = false;
            this.txt_adresse.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.txt_adresse.LineIdleColor = System.Drawing.Color.White;
            this.txt_adresse.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.txt_adresse.LineThickness = 1;
            this.txt_adresse.Location = new System.Drawing.Point(13, 212);
            this.txt_adresse.Margin = new System.Windows.Forms.Padding(4);
            this.txt_adresse.Name = "txt_adresse";
            this.txt_adresse.Size = new System.Drawing.Size(863, 44);
            this.txt_adresse.TabIndex = 59;
            this.txt_adresse.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_profession
            // 
            this.txt_profession.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_profession.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_profession.ForeColor = System.Drawing.Color.White;
            this.txt_profession.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_profession.HintText = "Completez la profession du membre de menage";
            this.txt_profession.isPassword = false;
            this.txt_profession.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.txt_profession.LineIdleColor = System.Drawing.Color.White;
            this.txt_profession.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.txt_profession.LineThickness = 1;
            this.txt_profession.Location = new System.Drawing.Point(445, 163);
            this.txt_profession.Margin = new System.Windows.Forms.Padding(4);
            this.txt_profession.Name = "txt_profession";
            this.txt_profession.Size = new System.Drawing.Size(431, 44);
            this.txt_profession.TabIndex = 60;
            this.txt_profession.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(396, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(311, 17);
            this.label6.TabIndex = 62;
            this.label6.Text = "Ce membre est il un représentant du ménage?";
            // 
            // rd_btn_yes
            // 
            this.rd_btn_yes.AutoSize = true;
            this.rd_btn_yes.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_btn_yes.ForeColor = System.Drawing.Color.White;
            this.rd_btn_yes.Location = new System.Drawing.Point(720, 272);
            this.rd_btn_yes.Name = "rd_btn_yes";
            this.rd_btn_yes.Size = new System.Drawing.Size(48, 21);
            this.rd_btn_yes.TabIndex = 63;
            this.rd_btn_yes.TabStop = true;
            this.rd_btn_yes.Text = "Oui";
            this.rd_btn_yes.UseVisualStyleBackColor = true;
            // 
            // rd_btn_no
            // 
            this.rd_btn_no.AutoSize = true;
            this.rd_btn_no.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rd_btn_no.ForeColor = System.Drawing.Color.White;
            this.rd_btn_no.Location = new System.Drawing.Point(781, 273);
            this.rd_btn_no.Name = "rd_btn_no";
            this.rd_btn_no.Size = new System.Drawing.Size(53, 21);
            this.rd_btn_no.TabIndex = 64;
            this.rd_btn_no.TabStop = true;
            this.rd_btn_no.Text = "Non";
            this.rd_btn_no.UseVisualStyleBackColor = true;
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.bunifuCustomDataGrid2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuCustomDataGrid2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuCustomDataGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid2.DefaultCellStyle = dataGridViewCellStyle3;
            this.bunifuCustomDataGrid2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunifuCustomDataGrid2.DoubleBuffered = true;
            this.bunifuCustomDataGrid2.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuCustomDataGrid2.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuCustomDataGrid2.HeaderForeColor = System.Drawing.Color.White;
            this.bunifuCustomDataGrid2.Location = new System.Drawing.Point(0, 374);
            this.bunifuCustomDataGrid2.Name = "bunifuCustomDataGrid2";
            this.bunifuCustomDataGrid2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid2.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid2.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.bunifuCustomDataGrid2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bunifuCustomDataGrid2.Size = new System.Drawing.Size(1256, 256);
            this.bunifuCustomDataGrid2.TabIndex = 67;
            this.bunifuCustomDataGrid2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuCustomDataGrid2_CellContentClick);
            // 
            // cbx_sexe
            // 
            this.cbx_sexe.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.cbx_sexe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbx_sexe.ForeColor = System.Drawing.Color.White;
            this.cbx_sexe.FormattingEnabled = true;
            this.cbx_sexe.ItemHeight = 23;
            this.cbx_sexe.Items.AddRange(new object[] {
            "Feminin",
            "Masculin"});
            this.cbx_sexe.Location = new System.Drawing.Point(895, 60);
            this.cbx_sexe.Name = "cbx_sexe";
            this.cbx_sexe.PromptText = "Choisissez le genre";
            this.cbx_sexe.Size = new System.Drawing.Size(349, 29);
            this.cbx_sexe.Style = MetroFramework.MetroColorStyle.Blue;
            this.cbx_sexe.TabIndex = 68;
            this.cbx_sexe.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbx_sexe.UseSelectable = true;
            // 
            // btn_supprimer
            // 
            this.btn_supprimer.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_supprimer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_supprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_supprimer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_supprimer.BorderRadius = 0;
            this.btn_supprimer.ButtonText = "     Supprimer";
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
            this.btn_supprimer.IconZoom = 70D;
            this.btn_supprimer.IsTab = true;
            this.btn_supprimer.Location = new System.Drawing.Point(630, 318);
            this.btn_supprimer.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btn_supprimer.Name = "btn_supprimer";
            this.btn_supprimer.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_supprimer.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.btn_supprimer.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_supprimer.selected = false;
            this.btn_supprimer.Size = new System.Drawing.Size(183, 38);
            this.btn_supprimer.TabIndex = 70;
            this.btn_supprimer.Text = "     Supprimer";
            this.btn_supprimer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_supprimer.Textcolor = System.Drawing.Color.White;
            this.btn_supprimer.TextFont = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_supprimer.Click += new System.EventHandler(this.btn_supprimer_Click);
            // 
            // btn_enregistrer
            // 
            this.btn_enregistrer.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_enregistrer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_enregistrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_enregistrer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_enregistrer.BorderRadius = 0;
            this.btn_enregistrer.ButtonText = "     Enregistrer";
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
            this.btn_enregistrer.IconZoom = 70D;
            this.btn_enregistrer.IsTab = true;
            this.btn_enregistrer.Location = new System.Drawing.Point(437, 318);
            this.btn_enregistrer.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btn_enregistrer.Name = "btn_enregistrer";
            this.btn_enregistrer.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_enregistrer.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.btn_enregistrer.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_enregistrer.selected = false;
            this.btn_enregistrer.Size = new System.Drawing.Size(192, 38);
            this.btn_enregistrer.TabIndex = 69;
            this.btn_enregistrer.Text = "     Enregistrer";
            this.btn_enregistrer.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_enregistrer.Textcolor = System.Drawing.Color.White;
            this.btn_enregistrer.TextFont = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enregistrer.Click += new System.EventHandler(this.btn_enregistrer_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuImageButton1.Image = global::MediationDB.Properties.Resources.multiply_96px;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(1202, 7);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(42, 34);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 7;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // frm_membres
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(1256, 630);
            this.ControlBox = false;
            this.Controls.Add(this.btn_supprimer);
            this.Controls.Add(this.btn_enregistrer);
            this.Controls.Add(this.dt_date_enregistrement);
            this.Controls.Add(this.cbx_sexe);
            this.Controls.Add(this.bunifuCustomDataGrid2);
            this.Controls.Add(this.rd_btn_no);
            this.Controls.Add(this.rd_btn_yes);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_profession);
            this.Controls.Add(this.txt_adresse);
            this.Controls.Add(this.txt_telephone);
            this.Controls.Add(this.txt_provenance);
            this.Controls.Add(this.cbx_vulnerabilite);
            this.Controls.Add(this.dt_date_naissance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbx_etat_civil);
            this.Controls.Add(this.txt_code_membre);
            this.Controls.Add(this.txt_noms_membre);
            this.Controls.Add(this.txt_id_menage);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frm_membres";
            this.Opacity = 0.9D;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_membres_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_noms_membre;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_code_membre;
        private MetroFramework.Controls.MetroComboBox cbx_etat_civil;
        private MetroFramework.Controls.MetroDateTime dt_date_naissance;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroDateTime dt_date_enregistrement;
        private MetroFramework.Controls.MetroComboBox cbx_vulnerabilite;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_provenance;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_telephone;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_adresse;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_profession;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton rd_btn_yes;
        private System.Windows.Forms.RadioButton rd_btn_no;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txt_id_menage;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid2;
        private MetroFramework.Controls.MetroComboBox cbx_sexe;
        private Bunifu.Framework.UI.BunifuFlatButton btn_supprimer;
        private Bunifu.Framework.UI.BunifuFlatButton btn_enregistrer;
    }
}