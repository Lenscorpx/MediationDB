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
            this.bunifuTileButton12 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton11 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton5 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton6 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton7 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton8 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton9 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton10 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton3 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton4 = new Bunifu.Framework.UI.BunifuTileButton();
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
            this.panel2.Controls.Add(this.bunifuTileButton12);
            this.panel2.Controls.Add(this.bunifuTileButton11);
            this.panel2.Controls.Add(this.bunifuTileButton5);
            this.panel2.Controls.Add(this.bunifuTileButton6);
            this.panel2.Controls.Add(this.bunifuTileButton7);
            this.panel2.Controls.Add(this.bunifuTileButton8);
            this.panel2.Controls.Add(this.bunifuTileButton9);
            this.panel2.Controls.Add(this.bunifuTileButton10);
            this.panel2.Controls.Add(this.bunifuTileButton3);
            this.panel2.Controls.Add(this.bunifuTileButton4);
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
            // bunifuTileButton12
            // 
            this.bunifuTileButton12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuTileButton12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuTileButton12.color = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuTileButton12.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.bunifuTileButton12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuTileButton12, BunifuAnimatorNS.DecorationType.Custom);
            this.bunifuTileButton12.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.bunifuTileButton12.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton12.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton12.Image")));
            this.bunifuTileButton12.ImagePosition = 14;
            this.bunifuTileButton12.ImageZoom = 50;
            this.bunifuTileButton12.LabelPosition = 27;
            this.bunifuTileButton12.LabelText = "Tile 1";
            this.bunifuTileButton12.Location = new System.Drawing.Point(1082, 131);
            this.bunifuTileButton12.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bunifuTileButton12.Name = "bunifuTileButton12";
            this.bunifuTileButton12.Size = new System.Drawing.Size(128, 101);
            this.bunifuTileButton12.TabIndex = 75;
            // 
            // bunifuTileButton11
            // 
            this.bunifuTileButton11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuTileButton11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuTileButton11.color = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuTileButton11.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.bunifuTileButton11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuTileButton11, BunifuAnimatorNS.DecorationType.Custom);
            this.bunifuTileButton11.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.bunifuTileButton11.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton11.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton11.Image")));
            this.bunifuTileButton11.ImagePosition = 14;
            this.bunifuTileButton11.ImageZoom = 50;
            this.bunifuTileButton11.LabelPosition = 27;
            this.bunifuTileButton11.LabelText = "Tile 1";
            this.bunifuTileButton11.Location = new System.Drawing.Point(918, 131);
            this.bunifuTileButton11.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bunifuTileButton11.Name = "bunifuTileButton11";
            this.bunifuTileButton11.Size = new System.Drawing.Size(128, 101);
            this.bunifuTileButton11.TabIndex = 73;
            // 
            // bunifuTileButton5
            // 
            this.bunifuTileButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuTileButton5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuTileButton5.color = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuTileButton5.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.bunifuTileButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuTileButton5, BunifuAnimatorNS.DecorationType.Custom);
            this.bunifuTileButton5.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.bunifuTileButton5.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton5.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton5.Image")));
            this.bunifuTileButton5.ImagePosition = 14;
            this.bunifuTileButton5.ImageZoom = 50;
            this.bunifuTileButton5.LabelPosition = 27;
            this.bunifuTileButton5.LabelText = "Tile 1";
            this.bunifuTileButton5.Location = new System.Drawing.Point(749, 131);
            this.bunifuTileButton5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bunifuTileButton5.Name = "bunifuTileButton5";
            this.bunifuTileButton5.Size = new System.Drawing.Size(128, 101);
            this.bunifuTileButton5.TabIndex = 71;
            // 
            // bunifuTileButton6
            // 
            this.bunifuTileButton6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuTileButton6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuTileButton6.color = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuTileButton6.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.bunifuTileButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuTileButton6, BunifuAnimatorNS.DecorationType.Custom);
            this.bunifuTileButton6.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.bunifuTileButton6.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton6.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton6.Image")));
            this.bunifuTileButton6.ImagePosition = 14;
            this.bunifuTileButton6.ImageZoom = 50;
            this.bunifuTileButton6.LabelPosition = 27;
            this.bunifuTileButton6.LabelText = "Tile 1";
            this.bunifuTileButton6.Location = new System.Drawing.Point(580, 131);
            this.bunifuTileButton6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bunifuTileButton6.Name = "bunifuTileButton6";
            this.bunifuTileButton6.Size = new System.Drawing.Size(128, 101);
            this.bunifuTileButton6.TabIndex = 70;
            // 
            // bunifuTileButton7
            // 
            this.bunifuTileButton7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuTileButton7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuTileButton7.color = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuTileButton7.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.bunifuTileButton7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuTileButton7, BunifuAnimatorNS.DecorationType.Custom);
            this.bunifuTileButton7.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.bunifuTileButton7.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton7.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton7.Image")));
            this.bunifuTileButton7.ImagePosition = 14;
            this.bunifuTileButton7.ImageZoom = 50;
            this.bunifuTileButton7.LabelPosition = 27;
            this.bunifuTileButton7.LabelText = "Tile 1";
            this.bunifuTileButton7.Location = new System.Drawing.Point(405, 131);
            this.bunifuTileButton7.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bunifuTileButton7.Name = "bunifuTileButton7";
            this.bunifuTileButton7.Size = new System.Drawing.Size(128, 101);
            this.bunifuTileButton7.TabIndex = 69;
            // 
            // bunifuTileButton8
            // 
            this.bunifuTileButton8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuTileButton8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuTileButton8.color = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuTileButton8.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.bunifuTileButton8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuTileButton8, BunifuAnimatorNS.DecorationType.Custom);
            this.bunifuTileButton8.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.bunifuTileButton8.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton8.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton8.Image")));
            this.bunifuTileButton8.ImagePosition = 14;
            this.bunifuTileButton8.ImageZoom = 50;
            this.bunifuTileButton8.LabelPosition = 27;
            this.bunifuTileButton8.LabelText = "Tile 1";
            this.bunifuTileButton8.Location = new System.Drawing.Point(234, 131);
            this.bunifuTileButton8.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bunifuTileButton8.Name = "bunifuTileButton8";
            this.bunifuTileButton8.Size = new System.Drawing.Size(128, 101);
            this.bunifuTileButton8.TabIndex = 68;
            // 
            // bunifuTileButton9
            // 
            this.bunifuTileButton9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuTileButton9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuTileButton9.color = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuTileButton9.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.bunifuTileButton9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuTileButton9, BunifuAnimatorNS.DecorationType.Custom);
            this.bunifuTileButton9.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.bunifuTileButton9.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton9.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton9.Image")));
            this.bunifuTileButton9.ImagePosition = 14;
            this.bunifuTileButton9.ImageZoom = 50;
            this.bunifuTileButton9.LabelPosition = 27;
            this.bunifuTileButton9.LabelText = "Tile 1";
            this.bunifuTileButton9.Location = new System.Drawing.Point(62, 131);
            this.bunifuTileButton9.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bunifuTileButton9.Name = "bunifuTileButton9";
            this.bunifuTileButton9.Size = new System.Drawing.Size(128, 101);
            this.bunifuTileButton9.TabIndex = 67;
            // 
            // bunifuTileButton10
            // 
            this.bunifuTileButton10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuTileButton10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuTileButton10.color = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuTileButton10.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.bunifuTileButton10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuTileButton10, BunifuAnimatorNS.DecorationType.Custom);
            this.bunifuTileButton10.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.bunifuTileButton10.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton10.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton10.Image")));
            this.bunifuTileButton10.ImagePosition = 14;
            this.bunifuTileButton10.ImageZoom = 50;
            this.bunifuTileButton10.LabelPosition = 27;
            this.bunifuTileButton10.LabelText = "Tile 1";
            this.bunifuTileButton10.Location = new System.Drawing.Point(1082, 16);
            this.bunifuTileButton10.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bunifuTileButton10.Name = "bunifuTileButton10";
            this.bunifuTileButton10.Size = new System.Drawing.Size(128, 101);
            this.bunifuTileButton10.TabIndex = 66;
            // 
            // bunifuTileButton3
            // 
            this.bunifuTileButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuTileButton3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuTileButton3.color = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuTileButton3.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.bunifuTileButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuTileButton3, BunifuAnimatorNS.DecorationType.Custom);
            this.bunifuTileButton3.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.bunifuTileButton3.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton3.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton3.Image")));
            this.bunifuTileButton3.ImagePosition = 14;
            this.bunifuTileButton3.ImageZoom = 50;
            this.bunifuTileButton3.LabelPosition = 27;
            this.bunifuTileButton3.LabelText = "Tile 1";
            this.bunifuTileButton3.Location = new System.Drawing.Point(918, 16);
            this.bunifuTileButton3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bunifuTileButton3.Name = "bunifuTileButton3";
            this.bunifuTileButton3.Size = new System.Drawing.Size(128, 101);
            this.bunifuTileButton3.TabIndex = 59;
            // 
            // bunifuTileButton4
            // 
            this.bunifuTileButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuTileButton4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuTileButton4.color = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuTileButton4.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(72)))), ((int)(((byte)(65)))));
            this.bunifuTileButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuTileButton4, BunifuAnimatorNS.DecorationType.Custom);
            this.bunifuTileButton4.Font = new System.Drawing.Font("Century Gothic", 8F);
            this.bunifuTileButton4.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton4.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton4.Image")));
            this.bunifuTileButton4.ImagePosition = 14;
            this.bunifuTileButton4.ImageZoom = 50;
            this.bunifuTileButton4.LabelPosition = 27;
            this.bunifuTileButton4.LabelText = "Tile 1";
            this.bunifuTileButton4.Location = new System.Drawing.Point(749, 16);
            this.bunifuTileButton4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bunifuTileButton4.Name = "bunifuTileButton4";
            this.bunifuTileButton4.Size = new System.Drawing.Size(128, 101);
            this.bunifuTileButton4.TabIndex = 58;
            // 
            // btn_etat_part
            // 
            this.btn_etat_part.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_etat_part.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.btn_etat_part.Location = new System.Drawing.Point(580, 16);
            this.btn_etat_part.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_etat_part.Name = "btn_etat_part";
            this.btn_etat_part.Size = new System.Drawing.Size(128, 101);
            this.btn_etat_part.TabIndex = 55;
            // 
            // btn_resolutions
            // 
            this.btn_resolutions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_resolutions.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.btn_resolutions.Location = new System.Drawing.Point(405, 16);
            this.btn_resolutions.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_resolutions.Name = "btn_resolutions";
            this.btn_resolutions.Size = new System.Drawing.Size(128, 101);
            this.btn_resolutions.TabIndex = 54;
            // 
            // btn_objets
            // 
            this.btn_objets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_objets.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.btn_objets.Location = new System.Drawing.Point(234, 16);
            this.btn_objets.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_objets.Name = "btn_objets";
            this.btn_objets.Size = new System.Drawing.Size(128, 101);
            this.btn_objets.TabIndex = 49;
            // 
            // btn_params_causes
            // 
            this.btn_params_causes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.btn_params_causes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.btn_params_causes.Location = new System.Drawing.Point(62, 16);
            this.btn_params_causes.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_params_causes.Name = "btn_params_causes";
            this.btn_params_causes.Size = new System.Drawing.Size(128, 101);
            this.btn_params_causes.TabIndex = 48;
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
            this.btn_rapports.Location = new System.Drawing.Point(902, 233);
            this.btn_rapports.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_rapports.Name = "btn_rapports";
            this.btn_rapports.Size = new System.Drawing.Size(191, 162);
            this.btn_rapports.TabIndex = 16;
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
            this.btn_organisations.Location = new System.Drawing.Point(664, 233);
            this.btn_organisations.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_organisations.Name = "btn_organisations";
            this.btn_organisations.Size = new System.Drawing.Size(191, 162);
            this.btn_organisations.TabIndex = 15;
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
            this.btn_parties.Location = new System.Drawing.Point(426, 233);
            this.btn_parties.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_parties.Name = "btn_parties";
            this.btn_parties.Size = new System.Drawing.Size(191, 162);
            this.btn_parties.TabIndex = 14;
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
            this.btn_menages.Location = new System.Drawing.Point(185, 233);
            this.btn_menages.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_menages.Name = "btn_menages";
            this.btn_menages.Size = new System.Drawing.Size(191, 162);
            this.btn_menages.TabIndex = 9;
            this.btn_menages.Click += new System.EventHandler(this.bunifuTileButton5_Click);
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
            this.btn_conflits.Location = new System.Drawing.Point(902, 35);
            this.btn_conflits.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_conflits.Name = "btn_conflits";
            this.btn_conflits.Size = new System.Drawing.Size(191, 162);
            this.btn_conflits.TabIndex = 7;
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
            this.btn_mediateurs.Location = new System.Drawing.Point(664, 35);
            this.btn_mediateurs.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_mediateurs.Name = "btn_mediateurs";
            this.btn_mediateurs.Size = new System.Drawing.Size(191, 162);
            this.btn_mediateurs.TabIndex = 5;
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
            this.btn_sensibilisations.Location = new System.Drawing.Point(426, 35);
            this.btn_sensibilisations.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_sensibilisations.Name = "btn_sensibilisations";
            this.btn_sensibilisations.Size = new System.Drawing.Size(191, 162);
            this.btn_sensibilisations.TabIndex = 3;
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
            this.btn_ateliers.Location = new System.Drawing.Point(185, 35);
            this.btn_ateliers.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btn_ateliers.Name = "btn_ateliers";
            this.btn_ateliers.Size = new System.Drawing.Size(191, 162);
            this.btn_ateliers.TabIndex = 0;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuTransition1.SetDecoration(this.bunifuImageButton1, BunifuAnimatorNS.DecorationType.None);
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
        public Bunifu.Framework.UI.BunifuTileButton bunifuTileButton12;
        public Bunifu.Framework.UI.BunifuTileButton bunifuTileButton11;
        public Bunifu.Framework.UI.BunifuTileButton bunifuTileButton5;
        public Bunifu.Framework.UI.BunifuTileButton bunifuTileButton6;
        public Bunifu.Framework.UI.BunifuTileButton bunifuTileButton7;
        public Bunifu.Framework.UI.BunifuTileButton bunifuTileButton8;
        public Bunifu.Framework.UI.BunifuTileButton bunifuTileButton9;
        public Bunifu.Framework.UI.BunifuTileButton bunifuTileButton10;
        public Bunifu.Framework.UI.BunifuTileButton bunifuTileButton3;
        public Bunifu.Framework.UI.BunifuTileButton bunifuTileButton4;
        public Bunifu.Framework.UI.BunifuTileButton btn_etat_part;
        public Bunifu.Framework.UI.BunifuTileButton btn_resolutions;
    }
}