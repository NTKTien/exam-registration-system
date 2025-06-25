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
            // Tạo sẵn 10 dòng dữ liệu giả lập
            for (int i = 1; i <= 100; i++)
            {
                dgvRegList.Rows.Add(
                    $"P{i:000}", // Mã phiếu: P001, P002,...
                    DateTime.Today.AddDays(-i).ToShortDateString(), // Ngày lập
                    i % 2 == 0 ? "Anh văn" : "Tin học", // Loại ĐGNL
                    DateTime.Today.AddDays(i).ToShortDateString(), // Ngày dự thi
                    $"Nguyễn Văn {Convert.ToChar(64 + i)}", // Tên khách hàng
                    i % 2 == 0 ? "Đơn vị" : "Cá nhân", // Loại KH
                    i % 3 == 0 ? "Đã thanh toán" : "Chưa thanh toán" // Trạng thái
                );
            }
        }
    }
}
