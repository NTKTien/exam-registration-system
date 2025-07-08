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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.btnDownload = new Guna.UI2.WinForms.Guna2Button();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.tbSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvRegulations = new Guna.UI2.WinForms.Guna2DataGridView();
            this.RegulationID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegulationContent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.btnRefundPolicy = new Guna.UI2.WinForms.Guna2Button();
            this.btnSpecialHandling = new Guna.UI2.WinForms.Guna2Button();
            this.btnExtensionRules = new Guna.UI2.WinForms.Guna2Button();
            this.btnPaymentRules = new Guna.UI2.WinForms.Guna2Button();
            this.btnRegistrationRules = new Guna.UI2.WinForms.Guna2Button();
            this.lbHeader = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pnlContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegulations)).BeginInit();
            this.pnlHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlContainer
            // 
            this.pnlContainer.Controls.Add(this.btnDownload);
            this.pnlContainer.Controls.Add(this.btnSearch);
            this.pnlContainer.Controls.Add(this.tbSearch);
            this.pnlContainer.Controls.Add(this.dgvRegulations);
            this.pnlContainer.Controls.Add(this.pnlHeader);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlContainer.Location = new System.Drawing.Point(0, 0);
            this.pnlContainer.Margin = new System.Windows.Forms.Padding(2);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(897, 672);
            this.pnlContainer.TabIndex = 0;
            // 
            // btnDownload
            // 
            this.btnDownload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnDownload.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDownload.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDownload.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDownload.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDownload.FillColor = System.Drawing.Color.LimeGreen;
            this.btnDownload.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownload.ForeColor = System.Drawing.Color.White;
            this.btnDownload.Location = new System.Drawing.Point(33, 112);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(100, 30);
            this.btnDownload.TabIndex = 6;
            this.btnDownload.Text = "↓ Tải xuống";
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
            this.btnSearch.Location = new System.Drawing.Point(780, 112);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(80, 30);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Tìm kiếm";
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
            this.tbSearch.Location = new System.Drawing.Point(580, 112);
            this.tbSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.PlaceholderText = "";
            this.tbSearch.SelectedText = "";
            this.tbSearch.Size = new System.Drawing.Size(200, 30);
            this.tbSearch.TabIndex = 4;
            // 
            // dgvRegulations
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvRegulations.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRegulations.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvRegulations.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.dgvRegulations.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvRegulations.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRegulations.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRegulations.ColumnHeadersHeight = 40;
            this.dgvRegulations.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RegulationID,
            this.RegulationContent});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRegulations.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRegulations.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.dgvRegulations.Location = new System.Drawing.Point(32, 154);
            this.dgvRegulations.Margin = new System.Windows.Forms.Padding(2);
            this.dgvRegulations.Name = "dgvRegulations";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRegulations.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvRegulations.RowHeadersVisible = false;
            this.dgvRegulations.RowHeadersWidth = 51;
            this.dgvRegulations.RowTemplate.Height = 24;
            this.dgvRegulations.Size = new System.Drawing.Size(831, 485);
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
            this.dgvRegulations.ThemeStyle.HeaderStyle.Height = 40;
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
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.pnlHeader.Controls.Add(this.btnRefundPolicy);
            this.pnlHeader.Controls.Add(this.btnSpecialHandling);
            this.pnlHeader.Controls.Add(this.btnExtensionRules);
            this.pnlHeader.Controls.Add(this.btnPaymentRules);
            this.pnlHeader.Controls.Add(this.btnRegistrationRules);
            this.pnlHeader.Controls.Add(this.lbHeader);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Margin = new System.Windows.Forms.Padding(2);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(897, 94);
            this.pnlHeader.TabIndex = 0;
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
            this.btnRefundPolicy.Location = new System.Drawing.Point(703, 54);
            this.btnRefundPolicy.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefundPolicy.Name = "btnRefundPolicy";
            this.btnRefundPolicy.Size = new System.Drawing.Size(160, 32);
            this.btnRefundPolicy.TabIndex = 10;
            this.btnRefundPolicy.Text = "💰Chính sách hoàn tiền";
            this.btnRefundPolicy.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.btnSpecialHandling.Location = new System.Drawing.Point(536, 54);
            this.btnSpecialHandling.Margin = new System.Windows.Forms.Padding(2);
            this.btnSpecialHandling.Name = "btnSpecialHandling";
            this.btnSpecialHandling.Size = new System.Drawing.Size(151, 32);
            this.btnSpecialHandling.TabIndex = 9;
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
            this.btnExtensionRules.Location = new System.Drawing.Point(368, 54);
            this.btnExtensionRules.Margin = new System.Windows.Forms.Padding(2);
            this.btnExtensionRules.Name = "btnExtensionRules";
            this.btnExtensionRules.Size = new System.Drawing.Size(153, 32);
            this.btnExtensionRules.TabIndex = 7;
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
            this.btnPaymentRules.Location = new System.Drawing.Point(210, 54);
            this.btnPaymentRules.Margin = new System.Windows.Forms.Padding(2);
            this.btnPaymentRules.Name = "btnPaymentRules";
            this.btnPaymentRules.Size = new System.Drawing.Size(146, 32);
            this.btnPaymentRules.TabIndex = 8;
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
            this.btnRegistrationRules.Location = new System.Drawing.Point(32, 54);
            this.btnRegistrationRules.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistrationRules.Name = "btnRegistrationRules";
            this.btnRegistrationRules.Size = new System.Drawing.Size(160, 32);
            this.btnRegistrationRules.TabIndex = 6;
            this.btnRegistrationRules.Text = "📝 QĐ Dăng ký dự thi";
            // 
            // lbHeader
            // 
            this.lbHeader.BackColor = System.Drawing.Color.Transparent;
            this.lbHeader.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHeader.ForeColor = System.Drawing.Color.Black;
            this.lbHeader.Location = new System.Drawing.Point(389, 6);
            this.lbHeader.Margin = new System.Windows.Forms.Padding(2);
            this.lbHeader.Name = "lbHeader";
            this.lbHeader.Size = new System.Drawing.Size(108, 32);
            this.lbHeader.TabIndex = 1;
            this.lbHeader.Text = "QUY ĐỊNH";
            this.lbHeader.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RegulationsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(897, 672);
            this.Controls.Add(this.pnlContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RegulationsView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegulationsView";
            this.pnlContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegulations)).EndInit();
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlContainer;
        private Guna.UI2.WinForms.Guna2HtmlLabel lbHeader;
        private Guna.UI2.WinForms.Guna2DataGridView dgvRegulations;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegulationID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegulationContent;
        private Guna.UI2.WinForms.Guna2TextBox tbSearch;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2Button btnDownload;
        private Guna.UI2.WinForms.Guna2Panel pnlHeader;
        private Guna.UI2.WinForms.Guna2Button btnRefundPolicy;
        private Guna.UI2.WinForms.Guna2Button btnSpecialHandling;
        private Guna.UI2.WinForms.Guna2Button btnExtensionRules;
        private Guna.UI2.WinForms.Guna2Button btnPaymentRules;
        private Guna.UI2.WinForms.Guna2Button btnRegistrationRules;
    }
}