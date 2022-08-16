namespace Present_Layer
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.pContainer = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lblNameSystem = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pMenu = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.lblLastname = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnLogOut = new Guna.UI2.WinForms.Guna2GradientButton();
            this.pContainerProlifePic = new System.Windows.Forms.Panel();
            this.pcbxProlife = new System.Windows.Forms.PictureBox();
            this.lblRole = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblEmail = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblinfoLogo = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnAddUser = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnConsultVisit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAddCites = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pBar = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnMin = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnClose = new Bunifu.Framework.UI.BunifuImageButton();
            this.pContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pMenu.SuspendLayout();
            this.pContainerProlifePic.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbxProlife)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            this.SuspendLayout();
            // 
            // pContainer
            // 
            this.pContainer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pContainer.BackgroundImage")));
            this.pContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pContainer.Controls.Add(this.lblNameSystem);
            this.pContainer.Controls.Add(this.pictureBox2);
            this.pContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pContainer.GradientBottomLeft = System.Drawing.Color.White;
            this.pContainer.GradientBottomRight = System.Drawing.Color.White;
            this.pContainer.GradientTopLeft = System.Drawing.Color.White;
            this.pContainer.GradientTopRight = System.Drawing.Color.White;
            this.pContainer.Location = new System.Drawing.Point(200, 29);
            this.pContainer.Name = "pContainer";
            this.pContainer.Quality = 10;
            this.pContainer.Size = new System.Drawing.Size(700, 420);
            this.pContainer.TabIndex = 2;
            // 
            // lblNameSystem
            // 
            this.lblNameSystem.AutoSize = true;
            this.lblNameSystem.BackColor = System.Drawing.Color.Transparent;
            this.lblNameSystem.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameSystem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(122)))));
            this.lblNameSystem.Location = new System.Drawing.Point(321, 278);
            this.lblNameSystem.Name = "lblNameSystem";
            this.lblNameSystem.Size = new System.Drawing.Size(112, 20);
            this.lblNameSystem.TabIndex = 1;
            this.lblNameSystem.Text = "Visiting System";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(214, 102);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(310, 230);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // pMenu
            // 
            this.pMenu.BackColor = System.Drawing.Color.Transparent;
            this.pMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pMenu.BackgroundImage")));
            this.pMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pMenu.Controls.Add(this.lblLastname);
            this.pMenu.Controls.Add(this.btnLogOut);
            this.pMenu.Controls.Add(this.pContainerProlifePic);
            this.pMenu.Controls.Add(this.lblRole);
            this.pMenu.Controls.Add(this.guna2VSeparator1);
            this.pMenu.Controls.Add(this.bunifuCustomLabel1);
            this.pMenu.Controls.Add(this.lblEmail);
            this.pMenu.Controls.Add(this.lblinfoLogo);
            this.pMenu.Controls.Add(this.lblName);
            this.pMenu.Controls.Add(this.btnAddUser);
            this.pMenu.Controls.Add(this.btnConsultVisit);
            this.pMenu.Controls.Add(this.panel1);
            this.pMenu.Controls.Add(this.btnAddCites);
            this.pMenu.Controls.Add(this.pictureBox1);
            this.pMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pMenu.GradientBottomLeft = System.Drawing.Color.White;
            this.pMenu.GradientBottomRight = System.Drawing.Color.White;
            this.pMenu.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(57)))), ((int)(((byte)(103)))));
            this.pMenu.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.pMenu.Location = new System.Drawing.Point(0, 29);
            this.pMenu.Name = "pMenu";
            this.pMenu.Quality = 10;
            this.pMenu.Size = new System.Drawing.Size(200, 420);
            this.pMenu.TabIndex = 1;
            // 
            // lblLastname
            // 
            this.lblLastname.AutoSize = true;
            this.lblLastname.BackColor = System.Drawing.Color.Transparent;
            this.lblLastname.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastname.ForeColor = System.Drawing.SystemColors.Control;
            this.lblLastname.Location = new System.Drawing.Point(82, 134);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(64, 17);
            this.lblLastname.TabIndex = 13;
            this.lblLastname.Text = "Lastname";
            // 
            // btnLogOut
            // 
            this.btnLogOut.Animated = true;
            this.btnLogOut.AutoRoundedCorners = true;
            this.btnLogOut.BorderRadius = 14;
            this.btnLogOut.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.btnLogOut.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogOut.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogOut.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogOut.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogOut.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogOut.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.btnLogOut.FillColor2 = System.Drawing.Color.SeaGreen;
            this.btnLogOut.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnLogOut.ForeColor = System.Drawing.Color.White;
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.Location = new System.Drawing.Point(59, 368);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(122)))));
            this.btnLogOut.Size = new System.Drawing.Size(92, 30);
            this.btnLogOut.TabIndex = 12;
            this.btnLogOut.Text = "Logout";
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // pContainerProlifePic
            // 
            this.pContainerProlifePic.BackColor = System.Drawing.Color.Transparent;
            this.pContainerProlifePic.Controls.Add(this.pcbxProlife);
            this.pContainerProlifePic.Location = new System.Drawing.Point(26, 114);
            this.pContainerProlifePic.Name = "pContainerProlifePic";
            this.pContainerProlifePic.Size = new System.Drawing.Size(45, 45);
            this.pContainerProlifePic.TabIndex = 2;
            // 
            // pcbxProlife
            // 
            this.pcbxProlife.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcbxProlife.Image = ((System.Drawing.Image)(resources.GetObject("pcbxProlife.Image")));
            this.pcbxProlife.Location = new System.Drawing.Point(0, 0);
            this.pcbxProlife.Name = "pcbxProlife";
            this.pcbxProlife.Size = new System.Drawing.Size(45, 45);
            this.pcbxProlife.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbxProlife.TabIndex = 0;
            this.pcbxProlife.TabStop = false;
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.BackColor = System.Drawing.Color.Transparent;
            this.lblRole.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRole.Location = new System.Drawing.Point(83, 107);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(30, 13);
            this.lblRole.TabIndex = 7;
            this.lblRole.Text = "Role";
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.guna2VSeparator1.FillColor = System.Drawing.Color.SeaGreen;
            this.guna2VSeparator1.Location = new System.Drawing.Point(73, 111);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(10, 56);
            this.guna2VSeparator1.TabIndex = 8;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Malgun Gothic Semilight", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.Control;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(56, 56);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(41, 13);
            this.bunifuCustomLabel1.TabIndex = 11;
            this.bunifuCustomLabel1.Text = "system";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Malgun Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.SystemColors.Control;
            this.lblEmail.Location = new System.Drawing.Point(83, 154);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "Email";
            // 
            // lblinfoLogo
            // 
            this.lblinfoLogo.AutoSize = true;
            this.lblinfoLogo.BackColor = System.Drawing.Color.Transparent;
            this.lblinfoLogo.Font = new System.Drawing.Font("Malgun Gothic Semilight", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblinfoLogo.ForeColor = System.Drawing.SystemColors.Control;
            this.lblinfoLogo.Location = new System.Drawing.Point(63, 69);
            this.lblinfoLogo.Name = "lblinfoLogo";
            this.lblinfoLogo.Size = new System.Drawing.Size(65, 17);
            this.lblinfoLogo.TabIndex = 6;
            this.lblinfoLogo.Text = "Welcome:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.BackColor = System.Drawing.Color.Transparent;
            this.lblName.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblName.Location = new System.Drawing.Point(82, 119);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(43, 17);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "Name";
            // 
            // btnAddUser
            // 
            this.btnAddUser.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAddUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.btnAddUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddUser.BorderRadius = 0;
            this.btnAddUser.ButtonText = "   Añadir usuario";
            this.btnAddUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddUser.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddUser.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddUser.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAddUser.Iconimage")));
            this.btnAddUser.Iconimage_right = null;
            this.btnAddUser.Iconimage_right_Selected = null;
            this.btnAddUser.Iconimage_Selected = null;
            this.btnAddUser.IconMarginLeft = 0;
            this.btnAddUser.IconMarginRight = 0;
            this.btnAddUser.IconRightVisible = true;
            this.btnAddUser.IconRightZoom = 0D;
            this.btnAddUser.IconVisible = true;
            this.btnAddUser.IconZoom = 40D;
            this.btnAddUser.IsTab = false;
            this.btnAddUser.Location = new System.Drawing.Point(26, 290);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.btnAddUser.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(122)))));
            this.btnAddUser.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddUser.selected = false;
            this.btnAddUser.Size = new System.Drawing.Size(174, 48);
            this.btnAddUser.TabIndex = 5;
            this.btnAddUser.Text = "   Añadir usuario";
            this.btnAddUser.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddUser.Textcolor = System.Drawing.Color.White;
            this.btnAddUser.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnConsultVisit
            // 
            this.btnConsultVisit.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnConsultVisit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.btnConsultVisit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConsultVisit.BorderRadius = 0;
            this.btnConsultVisit.ButtonText = "   Consultar cita";
            this.btnConsultVisit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultVisit.DisabledColor = System.Drawing.Color.Gray;
            this.btnConsultVisit.Iconcolor = System.Drawing.Color.Transparent;
            this.btnConsultVisit.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnConsultVisit.Iconimage")));
            this.btnConsultVisit.Iconimage_right = null;
            this.btnConsultVisit.Iconimage_right_Selected = null;
            this.btnConsultVisit.Iconimage_Selected = null;
            this.btnConsultVisit.IconMarginLeft = 0;
            this.btnConsultVisit.IconMarginRight = 0;
            this.btnConsultVisit.IconRightVisible = true;
            this.btnConsultVisit.IconRightZoom = 0D;
            this.btnConsultVisit.IconVisible = true;
            this.btnConsultVisit.IconZoom = 40D;
            this.btnConsultVisit.IsTab = false;
            this.btnConsultVisit.Location = new System.Drawing.Point(26, 236);
            this.btnConsultVisit.Name = "btnConsultVisit";
            this.btnConsultVisit.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.btnConsultVisit.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(122)))));
            this.btnConsultVisit.OnHoverTextColor = System.Drawing.Color.White;
            this.btnConsultVisit.selected = false;
            this.btnConsultVisit.Size = new System.Drawing.Size(174, 48);
            this.btnConsultVisit.TabIndex = 4;
            this.btnConsultVisit.Text = "   Consultar cita";
            this.btnConsultVisit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultVisit.Textcolor = System.Drawing.Color.White;
            this.btnConsultVisit.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultVisit.Click += new System.EventHandler(this.btnConsultVisit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Location = new System.Drawing.Point(0, 182);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(27, 156);
            this.panel1.TabIndex = 3;
            // 
            // btnAddCites
            // 
            this.btnAddCites.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAddCites.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.btnAddCites.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddCites.BorderRadius = 0;
            this.btnAddCites.ButtonText = "   Añadir cita";
            this.btnAddCites.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCites.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddCites.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddCites.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAddCites.Iconimage")));
            this.btnAddCites.Iconimage_right = null;
            this.btnAddCites.Iconimage_right_Selected = null;
            this.btnAddCites.Iconimage_Selected = null;
            this.btnAddCites.IconMarginLeft = 0;
            this.btnAddCites.IconMarginRight = 0;
            this.btnAddCites.IconRightVisible = true;
            this.btnAddCites.IconRightZoom = 0D;
            this.btnAddCites.IconVisible = true;
            this.btnAddCites.IconZoom = 40D;
            this.btnAddCites.IsTab = false;
            this.btnAddCites.Location = new System.Drawing.Point(26, 182);
            this.btnAddCites.Name = "btnAddCites";
            this.btnAddCites.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.btnAddCites.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(122)))));
            this.btnAddCites.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddCites.selected = false;
            this.btnAddCites.Size = new System.Drawing.Size(174, 48);
            this.btnAddCites.TabIndex = 2;
            this.btnAddCites.Text = "   Añadir cita";
            this.btnAddCites.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddCites.Textcolor = System.Drawing.Color.White;
            this.btnAddCites.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCites.Click += new System.EventHandler(this.btnAddCites_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // pBar
            // 
            this.pBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pBar.BackgroundImage")));
            this.pBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pBar.Controls.Add(this.btnMin);
            this.pBar.Controls.Add(this.btnClose);
            this.pBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pBar.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(169)))), ((int)(((byte)(254)))));
            this.pBar.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.pBar.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(169)))), ((int)(((byte)(254)))));
            this.pBar.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.pBar.Location = new System.Drawing.Point(0, 0);
            this.pBar.Name = "pBar";
            this.pBar.Quality = 10;
            this.pBar.Size = new System.Drawing.Size(900, 29);
            this.pBar.TabIndex = 0;
            this.pBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pBar_MouseDown);
            // 
            // btnMin
            // 
            this.btnMin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMin.BackColor = System.Drawing.Color.Transparent;
            this.btnMin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMin.Image = ((System.Drawing.Image)(resources.GetObject("btnMin.Image")));
            this.btnMin.ImageActive = null;
            this.btnMin.Location = new System.Drawing.Point(850, 3);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(20, 20);
            this.btnMin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnMin.TabIndex = 1;
            this.btnMin.TabStop = false;
            this.btnMin.Zoom = 10;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.Location = new System.Drawing.Point(876, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(20, 20);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 0;
            this.btnClose.TabStop = false;
            this.btnClose.Zoom = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(900, 449);
            this.Controls.Add(this.pContainer);
            this.Controls.Add(this.pMenu);
            this.Controls.Add(this.pBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(890, 418);
            this.Name = "FrmMain";
            this.Opacity = 0.96D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Visiting System";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.pContainer.ResumeLayout(false);
            this.pContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pMenu.ResumeLayout(false);
            this.pMenu.PerformLayout();
            this.pContainerProlifePic.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbxProlife)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuGradientPanel pBar;
        private Bunifu.Framework.UI.BunifuImageButton btnMin;
        private Bunifu.Framework.UI.BunifuImageButton btnClose;
        private Bunifu.Framework.UI.BunifuGradientPanel pMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddCites;
        private Bunifu.Framework.UI.BunifuFlatButton btnAddUser;
        private Bunifu.Framework.UI.BunifuFlatButton btnConsultVisit;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuGradientPanel pContainer;
        private Bunifu.Framework.UI.BunifuCustomLabel lblNameSystem;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Bunifu.Framework.UI.BunifuCustomLabel lblRole;
        private Bunifu.Framework.UI.BunifuCustomLabel lblinfoLogo;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        private System.Windows.Forms.Panel pContainerProlifePic;
        private System.Windows.Forms.PictureBox pcbxProlife;
        private Bunifu.Framework.UI.BunifuCustomLabel lblEmail;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Guna.UI2.WinForms.Guna2GradientButton btnLogOut;
        private Bunifu.Framework.UI.BunifuCustomLabel lblLastname;
        private Bunifu.Framework.UI.BunifuCustomLabel lblName;
    }
}