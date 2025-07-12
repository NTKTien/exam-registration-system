using exam_registration_system.Business;
using System;
using System.Data;
using System.Windows.Forms;

namespace exam_registration_system.CommonForms
{
    public partial class RegDetailForm : Form
    {
        private string RegistrationId;

        // ===== Thuộc tính khách hàng =====
        private string HoTen { get; set; }
        private string GioiTinh { get; set; }
        private string NgaySinh { get; set; }
        private string CCCD { get; set; }
        private string SDT { get; set; }
        private string Email { get; set; }
        private string DiaChi { get; set; }

        // ===== Thuộc tính thí sinh =====
        private string HoTenTS { get; set; }
        private string GioiTinhTS { get; set; }
        private string NgaySinhTS { get; set; }
        private string CCCDTS { get; set; }
        private string SDTTS { get; set; }
        private string EmailTS { get; set; }

        // ===== Thuộc tính phiếu đăng ký =====
        private string MaPDK { get; set; }
        private string NgayLap { get; set; }
        private string NgayThi { get; set; }
        private string CaThi { get; set; }
        private string LoaiCC { get; set; }
        private string TrangThai { get; set; }

        public RegDetailForm(string registrationId)
        {
            InitializeComponent();
            this.RegistrationId = registrationId;
        }

        // ===== Phương thức =====
        private void RegDetailForm_Load(object sender, EventArgs e)
        {
            LoadCustomerInfo();
            LoadCandidateInfo();
            LoadRegistrationInfo();
            FillControls();
        }

        private void LoadCustomerInfo()
        {
            DataTable dt = CustomerService.GetFreeCustomerInforByRegId(RegistrationId);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                HoTen = row["HoTen"].ToString();
                GioiTinh = row["GioiTinh"].ToString();
                NgaySinh = row["NgaySinh"].ToString();
                CCCD = row["CCCD"].ToString();
                SDT = row["SoDienThoai"].ToString();
                Email = row["Email"].ToString();
                DiaChi = row["DiaChi"].ToString();
            }
        }

        private void LoadCandidateInfo()
        {
            DataTable dt = CandidateService.GetCandidateByMaPDK(RegistrationId);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                HoTenTS = row["HoTen"].ToString();
                GioiTinhTS = row["GioiTinh"].ToString();
                NgaySinhTS = row["Ngaysinh"].ToString();
                CCCDTS = row["CCCD"].ToString();
                SDTTS = row["SoDienThoai"].ToString();
                EmailTS = row["Email"].ToString();
            }
        }

        private void LoadRegistrationInfo()
        {
            DataTable dt = PhieuDangKyService.GetDetailRegByID(RegistrationId);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                MaPDK = row["MaPDK"].ToString();
                NgayLap = row["NgayLap"].ToString();
                NgayThi = row["NgayThi"].ToString();
                CaThi = row["CaThi"].ToString();
                TrangThai = row["TrangThai"].ToString();
                LoaiCC = row["LoaiCC"].ToString();
            }
        }

        private void FillControls()
        {
            // Khách hàng
            tbFullName.Text = HoTen;
            tbSex.Text = GioiTinh;
            tbBirth.Text = NgaySinh;
            tbCCCD.Text = CCCD;
            tbSDT.Text = SDT;
            tbEmail.Text = Email;
            tbAddress.Text = DiaChi;

            // Thí sinh
            tbNameTS.Text = HoTenTS;
            tbSexTS.Text = GioiTinhTS;
            tbBirthTS.Text = NgaySinhTS;
            tbCCCDTS.Text = CCCDTS;
            tbSDTTS.Text = SDTTS;
            tbEmailTS.Text = EmailTS;

            // Phiếu đăng ký
            tbRegCode.Text = MaPDK;
            tbRegDate.Text = NgayLap;
            tbExamDate.Text = NgayThi;
            tbExamShift.Text = CaThi;
            tbStatus.Text = TrangThai;
            tbTypeReg.Text = LoaiCC;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
