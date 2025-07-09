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
    }
}
