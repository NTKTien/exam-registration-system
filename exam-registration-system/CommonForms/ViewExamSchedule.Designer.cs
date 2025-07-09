namespace exam_registration_system.CommonForms
{
    partial class ViewExamSchedule
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.butSelect = new Guna.UI2.WinForms.Guna2Button();
            this.dgvExamSchedule = new Guna.UI2.WinForms.Guna2DataGridView();
            this.butSearch = new Guna.UI2.WinForms.Guna2Button();
            this.textSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.labelDetailReg = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Examdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Shift = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Room = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentAmout = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guna2Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExamSchedule)).BeginInit();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel3.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel3.BorderThickness = 1;
            this.guna2Panel3.Controls.Add(this.butSelect);
            this.guna2Panel3.Controls.Add(this.dgvExamSchedule);
            this.guna2Panel3.Controls.Add(this.butSearch);
            this.guna2Panel3.Controls.Add(this.textSearch);
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel3.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Panel3.Location = new System.Drawing.Point(0, 54);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.ShadowDecoration.BorderRadius = 15;
            this.guna2Panel3.ShadowDecoration.Depth = 10;
            this.guna2Panel3.ShadowDecoration.Enabled = true;
            this.guna2Panel3.Size = new System.Drawing.Size(881, 491);
            this.guna2Panel3.TabIndex = 5;
            // 
            // butSelect
            // 
            this.butSelect.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.butSelect.BorderRadius = 5;
            this.butSelect.BorderThickness = 1;
            this.butSelect.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butSelect.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butSelect.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butSelect.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butSelect.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(117)))), ((int)(((byte)(185)))));
            this.butSelect.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSelect.ForeColor = System.Drawing.Color.White;
            this.butSelect.Location = new System.Drawing.Point(763, 446);
            this.butSelect.Name = "butSelect";
            this.butSelect.Size = new System.Drawing.Size(88, 33);
            this.butSelect.TabIndex = 64;
            this.butSelect.Text = "Chọn";
            this.butSelect.Click += new System.EventHandler(this.butSelect_Click);
            // 
            // dgvExamSchedule
            // 
            this.dgvExamSchedule.AllowUserToAddRows = false;
            this.dgvExamSchedule.AllowUserToDeleteRows = false;
            this.dgvExamSchedule.AllowUserToResizeColumns = false;
            this.dgvExamSchedule.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dgvExamSchedule.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvExamSchedule.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.dgvExamSchedule.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dgvExamSchedule.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExamSchedule.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvExamSchedule.ColumnHeadersHeight = 50;
            this.dgvExamSchedule.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvExamSchedule.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.code,
            this.Examdate,
            this.Shift,
            this.Room,
            this.type,
            this.maxAmount,
            this.CurrentAmout});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvExamSchedule.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvExamSchedule.GridColor = System.Drawing.Color.Black;
            this.dgvExamSchedule.Location = new System.Drawing.Point(25, 86);
            this.dgvExamSchedule.Margin = new System.Windows.Forms.Padding(2);
            this.dgvExamSchedule.Name = "dgvExamSchedule";
            this.dgvExamSchedule.ReadOnly = true;
            this.dgvExamSchedule.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExamSchedule.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvExamSchedule.RowHeadersVisible = false;
            this.dgvExamSchedule.RowHeadersWidth = 51;
            this.dgvExamSchedule.RowTemplate.Height = 32;
            this.dgvExamSchedule.Size = new System.Drawing.Size(834, 343);
            this.dgvExamSchedule.TabIndex = 63;
            this.dgvExamSchedule.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvExamSchedule.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvExamSchedule.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvExamSchedule.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvExamSchedule.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvExamSchedule.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvExamSchedule.ThemeStyle.GridColor = System.Drawing.Color.Black;
            this.dgvExamSchedule.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvExamSchedule.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvExamSchedule.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvExamSchedule.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvExamSchedule.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvExamSchedule.ThemeStyle.HeaderStyle.Height = 50;
            this.dgvExamSchedule.ThemeStyle.ReadOnly = true;
            this.dgvExamSchedule.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvExamSchedule.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvExamSchedule.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvExamSchedule.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvExamSchedule.ThemeStyle.RowsStyle.Height = 32;
            this.dgvExamSchedule.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvExamSchedule.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // butSearch
            // 
            this.butSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.butSearch.BorderRadius = 5;
            this.butSearch.BorderThickness = 1;
            this.butSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.butSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.butSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.butSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.butSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(117)))), ((int)(((byte)(185)))));
            this.butSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butSearch.ForeColor = System.Drawing.Color.White;
            this.butSearch.Location = new System.Drawing.Point(302, 29);
            this.butSearch.Name = "butSearch";
            this.butSearch.Size = new System.Drawing.Size(88, 33);
            this.butSearch.TabIndex = 61;
            this.butSearch.Text = "Tra cứu ";
            this.butSearch.Click += new System.EventHandler(this.butSearch_Click);
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
            this.textSearch.Location = new System.Drawing.Point(25, 27);
            this.textSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textSearch.Name = "textSearch";
            this.textSearch.PlaceholderText = "Nhập thông tin  lịch thi để tìm kiếm";
            this.textSearch.SelectedText = "";
            this.textSearch.Size = new System.Drawing.Size(267, 39);
            this.textSearch.TabIndex = 62;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(190)))), ((int)(((byte)(230)))));
            this.guna2Panel2.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel2.BorderThickness = 1;
            this.guna2Panel2.Controls.Add(this.btnExit);
            this.guna2Panel2.Controls.Add(this.labelDetailReg);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Padding = new System.Windows.Forms.Padding(15, 16, 15, 16);
            this.guna2Panel2.Size = new System.Drawing.Size(881, 54);
            this.guna2Panel2.TabIndex = 1;
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
            this.btnExit.Location = new System.Drawing.Point(844, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(37, 30);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "✕";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // labelDetailReg
            // 
            this.labelDetailReg.AutoSize = false;
            this.labelDetailReg.BackColor = System.Drawing.Color.Transparent;
            this.labelDetailReg.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDetailReg.ForeColor = System.Drawing.Color.Black;
            this.labelDetailReg.Location = new System.Drawing.Point(345, 12);
            this.labelDetailReg.Name = "labelDetailReg";
            this.labelDetailReg.Size = new System.Drawing.Size(189, 36);
            this.labelDetailReg.TabIndex = 1;
            this.labelDetailReg.Text = "Danh sách lịch thi";
            // 
            // code
            // 
            this.code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.code.DataPropertyName = "MaLT";
            this.code.HeaderText = "Mã Lịch thi";
            this.code.MinimumWidth = 100;
            this.code.Name = "code";
            this.code.ReadOnly = true;
            // 
            // Examdate
            // 
            this.Examdate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Examdate.DataPropertyName = "NgayThi";
            this.Examdate.FillWeight = 145F;
            this.Examdate.HeaderText = "Ngày thi";
            this.Examdate.MinimumWidth = 145;
            this.Examdate.Name = "Examdate";
            this.Examdate.ReadOnly = true;
            this.Examdate.Width = 145;
            // 
            // Shift
            // 
            this.Shift.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Shift.DataPropertyName = "CaThi";
            this.Shift.HeaderText = "Ca thi";
            this.Shift.MinimumWidth = 100;
            this.Shift.Name = "Shift";
            this.Shift.ReadOnly = true;
            // 
            // Room
            // 
            this.Room.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Room.DataPropertyName = "PhongThi";
            this.Room.HeaderText = "Phòng thi";
            this.Room.MinimumWidth = 100;
            this.Room.Name = "Room";
            this.Room.ReadOnly = true;
            // 
            // type
            // 
            this.type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.type.DataPropertyName = "LoaiDGNL";
            this.type.FillWeight = 145F;
            this.type.HeaderText = "Loai CC";
            this.type.MinimumWidth = 145;
            this.type.Name = "type";
            this.type.ReadOnly = true;
            this.type.Width = 145;
            // 
            // maxAmount
            // 
            this.maxAmount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.maxAmount.DataPropertyName = "SLTSToiDa";
            this.maxAmount.FillWeight = 120F;
            this.maxAmount.HeaderText = "SLTS tối đa";
            this.maxAmount.MinimumWidth = 120;
            this.maxAmount.Name = "maxAmount";
            this.maxAmount.ReadOnly = true;
            this.maxAmount.Width = 120;
            // 
            // CurrentAmout
            // 
            this.CurrentAmout.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CurrentAmout.DataPropertyName = "SLTSHienTai";
            this.CurrentAmout.FillWeight = 120F;
            this.CurrentAmout.HeaderText = "SLTS hiện tại";
            this.CurrentAmout.MinimumWidth = 120;
            this.CurrentAmout.Name = "CurrentAmout";
            this.CurrentAmout.ReadOnly = true;
            this.CurrentAmout.Width = 120;
            // 
            // ViewExamSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(881, 545);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.guna2Panel2);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ViewExamSchedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewExamSchedule";
            this.Load += new System.EventHandler(this.ViewExamSchedule_Load);
            this.guna2Panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExamSchedule)).EndInit();
            this.guna2Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelDetailReg;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Guna.UI2.WinForms.Guna2Button butSearch;
        private Guna.UI2.WinForms.Guna2TextBox textSearch;
        private Guna.UI2.WinForms.Guna2DataGridView dgvExamSchedule;
        private Guna.UI2.WinForms.Guna2Button butSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn code;
        private System.Windows.Forms.DataGridViewTextBoxColumn Examdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Shift;
        private System.Windows.Forms.DataGridViewTextBoxColumn Room;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrentAmout;
    }
}