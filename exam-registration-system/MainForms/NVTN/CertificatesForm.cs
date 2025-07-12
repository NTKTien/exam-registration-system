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
using Guna.UI2.WinForms;
using exam_registration_system.Business;
using System;
using System.Windows.Forms;

namespace exam_registration_system.MainForms.NVTN
{
    public partial class CertificatesForm : Form
    {
        public CertificatesForm()
        {
            InitializeComponent();
        }

        private void butCreateReg_Click(object sender, EventArgs e)
        {
            string maPDK = tbFullName.Text.Trim();

            if (string.IsNullOrEmpty(maPDK))
            {
                MessageBox.Show("Vui lòng nhập mã phiếu đăng ký!", "Thông báo");
                return;
            }

            var data = CertificatesFormService.GetCertificateInfoByMaPDK(maPDK);

            if (data == null)
            {
                MessageBox.Show("Không tìm thấy thông tin phiếu đăng ký!", "Thông báo");
                return;
            }

            if (data.LoaiPDK == "KHĐV")
            {
                MessageBox.Show("Phiếu đăng ký này thuộc khách hàng ĐƠN VỊ.", "Thông báo");
                return;
            }

            guna2TextBox2.Text = data.HoTen;
            guna2TextBox1.Text = data.LoaiCC;
            guna2TextBox5.Text = data.KetQua;
            guna2DateTimePicker1.Text = data.NgayThi.ToString("dd/MM/yyyy");
            guna2TextBox3.Text = data.TrangThai;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            string ketQua = guna2TextBox5.Text.Trim();
            string trangThai = guna2TextBox3.Text.Trim();
            string maTS = tbFullName.Text.Trim();

            if (string.IsNullOrEmpty(maTS))
            {
                MessageBox.Show("Vui lòng nhập mã thí sinh và tra cứu trước!", "Cảnh báo");
                return;
            }

            if (ketQua != "Đạt")
            {
                MessageBox.Show("Bạn chưa đủ điều kiện để nhận chứng chỉ.", "Thông báo");
                return;
            }

            if (trangThai == "Đã giao")
            {
                MessageBox.Show("Thí sinh đã nhận chứng chỉ rồi.", "Thông báo");
                return;
            }

            bool result = CertificatesFormService.ConfirmCertificateDelivery(maTS);
            if (result)
            {
                MessageBox.Show("Cấp chứng chỉ thành công!", "Thành công");
                guna2TextBox3.Text = "Đã giao";
            }
            else
            {
                MessageBox.Show("Không tìm thấy bảng tính để cập nhật!", "Lỗi");
            }
        }
    }
}
