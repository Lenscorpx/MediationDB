namespace MediationDB.FormLibrary
{
    partial class frm_conflit
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnl_header = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txt_id_localite = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomDataGrid2 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.txt_num_conflit = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_localite = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.metroDateTime1 = new MetroFramework.Controls.MetroDateTime();
            this.btn_mediation = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_objets = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_causes = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_details = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_parties = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_supprimer = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_enregistrer = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cbx_nature_conflit = new MetroFramework.Controls.MetroComboBox();
            this.cbx_type_conflit = new MetroFramework.Controls.MetroComboBox();
            this.pnl_header.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid2)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_header
            // 
            this.pnl_header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.pnl_header.Controls.Add(this.bunifuImageButton1);
            this.pnl_header.Controls.Add(this.label1);
            this.pnl_header.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_header.Location = new System.Drawing.Point(0, 0);
            this.pnl_header.Name = "pnl_header";
            this.pnl_header.Size = new System.Drawing.Size(1300, 56);
            this.pnl_header.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(494, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Informations sur le conflit";
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuImageButton1.Image = global::MediationDB.Properties.Resources.Fermer_window;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(1242, 5);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(46, 40);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuImageButton1.TabIndex = 4;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.Color.White;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 17;
            this.listBox1.Location = new System.Drawing.Point(30, 112);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(217, 272);
            this.listBox1.TabIndex = 29;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // txt_id_localite
            // 
            this.txt_id_localite.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_id_localite.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_id_localite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.txt_id_localite.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.txt_id_localite.HintText = "Recherchez une localité";
            this.txt_id_localite.isPassword = false;
            this.txt_id_localite.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.txt_id_localite.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.txt_id_localite.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.txt_id_localite.LineThickness = 4;
            this.txt_id_localite.Location = new System.Drawing.Point(30, 67);
            this.txt_id_localite.Margin = new System.Windows.Forms.Padding(4);
            this.txt_id_localite.Name = "txt_id_localite";
            this.txt_id_localite.Size = new System.Drawing.Size(213, 44);
            this.txt_id_localite.TabIndex = 30;
            this.txt_id_localite.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_id_localite.OnValueChanged += new System.EventHandler(this.txt_id_localite_OnValueChanged);
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
            this.bunifuCustomDataGrid2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bunifuCustomDataGrid2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.bunifuCustomDataGrid2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuCustomDataGrid2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuCustomDataGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid2.ColumnHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.bunifuCustomDataGrid2.Location = new System.Drawing.Point(0, 385);
            this.bunifuCustomDataGrid2.Name = "bunifuCustomDataGrid2";
            this.bunifuCustomDataGrid2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.bunifuCustomDataGrid2.Size = new System.Drawing.Size(1300, 280);
            this.bunifuCustomDataGrid2.TabIndex = 52;
            this.bunifuCustomDataGrid2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuCustomDataGrid2_CellContentClick);
            // 
            // txt_num_conflit
            // 
            this.txt_num_conflit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_num_conflit.Enabled = false;
            this.txt_num_conflit.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_num_conflit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.txt_num_conflit.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_num_conflit.HintText = "Num. cnft";
            this.txt_num_conflit.isPassword = false;
            this.txt_num_conflit.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.txt_num_conflit.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.txt_num_conflit.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.txt_num_conflit.LineThickness = 4;
            this.txt_num_conflit.Location = new System.Drawing.Point(581, 67);
            this.txt_num_conflit.Margin = new System.Windows.Forms.Padding(4);
            this.txt_num_conflit.Name = "txt_num_conflit";
            this.txt_num_conflit.Size = new System.Drawing.Size(319, 44);
            this.txt_num_conflit.TabIndex = 54;
            this.txt_num_conflit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_localite
            // 
            this.txt_localite.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_localite.Enabled = false;
            this.txt_localite.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_localite.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.txt_localite.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_localite.HintText = "Localite ou se trouve le conflit";
            this.txt_localite.isPassword = false;
            this.txt_localite.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.txt_localite.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.txt_localite.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.txt_localite.LineThickness = 4;
            this.txt_localite.Location = new System.Drawing.Point(254, 67);
            this.txt_localite.Margin = new System.Windows.Forms.Padding(4);
            this.txt_localite.Name = "txt_localite";
            this.txt_localite.Size = new System.Drawing.Size(319, 44);
            this.txt_localite.TabIndex = 53;
            this.txt_localite.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // metroDateTime1
            // 
            this.metroDateTime1.Location = new System.Drawing.Point(284, 154);
            this.metroDateTime1.MinimumSize = new System.Drawing.Size(0, 29);
            this.metroDateTime1.Name = "metroDateTime1";
            this.metroDateTime1.Size = new System.Drawing.Size(289, 29);
            this.metroDateTime1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroDateTime1.TabIndex = 67;
            this.metroDateTime1.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // btn_mediation
            // 
            this.btn_mediation.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.btn_mediation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_mediation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_mediation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_mediation.BorderRadius = 0;
            this.btn_mediation.ButtonText = "Mediation";
            this.btn_mediation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_mediation.DisabledColor = System.Drawing.Color.Gray;
            this.btn_mediation.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mediation.ForeColor = System.Drawing.Color.White;
            this.btn_mediation.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_mediation.Iconimage = global::MediationDB.Properties.Resources.idea_sharing_80px;
            this.btn_mediation.Iconimage_right = null;
            this.btn_mediation.Iconimage_right_Selected = null;
            this.btn_mediation.Iconimage_Selected = null;
            this.btn_mediation.IconMarginLeft = 0;
            this.btn_mediation.IconMarginRight = 0;
            this.btn_mediation.IconRightVisible = true;
            this.btn_mediation.IconRightZoom = 0D;
            this.btn_mediation.IconVisible = true;
            this.btn_mediation.IconZoom = 70D;
            this.btn_mediation.IsTab = true;
            this.btn_mediation.Location = new System.Drawing.Point(988, 250);
            this.btn_mediation.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btn_mediation.Name = "btn_mediation";
            this.btn_mediation.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_mediation.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.btn_mediation.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_mediation.selected = false;
            this.btn_mediation.Size = new System.Drawing.Size(287, 38);
            this.btn_mediation.TabIndex = 66;
            this.btn_mediation.Text = "Mediation";
            this.btn_mediation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_mediation.Textcolor = System.Drawing.Color.White;
            this.btn_mediation.TextFont = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mediation.Click += new System.EventHandler(this.btn_mediation_Click);
            // 
            // btn_objets
            // 
            this.btn_objets.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.btn_objets.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_objets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_objets.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_objets.BorderRadius = 0;
            this.btn_objets.ButtonText = "Objets du conflit";
            this.btn_objets.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_objets.DisabledColor = System.Drawing.Color.Gray;
            this.btn_objets.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_objets.ForeColor = System.Drawing.Color.White;
            this.btn_objets.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_objets.Iconimage = global::MediationDB.Properties.Resources.new_slide_80px;
            this.btn_objets.Iconimage_right = null;
            this.btn_objets.Iconimage_right_Selected = null;
            this.btn_objets.Iconimage_Selected = null;
            this.btn_objets.IconMarginLeft = 0;
            this.btn_objets.IconMarginRight = 0;
            this.btn_objets.IconRightVisible = true;
            this.btn_objets.IconRightZoom = 0D;
            this.btn_objets.IconVisible = true;
            this.btn_objets.IconZoom = 70D;
            this.btn_objets.IsTab = true;
            this.btn_objets.Location = new System.Drawing.Point(988, 208);
            this.btn_objets.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btn_objets.Name = "btn_objets";
            this.btn_objets.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_objets.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.btn_objets.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_objets.selected = false;
            this.btn_objets.Size = new System.Drawing.Size(287, 38);
            this.btn_objets.TabIndex = 65;
            this.btn_objets.Text = "Objets du conflit";
            this.btn_objets.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_objets.Textcolor = System.Drawing.Color.White;
            this.btn_objets.TextFont = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn_causes
            // 
            this.btn_causes.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.btn_causes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_causes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_causes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_causes.BorderRadius = 0;
            this.btn_causes.ButtonText = "Causes du conflit";
            this.btn_causes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_causes.DisabledColor = System.Drawing.Color.Gray;
            this.btn_causes.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_causes.ForeColor = System.Drawing.Color.White;
            this.btn_causes.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_causes.Iconimage = global::MediationDB.Properties.Resources.speaker_notes_80px;
            this.btn_causes.Iconimage_right = null;
            this.btn_causes.Iconimage_right_Selected = null;
            this.btn_causes.Iconimage_Selected = null;
            this.btn_causes.IconMarginLeft = 0;
            this.btn_causes.IconMarginRight = 0;
            this.btn_causes.IconRightVisible = true;
            this.btn_causes.IconRightZoom = 0D;
            this.btn_causes.IconVisible = true;
            this.btn_causes.IconZoom = 70D;
            this.btn_causes.IsTab = true;
            this.btn_causes.Location = new System.Drawing.Point(988, 166);
            this.btn_causes.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btn_causes.Name = "btn_causes";
            this.btn_causes.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_causes.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.btn_causes.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_causes.selected = false;
            this.btn_causes.Size = new System.Drawing.Size(287, 38);
            this.btn_causes.TabIndex = 64;
            this.btn_causes.Text = "Causes du conflit";
            this.btn_causes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_causes.Textcolor = System.Drawing.Color.White;
            this.btn_causes.TextFont = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn_details
            // 
            this.btn_details.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.btn_details.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_details.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_details.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_details.BorderRadius = 0;
            this.btn_details.ButtonText = "Description de faits";
            this.btn_details.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_details.DisabledColor = System.Drawing.Color.Gray;
            this.btn_details.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_details.ForeColor = System.Drawing.Color.White;
            this.btn_details.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_details.Iconimage = global::MediationDB.Properties.Resources.edit_property_80px;
            this.btn_details.Iconimage_right = null;
            this.btn_details.Iconimage_right_Selected = null;
            this.btn_details.Iconimage_Selected = null;
            this.btn_details.IconMarginLeft = 0;
            this.btn_details.IconMarginRight = 0;
            this.btn_details.IconRightVisible = true;
            this.btn_details.IconRightZoom = 0D;
            this.btn_details.IconVisible = true;
            this.btn_details.IconZoom = 70D;
            this.btn_details.IsTab = true;
            this.btn_details.Location = new System.Drawing.Point(988, 124);
            this.btn_details.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btn_details.Name = "btn_details";
            this.btn_details.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_details.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.btn_details.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_details.selected = false;
            this.btn_details.Size = new System.Drawing.Size(287, 38);
            this.btn_details.TabIndex = 63;
            this.btn_details.Text = "Description de faits";
            this.btn_details.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_details.Textcolor = System.Drawing.Color.White;
            this.btn_details.TextFont = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_details.Click += new System.EventHandler(this.btn_details_Click);
            // 
            // btn_parties
            // 
            this.btn_parties.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.btn_parties.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_parties.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_parties.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_parties.BorderRadius = 0;
            this.btn_parties.ButtonText = "Parties au conflit";
            this.btn_parties.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_parties.DisabledColor = System.Drawing.Color.Gray;
            this.btn_parties.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_parties.ForeColor = System.Drawing.Color.White;
            this.btn_parties.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_parties.Iconimage = global::MediationDB.Properties.Resources.strike_80px1;
            this.btn_parties.Iconimage_right = null;
            this.btn_parties.Iconimage_right_Selected = null;
            this.btn_parties.Iconimage_Selected = null;
            this.btn_parties.IconMarginLeft = 0;
            this.btn_parties.IconMarginRight = 0;
            this.btn_parties.IconRightVisible = true;
            this.btn_parties.IconRightZoom = 0D;
            this.btn_parties.IconVisible = true;
            this.btn_parties.IconZoom = 70D;
            this.btn_parties.IsTab = true;
            this.btn_parties.Location = new System.Drawing.Point(988, 292);
            this.btn_parties.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btn_parties.Name = "btn_parties";
            this.btn_parties.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_parties.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.btn_parties.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_parties.selected = false;
            this.btn_parties.Size = new System.Drawing.Size(287, 38);
            this.btn_parties.TabIndex = 62;
            this.btn_parties.Text = "Parties au conflit";
            this.btn_parties.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_parties.Textcolor = System.Drawing.Color.White;
            this.btn_parties.TextFont = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.label4.Location = new System.Drawing.Point(253, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 17);
            this.label4.TabIndex = 61;
            this.label4.Text = "Nature de conflit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.label3.Location = new System.Drawing.Point(578, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 17);
            this.label3.TabIndex = 60;
            this.label3.Text = "Type de conflit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.label2.Location = new System.Drawing.Point(253, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 17);
            this.label2.TabIndex = 55;
            this.label2.Text = "Date de debut deu conflit";
            // 
            // btn_supprimer
            // 
            this.btn_supprimer.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.btn_supprimer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_supprimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
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
            this.btn_supprimer.IconZoom = 50D;
            this.btn_supprimer.IsTab = true;
            this.btn_supprimer.Location = new System.Drawing.Point(722, 294);
            this.btn_supprimer.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btn_supprimer.Name = "btn_supprimer";
            this.btn_supprimer.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.btn_supprimer.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_supprimer.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.btn_supprimer.selected = false;
            this.btn_supprimer.Size = new System.Drawing.Size(178, 36);
            this.btn_supprimer.TabIndex = 59;
            this.btn_supprimer.Text = "     Supprimer";
            this.btn_supprimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_supprimer.Textcolor = System.Drawing.Color.White;
            this.btn_supprimer.TextFont = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_supprimer.Click += new System.EventHandler(this.btn_supprimer_Click);
            // 
            // btn_enregistrer
            // 
            this.btn_enregistrer.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.btn_enregistrer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_enregistrer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
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
            this.btn_enregistrer.IconZoom = 50D;
            this.btn_enregistrer.IsTab = true;
            this.btn_enregistrer.Location = new System.Drawing.Point(512, 294);
            this.btn_enregistrer.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btn_enregistrer.Name = "btn_enregistrer";
            this.btn_enregistrer.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.btn_enregistrer.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_enregistrer.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.btn_enregistrer.selected = false;
            this.btn_enregistrer.Size = new System.Drawing.Size(200, 38);
            this.btn_enregistrer.TabIndex = 58;
            this.btn_enregistrer.Text = "     Enregistrer";
            this.btn_enregistrer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_enregistrer.Textcolor = System.Drawing.Color.White;
            this.btn_enregistrer.TextFont = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enregistrer.Click += new System.EventHandler(this.btn_enregistrer_Click);
            // 
            // cbx_nature_conflit
            // 
            this.cbx_nature_conflit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.cbx_nature_conflit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbx_nature_conflit.ForeColor = System.Drawing.Color.White;
            this.cbx_nature_conflit.FormattingEnabled = true;
            this.cbx_nature_conflit.ItemHeight = 23;
            this.cbx_nature_conflit.Location = new System.Drawing.Point(284, 222);
            this.cbx_nature_conflit.Name = "cbx_nature_conflit";
            this.cbx_nature_conflit.PromptText = "Choisissez la nature du conflit";
            this.cbx_nature_conflit.Size = new System.Drawing.Size(289, 29);
            this.cbx_nature_conflit.Style = MetroFramework.MetroColorStyle.Blue;
            this.cbx_nature_conflit.TabIndex = 57;
            this.cbx_nature_conflit.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cbx_nature_conflit.UseSelectable = true;
            // 
            // cbx_type_conflit
            // 
            this.cbx_type_conflit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.cbx_type_conflit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbx_type_conflit.ForeColor = System.Drawing.Color.White;
            this.cbx_type_conflit.FormattingEnabled = true;
            this.cbx_type_conflit.ItemHeight = 23;
            this.cbx_type_conflit.Location = new System.Drawing.Point(611, 154);
            this.cbx_type_conflit.Name = "cbx_type_conflit";
            this.cbx_type_conflit.PromptText = "Choisissez le type de conflit";
            this.cbx_type_conflit.Size = new System.Drawing.Size(289, 29);
            this.cbx_type_conflit.Style = MetroFramework.MetroColorStyle.Blue;
            this.cbx_type_conflit.TabIndex = 56;
            this.cbx_type_conflit.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cbx_type_conflit.UseSelectable = true;
            // 
            // frm_conflit
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1300, 665);
            this.Controls.Add(this.metroDateTime1);
            this.Controls.Add(this.btn_mediation);
            this.Controls.Add(this.btn_objets);
            this.Controls.Add(this.btn_causes);
            this.Controls.Add(this.btn_details);
            this.Controls.Add(this.btn_parties);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_supprimer);
            this.Controls.Add(this.btn_enregistrer);
            this.Controls.Add(this.cbx_nature_conflit);
            this.Controls.Add(this.cbx_type_conflit);
            this.Controls.Add(this.txt_num_conflit);
            this.Controls.Add(this.txt_localite);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.txt_id_localite);
            this.Controls.Add(this.pnl_header);
            this.Controls.Add(this.bunifuCustomDataGrid2);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "frm_conflit";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_conflit";
            this.pnl_header.ResumeLayout(false);
            this.pnl_header.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_header;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.ListBox listBox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_id_localite;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_num_conflit;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_localite;
        private MetroFramework.Controls.MetroDateTime metroDateTime1;
        private Bunifu.Framework.UI.BunifuFlatButton btn_mediation;
        private Bunifu.Framework.UI.BunifuFlatButton btn_objets;
        private Bunifu.Framework.UI.BunifuFlatButton btn_causes;
        private Bunifu.Framework.UI.BunifuFlatButton btn_details;
        private Bunifu.Framework.UI.BunifuFlatButton btn_parties;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuFlatButton btn_supprimer;
        private Bunifu.Framework.UI.BunifuFlatButton btn_enregistrer;
        private MetroFramework.Controls.MetroComboBox cbx_nature_conflit;
        private MetroFramework.Controls.MetroComboBox cbx_type_conflit;
    }
}