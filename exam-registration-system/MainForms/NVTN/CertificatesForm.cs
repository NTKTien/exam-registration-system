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

namespace exam_registration_system.MainForms.NVTN
{
    public partial class CertificatesForm : Form
    {
        

        public CertificatesForm()
        {
            InitializeComponent();
        }

        private void tbFullName_TextChanged(object sender, EventArgs e)
        {

        }

        private void butCreateReg_Click(object sender, EventArgs e)
        {
            string maPDK = tbFullName.Text.Trim(); // giả định bạn dùng guna2TextBox4 để nhập MaPDK

            if (string.IsNullOrEmpty(maPDK))
            {
                MessageBox.Show("Vui lòng nhập mã phiếu đăng ký!", "Thông báo");
                return;
            }

            string query = @"
                    SELECT 
                        ts.HoTen,
                        pd.LoaiPDK,
                        pd.LoaiCC,
                        bt.KetQua,
                        ld.NgayThi,
                        bt.TrangThai
                    FROM PhieuDangKy pd
                    JOIN ThiSinh ts ON ts.MaDS = pd.MaDS
                    JOIN PhieuDuThi pdt ON pdt.MaPDK = pd.MaPDK
                    JOIN BangTinh bt ON bt.MaPDT = pdt.MaPDT
                    JOIN LichDGNL ld ON ld.MaLT = pd.MaLT
                    WHERE pd.MaPDK = @MaPDK
                    ";

            SqlParameter[] parameters = { new SqlParameter("@MaPDK", maPDK) };
            DataTable result = SqlServerHelper.ExecuteQuery(query, parameters);

            if (result.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy thông tin phiếu đăng ký!", "Thông báo");
                return;
            }

            DataRow row = result.Rows[0];
            string loaiPDK = row["LoaiPDK"].ToString();

            if (loaiPDK == "KHĐV")
            {
                MessageBox.Show("Phiếu đăng ký này thuộc khách hàng ĐƠN VỊ. Vui lòng chuyển sang màn hình cấp chứng chỉ đơn vị!", "Thông báo");
                return;
            }

            // Nếu là KHTD thì hiển thị thông tin vào đúng các textbox bạn đang dùng
            guna2TextBox2.Text = row["HoTen"].ToString();                                 // Họ tên
            guna2TextBox1.Text = row["LoaiCC"].ToString();                                // Loại chứng chỉ
            guna2TextBox5.Text = row["KetQua"].ToString();                                // Kết quả
            guna2DateTimePicker1.Text = Convert.ToDateTime(row["NgayThi"]).ToString("dd/MM/yyyy"); // Ngày thi
            guna2TextBox3.Text = row["TrangThai"].ToString();
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

            string findBTQuery = @"
                SELECT bt.MaBT
                FROM ThiSinh ts
                JOIN PhieuDangKy pdk ON ts.MaDS = pdk.MaDS
                JOIN PhieuDuThi pdt ON pdk.MaPDK = pdt.MaPDK
                JOIN BangTinh bt ON bt.MaPDT = pdt.MaPDT
                WHERE ts.MaTS = @MaTS
            ";

            SqlParameter[] findParams = { new SqlParameter("@MaTS", maTS) };
            DataTable btResult = SqlServerHelper.ExecuteQuery(findBTQuery, findParams);

            if (btResult.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy bảng tính để cập nhật!", "Lỗi");
                return;
            }

            string maBT = btResult.Rows[0]["MaBT"].ToString();

            string updateQuery = @"
                    UPDATE BangTinh
                    SET TrangThai = N'Đã giao', ThoiGianGiaoCC = GETDATE()
                    WHERE MaBT = @MaBT
                ";

            SqlParameter[] updateParams = { new SqlParameter("@MaBT", maBT) };
            SqlServerHelper.ExecuteQuery(updateQuery, updateParams);

            MessageBox.Show("Cấp chứng chỉ thành công!", "Thành công");
            guna2TextBox3.Text = "Đã giao";
        }
        
    }
}