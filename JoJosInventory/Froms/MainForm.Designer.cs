namespace JoJosInventory
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            pnTop = new Panel();
            btnUser = new Button();
            lblTitle = new Label();
            picMain = new PictureBox();
            flMenu = new FlowLayoutPanel();
            pnCo = new Panel();
            btnCO = new Button();
            pnMo = new Panel();
            bntMo = new Button();
            pnDmp = new Panel();
            btnDmp = new Button();
            imageList = new ImageList(components);
            flDamage = new FlowLayoutPanel();
            pnDPp = new Panel();
            btnDmPp = new Button();
            pnDBm = new Panel();
            btnDmBm = new Button();
            pnPp = new Panel();
            btnPpl = new Button();
            pnBm = new Panel();
            btnBaseMaterial = new Button();
            pnAu = new Panel();
            btnAdmin = new Button();
            timerSubMenuTransition = new System.Windows.Forms.Timer(components);
            timerMenuTransition = new System.Windows.Forms.Timer(components);
            pnMain = new Panel();
            pnTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picMain).BeginInit();
            flMenu.SuspendLayout();
            pnCo.SuspendLayout();
            pnMo.SuspendLayout();
            pnDmp.SuspendLayout();
            flDamage.SuspendLayout();
            pnDPp.SuspendLayout();
            pnDBm.SuspendLayout();
            pnPp.SuspendLayout();
            pnBm.SuspendLayout();
            pnAu.SuspendLayout();
            SuspendLayout();
            // 
            // pnTop
            // 
            pnTop.BackColor = Color.WhiteSmoke;
            pnTop.BorderStyle = BorderStyle.FixedSingle;
            pnTop.Controls.Add(btnUser);
            pnTop.Controls.Add(lblTitle);
            pnTop.Controls.Add(picMain);
            pnTop.Dock = DockStyle.Top;
            pnTop.Location = new Point(0, 0);
            pnTop.Margin = new Padding(3, 4, 3, 4);
            pnTop.Name = "pnTop";
            pnTop.Size = new Size(1125, 43);
            pnTop.TabIndex = 0;
            // 
            // btnUser
            // 
            btnUser.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnUser.AutoSize = true;
            btnUser.FlatAppearance.BorderSize = 0;
            btnUser.FlatStyle = FlatStyle.Flat;
            btnUser.Location = new Point(1016, 0);
            btnUser.Margin = new Padding(3, 4, 3, 4);
            btnUser.Name = "btnUser";
            btnUser.Size = new Size(104, 40);
            btnUser.TabIndex = 3;
            btnUser.Text = "John Smith";
            btnUser.UseVisualStyleBackColor = true;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.Location = new Point(48, 12);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(215, 20);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Jojos Inventory Management";
            // 
            // picMain
            // 
            picMain.BackColor = Color.Transparent;
            picMain.Image = (Image)resources.GetObject("picMain.Image");
            picMain.Location = new Point(10, 8);
            picMain.Margin = new Padding(3, 4, 3, 4);
            picMain.Name = "picMain";
            picMain.Size = new Size(24, 24);
            picMain.SizeMode = PictureBoxSizeMode.AutoSize;
            picMain.TabIndex = 1;
            picMain.TabStop = false;
            picMain.Click += picMain_Click;
            // 
            // flMenu
            // 
            flMenu.BackColor = Color.WhiteSmoke;
            flMenu.Controls.Add(pnCo);
            flMenu.Controls.Add(pnMo);
            flMenu.Controls.Add(pnDmp);
            flMenu.Controls.Add(flDamage);
            flMenu.Controls.Add(pnPp);
            flMenu.Controls.Add(pnBm);
            flMenu.Controls.Add(pnAu);
            flMenu.Dock = DockStyle.Left;
            flMenu.Location = new Point(0, 43);
            flMenu.Margin = new Padding(3, 4, 3, 4);
            flMenu.Name = "flMenu";
            flMenu.Size = new Size(265, 705);
            flMenu.TabIndex = 1;
            // 
            // pnCo
            // 
            pnCo.Controls.Add(btnCO);
            pnCo.Location = new Point(3, 4);
            pnCo.Margin = new Padding(3, 4, 3, 4);
            pnCo.Name = "pnCo";
            pnCo.Size = new Size(263, 41);
            pnCo.TabIndex = 3;
            pnCo.Tag = "Co";
            // 
            // btnCO
            // 
            btnCO.BackColor = Color.WhiteSmoke;
            btnCO.Dock = DockStyle.Fill;
            btnCO.FlatAppearance.BorderSize = 0;
            btnCO.FlatStyle = FlatStyle.Flat;
            btnCO.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnCO.ForeColor = Color.Black;
            btnCO.Image = (Image)resources.GetObject("btnCO.Image");
            btnCO.ImageAlign = ContentAlignment.MiddleLeft;
            btnCO.Location = new Point(0, 0);
            btnCO.Margin = new Padding(3, 4, 3, 4);
            btnCO.Name = "btnCO";
            btnCO.Size = new Size(263, 41);
            btnCO.TabIndex = 1;
            btnCO.Tag = "Co";
            btnCO.Text = "            Customer Orders";
            btnCO.TextAlign = ContentAlignment.MiddleLeft;
            btnCO.UseVisualStyleBackColor = false;
            btnCO.Click += btnMenu_Click;
            // 
            // pnMo
            // 
            pnMo.Controls.Add(bntMo);
            pnMo.Location = new Point(3, 53);
            pnMo.Margin = new Padding(3, 4, 3, 4);
            pnMo.Name = "pnMo";
            pnMo.Size = new Size(263, 41);
            pnMo.TabIndex = 4;
            pnMo.Tag = "Mo";
            // 
            // bntMo
            // 
            bntMo.BackColor = Color.WhiteSmoke;
            bntMo.Dock = DockStyle.Fill;
            bntMo.FlatAppearance.BorderSize = 0;
            bntMo.FlatStyle = FlatStyle.Flat;
            bntMo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            bntMo.ForeColor = Color.Black;
            bntMo.Image = (Image)resources.GetObject("bntMo.Image");
            bntMo.ImageAlign = ContentAlignment.MiddleLeft;
            bntMo.Location = new Point(0, 0);
            bntMo.Margin = new Padding(3, 4, 3, 4);
            bntMo.Name = "bntMo";
            bntMo.Size = new Size(263, 41);
            bntMo.TabIndex = 1;
            bntMo.Tag = "Mo";
            bntMo.Text = "            Manufacturing Orders";
            bntMo.TextAlign = ContentAlignment.MiddleLeft;
            bntMo.UseVisualStyleBackColor = false;
            bntMo.Click += btnMenu_Click;
            // 
            // pnDmp
            // 
            pnDmp.Controls.Add(btnDmp);
            pnDmp.Location = new Point(3, 102);
            pnDmp.Margin = new Padding(3, 4, 3, 0);
            pnDmp.Name = "pnDmp";
            pnDmp.Size = new Size(263, 41);
            pnDmp.TabIndex = 6;
            pnDmp.Tag = "Dm";
            // 
            // btnDmp
            // 
            btnDmp.BackColor = Color.WhiteSmoke;
            btnDmp.Dock = DockStyle.Fill;
            btnDmp.FlatAppearance.BorderSize = 0;
            btnDmp.FlatStyle = FlatStyle.Flat;
            btnDmp.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDmp.ForeColor = Color.Black;
            btnDmp.ImageAlign = ContentAlignment.MiddleLeft;
            btnDmp.ImageIndex = 2;
            btnDmp.ImageList = imageList;
            btnDmp.Location = new Point(0, 0);
            btnDmp.Margin = new Padding(3, 0, 3, 4);
            btnDmp.Name = "btnDmp";
            btnDmp.Size = new Size(263, 41);
            btnDmp.TabIndex = 2;
            btnDmp.Tag = "Dp";
            btnDmp.Text = "            Damaged and missing products";
            btnDmp.TextAlign = ContentAlignment.MiddleLeft;
            btnDmp.UseVisualStyleBackColor = false;
            btnDmp.Click += btnDmp_Click;
            // 
            // imageList
            // 
            imageList.ColorDepth = ColorDepth.Depth8Bit;
            imageList.ImageStream = (ImageListStreamer)resources.GetObject("imageList.ImageStream");
            imageList.TransparentColor = Color.Transparent;
            imageList.Images.SetKeyName(0, "chevron_left_FILL0_wght400_GRAD0_opsz24.png");
            imageList.Images.SetKeyName(1, "expand_less_FILL0_wght400_GRAD0_opsz24.png");
            imageList.Images.SetKeyName(2, "expand_more_FILL0_wght400_GRAD0_opsz24.png");
            imageList.Images.SetKeyName(3, "menu_open_FILL0_wght400_GRAD0_opsz24.png");
            imageList.Images.SetKeyName(4, "menu_FILL0_wght400_GRAD0_opsz24.png");
            // 
            // flDamage
            // 
            flDamage.BackColor = Color.Gainsboro;
            flDamage.Controls.Add(pnDPp);
            flDamage.Controls.Add(pnDBm);
            flDamage.Location = new Point(0, 143);
            flDamage.Margin = new Padding(0);
            flDamage.Name = "flDamage";
            flDamage.Size = new Size(263, 99);
            flDamage.TabIndex = 4;
            flDamage.Tag = "Dm";
            flDamage.Paint += flDamage_Paint;
            // 
            // pnDPp
            // 
            pnDPp.Controls.Add(btnDmPp);
            pnDPp.Location = new Point(3, 0);
            pnDPp.Margin = new Padding(3, 0, 0, 0);
            pnDPp.Name = "pnDPp";
            pnDPp.Size = new Size(263, 41);
            pnDPp.TabIndex = 7;
            // 
            // btnDmPp
            // 
            btnDmPp.BackColor = Color.Gainsboro;
            btnDmPp.Dock = DockStyle.Fill;
            btnDmPp.FlatAppearance.BorderSize = 0;
            btnDmPp.FlatStyle = FlatStyle.Flat;
            btnDmPp.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDmPp.ForeColor = Color.Black;
            btnDmPp.Image = (Image)resources.GetObject("btnDmPp.Image");
            btnDmPp.ImageAlign = ContentAlignment.MiddleLeft;
            btnDmPp.Location = new Point(0, 0);
            btnDmPp.Margin = new Padding(3, 0, 3, 0);
            btnDmPp.Name = "btnDmPp";
            btnDmPp.Size = new Size(263, 41);
            btnDmPp.TabIndex = 2;
            btnDmPp.Tag = "DmPp";
            btnDmPp.Text = "            Printed Products";
            btnDmPp.TextAlign = ContentAlignment.MiddleLeft;
            btnDmPp.UseVisualStyleBackColor = false;
            btnDmPp.Click += btnMenu_Click;
            // 
            // pnDBm
            // 
            pnDBm.Controls.Add(btnDmBm);
            pnDBm.Location = new Point(3, 45);
            pnDBm.Margin = new Padding(3, 4, 3, 4);
            pnDBm.Name = "pnDBm";
            pnDBm.Size = new Size(263, 41);
            pnDBm.TabIndex = 8;
            // 
            // btnDmBm
            // 
            btnDmBm.BackColor = Color.Gainsboro;
            btnDmBm.Dock = DockStyle.Fill;
            btnDmBm.FlatAppearance.BorderSize = 0;
            btnDmBm.FlatStyle = FlatStyle.Flat;
            btnDmBm.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnDmBm.ForeColor = Color.Black;
            btnDmBm.Image = (Image)resources.GetObject("btnDmBm.Image");
            btnDmBm.ImageAlign = ContentAlignment.MiddleLeft;
            btnDmBm.Location = new Point(0, 0);
            btnDmBm.Margin = new Padding(3, 0, 3, 0);
            btnDmBm.Name = "btnDmBm";
            btnDmBm.Size = new Size(263, 41);
            btnDmBm.TabIndex = 2;
            btnDmBm.Tag = "DmBm";
            btnDmBm.Text = "            Base Material";
            btnDmBm.TextAlign = ContentAlignment.MiddleLeft;
            btnDmBm.UseVisualStyleBackColor = false;
            btnDmBm.Click += btnMenu_Click;
            // 
            // pnPp
            // 
            pnPp.Controls.Add(btnPpl);
            pnPp.Location = new Point(3, 246);
            pnPp.Margin = new Padding(3, 4, 3, 4);
            pnPp.Name = "pnPp";
            pnPp.Size = new Size(263, 41);
            pnPp.TabIndex = 4;
            pnPp.Tag = "Pp";
            // 
            // btnPpl
            // 
            btnPpl.BackColor = Color.WhiteSmoke;
            btnPpl.Dock = DockStyle.Fill;
            btnPpl.FlatAppearance.BorderSize = 0;
            btnPpl.FlatStyle = FlatStyle.Flat;
            btnPpl.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnPpl.ForeColor = Color.Black;
            btnPpl.Image = (Image)resources.GetObject("btnPpl.Image");
            btnPpl.ImageAlign = ContentAlignment.MiddleLeft;
            btnPpl.Location = new Point(0, 0);
            btnPpl.Margin = new Padding(3, 4, 3, 4);
            btnPpl.Name = "btnPpl";
            btnPpl.Size = new Size(263, 41);
            btnPpl.TabIndex = 1;
            btnPpl.Tag = "Pp";
            btnPpl.Text = "            Printed Product List";
            btnPpl.TextAlign = ContentAlignment.MiddleLeft;
            btnPpl.UseVisualStyleBackColor = false;
            btnPpl.Click += btnMenu_Click;
            // 
            // pnBm
            // 
            pnBm.Controls.Add(btnBaseMaterial);
            pnBm.Location = new Point(3, 295);
            pnBm.Margin = new Padding(3, 4, 3, 4);
            pnBm.Name = "pnBm";
            pnBm.Size = new Size(263, 41);
            pnBm.TabIndex = 5;
            pnBm.Tag = "Bm";
            // 
            // btnBaseMaterial
            // 
            btnBaseMaterial.BackColor = Color.WhiteSmoke;
            btnBaseMaterial.Dock = DockStyle.Fill;
            btnBaseMaterial.FlatAppearance.BorderSize = 0;
            btnBaseMaterial.FlatStyle = FlatStyle.Flat;
            btnBaseMaterial.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnBaseMaterial.ForeColor = Color.Black;
            btnBaseMaterial.Image = (Image)resources.GetObject("btnBaseMaterial.Image");
            btnBaseMaterial.ImageAlign = ContentAlignment.MiddleLeft;
            btnBaseMaterial.Location = new Point(0, 0);
            btnBaseMaterial.Margin = new Padding(3, 4, 3, 4);
            btnBaseMaterial.Name = "btnBaseMaterial";
            btnBaseMaterial.Size = new Size(263, 41);
            btnBaseMaterial.TabIndex = 1;
            btnBaseMaterial.Tag = "Bm";
            btnBaseMaterial.Text = "            Base Material";
            btnBaseMaterial.TextAlign = ContentAlignment.MiddleLeft;
            btnBaseMaterial.UseVisualStyleBackColor = false;
            btnBaseMaterial.Click += btnMenu_Click;
            // 
            // pnAu
            // 
            pnAu.Controls.Add(btnAdmin);
            pnAu.Location = new Point(3, 344);
            pnAu.Margin = new Padding(3, 4, 3, 4);
            pnAu.Name = "pnAu";
            pnAu.Size = new Size(263, 41);
            pnAu.TabIndex = 5;
            pnAu.Tag = "Au";
            // 
            // btnAdmin
            // 
            btnAdmin.BackColor = Color.WhiteSmoke;
            btnAdmin.Dock = DockStyle.Fill;
            btnAdmin.FlatAppearance.BorderSize = 0;
            btnAdmin.FlatStyle = FlatStyle.Flat;
            btnAdmin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdmin.ForeColor = Color.Black;
            btnAdmin.Image = (Image)resources.GetObject("btnAdmin.Image");
            btnAdmin.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdmin.Location = new Point(0, 0);
            btnAdmin.Margin = new Padding(3, 4, 3, 4);
            btnAdmin.Name = "btnAdmin";
            btnAdmin.Size = new Size(263, 41);
            btnAdmin.TabIndex = 1;
            btnAdmin.Tag = "Au";
            btnAdmin.Text = "            Admin User";
            btnAdmin.TextAlign = ContentAlignment.MiddleLeft;
            btnAdmin.UseVisualStyleBackColor = false;
            btnAdmin.Click += btnMenu_Click;
            // 
            // timerSubMenuTransition
            // 
            timerSubMenuTransition.Interval = 10;
            timerSubMenuTransition.Tick += timerSubMenuTransition_Tick;
            // 
            // timerMenuTransition
            // 
            timerMenuTransition.Interval = 10;
            timerMenuTransition.Tick += timerMenuTransition_Tick;
            // 
            // pnMain
            // 
            pnMain.BackColor = Color.IndianRed;
            pnMain.Dock = DockStyle.Fill;
            pnMain.Location = new Point(265, 43);
            pnMain.Margin = new Padding(3, 4, 3, 4);
            pnMain.Name = "pnMain";
            pnMain.Size = new Size(860, 705);
            pnMain.TabIndex = 2;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1125, 748);
            Controls.Add(pnMain);
            Controls.Add(flMenu);
            Controls.Add(pnTop);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MinimumSize = new Size(1140, 784);
            Name = "MainForm";
            Text = "JIM";
            Load += MainForm_Load;
            pnTop.ResumeLayout(false);
            pnTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picMain).EndInit();
            flMenu.ResumeLayout(false);
            pnCo.ResumeLayout(false);
            pnMo.ResumeLayout(false);
            pnDmp.ResumeLayout(false);
            flDamage.ResumeLayout(false);
            pnDPp.ResumeLayout(false);
            pnDBm.ResumeLayout(false);
            pnPp.ResumeLayout(false);
            pnBm.ResumeLayout(false);
            pnAu.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnTop;
        private PictureBox picMain;
        private Label lblTitle;
        private FlowLayoutPanel flMenu;
        private Panel pnCo;
        private Button btnCO;
        private FlowLayoutPanel flDamage;
        private Panel pnMo;
        private Button bntMo;
        private Panel pnDmp;
        private Button btnDmp;
        private Panel pnDPp;
        private Button btnDmPp;
        private Panel pnDBm;
        private Button btnDmBm;
        private Button btnUser;
        private Panel pnPp;
        private Button btnPpl;
        private Panel pnBm;
        private Button btnBaseMaterial;
        private Panel pnAu;
        private Button btnAdmin;
        private System.Windows.Forms.Timer timerSubMenuTransition;
        private ImageList imageList;
        private System.Windows.Forms.Timer timerMenuTransition;
        private Panel pnMain;
    }
}