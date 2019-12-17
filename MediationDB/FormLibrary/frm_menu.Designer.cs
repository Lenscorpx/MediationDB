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
            this.lbl_nom_user = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btn_typep_conflit = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_pays = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_porvinces = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_territoire = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_groupement = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_localite = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_vulnerabilites = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_types_parties = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_situation = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_nature_conflit = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_users = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_etat_part = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_resolutions = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_objets = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_params_causes = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_rapports = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_organisations = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_parties = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_menages = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_conflits = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_mediateurs = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_sensibilisations = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_ateliers = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.pnl_head.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
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
            // lbl_nom_user
            // 
            this.lbl_nom_user.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.lbl_nom_user, BunifuAnimatorNS.DecorationType.None);
            this.lbl_nom_user.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nom_user.ForeColor = System.Drawing.Color.White;
            this.lbl_nom_user.Location = new System.Drawing.Point(12, 10);
            this.lbl_nom_user.Name = "lbl_nom_user";
            this.lbl_nom_user.Size = new System.Drawing.Size(120, 25);
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
            this.label1.Location = new System.Drawing.Point(578, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mediator";
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
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btn_rapports);
            this.panel1.Controls.Add(this.btn_organisations);
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
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.panel2.Controls.Add(this.btn_typep_conflit);
            this.panel2.Controls.Add(this.btn_pays);
            this.panel2.Controls.Add(this.btn_porvinces);
            this.panel2.Controls.Add(this.btn_territoire);
            this.panel2.Controls.Add(this.btn_groupement);
            this.panel2.Controls.Add(this.btn_localite);
            this.panel2.Controls.Add(this.btn_vulnerabilites);
            this.panel2.Controls.Add(this.btn_types_parties);
            this.panel2.Controls.Add(this.btn_situation);
            this.panel2.Controls.Add(this.btn_nature_conflit);
            this.panel2.Controls.Add(this.btn_users);
            this.panel2.Controls.Add(this.btn_etat_part);
            this.panel2.Controls.Add(this.btn_resolutions);
            this.panel2.Controls.Add(this.btn_objets);
            this.panel2.Controls.Add(this.btn_params_causes);
            this.bunifuTransition1.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 425);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1300, 240);
            this.panel2.TabIndex = 60;
            // 
            // pictureBox4
            // 
            this.bunifuTransition1.SetDecoration(this.pictureBox4, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox4.Image = global::MediationDB.Properties.Resources.Logo_SCC;
            this.pictureBox4.Location = new System.Drawing.Point(17, 160);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(165, 106);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 64;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.bunifuTransition1.SetDecoration(this.pictureBox3, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox3.Image = global::MediationDB.Properties.Resources.Logo_SCC;
            this.pictureBox3.Location = new System.Drawing.Point(1123, 160);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(165, 106);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 63;
            this.pictureBox3.TabStop = false;
            // 
            // btn_typep_conflit
            // 
            this.btn_typep_conflit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_typep_conflit.color = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_typep_conflit.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.btn_typep_conflit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btn_typep_conflit, BunifuAnimatorNS.DecorationType.Custom);
            this.btn_typep_conflit.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.btn_typep_conflit.ForeColor = System.Drawing.Color.White;
            this.btn_typep_conflit.Image = global::MediationDB.Properties.Resources.typesdeconflit;
            this.btn_typep_conflit.ImagePosition = 14;
            this.btn_typep_conflit.ImageZoom = 50;
            this.btn_typep_conflit.LabelPosition = 27;
            this.btn_typep_conflit.LabelText = "Types de conflits";
            this.btn_typep_conflit.Location = new System.Drawing.Point(1148, 14);
            this.btn_typep_conflit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_typep_conflit.Name = "btn_typep_conflit";
            this.btn_typep_conflit.Size = new System.Drawing.Size(128, 101);
            this.btn_typep_conflit.TabIndex = 37;
            this.btn_typep_conflit.Click += new System.EventHandler(this.btn_typep_conflit_Click);
            // 
            // btn_pays
            // 
            this.btn_pays.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_pays.color = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_pays.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.btn_pays.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btn_pays, BunifuAnimatorNS.DecorationType.Custom);
            this.btn_pays.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.btn_pays.ForeColor = System.Drawing.Color.White;
            this.btn_pays.Image = global::MediationDB.Properties.Resources.location_96px;
            this.btn_pays.ImagePosition = 14;
            this.btn_pays.ImageZoom = 50;
            this.btn_pays.LabelPosition = 27;
            this.btn_pays.LabelText = "Pays";
            this.btn_pays.Location = new System.Drawing.Point(985, 129);
            this.btn_pays.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_pays.Name = "btn_pays";
            this.btn_pays.Size = new System.Drawing.Size(128, 101);
            this.btn_pays.TabIndex = 21;
            // 
            // btn_porvinces
            // 
            this.btn_porvinces.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_porvinces.color = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_porvinces.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.btn_porvinces.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btn_porvinces, BunifuAnimatorNS.DecorationType.Custom);
            this.btn_porvinces.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.btn_porvinces.ForeColor = System.Drawing.Color.White;
            this.btn_porvinces.Image = global::MediationDB.Properties.Resources.location_96px;
            this.btn_porvinces.ImagePosition = 14;
            this.btn_porvinces.ImageZoom = 50;
            this.btn_porvinces.LabelPosition = 27;
            this.btn_porvinces.LabelText = "Provinces";
            this.btn_porvinces.Location = new System.Drawing.Point(819, 129);
            this.btn_porvinces.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_porvinces.Name = "btn_porvinces";
            this.btn_porvinces.Size = new System.Drawing.Size(128, 101);
            this.btn_porvinces.TabIndex = 20;
            // 
            // btn_territoire
            // 
            this.btn_territoire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_territoire.color = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_territoire.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.btn_territoire.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btn_territoire, BunifuAnimatorNS.DecorationType.Custom);
            this.btn_territoire.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.btn_territoire.ForeColor = System.Drawing.Color.White;
            this.btn_territoire.Image = global::MediationDB.Properties.Resources.location_96px1;
            this.btn_territoire.ImagePosition = 14;
            this.btn_territoire.ImageZoom = 50;
            this.btn_territoire.LabelPosition = 27;
            this.btn_territoire.LabelText = "Territoires";
            this.btn_territoire.Location = new System.Drawing.Point(658, 129);
            this.btn_territoire.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_territoire.Name = "btn_territoire";
            this.btn_territoire.Size = new System.Drawing.Size(128, 101);
            this.btn_territoire.TabIndex = 19;
            // 
            // btn_groupement
            // 
            this.btn_groupement.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_groupement.color = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_groupement.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.btn_groupement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btn_groupement, BunifuAnimatorNS.DecorationType.Custom);
            this.btn_groupement.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.btn_groupement.ForeColor = System.Drawing.Color.White;
            this.btn_groupement.Image = global::MediationDB.Properties.Resources.location_96px1;
            this.btn_groupement.ImagePosition = 14;
            this.btn_groupement.ImageZoom = 50;
            this.btn_groupement.LabelPosition = 27;
            this.btn_groupement.LabelText = "Groupements";
            this.btn_groupement.Location = new System.Drawing.Point(499, 129);
            this.btn_groupement.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_groupement.Name = "btn_groupement";
            this.btn_groupement.Size = new System.Drawing.Size(128, 101);
            this.btn_groupement.TabIndex = 18;
            // 
            // btn_localite
            // 
            this.btn_localite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_localite.color = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_localite.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.btn_localite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btn_localite, BunifuAnimatorNS.DecorationType.Custom);
            this.btn_localite.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.btn_localite.ForeColor = System.Drawing.Color.White;
            this.btn_localite.Image = global::MediationDB.Properties.Resources.location_96px;
            this.btn_localite.ImagePosition = 14;
            this.btn_localite.ImageZoom = 50;
            this.btn_localite.LabelPosition = 27;
            this.btn_localite.LabelText = "Localités";
            this.btn_localite.Location = new System.Drawing.Point(343, 129);
            this.btn_localite.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_localite.Name = "btn_localite";
            this.btn_localite.Size = new System.Drawing.Size(128, 101);
            this.btn_localite.TabIndex = 17;
            // 
            // btn_vulnerabilites
            // 
            this.btn_vulnerabilites.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_vulnerabilites.color = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_vulnerabilites.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.btn_vulnerabilites.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btn_vulnerabilites, BunifuAnimatorNS.DecorationType.Custom);
            this.btn_vulnerabilites.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.btn_vulnerabilites.ForeColor = System.Drawing.Color.White;
            this.btn_vulnerabilites.Image = global::MediationDB.Properties.Resources.vulnera;
            this.btn_vulnerabilites.ImagePosition = 14;
            this.btn_vulnerabilites.ImageZoom = 50;
            this.btn_vulnerabilites.LabelPosition = 27;
            this.btn_vulnerabilites.LabelText = "Fact. marginalisation";
            this.btn_vulnerabilites.Location = new System.Drawing.Point(183, 129);
            this.btn_vulnerabilites.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_vulnerabilites.Name = "btn_vulnerabilites";
            this.btn_vulnerabilites.Size = new System.Drawing.Size(128, 101);
            this.btn_vulnerabilites.TabIndex = 16;
            // 
            // btn_types_parties
            // 
            this.btn_types_parties.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_types_parties.color = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_types_parties.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.btn_types_parties.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btn_types_parties, BunifuAnimatorNS.DecorationType.Custom);
            this.btn_types_parties.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.btn_types_parties.ForeColor = System.Drawing.Color.White;
            this.btn_types_parties.Image = global::MediationDB.Properties.Resources.types_de_parties;
            this.btn_types_parties.ImagePosition = 14;
            this.btn_types_parties.ImageZoom = 50;
            this.btn_types_parties.LabelPosition = 27;
            this.btn_types_parties.LabelText = "Types de parties";
            this.btn_types_parties.Location = new System.Drawing.Point(27, 129);
            this.btn_types_parties.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_types_parties.Name = "btn_types_parties";
            this.btn_types_parties.Size = new System.Drawing.Size(128, 101);
            this.btn_types_parties.TabIndex = 15;
            // 
            // btn_situation
            // 
            this.btn_situation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_situation.color = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_situation.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.btn_situation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btn_situation, BunifuAnimatorNS.DecorationType.Custom);
            this.btn_situation.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.btn_situation.ForeColor = System.Drawing.Color.White;
            this.btn_situation.Image = global::MediationDB.Properties.Resources.situationsMenages;
            this.btn_situation.ImagePosition = 14;
            this.btn_situation.ImageZoom = 50;
            this.btn_situation.LabelPosition = 27;
            this.btn_situation.LabelText = "Situation du menage";
            this.btn_situation.Location = new System.Drawing.Point(985, 14);
            this.btn_situation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_situation.Name = "btn_situation";
            this.btn_situation.Size = new System.Drawing.Size(128, 101);
            this.btn_situation.TabIndex = 14;
            this.btn_situation.Click += new System.EventHandler(this.btn_situation_Click);
            // 
            // btn_nature_conflit
            // 
            this.btn_nature_conflit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_nature_conflit.color = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_nature_conflit.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.btn_nature_conflit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btn_nature_conflit, BunifuAnimatorNS.DecorationType.Custom);
            this.btn_nature_conflit.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.btn_nature_conflit.ForeColor = System.Drawing.Color.White;
            this.btn_nature_conflit.Image = global::MediationDB.Properties.Resources.natures_conflit;
            this.btn_nature_conflit.ImagePosition = 14;
            this.btn_nature_conflit.ImageZoom = 50;
            this.btn_nature_conflit.LabelPosition = 27;
            this.btn_nature_conflit.LabelText = "Nature du conflit";
            this.btn_nature_conflit.Location = new System.Drawing.Point(819, 14);
            this.btn_nature_conflit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_nature_conflit.Name = "btn_nature_conflit";
            this.btn_nature_conflit.Size = new System.Drawing.Size(128, 101);
            this.btn_nature_conflit.TabIndex = 13;
            this.btn_nature_conflit.Click += new System.EventHandler(this.btn_nature_conflit_Click);
            // 
            // btn_users
            // 
            this.btn_users.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_users.color = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_users.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.btn_users.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btn_users, BunifuAnimatorNS.DecorationType.Custom);
            this.btn_users.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.btn_users.ForeColor = System.Drawing.Color.White;
            this.btn_users.Image = global::MediationDB.Properties.Resources.users;
            this.btn_users.ImagePosition = 14;
            this.btn_users.ImageZoom = 50;
            this.btn_users.LabelPosition = 27;
            this.btn_users.LabelText = "Utilisateurs";
            this.btn_users.Location = new System.Drawing.Point(658, 14);
            this.btn_users.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_users.Name = "btn_users";
            this.btn_users.Size = new System.Drawing.Size(128, 101);
            this.btn_users.TabIndex = 12;
            // 
            // btn_etat_part
            // 
            this.btn_etat_part.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_etat_part.color = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_etat_part.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.btn_etat_part.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btn_etat_part, BunifuAnimatorNS.DecorationType.Custom);
            this.btn_etat_part.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.btn_etat_part.ForeColor = System.Drawing.Color.White;
            this.btn_etat_part.Image = global::MediationDB.Properties.Resources.etat_participants;
            this.btn_etat_part.ImagePosition = 14;
            this.btn_etat_part.ImageZoom = 50;
            this.btn_etat_part.LabelPosition = 27;
            this.btn_etat_part.LabelText = "Etat du participant";
            this.btn_etat_part.Location = new System.Drawing.Point(499, 14);
            this.btn_etat_part.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_etat_part.Name = "btn_etat_part";
            this.btn_etat_part.Size = new System.Drawing.Size(128, 101);
            this.btn_etat_part.TabIndex = 11;
            // 
            // btn_resolutions
            // 
            this.btn_resolutions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_resolutions.color = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_resolutions.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.btn_resolutions.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btn_resolutions, BunifuAnimatorNS.DecorationType.Custom);
            this.btn_resolutions.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.btn_resolutions.ForeColor = System.Drawing.Color.White;
            this.btn_resolutions.Image = global::MediationDB.Properties.Resources.resolutions;
            this.btn_resolutions.ImagePosition = 14;
            this.btn_resolutions.ImageZoom = 50;
            this.btn_resolutions.LabelPosition = 27;
            this.btn_resolutions.LabelText = "Resolutions";
            this.btn_resolutions.Location = new System.Drawing.Point(343, 14);
            this.btn_resolutions.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_resolutions.Name = "btn_resolutions";
            this.btn_resolutions.Size = new System.Drawing.Size(128, 101);
            this.btn_resolutions.TabIndex = 10;
            this.btn_resolutions.Click += new System.EventHandler(this.btn_resolutions_Click);
            // 
            // btn_objets
            // 
            this.btn_objets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_objets.color = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_objets.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.btn_objets.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btn_objets, BunifuAnimatorNS.DecorationType.Custom);
            this.btn_objets.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.btn_objets.ForeColor = System.Drawing.Color.White;
            this.btn_objets.Image = global::MediationDB.Properties.Resources.objets_confl;
            this.btn_objets.ImagePosition = 14;
            this.btn_objets.ImageZoom = 50;
            this.btn_objets.LabelPosition = 27;
            this.btn_objets.LabelText = "Objets du conflit";
            this.btn_objets.Location = new System.Drawing.Point(183, 14);
            this.btn_objets.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_objets.Name = "btn_objets";
            this.btn_objets.Size = new System.Drawing.Size(128, 101);
            this.btn_objets.TabIndex = 9;
            this.btn_objets.Click += new System.EventHandler(this.btn_objets_Click);
            // 
            // btn_params_causes
            // 
            this.btn_params_causes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_params_causes.color = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_params_causes.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.btn_params_causes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btn_params_causes, BunifuAnimatorNS.DecorationType.Custom);
            this.btn_params_causes.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.btn_params_causes.ForeColor = System.Drawing.Color.White;
            this.btn_params_causes.Image = global::MediationDB.Properties.Resources.causes;
            this.btn_params_causes.ImagePosition = 14;
            this.btn_params_causes.ImageZoom = 50;
            this.btn_params_causes.LabelPosition = 27;
            this.btn_params_causes.LabelText = "Causes de conflit";
            this.btn_params_causes.Location = new System.Drawing.Point(27, 14);
            this.btn_params_causes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_params_causes.Name = "btn_params_causes";
            this.btn_params_causes.Size = new System.Drawing.Size(128, 101);
            this.btn_params_causes.TabIndex = 8;
            this.btn_params_causes.Click += new System.EventHandler(this.btn_params_causes_Click);
            // 
            // btn_rapports
            // 
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
            this.btn_rapports.Location = new System.Drawing.Point(916, 233);
            this.btn_rapports.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_rapports.Name = "btn_rapports";
            this.btn_rapports.Size = new System.Drawing.Size(191, 162);
            this.btn_rapports.TabIndex = 7;
            // 
            // btn_organisations
            // 
            this.btn_organisations.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_organisations.color = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_organisations.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.btn_organisations.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btn_organisations, BunifuAnimatorNS.DecorationType.None);
            this.btn_organisations.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btn_organisations.ForeColor = System.Drawing.Color.White;
            this.btn_organisations.Image = global::MediationDB.Properties.Resources.organization_96px;
            this.btn_organisations.ImagePosition = 18;
            this.btn_organisations.ImageZoom = 50;
            this.btn_organisations.LabelPosition = 36;
            this.btn_organisations.LabelText = "Organisations";
            this.btn_organisations.Location = new System.Drawing.Point(678, 233);
            this.btn_organisations.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_organisations.Name = "btn_organisations";
            this.btn_organisations.Size = new System.Drawing.Size(191, 162);
            this.btn_organisations.TabIndex = 6;
            // 
            // btn_parties
            // 
            this.btn_parties.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_parties.color = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_parties.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.btn_parties.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btn_parties, BunifuAnimatorNS.DecorationType.None);
            this.btn_parties.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.btn_parties.ForeColor = System.Drawing.Color.White;
            this.btn_parties.Image = global::MediationDB.Properties.Resources.fight_96px;
            this.btn_parties.ImagePosition = 18;
            this.btn_parties.ImageZoom = 50;
            this.btn_parties.LabelPosition = 36;
            this.btn_parties.LabelText = "Parties au conflit";
            this.btn_parties.Location = new System.Drawing.Point(440, 233);
            this.btn_parties.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_parties.Name = "btn_parties";
            this.btn_parties.Size = new System.Drawing.Size(191, 162);
            this.btn_parties.TabIndex = 5;
            // 
            // btn_menages
            // 
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
            this.btn_menages.Location = new System.Drawing.Point(199, 233);
            this.btn_menages.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_menages.Name = "btn_menages";
            this.btn_menages.Size = new System.Drawing.Size(191, 162);
            this.btn_menages.TabIndex = 4;
            // 
            // btn_conflits
            // 
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
            this.btn_conflits.Location = new System.Drawing.Point(916, 35);
            this.btn_conflits.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_conflits.Name = "btn_conflits";
            this.btn_conflits.Size = new System.Drawing.Size(191, 162);
            this.btn_conflits.TabIndex = 3;
            this.btn_conflits.Click += new System.EventHandler(this.btn_conflits_Click);
            // 
            // btn_mediateurs
            // 
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
            this.btn_mediateurs.Location = new System.Drawing.Point(678, 35);
            this.btn_mediateurs.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_mediateurs.Name = "btn_mediateurs";
            this.btn_mediateurs.Size = new System.Drawing.Size(191, 162);
            this.btn_mediateurs.TabIndex = 2;
            // 
            // btn_sensibilisations
            // 
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
            this.btn_sensibilisations.Location = new System.Drawing.Point(440, 35);
            this.btn_sensibilisations.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_sensibilisations.Name = "btn_sensibilisations";
            this.btn_sensibilisations.Size = new System.Drawing.Size(191, 162);
            this.btn_sensibilisations.TabIndex = 1;
            // 
            // btn_ateliers
            // 
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
            this.btn_ateliers.Location = new System.Drawing.Point(199, 35);
            this.btn_ateliers.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_ateliers.Name = "btn_ateliers";
            this.btn_ateliers.Size = new System.Drawing.Size(191, 162);
            this.btn_ateliers.TabIndex = 0;
            // 
            // bunifuImageButton1
            // 
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
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
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
        public Bunifu.Framework.UI.BunifuTileButton btn_organisations;
        public Bunifu.Framework.UI.BunifuTileButton btn_parties;
        private System.Windows.Forms.Panel panel2;
        public Bunifu.Framework.UI.BunifuTileButton btn_objets;
        public Bunifu.Framework.UI.BunifuTileButton btn_params_causes;
        public Bunifu.Framework.UI.BunifuTileButton btn_pays;
        public Bunifu.Framework.UI.BunifuTileButton btn_porvinces;
        public Bunifu.Framework.UI.BunifuTileButton btn_territoire;
        public Bunifu.Framework.UI.BunifuTileButton btn_groupement;
        public Bunifu.Framework.UI.BunifuTileButton btn_localite;
        public Bunifu.Framework.UI.BunifuTileButton btn_vulnerabilites;
        public Bunifu.Framework.UI.BunifuTileButton btn_types_parties;
        public Bunifu.Framework.UI.BunifuTileButton btn_situation;
        public Bunifu.Framework.UI.BunifuTileButton btn_nature_conflit;
        public Bunifu.Framework.UI.BunifuTileButton btn_users;
        public Bunifu.Framework.UI.BunifuTileButton btn_etat_part;
        public Bunifu.Framework.UI.BunifuTileButton btn_resolutions;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        public Bunifu.Framework.UI.BunifuTileButton btn_typep_conflit;
    }
}