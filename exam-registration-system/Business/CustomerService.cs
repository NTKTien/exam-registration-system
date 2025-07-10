using exam_registration_system.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exam_registration_system.Business
{
    public class CustomerService
    {
        public static DataTable GetFreeCustomerInforByRegId(string registrationId)
        {
            return CustomerDAO.GetFreeCustomerInforByRegId(registrationId);
        }

        public static bool InsertCustomer(string hoTen, string gioiTinh, DateTime ngaySinh, string cccd, string sdt, string email, string diaChi, string maPDK)
        {
            return CustomerDAO.InsertCustomer(hoTen, gioiTinh, ngaySinh, cccd, sdt, email, diaChi, maPDK);
        }

        public static DataTable GetRegistorList(
            string maNDK = null,
                string cccd = null,
                string hoTen = null,
                string gioiTinh = null,
                DateTime? ngaySinhFrom = null,
                DateTime? ngaySinhTo = null,
                string soDienThoai = null,
                string email = null,
                string diaChi = null,
                string maPDK = null) {
            return CustomerDAO.TraCuuTTNguoiDangKy(maNDK, cccd, hoTen, gioiTinh, ngaySinhFrom, ngaySinhTo, soDienThoai, email, diaChi, maPDK);
        }
    }
}
