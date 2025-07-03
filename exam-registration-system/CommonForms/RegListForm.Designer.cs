namespace exam_registration_system.CommonForms
{
    partial class RegListForm
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
            this.panelContent = new Guna.UI2.WinForms.Guna2Panel();
            this.butCreateReg = new Guna.UI2.WinForms.Guna2Button();
            this.labelDetailReg = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.textSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvRegList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.codeReg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateCreated = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDGNL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateExame = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegList)).BeginInit();
            this.SuspendLayout();
            // 
            // panelContent
            // 
            this.panelContent.BorderColor = System.Drawing.Color.Gray;
            this.panelContent.BorderThickness = 1;
            this.panelContent.Controls.Add(this.butCreateReg);
            this.panelContent.Controls.Add(this.labelDetailReg);
            this.panelContent.Controls.Add(this.textSearch);
            this.panelContent.Controls.Add(this.dgvRegList);
            this.panelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContent.Location = new System.Drawing.Point(0, 0);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(897, 672);
            this.panelContent.TabIndex = 2;
            // 
            // butCreateReg
            // 
            this.butCreateReg.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.butCreateReg.BorderRadius = 5;
            this.butCreateReg.BorderThickness = 1;
            this.butCreateReg.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butCreateReg.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butCreateReg.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butCreateReg.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butCreateReg.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(117)))), ((int)(((byte)(185)))));
            this.butCreateReg.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCreateReg.ForeColor = System.Drawing.Color.White;
            this.butCreateReg.Location = new System.Drawing.Point(345, 78);
            this.butCreateReg.Name = "butCreateReg";
            this.butCreateReg.Size = new System.Drawing.Size(88, 33);
            this.butCreateReg.TabIndex = 23;
            this.butCreateReg.Text = "Tra cứu ";
            // 
            // labelDetailReg
            // 
            this.labelDetailReg.AutoSize = false;
            this.labelDetailReg.BackColor = System.Drawing.Color.Transparent;
            this.labelDetailReg.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDetailReg.Location = new System.Drawing.Point(231, 12);
            this.labelDetailReg.Name = "labelDetailReg";
            this.labelDetailReg.Size = new System.Drawing.Size(446, 32);
            this.labelDetailReg.TabIndex = 62;
            this.labelDetailReg.Text = "Danh sách phiếu đăng ký đánh giá năng lực";
            // 
            // textSearch
            // 
            this.textSearch.BorderColor = System.Drawing.Color.DimGray;
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
            this.textSearch.Location = new System.Drawing.Point(17, 76);
            this.textSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textSearch.Name = "textSearch";
            this.textSearch.PlaceholderText = "Nhập thông tin phiếu đăng kí để tìm kiếm";
            this.textSearch.SelectedText = "";
            this.textSearch.Size = new System.Drawing.Size(320, 39);
            this.textSearch.TabIndex = 60;
            // 
            // dgvRegList
            // 
            this.dgvRegList.AllowUserToAddRows = false;
            this.dgvRegList.AllowUserToDeleteRows = false;
            this.dgvRegList.AllowUserToResizeColumns = false;
            this.dgvRegList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvRegList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRegList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.dgvRegList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvRegList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRegList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRegList.ColumnHeadersHeight = 50;
            this.dgvRegList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvRegList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codeReg,
            this.dateCreated,
            this.typeDGNL,
            this.dateExame,
            this.customerName,
            this.TypeCustomer,
            this.Status});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRegList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRegList.GridColor = System.Drawing.Color.Black;
            this.dgvRegList.Location = new System.Drawing.Point(17, 125);
            this.dgvRegList.Margin = new System.Windows.Forms.Padding(2);
            this.dgvRegList.Name = "dgvRegList";
            this.dgvRegList.ReadOnly = true;
            this.dgvRegList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRegList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvRegList.RowHeadersVisible = false;
            this.dgvRegList.RowHeadersWidth = 51;
            this.dgvRegList.RowTemplate.Height = 24;
            this.dgvRegList.Size = new System.Drawing.Size(863, 522);
            this.dgvRegList.TabIndex = 59;
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
            // codeReg
            // 
            this.codeReg.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.codeReg.HeaderText = "Mã phiếu";
            this.codeReg.MinimumWidth = 100;
            this.codeReg.Name = "codeReg";
            this.codeReg.ReadOnly = true;
            // 
            // dateCreated
            // 
            this.dateCreated.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dateCreated.FillWeight = 120F;
            this.dateCreated.HeaderText = "Ngày lập";
            this.dateCreated.MinimumWidth = 120;
            this.dateCreated.Name = "dateCreated";
            this.dateCreated.ReadOnly = true;
            this.dateCreated.Width = 120;
            // 
            // typeDGNL
            // 
            this.typeDGNL.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.typeDGNL.FillWeight = 150F;
            this.typeDGNL.HeaderText = "Loại ĐGNL";
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
            this.customerName.HeaderText = "Tên khách hàng";
            this.customerName.MinimumWidth = 140;
            this.customerName.Name = "customerName";
            this.customerName.ReadOnly = true;
            this.customerName.Width = 140;
            // 
            // TypeCustomer
            // 
            this.TypeCustomer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TypeCustomer.HeaderText = "Loai KH";
            this.TypeCustomer.MinimumWidth = 100;
            this.TypeCustomer.Name = "TypeCustomer";
            this.TypeCustomer.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Status.FillWeight = 130F;
            this.Status.HeaderText = "Trạng thái ";
            this.Status.MinimumWidth = 130;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 130;
            // 
            // RegListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(247)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(897, 672);
            this.Controls.Add(this.panelContent);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RegListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegListForm";
            this.Load += new System.EventHandler(this.RegListForm_Load);
            this.panelContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel panelContent;
        private Guna.UI2.WinForms.Guna2TextBox textSearch;
        private Guna.UI2.WinForms.Guna2DataGridView dgvRegList;
        private System.Windows.Forms.DataGridViewTextBoxColumn codeReg;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateCreated;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDGNL;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateExame;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelDetailReg;
        private Guna.UI2.WinForms.Guna2Button butCreateReg;
    }
}