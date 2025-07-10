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
    public partial class ViewExamSchedule : Form
    {
        private string loaiDGNL;
        public string SelectedMaLT { get; private set; }
        public string SelectedNgayThi { get; private set; }
        public string SelectedCaThi { get; private set; }
        public string SelectedPhongThi { get; private set; }
        public ViewExamSchedule(string loaiDGNL)
        {
            InitializeComponent();
            this.loaiDGNL = loaiDGNL;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadAvailableSchedules()
        {
            DataTable dt = ExamScheduleService.GetAllAvailableSchedulesByTypeCC(loaiDGNL);
            dgvExamSchedule.DataSource = dt;
        }

        private void butSearch_Click(object sender, EventArgs e)
        {
            string keyword = textSearch.Text.Trim().ToLower();

            // Nếu trống thì load lại danh sách gốc
            if (string.IsNullOrEmpty(keyword))
            {
                LoadAvailableSchedules();
                return;
            }

            // Lấy dữ liệu gốc từ DataSource (DataTable)
            DataTable dt = dgvExamSchedule.DataSource as DataTable;
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

            dgvExamSchedule.DataSource = filteredTable;
        }

        private void ViewExamSchedule_Load(object sender, EventArgs e)
        {
            LoadAvailableSchedules();
        }
        // Ví dụ đơn giản
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click_1(object sender, EventArgs e) { }
        private void labelInforHeader_Click(object sender, EventArgs e) { }
        private void guna2Panel2_Paint(object sender, PaintEventArgs e) { }
        private void guna2Button1_Click(object sender, EventArgs e) { }
 
        private void butSelect_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvExamSchedule.CurrentRow != null)
                {
                    SelectedMaLT = dgvExamSchedule.CurrentRow.Cells["code"].Value.ToString();
                    SelectedNgayThi = dgvExamSchedule.CurrentRow.Cells["Examdate"].Value.ToString();
                    SelectedCaThi = dgvExamSchedule.CurrentRow.Cells["Shift"].Value.ToString();
                    SelectedPhongThi = dgvExamSchedule.CurrentRow.Cells["Room"].Value.ToString();

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }

                else
                {
                    MessageBox.Show("Vui lòng chọn một lịch thi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
{
                MessageBox.Show("Lỗi cụ thể:\n" + ex.Message + "\n\n" + ex.StackTrace);
            }

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }
    }
    
}
