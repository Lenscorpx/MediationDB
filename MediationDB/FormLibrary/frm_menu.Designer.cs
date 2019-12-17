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
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuTileButton1 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton2 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton3 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton4 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton5 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton7 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton8 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton9 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton10 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton11 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton12 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton13 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton14 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton15 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton16 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton17 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton18 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton19 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton20 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton21 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton22 = new Bunifu.Framework.UI.BunifuTileButton();
            this.bunifuTileButton23 = new Bunifu.Framework.UI.BunifuTileButton();
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
            this.panel1.Controls.Add(this.bunifuTileButton17);
            this.panel1.Controls.Add(this.bunifuTileButton18);
            this.panel1.Controls.Add(this.bunifuTileButton19);
            this.panel1.Controls.Add(this.bunifuTileButton20);
            this.panel1.Controls.Add(this.bunifuTileButton21);
            this.panel1.Controls.Add(this.bunifuTileButton22);
            this.panel1.Controls.Add(this.bunifuTileButton23);
            this.panel1.Controls.Add(this.bunifuTileButton16);
            this.panel1.Controls.Add(this.bunifuTileButton13);
            this.panel1.Controls.Add(this.bunifuTileButton14);
            this.panel1.Controls.Add(this.bunifuTileButton15);
            this.panel1.Controls.Add(this.bunifuTileButton12);
            this.panel1.Controls.Add(this.bunifuTileButton11);
            this.panel1.Controls.Add(this.bunifuTileButton10);
            this.panel1.Controls.Add(this.bunifuTileButton7);
            this.panel1.Controls.Add(this.bunifuTileButton8);
            this.panel1.Controls.Add(this.bunifuTileButton9);
            this.panel1.Controls.Add(this.bunifuTileButton5);
            this.panel1.Controls.Add(this.bunifuTileButton4);
            this.panel1.Controls.Add(this.bunifuTileButton3);
            this.panel1.Controls.Add(this.bunifuTileButton2);
            this.panel1.Controls.Add(this.bunifuTileButton1);
            this.bunifuTransition1.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1300, 665);
            this.panel1.TabIndex = 3;
            // 
            // bunifuTileButton1
            // 
            this.bunifuTileButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuTileButton1.color = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuTileButton1.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuTileButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuTileButton1, BunifuAnimatorNS.DecorationType.Custom);
            this.bunifuTileButton1.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuTileButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton1.Image")));
            this.bunifuTileButton1.ImagePosition = 20;
            this.bunifuTileButton1.ImageZoom = 50;
            this.bunifuTileButton1.LabelPosition = 41;
            this.bunifuTileButton1.LabelText = "Tile 1";
            this.bunifuTileButton1.Location = new System.Drawing.Point(102, 40);
            this.bunifuTileButton1.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton1.Name = "bunifuTileButton1";
            this.bunifuTileButton1.Size = new System.Drawing.Size(170, 146);
            this.bunifuTileButton1.TabIndex = 0;
            // 
            // bunifuTileButton2
            // 
            this.bunifuTileButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuTileButton2.color = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuTileButton2.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuTileButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuTileButton2, BunifuAnimatorNS.DecorationType.Custom);
            this.bunifuTileButton2.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuTileButton2.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton2.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton2.Image")));
            this.bunifuTileButton2.ImagePosition = 20;
            this.bunifuTileButton2.ImageZoom = 50;
            this.bunifuTileButton2.LabelPosition = 41;
            this.bunifuTileButton2.LabelText = "Tile 1";
            this.bunifuTileButton2.Location = new System.Drawing.Point(409, 40);
            this.bunifuTileButton2.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton2.Name = "bunifuTileButton2";
            this.bunifuTileButton2.Size = new System.Drawing.Size(170, 146);
            this.bunifuTileButton2.TabIndex = 3;
            // 
            // bunifuTileButton3
            // 
            this.bunifuTileButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuTileButton3.color = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuTileButton3.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuTileButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuTileButton3, BunifuAnimatorNS.DecorationType.Custom);
            this.bunifuTileButton3.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuTileButton3.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton3.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton3.Image")));
            this.bunifuTileButton3.ImagePosition = 20;
            this.bunifuTileButton3.ImageZoom = 50;
            this.bunifuTileButton3.LabelPosition = 41;
            this.bunifuTileButton3.LabelText = "Tile 1";
            this.bunifuTileButton3.Location = new System.Drawing.Point(745, 40);
            this.bunifuTileButton3.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton3.Name = "bunifuTileButton3";
            this.bunifuTileButton3.Size = new System.Drawing.Size(170, 146);
            this.bunifuTileButton3.TabIndex = 5;
            // 
            // bunifuTileButton4
            // 
            this.bunifuTileButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuTileButton4.color = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuTileButton4.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuTileButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuTileButton4, BunifuAnimatorNS.DecorationType.Custom);
            this.bunifuTileButton4.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuTileButton4.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton4.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton4.Image")));
            this.bunifuTileButton4.ImagePosition = 20;
            this.bunifuTileButton4.ImageZoom = 50;
            this.bunifuTileButton4.LabelPosition = 41;
            this.bunifuTileButton4.LabelText = "Tile 1";
            this.bunifuTileButton4.Location = new System.Drawing.Point(1040, 40);
            this.bunifuTileButton4.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton4.Name = "bunifuTileButton4";
            this.bunifuTileButton4.Size = new System.Drawing.Size(170, 146);
            this.bunifuTileButton4.TabIndex = 7;
            // 
            // bunifuTileButton5
            // 
            this.bunifuTileButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuTileButton5.color = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuTileButton5.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuTileButton5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuTileButton5, BunifuAnimatorNS.DecorationType.Custom);
            this.bunifuTileButton5.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuTileButton5.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton5.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton5.Image")));
            this.bunifuTileButton5.ImagePosition = 20;
            this.bunifuTileButton5.ImageZoom = 50;
            this.bunifuTileButton5.LabelPosition = 41;
            this.bunifuTileButton5.LabelText = "Tile 1";
            this.bunifuTileButton5.Location = new System.Drawing.Point(193, 216);
            this.bunifuTileButton5.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton5.Name = "bunifuTileButton5";
            this.bunifuTileButton5.Size = new System.Drawing.Size(170, 146);
            this.bunifuTileButton5.TabIndex = 9;
            this.bunifuTileButton5.Click += new System.EventHandler(this.bunifuTileButton5_Click);
            // 
            // bunifuTileButton7
            // 
            this.bunifuTileButton7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuTileButton7.color = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuTileButton7.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuTileButton7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuTileButton7, BunifuAnimatorNS.DecorationType.Custom);
            this.bunifuTileButton7.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuTileButton7.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton7.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton7.Image")));
            this.bunifuTileButton7.ImagePosition = 20;
            this.bunifuTileButton7.ImageZoom = 50;
            this.bunifuTileButton7.LabelPosition = 41;
            this.bunifuTileButton7.LabelText = "Tile 1";
            this.bunifuTileButton7.Location = new System.Drawing.Point(925, 216);
            this.bunifuTileButton7.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton7.Name = "bunifuTileButton7";
            this.bunifuTileButton7.Size = new System.Drawing.Size(170, 146);
            this.bunifuTileButton7.TabIndex = 16;
            // 
            // bunifuTileButton8
            // 
            this.bunifuTileButton8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuTileButton8.color = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuTileButton8.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuTileButton8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuTileButton8, BunifuAnimatorNS.DecorationType.Custom);
            this.bunifuTileButton8.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuTileButton8.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton8.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton8.Image")));
            this.bunifuTileButton8.ImagePosition = 20;
            this.bunifuTileButton8.ImageZoom = 50;
            this.bunifuTileButton8.LabelPosition = 41;
            this.bunifuTileButton8.LabelText = "Tile 1";
            this.bunifuTileButton8.Location = new System.Drawing.Point(678, 216);
            this.bunifuTileButton8.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton8.Name = "bunifuTileButton8";
            this.bunifuTileButton8.Size = new System.Drawing.Size(170, 146);
            this.bunifuTileButton8.TabIndex = 15;
            // 
            // bunifuTileButton9
            // 
            this.bunifuTileButton9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuTileButton9.color = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuTileButton9.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuTileButton9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuTileButton9, BunifuAnimatorNS.DecorationType.Custom);
            this.bunifuTileButton9.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.bunifuTileButton9.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton9.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton9.Image")));
            this.bunifuTileButton9.ImagePosition = 20;
            this.bunifuTileButton9.ImageZoom = 50;
            this.bunifuTileButton9.LabelPosition = 41;
            this.bunifuTileButton9.LabelText = "Tile 1";
            this.bunifuTileButton9.Location = new System.Drawing.Point(433, 216);
            this.bunifuTileButton9.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuTileButton9.Name = "bunifuTileButton9";
            this.bunifuTileButton9.Size = new System.Drawing.Size(170, 146);
            this.bunifuTileButton9.TabIndex = 14;
            // 
            // bunifuTileButton10
            // 
            this.bunifuTileButton10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuTileButton10.color = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuTileButton10.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuTileButton10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuTileButton10, BunifuAnimatorNS.DecorationType.Custom);
            this.bunifuTileButton10.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.bunifuTileButton10.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton10.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton10.Image")));
            this.bunifuTileButton10.ImagePosition = 18;
            this.bunifuTileButton10.ImageZoom = 50;
            this.bunifuTileButton10.LabelPosition = 36;
            this.bunifuTileButton10.LabelText = "Tile 1";
            this.bunifuTileButton10.Location = new System.Drawing.Point(218, 428);
            this.bunifuTileButton10.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.bunifuTileButton10.Name = "bunifuTileButton10";
            this.bunifuTileButton10.Size = new System.Drawing.Size(116, 102);
            this.bunifuTileButton10.TabIndex = 19;
            // 
            // bunifuTileButton11
            // 
            this.bunifuTileButton11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuTileButton11.color = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuTileButton11.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuTileButton11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuTileButton11, BunifuAnimatorNS.DecorationType.Custom);
            this.bunifuTileButton11.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.bunifuTileButton11.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton11.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton11.Image")));
            this.bunifuTileButton11.ImagePosition = 18;
            this.bunifuTileButton11.ImageZoom = 50;
            this.bunifuTileButton11.LabelPosition = 36;
            this.bunifuTileButton11.LabelText = "Tile 1";
            this.bunifuTileButton11.Location = new System.Drawing.Point(341, 428);
            this.bunifuTileButton11.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.bunifuTileButton11.Name = "bunifuTileButton11";
            this.bunifuTileButton11.Size = new System.Drawing.Size(116, 102);
            this.bunifuTileButton11.TabIndex = 21;
            // 
            // bunifuTileButton12
            // 
            this.bunifuTileButton12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuTileButton12.color = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuTileButton12.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuTileButton12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuTileButton12, BunifuAnimatorNS.DecorationType.Custom);
            this.bunifuTileButton12.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.bunifuTileButton12.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton12.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton12.Image")));
            this.bunifuTileButton12.ImagePosition = 18;
            this.bunifuTileButton12.ImageZoom = 50;
            this.bunifuTileButton12.LabelPosition = 36;
            this.bunifuTileButton12.LabelText = "Tile 1";
            this.bunifuTileButton12.Location = new System.Drawing.Point(464, 428);
            this.bunifuTileButton12.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.bunifuTileButton12.Name = "bunifuTileButton12";
            this.bunifuTileButton12.Size = new System.Drawing.Size(116, 102);
            this.bunifuTileButton12.TabIndex = 23;
            // 
            // bunifuTileButton13
            // 
            this.bunifuTileButton13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuTileButton13.color = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuTileButton13.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuTileButton13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuTileButton13, BunifuAnimatorNS.DecorationType.Custom);
            this.bunifuTileButton13.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.bunifuTileButton13.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton13.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton13.Image")));
            this.bunifuTileButton13.ImagePosition = 18;
            this.bunifuTileButton13.ImageZoom = 50;
            this.bunifuTileButton13.LabelPosition = 36;
            this.bunifuTileButton13.LabelText = "Tile 1";
            this.bunifuTileButton13.Location = new System.Drawing.Point(834, 428);
            this.bunifuTileButton13.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.bunifuTileButton13.Name = "bunifuTileButton13";
            this.bunifuTileButton13.Size = new System.Drawing.Size(116, 102);
            this.bunifuTileButton13.TabIndex = 29;
            // 
            // bunifuTileButton14
            // 
            this.bunifuTileButton14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuTileButton14.color = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuTileButton14.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuTileButton14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuTileButton14, BunifuAnimatorNS.DecorationType.Custom);
            this.bunifuTileButton14.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.bunifuTileButton14.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton14.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton14.Image")));
            this.bunifuTileButton14.ImagePosition = 18;
            this.bunifuTileButton14.ImageZoom = 50;
            this.bunifuTileButton14.LabelPosition = 36;
            this.bunifuTileButton14.LabelText = "Tile 1";
            this.bunifuTileButton14.Location = new System.Drawing.Point(711, 428);
            this.bunifuTileButton14.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.bunifuTileButton14.Name = "bunifuTileButton14";
            this.bunifuTileButton14.Size = new System.Drawing.Size(116, 102);
            this.bunifuTileButton14.TabIndex = 28;
            // 
            // bunifuTileButton15
            // 
            this.bunifuTileButton15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuTileButton15.color = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuTileButton15.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuTileButton15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuTileButton15, BunifuAnimatorNS.DecorationType.Custom);
            this.bunifuTileButton15.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.bunifuTileButton15.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton15.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton15.Image")));
            this.bunifuTileButton15.ImagePosition = 18;
            this.bunifuTileButton15.ImageZoom = 50;
            this.bunifuTileButton15.LabelPosition = 36;
            this.bunifuTileButton15.LabelText = "Tile 1";
            this.bunifuTileButton15.Location = new System.Drawing.Point(587, 428);
            this.bunifuTileButton15.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.bunifuTileButton15.Name = "bunifuTileButton15";
            this.bunifuTileButton15.Size = new System.Drawing.Size(116, 102);
            this.bunifuTileButton15.TabIndex = 27;
            // 
            // bunifuTileButton16
            // 
            this.bunifuTileButton16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuTileButton16.color = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuTileButton16.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuTileButton16.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuTileButton16, BunifuAnimatorNS.DecorationType.Custom);
            this.bunifuTileButton16.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.bunifuTileButton16.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton16.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton16.Image")));
            this.bunifuTileButton16.ImagePosition = 18;
            this.bunifuTileButton16.ImageZoom = 50;
            this.bunifuTileButton16.LabelPosition = 36;
            this.bunifuTileButton16.LabelText = "Tile 1";
            this.bunifuTileButton16.Location = new System.Drawing.Point(958, 428);
            this.bunifuTileButton16.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.bunifuTileButton16.Name = "bunifuTileButton16";
            this.bunifuTileButton16.Size = new System.Drawing.Size(116, 102);
            this.bunifuTileButton16.TabIndex = 31;
            // 
            // bunifuTileButton17
            // 
            this.bunifuTileButton17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuTileButton17.color = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuTileButton17.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuTileButton17.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuTileButton17, BunifuAnimatorNS.DecorationType.Custom);
            this.bunifuTileButton17.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.bunifuTileButton17.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton17.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton17.Image")));
            this.bunifuTileButton17.ImagePosition = 18;
            this.bunifuTileButton17.ImageZoom = 50;
            this.bunifuTileButton17.LabelPosition = 36;
            this.bunifuTileButton17.LabelText = "Tile 1";
            this.bunifuTileButton17.Location = new System.Drawing.Point(958, 540);
            this.bunifuTileButton17.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.bunifuTileButton17.Name = "bunifuTileButton17";
            this.bunifuTileButton17.Size = new System.Drawing.Size(116, 102);
            this.bunifuTileButton17.TabIndex = 45;
            // 
            // bunifuTileButton18
            // 
            this.bunifuTileButton18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuTileButton18.color = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuTileButton18.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuTileButton18.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuTileButton18, BunifuAnimatorNS.DecorationType.Custom);
            this.bunifuTileButton18.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.bunifuTileButton18.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton18.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton18.Image")));
            this.bunifuTileButton18.ImagePosition = 18;
            this.bunifuTileButton18.ImageZoom = 50;
            this.bunifuTileButton18.LabelPosition = 36;
            this.bunifuTileButton18.LabelText = "Tile 1";
            this.bunifuTileButton18.Location = new System.Drawing.Point(834, 540);
            this.bunifuTileButton18.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.bunifuTileButton18.Name = "bunifuTileButton18";
            this.bunifuTileButton18.Size = new System.Drawing.Size(116, 102);
            this.bunifuTileButton18.TabIndex = 44;
            // 
            // bunifuTileButton19
            // 
            this.bunifuTileButton19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuTileButton19.color = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuTileButton19.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuTileButton19.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuTileButton19, BunifuAnimatorNS.DecorationType.Custom);
            this.bunifuTileButton19.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.bunifuTileButton19.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton19.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton19.Image")));
            this.bunifuTileButton19.ImagePosition = 18;
            this.bunifuTileButton19.ImageZoom = 50;
            this.bunifuTileButton19.LabelPosition = 36;
            this.bunifuTileButton19.LabelText = "Tile 1";
            this.bunifuTileButton19.Location = new System.Drawing.Point(711, 540);
            this.bunifuTileButton19.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.bunifuTileButton19.Name = "bunifuTileButton19";
            this.bunifuTileButton19.Size = new System.Drawing.Size(116, 102);
            this.bunifuTileButton19.TabIndex = 43;
            // 
            // bunifuTileButton20
            // 
            this.bunifuTileButton20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuTileButton20.color = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuTileButton20.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuTileButton20.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuTileButton20, BunifuAnimatorNS.DecorationType.Custom);
            this.bunifuTileButton20.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.bunifuTileButton20.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton20.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton20.Image")));
            this.bunifuTileButton20.ImagePosition = 18;
            this.bunifuTileButton20.ImageZoom = 50;
            this.bunifuTileButton20.LabelPosition = 36;
            this.bunifuTileButton20.LabelText = "Tile 1";
            this.bunifuTileButton20.Location = new System.Drawing.Point(587, 540);
            this.bunifuTileButton20.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.bunifuTileButton20.Name = "bunifuTileButton20";
            this.bunifuTileButton20.Size = new System.Drawing.Size(116, 102);
            this.bunifuTileButton20.TabIndex = 42;
            // 
            // bunifuTileButton21
            // 
            this.bunifuTileButton21.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuTileButton21.color = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuTileButton21.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuTileButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuTileButton21, BunifuAnimatorNS.DecorationType.Custom);
            this.bunifuTileButton21.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.bunifuTileButton21.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton21.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton21.Image")));
            this.bunifuTileButton21.ImagePosition = 18;
            this.bunifuTileButton21.ImageZoom = 50;
            this.bunifuTileButton21.LabelPosition = 36;
            this.bunifuTileButton21.LabelText = "Tile 1";
            this.bunifuTileButton21.Location = new System.Drawing.Point(464, 540);
            this.bunifuTileButton21.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.bunifuTileButton21.Name = "bunifuTileButton21";
            this.bunifuTileButton21.Size = new System.Drawing.Size(116, 102);
            this.bunifuTileButton21.TabIndex = 41;
            // 
            // bunifuTileButton22
            // 
            this.bunifuTileButton22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuTileButton22.color = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuTileButton22.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuTileButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuTileButton22, BunifuAnimatorNS.DecorationType.Custom);
            this.bunifuTileButton22.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.bunifuTileButton22.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton22.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton22.Image")));
            this.bunifuTileButton22.ImagePosition = 18;
            this.bunifuTileButton22.ImageZoom = 50;
            this.bunifuTileButton22.LabelPosition = 36;
            this.bunifuTileButton22.LabelText = "Tile 1";
            this.bunifuTileButton22.Location = new System.Drawing.Point(341, 540);
            this.bunifuTileButton22.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.bunifuTileButton22.Name = "bunifuTileButton22";
            this.bunifuTileButton22.Size = new System.Drawing.Size(116, 102);
            this.bunifuTileButton22.TabIndex = 40;
            // 
            // bunifuTileButton23
            // 
            this.bunifuTileButton23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuTileButton23.color = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuTileButton23.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(43)))), ((int)(((byte)(69)))));
            this.bunifuTileButton23.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuTileButton23, BunifuAnimatorNS.DecorationType.Custom);
            this.bunifuTileButton23.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.bunifuTileButton23.ForeColor = System.Drawing.Color.White;
            this.bunifuTileButton23.Image = ((System.Drawing.Image)(resources.GetObject("bunifuTileButton23.Image")));
            this.bunifuTileButton23.ImagePosition = 18;
            this.bunifuTileButton23.ImageZoom = 50;
            this.bunifuTileButton23.LabelPosition = 36;
            this.bunifuTileButton23.LabelText = "Tile 1";
            this.bunifuTileButton23.Location = new System.Drawing.Point(218, 540);
            this.bunifuTileButton23.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.bunifuTileButton23.Name = "bunifuTileButton23";
            this.bunifuTileButton23.Size = new System.Drawing.Size(116, 102);
            this.bunifuTileButton23.TabIndex = 39;
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
            this.Opacity = 0.9D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mediator - SCC";
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
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_nom_user;
        public Bunifu.Framework.UI.BunifuTileButton bunifuTileButton1;
        public Bunifu.Framework.UI.BunifuTileButton bunifuTileButton5;
        public Bunifu.Framework.UI.BunifuTileButton bunifuTileButton4;
        public Bunifu.Framework.UI.BunifuTileButton bunifuTileButton3;
        public Bunifu.Framework.UI.BunifuTileButton bunifuTileButton2;
        public Bunifu.Framework.UI.BunifuTileButton bunifuTileButton17;
        public Bunifu.Framework.UI.BunifuTileButton bunifuTileButton18;
        public Bunifu.Framework.UI.BunifuTileButton bunifuTileButton19;
        public Bunifu.Framework.UI.BunifuTileButton bunifuTileButton20;
        public Bunifu.Framework.UI.BunifuTileButton bunifuTileButton21;
        public Bunifu.Framework.UI.BunifuTileButton bunifuTileButton22;
        public Bunifu.Framework.UI.BunifuTileButton bunifuTileButton23;
        public Bunifu.Framework.UI.BunifuTileButton bunifuTileButton16;
        public Bunifu.Framework.UI.BunifuTileButton bunifuTileButton13;
        public Bunifu.Framework.UI.BunifuTileButton bunifuTileButton14;
        public Bunifu.Framework.UI.BunifuTileButton bunifuTileButton15;
        public Bunifu.Framework.UI.BunifuTileButton bunifuTileButton12;
        public Bunifu.Framework.UI.BunifuTileButton bunifuTileButton11;
        public Bunifu.Framework.UI.BunifuTileButton bunifuTileButton10;
        public Bunifu.Framework.UI.BunifuTileButton bunifuTileButton7;
        public Bunifu.Framework.UI.BunifuTileButton bunifuTileButton8;
        public Bunifu.Framework.UI.BunifuTileButton bunifuTileButton9;
    }
}