namespace exam_registration_system.MainForms.NVNL
{
    partial class HomeNVNLForm
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.labelHeader = new System.Windows.Forms.Label();
            this.logo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ButHome = new Guna.UI2.WinForms.Guna2Button();
            this.menuContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.menu = new Guna.UI2.WinForms.Guna2Button();
            this.butViewSheet = new Guna.UI2.WinForms.Guna2Button();
            this.butHandleExtend = new Guna.UI2.WinForms.Guna2Button();
            this.butRecordCertificate = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.butLogout = new Guna.UI2.WinForms.Guna2Button();
            this.panelContent = new Guna.UI2.WinForms.Guna2Panel();
            this.menuTransaction = new System.Windows.Forms.Timer(this.components);
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.sidebar.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panelHeader.Controls.Add(this.btnExit);
            this.panelHeader.Controls.Add(this.guna2PictureBox1);
            this.panelHeader.Controls.Add(this.labelHeader);
            this.panelHeader.Controls.Add(this.logo);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1040, 51);
            this.panelHeader.TabIndex = 39;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExit.FillColor = System.Drawing.Color.Transparent;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.ImageSize = new System.Drawing.Size(50, 50);
            this.btnExit.Location = new System.Drawing.Point(1001, 4);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(37, 30);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "✕";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::exam_registration_system.Properties.Resources.logo_icon;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(7, 3);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(65, 45);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 17;
            this.guna2PictureBox1.TabStop = false;
            // 
            // labelHeader
            // 
            this.labelHeader.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.ForeColor = System.Drawing.Color.White;
            this.labelHeader.Location = new System.Drawing.Point(74, 12);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(493, 33);
            this.labelHeader.TabIndex = 24;
            this.labelHeader.Text = "HỆ THỐNG TỔ CHỨC THI CHỨNG CHỈ ANH NGỮ VÀ TIN HỌC ACCI\r\n\r\n";
            // 
            // logo
            // 
            this.logo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.logo.FillColor = System.Drawing.Color.Transparent;
            this.logo.ImageRotate = 0F;
            this.logo.Location = new System.Drawing.Point(3, 4);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(65, 45);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo.TabIndex = 16;
            this.logo.TabStop = false;
            // 
            // sidebar
            // 
            this.sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.sidebar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sidebar.Controls.Add(this.panel2);
            this.sidebar.Controls.Add(this.menuContainer);
            this.sidebar.Controls.Add(this.panel1);
            this.sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebar.Location = new System.Drawing.Point(0, 51);
            this.sidebar.Name = "sidebar";
            this.sidebar.Size = new System.Drawing.Size(143, 672);
            this.sidebar.TabIndex = 42;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.ButHome);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(140, 43);
            this.panel2.TabIndex = 18;
            // 
            // ButHome
            // 
            this.ButHome.BackColor = System.Drawing.Color.Transparent;
            this.ButHome.CheckedState.FillColor = System.Drawing.Color.Gainsboro;
            this.ButHome.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButHome.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButHome.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButHome.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButHome.FillColor = System.Drawing.Color.Transparent;
            this.ButHome.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButHome.ForeColor = System.Drawing.Color.White;
            this.ButHome.Image = global::exam_registration_system.Properties.Resources.home_icon;
            this.ButHome.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ButHome.ImageOffset = new System.Drawing.Point(2, 0);
            this.ButHome.ImageSize = new System.Drawing.Size(18, 18);
            this.ButHome.Location = new System.Drawing.Point(0, 1);
            this.ButHome.Name = "ButHome";
            this.ButHome.Size = new System.Drawing.Size(137, 40);
            this.ButHome.TabIndex = 6;
            this.ButHome.Text = "  Trang chủ ";
            this.ButHome.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ButHome.Click += new System.EventHandler(this.ButHome_Click);
            // 
            // menuContainer
            // 
            this.menuContainer.BackColor = System.Drawing.Color.Transparent;
            this.menuContainer.Controls.Add(this.menu);
            this.menuContainer.Controls.Add(this.butViewSheet);
            this.menuContainer.Controls.Add(this.butHandleExtend);
            this.menuContainer.Controls.Add(this.butRecordCertificate);
            this.menuContainer.Location = new System.Drawing.Point(3, 52);
            this.menuContainer.Name = "menuContainer";
            this.menuContainer.Size = new System.Drawing.Size(140, 45);
            this.menuContainer.TabIndex = 16;
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.Transparent;
            this.menu.CheckedState.FillColor = System.Drawing.Color.Gainsboro;
            this.menu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.menu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.menu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.menu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.menu.FillColor = System.Drawing.Color.Transparent;
            this.menu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.menu.ForeColor = System.Drawing.Color.White;
            this.menu.Image = global::exam_registration_system.Properties.Resources.menu_icon;
            this.menu.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.menu.ImageOffset = new System.Drawing.Point(-2, 0);
            this.menu.Location = new System.Drawing.Point(3, 3);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(134, 45);
            this.menu.TabIndex = 4;
            this.menu.Text = " Menu";
            this.menu.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.menu.Click += new System.EventHandler(this.menu_Click);
            // 
            // butViewSheet
            // 
            this.butViewSheet.BackColor = System.Drawing.Color.Transparent;
            this.butViewSheet.CheckedState.FillColor = System.Drawing.Color.Gainsboro;
            this.butViewSheet.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butViewSheet.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butViewSheet.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butViewSheet.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butViewSheet.FillColor = System.Drawing.Color.Transparent;
            this.butViewSheet.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butViewSheet.ForeColor = System.Drawing.Color.White;
            this.butViewSheet.Location = new System.Drawing.Point(3, 54);
            this.butViewSheet.Name = "butViewSheet";
            this.butViewSheet.Size = new System.Drawing.Size(134, 40);
            this.butViewSheet.TabIndex = 4;
            this.butViewSheet.Text = "Xem bảng tính";
            this.butViewSheet.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.butViewSheet.Click += new System.EventHandler(this.butViewSheet_Click);
            // 
            // butHandleExtend
            // 
            this.butHandleExtend.BackColor = System.Drawing.Color.Transparent;
            this.butHandleExtend.CheckedState.FillColor = System.Drawing.Color.Gainsboro;
            this.butHandleExtend.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butHandleExtend.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butHandleExtend.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butHandleExtend.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butHandleExtend.FillColor = System.Drawing.Color.Transparent;
            this.butHandleExtend.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butHandleExtend.ForeColor = System.Drawing.Color.White;
            this.butHandleExtend.Location = new System.Drawing.Point(3, 100);
            this.butHandleExtend.Name = "butHandleExtend";
            this.butHandleExtend.Size = new System.Drawing.Size(134, 40);
            this.butHandleExtend.TabIndex = 9;
            this.butHandleExtend.Text = "Xử lí gia hạn thi";
            this.butHandleExtend.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.butHandleExtend.Click += new System.EventHandler(this.butHandleExtend_Click);
            // 
            // butRecordCertificate
            // 
            this.butRecordCertificate.BackColor = System.Drawing.Color.Transparent;
            this.butRecordCertificate.CheckedState.FillColor = System.Drawing.Color.Gainsboro;
            this.butRecordCertificate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butRecordCertificate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butRecordCertificate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butRecordCertificate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butRecordCertificate.FillColor = System.Drawing.Color.Transparent;
            this.butRecordCertificate.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butRecordCertificate.ForeColor = System.Drawing.Color.White;
            this.butRecordCertificate.Location = new System.Drawing.Point(3, 146);
            this.butRecordCertificate.Name = "butRecordCertificate";
            this.butRecordCertificate.Size = new System.Drawing.Size(134, 40);
            this.butRecordCertificate.TabIndex = 10;
            this.butRecordCertificate.Text = "Ghi nhận thông tin chứng chỉ";
            this.butRecordCertificate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.butRecordCertificate.Click += new System.EventHandler(this.butRecordCertificate_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.butLogout);
            this.panel1.Location = new System.Drawing.Point(3, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(140, 43);
            this.panel1.TabIndex = 17;
            // 
            // butLogout
            // 
            this.butLogout.BackColor = System.Drawing.Color.Transparent;
            this.butLogout.CheckedState.FillColor = System.Drawing.Color.Gainsboro;
            this.butLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butLogout.FillColor = System.Drawing.Color.Transparent;
            this.butLogout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butLogout.ForeColor = System.Drawing.Color.White;
            this.butLogout.Image = global::exam_registration_system.Properties.Resources.logout_icon;
            this.butLogout.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.butLogout.Location = new System.Drawing.Point(3, 0);
            this.butLogout.Name = "butLogout";
            this.butLogout.Size = new System.Drawing.Size(134, 40);
            this.butLogout.TabIndex = 6;
            this.butLogout.Text = " Đăng xuất";
            this.butLogout.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panelContent
            // 
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(143, 51);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(897, 672);
            this.panelContent.TabIndex = 43;
            this.panelContent.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContent_Paint);
            // 
            // menuTransaction
            // 
            this.menuTransaction.Interval = 5;
            this.menuTransaction.Tick += new System.EventHandler(this.menuTransaction_Tick);
            // 
            // HomeNVNLForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 723);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HomeNVNLForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeNVNL";
            this.panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.sidebar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.menuContainer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label labelHeader;
        private Guna.UI2.WinForms.Guna2PictureBox logo;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button ButHome;
        private System.Windows.Forms.FlowLayoutPanel menuContainer;
        private Guna.UI2.WinForms.Guna2Button menu;
        private Guna.UI2.WinForms.Guna2Button butViewSheet;
        private Guna.UI2.WinForms.Guna2Button butHandleExtend;
        private Guna.UI2.WinForms.Guna2Button butRecordCertificate;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button butLogout;
        private Guna.UI2.WinForms.Guna2Panel panelContent;
        private System.Windows.Forms.Timer menuTransaction;
    }
}