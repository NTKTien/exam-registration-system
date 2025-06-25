namespace exam_registration_system.MainForms.NVKT
{
    partial class Form1
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
            this.panelContent = new System.Windows.Forms.Panel();
            this.panelPaymentInfo = new System.Windows.Forms.Panel();
            this.groupBoxPaymentDetails = new System.Windows.Forms.GroupBox();
            this.txtStatus = new System.Windows.Forms.TextBox();
            this.txtExpiryDate = new System.Windows.Forms.TextBox();
            this.txtRegistrationDate = new System.Windows.Forms.TextBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtCertificateType = new System.Windows.Forms.TextBox();
            this.txtTotalAmount = new System.Windows.Forms.TextBox();
            this.labelStatus = new System.Windows.Forms.Label();
            this.labelExpiryDate = new System.Windows.Forms.Label();
            this.labelRegistrationDate = new System.Windows.Forms.Label();
            this.labelCustomerName = new System.Windows.Forms.Label();
            this.labelCertificateType = new System.Windows.Forms.Label();
            this.labelTotalAmount = new System.Windows.Forms.Label();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.btnClear = new Guna.UI2.WinForms.Guna2Button();
            this.btnCreateInvoice = new Guna.UI2.WinForms.Guna2Button();
            this.btnConfirmPayment = new Guna.UI2.WinForms.Guna2Button();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.labelRegistrationCode = new System.Windows.Forms.Label();
            this.txtRegistrationCode = new System.Windows.Forms.TextBox();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.PanelHeader = new System.Windows.Forms.Panel();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.lbHeader = new System.Windows.Forms.Label();
            this.panelContent.SuspendLayout();
            this.panelPaymentInfo.SuspendLayout();
            this.groupBoxPaymentDetails.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.panelSearch.SuspendLayout();
            this.groupBoxSearch.SuspendLayout();
            this.PanelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.White;
            this.panelContent.Controls.Add(this.panelPaymentInfo);
            this.panelContent.Controls.Add(this.panelSearch);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 30);
            this.panelContent.Margin = new System.Windows.Forms.Padding(2);
            this.panelContent.Name = "panelContent";
            this.panelContent.Padding = new System.Windows.Forms.Padding(16);
            this.panelContent.Size = new System.Drawing.Size(880, 410);
            this.panelContent.TabIndex = 0;
            // 
            // panelPaymentInfo
            // 
            this.panelPaymentInfo.Controls.Add(this.groupBoxPaymentDetails);
            this.panelPaymentInfo.Controls.Add(this.panelButtons);
            this.panelPaymentInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPaymentInfo.Location = new System.Drawing.Point(16, 96);
            this.panelPaymentInfo.Margin = new System.Windows.Forms.Padding(2);
            this.panelPaymentInfo.Name = "panelPaymentInfo";
            this.panelPaymentInfo.Size = new System.Drawing.Size(848, 298);
            this.panelPaymentInfo.TabIndex = 1;
            this.panelPaymentInfo.Visible = false;
            // 
            // groupBoxPaymentDetails
            // 
            this.groupBoxPaymentDetails.Controls.Add(this.txtStatus);
            this.groupBoxPaymentDetails.Controls.Add(this.txtExpiryDate);
            this.groupBoxPaymentDetails.Controls.Add(this.txtRegistrationDate);
            this.groupBoxPaymentDetails.Controls.Add(this.txtCustomerName);
            this.groupBoxPaymentDetails.Controls.Add(this.txtCertificateType);
            this.groupBoxPaymentDetails.Controls.Add(this.txtTotalAmount);
            this.groupBoxPaymentDetails.Controls.Add(this.labelStatus);
            this.groupBoxPaymentDetails.Controls.Add(this.labelExpiryDate);
            this.groupBoxPaymentDetails.Controls.Add(this.labelRegistrationDate);
            this.groupBoxPaymentDetails.Controls.Add(this.labelCustomerName);
            this.groupBoxPaymentDetails.Controls.Add(this.labelCertificateType);
            this.groupBoxPaymentDetails.Controls.Add(this.labelTotalAmount);
            this.groupBoxPaymentDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxPaymentDetails.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.groupBoxPaymentDetails.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.groupBoxPaymentDetails.Location = new System.Drawing.Point(0, 0);
            this.groupBoxPaymentDetails.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxPaymentDetails.Name = "groupBoxPaymentDetails";
            this.groupBoxPaymentDetails.Padding = new System.Windows.Forms.Padding(16);
            this.groupBoxPaymentDetails.Size = new System.Drawing.Size(848, 250);
            this.groupBoxPaymentDetails.TabIndex = 1;
            this.groupBoxPaymentDetails.TabStop = false;
            this.groupBoxPaymentDetails.Text = "Thông tin thanh toán";
            // 
            // txtStatus
            // 
            this.txtStatus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.txtStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.txtStatus.Location = new System.Drawing.Point(200, 172);
            this.txtStatus.Margin = new System.Windows.Forms.Padding(2);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.ReadOnly = true;
            this.txtStatus.Size = new System.Drawing.Size(201, 25);
            this.txtStatus.TabIndex = 11;
            // 
            // txtExpiryDate
            // 
            this.txtExpiryDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtExpiryDate.Location = new System.Drawing.Point(200, 132);
            this.txtExpiryDate.Margin = new System.Windows.Forms.Padding(2);
            this.txtExpiryDate.Name = "txtExpiryDate";
            this.txtExpiryDate.ReadOnly = true;
            this.txtExpiryDate.Size = new System.Drawing.Size(201, 25);
            this.txtExpiryDate.TabIndex = 10;
            // 
            // txtRegistrationDate
            // 
            this.txtRegistrationDate.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtRegistrationDate.Location = new System.Drawing.Point(200, 92);
            this.txtRegistrationDate.Margin = new System.Windows.Forms.Padding(2);
            this.txtRegistrationDate.Name = "txtRegistrationDate";
            this.txtRegistrationDate.ReadOnly = true;
            this.txtRegistrationDate.Size = new System.Drawing.Size(201, 25);
            this.txtRegistrationDate.TabIndex = 9;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCustomerName.Location = new System.Drawing.Point(200, 52);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(2);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.ReadOnly = true;
            this.txtCustomerName.Size = new System.Drawing.Size(241, 25);
            this.txtCustomerName.TabIndex = 8;
            // 
            // txtCertificateType
            // 
            this.txtCertificateType.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCertificateType.Location = new System.Drawing.Point(200, 212);
            this.txtCertificateType.Margin = new System.Windows.Forms.Padding(2);
            this.txtCertificateType.Name = "txtCertificateType";
            this.txtCertificateType.ReadOnly = true;
            this.txtCertificateType.Size = new System.Drawing.Size(201, 25);
            this.txtCertificateType.TabIndex = 7;
            // 
            // txtTotalAmount
            // 
            this.txtTotalAmount.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.txtTotalAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.txtTotalAmount.Location = new System.Drawing.Point(200, 252);
            this.txtTotalAmount.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotalAmount.Name = "txtTotalAmount";
            this.txtTotalAmount.ReadOnly = true;
            this.txtTotalAmount.Size = new System.Drawing.Size(201, 27);
            this.txtTotalAmount.TabIndex = 6;
            // 
            // labelStatus
            // 
            this.labelStatus.AutoSize = true;
            this.labelStatus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.labelStatus.Location = new System.Drawing.Point(40, 176);
            this.labelStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(80, 19);
            this.labelStatus.TabIndex = 5;
            this.labelStatus.Text = "Trạng thái:";
            // 
            // labelExpiryDate
            // 
            this.labelExpiryDate.AutoSize = true;
            this.labelExpiryDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelExpiryDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.labelExpiryDate.Location = new System.Drawing.Point(40, 136);
            this.labelExpiryDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelExpiryDate.Name = "labelExpiryDate";
            this.labelExpiryDate.Size = new System.Drawing.Size(144, 19);
            this.labelExpiryDate.TabIndex = 4;
            this.labelExpiryDate.Text = "Hạn thanh toán đến:";
            // 
            // labelRegistrationDate
            // 
            this.labelRegistrationDate.AutoSize = true;
            this.labelRegistrationDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelRegistrationDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.labelRegistrationDate.Location = new System.Drawing.Point(40, 96);
            this.labelRegistrationDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRegistrationDate.Name = "labelRegistrationDate";
            this.labelRegistrationDate.Size = new System.Drawing.Size(107, 19);
            this.labelRegistrationDate.TabIndex = 3;
            this.labelRegistrationDate.Text = "Ngày đăng ký:";
            // 
            // labelCustomerName
            // 
            this.labelCustomerName.AutoSize = true;
            this.labelCustomerName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelCustomerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.labelCustomerName.Location = new System.Drawing.Point(40, 56);
            this.labelCustomerName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCustomerName.Name = "labelCustomerName";
            this.labelCustomerName.Size = new System.Drawing.Size(116, 19);
            this.labelCustomerName.TabIndex = 2;
            this.labelCustomerName.Text = "Tên khách hàng:";
            // 
            // labelCertificateType
            // 
            this.labelCertificateType.AutoSize = true;
            this.labelCertificateType.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelCertificateType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.labelCertificateType.Location = new System.Drawing.Point(40, 216);
            this.labelCertificateType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCertificateType.Name = "labelCertificateType";
            this.labelCertificateType.Size = new System.Drawing.Size(109, 19);
            this.labelCertificateType.TabIndex = 1;
            this.labelCertificateType.Text = "Loại chứng chỉ:";
            // 
            // labelTotalAmount
            // 
            this.labelTotalAmount.AutoSize = true;
            this.labelTotalAmount.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelTotalAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.labelTotalAmount.Location = new System.Drawing.Point(40, 256);
            this.labelTotalAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTotalAmount.Name = "labelTotalAmount";
            this.labelTotalAmount.Size = new System.Drawing.Size(72, 19);
            this.labelTotalAmount.TabIndex = 0;
            this.labelTotalAmount.Text = "Tổng phí:";
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.btnClear);
            this.panelButtons.Controls.Add(this.btnCreateInvoice);
            this.panelButtons.Controls.Add(this.btnConfirmPayment);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelButtons.Location = new System.Drawing.Point(0, 250);
            this.panelButtons.Margin = new System.Windows.Forms.Padding(2);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Padding = new System.Windows.Forms.Padding(16, 8, 16, 16);
            this.panelButtons.Size = new System.Drawing.Size(848, 48);
            this.panelButtons.TabIndex = 0;
            // 
            // btnClear
            // 
            this.btnClear.BorderRadius = 8;
            this.btnClear.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClear.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(165)))), ((int)(((byte)(166)))));
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(280, 8);
            this.btnClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(91, 32);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Làm mới";
            // 
            // btnCreateInvoice
            // 
            this.btnCreateInvoice.BorderRadius = 8;
            this.btnCreateInvoice.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCreateInvoice.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCreateInvoice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCreateInvoice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCreateInvoice.Enabled = false;
            this.btnCreateInvoice.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnCreateInvoice.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnCreateInvoice.ForeColor = System.Drawing.Color.White;
            this.btnCreateInvoice.Location = new System.Drawing.Point(160, 8);
            this.btnCreateInvoice.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateInvoice.Name = "btnCreateInvoice";
            this.btnCreateInvoice.Size = new System.Drawing.Size(104, 32);
            this.btnCreateInvoice.TabIndex = 1;
            this.btnCreateInvoice.Text = "Tạo hóa đơn";
            // 
            // btnConfirmPayment
            // 
            this.btnConfirmPayment.BorderRadius = 8;
            this.btnConfirmPayment.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnConfirmPayment.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnConfirmPayment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnConfirmPayment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnConfirmPayment.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnConfirmPayment.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnConfirmPayment.ForeColor = System.Drawing.Color.White;
            this.btnConfirmPayment.Location = new System.Drawing.Point(24, 8);
            this.btnConfirmPayment.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirmPayment.Name = "btnConfirmPayment";
            this.btnConfirmPayment.Size = new System.Drawing.Size(120, 32);
            this.btnConfirmPayment.TabIndex = 0;
            this.btnConfirmPayment.Text = "Xác nhận thanh toán";
            // 
            // panelSearch
            // 
            this.panelSearch.Controls.Add(this.groupBoxSearch);
            this.panelSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSearch.Location = new System.Drawing.Point(16, 16);
            this.panelSearch.Margin = new System.Windows.Forms.Padding(2);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(848, 80);
            this.panelSearch.TabIndex = 0;
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Controls.Add(this.labelRegistrationCode);
            this.groupBoxSearch.Controls.Add(this.txtRegistrationCode);
            this.groupBoxSearch.Controls.Add(this.btnSearch);
            this.groupBoxSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxSearch.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.groupBoxSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.groupBoxSearch.Location = new System.Drawing.Point(0, 0);
            this.groupBoxSearch.Margin = new System.Windows.Forms.Padding(2);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Padding = new System.Windows.Forms.Padding(16);
            this.groupBoxSearch.Size = new System.Drawing.Size(848, 80);
            this.groupBoxSearch.TabIndex = 0;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Tìm kiếm phiếu đăng ký";
            this.groupBoxSearch.Enter += new System.EventHandler(this.groupBoxSearch_Enter);
            // 
            // labelRegistrationCode
            // 
            this.labelRegistrationCode.AutoSize = true;
            this.labelRegistrationCode.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.labelRegistrationCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.labelRegistrationCode.Location = new System.Drawing.Point(40, 40);
            this.labelRegistrationCode.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRegistrationCode.Name = "labelRegistrationCode";
            this.labelRegistrationCode.Size = new System.Drawing.Size(133, 19);
            this.labelRegistrationCode.TabIndex = 2;
            this.labelRegistrationCode.Text = "Mã phiếu đăng ký:";
            // 
            // txtRegistrationCode
            // 
            this.txtRegistrationCode.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtRegistrationCode.Location = new System.Drawing.Point(200, 36);
            this.txtRegistrationCode.Margin = new System.Windows.Forms.Padding(2);
            this.txtRegistrationCode.Name = "txtRegistrationCode";
            this.txtRegistrationCode.Size = new System.Drawing.Size(201, 29);
            this.txtRegistrationCode.TabIndex = 1;
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
            this.btnSearch.Location = new System.Drawing.Point(416, 33);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(120, 36);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "Tìm kiếm";
            // 
            // PanelHeader
            // 
            this.PanelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.PanelHeader.Controls.Add(this.btnExit);
            this.PanelHeader.Controls.Add(this.lbHeader);
            this.PanelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelHeader.Location = new System.Drawing.Point(0, 0);
            this.PanelHeader.Margin = new System.Windows.Forms.Padding(2);
            this.PanelHeader.Name = "PanelHeader";
            this.PanelHeader.Size = new System.Drawing.Size(880, 30);
            this.PanelHeader.TabIndex = 1;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(880, 440);
            this.Controls.Add(this.panelContent);
            this.Controls.Add(this.PanelHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaymentManagementForm";
            this.panelContent.ResumeLayout(false);
            this.panelPaymentInfo.ResumeLayout(false);
            this.groupBoxPaymentDetails.ResumeLayout(false);
            this.groupBoxPaymentDetails.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.panelSearch.ResumeLayout(false);
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            this.PanelHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Panel panelPaymentInfo;
        private System.Windows.Forms.GroupBox groupBoxPaymentDetails;
        private System.Windows.Forms.TextBox txtStatus;
        private System.Windows.Forms.TextBox txtExpiryDate;
        private System.Windows.Forms.TextBox txtRegistrationDate;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtCertificateType;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Label labelExpiryDate;
        private System.Windows.Forms.Label labelRegistrationDate;
        private System.Windows.Forms.Label labelCustomerName;
        private System.Windows.Forms.Label labelCertificateType;
        private System.Windows.Forms.Label labelTotalAmount;
        private System.Windows.Forms.Panel panelButtons;
        private Guna.UI2.WinForms.Guna2Button btnClear;
        private Guna.UI2.WinForms.Guna2Button btnCreateInvoice;
        private Guna.UI2.WinForms.Guna2Button btnConfirmPayment;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.GroupBox groupBoxSearch;
        private System.Windows.Forms.Label labelRegistrationCode;
        private System.Windows.Forms.TextBox txtRegistrationCode;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private System.Windows.Forms.Panel PanelHeader;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private System.Windows.Forms.Label lbHeader;
    }
}