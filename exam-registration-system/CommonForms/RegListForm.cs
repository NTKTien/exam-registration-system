using exam_registration_system.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exam_registration_system.CommonForms
{
    public partial class RegListForm : Form
    {
        public RegListForm()
        {
            InitializeComponent();
        }

        private void RegListForm_Load(object sender, EventArgs e)
        {
            LoadRegList();
        }

        private void LoadRegList()
        {
            DataTable dt = PhieuDangKyService.GetAllReg();
            dgvRegList.DataSource = dt;
        }

        private void butDetailReg_Click(object sender, EventArgs e)
        {
            // Kiểm tra có dòng nào được chọn chưa
            if (dgvRegList.CurrentRow != null)
            {
                // Lấy mã phiếu và loại PDK từ dòng được chọn
                string registrationId = dgvRegList.CurrentRow.Cells["codeReg"].Value.ToString();
                string loaiPDK = dgvRegList.CurrentRow.Cells["TypeCustomer"].Value.ToString(); // giả sử tên cột là "typeReg"

                // Kiểm tra loại phiếu để hiển thị form phù hợp
                if (loaiPDK == "KHTD")
                {
                    RegDetailForm formChiTiet = new RegDetailForm(registrationId);
                    formChiTiet.ShowDialog();
                }
                else if (loaiPDK == "KHĐV")
                {
                    UnitRegDetailForm formChiTiet = new UnitRegDetailForm();
                    formChiTiet.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Loại phiếu không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một phiếu đăng ký để xem chi tiết!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void butSearch_Click(object sender, EventArgs e)
        {
            string keyword = textSearch.Text.Trim().ToLower();

            // Nếu trống thì load lại danh sách gốc
            if (string.IsNullOrEmpty(keyword))
            {
                LoadRegList();
                return;
            }

            // Lấy dữ liệu gốc từ DataSource (DataTable)
            DataTable dt = dgvRegList.DataSource as DataTable;
            if (dt == null) return;

            // Clone cấu trúc bảng để tạo bảng kết quả
            DataTable filteredTable = dt.Clone();

            foreach (DataRow row in dt.Rows)
            {
                // Kiểm tra tất cả các ô trong hàng
                foreach (var item in row.ItemArray)
                {
                    if (item.ToString().ToLower().Contains(keyword))
                    {
                        filteredTable.ImportRow(row);
                        break; // Chỉ cần một ô khớp là đủ
                    }
                }
            }

            dgvRegList.DataSource = filteredTable;
        }
    }
}
