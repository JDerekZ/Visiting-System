namespace Present_Layer
{
    partial class FrmLoadScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLoadScreen));
            this.pbxImage = new System.Windows.Forms.PictureBox();
            this.pNBar = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lblWelcome = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblUser = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.CircleProgressBar = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.lblRole = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.lblNickName = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage)).BeginInit();
            this.pNBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxImage
            // 
            this.pbxImage.BackColor = System.Drawing.Color.Transparent;
            this.pbxImage.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbxImage.Image = ((System.Drawing.Image)(resources.GetObject("pbxImage.Image")));
            this.pbxImage.Location = new System.Drawing.Point(0, 49);
            this.pbxImage.Name = "pbxImage";
            this.pbxImage.Size = new System.Drawing.Size(452, 283);
            this.pbxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxImage.TabIndex = 1;
            this.pbxImage.TabStop = false;
            // 
            // pNBar
            // 
            this.pNBar.Controls.Add(this.lblNickName);
            this.pNBar.Controls.Add(this.lblRole);
            this.pNBar.Controls.Add(this.bunifuCustomLabel2);
            this.pNBar.Controls.Add(this.bunifuCustomLabel1);
            this.pNBar.Controls.Add(this.pictureBox1);
            this.pNBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pNBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(122)))));
            this.pNBar.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(122)))));
            this.pNBar.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(122)))));
            this.pNBar.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(27)))), ((int)(((byte)(52)))));
            this.pNBar.Location = new System.Drawing.Point(0, 0);
            this.pNBar.Name = "pNBar";
            this.pNBar.Size = new System.Drawing.Size(680, 49);
            this.pNBar.TabIndex = 0;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Malgun Gothic Semilight", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.SystemColors.Control;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(86, 9);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(41, 13);
            this.bunifuCustomLabel2.TabIndex = 13;
            this.bunifuCustomLabel2.Text = "Visiting";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Malgun Gothic Semilight", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.SystemColors.Control;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(92, 22);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(41, 13);
            this.bunifuCustomLabel1.TabIndex = 12;
            this.bunifuCustomLabel1.Text = "system";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-43, -15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(196, 82);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.BackColor = System.Drawing.Color.Transparent;
            this.lblWelcome.Font = new System.Drawing.Font("Malgun Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWelcome.ForeColor = System.Drawing.SystemColors.Control;
            this.lblWelcome.Location = new System.Drawing.Point(315, 62);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(258, 65);
            this.lblWelcome.TabIndex = 2;
            this.lblWelcome.Text = "WELCOME";
            // 
            // lblUser
            // 
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.SystemColors.Control;
            this.lblUser.Location = new System.Drawing.Point(447, 130);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(76, 22);
            this.lblUser.TabIndex = 3;
            this.lblUser.Text = "Name user";
            // 
            // CircleProgressBar
            // 
            this.CircleProgressBar.Animated = true;
            this.CircleProgressBar.BackColor = System.Drawing.Color.Transparent;
            this.CircleProgressBar.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.CircleProgressBar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(122)))));
            this.CircleProgressBar.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CircleProgressBar.ForeColor = System.Drawing.Color.White;
            this.CircleProgressBar.Location = new System.Drawing.Point(422, 200);
            this.CircleProgressBar.Minimum = 0;
            this.CircleProgressBar.Name = "CircleProgressBar";
            this.CircleProgressBar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(169)))), ((int)(((byte)(254)))));
            this.CircleProgressBar.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(134)))), ((int)(((byte)(247)))));
            this.CircleProgressBar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.CircleProgressBar.ShowText = true;
            this.CircleProgressBar.Size = new System.Drawing.Size(103, 103);
            this.CircleProgressBar.TabIndex = 4;
            this.CircleProgressBar.Text = "0";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.BackColor = System.Drawing.Color.Transparent;
            this.lblRole.Font = new System.Drawing.Font("Malgun Gothic Semilight", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.ForeColor = System.Drawing.SystemColors.Control;
            this.lblRole.Location = new System.Drawing.Point(526, 25);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(29, 13);
            this.lblRole.TabIndex = 14;
            this.lblRole.Text = "Role:";
            // 
            // lblNickName
            // 
            this.lblNickName.AutoSize = true;
            this.lblNickName.BackColor = System.Drawing.Color.Transparent;
            this.lblNickName.Font = new System.Drawing.Font("Malgun Gothic Semilight", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNickName.ForeColor = System.Drawing.SystemColors.Control;
            this.lblNickName.Location = new System.Drawing.Point(526, 9);
            this.lblNickName.Name = "lblNickName";
            this.lblNickName.Size = new System.Drawing.Size(56, 13);
            this.lblNickName.TabIndex = 15;
            this.lblNickName.Text = "Nickname:";
            // 
            // FrmLoadScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(53)))), ((int)(((byte)(122)))));
            this.ClientSize = new System.Drawing.Size(680, 332);
            this.Controls.Add(this.CircleProgressBar);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblWelcome);
            this.Controls.Add(this.pbxImage);
            this.Controls.Add(this.pNBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmLoadScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.FrmLoadScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxImage)).EndInit();
            this.pNBar.ResumeLayout(false);
            this.pNBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxImage;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel pNBar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private Bunifu.Framework.UI.BunifuCustomLabel lblWelcome;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblUser;
        private Guna.UI2.WinForms.Guna2CircleProgressBar CircleProgressBar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel lblNickName;
        private Bunifu.Framework.UI.BunifuCustomLabel lblRole;
    }
}