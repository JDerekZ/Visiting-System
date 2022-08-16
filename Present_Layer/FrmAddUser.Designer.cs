namespace Present_Layer
{
    partial class FrmAddUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddUser));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitle = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblName = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblLastname = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblUserType = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lbNickname = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblPassword = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblEmail = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.tbxEmail = new System.Windows.Forms.MaskedTextBox();
            this.tbxName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tbxLastname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.tbxNickname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.cbxTypeUser = new System.Windows.Forms.ComboBox();
            this.lblConfirmPass = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.tbxPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbxConfirmPass = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnInvisiblePassword = new Guna.UI2.WinForms.Guna2Button();
            this.btnVisiblePassword = new Guna.UI2.WinForms.Guna2Button();
            this.btnClose = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnDelete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnEdit = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSave = new Bunifu.Framework.UI.BunifuFlatButton();
            this.pContainerDgv = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.dgvAddUser = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.pContainerDgv.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddUser)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblTitle.Location = new System.Drawing.Point(12, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(119, 34);
            this.lblTitle.TabIndex = 22;
            this.lblTitle.Text = "Add User:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblName.Location = new System.Drawing.Point(15, 75);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(46, 17);
            this.lblName.TabIndex = 23;
            this.lblName.Text = "Name:";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLastname
            // 
            this.lblLastname.AutoSize = true;
            this.lblLastname.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastname.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblLastname.Location = new System.Drawing.Point(12, 104);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(67, 17);
            this.lblLastname.TabIndex = 24;
            this.lblLastname.Text = "Lastname:";
            this.lblLastname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUserType
            // 
            this.lblUserType.AutoSize = true;
            this.lblUserType.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserType.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblUserType.Location = new System.Drawing.Point(12, 260);
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(87, 17);
            this.lblUserType.TabIndex = 25;
            this.lblUserType.Text = "Type of user:";
            this.lblUserType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbNickname
            // 
            this.lbNickname.AutoSize = true;
            this.lbNickname.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNickname.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lbNickname.Location = new System.Drawing.Point(12, 136);
            this.lbNickname.Name = "lbNickname";
            this.lbNickname.Size = new System.Drawing.Size(70, 17);
            this.lbNickname.TabIndex = 26;
            this.lbNickname.Text = "Nickname:";
            this.lbNickname.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblPassword.Location = new System.Drawing.Point(12, 165);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(68, 17);
            this.lblPassword.TabIndex = 27;
            this.lblPassword.Text = "Password:";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblEmail.Location = new System.Drawing.Point(12, 228);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 17);
            this.lblEmail.TabIndex = 28;
            this.lblEmail.Text = "Email:";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(15, 42);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(645, 10);
            this.bunifuSeparator1.TabIndex = 29;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // tbxEmail
            // 
            this.tbxEmail.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tbxEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbxEmail.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxEmail.Location = new System.Drawing.Point(60, 228);
            this.tbxEmail.Mask = "00000000@itla.edu.do";
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(168, 16);
            this.tbxEmail.TabIndex = 30;
            // 
            // tbxName
            // 
            this.tbxName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbxName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbxName.HintForeColor = System.Drawing.Color.Empty;
            this.tbxName.HintText = "";
            this.tbxName.isPassword = false;
            this.tbxName.LineFocusedColor = System.Drawing.Color.CornflowerBlue;
            this.tbxName.LineIdleColor = System.Drawing.Color.Gray;
            this.tbxName.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(154)))), ((int)(((byte)(115)))));
            this.tbxName.LineThickness = 3;
            this.tbxName.Location = new System.Drawing.Point(68, 72);
            this.tbxName.Margin = new System.Windows.Forms.Padding(4);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(160, 20);
            this.tbxName.TabIndex = 31;
            this.tbxName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tbxLastname
            // 
            this.tbxLastname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxLastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbxLastname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbxLastname.HintForeColor = System.Drawing.Color.Empty;
            this.tbxLastname.HintText = "";
            this.tbxLastname.isPassword = false;
            this.tbxLastname.LineFocusedColor = System.Drawing.Color.CornflowerBlue;
            this.tbxLastname.LineIdleColor = System.Drawing.Color.Gray;
            this.tbxLastname.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(154)))), ((int)(((byte)(115)))));
            this.tbxLastname.LineThickness = 3;
            this.tbxLastname.Location = new System.Drawing.Point(86, 100);
            this.tbxLastname.Margin = new System.Windows.Forms.Padding(4);
            this.tbxLastname.Name = "tbxLastname";
            this.tbxLastname.Size = new System.Drawing.Size(142, 20);
            this.tbxLastname.TabIndex = 32;
            this.tbxLastname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // tbxNickname
            // 
            this.tbxNickname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxNickname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
            this.tbxNickname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbxNickname.HintForeColor = System.Drawing.Color.Empty;
            this.tbxNickname.HintText = "";
            this.tbxNickname.isPassword = false;
            this.tbxNickname.LineFocusedColor = System.Drawing.Color.CornflowerBlue;
            this.tbxNickname.LineIdleColor = System.Drawing.Color.Gray;
            this.tbxNickname.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(154)))), ((int)(((byte)(115)))));
            this.tbxNickname.LineThickness = 3;
            this.tbxNickname.Location = new System.Drawing.Point(86, 133);
            this.tbxNickname.Margin = new System.Windows.Forms.Padding(4);
            this.tbxNickname.Name = "tbxNickname";
            this.tbxNickname.Size = new System.Drawing.Size(142, 20);
            this.tbxNickname.TabIndex = 33;
            this.tbxNickname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // cbxTypeUser
            // 
            this.cbxTypeUser.BackColor = System.Drawing.SystemColors.ControlLight;
            this.cbxTypeUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbxTypeUser.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxTypeUser.FormattingEnabled = true;
            this.cbxTypeUser.Items.AddRange(new object[] {
            "Admin",
            "General"});
            this.cbxTypeUser.Location = new System.Drawing.Point(105, 253);
            this.cbxTypeUser.Name = "cbxTypeUser";
            this.cbxTypeUser.Size = new System.Drawing.Size(123, 23);
            this.cbxTypeUser.TabIndex = 35;
            // 
            // lblConfirmPass
            // 
            this.lblConfirmPass.AutoSize = true;
            this.lblConfirmPass.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPass.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lblConfirmPass.Location = new System.Drawing.Point(12, 198);
            this.lblConfirmPass.Name = "lblConfirmPass";
            this.lblConfirmPass.Size = new System.Drawing.Size(120, 17);
            this.lblConfirmPass.TabIndex = 36;
            this.lblConfirmPass.Text = "Confirm Password:";
            this.lblConfirmPass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbxPassword
            // 
            this.tbxPassword.Animated = true;
            this.tbxPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxPassword.DefaultText = "";
            this.tbxPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbxPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbxPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxPassword.FillColor = System.Drawing.SystemColors.ControlLight;
            this.tbxPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbxPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxPassword.Location = new System.Drawing.Point(86, 161);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.PasswordChar = '\0';
            this.tbxPassword.PlaceholderText = "";
            this.tbxPassword.SelectedText = "";
            this.tbxPassword.Size = new System.Drawing.Size(144, 21);
            this.tbxPassword.TabIndex = 44;
            // 
            // tbxConfirmPass
            // 
            this.tbxConfirmPass.Animated = true;
            this.tbxConfirmPass.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxConfirmPass.DefaultText = "";
            this.tbxConfirmPass.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbxConfirmPass.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbxConfirmPass.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxConfirmPass.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxConfirmPass.FillColor = System.Drawing.SystemColors.ControlLight;
            this.tbxConfirmPass.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxConfirmPass.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbxConfirmPass.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxConfirmPass.Location = new System.Drawing.Point(130, 194);
            this.tbxConfirmPass.Name = "tbxConfirmPass";
            this.tbxConfirmPass.PasswordChar = '\0';
            this.tbxConfirmPass.PlaceholderText = "";
            this.tbxConfirmPass.SelectedText = "";
            this.tbxConfirmPass.Size = new System.Drawing.Size(139, 21);
            this.tbxConfirmPass.TabIndex = 45;
            // 
            // btnInvisiblePassword
            // 
            this.btnInvisiblePassword.Animated = true;
            this.btnInvisiblePassword.AutoRoundedCorners = true;
            this.btnInvisiblePassword.BackColor = System.Drawing.Color.Transparent;
            this.btnInvisiblePassword.BorderRadius = 16;
            this.btnInvisiblePassword.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnInvisiblePassword.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnInvisiblePassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnInvisiblePassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnInvisiblePassword.FillColor = System.Drawing.Color.Transparent;
            this.btnInvisiblePassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnInvisiblePassword.ForeColor = System.Drawing.Color.White;
            this.btnInvisiblePassword.Image = global::Present_Layer.Properties.Resources.eye_disable;
            this.btnInvisiblePassword.ImageSize = new System.Drawing.Size(15, 15);
            this.btnInvisiblePassword.Location = new System.Drawing.Point(235, 152);
            this.btnInvisiblePassword.Name = "btnInvisiblePassword";
            this.btnInvisiblePassword.PressedColor = System.Drawing.Color.CornflowerBlue;
            this.btnInvisiblePassword.Size = new System.Drawing.Size(34, 35);
            this.btnInvisiblePassword.TabIndex = 46;
            this.btnInvisiblePassword.UseTransparentBackground = true;
            this.btnInvisiblePassword.Visible = false;
            this.btnInvisiblePassword.Click += new System.EventHandler(this.btnInvisiblePassword_Click);
            // 
            // btnVisiblePassword
            // 
            this.btnVisiblePassword.Animated = true;
            this.btnVisiblePassword.AutoRoundedCorners = true;
            this.btnVisiblePassword.BackColor = System.Drawing.Color.Transparent;
            this.btnVisiblePassword.BorderRadius = 16;
            this.btnVisiblePassword.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnVisiblePassword.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnVisiblePassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnVisiblePassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnVisiblePassword.FillColor = System.Drawing.Color.Transparent;
            this.btnVisiblePassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnVisiblePassword.ForeColor = System.Drawing.Color.White;
            this.btnVisiblePassword.Image = global::Present_Layer.Properties.Resources.eye_free_icon_font;
            this.btnVisiblePassword.ImageSize = new System.Drawing.Size(15, 15);
            this.btnVisiblePassword.Location = new System.Drawing.Point(235, 152);
            this.btnVisiblePassword.Name = "btnVisiblePassword";
            this.btnVisiblePassword.PressedColor = System.Drawing.Color.CornflowerBlue;
            this.btnVisiblePassword.Size = new System.Drawing.Size(34, 35);
            this.btnVisiblePassword.TabIndex = 43;
            this.btnVisiblePassword.UseTransparentBackground = true;
            this.btnVisiblePassword.Click += new System.EventHandler(this.btnVisiblePassword_Click);
            // 
            // btnClose
            // 
            this.btnClose.ActiveBorderThickness = 1;
            this.btnClose.ActiveCornerRadius = 20;
            this.btnClose.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnClose.ActiveForecolor = System.Drawing.Color.White;
            this.btnClose.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(171)))), ((int)(((byte)(116)))));
            this.btnClose.BackColor = System.Drawing.SystemColors.Control;
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.ButtonText = " Close";
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClose.IdleBorderThickness = 1;
            this.btnClose.IdleCornerRadius = 20;
            this.btnClose.IdleFillColor = System.Drawing.SystemColors.Highlight;
            this.btnClose.IdleForecolor = System.Drawing.SystemColors.Control;
            this.btnClose.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.btnClose.Location = new System.Drawing.Point(614, 9);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(46, 33);
            this.btnClose.TabIndex = 42;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(154)))), ((int)(((byte)(115)))));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.BorderRadius = 0;
            this.btnDelete.ButtonText = "Delete user";
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.DisabledColor = System.Drawing.Color.Gray;
            this.btnDelete.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDelete.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnDelete.Iconimage")));
            this.btnDelete.Iconimage_right = null;
            this.btnDelete.Iconimage_right_Selected = null;
            this.btnDelete.Iconimage_Selected = null;
            this.btnDelete.IconMarginLeft = 0;
            this.btnDelete.IconMarginRight = 0;
            this.btnDelete.IconRightVisible = true;
            this.btnDelete.IconRightZoom = 0D;
            this.btnDelete.IconVisible = true;
            this.btnDelete.IconZoom = 35D;
            this.btnDelete.IsTab = false;
            this.btnDelete.Location = new System.Drawing.Point(280, 306);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(154)))), ((int)(((byte)(115)))));
            this.btnDelete.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDelete.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDelete.selected = false;
            this.btnDelete.Size = new System.Drawing.Size(182, 48);
            this.btnDelete.TabIndex = 41;
            this.btnDelete.Text = "Delete user";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelete.Textcolor = System.Drawing.Color.White;
            this.btnDelete.TextFont = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(154)))), ((int)(((byte)(115)))));
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEdit.BorderRadius = 0;
            this.btnEdit.ButtonText = "Edit user";
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.DisabledColor = System.Drawing.Color.Gray;
            this.btnEdit.Iconcolor = System.Drawing.Color.Transparent;
            this.btnEdit.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnEdit.Iconimage")));
            this.btnEdit.Iconimage_right = null;
            this.btnEdit.Iconimage_right_Selected = null;
            this.btnEdit.Iconimage_Selected = null;
            this.btnEdit.IconMarginLeft = 0;
            this.btnEdit.IconMarginRight = 0;
            this.btnEdit.IconRightVisible = true;
            this.btnEdit.IconRightZoom = 0D;
            this.btnEdit.IconVisible = true;
            this.btnEdit.IconZoom = 35D;
            this.btnEdit.IsTab = false;
            this.btnEdit.Location = new System.Drawing.Point(478, 306);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(154)))), ((int)(((byte)(115)))));
            this.btnEdit.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(139)))), ((int)(((byte)(85)))));
            this.btnEdit.OnHoverTextColor = System.Drawing.Color.White;
            this.btnEdit.selected = false;
            this.btnEdit.Size = new System.Drawing.Size(182, 48);
            this.btnEdit.TabIndex = 40;
            this.btnEdit.Text = "Edit user";
            this.btnEdit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnEdit.Textcolor = System.Drawing.Color.White;
            this.btnEdit.TextFont = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnSave
            // 
            this.btnSave.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(154)))), ((int)(((byte)(115)))));
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(154)))), ((int)(((byte)(115)))));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.BorderRadius = 0;
            this.btnSave.ButtonText = "Save";
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.DisabledColor = System.Drawing.Color.Gray;
            this.btnSave.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSave.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSave.Iconimage")));
            this.btnSave.Iconimage_right = null;
            this.btnSave.Iconimage_right_Selected = null;
            this.btnSave.Iconimage_Selected = null;
            this.btnSave.IconMarginLeft = 0;
            this.btnSave.IconMarginRight = 0;
            this.btnSave.IconRightVisible = true;
            this.btnSave.IconRightZoom = 0D;
            this.btnSave.IconVisible = true;
            this.btnSave.IconZoom = 35D;
            this.btnSave.IsTab = false;
            this.btnSave.Location = new System.Drawing.Point(60, 315);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(154)))), ((int)(((byte)(115)))));
            this.btnSave.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSave.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSave.selected = false;
            this.btnSave.Size = new System.Drawing.Size(134, 33);
            this.btnSave.TabIndex = 39;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSave.Textcolor = System.Drawing.Color.White;
            this.btnSave.TextFont = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // pContainerDgv
            // 
            this.pContainerDgv.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pContainerDgv.BackgroundImage")));
            this.pContainerDgv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pContainerDgv.Controls.Add(this.dgvAddUser);
            this.pContainerDgv.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(0)))));
            this.pContainerDgv.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(221)))), ((int)(((byte)(206)))));
            this.pContainerDgv.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(221)))), ((int)(((byte)(206)))));
            this.pContainerDgv.GradientTopRight = System.Drawing.Color.White;
            this.pContainerDgv.Location = new System.Drawing.Point(280, 55);
            this.pContainerDgv.Name = "pContainerDgv";
            this.pContainerDgv.Quality = 10;
            this.pContainerDgv.Size = new System.Drawing.Size(380, 245);
            this.pContainerDgv.TabIndex = 38;
            // 
            // dgvAddUser
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvAddUser.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAddUser.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvAddUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvAddUser.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAddUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAddUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddUser.DoubleBuffered = true;
            this.dgvAddUser.EnableHeadersVisualStyles = false;
            this.dgvAddUser.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dgvAddUser.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.dgvAddUser.Location = new System.Drawing.Point(3, 3);
            this.dgvAddUser.Name = "dgvAddUser";
            this.dgvAddUser.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvAddUser.Size = new System.Drawing.Size(374, 239);
            this.dgvAddUser.TabIndex = 42;
            // 
            // FrmAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 381);
            this.Controls.Add(this.btnInvisiblePassword);
            this.Controls.Add(this.tbxConfirmPass);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.btnVisiblePassword);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pContainerDgv);
            this.Controls.Add(this.lblConfirmPass);
            this.Controls.Add(this.cbxTypeUser);
            this.Controls.Add(this.tbxNickname);
            this.Controls.Add(this.tbxLastname);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.tbxEmail);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lbNickname);
            this.Controls.Add(this.lblUserType);
            this.Controls.Add(this.lblLastname);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(700, 420);
            this.Name = "FrmAddUser";
            this.Text = "FrmAddUser";
            this.Load += new System.EventHandler(this.FrmAddUser_Load);
            this.pContainerDgv.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel lblTitle;
        private Bunifu.Framework.UI.BunifuCustomLabel lblName;
        private Bunifu.Framework.UI.BunifuCustomLabel lblLastname;
        private Bunifu.Framework.UI.BunifuCustomLabel lblUserType;
        private Bunifu.Framework.UI.BunifuCustomLabel lbNickname;
        private Bunifu.Framework.UI.BunifuCustomLabel lblPassword;
        private Bunifu.Framework.UI.BunifuCustomLabel lblEmail;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.MaskedTextBox tbxEmail;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbxName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbxLastname;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tbxNickname;
        private System.Windows.Forms.ComboBox cbxTypeUser;
        private Bunifu.Framework.UI.BunifuCustomLabel lblConfirmPass;
        private Bunifu.Framework.UI.BunifuGradientPanel pContainerDgv;
        private Bunifu.Framework.UI.BunifuFlatButton btnSave;
        private Bunifu.Framework.UI.BunifuFlatButton btnEdit;
        private Bunifu.Framework.UI.BunifuFlatButton btnDelete;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvAddUser;
        private Bunifu.Framework.UI.BunifuThinButton2 btnClose;
        private Guna.UI2.WinForms.Guna2Button btnVisiblePassword;
        private Guna.UI2.WinForms.Guna2TextBox tbxPassword;
        private Guna.UI2.WinForms.Guna2TextBox tbxConfirmPass;
        private Guna.UI2.WinForms.Guna2Button btnInvisiblePassword;
    }
}