namespace exam_registration_system.MainForms.NVTN
{
    partial class ListCertificatescsUnitForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelHeader = new Guna.UI2.WinForms.Guna2Panel();
            this.labelDetailReg = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.textSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvRegList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.butSearch = new Guna.UI2.WinForms.Guna2PictureBox();
            this.codeReg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateCreated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDGNL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateExame = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.butSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(190)))), ((int)(((byte)(230)))));
            this.panelHeader.BorderColor = System.Drawing.Color.Gray;
            this.panelHeader.BorderThickness = 1;
            this.panelHeader.Controls.Add(this.labelDetailReg);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(4);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1400, 88);
            this.panelHeader.TabIndex = 2;
            // 
            // labelDetailReg
            // 
            this.labelDetailReg.AutoSize = false;
            this.labelDetailReg.BackColor = System.Drawing.Color.Transparent;
            this.labelDetailReg.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDetailReg.Location = new System.Drawing.Point(485, 18);
            this.labelDetailReg.Margin = new System.Windows.Forms.Padding(4);
            this.labelDetailReg.Name = "labelDetailReg";
            this.labelDetailReg.Size = new System.Drawing.Size(430, 48);
            this.labelDetailReg.TabIndex = 0;
            this.labelDetailReg.Text = "Danh sách chứng chỉ đơn vị";
            // 
            // textSearch
            // 
            this.textSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textSearch.BorderRadius = 5;
            this.textSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textSearch.DefaultText = "";
            this.textSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.textSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.textSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.textSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.textSearch.ForeColor = System.Drawing.Color.Black;
            this.textSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.textSearch.Location = new System.Drawing.Point(860, 88);
            this.textSearch.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.textSearch.Name = "textSearch";
            this.textSearch.PlaceholderText = "Nhập thông tin thí sinh để tìm kiếm ";
            this.textSearch.SelectedText = "";
            this.textSearch.Size = new System.Drawing.Size(480, 58);
            this.textSearch.TabIndex = 63;
            // 
            // dgvRegList
            // 
            this.dgvRegList.AllowUserToAddRows = false;
            this.dgvRegList.AllowUserToDeleteRows = false;
            this.dgvRegList.AllowUserToResizeColumns = false;
            this.dgvRegList.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            this.dgvRegList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvRegList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.dgvRegList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvRegList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRegList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvRegList.ColumnHeadersHeight = 50;
            this.dgvRegList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvRegList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeReg,
            this.dateCreated,
            this.typeDGNL,
            this.dateExame,
            this.customerName,
            this.TypeCustomer});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRegList.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvRegList.GridColor = System.Drawing.Color.Black;
            this.dgvRegList.Location = new System.Drawing.Point(50, 148);
            this.dgvRegList.Name = "dgvRegList";
            this.dgvRegList.ReadOnly = true;
            this.dgvRegList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRegList.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvRegList.RowHeadersVisible = false;
            this.dgvRegList.RowHeadersWidth = 51;
            this.dgvRegList.RowTemplate.Height = 24;
            this.dgvRegList.Size = new System.Drawing.Size(1290, 573);
            this.dgvRegList.TabIndex = 62;
            this.dgvRegList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvRegList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvRegList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvRegList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvRegList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvRegList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvRegList.ThemeStyle.GridColor = System.Drawing.Color.Black;
            this.dgvRegList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvRegList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvRegList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvRegList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvRegList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvRegList.ThemeStyle.HeaderStyle.Height = 50;
            this.dgvRegList.ThemeStyle.ReadOnly = true;
            this.dgvRegList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvRegList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvRegList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvRegList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvRegList.ThemeStyle.RowsStyle.Height = 24;
            this.dgvRegList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvRegList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // butSearch
            // 
            this.butSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butSearch.BackColor = System.Drawing.Color.White;
            this.butSearch.Image = global::exam_registration_system.Properties.Resources.images;
            this.butSearch.ImageRotate = 0F;
            this.butSearch.Location = new System.Drawing.Point(1288, 91);
            this.butSearch.Margin = new System.Windows.Forms.Padding(4);
            this.butSearch.Name = "butSearch";
            this.butSearch.Size = new System.Drawing.Size(52, 50);
            this.butSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.butSearch.TabIndex = 64;
            this.butSearch.TabStop = false;
            // 
            // codeReg
            // 
            this.codeReg.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.codeReg.HeaderText = "STT";
            this.codeReg.MinimumWidth = 100;
            this.codeReg.Name = "codeReg";
            this.codeReg.ReadOnly = true;
            this.codeReg.Width = 150;
            // 
            // dateCreated
            // 
            this.dateCreated.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dateCreated.FillWeight = 120F;
            this.dateCreated.HeaderText = "Họ Tên ";
            this.dateCreated.MinimumWidth = 120;
            this.dateCreated.Name = "dateCreated";
            this.dateCreated.ReadOnly = true;
            this.dateCreated.Width = 120;
            // 
            // typeDGNL
            // 
            this.typeDGNL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.typeDGNL.FillWeight = 150F;
            this.typeDGNL.HeaderText = "Mã số thí sinh ";
            this.typeDGNL.MinimumWidth = 150;
            this.typeDGNL.Name = "typeDGNL";
            this.typeDGNL.ReadOnly = true;
            this.typeDGNL.Width = 150;
            // 
            // dateExame
            // 
            this.dateExame.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dateExame.FillWeight = 120F;
            this.dateExame.HeaderText = "Ngày dự thi";
            this.dateExame.MinimumWidth = 120;
            this.dateExame.Name = "dateExame";
            this.dateExame.ReadOnly = true;
            this.dateExame.Width = 120;
            // 
            // customerName
            // 
            this.customerName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.customerName.FillWeight = 140F;
            this.customerName.HeaderText = "Kết quả";
            this.customerName.MinimumWidth = 140;
            this.customerName.Name = "customerName";
            this.customerName.ReadOnly = true;
            this.customerName.Width = 140;
            // 
            // TypeCustomer
            // 
            this.TypeCustomer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TypeCustomer.HeaderText = "Trạng thái ";
            this.TypeCustomer.MinimumWidth = 100;
            this.TypeCustomer.Name = "TypeCustomer";
            this.TypeCustomer.ReadOnly = true;
            this.TypeCustomer.Width = 150;
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.guna2Button1.BorderRadius = 5;
            this.guna2Button1.BorderThickness = 1;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(117)))), ((int)(((byte)(185)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(1187, 730);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(153, 51);
            this.guna2Button1.TabIndex = 65;
            this.guna2Button1.Text = "Xem chi tiết  ";
            // 
            // ListCertificatescsUnitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 794);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.butSearch);
            this.Controls.Add(this.textSearch);
            this.Controls.Add(this.dgvRegList);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListCertificatescsUnitForm";
            this.Text = "ListCertificatescsUnitForm";
            this.Load += new System.EventHandler(this.ListCertificatescsUnitForm_Load);
            this.panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.butSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel panelHeader;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelDetailReg;
        private Guna.UI2.WinForms.Guna2PictureBox butSearch;
        private Guna.UI2.WinForms.Guna2TextBox textSearch;
        private Guna.UI2.WinForms.Guna2DataGridView dgvRegList;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeReg;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateCreated;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDGNL;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateExame;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeCustomer;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}