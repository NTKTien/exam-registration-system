using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using exam_registration_system.Utils;


namespace exam_registration_system.MainForms.NVTN
{
    public partial class releaseCard : Form
    {
       
        public releaseCard()
        {
            InitializeComponent();
            SetupDataGridView();
            LoadData();

        }

        private void SetupDataGridView()
        {
            // Đảm bảo hiển thị tiêu đề cột
            DataGridViewRegList.ColumnHeadersVisible = true;
            DataGridViewRegList.EnableHeadersVisualStyles = true;
            DataGridViewRegList.RowHeadersVisible = false; // Ẩn tiêu đề hàng để giao diện gọn hơn

            // Đặt chiều cao tiêu đề cột
            DataGridViewRegList.ColumnHeadersHeight = 30; // Đặt chiều cao hợp lý (30px)
            DataGridViewRegList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing; // Ngăn người dùng thay đổi chiều cao

            // Tùy chỉnh kiểu dáng tiêu đề cột
            DataGridViewRegList.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            DataGridViewRegList.ColumnHeadersDefaultCellStyle.BackColor = Color.BlueViolet;
            DataGridViewRegList.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Tùy chỉnh kiểu dáng ô dữ liệu
            DataGridViewRegList.DefaultCellStyle.Font = new Font("Segoe UI", 9);
            DataGridViewRegList.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            DataGridViewRegList.DefaultCellStyle.WrapMode = DataGridViewTriState.False;

            // Bật lưới và thiết lập màu lưới
            DataGridViewRegList.GridColor = Color.Gray;
            DataGridViewRegList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // Tự động căn chỉnh cột (sẽ được gọi lại sau khi đổ dữ liệu)
            DataGridViewRegList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            // Đưa DataGridView lên trước để không bị che
            DataGridViewRegList.BringToFront();
        }

        private void AdjustDataGridViewSize()
        {
            // Đặt chế độ tự động căn chỉnh cột
            DataGridViewRegList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            // Tính tổng chiều rộng của tất cả các cột
            int totalWidth = DataGridViewRegList.Columns.GetColumnsWidth(DataGridViewElementStates.Visible);

            // Thêm chiều rộng của thanh cuộn dọc nếu có
            if (DataGridViewRegList.ScrollBars == System.Windows.Forms.ScrollBars.Vertical || DataGridViewRegList.ScrollBars == System.Windows.Forms.ScrollBars.Both)
            {
                totalWidth += SystemInformation.VerticalScrollBarWidth;
            }

            // Đặt chiều rộng DataGridView
            int maxWidth = this.ClientSize.Width - 20; // Giới hạn tối đa để tránh tràn form
            DataGridViewRegList.Width = Math.Min(totalWidth, maxWidth);

            // Tính chiều cao: chiều cao tiêu đề + chiều cao các hàng
            int rowHeight = DataGridViewRegList.RowTemplate.Height;
            int headerHeight = DataGridViewRegList.ColumnHeadersHeight;
            int totalHeight = headerHeight + (DataGridViewRegList.RowCount * rowHeight);

            // Đặt chiều cao DataGridView
            int maxHeight = this.ClientSize.Height - DataGridViewRegList.Top - 20; // Giới hạn tối đa
            DataGridViewRegList.Height = Math.Min(totalHeight, maxHeight);
        }

        private void SetColumnHeaders()
        {
            // Đặt tên hiển thị cho các cột
            if (DataGridViewRegList.Columns["MaPDK"] != null)
                DataGridViewRegList.Columns["MaPDK"].HeaderText = "Mã PĐK";
            if (DataGridViewRegList.Columns["HoTen"] != null)
                DataGridViewRegList.Columns["HoTen"].HeaderText = "Họ Tên";
            if (DataGridViewRegList.Columns["Email"] != null)
                DataGridViewRegList.Columns["Email"].HeaderText = "Email";
            if (DataGridViewRegList.Columns["LoaiPDK"] != null)
                DataGridViewRegList.Columns["LoaiPDK"].HeaderText = "Loại khách hàng";
            if (DataGridViewRegList.Columns["NgayThi"] != null)
                DataGridViewRegList.Columns["NgayThi"].HeaderText = "Ngày Thi";
            if (DataGridViewRegList.Columns["PhongThi"] != null)
                DataGridViewRegList.Columns["PhongThi"].HeaderText = "Phòng Thi";
            if (DataGridViewRegList.Columns["TrangThaiThanhToan"] != null)
                DataGridViewRegList.Columns["TrangThaiThanhToan"].HeaderText = "Thanh Toán";
            if (DataGridViewRegList.Columns["TrangThaiXuatPDT"] != null)
                DataGridViewRegList.Columns["TrangThaiXuatPDT"].HeaderText = "Xuất PDT";
        }

        public void LoadData()
        {
            try
            {

                using (SqlConnection conn = new SqlConnection(GlobalInfo.ConnectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("XemTatCaPhieuDangKy", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Create a DataTable to hold the results
                        DataTable dt = new DataTable();
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }

                        // Gán DataTable vào DataGridView
                        DataGridViewRegList.DataSource = dt;

                        // Đặt tên hiển thị cho các cột
                        SetColumnHeaders();

                        // Đảm bảo tiêu đề cột hiển thị
                        DataGridViewRegList.ColumnHeadersVisible = true;

                        // Điều chỉnh kích thước sau khi lọc dữ liệu
                        AdjustDataGridViewSize();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void DataGridViewCardList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem có click vào hàng hợp lệ không
            if (e.RowIndex >= 0)
            {
                // Lấy hàng được chọn
                DataGridViewRow row = DataGridViewRegList.Rows[e.RowIndex];

                // Lấy giá trị MaPDK và TrangThaiXuatPDT
                string maPDK = row.Cells["MaPDK"].Value?.ToString();
                string trangThaiXuatPDT = row.Cells["TrangThaiXuatPDT"].Value?.ToString();

                if (!string.IsNullOrEmpty(maPDK) && !string.IsNullOrEmpty(trangThaiXuatPDT))
                {
                    // Mở form viewDetailCard và truyền MaPDK, TrangThaiXuatPDT
                    viewDetailCard detailForm = new viewDetailCard(maPDK, trangThaiXuatPDT, this);
                    detailForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Không thể lấy thông tin Mã PĐK hoặc Trạng Thái Xuất PDT.", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void lbType_Click(object sender, EventArgs e)
        {

        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
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
            try
            {
                using (SqlConnection conn = new SqlConnection(GlobalInfo.ConnectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("LocPhieuDangKy", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;

                        // Add parameters (NULL if empty or not selected)
                        cmd.Parameters.AddWithValue("@MaPDK", string.IsNullOrWhiteSpace(tbID.Text) ? (object)DBNull.Value : (object)tbID.Text);
                        cmd.Parameters.AddWithValue("@LoaiKyThi", cbxTypeCer.SelectedItem == null ? (object)DBNull.Value : (object)cbxTypeCer.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@TrangThaiXuatPDT", cbbStatus.SelectedItem == null ? (object)DBNull.Value : (object)cbbStatus.SelectedItem.ToString());
                        // Create a DataTable to hold the results
                        DataTable dt = new DataTable();
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }

                        // Kiểm tra nếu không có dữ liệu
                        if (dt.Rows.Count == 0)
                        {
                            MessageBox.Show("KHÔNG CÓ DỮ LIỆU NÀO THOẢ MÃN", "Thông báo",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            DataGridViewRegList.DataSource = null; // Xóa dữ liệu cũ trong DataGridView
                            return;
                        }

                        // Gán DataTable vào DataGridView
                        DataGridViewRegList.DataSource = dt;

                        // Đặt tên hiển thị cho các cột
                        SetColumnHeaders();

                        // Đảm bảo tiêu đề cột hiển thị
                        DataGridViewRegList.ColumnHeadersVisible = true;

                        // Điều chỉnh kích thước sau khi lọc dữ liệu
                        AdjustDataGridViewSize();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error filtering data: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void labelHeader_Click(object sender, EventArgs e)
        {

        }

        private void releaseCard_Load(object sender, EventArgs e)
        {

        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
