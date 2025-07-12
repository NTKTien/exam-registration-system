using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace exam_registration_system.MainForms.NVKT
{
    public partial class viewListExtensionRequest : Form
    {
        private DataTable dt;
        private DataTable originalDt;

        public viewListExtensionRequest()
        {
            InitializeComponent();
            btncreate.Enabled = false;
        }

        private void viewListExtensionRequest_Load(object sender, EventArgs e)
        {
            try
            {
                originalDt = Business.ExtensionFormService.GetPendingExtensionForms();

                if (originalDt == null || originalDt.Rows.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                dt = originalDt.Copy();

                dataGridView1.Columns.Clear();
                foreach (DataColumn col in dt.Columns)
                {
                    dataGridView1.Columns.Add(new DataGridViewTextBoxColumn
                    {
                        Name = col.ColumnName,
                        HeaderText = col.ColumnName,
                        DataPropertyName = col.ColumnName,
                        ReadOnly = true
                    });
                }
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dataGridView1.DataSource = dt;

                if (dataGridView1.Columns["ThoiGian"] != null)
                {
                    dataGridView1.Columns["ThoiGian"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
                }

                PopulateLocationComboBox();
                PopulateSubjectComboBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PopulateLocationComboBox()
        {
            comboboxdiadiem.Items.Clear();
            comboboxdiadiem.Items.Add("All");

            var locations = originalDt.AsEnumerable()
                .Select(row => row.Field<string>("DiaDiem")?.Trim())
                .Where(location => !string.IsNullOrWhiteSpace(location))
                .Distinct()
                .OrderBy(location => location)
                .ToList();

            comboboxdiadiem.Items.AddRange(locations.ToArray());
            comboboxdiadiem.SelectedIndex = 0;
        }

        private void PopulateSubjectComboBox()
        {
            cbxMonthi.Items.Clear();

            // Thêm lựa chọn "All" đầu tiên
            cbxMonthi.Items.Add("All");

            // Chỉ thêm đúng 2 loại đặc biệt và không đặc biệt
            cbxMonthi.Items.Add("Đặc biệt");
            cbxMonthi.Items.Add("Không đặc biệt");

            cbxMonthi.SelectedIndex = 0;
        }


        private void btnfilter_Click(object sender, EventArgs e)
        {
            try
            {
                string selectedLocation = comboboxdiadiem.SelectedItem?.ToString()?.Trim() ?? "All";
                string selectedType = cbxMonthi.SelectedItem?.ToString()?.Trim() ?? "All";
                DateTime? selectedDate = chkFilterDate.Checked ? guna2DateTimePicker1.Value.Date : (DateTime?)null;

                if (selectedLocation.Equals("All", StringComparison.OrdinalIgnoreCase)
                    && selectedType.Equals("All", StringComparison.OrdinalIgnoreCase)
                    && !selectedDate.HasValue)
                {
                    dt = originalDt.Copy();
                    RefreshDataGridView(dt);
                    return;
                }

                var filteredRows = originalDt.AsEnumerable();

                if (!selectedLocation.Equals("All", StringComparison.OrdinalIgnoreCase))
                {
                    filteredRows = filteredRows.Where(row =>
                    {
                        string diaDiem = (row.Field<string>("DiaDiem") ?? "").Trim();
                        return diaDiem.Equals(selectedLocation, StringComparison.OrdinalIgnoreCase);
                    });
                }

                if (!selectedType.Equals("All", StringComparison.OrdinalIgnoreCase))
                {
                    filteredRows = filteredRows.Where(row =>
                    {
                        string loaiGH = (row.Field<string>("LoaiGH") ?? "").Trim();
                        return loaiGH.Equals(selectedType, StringComparison.OrdinalIgnoreCase);
                    });
                }

                if (selectedDate.HasValue)
                {
                    filteredRows = filteredRows.Where(row =>
                    {
                        DateTime thoiGian = row.Field<DateTime>("ThoiGian");
                        return thoiGian.Date == selectedDate.Value;
                    });
                }

                DataTable filteredDt;
                if (filteredRows.Any())
                {
                    filteredDt = filteredRows.CopyToDataTable();
                }
                else
                {
                    filteredDt = originalDt.Clone();
                }

                dt = filteredDt;
                RefreshDataGridView(dt);

                if (filteredDt.Rows.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu phù hợp với bộ lọc.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lọc dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RefreshDataGridView(DataTable dataTable)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dataTable;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            if (dataGridView1.Columns["ThoiGian"] != null)
            {
                dataGridView1.Columns["ThoiGian"].DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
            }

            btncreate.Enabled = dataTable.Rows.Count > 0 && dataGridView1.SelectedRows.Count > 0;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            try
            {
                comboboxdiadiem.SelectedIndex = 0;
                cbxMonthi.SelectedIndex = 0;
                guna2DateTimePicker1.Checked = false;

                dt = originalDt.Copy();
                dataGridView1.DataSource = dt;

                btncreate.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi reset filter: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                btncreate.Enabled = true;
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            btncreate.Enabled = dataGridView1.SelectedRows.Count > 0;
        }

        private void BtnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    string maPGH = dataGridView1.SelectedRows[0].Cells["MaPGH"].Value?.ToString();
                    if (!string.IsNullOrEmpty(maPGH))
                    {
                        CreateExtensionForm frm = new CreateExtensionForm(maPGH);
                        frm.Owner = this;
                        frm.StartPosition = FormStartPosition.CenterParent;
                        frm.ShowDialog();

                        viewListExtensionRequest_Load(null, null);
                    }
                    else
                    {
                        MessageBox.Show("Mã phiếu gia hạn trống.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một dòng dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi mở form tạo phiếu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
