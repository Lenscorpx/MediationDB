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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbx_projet = new MetroFramework.Controls.MetroComboBox();
            this.cbx_executant = new MetroFramework.Controls.MetroComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbx_agr = new MetroFramework.Controls.MetroComboBox();
            this.txt_num_distribution = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_id_localite = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_qte_recue = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_observation = new System.Windows.Forms.RichTextBox();
            this.txt_valeur = new Bunifu.Framework.UI.BunifuMaterialTextbox();
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
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 17;
            this.listBox1.Location = new System.Drawing.Point(4, 102);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(235, 306);
            this.listBox1.TabIndex = 35;
            // 
            // txt_search_localite
            // 
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
            this.bunifuCustomDataGrid2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
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
            this.bunifuCustomDataGrid2.Location = new System.Drawing.Point(0, 363);
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
            this.bunifuCustomDataGrid2.Size = new System.Drawing.Size(1263, 286);
            this.bunifuCustomDataGrid2.TabIndex = 53;
            // 
            // dt_date_distribution
            // 
            this.dt_date_distribution.Location = new System.Drawing.Point(937, 71);
            this.dt_date_distribution.MinimumSize = new System.Drawing.Size(0, 29);
            this.dt_date_distribution.Name = "dt_date_distribution";
            this.dt_date_distribution.Size = new System.Drawing.Size(289, 29);
            this.dt_date_distribution.Style = MetroFramework.MetroColorStyle.Blue;
            this.dt_date_distribution.TabIndex = 73;
            this.dt_date_distribution.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(252, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 72;
            this.label4.Text = "Projet";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(579, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 17);
            this.label3.TabIndex = 71;
            this.label3.Text = "Partenaire d\'éxecution";
            // 
            // cbx_projet
            // 
            this.cbx_projet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.cbx_projet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbx_projet.ForeColor = System.Drawing.Color.White;
            this.cbx_projet.FormattingEnabled = true;
            this.cbx_projet.ItemHeight = 23;
            this.cbx_projet.Location = new System.Drawing.Point(285, 133);
            this.cbx_projet.Name = "cbx_projet";
            this.cbx_projet.PromptText = "Choisissez le projet lié à cette distribution";
            this.cbx_projet.Size = new System.Drawing.Size(289, 29);
            this.cbx_projet.Style = MetroFramework.MetroColorStyle.Blue;
            this.cbx_projet.TabIndex = 70;
            this.cbx_projet.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbx_projet.UseSelectable = true;
            // 
            // cbx_executant
            // 
            this.cbx_executant.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.cbx_executant.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbx_executant.ForeColor = System.Drawing.Color.White;
            this.cbx_executant.FormattingEnabled = true;
            this.cbx_executant.ItemHeight = 23;
            this.cbx_executant.Location = new System.Drawing.Point(612, 133);
            this.cbx_executant.Name = "cbx_executant";
            this.cbx_executant.PromptText = "Choisissez le partenaire d\'éxecuion";
            this.cbx_executant.Size = new System.Drawing.Size(289, 29);
            this.cbx_executant.Style = MetroFramework.MetroColorStyle.Blue;
            this.cbx_executant.TabIndex = 69;
            this.cbx_executant.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbx_executant.UseSelectable = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(920, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 17);
            this.label5.TabIndex = 75;
            this.label5.Text = "AGR donné";
            // 
            // cbx_agr
            // 
            this.cbx_agr.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.cbx_agr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbx_agr.ForeColor = System.Drawing.Color.White;
            this.cbx_agr.FormattingEnabled = true;
            this.cbx_agr.ItemHeight = 23;
            this.cbx_agr.Location = new System.Drawing.Point(937, 133);
            this.cbx_agr.Name = "cbx_agr";
            this.cbx_agr.PromptText = "Selectionnez l\'AGR donné";
            this.cbx_agr.Size = new System.Drawing.Size(289, 29);
            this.cbx_agr.Style = MetroFramework.MetroColorStyle.Blue;
            this.cbx_agr.TabIndex = 74;
            this.cbx_agr.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbx_agr.UseSelectable = true;
            // 
            // txt_num_distribution
            // 
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
            this.txt_num_distribution.Location = new System.Drawing.Point(582, 56);
            this.txt_num_distribution.Margin = new System.Windows.Forms.Padding(4);
            this.txt_num_distribution.Name = "txt_num_distribution";
            this.txt_num_distribution.Size = new System.Drawing.Size(319, 44);
            this.txt_num_distribution.TabIndex = 77;
            this.txt_num_distribution.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_id_localite
            // 
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
            this.txt_id_localite.Size = new System.Drawing.Size(319, 44);
            this.txt_id_localite.TabIndex = 76;
            this.txt_id_localite.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_qte_recue
            // 
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
            this.txt_qte_recue.Location = new System.Drawing.Point(285, 169);
            this.txt_qte_recue.Margin = new System.Windows.Forms.Padding(4);
            this.txt_qte_recue.Name = "txt_qte_recue";
            this.txt_qte_recue.Size = new System.Drawing.Size(289, 44);
            this.txt_qte_recue.TabIndex = 78;
            this.txt_qte_recue.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_observation
            // 
            this.txt_observation.Location = new System.Drawing.Point(937, 169);
            this.txt_observation.Name = "txt_observation";
            this.txt_observation.Size = new System.Drawing.Size(314, 188);
            this.txt_observation.TabIndex = 79;
            this.txt_observation.Text = "";
            // 
            // txt_valeur
            // 
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
            this.txt_valeur.Location = new System.Drawing.Point(285, 221);
            this.txt_valeur.Margin = new System.Windows.Forms.Padding(4);
            this.txt_valeur.Name = "txt_valeur";
            this.txt_valeur.Size = new System.Drawing.Size(289, 44);
            this.txt_valeur.TabIndex = 80;
            this.txt_valeur.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // frm_distribution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(1263, 649);
            this.Controls.Add(this.txt_valeur);
            this.Controls.Add(this.txt_observation);
            this.Controls.Add(this.txt_qte_recue);
            this.Controls.Add(this.txt_num_distribution);
            this.Controls.Add(this.txt_id_localite);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbx_agr);
            this.Controls.Add(this.dt_date_distribution);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbx_projet);
            this.Controls.Add(this.cbx_executant);
            this.Controls.Add(this.bunifuCustomDataGrid2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txt_search_localite);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private MetroFramework.Controls.MetroComboBox cbx_projet;
        private MetroFramework.Controls.MetroComboBox cbx_executant;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroComboBox cbx_agr;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_num_distribution;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_id_localite;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_qte_recue;
        private System.Windows.Forms.RichTextBox txt_observation;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_valeur;
    }
}