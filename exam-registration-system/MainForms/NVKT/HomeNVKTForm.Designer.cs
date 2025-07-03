namespace exam_registration_system.MainForms.NVKT
{
    partial class HomeNVKTForm
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
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.labelHeader = new System.Windows.Forms.Label();
            this.logo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.menuTransaction = new System.Windows.Forms.Timer(this.components);
            this.sidebarTransaction = new System.Windows.Forms.Timer(this.components);
            this.sidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ButHome = new Guna.UI2.WinForms.Guna2Button();
            this.menuContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.menu = new Guna.UI2.WinForms.Guna2Button();
            this.butViewReg = new Guna.UI2.WinForms.Guna2Button();
            this.butExtend = new Guna.UI2.WinForms.Guna2Button();
            this.butPayment = new Guna.UI2.WinForms.Guna2Button();
            this.butPaymentUnit = new Guna.UI2.WinForms.Guna2Button();
            this.butViewRegulation = new Guna.UI2.WinForms.Guna2Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.butLogout = new Guna.UI2.WinForms.Guna2Button();
            this.panelContent = new Guna.UI2.WinForms.Guna2Panel();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.sidebar.SuspendLayout();
            this.panel2.SuspendLayout();
            this.menuContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.panelHeader.TabIndex = 38;
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
            // menuTransaction
            // 
            this.menuTransaction.Interval = 5;
            this.menuTransaction.Tick += new System.EventHandler(this.menuTransaction_Tick);
            // 
            // sidebarTransaction
            // 
            this.sidebarTransaction.Interval = 10;
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
            this.sidebar.TabIndex = 41;
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
            this.menuContainer.Controls.Add(this.butViewReg);
            this.menuContainer.Controls.Add(this.butExtend);
            this.menuContainer.Controls.Add(this.butPayment);
            this.menuContainer.Controls.Add(this.butPaymentUnit);
            this.menuContainer.Controls.Add(this.butViewRegulation);
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
            // butViewReg
            // 
            this.butViewReg.BackColor = System.Drawing.Color.Transparent;
            this.butViewReg.CheckedState.FillColor = System.Drawing.Color.Gainsboro;
            this.butViewReg.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butViewReg.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butViewReg.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butViewReg.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butViewReg.FillColor = System.Drawing.Color.Transparent;
            this.butViewReg.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butViewReg.ForeColor = System.Drawing.Color.White;
            this.butViewReg.Location = new System.Drawing.Point(3, 54);
            this.butViewReg.Name = "butViewReg";
            this.butViewReg.Size = new System.Drawing.Size(134, 40);
            this.butViewReg.TabIndex = 4;
            this.butViewReg.Text = "Xem phiếu đăng kí ";
            this.butViewReg.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.butViewReg.Click += new System.EventHandler(this.butViewReg_Click);
            // 
            // butExtend
            // 
            this.butExtend.BackColor = System.Drawing.Color.Transparent;
            this.butExtend.CheckedState.FillColor = System.Drawing.Color.Gainsboro;
            this.butExtend.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butExtend.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butExtend.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butExtend.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butExtend.FillColor = System.Drawing.Color.Transparent;
            this.butExtend.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butExtend.ForeColor = System.Drawing.Color.White;
            this.butExtend.Location = new System.Drawing.Point(3, 100);
            this.butExtend.Name = "butExtend";
            this.butExtend.Size = new System.Drawing.Size(134, 40);
            this.butExtend.TabIndex = 9;
            this.butExtend.Text = "Lập phiếu gia hạn";
            this.butExtend.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.butExtend.Click += new System.EventHandler(this.butExtend_Click);
            // 
            // butPayment
            // 
            this.butPayment.BackColor = System.Drawing.Color.Transparent;
            this.butPayment.CheckedState.FillColor = System.Drawing.Color.Gainsboro;
            this.butPayment.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butPayment.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butPayment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butPayment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butPayment.FillColor = System.Drawing.Color.Transparent;
            this.butPayment.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butPayment.ForeColor = System.Drawing.Color.White;
            this.butPayment.Location = new System.Drawing.Point(3, 146);
            this.butPayment.Name = "butPayment";
            this.butPayment.Size = new System.Drawing.Size(134, 40);
            this.butPayment.TabIndex = 10;
            this.butPayment.Text = "Thanh toán cá nhân";
            this.butPayment.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.butPayment.Click += new System.EventHandler(this.butPayment_Click);
            // 
            // butPaymentUnit
            // 
            this.butPaymentUnit.BackColor = System.Drawing.Color.Transparent;
            this.butPaymentUnit.CheckedState.FillColor = System.Drawing.Color.Gainsboro;
            this.butPaymentUnit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butPaymentUnit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butPaymentUnit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butPaymentUnit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butPaymentUnit.FillColor = System.Drawing.Color.Transparent;
            this.butPaymentUnit.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butPaymentUnit.ForeColor = System.Drawing.Color.White;
            this.butPaymentUnit.Location = new System.Drawing.Point(3, 192);
            this.butPaymentUnit.Name = "butPaymentUnit";
            this.butPaymentUnit.Size = new System.Drawing.Size(134, 40);
            this.butPaymentUnit.TabIndex = 11;
            this.butPaymentUnit.Text = "Thanh toán đơn vị";
            this.butPaymentUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.butPaymentUnit.Click += new System.EventHandler(this.butPaymentUnit_Click);
            // 
            // butViewRegulation
            // 
            this.butViewRegulation.BackColor = System.Drawing.Color.Transparent;
            this.butViewRegulation.CheckedState.FillColor = System.Drawing.Color.Gainsboro;
            this.butViewRegulation.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butViewRegulation.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butViewRegulation.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butViewRegulation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butViewRegulation.FillColor = System.Drawing.Color.Transparent;
            this.butViewRegulation.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butViewRegulation.ForeColor = System.Drawing.Color.White;
            this.butViewRegulation.Location = new System.Drawing.Point(3, 238);
            this.butViewRegulation.Name = "butViewRegulation";
            this.butViewRegulation.Size = new System.Drawing.Size(134, 40);
            this.butViewRegulation.TabIndex = 8;
            this.butViewRegulation.Text = "Xem quy định ";
            this.butViewRegulation.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.butViewRegulation.Click += new System.EventHandler(this.butViewRegulation_Click);
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
            this.panelContent.TabIndex = 42;
            // 
            // HomeNVKTForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1040, 723);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.sidebar);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "HomeNVKTForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomeNVKT";
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
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelHeader;
        private Guna.UI2.WinForms.Guna2PictureBox logo;
        private System.Windows.Forms.Timer menuTransaction;
        private System.Windows.Forms.Timer sidebarTransaction;
        private System.Windows.Forms.FlowLayoutPanel sidebar;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button ButHome;
        private System.Windows.Forms.FlowLayoutPanel menuContainer;
        private Guna.UI2.WinForms.Guna2Button menu;
        private Guna.UI2.WinForms.Guna2Button butViewReg;
        private Guna.UI2.WinForms.Guna2Button butExtend;
        private Guna.UI2.WinForms.Guna2Button butPayment;
        private Guna.UI2.WinForms.Guna2Button butViewRegulation;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button butLogout;
        private Guna.UI2.WinForms.Guna2Panel panelContent;
        private Guna.UI2.WinForms.Guna2Button butPaymentUnit;
    }
}