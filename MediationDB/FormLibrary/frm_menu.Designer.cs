namespace MediationDB.FormLibrary
{
    partial class frm_menu
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
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_menu));
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.pnl_head = new System.Windows.Forms.Panel();
            this.lbl_organisation = new System.Windows.Forms.Label();
            this.lbl_nom_user = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuTileButton2 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton3 = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_rapports = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_membres = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_parties = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_menages = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_conflits = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_mediateurs = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_sensibilisations = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_ateliers = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuImageButton2 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnl_head.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.pnl_head;
            this.bunifuDragControl1.Vertical = true;
            // 
            // pnl_head
            // 
            this.pnl_head.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.pnl_head.Controls.Add(this.lbl_organisation);
            this.pnl_head.Controls.Add(this.bunifuImageButton2);
            this.pnl_head.Controls.Add(this.lbl_nom_user);
            this.pnl_head.Controls.Add(this.bunifuImageButton1);
            this.pnl_head.Controls.Add(this.label1);
            this.bunifuTransition1.SetDecoration(this.pnl_head, BunifuAnimatorNS.DecorationType.None);
            this.pnl_head.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_head.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_head.Location = new System.Drawing.Point(0, 0);
            this.pnl_head.Name = "pnl_head";
            this.pnl_head.Size = new System.Drawing.Size(1300, 49);
            this.pnl_head.TabIndex = 1;
            this.pnl_head.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lbl_organisation
            // 
            this.lbl_organisation.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lbl_organisation, BunifuAnimatorNS.DecorationType.None);
            this.lbl_organisation.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_organisation.ForeColor = System.Drawing.Color.White;
            this.lbl_organisation.Location = new System.Drawing.Point(654, 14);
            this.lbl_organisation.Name = "lbl_organisation";
            this.lbl_organisation.Size = new System.Drawing.Size(111, 21);
            this.lbl_organisation.TabIndex = 7;
            this.lbl_organisation.Text = "Organisation";
            this.lbl_organisation.Visible = false;
            this.lbl_organisation.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbl_nom_user
            // 
            this.lbl_nom_user.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lbl_nom_user, BunifuAnimatorNS.DecorationType.None);
            this.lbl_nom_user.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nom_user.ForeColor = System.Drawing.Color.White;
            this.lbl_nom_user.Location = new System.Drawing.Point(339, 14);
            this.lbl_nom_user.Name = "lbl_nom_user";
            this.lbl_nom_user.Size = new System.Drawing.Size(87, 21);
            this.lbl_nom_user.TabIndex = 3;
            this.lbl_nom_user.Text = "Nom_User";
            this.lbl_nom_user.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mediator";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.HorizSlide;
            this.bunifuTransition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation1;
            this.bunifuTransition1.TimeStep = 0.09F;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(85)))), ((int)(((byte)(142)))));
            this.panel1.BackgroundImage = global::MediationDB.Properties.Resources.UNHABITAT1;
            this.panel1.Controls.Add(this.bunifuTileButton2);
            this.panel1.Controls.Add(this.bunifuTileButton3);
            this.panel1.Controls.Add(this.btn_rapports);
            this.panel1.Controls.Add(this.btn_membres);
            this.panel1.Controls.Add(this.btn_parties);
            this.panel1.Controls.Add(this.btn_menages);
            this.panel1.Controls.Add(this.btn_conflits);
            this.panel1.Controls.Add(this.btn_mediateurs);
            this.panel1.Controls.Add(this.btn_sensibilisations);
            this.panel1.Controls.Add(this.btn_ateliers);
            this.bunifuTransition1.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1300, 665);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_2);
            // 
            // bunifuTileButton2
            // 
            this.bunifuTileButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuTileButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuTileButton2.color = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuTileButton2.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.bunifuTileButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuTileButton2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTileButton2.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.bunifuTileButton2.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton2.Image = global::MediationDB.Properties.Resources.statistics_report_96px;
            this.bunifuTileButton2.ImagePosition = 18;
            this.bunifuTileButton2.ImageZoom = 50;
            this.bunifuTileButton2.LabelPosition = 36;
            this.bunifuTileButton2.LabelText = "AGR";
            this.bunifuTileButton2.Location = new System.Drawing.Point(315, 232);
            this.bunifuTileButton2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.bunifuTileButton2.Name = "bunifuTileButton2";
            this.bunifuTileButton2.Size = new System.Drawing.Size(191, 162);
            this.bunifuTileButton2.TabIndex = 62;
            this.bunifuTileButton2.Click += new System.EventHandler(this.bunifuTileButton2_Click);
            // 
            // bunifuTileButton3
            // 
            this.bunifuTileButton3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuTileButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuTileButton3.color = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuTileButton3.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.bunifuTileButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuTileButton3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuTileButton3.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.bunifuTileButton3.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton3.Image = global::MediationDB.Properties.Resources.violences_sur_bg;
            this.bunifuTileButton3.ImagePosition = 18;
            this.bunifuTileButton3.ImageZoom = 50;
            this.bunifuTileButton3.LabelPosition = 36;
            this.bunifuTileButton3.LabelText = "Recherches";
            this.bunifuTileButton3.Location = new System.Drawing.Point(553, 232);
            this.bunifuTileButton3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.bunifuTileButton3.Name = "bunifuTileButton3";
            this.bunifuTileButton3.Size = new System.Drawing.Size(191, 162);
            this.bunifuTileButton3.TabIndex = 61;
            this.bunifuTileButton3.Click += new System.EventHandler(this.bunifuTileButton3_Click);
            // 
            // btn_rapports
            // 
            this.btn_rapports.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_rapports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_rapports.color = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_rapports.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.btn_rapports.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btn_rapports, BunifuAnimatorNS.DecorationType.None);
            this.btn_rapports.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btn_rapports.ForeColor = System.Drawing.Color.White;
            this.btn_rapports.Image = global::MediationDB.Properties.Resources.statistics_report_96px;
            this.btn_rapports.ImagePosition = 18;
            this.btn_rapports.ImageZoom = 50;
            this.btn_rapports.LabelPosition = 36;
            this.btn_rapports.LabelText = "Rapports";
            this.btn_rapports.Location = new System.Drawing.Point(1026, 232);
            this.btn_rapports.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_rapports.Name = "btn_rapports";
            this.btn_rapports.Size = new System.Drawing.Size(191, 162);
            this.btn_rapports.TabIndex = 7;
            this.btn_rapports.Click += new System.EventHandler(this.btn_rapports_Click);
            // 
            // btn_membres
            // 
            this.btn_membres.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_membres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_membres.color = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_membres.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.btn_membres.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btn_membres, BunifuAnimatorNS.DecorationType.None);
            this.btn_membres.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btn_membres.ForeColor = System.Drawing.Color.White;
            this.btn_membres.Image = global::MediationDB.Properties.Resources.organization_96px;
            this.btn_membres.ImagePosition = 18;
            this.btn_membres.ImageZoom = 50;
            this.btn_membres.LabelPosition = 36;
            this.btn_membres.LabelText = "Membres de menages";
            this.btn_membres.Location = new System.Drawing.Point(76, 232);
            this.btn_membres.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_membres.Name = "btn_membres";
            this.btn_membres.Size = new System.Drawing.Size(191, 162);
            this.btn_membres.TabIndex = 6;
            this.btn_membres.Click += new System.EventHandler(this.btn_organisations_Click);
            // 
            // btn_parties
            // 
            this.btn_parties.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_parties.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_parties.color = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_parties.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.btn_parties.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btn_parties, BunifuAnimatorNS.DecorationType.None);
            this.btn_parties.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btn_parties.ForeColor = System.Drawing.Color.White;
            this.btn_parties.Image = global::MediationDB.Properties.Resources.combo_chart_80px;
            this.btn_parties.ImagePosition = 18;
            this.btn_parties.ImageZoom = 50;
            this.btn_parties.LabelPosition = 36;
            this.btn_parties.LabelText = "Statistiques";
            this.btn_parties.Location = new System.Drawing.Point(788, 232);
            this.btn_parties.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_parties.Name = "btn_parties";
            this.btn_parties.Size = new System.Drawing.Size(191, 162);
            this.btn_parties.TabIndex = 5;
            this.btn_parties.Click += new System.EventHandler(this.btn_parties_Click);
            // 
            // btn_menages
            // 
            this.btn_menages.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_menages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_menages.color = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_menages.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.btn_menages.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btn_menages, BunifuAnimatorNS.DecorationType.None);
            this.btn_menages.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btn_menages.ForeColor = System.Drawing.Color.White;
            this.btn_menages.Image = global::MediationDB.Properties.Resources.menages_2;
            this.btn_menages.ImagePosition = 18;
            this.btn_menages.ImageZoom = 50;
            this.btn_menages.LabelPosition = 36;
            this.btn_menages.LabelText = "Menages";
            this.btn_menages.Location = new System.Drawing.Point(1026, 34);
            this.btn_menages.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_menages.Name = "btn_menages";
            this.btn_menages.Size = new System.Drawing.Size(191, 162);
            this.btn_menages.TabIndex = 4;
            this.btn_menages.Click += new System.EventHandler(this.btn_menages_Click);
            // 
            // btn_conflits
            // 
            this.btn_conflits.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_conflits.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_conflits.color = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_conflits.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.btn_conflits.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btn_conflits, BunifuAnimatorNS.DecorationType.None);
            this.btn_conflits.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btn_conflits.ForeColor = System.Drawing.Color.White;
            this.btn_conflits.Image = global::MediationDB.Properties.Resources.conflits;
            this.btn_conflits.ImagePosition = 18;
            this.btn_conflits.ImageZoom = 50;
            this.btn_conflits.LabelPosition = 36;
            this.btn_conflits.LabelText = "Conflits";
            this.btn_conflits.Location = new System.Drawing.Point(791, 34);
            this.btn_conflits.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_conflits.Name = "btn_conflits";
            this.btn_conflits.Size = new System.Drawing.Size(191, 162);
            this.btn_conflits.TabIndex = 3;
            this.btn_conflits.Click += new System.EventHandler(this.btn_conflits_Click);
            // 
            // btn_mediateurs
            // 
            this.btn_mediateurs.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_mediateurs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_mediateurs.color = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_mediateurs.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.btn_mediateurs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btn_mediateurs, BunifuAnimatorNS.DecorationType.None);
            this.btn_mediateurs.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btn_mediateurs.ForeColor = System.Drawing.Color.White;
            this.btn_mediateurs.Image = global::MediationDB.Properties.Resources.mediateurs;
            this.btn_mediateurs.ImagePosition = 18;
            this.btn_mediateurs.ImageZoom = 50;
            this.btn_mediateurs.LabelPosition = 36;
            this.btn_mediateurs.LabelText = "Mediateurs";
            this.btn_mediateurs.Location = new System.Drawing.Point(553, 34);
            this.btn_mediateurs.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_mediateurs.Name = "btn_mediateurs";
            this.btn_mediateurs.Size = new System.Drawing.Size(191, 162);
            this.btn_mediateurs.TabIndex = 2;
            this.btn_mediateurs.Click += new System.EventHandler(this.btn_mediateurs_Click);
            // 
            // btn_sensibilisations
            // 
            this.btn_sensibilisations.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_sensibilisations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_sensibilisations.color = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_sensibilisations.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.btn_sensibilisations.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btn_sensibilisations, BunifuAnimatorNS.DecorationType.None);
            this.btn_sensibilisations.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btn_sensibilisations.ForeColor = System.Drawing.Color.White;
            this.btn_sensibilisations.Image = global::MediationDB.Properties.Resources.sensibilisation;
            this.btn_sensibilisations.ImagePosition = 18;
            this.btn_sensibilisations.ImageZoom = 50;
            this.btn_sensibilisations.LabelPosition = 36;
            this.btn_sensibilisations.LabelText = "Sensibilisations";
            this.btn_sensibilisations.Location = new System.Drawing.Point(76, 34);
            this.btn_sensibilisations.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_sensibilisations.Name = "btn_sensibilisations";
            this.btn_sensibilisations.Size = new System.Drawing.Size(191, 162);
            this.btn_sensibilisations.TabIndex = 1;
            this.btn_sensibilisations.Click += new System.EventHandler(this.btn_sensibilisations_Click);
            // 
            // btn_ateliers
            // 
            this.btn_ateliers.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_ateliers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_ateliers.color = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_ateliers.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.btn_ateliers.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btn_ateliers, BunifuAnimatorNS.DecorationType.None);
            this.btn_ateliers.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btn_ateliers.ForeColor = System.Drawing.Color.White;
            this.btn_ateliers.Image = global::MediationDB.Properties.Resources.joining_queue_96px;
            this.btn_ateliers.ImagePosition = 18;
            this.btn_ateliers.ImageZoom = 50;
            this.btn_ateliers.LabelPosition = 36;
            this.btn_ateliers.LabelText = "Ateliers";
            this.btn_ateliers.Location = new System.Drawing.Point(315, 34);
            this.btn_ateliers.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_ateliers.Name = "btn_ateliers";
            this.btn_ateliers.Size = new System.Drawing.Size(191, 162);
            this.btn_ateliers.TabIndex = 0;
            this.btn_ateliers.Click += new System.EventHandler(this.btn_ateliers_Click);
            // 
            // bunifuImageButton2
            // 
            this.bunifuImageButton2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuTransition1.SetDecoration(this.bunifuImageButton2, BunifuAnimatorNS.DecorationType.Custom);
            this.bunifuImageButton2.Image = global::MediationDB.Properties.Resources.help_96px;
            this.bunifuImageButton2.ImageActive = null;
            this.bunifuImageButton2.Location = new System.Drawing.Point(1193, 5);
            this.bunifuImageButton2.Name = "bunifuImageButton2";
            this.bunifuImageButton2.Size = new System.Drawing.Size(46, 40);
            this.bunifuImageButton2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuImageButton2.TabIndex = 5;
            this.bunifuImageButton2.TabStop = false;
            this.bunifuImageButton2.Zoom = 10;
            this.bunifuImageButton2.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuTransition1.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.Custom);
            this.bunifuImageButton1.Image = global::MediationDB.Properties.Resources.Fermer_window;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(1245, 5);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(46, 40);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuImageButton1.TabIndex = 2;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // frm_menu
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1300, 714);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnl_head);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_menu";
            this.Opacity = 0.96D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mediator - SCC";
            this.Load += new System.EventHandler(this.frm_menu_Load);
            this.pnl_head.ResumeLayout(false);
            this.pnl_head.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel pnl_head;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_nom_user;
        public Bunifu.Framework.UI.BunifuTileButton btn_ateliers;
        public Bunifu.Framework.UI.BunifuTileButton btn_menages;
        public Bunifu.Framework.UI.BunifuTileButton btn_conflits;
        public Bunifu.Framework.UI.BunifuTileButton btn_mediateurs;
        public Bunifu.Framework.UI.BunifuTileButton btn_sensibilisations;
        public Bunifu.Framework.UI.BunifuTileButton btn_rapports;
        public Bunifu.Framework.UI.BunifuTileButton btn_membres;
        public Bunifu.Framework.UI.BunifuTileButton btn_parties;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton2;
        public System.Windows.Forms.Label lbl_organisation;
        public Bunifu.Framework.UI.BunifuTileButton bunifuTileButton2;
        public Bunifu.Framework.UI.BunifuTileButton bunifuTileButton3;
    }
}