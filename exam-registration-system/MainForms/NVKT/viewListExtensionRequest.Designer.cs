using System;

namespace exam_registration_system.MainForms.NVKT
{
    partial class viewListExtensionRequest
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

        private void InitializeComponent()
        {
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.btncreate = new Guna.UI2.WinForms.Guna2Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelInforHeader = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnfilter = new Guna.UI2.WinForms.Guna2Button();
            this.comboboxdiadiem = new Guna.UI2.WinForms.Guna2ComboBox();
            this.cbxMonthi = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2DateTimePicker1 = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.chkFilterDate = new System.Windows.Forms.CheckBox();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.labelDetailReg = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel3.BorderColor = System.Drawing.Color.Silver;
            this.guna2Panel3.BorderRadius = 10;
            this.guna2Panel3.BorderThickness = 1;
            this.guna2Panel3.Controls.Add(this.btncreate);
            this.guna2Panel3.Controls.Add(this.dataGridView1);
            this.guna2Panel3.Controls.Add(this.labelInforHeader);
            this.guna2Panel3.Controls.Add(this.guna2Panel1);
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel3.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Panel3.Location = new System.Drawing.Point(0, 79);
            this.guna2Panel3.Margin = new System.Windows.Forms.Padding(4);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.ShadowDecoration.BorderRadius = 15;
            this.guna2Panel3.ShadowDecoration.Depth = 10;
            this.guna2Panel3.ShadowDecoration.Enabled = true;
            this.guna2Panel3.Size = new System.Drawing.Size(1100, 746);
            this.guna2Panel3.TabIndex = 7;
            // 
            // btncreate
            // 
            this.btncreate.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btncreate.BorderRadius = 8;
            this.btncreate.BorderThickness = 1;
            this.btncreate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btncreate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btncreate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btncreate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btncreate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btncreate.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btncreate.ForeColor = System.Drawing.Color.White;
            this.btncreate.Location = new System.Drawing.Point(944, 624);
            this.btncreate.Margin = new System.Windows.Forms.Padding(2);
            this.btncreate.Name = "btncreate";
            this.btncreate.Size = new System.Drawing.Size(138, 39);
            this.btncreate.TabIndex = 24;
            this.btncreate.Text = "Tạo phiếu";
            this.btncreate.Click += new System.EventHandler(this.BtnCreate_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 177);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1069, 426);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.DataGridView1_SelectionChanged);
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            // 
            // labelInforHeader
            // 
            this.labelInforHeader.AutoSize = false;
            this.labelInforHeader.BackColor = System.Drawing.Color.Transparent;
            this.labelInforHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInforHeader.Location = new System.Drawing.Point(13, 136);
            this.labelInforHeader.Margin = new System.Windows.Forms.Padding(4);
            this.labelInforHeader.Name = "labelInforHeader";
            this.labelInforHeader.Size = new System.Drawing.Size(664, 34);
            this.labelInforHeader.TabIndex = 2;
            this.labelInforHeader.Text = "Danh sách yêu cầu gia hạn";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderColor = System.Drawing.Color.Silver;
            this.guna2Panel1.BorderRadius = 28;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.btnfilter);
            this.guna2Panel1.Controls.Add(this.comboboxdiadiem);
            this.guna2Panel1.Controls.Add(this.cbxMonthi);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.guna2DateTimePicker1);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.chkFilterDate);
            this.guna2Panel1.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2Panel1.Location = new System.Drawing.Point(13, 9);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(29, 30, 29, 30);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Padding = new System.Windows.Forms.Padding(29, 30, 29, 30);
            this.guna2Panel1.ShadowDecoration.BorderRadius = 15;
            this.guna2Panel1.ShadowDecoration.Depth = 10;
            this.guna2Panel1.ShadowDecoration.Enabled = true;
            this.guna2Panel1.Size = new System.Drawing.Size(1069, 99);
            this.guna2Panel1.TabIndex = 7;
            // 
            // btnfilter
            // 
            this.btnfilter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnfilter.BorderRadius = 8;
            this.btnfilter.BorderThickness = 1;
            this.btnfilter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnfilter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnfilter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnfilter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnfilter.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            this.btnfilter.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnfilter.ForeColor = System.Drawing.Color.White;
            this.btnfilter.Location = new System.Drawing.Point(907, 48);
            this.btnfilter.Margin = new System.Windows.Forms.Padding(2);
            this.btnfilter.Name = "btnfilter";
            this.btnfilter.Size = new System.Drawing.Size(118, 39);
            this.btnfilter.TabIndex = 23;
            this.btnfilter.Text = "Lọc";
            this.btnfilter.Click += new System.EventHandler(this.btnfilter_Click);
            // 
            // comboboxdiadiem
            // 
            this.comboboxdiadiem.BackColor = System.Drawing.Color.Transparent;
            this.comboboxdiadiem.BorderRadius = 8;
            this.comboboxdiadiem.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboboxdiadiem.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboboxdiadiem.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboboxdiadiem.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.comboboxdiadiem.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.comboboxdiadiem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.comboboxdiadiem.ItemHeight = 30;
            this.comboboxdiadiem.Items.AddRange(new object[] {
            "Ngoại ngữ",
            "Tin học"});
            this.comboboxdiadiem.Location = new System.Drawing.Point(677, 48);
            this.comboboxdiadiem.Margin = new System.Windows.Forms.Padding(4);
            this.comboboxdiadiem.Name = "comboboxdiadiem";
            this.comboboxdiadiem.Size = new System.Drawing.Size(195, 36);
            this.comboboxdiadiem.TabIndex = 22;
           // this.comboboxdiadiem.SelectedIndexChanged += new System.EventHandler(this.comboboxdiadiem_SelectedIndexChanged);
            // 
            // cbxMonthi
            // 
            this.cbxMonthi.BackColor = System.Drawing.Color.Transparent;
            this.cbxMonthi.BorderRadius = 8;
            this.cbxMonthi.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbxMonthi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMonthi.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxMonthi.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbxMonthi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbxMonthi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbxMonthi.ItemHeight = 30;
            this.cbxMonthi.Items.AddRange(new object[] {
            "Ngoại ngữ",
            "Tin học"});
            this.cbxMonthi.Location = new System.Drawing.Point(378, 48);
            this.cbxMonthi.Margin = new System.Windows.Forms.Padding(4);
            this.cbxMonthi.Name = "cbxMonthi";
            this.cbxMonthi.Size = new System.Drawing.Size(170, 36);
            this.cbxMonthi.TabIndex = 21;
          //  this.cbxMonthi.SelectedIndexChanged += new System.EventHandler(this.cbxMonthi_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label3.Location = new System.Drawing.Point(600, 10);
            this.label3.Margin = new System.Windows.Forms.Padding(0, 0, 51, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 30);
            this.label3.TabIndex = 20;
            this.label3.Text = "Địa điểm";
            // 
            // guna2DateTimePicker1
            // 
            this.guna2DateTimePicker1.Animated = true;
            this.guna2DateTimePicker1.AutoRoundedCorners = true;
            this.guna2DateTimePicker1.Checked = true;
            this.guna2DateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.guna2DateTimePicker1.Location = new System.Drawing.Point(32, 48);
            this.guna2DateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2DateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.guna2DateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.guna2DateTimePicker1.Name = "guna2DateTimePicker1";
            this.guna2DateTimePicker1.Size = new System.Drawing.Size(219, 36);
            this.guna2DateTimePicker1.TabIndex = 16;
            this.guna2DateTimePicker1.Value = new System.DateTime(2025, 6, 27, 14, 26, 39, 971);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.label2.Location = new System.Drawing.Point(312, 13);
            this.label2.Margin = new System.Windows.Forms.Padding(0, 0, 51, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 30);
            this.label2.TabIndex = 18;
            this.label2.Text = "LoạiGH";
          //  this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // chkFilterDate
            // 
            this.chkFilterDate.AutoSize = true;
            this.chkFilterDate.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.chkFilterDate.Location = new System.Drawing.Point(11, 9);
            this.chkFilterDate.Name = "chkFilterDate";
            this.chkFilterDate.Size = new System.Drawing.Size(171, 34);
            this.chkFilterDate.TabIndex = 30;
            this.chkFilterDate.Text = "Lọc theo ngày";
            this.chkFilterDate.UseVisualStyleBackColor = true;
            this.chkFilterDate.CheckedChanged += new System.EventHandler(this.chkFilterDate_CheckedChanged);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.White;
            this.guna2Panel2.Controls.Add(this.labelDetailReg);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Padding = new System.Windows.Forms.Padding(20);
            this.guna2Panel2.Size = new System.Drawing.Size(1100, 79);
            this.guna2Panel2.TabIndex = 6;
            // 
            // labelDetailReg
            // 
            this.labelDetailReg.AutoSize = false;
            this.labelDetailReg.BackColor = System.Drawing.Color.Transparent;
            this.labelDetailReg.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDetailReg.Location = new System.Drawing.Point(0, 0);
            this.labelDetailReg.Margin = new System.Windows.Forms.Padding(4);
            this.labelDetailReg.Name = "labelDetailReg";
            this.labelDetailReg.Size = new System.Drawing.Size(1100, 77);
            this.labelDetailReg.TabIndex = 1;
            this.labelDetailReg.Text = "Yêu cầu gia hạn";
            this.labelDetailReg.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
           // this.labelDetailReg.Click += new System.EventHandler(this.labelDetailReg_Click);
            // 
            // viewListExtensionRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1100, 825);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.guna2Panel2);
            this.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "viewListExtensionRequest";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "viewListExtensionRequest";
            this.Load += new System.EventHandler(this.viewListExtensionRequest_Load);
            this.guna2Panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void btncreate_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
        private void chkFilterDate_CheckedChanged(object sender, EventArgs e)
        {
            guna2DateTimePicker1.Enabled = chkFilterDate.Checked;
        }

        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelInforHeader;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ComboBox comboboxdiadiem;
        private Guna.UI2.WinForms.Guna2ComboBox cbxMonthi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DateTimePicker guna2DateTimePicker1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel labelDetailReg;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Guna.UI2.WinForms.Guna2Button btncreate;
        private Guna.UI2.WinForms.Guna2Button btnfilter;
        private System.Windows.Forms.CheckBox chkFilterDate;

    }
}