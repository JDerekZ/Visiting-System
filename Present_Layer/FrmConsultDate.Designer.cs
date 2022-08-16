namespace Present_Layer
{
    partial class FrmConsultDate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsultDate));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitle = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btnSearchBuilt = new Bunifu.Framework.UI.BunifuFlatButton();
            this.guna2VSeparator1 = new Guna.UI2.WinForms.Guna2VSeparator();
            this.pDgvContainer = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.dgvConsult = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.btnSearchClassroom = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.btnClose = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbxSearchBuilt = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbxSearchClassroom = new Guna.UI2.WinForms.Guna2TextBox();
            this.pDgvContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsult)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.CadetBlue;
            this.lblTitle.Location = new System.Drawing.Point(274, 7);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(161, 34);
            this.lblTitle.TabIndex = 22;
            this.lblTitle.Text = "Consult Date:";
            // 
            // btnSearchBuilt
            // 
            this.btnSearchBuilt.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(154)))), ((int)(((byte)(115)))));
            this.btnSearchBuilt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(154)))), ((int)(((byte)(115)))));
            this.btnSearchBuilt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchBuilt.BorderRadius = 0;
            this.btnSearchBuilt.ButtonText = "";
            this.btnSearchBuilt.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchBuilt.DisabledColor = System.Drawing.Color.Gray;
            this.btnSearchBuilt.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSearchBuilt.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSearchBuilt.Iconimage")));
            this.btnSearchBuilt.Iconimage_right = null;
            this.btnSearchBuilt.Iconimage_right_Selected = null;
            this.btnSearchBuilt.Iconimage_Selected = null;
            this.btnSearchBuilt.IconMarginLeft = 0;
            this.btnSearchBuilt.IconMarginRight = 0;
            this.btnSearchBuilt.IconRightVisible = true;
            this.btnSearchBuilt.IconRightZoom = 0D;
            this.btnSearchBuilt.IconVisible = true;
            this.btnSearchBuilt.IconZoom = 40D;
            this.btnSearchBuilt.IsTab = false;
            this.btnSearchBuilt.Location = new System.Drawing.Point(238, 88);
            this.btnSearchBuilt.Name = "btnSearchBuilt";
            this.btnSearchBuilt.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(154)))), ((int)(((byte)(115)))));
            this.btnSearchBuilt.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnSearchBuilt.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSearchBuilt.selected = false;
            this.btnSearchBuilt.Size = new System.Drawing.Size(34, 34);
            this.btnSearchBuilt.TabIndex = 24;
            this.btnSearchBuilt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchBuilt.Textcolor = System.Drawing.Color.White;
            this.btnSearchBuilt.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchBuilt.Click += new System.EventHandler(this.btnSearchBuilt_Click);
            // 
            // guna2VSeparator1
            // 
            this.guna2VSeparator1.Location = new System.Drawing.Point(340, 46);
            this.guna2VSeparator1.Name = "guna2VSeparator1";
            this.guna2VSeparator1.Size = new System.Drawing.Size(26, 90);
            this.guna2VSeparator1.TabIndex = 25;
            // 
            // pDgvContainer
            // 
            this.pDgvContainer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pDgvContainer.BackgroundImage")));
            this.pDgvContainer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pDgvContainer.Controls.Add(this.dgvConsult);
            this.pDgvContainer.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(61)))), ((int)(((byte)(0)))));
            this.pDgvContainer.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(221)))), ((int)(((byte)(206)))));
            this.pDgvContainer.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(221)))), ((int)(((byte)(206)))));
            this.pDgvContainer.GradientTopRight = System.Drawing.Color.White;
            this.pDgvContainer.Location = new System.Drawing.Point(60, 152);
            this.pDgvContainer.Name = "pDgvContainer";
            this.pDgvContainer.Quality = 10;
            this.pDgvContainer.Size = new System.Drawing.Size(581, 189);
            this.pDgvContainer.TabIndex = 26;
            // 
            // dgvConsult
            // 
            this.dgvConsult.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvConsult.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvConsult.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.dgvConsult.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvConsult.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConsult.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvConsult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsult.DoubleBuffered = true;
            this.dgvConsult.EnableHeadersVisualStyles = false;
            this.dgvConsult.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.dgvConsult.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.dgvConsult.Location = new System.Drawing.Point(9, 8);
            this.dgvConsult.Name = "dgvConsult";
            this.dgvConsult.ReadOnly = true;
            this.dgvConsult.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvConsult.Size = new System.Drawing.Size(563, 173);
            this.dgvConsult.TabIndex = 0;
            // 
            // btnSearchClassroom
            // 
            this.btnSearchClassroom.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(154)))), ((int)(((byte)(115)))));
            this.btnSearchClassroom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(154)))), ((int)(((byte)(115)))));
            this.btnSearchClassroom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearchClassroom.BorderRadius = 0;
            this.btnSearchClassroom.ButtonText = "";
            this.btnSearchClassroom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchClassroom.DisabledColor = System.Drawing.Color.Gray;
            this.btnSearchClassroom.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSearchClassroom.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSearchClassroom.Iconimage")));
            this.btnSearchClassroom.Iconimage_right = null;
            this.btnSearchClassroom.Iconimage_right_Selected = null;
            this.btnSearchClassroom.Iconimage_Selected = null;
            this.btnSearchClassroom.IconMarginLeft = 0;
            this.btnSearchClassroom.IconMarginRight = 0;
            this.btnSearchClassroom.IconRightVisible = true;
            this.btnSearchClassroom.IconRightZoom = 0D;
            this.btnSearchClassroom.IconVisible = true;
            this.btnSearchClassroom.IconZoom = 40D;
            this.btnSearchClassroom.IsTab = false;
            this.btnSearchClassroom.Location = new System.Drawing.Point(607, 88);
            this.btnSearchClassroom.Name = "btnSearchClassroom";
            this.btnSearchClassroom.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(154)))), ((int)(((byte)(115)))));
            this.btnSearchClassroom.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnSearchClassroom.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSearchClassroom.selected = false;
            this.btnSearchClassroom.Size = new System.Drawing.Size(34, 34);
            this.btnSearchClassroom.TabIndex = 28;
            this.btnSearchClassroom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchClassroom.Textcolor = System.Drawing.Color.White;
            this.btnSearchClassroom.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchClassroom.Click += new System.EventHandler(this.btnSearchClassroom_Click);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(12, 128);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(675, 18);
            this.bunifuSeparator1.TabIndex = 29;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
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
            this.btnClose.Location = new System.Drawing.Point(595, 7);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(46, 33);
            this.btnClose.TabIndex = 30;
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(280, 343);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(138, 39);
            this.panel1.TabIndex = 31;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(138, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tbxSearchBuilt
            // 
            this.tbxSearchBuilt.Animated = true;
            this.tbxSearchBuilt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxSearchBuilt.DefaultText = "";
            this.tbxSearchBuilt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbxSearchBuilt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbxSearchBuilt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxSearchBuilt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxSearchBuilt.FillColor = System.Drawing.SystemColors.ControlLight;
            this.tbxSearchBuilt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxSearchBuilt.Font = new System.Drawing.Font("Malgun Gothic", 9F);
            this.tbxSearchBuilt.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbxSearchBuilt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxSearchBuilt.Location = new System.Drawing.Point(60, 88);
            this.tbxSearchBuilt.Name = "tbxSearchBuilt";
            this.tbxSearchBuilt.PasswordChar = '\0';
            this.tbxSearchBuilt.PlaceholderText = "";
            this.tbxSearchBuilt.SelectedText = "";
            this.tbxSearchBuilt.Size = new System.Drawing.Size(178, 34);
            this.tbxSearchBuilt.TabIndex = 32;
            // 
            // tbxSearchClassroom
            // 
            this.tbxSearchClassroom.Animated = true;
            this.tbxSearchClassroom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbxSearchClassroom.DefaultText = "";
            this.tbxSearchClassroom.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbxSearchClassroom.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbxSearchClassroom.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxSearchClassroom.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbxSearchClassroom.FillColor = System.Drawing.SystemColors.ControlLight;
            this.tbxSearchClassroom.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxSearchClassroom.Font = new System.Drawing.Font("Malgun Gothic", 9F);
            this.tbxSearchClassroom.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbxSearchClassroom.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbxSearchClassroom.Location = new System.Drawing.Point(429, 88);
            this.tbxSearchClassroom.Name = "tbxSearchClassroom";
            this.tbxSearchClassroom.PasswordChar = '\0';
            this.tbxSearchClassroom.PlaceholderText = "";
            this.tbxSearchClassroom.SelectedText = "";
            this.tbxSearchClassroom.Size = new System.Drawing.Size(178, 34);
            this.tbxSearchClassroom.TabIndex = 33;
            // 
            // FrmConsultDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(684, 381);
            this.Controls.Add(this.tbxSearchClassroom);
            this.Controls.Add(this.tbxSearchBuilt);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.guna2VSeparator1);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.btnSearchClassroom);
            this.Controls.Add(this.pDgvContainer);
            this.Controls.Add(this.btnSearchBuilt);
            this.Controls.Add(this.lblTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(700, 420);
            this.Name = "FrmConsultDate";
            this.Text = "Consult Date";
            this.Load += new System.EventHandler(this.FrmConsultDate_Load);
            this.pDgvContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsult)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel lblTitle;
        private Bunifu.Framework.UI.BunifuFlatButton btnSearchBuilt;
        private Guna.UI2.WinForms.Guna2VSeparator guna2VSeparator1;
        private Bunifu.Framework.UI.BunifuGradientPanel pDgvContainer;
        private Bunifu.Framework.UI.BunifuFlatButton btnSearchClassroom;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnClose;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dgvConsult;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2TextBox tbxSearchBuilt;
        private Guna.UI2.WinForms.Guna2TextBox tbxSearchClassroom;
    }
}