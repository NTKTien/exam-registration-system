using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using exam_registration_system.Utils;


namespace exam_registration_system.MainForms.NVTN
{
    public partial class releaseCard : Form
    {
       
        public releaseCard()
        {
            InitializeComponent();
            InitializeControls();
            LoadAllPhieuDangKy();
        }

        private void InitializeControls()
        {
            // Thiết lập ComboBox cho LoaiPDK
            cbxTypeCer.Items.Clear();
            cbxTypeCer.Items.AddRange(new object[] { "KHĐV", "KHTD" });
            cbxTypeCer.SelectedIndex = 0; // Mặc định chọn rỗng

            // Thiết lập ComboBox cho TrangThaiXuatPDT
            cbbStatus.Items.Clear();
            cbbStatus.Items.AddRange(new object[] { "Đã xuất PDT", "Chưa xuất PDT" });
            cbbStatus.SelectedIndex = 0; // Mặc định chọn rỗng
        }

        private void LoadAllPhieuDangKy()
        {
            try
            {
                // Gọi stored procedure XemTatCaPhieuDangKy
                DataTable dataTable = SqlServerHelper.ExecuteQuery("XemTatCaPhieuDangKy");

                DataGridViewRegList.DataSource = dataTable;

                // Tùy chỉnh tiêu đề cột
                DataGridViewRegList.Columns["MaPDK"].HeaderText = "Mã Phiếu ĐK";
                DataGridViewRegList.Columns["HoTen"].HeaderText = "Họ Tên";
                DataGridViewRegList.Columns["Email"].HeaderText = "Email";
                DataGridViewRegList.Columns["LoaiPDK"].HeaderText = "Loại Phiếu ĐK";
                DataGridViewRegList.Columns["NgayThi"].HeaderText = "Ngày Thi";
                DataGridViewRegList.Columns["PhongThi"].HeaderText = "Phòng Thi";
                DataGridViewRegList.Columns["TrangThaiThanhToan"].HeaderText = "Trạng Thái Thanh Toán";
                DataGridViewRegList.Columns["TrangThaiXuatPDT"].HeaderText = "Trạng Thái Xuất PDT";

                // Kiểm tra nếu không có dữ liệu
                if (dataTable.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy phiếu đăng ký nào.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách phiếu đăng ký: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FilterPhieuDangKy()
        {
            try
            {
                // Tạo danh sách tham số cho stored procedure LocPhieuDangKy
                var parameters = new List<SqlParameter>
                {
                    new SqlParameter("@MaPDK", string.IsNullOrEmpty(tbID.Text) ? (object)DBNull.Value : tbID.Text.Trim()),
                    new SqlParameter("@LoaiPDK", string.IsNullOrEmpty(cbxTypeCer.SelectedItem?.ToString()) ? (object)DBNull.Value : cbxTypeCer.SelectedItem.ToString()),
                    new SqlParameter("@TrangThaiXuatPDT", string.IsNullOrEmpty(cbbStatus.SelectedItem?.ToString()) ? (object)DBNull.Value : cbbStatus.SelectedItem.ToString())
                };

                // Gọi stored procedure LocPhieuDangKy
                DataTable dataTable = SqlServerHelper.ExecuteQuery("LocPhieuDangKy", parameters.ToArray());

                DataGridViewRegList.DataSource = dataTable;

                // Tùy chỉnh tiêu đề cột
                DataGridViewRegList.Columns["MaPDK"].HeaderText = "Mã Phiếu ĐK";
                DataGridViewRegList.Columns["HoTen"].HeaderText = "Họ Tên";
                DataGridViewRegList.Columns["Email"].HeaderText = "Email";
                DataGridViewRegList.Columns["LoaiPDK"].HeaderText = "Loại Phiếu ĐK";
                DataGridViewRegList.Columns["NgayThi"].HeaderText = "Ngày Thi";
                DataGridViewRegList.Columns["PhongThi"].HeaderText = "Phòng Thi";
                DataGridViewRegList.Columns["TrangThaiThanhToan"].HeaderText = "Trạng Thái Thanh Toán";
                DataGridViewRegList.Columns["TrangThaiXuatPDT"].HeaderText = "Trạng Thái Xuất PDT";

                // Kiểm tra nếu không có dữ liệu
                if (dataTable.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy phiếu đăng ký nào phù hợp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lọc danh sách phiếu đăng ký: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DataGridViewCardList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lbType_Click(object sender, EventArgs e)
        {

        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DataGridViewRegList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            
        }

        private void tbID_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void cbxTypeCer_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            FilterPhieuDangKy();
        }
    }
}
