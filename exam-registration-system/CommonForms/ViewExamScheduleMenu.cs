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
    public partial class ViewExamScheduleMenu : UserControl
    {
        public ViewExamScheduleMenu()
        {
            InitializeComponent();
            LoadAvailableSchedules();
        }

        private void LoadAvailableSchedules()
        {
            DataTable dt = ExamScheduleService.GetAllAvailableSchedules();
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
    }
}
