using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exam_registration_system.DataAccess;

namespace exam_registration_system.Business
{
    public class EmployeeService
    {
        public static DataTable GetEmpInfo(
            string maNV = null,
            string hoTen = null,
            string diaChi = null,
            string soDienThoai = null,
            DateTime? ngaySinhFrom = null,
            DateTime? ngaySinhTo = null,
            string email = null,
            string loaiNV = null)
        {
            return EmployeeDAO.TraCuuNhanVien(maNV, hoTen, diaChi, soDienThoai, ngaySinhFrom, ngaySinhTo, email, loaiNV);
        }

        public static string CheckLogin(string maNV)
        {
            DataTable dt = EmployeeDAO.TraCuuNhanVien(maNV);
            if (dt.Rows.Count > 0)
            {
                return dt.Rows[0]["LoaiNV"].ToString();
            }
            return null;
        }
    }
}