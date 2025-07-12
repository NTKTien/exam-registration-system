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

                tbCalenderEx.Text = $"{ngayThiStr} - Ca {caThi} - {phongThi}";
            }
        }

        private void butCreateReg_Click(object sender, EventArgs e)
        {
            // Biến lưu thông tin người đăng kí 
            string hoTen = tbFullName.Text;
            string gioiTinh = radioButMale.Checked ? "Nam" : "Nữ";
            DateTime ngaySinh = dtpNgaySinh.Value;
            string cccd = tbCCCD.Text;
            string sdt = tbSDT.Text;
            string email = tbEmail.Text;
            string diaChi = tbAddress.Text;

            //Biến lưu Thông tin thí sinh
            string hoTenTS = tbNameTS.Text;
            string gioiTinhTS = radioButMaleTS.Checked ? "Nam" : "Nữ";
            DateTime ngaySinhTS = dtpBirthTS.Value;
            string cccdTS = tbCCCDTS.Text;
            string sdtTS = tbSDTTS.Text;
            string emailTS = tbEmailTS.Text;

            //Biến lưu thông tin phiếu đăng ký
            string maPDK = tbRegCode.Text;
            DateTime ngayDangKy = dtpNgayDangKy.Value;
            string maLichThi = selectedMaLT;

            // Kiểm tra thiếu thông tin
            bool isMissing =
                string.IsNullOrWhiteSpace(hoTen) ||
                string.IsNullOrWhiteSpace(gioiTinh) ||
                string.IsNullOrWhiteSpace(cccd) ||
                string.IsNullOrWhiteSpace(sdt) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(diaChi) ||
                string.IsNullOrWhiteSpace(hoTenTS) ||
                string.IsNullOrWhiteSpace(gioiTinhTS) ||
                string.IsNullOrWhiteSpace(cccdTS) ||
                string.IsNullOrWhiteSpace(sdtTS) ||
                string.IsNullOrWhiteSpace(emailTS) ||
                string.IsNullOrWhiteSpace(maPDK) ||
                cmbTypeDGNL.SelectedItem == null ||   
                string.IsNullOrWhiteSpace(maLichThi);

            if (isMissing)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin đăng ký!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra hợp lệ ngày sinh người đăng ký
            int tuoiNguoiDK = DateTime.Now.Year - ngaySinh.Year;
            if (ngaySinh >= DateTime.Today || tuoiNguoiDK < 18)
            {
                MessageBox.Show("Người đăng ký phải đủ 18 tuổi trở lên!", "Lỗi ngày sinh", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kiểm tra hợp lệ ngày sinh thí sinh
            int tuoiTS = DateTime.Now.Year - ngaySinhTS.Year;
            if (ngaySinhTS >= DateTime.Today || tuoiTS < 6 || tuoiTS > 100)
            {
                MessageBox.Show("Thí sinh phải từ 6 đến 100 tuổi!", "Lỗi ngày sinh", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Sau khi kiểm tra xong mới gọi ToString
            string loaiDGNL = cmbTypeDGNL.SelectedItem.ToString();

            //Thêm thí sinh
            string maDS = CandidateService.AddCandidate(hoTenTS, gioiTinhTS, ngaySinhTS, sdtTS, cccdTS, emailTS);

            // Thêm phiếu đăng ký
            bool isRegOk = PhieuDangKyService.InsertFreeReg(maPDK, maDS, ngayDangKy, loaiDGNL, "KHTD", maLichThi);

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

                // Xóa toàn bộ dữ liệu thí sinh
                tbNameTS.Clear();
                tbEmailTS.Clear();
                radioButMaleTS.Checked = true; // hoặc false, tùy mặc định
                dtpBirthTS.Value = DateTime.Today;
                tbCCCDTS.Clear();
                tbSDTTS.Clear();

                // Xóa toàn bộ dữ liệu phiếu đăng ký
                tbRegCode.Text = PhieuDangKyService.GetNextMaPhieuDK();
                dtpNgayDangKy.Value = DateTime.Today;
                cmbTypeDGNL.SelectedIndex = -1;

                tbCalenderEx.Text = string.Empty;
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

            //Thiết lập ngày lập phiếu mặc định là ngày hiện tại
            dtpNgayDangKy.Value = DateTime.Now;
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

        private void butCancel_Click(object sender, EventArgs e)
        {
            // Xóa toàn bộ dữ liệu người dùng đã nhập
            tbFullName.Clear();
            radioButMale.Checked = true; // hoặc false, tùy mặc định
            dtpNgaySinh.Value = DateTime.Today;
            tbCCCD.Clear();
            tbSDT.Clear();
            tbEmail.Clear();
            tbAddress.Clear();

            // Xóa toàn bộ dữ liệu thí sinh
            tbNameTS.Clear();
            tbEmailTS.Clear();
            radioButMaleTS.Checked = true; // hoặc false, tùy mặc định
            dtpBirthTS.Value = DateTime.Today;
            tbCCCDTS.Clear();
            tbSDTTS.Clear();

            // Xóa toàn bộ dữ liệu phiếu đăng ký
            tbRegCode.Text = PhieuDangKyService.GetNextMaPhieuDK();
            dtpNgayDangKy.Value = DateTime.Today;
            cmbTypeDGNL.SelectedIndex = -1;

            tbCalenderEx.Text = string.Empty;
            selectedMaLT = null;
        }

        private void tbEmail_Leave(object sender, EventArgs e)
        {
            string email = tbEmail.Text.Trim();
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            if (!Regex.IsMatch(email, emailPattern))
            {
                MessageBox.Show("Email không hợp lệ. Vui lòng nhập đúng định dạng (ví dụ: ten@email.com)!", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbEmail.Focus();
            }
        }

        private void tbSDTTS_Leave(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(tbSDTTS.Text.Trim(), @"^\d{10}$"))
            {
                MessageBox.Show("Số điện thoại phải gồm đúng 10 chữ số!", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbSDTTS.Focus(); // đưa con trỏ về lại ô này
            }
        }

        private void tbCCCDTS_Leave(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(tbCCCDTS.Text.Trim(), @"^\d{12}$"))
            {
                MessageBox.Show("CCCD phải gồm đúng 12 chữ số!", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbCCCDTS.Focus(); // đưa con trỏ về lại ô này
            }
        }

        private void tbEmailTS_Leave(object sender, EventArgs e)
        {
            string emailTS = tbEmailTS.Text.Trim();
            string emailPattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

            if (!Regex.IsMatch(emailTS, emailPattern))
            {
                MessageBox.Show("Email của thí sinh không hợp lệ. Vui lòng nhập đúng định dạng!", "Lỗi định dạng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbEmailTS.Focus();
            }
        }
    }
    
}
