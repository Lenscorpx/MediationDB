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
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuTileButton3 = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_rapports = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_membres = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_parties = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_menages = new Bunifu.Framework.UI.BunifuTileButton();
            this.btn_conflits = new Bunifu.Framework.UI.BunifuTileButton();
            this.pnl_head.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.pnl_head.Controls.Add(this.label1);
            this.pnl_head.Controls.Add(this.bunifuImageButton1);
            this.bunifuTransition1.SetDecoration(this.pnl_head, BunifuAnimatorNS.DecorationType.None);
            this.pnl_head.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_head.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnl_head.Location = new System.Drawing.Point(0, 0);
            this.pnl_head.Name = "pnl_head";
            this.pnl_head.Size = new System.Drawing.Size(1300, 49);
            this.pnl_head.TabIndex = 1;
            this.pnl_head.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(410, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(458, 39);
            this.label1.TabIndex = 9;
            this.label1.Text = "UN Habitat - Conflits fonciers";
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
            this.panel1.Controls.Add(this.bunifuTileButton3);
            this.panel1.Controls.Add(this.btn_rapports);
            this.panel1.Controls.Add(this.btn_membres);
            this.panel1.Controls.Add(this.btn_parties);
            this.panel1.Controls.Add(this.btn_menages);
            this.panel1.Controls.Add(this.btn_conflits);
            this.bunifuTransition1.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1300, 665);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_2);
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
            this.bunifuTileButton3.Location = new System.Drawing.Point(75, 356);
            this.bunifuTileButton3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.bunifuTileButton3.Name = "bunifuTileButton3";
            this.bunifuTileButton3.Size = new System.Drawing.Size(272, 211);
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
            this.btn_rapports.Location = new System.Drawing.Point(956, 356);
            this.btn_rapports.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_rapports.Name = "btn_rapports";
            this.btn_rapports.Size = new System.Drawing.Size(272, 211);
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
            this.btn_membres.Location = new System.Drawing.Point(956, 60);
            this.btn_membres.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_membres.Name = "btn_membres";
            this.btn_membres.Size = new System.Drawing.Size(272, 211);
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
            this.btn_parties.Location = new System.Drawing.Point(519, 356);
            this.btn_parties.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_parties.Name = "btn_parties";
            this.btn_parties.Size = new System.Drawing.Size(272, 211);
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
            this.btn_menages.Location = new System.Drawing.Point(519, 60);
            this.btn_menages.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_menages.Name = "btn_menages";
            this.btn_menages.Size = new System.Drawing.Size(272, 211);
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
            this.btn_conflits.Location = new System.Drawing.Point(75, 60);
            this.btn_conflits.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_conflits.Name = "btn_conflits";
            this.btn_conflits.Size = new System.Drawing.Size(272, 211);
            this.btn_conflits.TabIndex = 3;
            this.btn_conflits.Click += new System.EventHandler(this.btn_conflits_Click);
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
            this.Text = "MediatorDB";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frm_menu_Load);
            this.pnl_head.ResumeLayout(false);
            this.pnl_head.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Panel pnl_head;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Panel panel1;
        public Bunifu.Framework.UI.BunifuTileButton btn_menages;
        public Bunifu.Framework.UI.BunifuTileButton btn_conflits;
        public Bunifu.Framework.UI.BunifuTileButton btn_rapports;
        public Bunifu.Framework.UI.BunifuTileButton btn_membres;
        public Bunifu.Framework.UI.BunifuTileButton btn_parties;
        public Bunifu.Framework.UI.BunifuTileButton bunifuTileButton3;
        private System.Windows.Forms.Label label1;
    }
}