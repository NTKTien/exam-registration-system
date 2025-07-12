using exam_registration_system.Business;
using exam_registration_system.CommonForms;
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
using System.Text.RegularExpressions;


namespace exam_registration_system.MainForms.NVTN
{
    public partial class releaseCard : Form
    {
       
        public releaseCard()
        {
            InitializeComponent();
            InitializeComboBoxes();
            SetupDataGridView();
            LoadData();

        }

        private void InitializeComboBoxes()
        {
            // Thêm các giá trị cho cbxTypeCer (LoaiCC)
            cbxTypeCer.Items.Clear();
            cbxTypeCer.Items.AddRange(new string[] { "Tin học", "Ngoại ngữ" }); // Thay bằng danh sách thực tế từ cơ sở dữ liệu
            cbxTypeCer.SelectedIndex = -1; // Không chọn mặc định

            // Thêm các giá trị cho cbbStatus (TrangThai)
            cbbStatus.Items.Clear();
            cbbStatus.Items.AddRange(new string[] { "Chưa thanh toán", "Đã hủy", "Đã thanh toán", "Đã xuất PDT" }); // Thay bằng danh sách thực tế
            cbbStatus.SelectedIndex = -1; // Không chọn mặc định
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
            if (DataGridViewRegList.Columns["MaTS"] != null)
                DataGridViewRegList.Columns["MaTS"].HeaderText = "Mã TS";
            if (DataGridViewRegList.Columns["TenHienThi"] != null)
                DataGridViewRegList.Columns["TenHienThi"].HeaderText = "Tên";
            if (DataGridViewRegList.Columns["Email"] != null)
                DataGridViewRegList.Columns["Email"].HeaderText = "Email";
            if (DataGridViewRegList.Columns["LoaiPDK"] != null)
                DataGridViewRegList.Columns["LoaiPDK"].HeaderText = "Loại khách hàng";
            if (DataGridViewRegList.Columns["NgayThi"] != null)
                DataGridViewRegList.Columns["NgayThi"].HeaderText = "Ngày Thi";
            if (DataGridViewRegList.Columns["PhongThi"] != null)
                DataGridViewRegList.Columns["PhongThi"].HeaderText = "Phòng Thi";
            if (DataGridViewRegList.Columns["TrangThai"] != null)
                DataGridViewRegList.Columns["TrangThai"].HeaderText = "Trạng thái";
          

        }

        public void LoadData()
        {
            try
            {
                DataTable dt = PhieuDangKyService.XemPDKDeXuatPhieu();
                DataGridViewRegList.DataSource = dt;

                SetColumnHeaders();
                DataGridViewRegList.ColumnHeadersVisible = true;
                AdjustDataGridViewSize();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading data: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void DataGridViewCardList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = DataGridViewRegList.Rows[e.RowIndex];
                string maPDK = row.Cells["MaPDK"].Value?.ToString();
                string maTS = row.Cells["MaTS"].Value?.ToString();
                string trangThai = row.Cells["TrangThai"].Value?.ToString();
                

                if (!string.IsNullOrEmpty(maPDK) && !string.IsNullOrEmpty(trangThai))
                {
                    if( !string.IsNullOrEmpty(maTS))
                    {
                        viewDetailCard detailForm = new viewDetailCard(maPDK, trangThai, maTS);
                        detailForm.ShowDialog();
                    }    
                    
                }
                else
                {
                    MessageBox.Show("Không thể lấy thông tin Mã PĐK hoặc Trạng Thái Xuất PDT.", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            LoadData();
        }

        private void lbType_Click(object sender, EventArgs e)
        {

        }

        private void panelHeader_Paint(object sender, PaintEventArgs e)
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
            string maPDK = tbID.Text.Trim();

            if (maPDK.Length > 5)
            {
                MessageBox.Show("Mã phiếu đăng ký không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbID.Clear();
                return;
            }

            try
            {

                DataTable dt = PhieuDangKyService.FilterRegistrations(
                   tbID.Text.Trim(),
                   cbxTypeCer.SelectedItem?.ToString(),
                   cbbStatus.SelectedItem?.ToString()

                );
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("KHÔNG CÓ DỮ LIỆU NÀO THOẢ MÃN", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataGridViewRegList.DataSource = null;
                    return;
                }

                DataGridViewRegList.DataSource = dt;
                SetColumnHeaders();
                DataGridViewRegList.ColumnHeadersVisible = true;
                AdjustDataGridViewSize();

                cbxTypeCer.SelectedIndex = -1;
                cbbStatus.SelectedIndex = -1;
                tbID.Clear();


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
            LoadData();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
