namespace MediationDB.FormLibrary
{
    partial class frm_distribution
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
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txt_search_localite = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomDataGrid2 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.dt_date_distribution = new MetroFramework.Controls.MetroDateTime();
            this.cbx_projet = new MetroFramework.Controls.MetroComboBox();
            this.cbx_executant = new MetroFramework.Controls.MetroComboBox();
            this.cbx_agr = new MetroFramework.Controls.MetroComboBox();
            this.txt_num_distribution = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_id_localite = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_qte_recue = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_observation = new System.Windows.Forms.RichTextBox();
            this.txt_valeur = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_beneficiaires = new Bunifu.Framework.UI.BunifuFlatButton();
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
            this.panel1.Size = new System.Drawing.Size(1263, 49);
            this.panel1.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(406, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(473, 30);
            this.label1.TabIndex = 8;
            this.label1.Text = "Informations sur les distrtibutions d\'AGR";
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuImageButton1.Image = global::MediationDB.Properties.Resources.multiply_96px;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(1213, 7);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(42, 34);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 7;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // listBox1
            // 
            this.listBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 17;
            this.listBox1.Location = new System.Drawing.Point(4, 102);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(243, 255);
            this.listBox1.TabIndex = 35;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // txt_search_localite
            // 
            this.txt_search_localite.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_search_localite.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_search_localite.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_search_localite.ForeColor = System.Drawing.Color.White;
            this.txt_search_localite.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_search_localite.HintText = "Recherchez une localité";
            this.txt_search_localite.isPassword = false;
            this.txt_search_localite.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.txt_search_localite.LineIdleColor = System.Drawing.Color.White;
            this.txt_search_localite.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.txt_search_localite.LineThickness = 4;
            this.txt_search_localite.Location = new System.Drawing.Point(4, 56);
            this.txt_search_localite.Margin = new System.Windows.Forms.Padding(4);
            this.txt_search_localite.Name = "txt_search_localite";
            this.txt_search_localite.Size = new System.Drawing.Size(243, 44);
            this.txt_search_localite.TabIndex = 36;
            this.txt_search_localite.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_search_localite.OnValueChanged += new System.EventHandler(this.txt_search_localite_OnValueChanged);
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
            this.bunifuCustomDataGrid2.Location = new System.Drawing.Point(0, 379);
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
            this.bunifuCustomDataGrid2.Size = new System.Drawing.Size(1263, 270);
            this.bunifuCustomDataGrid2.TabIndex = 53;
            // 
            // dt_date_distribution
            // 
            this.dt_date_distribution.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dt_date_distribution.Location = new System.Drawing.Point(669, 262);
            this.dt_date_distribution.MinimumSize = new System.Drawing.Size(0, 29);
            this.dt_date_distribution.Name = "dt_date_distribution";
            this.dt_date_distribution.Size = new System.Drawing.Size(210, 29);
            this.dt_date_distribution.Style = MetroFramework.MetroColorStyle.Blue;
            this.dt_date_distribution.TabIndex = 73;
            this.dt_date_distribution.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // cbx_projet
            // 
            this.cbx_projet.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbx_projet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.cbx_projet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbx_projet.ForeColor = System.Drawing.Color.White;
            this.cbx_projet.FormattingEnabled = true;
            this.cbx_projet.ItemHeight = 23;
            this.cbx_projet.Location = new System.Drawing.Point(253, 161);
            this.cbx_projet.Name = "cbx_projet";
            this.cbx_projet.PromptText = "Choisissez le projet lié à cette distribution";
            this.cbx_projet.Size = new System.Drawing.Size(361, 29);
            this.cbx_projet.Style = MetroFramework.MetroColorStyle.Blue;
            this.cbx_projet.TabIndex = 70;
            this.cbx_projet.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbx_projet.UseSelectable = true;
            // 
            // cbx_executant
            // 
            this.cbx_executant.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbx_executant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.cbx_executant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbx_executant.ForeColor = System.Drawing.Color.White;
            this.cbx_executant.FormattingEnabled = true;
            this.cbx_executant.ItemHeight = 23;
            this.cbx_executant.Location = new System.Drawing.Point(253, 198);
            this.cbx_executant.Name = "cbx_executant";
            this.cbx_executant.PromptText = "Choisissez le partenaire d\'éxecuion";
            this.cbx_executant.Size = new System.Drawing.Size(361, 29);
            this.cbx_executant.Style = MetroFramework.MetroColorStyle.Blue;
            this.cbx_executant.TabIndex = 69;
            this.cbx_executant.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbx_executant.UseSelectable = true;
            // 
            // cbx_agr
            // 
            this.cbx_agr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbx_agr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.cbx_agr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbx_agr.ForeColor = System.Drawing.Color.White;
            this.cbx_agr.FormattingEnabled = true;
            this.cbx_agr.ItemHeight = 23;
            this.cbx_agr.Location = new System.Drawing.Point(253, 235);
            this.cbx_agr.Name = "cbx_agr";
            this.cbx_agr.PromptText = "Selectionnez l\'AGR donné";
            this.cbx_agr.Size = new System.Drawing.Size(361, 29);
            this.cbx_agr.Style = MetroFramework.MetroColorStyle.Blue;
            this.cbx_agr.TabIndex = 74;
            this.cbx_agr.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbx_agr.UseSelectable = true;
            // 
            // txt_num_distribution
            // 
            this.txt_num_distribution.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_num_distribution.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_num_distribution.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_num_distribution.ForeColor = System.Drawing.Color.White;
            this.txt_num_distribution.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_num_distribution.HintText = "Num. Distribution";
            this.txt_num_distribution.isPassword = false;
            this.txt_num_distribution.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.txt_num_distribution.LineIdleColor = System.Drawing.Color.White;
            this.txt_num_distribution.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.txt_num_distribution.LineThickness = 4;
            this.txt_num_distribution.Location = new System.Drawing.Point(255, 108);
            this.txt_num_distribution.Margin = new System.Windows.Forms.Padding(4);
            this.txt_num_distribution.Name = "txt_num_distribution";
            this.txt_num_distribution.Size = new System.Drawing.Size(359, 44);
            this.txt_num_distribution.TabIndex = 77;
            this.txt_num_distribution.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_id_localite
            // 
            this.txt_id_localite.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_id_localite.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_id_localite.Enabled = false;
            this.txt_id_localite.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_id_localite.ForeColor = System.Drawing.Color.White;
            this.txt_id_localite.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_id_localite.HintText = "Selectionnez la localité dans la liste";
            this.txt_id_localite.isPassword = false;
            this.txt_id_localite.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.txt_id_localite.LineIdleColor = System.Drawing.Color.White;
            this.txt_id_localite.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.txt_id_localite.LineThickness = 4;
            this.txt_id_localite.Location = new System.Drawing.Point(255, 56);
            this.txt_id_localite.Margin = new System.Windows.Forms.Padding(4);
            this.txt_id_localite.Name = "txt_id_localite";
            this.txt_id_localite.Size = new System.Drawing.Size(359, 44);
            this.txt_id_localite.TabIndex = 76;
            this.txt_id_localite.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_id_localite.OnValueChanged += new System.EventHandler(this.txt_id_localite_OnValueChanged);
            // 
            // txt_qte_recue
            // 
            this.txt_qte_recue.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_qte_recue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_qte_recue.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_qte_recue.ForeColor = System.Drawing.Color.White;
            this.txt_qte_recue.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_qte_recue.HintText = "Specifiez la quantité donnée";
            this.txt_qte_recue.isPassword = false;
            this.txt_qte_recue.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.txt_qte_recue.LineIdleColor = System.Drawing.Color.White;
            this.txt_qte_recue.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.txt_qte_recue.LineThickness = 4;
            this.txt_qte_recue.Location = new System.Drawing.Point(252, 323);
            this.txt_qte_recue.Margin = new System.Windows.Forms.Padding(4);
            this.txt_qte_recue.Name = "txt_qte_recue";
            this.txt_qte_recue.Size = new System.Drawing.Size(362, 44);
            this.txt_qte_recue.TabIndex = 78;
            this.txt_qte_recue.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_observation
            // 
            this.txt_observation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_observation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_observation.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_observation.ForeColor = System.Drawing.Color.Black;
            this.txt_observation.Location = new System.Drawing.Point(669, 89);
            this.txt_observation.Name = "txt_observation";
            this.txt_observation.Size = new System.Drawing.Size(580, 138);
            this.txt_observation.TabIndex = 79;
            this.txt_observation.Text = "";
            // 
            // txt_valeur
            // 
            this.txt_valeur.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_valeur.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_valeur.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_valeur.ForeColor = System.Drawing.Color.White;
            this.txt_valeur.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_valeur.HintText = "Spécifiez si possible la valeur  en monnaie";
            this.txt_valeur.isPassword = false;
            this.txt_valeur.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.txt_valeur.LineIdleColor = System.Drawing.Color.White;
            this.txt_valeur.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.txt_valeur.LineThickness = 4;
            this.txt_valeur.Location = new System.Drawing.Point(253, 271);
            this.txt_valeur.Margin = new System.Windows.Forms.Padding(4);
            this.txt_valeur.Name = "txt_valeur";
            this.txt_valeur.Size = new System.Drawing.Size(361, 44);
            this.txt_valeur.TabIndex = 80;
            this.txt_valeur.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(626, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Completez ici les observations!";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(644, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 19);
            this.label3.TabIndex = 83;
            this.label3.Text = "Date de distrtibution";
            // 
            // btn_beneficiaires
            // 
            this.btn_beneficiaires.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.btn_beneficiaires.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_beneficiaires.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.btn_beneficiaires.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_beneficiaires.BorderRadius = 0;
            this.btn_beneficiaires.ButtonText = "Ajouter des beneficiaires";
            this.btn_beneficiaires.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_beneficiaires.DisabledColor = System.Drawing.Color.Gray;
            this.btn_beneficiaires.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_beneficiaires.ForeColor = System.Drawing.Color.White;
            this.btn_beneficiaires.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_beneficiaires.Iconimage = global::MediationDB.Properties.Resources.add_96px;
            this.btn_beneficiaires.Iconimage_right = null;
            this.btn_beneficiaires.Iconimage_right_Selected = null;
            this.btn_beneficiaires.Iconimage_Selected = null;
            this.btn_beneficiaires.IconMarginLeft = 0;
            this.btn_beneficiaires.IconMarginRight = 0;
            this.btn_beneficiaires.IconRightVisible = true;
            this.btn_beneficiaires.IconRightZoom = 0D;
            this.btn_beneficiaires.IconVisible = true;
            this.btn_beneficiaires.IconZoom = 50D;
            this.btn_beneficiaires.IsTab = true;
            this.btn_beneficiaires.Location = new System.Drawing.Point(1003, 236);
            this.btn_beneficiaires.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btn_beneficiaires.Name = "btn_beneficiaires";
            this.btn_beneficiaires.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.btn_beneficiaires.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_beneficiaires.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_beneficiaires.selected = false;
            this.btn_beneficiaires.Size = new System.Drawing.Size(246, 39);
            this.btn_beneficiaires.TabIndex = 84;
            this.btn_beneficiaires.Text = "Ajouter des beneficiaires";
            this.btn_beneficiaires.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_beneficiaires.Textcolor = System.Drawing.Color.White;
            this.btn_beneficiaires.TextFont = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btn_supprimer.Location = new System.Drawing.Point(842, 323);
            this.btn_supprimer.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btn_supprimer.Name = "btn_supprimer";
            this.btn_supprimer.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.btn_supprimer.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_supprimer.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_supprimer.selected = false;
            this.btn_supprimer.Size = new System.Drawing.Size(164, 44);
            this.btn_supprimer.TabIndex = 82;
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
            this.btn_enregistrer.Location = new System.Drawing.Point(668, 323);
            this.btn_enregistrer.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btn_enregistrer.Name = "btn_enregistrer";
            this.btn_enregistrer.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.btn_enregistrer.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_enregistrer.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_enregistrer.selected = false;
            this.btn_enregistrer.Size = new System.Drawing.Size(164, 44);
            this.btn_enregistrer.TabIndex = 81;
            this.btn_enregistrer.Text = "Enregistrer";
            this.btn_enregistrer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_enregistrer.Textcolor = System.Drawing.Color.White;
            this.btn_enregistrer.TextFont = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enregistrer.Click += new System.EventHandler(this.btn_enregistrer_Click);
            // 
            // frm_distribution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(1263, 649);
            this.Controls.Add(this.btn_beneficiaires);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_supprimer);
            this.Controls.Add(this.btn_enregistrer);
            this.Controls.Add(this.txt_valeur);
            this.Controls.Add(this.txt_observation);
            this.Controls.Add(this.txt_qte_recue);
            this.Controls.Add(this.txt_num_distribution);
            this.Controls.Add(this.txt_id_localite);
            this.Controls.Add(this.cbx_agr);
            this.Controls.Add(this.dt_date_distribution);
            this.Controls.Add(this.cbx_projet);
            this.Controls.Add(this.cbx_executant);
            this.Controls.Add(this.bunifuCustomDataGrid2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txt_search_localite);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_distribution";
            this.Opacity = 0.96D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.ListBox listBox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_search_localite;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid2;
        private MetroFramework.Controls.MetroDateTime dt_date_distribution;
        private MetroFramework.Controls.MetroComboBox cbx_projet;
        private MetroFramework.Controls.MetroComboBox cbx_executant;
        private MetroFramework.Controls.MetroComboBox cbx_agr;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_id_localite;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_qte_recue;
        private System.Windows.Forms.RichTextBox txt_observation;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_valeur;
        private Bunifu.Framework.UI.BunifuFlatButton btn_supprimer;
        private Bunifu.Framework.UI.BunifuFlatButton btn_enregistrer;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txt_num_distribution;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuFlatButton btn_beneficiaires;
    }
}