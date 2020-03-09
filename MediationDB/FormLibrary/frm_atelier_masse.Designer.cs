namespace MediationDB.FormLibrary
{
    partial class frm_atelier_masse
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
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuCustomDataGrid2 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.txt_code_sensibilisation = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.dt_debut_sensibilisations = new MetroFramework.Controls.MetroDateTime();
            this.txt_filles = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_garcons = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_hommes = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_femmes = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_menages_rap = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_menages_locaux = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_menages_depl = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_menages_retournes = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_autorite_homme = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_autorite_femme = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_num_atelier = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_noms_sensibilisateurs = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_telephone = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_themes = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_observation = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txt_commentaires = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.btn_enregistrer = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn_supprimer = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(378, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(545, 36);
            this.label1.TabIndex = 142;
            this.label1.Text = "Informations sur les ateliers de masses";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
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
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuCustomDataGrid2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.bunifuCustomDataGrid2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.bunifuCustomDataGrid2.Location = new System.Drawing.Point(0, 312);
            this.bunifuCustomDataGrid2.Name = "bunifuCustomDataGrid2";
            this.bunifuCustomDataGrid2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.bunifuCustomDataGrid2.Size = new System.Drawing.Size(1300, 402);
            this.bunifuCustomDataGrid2.TabIndex = 156;
            this.bunifuCustomDataGrid2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuCustomDataGrid2_CellContentClick);
            // 
            // txt_code_sensibilisation
            // 
            this.txt_code_sensibilisation.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_code_sensibilisation.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_code_sensibilisation.ForeColor = System.Drawing.Color.White;
            this.txt_code_sensibilisation.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_code_sensibilisation.HintText = "Code Sensibilisation";
            this.txt_code_sensibilisation.isPassword = false;
            this.txt_code_sensibilisation.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.txt_code_sensibilisation.LineIdleColor = System.Drawing.Color.White;
            this.txt_code_sensibilisation.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.txt_code_sensibilisation.LineThickness = 1;
            this.txt_code_sensibilisation.Location = new System.Drawing.Point(205, 53);
            this.txt_code_sensibilisation.Margin = new System.Windows.Forms.Padding(4);
            this.txt_code_sensibilisation.Name = "txt_code_sensibilisation";
            this.txt_code_sensibilisation.Size = new System.Drawing.Size(205, 44);
            this.txt_code_sensibilisation.TabIndex = 145;
            this.txt_code_sensibilisation.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_code_sensibilisation.OnValueChanged += new System.EventHandler(this.txt_code_sensibilisation_OnValueChanged);
            // 
            // dt_debut_sensibilisations
            // 
            this.dt_debut_sensibilisations.Location = new System.Drawing.Point(983, 68);
            this.dt_debut_sensibilisations.MinimumSize = new System.Drawing.Size(0, 29);
            this.dt_debut_sensibilisations.Name = "dt_debut_sensibilisations";
            this.dt_debut_sensibilisations.Size = new System.Drawing.Size(287, 29);
            this.dt_debut_sensibilisations.Style = MetroFramework.MetroColorStyle.Blue;
            this.dt_debut_sensibilisations.TabIndex = 144;
            this.dt_debut_sensibilisations.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // txt_filles
            // 
            this.txt_filles.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_filles.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_filles.ForeColor = System.Drawing.Color.White;
            this.txt_filles.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_filles.HintText = "Nombres de filles";
            this.txt_filles.isPassword = false;
            this.txt_filles.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.txt_filles.LineIdleColor = System.Drawing.Color.White;
            this.txt_filles.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.txt_filles.LineThickness = 1;
            this.txt_filles.Location = new System.Drawing.Point(745, 157);
            this.txt_filles.Margin = new System.Windows.Forms.Padding(4);
            this.txt_filles.Name = "txt_filles";
            this.txt_filles.Size = new System.Drawing.Size(232, 44);
            this.txt_filles.TabIndex = 160;
            this.txt_filles.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_garcons
            // 
            this.txt_garcons.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_garcons.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_garcons.ForeColor = System.Drawing.Color.White;
            this.txt_garcons.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_garcons.HintText = "Nombres de garcons";
            this.txt_garcons.isPassword = false;
            this.txt_garcons.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.txt_garcons.LineIdleColor = System.Drawing.Color.White;
            this.txt_garcons.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.txt_garcons.LineThickness = 1;
            this.txt_garcons.Location = new System.Drawing.Point(505, 157);
            this.txt_garcons.Margin = new System.Windows.Forms.Padding(4);
            this.txt_garcons.Name = "txt_garcons";
            this.txt_garcons.Size = new System.Drawing.Size(232, 44);
            this.txt_garcons.TabIndex = 159;
            this.txt_garcons.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_hommes
            // 
            this.txt_hommes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_hommes.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_hommes.ForeColor = System.Drawing.Color.White;
            this.txt_hommes.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_hommes.HintText = "Nombre d\'hommes";
            this.txt_hommes.isPassword = false;
            this.txt_hommes.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.txt_hommes.LineIdleColor = System.Drawing.Color.White;
            this.txt_hommes.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.txt_hommes.LineThickness = 1;
            this.txt_hommes.Location = new System.Drawing.Point(25, 157);
            this.txt_hommes.Margin = new System.Windows.Forms.Padding(4);
            this.txt_hommes.Name = "txt_hommes";
            this.txt_hommes.Size = new System.Drawing.Size(232, 44);
            this.txt_hommes.TabIndex = 158;
            this.txt_hommes.Text = "Nombres d\'hommes";
            this.txt_hommes.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_femmes
            // 
            this.txt_femmes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_femmes.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_femmes.ForeColor = System.Drawing.Color.White;
            this.txt_femmes.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_femmes.HintText = "Nombres de femmes";
            this.txt_femmes.isPassword = false;
            this.txt_femmes.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.txt_femmes.LineIdleColor = System.Drawing.Color.White;
            this.txt_femmes.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.txt_femmes.LineThickness = 1;
            this.txt_femmes.Location = new System.Drawing.Point(265, 157);
            this.txt_femmes.Margin = new System.Windows.Forms.Padding(4);
            this.txt_femmes.Name = "txt_femmes";
            this.txt_femmes.Size = new System.Drawing.Size(232, 44);
            this.txt_femmes.TabIndex = 157;
            this.txt_femmes.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_menages_rap
            // 
            this.txt_menages_rap.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_menages_rap.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_menages_rap.ForeColor = System.Drawing.Color.White;
            this.txt_menages_rap.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_menages_rap.HintText = "Menages Rappatriés";
            this.txt_menages_rap.isPassword = false;
            this.txt_menages_rap.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.txt_menages_rap.LineIdleColor = System.Drawing.Color.White;
            this.txt_menages_rap.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.txt_menages_rap.LineThickness = 1;
            this.txt_menages_rap.Location = new System.Drawing.Point(745, 209);
            this.txt_menages_rap.Margin = new System.Windows.Forms.Padding(4);
            this.txt_menages_rap.Name = "txt_menages_rap";
            this.txt_menages_rap.Size = new System.Drawing.Size(232, 44);
            this.txt_menages_rap.TabIndex = 164;
            this.txt_menages_rap.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_menages_locaux
            // 
            this.txt_menages_locaux.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_menages_locaux.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_menages_locaux.ForeColor = System.Drawing.Color.White;
            this.txt_menages_locaux.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_menages_locaux.HintText = "Menages Locaux";
            this.txt_menages_locaux.isPassword = false;
            this.txt_menages_locaux.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.txt_menages_locaux.LineIdleColor = System.Drawing.Color.White;
            this.txt_menages_locaux.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.txt_menages_locaux.LineThickness = 1;
            this.txt_menages_locaux.Location = new System.Drawing.Point(505, 209);
            this.txt_menages_locaux.Margin = new System.Windows.Forms.Padding(4);
            this.txt_menages_locaux.Name = "txt_menages_locaux";
            this.txt_menages_locaux.Size = new System.Drawing.Size(232, 44);
            this.txt_menages_locaux.TabIndex = 163;
            this.txt_menages_locaux.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_menages_depl
            // 
            this.txt_menages_depl.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_menages_depl.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_menages_depl.ForeColor = System.Drawing.Color.White;
            this.txt_menages_depl.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_menages_depl.HintText = "Menages deplacés";
            this.txt_menages_depl.isPassword = false;
            this.txt_menages_depl.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.txt_menages_depl.LineIdleColor = System.Drawing.Color.White;
            this.txt_menages_depl.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.txt_menages_depl.LineThickness = 1;
            this.txt_menages_depl.Location = new System.Drawing.Point(25, 209);
            this.txt_menages_depl.Margin = new System.Windows.Forms.Padding(4);
            this.txt_menages_depl.Name = "txt_menages_depl";
            this.txt_menages_depl.Size = new System.Drawing.Size(232, 44);
            this.txt_menages_depl.TabIndex = 162;
            this.txt_menages_depl.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_menages_retournes
            // 
            this.txt_menages_retournes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_menages_retournes.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_menages_retournes.ForeColor = System.Drawing.Color.White;
            this.txt_menages_retournes.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_menages_retournes.HintText = "Menages Retournés";
            this.txt_menages_retournes.isPassword = false;
            this.txt_menages_retournes.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.txt_menages_retournes.LineIdleColor = System.Drawing.Color.White;
            this.txt_menages_retournes.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.txt_menages_retournes.LineThickness = 1;
            this.txt_menages_retournes.Location = new System.Drawing.Point(265, 209);
            this.txt_menages_retournes.Margin = new System.Windows.Forms.Padding(4);
            this.txt_menages_retournes.Name = "txt_menages_retournes";
            this.txt_menages_retournes.Size = new System.Drawing.Size(232, 44);
            this.txt_menages_retournes.TabIndex = 161;
            this.txt_menages_retournes.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_autorite_homme
            // 
            this.txt_autorite_homme.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_autorite_homme.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_autorite_homme.ForeColor = System.Drawing.Color.White;
            this.txt_autorite_homme.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_autorite_homme.HintText = "Autorité Homme";
            this.txt_autorite_homme.isPassword = false;
            this.txt_autorite_homme.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.txt_autorite_homme.LineIdleColor = System.Drawing.Color.White;
            this.txt_autorite_homme.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.txt_autorite_homme.LineThickness = 1;
            this.txt_autorite_homme.Location = new System.Drawing.Point(998, 157);
            this.txt_autorite_homme.Margin = new System.Windows.Forms.Padding(4);
            this.txt_autorite_homme.Name = "txt_autorite_homme";
            this.txt_autorite_homme.Size = new System.Drawing.Size(272, 44);
            this.txt_autorite_homme.TabIndex = 166;
            this.txt_autorite_homme.Text = "Autorité hommes";
            this.txt_autorite_homme.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_autorite_femme
            // 
            this.txt_autorite_femme.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_autorite_femme.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_autorite_femme.ForeColor = System.Drawing.Color.White;
            this.txt_autorite_femme.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_autorite_femme.HintText = "Autorité Femmes";
            this.txt_autorite_femme.isPassword = false;
            this.txt_autorite_femme.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.txt_autorite_femme.LineIdleColor = System.Drawing.Color.White;
            this.txt_autorite_femme.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.txt_autorite_femme.LineThickness = 1;
            this.txt_autorite_femme.Location = new System.Drawing.Point(998, 209);
            this.txt_autorite_femme.Margin = new System.Windows.Forms.Padding(4);
            this.txt_autorite_femme.Name = "txt_autorite_femme";
            this.txt_autorite_femme.Size = new System.Drawing.Size(272, 44);
            this.txt_autorite_femme.TabIndex = 165;
            this.txt_autorite_femme.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_num_atelier
            // 
            this.txt_num_atelier.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_num_atelier.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_num_atelier.ForeColor = System.Drawing.Color.White;
            this.txt_num_atelier.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_num_atelier.HintText = "Num Ateliers Masse";
            this.txt_num_atelier.isPassword = false;
            this.txt_num_atelier.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.txt_num_atelier.LineIdleColor = System.Drawing.Color.White;
            this.txt_num_atelier.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.txt_num_atelier.LineThickness = 1;
            this.txt_num_atelier.Location = new System.Drawing.Point(29, 53);
            this.txt_num_atelier.Margin = new System.Windows.Forms.Padding(4);
            this.txt_num_atelier.Name = "txt_num_atelier";
            this.txt_num_atelier.Size = new System.Drawing.Size(168, 44);
            this.txt_num_atelier.TabIndex = 169;
            this.txt_num_atelier.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_noms_sensibilisateurs
            // 
            this.txt_noms_sensibilisateurs.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_noms_sensibilisateurs.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_noms_sensibilisateurs.ForeColor = System.Drawing.Color.White;
            this.txt_noms_sensibilisateurs.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_noms_sensibilisateurs.HintText = "Noms du sensibilisateurs";
            this.txt_noms_sensibilisateurs.isPassword = false;
            this.txt_noms_sensibilisateurs.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.txt_noms_sensibilisateurs.LineIdleColor = System.Drawing.Color.White;
            this.txt_noms_sensibilisateurs.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.txt_noms_sensibilisateurs.LineThickness = 1;
            this.txt_noms_sensibilisateurs.Location = new System.Drawing.Point(418, 53);
            this.txt_noms_sensibilisateurs.Margin = new System.Windows.Forms.Padding(4);
            this.txt_noms_sensibilisateurs.Name = "txt_noms_sensibilisateurs";
            this.txt_noms_sensibilisateurs.Size = new System.Drawing.Size(272, 44);
            this.txt_noms_sensibilisateurs.TabIndex = 170;
            this.txt_noms_sensibilisateurs.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_telephone
            // 
            this.txt_telephone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_telephone.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_telephone.ForeColor = System.Drawing.Color.White;
            this.txt_telephone.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_telephone.HintText = "Telephone du sensibilisateur";
            this.txt_telephone.isPassword = false;
            this.txt_telephone.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.txt_telephone.LineIdleColor = System.Drawing.Color.White;
            this.txt_telephone.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.txt_telephone.LineThickness = 1;
            this.txt_telephone.Location = new System.Drawing.Point(700, 53);
            this.txt_telephone.Margin = new System.Windows.Forms.Padding(4);
            this.txt_telephone.Name = "txt_telephone";
            this.txt_telephone.Size = new System.Drawing.Size(272, 44);
            this.txt_telephone.TabIndex = 171;
            this.txt_telephone.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_themes
            // 
            this.txt_themes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_themes.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_themes.ForeColor = System.Drawing.Color.White;
            this.txt_themes.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_themes.HintText = "Thème développé";
            this.txt_themes.isPassword = false;
            this.txt_themes.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.txt_themes.LineIdleColor = System.Drawing.Color.White;
            this.txt_themes.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.txt_themes.LineThickness = 1;
            this.txt_themes.Location = new System.Drawing.Point(29, 105);
            this.txt_themes.Margin = new System.Windows.Forms.Padding(4);
            this.txt_themes.Name = "txt_themes";
            this.txt_themes.Size = new System.Drawing.Size(381, 44);
            this.txt_themes.TabIndex = 172;
            this.txt_themes.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_observation
            // 
            this.txt_observation.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_observation.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_observation.ForeColor = System.Drawing.Color.White;
            this.txt_observation.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_observation.HintText = "Observation";
            this.txt_observation.isPassword = false;
            this.txt_observation.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.txt_observation.LineIdleColor = System.Drawing.Color.White;
            this.txt_observation.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.txt_observation.LineThickness = 1;
            this.txt_observation.Location = new System.Drawing.Point(418, 105);
            this.txt_observation.Margin = new System.Windows.Forms.Padding(4);
            this.txt_observation.Name = "txt_observation";
            this.txt_observation.Size = new System.Drawing.Size(463, 44);
            this.txt_observation.TabIndex = 173;
            this.txt_observation.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_commentaires
            // 
            this.txt_commentaires.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_commentaires.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_commentaires.ForeColor = System.Drawing.Color.White;
            this.txt_commentaires.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txt_commentaires.HintText = "Commentaires";
            this.txt_commentaires.isPassword = false;
            this.txt_commentaires.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.txt_commentaires.LineIdleColor = System.Drawing.Color.White;
            this.txt_commentaires.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.txt_commentaires.LineThickness = 1;
            this.txt_commentaires.Location = new System.Drawing.Point(889, 105);
            this.txt_commentaires.Margin = new System.Windows.Forms.Padding(4);
            this.txt_commentaires.Name = "txt_commentaires";
            this.txt_commentaires.Size = new System.Drawing.Size(381, 44);
            this.txt_commentaires.TabIndex = 174;
            this.txt_commentaires.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.bunifuImageButton1.TabIndex = 143;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
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
            this.btn_enregistrer.Location = new System.Drawing.Point(922, 263);
            this.btn_enregistrer.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btn_enregistrer.Name = "btn_enregistrer";
            this.btn_enregistrer.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.btn_enregistrer.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_enregistrer.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_enregistrer.selected = false;
            this.btn_enregistrer.Size = new System.Drawing.Size(169, 40);
            this.btn_enregistrer.TabIndex = 146;
            this.btn_enregistrer.Text = "Enregistrer";
            this.btn_enregistrer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_enregistrer.Textcolor = System.Drawing.Color.White;
            this.btn_enregistrer.TextFont = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_enregistrer.Click += new System.EventHandler(this.btn_enregistrer_Click);
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
            this.btn_supprimer.Location = new System.Drawing.Point(1101, 263);
            this.btn_supprimer.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.btn_supprimer.Name = "btn_supprimer";
            this.btn_supprimer.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.btn_supprimer.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_supprimer.OnHoverTextColor = System.Drawing.Color.White;
            this.btn_supprimer.selected = false;
            this.btn_supprimer.Size = new System.Drawing.Size(169, 40);
            this.btn_supprimer.TabIndex = 147;
            this.btn_supprimer.Text = "Supprimer";
            this.btn_supprimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn_supprimer.Textcolor = System.Drawing.Color.White;
            this.btn_supprimer.TextFont = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_supprimer.Click += new System.EventHandler(this.btn_supprimer_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MediationDB.Properties.Resources.UNHABITAT_svg;
            this.pictureBox1.Location = new System.Drawing.Point(12, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 175;
            this.pictureBox1.TabStop = false;
            // 
            // frm_atelier_masse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(1300, 714);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_commentaires);
            this.Controls.Add(this.txt_observation);
            this.Controls.Add(this.txt_themes);
            this.Controls.Add(this.txt_telephone);
            this.Controls.Add(this.txt_noms_sensibilisateurs);
            this.Controls.Add(this.txt_num_atelier);
            this.Controls.Add(this.txt_autorite_homme);
            this.Controls.Add(this.txt_autorite_femme);
            this.Controls.Add(this.txt_menages_rap);
            this.Controls.Add(this.txt_menages_locaux);
            this.Controls.Add(this.txt_menages_depl);
            this.Controls.Add(this.txt_menages_retournes);
            this.Controls.Add(this.txt_filles);
            this.Controls.Add(this.txt_garcons);
            this.Controls.Add(this.txt_hommes);
            this.Controls.Add(this.txt_femmes);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bunifuCustomDataGrid2);
            this.Controls.Add(this.btn_enregistrer);
            this.Controls.Add(this.btn_supprimer);
            this.Controls.Add(this.txt_code_sensibilisation);
            this.Controls.Add(this.dt_debut_sensibilisations);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_atelier_masse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_atelier_masse";
            ((System.ComponentModel.ISupportInitialize)(this.bunifuCustomDataGrid2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid bunifuCustomDataGrid2;
        private Bunifu.Framework.UI.BunifuFlatButton btn_enregistrer;
        private Bunifu.Framework.UI.BunifuFlatButton btn_supprimer;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txt_code_sensibilisation;
        private MetroFramework.Controls.MetroDateTime dt_debut_sensibilisations;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_autorite_homme;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_autorite_femme;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_menages_rap;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_menages_locaux;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_menages_depl;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_menages_retournes;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_filles;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_garcons;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_hommes;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_femmes;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_commentaires;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_observation;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_themes;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_telephone;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_noms_sensibilisateurs;
        public Bunifu.Framework.UI.BunifuMaterialTextbox txt_num_atelier;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}