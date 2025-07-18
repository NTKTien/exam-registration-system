﻿namespace exam_registration_system.MainForms.NVKT
{
    partial class OrganizationPayment
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.btnCreateInvoice = new Guna.UI2.WinForms.Guna2Button();
            this.grpPaymentInfo = new System.Windows.Forms.GroupBox();
            this.tbFinalAmount = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbFinalAmount = new System.Windows.Forms.Label();
            this.tbSupportAmount = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbSupportAmount = new System.Windows.Forms.Label();
            this.tbTotalCost = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbTotalCost = new System.Windows.Forms.Label();
            this.tbTransactionID = new Guna.UI2.WinForms.Guna2TextBox();
            this.lbTransactionID = new System.Windows.Forms.Label();
            this.btnConfirmPayment = new Guna.UI2.WinForms.Guna2Button();
            this.grpCustomerInfo = new System.Windows.Forms.GroupBox();
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
            this.cmbUnpaidRegistrationID = new System.Windows.Forms.ComboBox();
            this.lbRegistrationCode = new System.Windows.Forms.Label();
            this.lbHeader = new System.Windows.Forms.Label();
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlContainer.SuspendLayout();
            this.grpPaymentInfo.SuspendLayout();
            this.grpCustomerInfo.SuspendLayout();
            this.grpSearch.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContainer
            // 
            this.pnlContainer.BackColor = System.Drawing.Color.White;
            this.pnlContainer.Controls.Add(this.btnCreateInvoice);
            this.pnlContainer.Controls.Add(this.grpPaymentInfo);
            this.pnlContainer.Controls.Add(this.grpCustomerInfo);
            this.pnlContainer.Controls.Add(this.grpSearch);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(0, 60);
            this.pnlContainer.Margin = new System.Windows.Forms.Padding(2);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Padding = new System.Windows.Forms.Padding(16, 16, 16, 16);
            this.pnlContainer.Size = new System.Drawing.Size(880, 501);
            this.pnlContainer.TabIndex = 0;
            this.pnlContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlContainer_Paint);
            // 
            // btnCreateInvoice
            // 
            this.btnCreateInvoice.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnCreateInvoice.BorderRadius = 8;
            this.btnCreateInvoice.BorderThickness = 1;
            this.btnCreateInvoice.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCreateInvoice.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCreateInvoice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCreateInvoice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCreateInvoice.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnCreateInvoice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCreateInvoice.ForeColor = System.Drawing.Color.White;
            this.btnCreateInvoice.Location = new System.Drawing.Point(380, 500);
            this.btnCreateInvoice.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateInvoice.Name = "btnCreateInvoice";
            this.btnCreateInvoice.Size = new System.Drawing.Size(150, 42);
            this.btnCreateInvoice.TabIndex = 4;
            this.btnCreateInvoice.Text = "Tạo hóa đơn";
            // 
            // grpPaymentInfo
            // 
            this.grpPaymentInfo.Controls.Add(this.tbFinalAmount);
            this.grpPaymentInfo.Controls.Add(this.lbFinalAmount);
            this.grpPaymentInfo.Controls.Add(this.tbSupportAmount);
            this.grpPaymentInfo.Controls.Add(this.lbSupportAmount);
            this.grpPaymentInfo.Controls.Add(this.tbTotalCost);
            this.grpPaymentInfo.Controls.Add(this.lbTotalCost);
            this.grpPaymentInfo.Controls.Add(this.tbTransactionID);
            this.grpPaymentInfo.Controls.Add(this.lbTransactionID);
            this.grpPaymentInfo.Controls.Add(this.btnConfirmPayment);
            this.grpPaymentInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.grpPaymentInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.grpPaymentInfo.Location = new System.Drawing.Point(454, 110);
            this.grpPaymentInfo.Name = "grpPaymentInfo";
            this.grpPaymentInfo.Size = new System.Drawing.Size(410, 330);
            this.grpPaymentInfo.TabIndex = 2;
            this.grpPaymentInfo.TabStop = false;
            this.grpPaymentInfo.Text = "Thông tin thanh toán";
            // 
            // tbFinalAmount
            // 
            this.tbFinalAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbFinalAmount.DefaultText = "10.000.000";
            this.tbFinalAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbFinalAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbFinalAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbFinalAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbFinalAmount.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.tbFinalAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.tbFinalAmount.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold);
            this.tbFinalAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.tbFinalAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.tbFinalAmount.Location = new System.Drawing.Point(170, 150);
            this.tbFinalAmount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbFinalAmount.Name = "tbFinalAmount";
            this.tbFinalAmount.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.tbFinalAmount.PlaceholderText = "10.000.000";
            this.tbFinalAmount.ReadOnly = true;
            this.tbFinalAmount.SelectedText = "";
            this.tbFinalAmount.Size = new System.Drawing.Size(180, 33);
            this.tbFinalAmount.TabIndex = 22;
            // 
            // lbFinalAmount
            // 
            this.lbFinalAmount.AutoSize = true;
            this.lbFinalAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lbFinalAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lbFinalAmount.Location = new System.Drawing.Point(20, 155);
            this.lbFinalAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbFinalAmount.Name = "lbFinalAmount";
            this.lbFinalAmount.Size = new System.Drawing.Size(96, 21);
            this.lbFinalAmount.TabIndex = 21;
            this.lbFinalAmount.Text = "Thành tiền:";
            // 
            // tbSupportAmount
            // 
            this.tbSupportAmount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSupportAmount.DefaultText = "800.000";
            this.tbSupportAmount.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbSupportAmount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbSupportAmount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSupportAmount.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSupportAmount.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.tbSupportAmount.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.tbSupportAmount.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold);
            this.tbSupportAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.tbSupportAmount.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.tbSupportAmount.Location = new System.Drawing.Point(170, 95);
            this.tbSupportAmount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbSupportAmount.Name = "tbSupportAmount";
            this.tbSupportAmount.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.tbSupportAmount.PlaceholderText = "800.000";
            this.tbSupportAmount.ReadOnly = true;
            this.tbSupportAmount.SelectedText = "";
            this.tbSupportAmount.Size = new System.Drawing.Size(180, 33);
            this.tbSupportAmount.TabIndex = 20;
            // 
            // lbSupportAmount
            // 
            this.lbSupportAmount.AutoSize = true;
            this.lbSupportAmount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lbSupportAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lbSupportAmount.Location = new System.Drawing.Point(20, 100);
            this.lbSupportAmount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbSupportAmount.Name = "lbSupportAmount";
            this.lbSupportAmount.Size = new System.Drawing.Size(66, 21);
            this.lbSupportAmount.TabIndex = 19;
            this.lbSupportAmount.Text = "Trợ giá:";
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
            this.tbTotalCost.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.tbTotalCost.Font = new System.Drawing.Font("Segoe UI Black", 12F, System.Drawing.FontStyle.Bold);
            this.tbTotalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.tbTotalCost.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.tbTotalCost.Location = new System.Drawing.Point(170, 40);
            this.tbTotalCost.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbTotalCost.Name = "tbTotalCost";
            this.tbTotalCost.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.tbTotalCost.PlaceholderText = "10.800.000";
            this.tbTotalCost.ReadOnly = true;
            this.tbTotalCost.SelectedText = "";
            this.tbTotalCost.Size = new System.Drawing.Size(180, 33);
            this.tbTotalCost.TabIndex = 18;
            // 
            // lbTotalCost
            // 
            this.lbTotalCost.AutoSize = true;
            this.lbTotalCost.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lbTotalCost.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lbTotalCost.Location = new System.Drawing.Point(20, 45);
            this.lbTotalCost.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTotalCost.Name = "lbTotalCost";
            this.lbTotalCost.Size = new System.Drawing.Size(109, 21);
            this.lbTotalCost.TabIndex = 17;
            this.lbTotalCost.Text = "Tổng chi phí:";
            // 
            // tbTransactionID
            // 
            this.tbTransactionID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbTransactionID.DefaultText = "PTHT123";
            this.tbTransactionID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbTransactionID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbTransactionID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbTransactionID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbTransactionID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.tbTransactionID.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.tbTransactionID.ForeColor = System.Drawing.Color.Black;
            this.tbTransactionID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.tbTransactionID.Location = new System.Drawing.Point(170, 205);
            this.tbTransactionID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbTransactionID.Name = "tbTransactionID";
            this.tbTransactionID.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.tbTransactionID.PlaceholderText = "PTHT123";
            this.tbTransactionID.SelectedText = "";
            this.tbTransactionID.Size = new System.Drawing.Size(180, 33);
            this.tbTransactionID.TabIndex = 16;
            // 
            // lbTransactionID
            // 
            this.lbTransactionID.AutoSize = true;
            this.lbTransactionID.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lbTransactionID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lbTransactionID.Location = new System.Drawing.Point(20, 210);
            this.lbTransactionID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTransactionID.Name = "lbTransactionID";
            this.lbTransactionID.Size = new System.Drawing.Size(113, 21);
            this.lbTransactionID.TabIndex = 15;
            this.lbTransactionID.Text = "Mã giao dịch:";
            // 
            // btnConfirmPayment
            // 
            this.btnConfirmPayment.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnConfirmPayment.BorderRadius = 8;
            this.btnConfirmPayment.BorderThickness = 1;
            this.btnConfirmPayment.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnConfirmPayment.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnConfirmPayment.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnConfirmPayment.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnConfirmPayment.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnConfirmPayment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnConfirmPayment.ForeColor = System.Drawing.Color.White;
            this.btnConfirmPayment.Location = new System.Drawing.Point(110, 270);
            this.btnConfirmPayment.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirmPayment.Name = "btnConfirmPayment";
            this.btnConfirmPayment.Size = new System.Drawing.Size(190, 40);
            this.btnConfirmPayment.TabIndex = 2;
            this.btnConfirmPayment.Text = "Xác nhận thanh toán";
            // 
            // grpCustomerInfo
            // 
            this.grpCustomerInfo.Controls.Add(this.tbCertificateType);
            this.grpCustomerInfo.Controls.Add(this.tbStatus);
            this.grpCustomerInfo.Controls.Add(this.tbExpiryDate);
            this.grpCustomerInfo.Controls.Add(this.tbRegistrationDate);
            this.grpCustomerInfo.Controls.Add(this.tbCustomerName);
            this.grpCustomerInfo.Controls.Add(this.lbStatus);
            this.grpCustomerInfo.Controls.Add(this.lbCertificateType);
            this.grpCustomerInfo.Controls.Add(this.lbExpiryDate);
            this.grpCustomerInfo.Controls.Add(this.lbRegistrationDate);
            this.grpCustomerInfo.Controls.Add(this.lbCustomerName);
            this.grpCustomerInfo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.grpCustomerInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.grpCustomerInfo.Location = new System.Drawing.Point(16, 110);
            this.grpCustomerInfo.Name = "grpCustomerInfo";
            this.grpCustomerInfo.Size = new System.Drawing.Size(410, 330);
            this.grpCustomerInfo.TabIndex = 1;
            this.grpCustomerInfo.TabStop = false;
            this.grpCustomerInfo.Text = "Thông tin đơn vị";
            // 
            // tbCertificateType
            // 
            this.tbCertificateType.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbCertificateType.DefaultText = "Tiếng Anh";
            this.tbCertificateType.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbCertificateType.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbCertificateType.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbCertificateType.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbCertificateType.Enabled = false;
            this.tbCertificateType.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.tbCertificateType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.tbCertificateType.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.tbCertificateType.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.tbCertificateType.Location = new System.Drawing.Point(170, 270);
            this.tbCertificateType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbCertificateType.Name = "tbCertificateType";
            this.tbCertificateType.PlaceholderText = "";
            this.tbCertificateType.ReadOnly = true;
            this.tbCertificateType.SelectedText = "";
            this.tbCertificateType.Size = new System.Drawing.Size(180, 29);
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
            this.tbStatus.Enabled = false;
            this.tbStatus.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.tbStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.tbStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.tbStatus.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.tbStatus.Location = new System.Drawing.Point(170, 215);
            this.tbStatus.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.PlaceholderText = "";
            this.tbStatus.ReadOnly = true;
            this.tbStatus.SelectedText = "";
            this.tbStatus.Size = new System.Drawing.Size(180, 29);
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
            this.tbExpiryDate.Enabled = false;
            this.tbExpiryDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.tbExpiryDate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.tbExpiryDate.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.tbExpiryDate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.tbExpiryDate.Location = new System.Drawing.Point(170, 160);
            this.tbExpiryDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbExpiryDate.Name = "tbExpiryDate";
            this.tbExpiryDate.PlaceholderText = "";
            this.tbExpiryDate.ReadOnly = true;
            this.tbExpiryDate.SelectedText = "";
            this.tbExpiryDate.Size = new System.Drawing.Size(180, 29);
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
            this.tbRegistrationDate.Enabled = false;
            this.tbRegistrationDate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.tbRegistrationDate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.tbRegistrationDate.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.tbRegistrationDate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.tbRegistrationDate.Location = new System.Drawing.Point(170, 105);
            this.tbRegistrationDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbRegistrationDate.Name = "tbRegistrationDate";
            this.tbRegistrationDate.PlaceholderText = "";
            this.tbRegistrationDate.ReadOnly = true;
            this.tbRegistrationDate.SelectedText = "";
            this.tbRegistrationDate.Size = new System.Drawing.Size(180, 29);
            this.tbRegistrationDate.TabIndex = 10;
            // 
            // tbCustomerName
            // 
            this.tbCustomerName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbCustomerName.DefaultText = "Trường ABC";
            this.tbCustomerName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbCustomerName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbCustomerName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbCustomerName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbCustomerName.Enabled = false;
            this.tbCustomerName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.tbCustomerName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.tbCustomerName.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.tbCustomerName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.tbCustomerName.Location = new System.Drawing.Point(170, 50);
            this.tbCustomerName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbCustomerName.Name = "tbCustomerName";
            this.tbCustomerName.PlaceholderText = "";
            this.tbCustomerName.ReadOnly = true;
            this.tbCustomerName.SelectedText = "";
            this.tbCustomerName.Size = new System.Drawing.Size(180, 29);
            this.tbCustomerName.TabIndex = 9;
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lbStatus.Location = new System.Drawing.Point(20, 220);
            this.lbStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(80, 19);
            this.lbStatus.TabIndex = 8;
            this.lbStatus.Text = "Trạng thái:";
            // 
            // lbCertificateType
            // 
            this.lbCertificateType.AutoSize = true;
            this.lbCertificateType.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbCertificateType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lbCertificateType.Location = new System.Drawing.Point(20, 275);
            this.lbCertificateType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCertificateType.Name = "lbCertificateType";
            this.lbCertificateType.Size = new System.Drawing.Size(109, 19);
            this.lbCertificateType.TabIndex = 7;
            this.lbCertificateType.Text = "Loại chứng chỉ:";
            // 
            // lbExpiryDate
            // 
            this.lbExpiryDate.AutoSize = true;
            this.lbExpiryDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbExpiryDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lbExpiryDate.Location = new System.Drawing.Point(20, 165);
            this.lbExpiryDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbExpiryDate.Name = "lbExpiryDate";
            this.lbExpiryDate.Size = new System.Drawing.Size(144, 19);
            this.lbExpiryDate.TabIndex = 6;
            this.lbExpiryDate.Text = "Hạn thanh toán đến:";
            // 
            // lbRegistrationDate
            // 
            this.lbRegistrationDate.AutoSize = true;
            this.lbRegistrationDate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbRegistrationDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lbRegistrationDate.Location = new System.Drawing.Point(20, 110);
            this.lbRegistrationDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbRegistrationDate.Name = "lbRegistrationDate";
            this.lbRegistrationDate.Size = new System.Drawing.Size(107, 19);
            this.lbRegistrationDate.TabIndex = 5;
            this.lbRegistrationDate.Text = "Ngày đăng ký:";
            // 
            // lbCustomerName
            // 
            this.lbCustomerName.AutoSize = true;
            this.lbCustomerName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lbCustomerName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lbCustomerName.Location = new System.Drawing.Point(20, 55);
            this.lbCustomerName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCustomerName.Name = "lbCustomerName";
            this.lbCustomerName.Size = new System.Drawing.Size(82, 19);
            this.lbCustomerName.TabIndex = 4;
            this.lbCustomerName.Text = "Tên đơn vị:";
            // 
            // grpSearch
            // 
            this.grpSearch.Controls.Add(this.btnSearch);
            this.grpSearch.Controls.Add(this.cmbUnpaidRegistrationID);
            this.grpSearch.Controls.Add(this.lbRegistrationCode);
            this.grpSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.grpSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.grpSearch.Location = new System.Drawing.Point(16, 16);
            this.grpSearch.Margin = new System.Windows.Forms.Padding(2);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Padding = new System.Windows.Forms.Padding(16, 16, 16, 16);
            this.grpSearch.Size = new System.Drawing.Size(848, 80);
            this.grpSearch.TabIndex = 0;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "Chọn phiếu đăng ký chưa thanh toán";
            // 
            // btnSearch
            // 
            this.btnSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnSearch.BorderRadius = 8;
            this.btnSearch.BorderThickness = 1;
            this.btnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(410, 32);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(110, 31);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Chọn";
            // 
            // cmbUnpaidRegistrationID
            // 
            this.cmbUnpaidRegistrationID.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold);
            this.cmbUnpaidRegistrationID.FormattingEnabled = true;
            this.cmbUnpaidRegistrationID.Items.AddRange(new object[] {
            "DV001",
            "DV002"});
            this.cmbUnpaidRegistrationID.Location = new System.Drawing.Point(190, 33);
            this.cmbUnpaidRegistrationID.Name = "cmbUnpaidRegistrationID";
            this.cmbUnpaidRegistrationID.Size = new System.Drawing.Size(200, 25);
            this.cmbUnpaidRegistrationID.TabIndex = 4;
            this.cmbUnpaidRegistrationID.Text = "PDK01";
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
            // lbHeader
            // 
            this.lbHeader.BackColor = System.Drawing.Color.White;
            this.lbHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbHeader.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lbHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.lbHeader.Location = new System.Drawing.Point(0, 0);
            this.lbHeader.Margin = new System.Windows.Forms.Padding(2);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(880, 60);
            this.lbHeader.TabIndex = 0;
            this.lbHeader.Text = "THANH TOÁN ĐƠN VỊ";
            this.lbHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.White;
            this.pnlHeader.Controls.Add(this.lbHeader);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(2);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(880, 60);
            this.pnlHeader.TabIndex = 1;
            // 
            // OrganizationPayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(880, 561);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "OrganizationPayment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrganizationPayment";
            this.pnlContainer.ResumeLayout(false);
            this.grpPaymentInfo.ResumeLayout(false);
            this.grpPaymentInfo.PerformLayout();
            this.grpCustomerInfo.ResumeLayout(false);
            this.grpCustomerInfo.PerformLayout();
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.pnlHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.Label lbHeader;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.Label lbRegistrationCode;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private System.Windows.Forms.ComboBox cmbUnpaidRegistrationID;
        private System.Windows.Forms.GroupBox grpCustomerInfo;
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
        private System.Windows.Forms.GroupBox grpPaymentInfo;
        private Guna.UI2.WinForms.Guna2TextBox tbTotalCost;
        private System.Windows.Forms.Label lbTotalCost;
        private Guna.UI2.WinForms.Guna2TextBox tbSupportAmount;
        private System.Windows.Forms.Label lbSupportAmount;
        private Guna.UI2.WinForms.Guna2TextBox tbFinalAmount;
        private System.Windows.Forms.Label lbFinalAmount;
        private Guna.UI2.WinForms.Guna2Button btnConfirmPayment;
        private Guna.UI2.WinForms.Guna2TextBox tbTransactionID;
        private System.Windows.Forms.Label lbTransactionID;
        private Guna.UI2.WinForms.Guna2Button btnCreateInvoice;
        private System.Windows.Forms.Panel pnlHeader;
    }
}