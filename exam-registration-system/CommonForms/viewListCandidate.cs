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
    public partial class viewListCandidate : Form
    {
        public viewListCandidate()
        {
            InitializeComponent();
            LoadFakeData(); 
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadFakeData()
        {
            DataTable dt = new DataTable();

            dt.Columns.Add("STT", typeof(int));
            dt.Columns.Add("Họ tên", typeof(string));
            dt.Columns.Add("Giới tính", typeof(string));
            dt.Columns.Add("Ngày sinh", typeof(DateTime));
            dt.Columns.Add("CCCD", typeof(string));
            dt.Columns.Add("Số điện thoại", typeof(string));
            dt.Columns.Add("Email", typeof(string)); // Cột mới

            for (int i = 1; i <= 20; i++)
            {
                dt.Rows.Add(
                    i,
                    $"Nguyễn Văn {i}",
                    i % 2 == 0 ? "Nam" : "Nữ",
                    new DateTime(2001, 1, 1).AddDays(i * 25),
                    $"1234567890{i:D2}",
                    $"09012345{i:D2}",
                    $"nguyenvan{i}@gmail.com"
                );
            }

            dgvCandidateList.DataSource = dt;
        }
    }
}
