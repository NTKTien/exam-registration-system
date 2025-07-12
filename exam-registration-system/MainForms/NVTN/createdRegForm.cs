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
        // ===== Thuộc tính người đăng ký =====
        private string HoTen => tbFullName.Text.Trim();
        private string GioiTinh => radioButMale.Checked ? "Nam" : "Nữ";
        private DateTime NgaySinh => dtpNgaySinh.Value;
        private string CCCD => tbCCCD.Text.Trim();
        private string SDT => tbSDT.Text.Trim();
        private string Email => tbEmail.Text.Trim();
        private string DiaChi => tbAddress.Text.Trim();

        // ===== Thuộc tính thí sinh =====
        private string HoTenTS => tbNameTS.Text.Trim();
        private string GioiTinhTS => radioButMaleTS.Checked ? "Nam" : "Nữ";
        private DateTime NgaySinhTS => dtpBirthTS.Value;
        private string CCCDTS => tbCCCDTS.Text.Trim();
        private string SDTTS => tbSDTTS.Text.Trim();
        private string EmailTS => tbEmailTS.Text.Trim();

        // ===== Phiếu đăng ký =====
        private string MaPDK => tbRegCode.Text.Trim();
        private DateTime NgayDangKy => dtpNgayDangKy.Value;
        private string LoaiDGNL => cmbTypeDGNL.SelectedItem?.ToString();
        private string selectedMaLT = null;
        public createdRegForm()
        {
            InitializeComponent();
        }


        // ===== Phương thức  =====
        private void butSelectCalenderEx_Click(object sender, EventArgs e)
        {
            if (cmbTypeDGNL.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn loại ĐGNL trước!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            ViewExamSchedule form = new ViewExamSchedule(LoaiDGNL);
            if (form.ShowDialog() == DialogResult.OK)
            {
                selectedMaLT = form.SelectedMaLT;
                tbCalenderEx.Text = $"{form.SelectedNgayThi} - Ca {form.SelectedCaThi} - {form.SelectedPhongThi}";
            }
        }

        private void butCreateReg_Click(object sender, EventArgs e)
        {
            if (IsMissingInformation())
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin đăng ký!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!IsValidDateOfBirth())
            {
                return;
            }

            //Thêm thí sinh
            string maDS = CandidateService.AddCandidate(HoTenTS, GioiTinhTS, NgaySinhTS, SDTTS, CCCDTS, EmailTS);

            // Thêm phiếu đăng ký
            bool isRegOk = PhieuDangKyService.InsertFreeReg(MaPDK, maDS, NgayDangKy, LoaiDGNL, "KHTD", selectedMaLT);

            // Thêm khách hàng
            bool isCustomerOk = CustomerService.InsertCustomer(HoTen, GioiTinh, NgaySinh, CCCD, SDT, Email, DiaChi, MaPDK);

            // Thêm hóa đơn với mã nhân viên hardcode
            bool isInvoiceOk = InvoiceService.InsertInvoice(MaPDK, GlobalInfo.CurrentUsername);

            if (isCustomerOk && isRegOk && isInvoiceOk)
            {
                MessageBox.Show("Tạo phiếu đăng ký thành công!", "Thành công");
                ClearForm();
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

        private void butCancel_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        //Xóa  các thông tin đã nhập trong form
        private void ClearForm()
        {
            tbFullName.Clear();
            radioButMale.Checked = true;
            dtpNgaySinh.Value = DateTime.Today;
            tbCCCD.Clear();
            tbSDT.Clear();
            tbEmail.Clear();
            tbAddress.Clear();

            tbNameTS.Clear();
            radioButMaleTS.Checked = true;
            dtpBirthTS.Value = DateTime.Today;
            tbCCCDTS.Clear();
            tbSDTTS.Clear();
            tbEmailTS.Clear();

            tbRegCode.Text = PhieuDangKyService.GetNextMaPhieuDK();
            dtpNgayDangKy.Value = DateTime.Today;
            cmbTypeDGNL.SelectedIndex = -1;

            tbCalenderEx.Text = string.Empty;
            selectedMaLT = null;
        }

        //Validate
        private bool IsMissingInformation()
        {
            return string.IsNullOrWhiteSpace(HoTen) ||
                   string.IsNullOrWhiteSpace(GioiTinh) ||
                   string.IsNullOrWhiteSpace(CCCD) ||
                   string.IsNullOrWhiteSpace(SDT) ||
                   string.IsNullOrWhiteSpace(Email) ||
                   string.IsNullOrWhiteSpace(DiaChi) ||
                   string.IsNullOrWhiteSpace(HoTenTS) ||
                   string.IsNullOrWhiteSpace(GioiTinhTS) ||
                   string.IsNullOrWhiteSpace(CCCDTS) ||
                   string.IsNullOrWhiteSpace(SDTTS) ||
                   string.IsNullOrWhiteSpace(EmailTS) ||
                   string.IsNullOrWhiteSpace(MaPDK) ||
                   LoaiDGNL == null ||
                   string.IsNullOrWhiteSpace(selectedMaLT);
        }

        private bool IsValidDateOfBirth()
        {
            int tuoiNguoiDK = DateTime.Now.Year - NgaySinh.Year;
            if (NgaySinh >= DateTime.Today || tuoiNguoiDK < 18)
            {
                MessageBox.Show("Người đăng ký phải đủ 18 tuổi trở lên!", "Lỗi ngày sinh", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            int tuoiTS = DateTime.Now.Year - NgaySinhTS.Year;
            if (NgaySinhTS >= DateTime.Today || tuoiTS < 6 || tuoiTS > 100)
            {
                MessageBox.Show("Thí sinh phải từ 6 đến 100 tuổi!", "Lỗi ngày sinh", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
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
