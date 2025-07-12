using exam_registration_system.Business;
using System;
using System.Data;
using System.Windows.Forms;

namespace exam_registration_system.CommonForms
{
    public partial class RegListForm : Form
    {
        // ===== Thuộc tính =====
        private DataTable RegList { get; set; } // Danh sách phiếu đăng ký gốc
        private string SelectedRegCode => dgvRegList.CurrentRow?.Cells["codeReg"]?.Value?.ToString();
        private string SelectedRegType => dgvRegList.CurrentRow?.Cells["TypeCustomer"]?.Value?.ToString(); // KHĐV, KHTD

        public RegListForm()
        {
            InitializeComponent();
        }

        // ===== Phương thức =====
        private void RegListForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            RegList = PhieuDangKyService.GetAllReg();
            dgvRegList.DataSource = RegList;
        }

        private void butDetailReg_Click(object sender, EventArgs e)
        {
            if (dgvRegList.CurrentRow == null)
            {
                MessageBox.Show("Vui lòng chọn một phiếu đăng ký để xem chi tiết!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(SelectedRegCode) || string.IsNullOrEmpty(SelectedRegType))
            {
                MessageBox.Show("Không thể lấy thông tin phiếu đăng ký!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            switch (SelectedRegType)
            {
                case "KHTD":
                    new RegDetailForm(SelectedRegCode).ShowDialog();
                    break;

                case "KHĐV":
                    new UnitRegDetailForm().ShowDialog(); // Nếu cần truyền Mã phiếu, hãy thêm constructor phù hợp
                    break;

                default:
                    MessageBox.Show("Loại phiếu không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
            }
        }

        private void butSearch_Click(object sender, EventArgs e)
        {
            string keyword = textSearch.Text.Trim().ToLower();

            if (string.IsNullOrEmpty(keyword))
            {
                dgvRegList.DataSource = RegList; // Trở lại danh sách gốc
                return;
            }

            DataTable filteredTable = FilterData(keyword);
            dgvRegList.DataSource = filteredTable;
        }

        private DataTable FilterData(string keyword)
        {
            if (RegList == null) return null;

            DataTable result = RegList.Clone();

            foreach (DataRow row in RegList.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    if (item.ToString().ToLower().Contains(keyword))
                    {
                        result.ImportRow(row);
                        break;
                    }
                }
            }

            return result;
        }
    }
}
