using exam_registration_system.Business;
using exam_registration_system.CommonForms;
using exam_registration_system.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exam_registration_system.MainForms.NVTN
{
    public partial class createdRegForm : Form
    {
        private string selectedMaLT = null;
        public createdRegForm()
        {
            InitializeComponent();
        }

        private void butSelectCalenderEx_Click(object sender, EventArgs e)
        {
            if (cmbTypeDGNL.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn loại ĐGNL trước!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string loaiDGNL = cmbTypeDGNL.SelectedItem.ToString();
            ViewExamSchedule form = new ViewExamSchedule(loaiDGNL);
            if (form.ShowDialog() == DialogResult.OK)
            {
                string ngayThiStr = form.SelectedNgayThi.ToString();
                string caThi = form.SelectedCaThi;
                string phongThi = form.SelectedPhongThi;
                selectedMaLT = form.SelectedMaLT;

                // Gán vào TextBox theo format mong muốn
                tbCalenderEx.Text = $"{ngayThiStr} - Ca {caThi} - {phongThi}";
            }
        }

        private void butCreateReg_Click(object sender, EventArgs e)
        {
            string hoTen = tbFullName.Text;
            string gioiTinh = radioButMale.Checked ? "Nam" : "Nữ";
            DateTime ngaySinh = dtpNgaySinh.Value;
            string cccd = tbCCCD.Text;
            string sdt = tbSDT.Text;
            string email = tbEmail.Text;
            string diaChi = tbAddress.Text;

            string maPDK = tbRegCode.Text;
            DateTime ngayDangKy = dtpNgayDangKy.Value;
            string loaiDGNL = cmbTypeDGNL.SelectedItem.ToString();
            string maLichThi = selectedMaLT;

            // Validate trước khi tạo
            if (string.IsNullOrWhiteSpace(hoTen) ||
                string.IsNullOrWhiteSpace(gioiTinh) ||
                string.IsNullOrWhiteSpace(cccd) ||
                string.IsNullOrWhiteSpace(sdt) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(diaChi) ||
                string.IsNullOrWhiteSpace(maPDK) ||
                string.IsNullOrWhiteSpace(loaiDGNL) ||
                string.IsNullOrWhiteSpace(maLichThi) ||
                ngaySinh >= DateTime.Today)
            {
                MessageBox.Show("Vui lòng điền đầy đủ tất cả thông tin bắt buộc!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Thêm phiếu đăng ký
            bool isRegOk = isRegOk = PhieuDangKyService.InsertFreeReg(maPDK, ngayDangKy, loaiDGNL, "KHTD", maLichThi);

            // Thêm khách hàng
            bool isCustomerOk = CustomerService.InsertCustomer(hoTen, gioiTinh, ngaySinh, cccd, sdt, email, diaChi, maPDK);

            // Thêm hóa đơn với mã nhân viên hardcode
            bool isInvoiceOk = InvoiceService.InsertInvoice(maPDK, GlobalInfo.CurrentUsername);

            if (isCustomerOk && isRegOk && isInvoiceOk)
            {
                MessageBox.Show("Tạo phiếu đăng ký thành công!", "Thành công");


                // Xóa toàn bộ dữ liệu người dùng đã nhập
                tbFullName.Clear();
                radioButMale.Checked = true; // hoặc false, tùy mặc định
                dtpNgaySinh.Value = DateTime.Today;
                tbCCCD.Clear();
                tbSDT.Clear();
                tbEmail.Clear();
                tbAddress.Clear();
                tbCalenderEx.Clear();

                tbRegCode.Text = PhieuDangKyService.GetNextMaPhieuDK();
                dtpNgayDangKy.Value = DateTime.Today;
                cmbTypeDGNL.SelectedIndex = -1;

                tbCalenderEx.Clear();
                selectedMaLT = null;
            }
            else
            {
                MessageBox.Show("Tạo phiếu thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void createdRegForm_Load(object sender, EventArgs e)
        {
            tbRegCode.Text = PhieuDangKyService.GetNextMaPhieuDK();
        }

        private void tbSDT_Leave(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(tbSDT.Text.Trim(), @"^\d{10}$"))
            {
                MessageBox.Show("Số điện thoại phải gồm đúng 10 chữ số!", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbSDT.Focus(); // đưa con trỏ về lại ô này
            }
        }

        private void tbCCCD_Leave(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(tbCCCD.Text.Trim(), @"^\d{12}$"))
            {
                MessageBox.Show("CCCD phải gồm đúng 12 chữ số!", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbCCCD.Focus(); // đưa con trỏ về lại ô này
            }
        }

        private void panelContent_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
