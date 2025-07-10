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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.ExamScheduleList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cccd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelInforHeader = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbxTypeCer = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.dateFilter = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnExit = new Guna.UI2.WinForms.Guna2Button();
            this.labelDetailReg = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel3.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExamScheduleList)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel3.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel3.BorderThickness = 1;
            this.guna2Panel3.Controls.Add(this.guna2Panel4);
            this.guna2Panel3.Controls.Add(this.guna2Panel1);
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel3.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Panel3.Location = new System.Drawing.Point(0, 68);
            this.guna2Panel3.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.ShadowDecoration.BorderRadius = 15;
            this.guna2Panel3.ShadowDecoration.Depth = 10;
            this.guna2Panel3.ShadowDecoration.Enabled = true;
            this.guna2Panel3.Size = new System.Drawing.Size(1144, 572);
            this.guna2Panel3.TabIndex = 5;
            this.guna2Panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel3_Paint);
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel4.BorderColor = System.Drawing.Color.Silver;
            this.guna2Panel4.BorderRadius = 28;
            this.guna2Panel4.BorderThickness = 1;
            this.guna2Panel4.Controls.Add(this.ExamScheduleList);
            this.guna2Panel4.Controls.Add(this.labelInforHeader);
            this.guna2Panel4.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Panel4.Location = new System.Drawing.Point(318, 26);
            this.guna2Panel4.Margin = new System.Windows.Forms.Padding(28, 30, 28, 30);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.Padding = new System.Windows.Forms.Padding(28, 30, 28, 30);
            this.guna2Panel4.ShadowDecoration.BorderRadius = 15;
            this.guna2Panel4.ShadowDecoration.Depth = 5;
            this.guna2Panel4.ShadowDecoration.Enabled = true;
            this.guna2Panel4.Size = new System.Drawing.Size(820, 525);
            this.guna2Panel4.TabIndex = 15;
            // 
            // ExamScheduleList
            // 
            this.ExamScheduleList.AllowUserToAddRows = false;
            this.ExamScheduleList.AllowUserToDeleteRows = false;
            this.ExamScheduleList.AllowUserToResizeColumns = false;
            this.ExamScheduleList.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.ExamScheduleList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.ExamScheduleList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.ExamScheduleList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ExamScheduleList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ExamScheduleList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ExamScheduleList.ColumnHeadersHeight = 50;
            this.ExamScheduleList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ExamScheduleList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stt,
            this.FullName,
            this.sex,
            this.birth,
            this.cccd,
            this.sdt,
            this.email});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.ExamScheduleList.DefaultCellStyle = dataGridViewCellStyle3;
            this.ExamScheduleList.GridColor = System.Drawing.Color.Black;
            this.ExamScheduleList.Location = new System.Drawing.Point(11, 55);
            this.ExamScheduleList.Margin = new System.Windows.Forms.Padding(2);
            this.ExamScheduleList.Name = "ExamScheduleList";
            this.ExamScheduleList.ReadOnly = true;
            this.ExamScheduleList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ExamScheduleList.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.ExamScheduleList.RowHeadersVisible = false;
            this.ExamScheduleList.RowHeadersWidth = 51;
            this.ExamScheduleList.RowTemplate.Height = 24;
            this.ExamScheduleList.Size = new System.Drawing.Size(804, 452);
            this.ExamScheduleList.TabIndex = 60;
            this.ExamScheduleList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.ExamScheduleList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.ExamScheduleList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.ExamScheduleList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.ExamScheduleList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.ExamScheduleList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.ExamScheduleList.ThemeStyle.GridColor = System.Drawing.Color.Black;
            this.ExamScheduleList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ExamScheduleList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.ExamScheduleList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExamScheduleList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.ExamScheduleList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.ExamScheduleList.ThemeStyle.HeaderStyle.Height = 50;
            this.ExamScheduleList.ThemeStyle.ReadOnly = true;
            this.ExamScheduleList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.ExamScheduleList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.ExamScheduleList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExamScheduleList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.ExamScheduleList.ThemeStyle.RowsStyle.Height = 24;
            this.ExamScheduleList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.ExamScheduleList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // stt
            // 
            this.stt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.stt.FillWeight = 50F;
            this.stt.HeaderText = "Mã LT";
            this.stt.MinimumWidth = 50;
            this.stt.Name = "stt";
            this.stt.ReadOnly = true;
            this.stt.Width = 50;
            // 
            // FullName
            // 
            this.FullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.FullName.FillWeight = 140F;
            this.FullName.HeaderText = "Ngày thi";
            this.FullName.MinimumWidth = 140;
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            this.FullName.Width = 140;
            // 
            // sex
            // 
            this.sex.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.sex.HeaderText = "ca thi";
            this.sex.MinimumWidth = 100;
            this.sex.Name = "sex";
            this.sex.ReadOnly = true;
            this.sex.Width = 125;
            // 
            // birth
            // 
            this.birth.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.birth.FillWeight = 120F;
            this.birth.HeaderText = "phòng";
            this.birth.MinimumWidth = 120;
            this.birth.Name = "birth";
            this.birth.ReadOnly = true;
            this.birth.Width = 120;
            // 
            // cccd
            // 
            this.cccd.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.cccd.HeaderText = "môn thi";
            this.cccd.MinimumWidth = 100;
            this.cccd.Name = "cccd";
            this.cccd.ReadOnly = true;
            this.cccd.Width = 125;
            // 
            // sdt
            // 
            this.sdt.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.sdt.FillWeight = 130F;
            this.sdt.HeaderText = "SL tối đa";
            this.sdt.MinimumWidth = 130;
            this.sdt.Name = "sdt";
            this.sdt.ReadOnly = true;
            this.sdt.Width = 130;
            // 
            // email
            // 
            this.email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.email.FillWeight = 120F;
            this.email.HeaderText = "SL hiện tại";
            this.email.MinimumWidth = 120;
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Width = 120;
            // 
            // labelInforHeader
            // 
            this.labelInforHeader.BackColor = System.Drawing.Color.Transparent;
            this.labelInforHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInforHeader.Location = new System.Drawing.Point(20, 15);
            this.labelInforHeader.Margin = new System.Windows.Forms.Padding(4);
            this.labelInforHeader.Name = "labelInforHeader";
            this.labelInforHeader.Size = new System.Drawing.Size(196, 34);
            this.labelInforHeader.TabIndex = 2;
            this.labelInforHeader.Text = "Danh sách lịch thi";
            this.labelInforHeader.Click += new System.EventHandler(this.labelInforHeader_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderColor = System.Drawing.Color.Silver;
            this.guna2Panel1.BorderRadius = 28;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.guna2ComboBox1);
            this.guna2Panel1.Controls.Add(this.cbxTypeCer);
            this.guna2Panel1.Controls.Add(this.btnSearch);
            this.guna2Panel1.Controls.Add(this.dateFilter);
            this.guna2Panel1.Controls.Add(this.guna2HtmlLabel1);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Panel1.Location = new System.Drawing.Point(12, 26);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(28, 30, 28, 30);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Padding = new System.Windows.Forms.Padding(28, 30, 28, 30);
            this.guna2Panel1.ShadowDecoration.BorderRadius = 15;
            this.guna2Panel1.ShadowDecoration.Depth = 5;
            this.guna2Panel1.ShadowDecoration.Enabled = true;
            this.guna2Panel1.Size = new System.Drawing.Size(287, 525);
            this.guna2Panel1.TabIndex = 7;
            // 
            // guna2ComboBox1
            // 
            this.guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox1.BorderRadius = 8;
            this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.guna2ComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox1.ItemHeight = 30;
            this.guna2ComboBox1.Items.AddRange(new object[] {
            "Ngoại ngữ",
            "Tin học"});
            this.guna2ComboBox1.Location = new System.Drawing.Point(25, 345);
            this.guna2ComboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.Size = new System.Drawing.Size(249, 36);
            this.guna2ComboBox1.TabIndex = 14;
            // 
            // cbxTypeCer
            // 
            this.cbxTypeCer.BackColor = System.Drawing.Color.Transparent;
            this.cbxTypeCer.BorderRadius = 8;
            this.cbxTypeCer.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxTypeCer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTypeCer.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxTypeCer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxTypeCer.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxTypeCer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbxTypeCer.ItemHeight = 30;
            this.cbxTypeCer.Items.AddRange(new object[] {
            "Ngoại ngữ",
            "Tin học"});
            this.cbxTypeCer.Location = new System.Drawing.Point(25, 241);
            this.cbxTypeCer.Margin = new System.Windows.Forms.Padding(4);
            this.cbxTypeCer.Name = "cbxTypeCer";
            this.cbxTypeCer.Size = new System.Drawing.Size(249, 36);
            this.cbxTypeCer.TabIndex = 13;
            // 
            // btnSearch
            // 
            this.btnSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.btnSearch.BorderRadius = 12;
            this.btnSearch.BorderThickness = 1;
            this.btnSearch.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(155, 431);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(118, 36);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // dateFilter
            // 
            this.dateFilter.Animated = true;
            this.dateFilter.AutoRoundedCorners = true;
            this.dateFilter.Checked = true;
            this.dateFilter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dateFilter.ForeColor = System.Drawing.Color.Cornsilk;
            this.dateFilter.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateFilter.Location = new System.Drawing.Point(25, 128);
            this.dateFilter.Margin = new System.Windows.Forms.Padding(2);
            this.dateFilter.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateFilter.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateFilter.Name = "dateFilter";
            this.dateFilter.Size = new System.Drawing.Size(249, 36);
            this.dateFilter.TabIndex = 1;
            this.dateFilter.Value = new System.DateTime(2025, 6, 27, 14, 26, 39, 971);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(12, 18);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(4);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(183, 34);
            this.guna2HtmlLabel1.TabIndex = 5;
            this.guna2HtmlLabel1.Text = "Tìm kiếm lịch thi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.label1.Location = new System.Drawing.Point(19, 84);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 0, 48, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 32);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ngày thi";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.label2.Location = new System.Drawing.Point(28, 192);
            this.label2.Margin = new System.Windows.Forms.Padding(0, 0, 48, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 32);
            this.label2.TabIndex = 7;
            this.label2.Text = "Môn thi";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.label3.Location = new System.Drawing.Point(28, 299);
            this.label3.Margin = new System.Windows.Forms.Padding(0, 0, 48, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 32);
            this.label3.TabIndex = 8;
            this.label3.Text = "Địa điểm";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.guna2Panel2.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel2.BorderThickness = 1;
            this.guna2Panel2.Controls.Add(this.btnExit);
            this.guna2Panel2.Controls.Add(this.labelDetailReg);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(2);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Padding = new System.Windows.Forms.Padding(19, 20, 19, 20);
            this.guna2Panel2.Size = new System.Drawing.Size(1144, 68);
            this.guna2Panel2.TabIndex = 1;
            this.guna2Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel2_Paint);
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
            this.btnExit.Location = new System.Drawing.Point(1092, 4);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(46, 38);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "✕";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // labelDetailReg
            // 
            this.labelDetailReg.AutoSize = false;
            this.labelDetailReg.BackColor = System.Drawing.Color.Transparent;
            this.labelDetailReg.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDetailReg.ForeColor = System.Drawing.Color.White;
            this.labelDetailReg.Location = new System.Drawing.Point(431, 15);
            this.labelDetailReg.Margin = new System.Windows.Forms.Padding(4);
            this.labelDetailReg.Name = "labelDetailReg";
            this.labelDetailReg.Size = new System.Drawing.Size(236, 45);
            this.labelDetailReg.TabIndex = 1;
            this.labelDetailReg.Text = "Danh sách lịch thi";
            // 
            // ViewExamSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1144, 640);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.guna2Panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ViewExamSchedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewExamSchedule";
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel4.ResumeLayout(false);
            this.guna2Panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExamScheduleList)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelInforHeader;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateFilter;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private Guna.UI2.WinForms.Guna2ComboBox cbxTypeCer;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelDetailReg;
        private Guna.UI2.WinForms.Guna2Button btnExit;
        private Guna.UI2.WinForms.Guna2DataGridView ExamScheduleList;
        private System.Windows.Forms.DataGridViewTextBoxColumn stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn birth;
        private System.Windows.Forms.DataGridViewTextBoxColumn cccd;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
    }
}