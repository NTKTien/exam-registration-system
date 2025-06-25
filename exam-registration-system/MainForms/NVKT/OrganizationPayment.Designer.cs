namespace exam_registration_system.MainForms.NVKT
{
    partial class OrganizationPayment
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
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.btnCreateInvoice = new Guna.UI2.WinForms.Guna2Button();
            this.btnConfirmPayment = new Guna.UI2.WinForms.Guna2Button();
            this.grpInformation = new System.Windows.Forms.GroupBox();
            this.tbTotalCost = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbTotalCost = new System.Windows.Forms.Label();
            this.tbCertificateType = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbStatus = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbExpiryDate = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbRegistrationDate = new Guna.UI2.WinForms.Guna2TextBox();
            this.tbCustomerName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbStatus = new System.Windows.Forms.Label();
            this.lbCertificateType = new System.Windows.Forms.Label();
            this.lbExpiryDate = new System.Windows.Forms.Label();
            this.lbRegistrationDate = new System.Windows.Forms.Label();
            this.lbCustomerName = new System.Windows.Forms.Label();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.tbRegistrationCode = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbRegistrationCode = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.lbHeader = new System.Windows.Forms.Label();
            this.lbTransactionID = new System.Windows.Forms.Label();
            this.tbTransactionID = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlContainer.SuspendLayout();
            this.grpInformation.SuspendLayout();
            this.grpSearch.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackColor = System.Drawing.Color.White;
            this.pnlContainer.Controls.Add(this.btnCreateInvoice);
            this.pnlContainer.Controls.Add(this.grpInformation);
            this.pnlContainer.Controls.Add(this.grpSearch);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(0, 30);
            this.pnlContainer.Margin = new System.Windows.Forms.Padding(2);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Padding = new System.Windows.Forms.Padding(16);
            this.pnlContainer.Size = new System.Drawing.Size(880, 410);
            this.pnlContainer.TabIndex = 0;
            // 
            // btnCreateInvoice
            // 
            this.btnCreateInvoice.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnCreateInvoice.BorderRadius = 8;
            this.btnCreateInvoice.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCreateInvoice.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCreateInvoice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCreateInvoice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCreateInvoice.Enabled = false;
            this.btnCreateInvoice.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCreateInvoice.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.btnCreateInvoice.ForeColor = System.Drawing.Color.Black;
            this.btnCreateInvoice.Location = new System.Drawing.Point(365, 360);
            this.btnCreateInvoice.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateInvoice.Name = "btnCreateInvoice";
            this.btnCreateInvoice.Size = new System.Drawing.Size(150, 32);
            this.btnCreateInvoice.TabIndex = 3;
            this.btnCreateInvoice.Text = "📋 Tạo hóa đơn";
            // 
            // btnConfirmPayment
            // 
            this.btnConfirmPayment.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.btnConfirmPayment.BorderRadius = 8;
            this.btnConfirmPayment.BorderThickness = 1;
            this.btnConfirmPayment.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnConfirmPayment.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnConfirmPayment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnConfirmPayment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnConfirmPayment.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnConfirmPayment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnConfirmPayment.ForeColor = System.Drawing.Color.White;
            this.btnConfirmPayment.Location = new System.Drawing.Point(625, 200);
            this.btnConfirmPayment.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirmPayment.Name = "btnConfirmPayment";
            this.btnConfirmPayment.Size = new System.Drawing.Size(125, 32);
            this.btnConfirmPayment.TabIndex = 2;
            this.btnConfirmPayment.Text = "Xác nhận thanh toán";
            // 
            // grpInformation
            // 
            this.grpInformation.Controls.Add(this.tbTransactionID);
            this.grpInformation.Controls.Add(this.btnConfirmPayment);
            this.grpInformation.Controls.Add(this.lbTransactionID);
            this.grpInformation.Controls.Add(this.tbTotalCost);
            this.grpInformation.Controls.Add(this.lbTotalCost);
            this.grpInformation.Controls.Add(this.tbCertificateType);
            this.grpInformation.Controls.Add(this.tbStatus);
            this.grpInformation.Controls.Add(this.tbExpiryDate);
            this.grpInformation.Controls.Add(this.tbRegistrationDate);
            this.grpInformation.Controls.Add(this.tbCustomerName);
            this.grpInformation.Controls.Add(this.lbStatus);
            this.grpInformation.Controls.Add(this.lbCertificateType);
            this.grpInformation.Controls.Add(this.lbExpiryDate);
            this.grpInformation.Controls.Add(this.lbRegistrationDate);
            this.grpInformation.Controls.Add(this.lbCustomerName);
            this.grpInformation.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpInformation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.grpInformation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.grpInformation.Location = new System.Drawing.Point(16, 96);
            this.grpInformation.Name = "grpInformation";
            this.grpInformation.Size = new System.Drawing.Size(848, 250);
            this.grpInformation.TabIndex = 1;
            this.grpInformation.TabStop = false;
            this.grpInformation.Text = "Thông tin thanh toán";
            // 
            // tbTotalCost
            // 
            this.tbTotalCost.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbTotalCost.DefaultText = "10.800.000";
            this.tbTotalCost.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbTotalCost.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbTotalCost.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbTotalCost.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbTotalCost.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.tbTotalCost.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbTotalCost.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTotalCost.ForeColor = System.Drawing.Color.RoyalBlue;
            this.tbTotalCost.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbTotalCost.Location = new System.Drawing.Point(550, 68);
            this.tbTotalCost.Name = "tbTotalCost";
            this.tbTotalCost.PlaceholderText = "";
            this.tbTotalCost.ReadOnly = true;
            this.tbTotalCost.SelectedText = "";
            this.tbTotalCost.Size = new System.Drawing.Size(274, 33);
            this.tbTotalCost.TabIndex = 15;
            // 
            // lbTotalCost
            // 
            this.lbTotalCost.AutoSize = true;
            this.lbTotalCost.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lbTotalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lbTotalCost.Location = new System.Drawing.Point(550, 30);
            this.lbTotalCost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTotalCost.Name = "lbTotalCost";
            this.lbTotalCost.Size = new System.Drawing.Size(109, 21);
            this.lbTotalCost.TabIndex = 14;
            this.lbTotalCost.Text = "Tổng chi phí:";
            // 
            // tbCertificateType
            // 
            this.tbCertificateType.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbCertificateType.DefaultText = "Tiếng Anh";
            this.tbCertificateType.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbCertificateType.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbCertificateType.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbCertificateType.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbCertificateType.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.tbCertificateType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbCertificateType.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.tbCertificateType.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbCertificateType.Location = new System.Drawing.Point(190, 198);
            this.tbCertificateType.Name = "tbCertificateType";
            this.tbCertificateType.PlaceholderText = "";
            this.tbCertificateType.ReadOnly = true;
            this.tbCertificateType.SelectedText = "";
            this.tbCertificateType.Size = new System.Drawing.Size(150, 29);
            this.tbCertificateType.TabIndex = 13;
            // 
            // tbStatus
            // 
            this.tbStatus.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbStatus.DefaultText = "Chưa thanh toán";
            this.tbStatus.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbStatus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbStatus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbStatus.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbStatus.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.tbStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.tbStatus.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbStatus.Location = new System.Drawing.Point(190, 158);
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.PlaceholderText = "";
            this.tbStatus.ReadOnly = true;
            this.tbStatus.SelectedText = "";
            this.tbStatus.Size = new System.Drawing.Size(150, 29);
            this.tbStatus.TabIndex = 12;
            // 
            // tbExpiryDate
            // 
            this.tbExpiryDate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbExpiryDate.DefaultText = "01/07/2025";
            this.tbExpiryDate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbExpiryDate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbExpiryDate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbExpiryDate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbExpiryDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.tbExpiryDate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbExpiryDate.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.tbExpiryDate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbExpiryDate.Location = new System.Drawing.Point(190, 118);
            this.tbExpiryDate.Name = "tbExpiryDate";
            this.tbExpiryDate.PlaceholderText = "";
            this.tbExpiryDate.ReadOnly = true;
            this.tbExpiryDate.SelectedText = "";
            this.tbExpiryDate.Size = new System.Drawing.Size(150, 29);
            this.tbExpiryDate.TabIndex = 11;
            // 
            // tbRegistrationDate
            // 
            this.tbRegistrationDate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbRegistrationDate.DefaultText = "25/06/2025";
            this.tbRegistrationDate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbRegistrationDate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbRegistrationDate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbRegistrationDate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbRegistrationDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.tbRegistrationDate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbRegistrationDate.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.tbRegistrationDate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbRegistrationDate.Location = new System.Drawing.Point(190, 78);
            this.tbRegistrationDate.Name = "tbRegistrationDate";
            this.tbRegistrationDate.PlaceholderText = "";
            this.tbRegistrationDate.ReadOnly = true;
            this.tbRegistrationDate.SelectedText = "";
            this.tbRegistrationDate.Size = new System.Drawing.Size(150, 29);
            this.tbRegistrationDate.TabIndex = 5;
            // 
            // tbCustomerName
            // 
            this.tbCustomerName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbCustomerName.DefaultText = "Trường ABC";
            this.tbCustomerName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbCustomerName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbCustomerName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbCustomerName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbCustomerName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.tbCustomerName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbCustomerName.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.tbCustomerName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbCustomerName.Location = new System.Drawing.Point(190, 38);
            this.tbCustomerName.Name = "tbCustomerName";
            this.tbCustomerName.PlaceholderText = "";
            this.tbCustomerName.ReadOnly = true;
            this.tbCustomerName.SelectedText = "";
            this.tbCustomerName.Size = new System.Drawing.Size(240, 29);
            this.tbCustomerName.TabIndex = 5;
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lbStatus.Location = new System.Drawing.Point(40, 160);
            this.lbStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(80, 19);
            this.lbStatus.TabIndex = 10;
            this.lbStatus.Text = "Trạng thái:";
            // 
            // lbCertificateType
            // 
            this.lbCertificateType.AutoSize = true;
            this.lbCertificateType.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbCertificateType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lbCertificateType.Location = new System.Drawing.Point(40, 200);
            this.lbCertificateType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCertificateType.Name = "lbCertificateType";
            this.lbCertificateType.Size = new System.Drawing.Size(109, 19);
            this.lbCertificateType.TabIndex = 9;
            this.lbCertificateType.Text = "Loại chứng chỉ:";
            // 
            // lbExpiryDate
            // 
            this.lbExpiryDate.AutoSize = true;
            this.lbExpiryDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbExpiryDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lbExpiryDate.Location = new System.Drawing.Point(40, 120);
            this.lbExpiryDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbExpiryDate.Name = "lbExpiryDate";
            this.lbExpiryDate.Size = new System.Drawing.Size(144, 19);
            this.lbExpiryDate.TabIndex = 7;
            this.lbExpiryDate.Text = "Hạn thanh toán đến:";
            // 
            // lbRegistrationDate
            // 
            this.lbRegistrationDate.AutoSize = true;
            this.lbRegistrationDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbRegistrationDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lbRegistrationDate.Location = new System.Drawing.Point(40, 80);
            this.lbRegistrationDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbRegistrationDate.Name = "lbRegistrationDate";
            this.lbRegistrationDate.Size = new System.Drawing.Size(107, 19);
            this.lbRegistrationDate.TabIndex = 6;
            this.lbRegistrationDate.Text = "Ngày đăng ký:";
            // 
            // lbCustomerName
            // 
            this.lbCustomerName.AutoSize = true;
            this.lbCustomerName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbCustomerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lbCustomerName.Location = new System.Drawing.Point(40, 40);
            this.lbCustomerName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCustomerName.Name = "lbCustomerName";
            this.lbCustomerName.Size = new System.Drawing.Size(116, 19);
            this.lbCustomerName.TabIndex = 5;
            this.lbCustomerName.Text = "Tên khách hàng:";
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.btnSearch);
            this.grpSearch.Controls.Add(this.tbRegistrationCode);
            this.grpSearch.Controls.Add(this.lbRegistrationCode);
            this.grpSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.grpSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.grpSearch.Location = new System.Drawing.Point(16, 16);
            this.grpSearch.Margin = new System.Windows.Forms.Padding(2);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Padding = new System.Windows.Forms.Padding(16);
            this.grpSearch.Size = new System.Drawing.Size(848, 80);
            this.grpSearch.TabIndex = 0;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Tìm kiếm phiếu đăng ký";
            // 
            // btnSearch
            // 
            this.btnSearch.BorderRadius = 8;
            this.btnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(410, 32);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(110, 31);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Tìm kiếm";
            // 
            // tbRegistrationCode
            // 
            this.tbRegistrationCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbRegistrationCode.DefaultText = "DV001";
            this.tbRegistrationCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbRegistrationCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbRegistrationCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbRegistrationCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbRegistrationCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbRegistrationCode.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.tbRegistrationCode.ForeColor = System.Drawing.Color.Black;
            this.tbRegistrationCode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbRegistrationCode.Location = new System.Drawing.Point(190, 33);
            this.tbRegistrationCode.Name = "tbRegistrationCode";
            this.tbRegistrationCode.PlaceholderText = "";
            this.tbRegistrationCode.SelectedText = "";
            this.tbRegistrationCode.Size = new System.Drawing.Size(200, 29);
            this.tbRegistrationCode.TabIndex = 4;
            // 
            // lbRegistrationCode
            // 
            this.lbRegistrationCode.AutoSize = true;
            this.lbRegistrationCode.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbRegistrationCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lbRegistrationCode.Location = new System.Drawing.Point(40, 35);
            this.lbRegistrationCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbRegistrationCode.Name = "lbRegistrationCode";
            this.lbRegistrationCode.Size = new System.Drawing.Size(133, 19);
            this.lbRegistrationCode.TabIndex = 3;
            this.lbRegistrationCode.Text = "Mã phiếu đăng ký:";
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.pnlHeader.Controls.Add(this.btnExit);
            this.pnlHeader.Controls.Add(this.lbHeader);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(2);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(880, 30);
            this.pnlHeader.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.AutoRoundedCorners = true;
            this.btnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.ImageSize = new System.Drawing.Size(50, 50);
            this.btnExit.Location = new System.Drawing.Point(843, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(37, 30);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "✕";
            // 
            // lbHeader
            // 
            this.lbHeader.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbHeader.ForeColor = System.Drawing.Color.White;
            this.lbHeader.Location = new System.Drawing.Point(3, 4);
            this.lbHeader.Margin = new System.Windows.Forms.Padding(2);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(110, 23);
            this.lbHeader.TabIndex = 0;
            this.lbHeader.Text = "THANH TOÁN";
            // 
            // lbTransactionID
            // 
            this.lbTransactionID.AutoSize = true;
            this.lbTransactionID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lbTransactionID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lbTransactionID.Location = new System.Drawing.Point(550, 110);
            this.lbTransactionID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTransactionID.Name = "lbTransactionID";
            this.lbTransactionID.Size = new System.Drawing.Size(113, 21);
            this.lbTransactionID.TabIndex = 16;
            this.lbTransactionID.Text = "Mã giao dịch:";
            // 
            // tbTransactionID
            // 
            this.tbTransactionID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbTransactionID.DefaultText = "PTHT123";
            this.tbTransactionID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbTransactionID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbTransactionID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbTransactionID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbTransactionID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbTransactionID.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.tbTransactionID.ForeColor = System.Drawing.Color.Black;
            this.tbTransactionID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbTransactionID.Location = new System.Drawing.Point(550, 148);
            this.tbTransactionID.Name = "tbTransactionID";
            this.tbTransactionID.PlaceholderText = "";
            this.tbTransactionID.SelectedText = "";
            this.tbTransactionID.Size = new System.Drawing.Size(274, 33);
            this.tbTransactionID.TabIndex = 17;
            // 
            // OrganizationPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(880, 440);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "OrganizationPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaymentManagementForm";
            this.pnlContainer.ResumeLayout(false);
            this.grpInformation.ResumeLayout(false);
            this.grpInformation.PerformLayout();
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Panel pnlHeader;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private System.Windows.Forms.Label lbHeader;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.Label lbRegistrationCode;
        private Guna.UI2.WinForms.Guna2TextBox tbRegistrationCode;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private System.Windows.Forms.GroupBox grpInformation;
        private System.Windows.Forms.Label lbCustomerName;
        private System.Windows.Forms.Label lbRegistrationDate;
        private System.Windows.Forms.Label lbExpiryDate;
        private System.Windows.Forms.Label lbCertificateType;
        private System.Windows.Forms.Label lbStatus;
        private Guna.UI2.WinForms.Guna2TextBox tbCustomerName;
        private Guna.UI2.WinForms.Guna2TextBox tbRegistrationDate;
        private Guna.UI2.WinForms.Guna2TextBox tbExpiryDate;
        private Guna.UI2.WinForms.Guna2TextBox tbStatus;
        private Guna.UI2.WinForms.Guna2TextBox tbCertificateType;
        private Guna.UI2.WinForms.Guna2TextBox tbTotalCost;
        private System.Windows.Forms.Label lbTotalCost;
        private Guna.UI2.WinForms.Guna2Button btnConfirmPayment;
        private Guna.UI2.WinForms.Guna2Button btnCreateInvoice;
        private System.Windows.Forms.Label lbTransactionID;
        private Guna.UI2.WinForms.Guna2TextBox tbTransactionID;
    }
}