namespace MediationDB.FormLibrary
{
    partial class frm_search_ateliers
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
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_id_localite = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.txt_theme = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.dt_debut = new MetroFramework.Controls.MetroDateTime();
            this.label2 = new System.Windows.Forms.Label();
            this.dt_fin = new MetroFramework.Controls.MetroDateTime();
            this.btn_rechercher = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
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
            this.bunifuImageButton1.TabIndex = 2;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(452, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(390, 36);
            this.label1.TabIndex = 3;
            this.label1.Text = "Informations sur les ateliers";
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
            this.txt_id_localite.LineThickness = 2;
            this.txt_id_localite.Location = new System.Drawing.Point(50, 94);
            this.txt_id_localite.Margin = new System.Windows.Forms.Padding(4);
            this.txt_id_localite.Name = "txt_id_localite";
            this.txt_id_localite.Size = new System.Drawing.Size(223, 44);
            this.txt_id_localite.TabIndex = 31;
            this.txt_id_localite.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // txt_theme
            // 
            this.txt_theme.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_theme.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_theme.ForeColor = System.Drawing.Color.White;
            this.txt_theme.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_theme.HintText = "Recherchez par thème";
            this.txt_theme.isPassword = false;
            this.txt_theme.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.txt_theme.LineIdleColor = System.Drawing.Color.White;
            this.txt_theme.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.txt_theme.LineThickness = 2;
            this.txt_theme.Location = new System.Drawing.Point(312, 94);
            this.txt_theme.Margin = new System.Windows.Forms.Padding(4);
            this.txt_theme.Name = "txt_theme";
            this.txt_theme.Size = new System.Drawing.Size(223, 44);
            this.txt_theme.TabIndex = 32;
            this.txt_theme.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // dt_debut
            // 
            this.dt_debut.Location = new System.Drawing.Point(591, 109);
            this.dt_debut.MinimumSize = new System.Drawing.Size(0, 29);
            this.dt_debut.Name = "dt_debut";
            this.dt_debut.Size = new System.Drawing.Size(236, 29);
            this.dt_debut.Style = MetroFramework.MetroColorStyle.Blue;
            this.dt_debut.TabIndex = 69;
            this.dt_debut.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(550, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(168, 17);
            this.label2.TabIndex = 68;
            this.label2.Text = "Rechercher entre 2 dates";
            // 
            // dt_fin
            // 
            this.dt_fin.Location = new System.Drawing.Point(842, 109);
            this.dt_fin.MinimumSize = new System.Drawing.Size(0, 29);
            this.dt_fin.Name = "dt_fin";
            this.dt_fin.Size = new System.Drawing.Size(236, 29);
            this.dt_fin.Style = MetroFramework.MetroColorStyle.Blue;
            this.dt_fin.TabIndex = 70;
            this.dt_fin.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // btn_rechercher
            // 
            this.btn_rechercher.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.btn_rechercher.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_rechercher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.btn_rechercher.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_rechercher.BorderRadius = 0;
            this.btn_rechercher.ButtonText = "     Rechercher";
            this.btn_rechercher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_rechercher.DisabledColor = System.Drawing.Color.Gray;
            this.btn_rechercher.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rechercher.ForeColor = System.Drawing.Color.White;
            this.btn_rechercher.Iconcolor = System.Drawing.Color.Transparent;
            this.btn_rechercher.Iconimage = global::MediationDB.Properties.Resources.add_96px;
            this.btn_rechercher.Iconimage_right = null;
            this.btn_rechercher.Iconimage_right_Selected = null;
            this.btn_rechercher.Iconimage_Selected = null;
            this.btn_rechercher.IconMarginLeft = 0;
            this.btn_rechercher.IconMarginRight = 0;
            this.btn_rechercher.IconRightVisible = true;
            this.btn_rechercher.IconRightZoom = 0D;
            this.btn_rechercher.IconVisible = true;
            this.btn_rechercher.IconZoom = 50D;
            this.btn_rechercher.IsTab = true;
            this.btn_rechercher.Location = new System.Drawing.Point(1099, 100);
            this.btn_rechercher.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btn_rechercher.Name = "btn_rechercher";
            this.btn_rechercher.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.btn_rechercher.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_rechercher.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_rechercher.selected = false;
            this.btn_rechercher.Size = new System.Drawing.Size(169, 40);
            this.btn_rechercher.TabIndex = 71;
            this.btn_rechercher.Text = "     Rechercher";
            this.btn_rechercher.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_rechercher.Textcolor = System.Drawing.Color.White;
            this.btn_rechercher.TextFont = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // frm_search_ateliers
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(1300, 597);
            this.Controls.Add(this.btn_rechercher);
            this.Controls.Add(this.dt_fin);
            this.Controls.Add(this.dt_debut);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_theme);
            this.Controls.Add(this.txt_id_localite);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunifuImageButton1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "frm_search_ateliers";
            this.Opacity = 0.97D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_id_localite;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_theme;
        private MetroFramework.Controls.MetroDateTime dt_fin;
        private MetroFramework.Controls.MetroDateTime dt_debut;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuFlatButton btn_rechercher;
    }
}