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
    public partial class RegDetailForm : Form
    {
        private string RegistrationId;
        public RegDetailForm(string RegistrationId)
        {
            InitializeComponent();
            this.RegistrationId = RegistrationId;
        }

        private void RegDetailForm_Load(object sender, EventArgs e)
        {
            LoadDetailReg(this.RegistrationId);
        }

        private void LoadDetailReg(string RegistrationId)
        {
            //Lấy thông tin khách hàng
            DataTable dtCustomer = CustomerService.GetFreeCustomerInforByRegId(RegistrationId);
            if (dtCustomer.Rows.Count > 0)
            {
                DataRow row = dtCustomer.Rows[0];
                tbFullName.Text = row["HoTen"].ToString();
                tbSex.Text = row["GioiTinh"].ToString();
                tbBirth.Text = row["NgaySinh"].ToString();
                tbCCCD.Text = row["CCCD"].ToString();
                tbSDT.Text = row["SoDienThoai"].ToString();
                tbEmail.Text = row["Email"].ToString();
                tbAddress.Text = row["DiaChi"].ToString();
            }

            // Lấy thông tin phiếu đăng ký
            DataTable dtReg = PhieuDangKyService.GetDetailRegByID(RegistrationId);
            if (dtReg.Rows.Count > 0)
            {
                DataRow row = dtReg.Rows[0];
                tbRegCode.Text = row["MaPDK"].ToString();
                tbRegDate.Text = row["NgayLap"].ToString();
                tbExamDate.Text = row["NgayThi"].ToString();
                tbStatus.Text = row["TrangThai"].ToString();
                tbTypeReg.Text = row["LoaiCC"].ToString();
                tbExamShift.Text = row["CaThi"].ToString();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
