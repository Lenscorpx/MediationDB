namespace MediationDB.FormLibrary
{
    partial class frm_organisation_atelier
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomDataGrid2 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.txt_num_participation = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_num_sensibilisation = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_noms_sensibilisateur = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_lieu_organisation = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_theme_descr = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.date_participation = new MetroFramework.Controls.MetroDateTime();
            this.cbx_themes = new MetroFramework.Controls.MetroComboBox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(315, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(602, 36);
            this.label1.TabIndex = 4;
            this.label1.Text = "Informations sur l\'organisation des ateliers";
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuImageButton1.Image = global::MediationDB.Properties.Resources.Fermer_window;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(1242, 12);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(46, 40);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuImageButton1.TabIndex = 5;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // bunifuCustomDataGrid2
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.bunifuCustomDataGrid2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bunifuCustomDataGrid2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.bunifuCustomDataGrid2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuCustomDataGrid2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuCustomDataGrid2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.bunifuCustomDataGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuCustomDataGrid2.ColumnHeadersVisible = false;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid2.DefaultCellStyle = dataGridViewCellStyle8;
            this.bunifuCustomDataGrid2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bunifuCustomDataGrid2.DoubleBuffered = true;
            this.bunifuCustomDataGrid2.EnableHeadersVisualStyles = false;
            this.bunifuCustomDataGrid2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuCustomDataGrid2.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuCustomDataGrid2.HeaderForeColor = System.Drawing.Color.White;
            this.bunifuCustomDataGrid2.Location = new System.Drawing.Point(0, 337);
            this.bunifuCustomDataGrid2.Name = "bunifuCustomDataGrid2";
            this.bunifuCustomDataGrid2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid2.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid2.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.bunifuCustomDataGrid2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bunifuCustomDataGrid2.Size = new System.Drawing.Size(1300, 377);
            this.bunifuCustomDataGrid2.TabIndex = 73;
            // 
            // txt_num_participation
            // 
            this.txt_num_participation.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_num_participation.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_num_participation.ForeColor = System.Drawing.Color.White;
            this.txt_num_participation.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_num_participation.HintText = "Entrez l\'ID Participation";
            this.txt_num_participation.isPassword = false;
            this.txt_num_participation.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.txt_num_participation.LineIdleColor = System.Drawing.Color.White;
            this.txt_num_participation.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.txt_num_participation.LineThickness = 2;
            this.txt_num_participation.Location = new System.Drawing.Point(36, 139);
            this.txt_num_participation.Margin = new System.Windows.Forms.Padding(4);
            this.txt_num_participation.Name = "txt_num_participation";
            this.txt_num_participation.Size = new System.Drawing.Size(279, 44);
            this.txt_num_participation.TabIndex = 74;
            this.txt_num_participation.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_num_sensibilisation
            // 
            this.txt_num_sensibilisation.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_num_sensibilisation.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_num_sensibilisation.ForeColor = System.Drawing.Color.White;
            this.txt_num_sensibilisation.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_num_sensibilisation.HintText = "Entrez le numero de sensibilisation";
            this.txt_num_sensibilisation.isPassword = false;
            this.txt_num_sensibilisation.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.txt_num_sensibilisation.LineIdleColor = System.Drawing.Color.White;
            this.txt_num_sensibilisation.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.txt_num_sensibilisation.LineThickness = 2;
            this.txt_num_sensibilisation.Location = new System.Drawing.Point(36, 191);
            this.txt_num_sensibilisation.Margin = new System.Windows.Forms.Padding(4);
            this.txt_num_sensibilisation.Name = "txt_num_sensibilisation";
            this.txt_num_sensibilisation.Size = new System.Drawing.Size(279, 44);
            this.txt_num_sensibilisation.TabIndex = 75;
            this.txt_num_sensibilisation.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_noms_sensibilisateur
            // 
            this.txt_noms_sensibilisateur.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_noms_sensibilisateur.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_noms_sensibilisateur.ForeColor = System.Drawing.Color.White;
            this.txt_noms_sensibilisateur.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_noms_sensibilisateur.HintText = "Entrez le nom du sensibilisateur";
            this.txt_noms_sensibilisateur.isPassword = false;
            this.txt_noms_sensibilisateur.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.txt_noms_sensibilisateur.LineIdleColor = System.Drawing.Color.White;
            this.txt_noms_sensibilisateur.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.txt_noms_sensibilisateur.LineThickness = 2;
            this.txt_noms_sensibilisateur.Location = new System.Drawing.Point(394, 190);
            this.txt_noms_sensibilisateur.Margin = new System.Windows.Forms.Padding(4);
            this.txt_noms_sensibilisateur.Name = "txt_noms_sensibilisateur";
            this.txt_noms_sensibilisateur.Size = new System.Drawing.Size(520, 44);
            this.txt_noms_sensibilisateur.TabIndex = 76;
            this.txt_noms_sensibilisateur.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_lieu_organisation
            // 
            this.txt_lieu_organisation.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_lieu_organisation.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_lieu_organisation.ForeColor = System.Drawing.Color.White;
            this.txt_lieu_organisation.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_lieu_organisation.HintText = "Entrez le lieu d\'organisation";
            this.txt_lieu_organisation.isPassword = false;
            this.txt_lieu_organisation.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.txt_lieu_organisation.LineIdleColor = System.Drawing.Color.White;
            this.txt_lieu_organisation.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.txt_lieu_organisation.LineThickness = 2;
            this.txt_lieu_organisation.Location = new System.Drawing.Point(922, 191);
            this.txt_lieu_organisation.Margin = new System.Windows.Forms.Padding(4);
            this.txt_lieu_organisation.Name = "txt_lieu_organisation";
            this.txt_lieu_organisation.Size = new System.Drawing.Size(297, 44);
            this.txt_lieu_organisation.TabIndex = 77;
            this.txt_lieu_organisation.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_theme_descr
            // 
            this.txt_theme_descr.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_theme_descr.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_theme_descr.ForeColor = System.Drawing.Color.White;
            this.txt_theme_descr.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_theme_descr.HintText = "Thème developpé";
            this.txt_theme_descr.isPassword = false;
            this.txt_theme_descr.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.txt_theme_descr.LineIdleColor = System.Drawing.Color.White;
            this.txt_theme_descr.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.txt_theme_descr.LineThickness = 2;
            this.txt_theme_descr.Location = new System.Drawing.Point(394, 138);
            this.txt_theme_descr.Margin = new System.Windows.Forms.Padding(4);
            this.txt_theme_descr.Name = "txt_theme_descr";
            this.txt_theme_descr.Size = new System.Drawing.Size(825, 44);
            this.txt_theme_descr.TabIndex = 78;
            this.txt_theme_descr.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // date_participation
            // 
            this.date_participation.Location = new System.Drawing.Point(36, 102);
            this.date_participation.MinimumSize = new System.Drawing.Size(0, 29);
            this.date_participation.Name = "date_participation";
            this.date_participation.Size = new System.Drawing.Size(279, 29);
            this.date_participation.Style = MetroFramework.MetroColorStyle.Blue;
            this.date_participation.TabIndex = 79;
            this.date_participation.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // cbx_themes
            // 
            this.cbx_themes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.cbx_themes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbx_themes.ForeColor = System.Drawing.Color.White;
            this.cbx_themes.FormattingEnabled = true;
            this.cbx_themes.ItemHeight = 23;
            this.cbx_themes.Location = new System.Drawing.Point(394, 102);
            this.cbx_themes.Name = "cbx_themes";
            this.cbx_themes.PromptText = "Choisissez le theme de l\'atelier";
            this.cbx_themes.Size = new System.Drawing.Size(311, 29);
            this.cbx_themes.Style = MetroFramework.MetroColorStyle.Blue;
            this.cbx_themes.TabIndex = 80;
            this.cbx_themes.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cbx_themes.UseSelectable = true;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // frm_organisation_atelier
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(1300, 714);
            this.Controls.Add(this.cbx_themes);
            this.Controls.Add(this.date_participation);
            this.Controls.Add(this.txt_theme_descr);
            this.Controls.Add(this.txt_lieu_organisation);
            this.Controls.Add(this.txt_noms_sensibilisateur);
            this.Controls.Add(this.txt_num_sensibilisation);
            this.Controls.Add(this.txt_num_participation);
            this.Controls.Add(this.bunifuCustomDataGrid2);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_organisation_atelier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_num_participation;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_num_sensibilisation;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_noms_sensibilisateur;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_lieu_organisation;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_theme_descr;
        private MetroFramework.Controls.MetroDateTime date_participation;
        private MetroFramework.Controls.MetroComboBox cbx_themes;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}