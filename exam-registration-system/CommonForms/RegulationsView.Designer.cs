namespace exam_registration_system.CommonForms
{
    partial class RegulationsView
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvRegulations = new Guna.UI2.WinForms.Guna2DataGridView();
            this.RegulationID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegulationContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlNavigation = new Guna.UI2.WinForms.Guna2Panel();
            this.btnRefundPolicy = new Guna.UI2.WinForms.Guna2Button();
            this.btnSpecialHandling = new Guna.UI2.WinForms.Guna2Button();
            this.btnExtensionRules = new Guna.UI2.WinForms.Guna2Button();
            this.btnPaymentRules = new Guna.UI2.WinForms.Guna2Button();
            this.btnRegistrationRules = new Guna.UI2.WinForms.Guna2Button();
            this.lbHeader = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pnlHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.tbSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.btnDownload = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.pnlContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegulations)).BeginInit();
            this.pnlNavigation.SuspendLayout();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContainer
            // 
            this.pnlContainer.Controls.Add(this.btnDownload);
            this.pnlContainer.Controls.Add(this.btnSearch);
            this.pnlContainer.Controls.Add(this.tbSearch);
            this.pnlContainer.Controls.Add(this.dgvRegulations);
            this.pnlContainer.Controls.Add(this.pnlNavigation);
            this.pnlContainer.Controls.Add(this.lbHeader);
            this.pnlContainer.Controls.Add(this.pnlHeader);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlContainer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(880, 440);
            this.pnlContainer.TabIndex = 0;
            // 
            // dgvRegulations
            // 
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.White;
            this.dgvRegulations.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle13;
            this.dgvRegulations.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvRegulations.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.dgvRegulations.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvRegulations.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRegulations.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.dgvRegulations.ColumnHeadersHeight = 30;
            this.dgvRegulations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RegulationID,
            this.RegulationContent});
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRegulations.DefaultCellStyle = dataGridViewCellStyle15;
            this.dgvRegulations.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.dgvRegulations.Location = new System.Drawing.Point(40, 140);
            this.dgvRegulations.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvRegulations.Name = "dgvRegulations";
            this.dgvRegulations.RowHeadersVisible = false;
            this.dgvRegulations.RowHeadersWidth = 51;
            this.dgvRegulations.RowTemplate.Height = 24;
            this.dgvRegulations.Size = new System.Drawing.Size(800, 280);
            this.dgvRegulations.TabIndex = 3;
            this.dgvRegulations.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvRegulations.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvRegulations.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvRegulations.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvRegulations.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvRegulations.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.dgvRegulations.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.dgvRegulations.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvRegulations.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvRegulations.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvRegulations.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvRegulations.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRegulations.ThemeStyle.HeaderStyle.Height = 30;
            this.dgvRegulations.ThemeStyle.ReadOnly = false;
            this.dgvRegulations.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvRegulations.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvRegulations.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvRegulations.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvRegulations.ThemeStyle.RowsStyle.Height = 24;
            this.dgvRegulations.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvRegulations.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // RegulationID
            // 
            this.RegulationID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.RegulationID.FillWeight = 150F;
            this.RegulationID.HeaderText = "Mã quy định";
            this.RegulationID.MinimumWidth = 6;
            this.RegulationID.Name = "RegulationID";
            this.RegulationID.ReadOnly = true;
            this.RegulationID.Width = 150;
            // 
            // RegulationContent
            // 
            this.RegulationContent.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RegulationContent.FillWeight = 37.50894F;
            this.RegulationContent.HeaderText = "Nội dung";
            this.RegulationContent.MinimumWidth = 6;
            this.RegulationContent.Name = "RegulationContent";
            this.RegulationContent.ReadOnly = true;
            // 
            // pnlNavigation
            // 
            this.pnlNavigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.pnlNavigation.Controls.Add(this.btnRefundPolicy);
            this.pnlNavigation.Controls.Add(this.btnSpecialHandling);
            this.pnlNavigation.Controls.Add(this.btnExtensionRules);
            this.pnlNavigation.Controls.Add(this.btnPaymentRules);
            this.pnlNavigation.Controls.Add(this.btnRegistrationRules);
            this.pnlNavigation.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlNavigation.Location = new System.Drawing.Point(0, 40);
            this.pnlNavigation.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlNavigation.Name = "pnlNavigation";
            this.pnlNavigation.Size = new System.Drawing.Size(880, 40);
            this.pnlNavigation.TabIndex = 2;
            // 
            // btnRefundPolicy
            // 
            this.btnRefundPolicy.BorderRadius = 8;
            this.btnRefundPolicy.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRefundPolicy.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRefundPolicy.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRefundPolicy.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRefundPolicy.FillColor = System.Drawing.Color.White;
            this.btnRefundPolicy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnRefundPolicy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnRefundPolicy.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.btnRefundPolicy.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnRefundPolicy.Location = new System.Drawing.Point(712, 4);
            this.btnRefundPolicy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRefundPolicy.Name = "btnRefundPolicy";
            this.btnRefundPolicy.Size = new System.Drawing.Size(160, 32);
            this.btnRefundPolicy.TabIndex = 5;
            this.btnRefundPolicy.Text = "💰Chính sách hoàn tiền";
            this.btnRefundPolicy.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnRefundPolicy.Visible = false;
            // 
            // btnSpecialHandling
            // 
            this.btnSpecialHandling.BorderRadius = 8;
            this.btnSpecialHandling.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSpecialHandling.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSpecialHandling.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSpecialHandling.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSpecialHandling.FillColor = System.Drawing.Color.White;
            this.btnSpecialHandling.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnSpecialHandling.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnSpecialHandling.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.btnSpecialHandling.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnSpecialHandling.Location = new System.Drawing.Point(536, 4);
            this.btnSpecialHandling.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSpecialHandling.Name = "btnSpecialHandling";
            this.btnSpecialHandling.Size = new System.Drawing.Size(160, 32);
            this.btnSpecialHandling.TabIndex = 4;
            this.btnSpecialHandling.Text = "⚡ Xử lý đặc biệt";
            // 
            // btnExtensionRules
            // 
            this.btnExtensionRules.BorderRadius = 8;
            this.btnExtensionRules.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExtensionRules.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExtensionRules.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExtensionRules.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExtensionRules.FillColor = System.Drawing.Color.White;
            this.btnExtensionRules.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnExtensionRules.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnExtensionRules.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.btnExtensionRules.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnExtensionRules.Location = new System.Drawing.Point(360, 4);
            this.btnExtensionRules.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnExtensionRules.Name = "btnExtensionRules";
            this.btnExtensionRules.Size = new System.Drawing.Size(160, 32);
            this.btnExtensionRules.TabIndex = 3;
            this.btnExtensionRules.Text = "⏰ QĐ gia hạn";
            // 
            // btnPaymentRules
            // 
            this.btnPaymentRules.BorderRadius = 8;
            this.btnPaymentRules.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPaymentRules.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPaymentRules.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPaymentRules.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPaymentRules.FillColor = System.Drawing.Color.White;
            this.btnPaymentRules.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnPaymentRules.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnPaymentRules.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.btnPaymentRules.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnPaymentRules.Location = new System.Drawing.Point(184, 4);
            this.btnPaymentRules.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnPaymentRules.Name = "btnPaymentRules";
            this.btnPaymentRules.Size = new System.Drawing.Size(160, 32);
            this.btnPaymentRules.TabIndex = 3;
            this.btnPaymentRules.Text = "💳 QĐ thanh toán";
            // 
            // btnRegistrationRules
            // 
            this.btnRegistrationRules.BorderRadius = 8;
            this.btnRegistrationRules.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRegistrationRules.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRegistrationRules.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRegistrationRules.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRegistrationRules.FillColor = System.Drawing.Color.White;
            this.btnRegistrationRules.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrationRules.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnRegistrationRules.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(196)))), ((int)(((byte)(15)))));
            this.btnRegistrationRules.HoverState.ForeColor = System.Drawing.Color.White;
            this.btnRegistrationRules.Location = new System.Drawing.Point(8, 4);
            this.btnRegistrationRules.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRegistrationRules.Name = "btnRegistrationRules";
            this.btnRegistrationRules.Size = new System.Drawing.Size(160, 32);
            this.btnRegistrationRules.TabIndex = 1;
            this.btnRegistrationRules.Text = "📝 QĐ Dăng ký dự thi";
            // 
            // lbHeader
            // 
            this.lbHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.lbHeader.Font = new System.Drawing.Font("Segoe UI", 14.5F, System.Drawing.FontStyle.Bold);
            this.lbHeader.ForeColor = System.Drawing.Color.White;
            this.lbHeader.Location = new System.Drawing.Point(6, 6);
            this.lbHeader.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(98, 27);
            this.lbHeader.TabIndex = 1;
            this.lbHeader.Text = "QUY ĐỊNH";
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.pnlHeader.Controls.Add(this.guna2Button1);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(880, 40);
            this.pnlHeader.TabIndex = 0;
            // 
            // tbSearch
            // 
            this.tbSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSearch.DefaultText = "";
            this.tbSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.tbSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbSearch.Location = new System.Drawing.Point(560, 90);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.PlaceholderText = "";
            this.tbSearch.SelectedText = "";
            this.tbSearch.Size = new System.Drawing.Size(200, 30);
            this.tbSearch.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(760, 90);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 30);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Tìm kiếm";
            // 
            // btnDownload
            // 
            this.btnDownload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnDownload.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDownload.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDownload.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDownload.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDownload.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnDownload.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownload.ForeColor = System.Drawing.Color.White;
            this.btnDownload.Location = new System.Drawing.Point(40, 90);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(100, 30);
            this.btnDownload.TabIndex = 6;
            this.btnDownload.Text = "↓ Tải xuống";
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderColor = System.Drawing.Color.White;
            this.guna2Button1.BorderRadius = 5;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Red;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(845, 5);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(30, 30);
            this.guna2Button1.TabIndex = 0;
            this.guna2Button1.Text = "❌";
            // 
            // RegulationsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(880, 440);
            this.Controls.Add(this.pnlContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "RegulationsView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegulationsView";
            this.pnlContainer.ResumeLayout(false);
            this.pnlContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegulations)).EndInit();
            this.pnlNavigation.ResumeLayout(false);
            this.pnlHeader.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlContainer;
        private Guna.UI2.WinForms.Guna2Panel pnlHeader;
        private Guna.UI2.WinForms.Guna2Panel pnlNavigation;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbHeader;
        private Guna.UI2.WinForms.Guna2Button btnRegistrationRules;
        private Guna.UI2.WinForms.Guna2Button btnPaymentRules;
        private Guna.UI2.WinForms.Guna2Button btnExtensionRules;
        private Guna.UI2.WinForms.Guna2Button btnSpecialHandling;
        private Guna.UI2.WinForms.Guna2Button btnRefundPolicy;
        private Guna.UI2.WinForms.Guna2DataGridView dgvRegulations;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegulationID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegulationContent;
        private Guna.UI2.WinForms.Guna2TextBox tbSearch;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2Button btnDownload;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}