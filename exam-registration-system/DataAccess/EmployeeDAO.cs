using exam_registration_system.Utils;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exam_registration_system.DataAccess
{
    public class EmployeeDAO
    {
        public static DataTable TraCuuNhanVien(
            string maNV = null,
            string hoTen = null,
            string diaChi = null,
            string soDienThoai = null,
            DateTime? ngaySinhFrom = null,
            DateTime? ngaySinhTo = null,
            string email = null,
            string loaiNV = null)
        {
            using (SqlConnection conn = new SqlConnection(GlobalInfo.ConnectionString))
            using (SqlCommand cmd = new SqlCommand("sp_TraCuuNhanVien", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MaNV", maNV ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@HoTen", hoTen ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@DiaChi", diaChi ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@SoDienThoai", soDienThoai ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@NgaySinhFrom", ngaySinhFrom.HasValue ? (object)ngaySinhFrom.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@NgaySinhTo", ngaySinhTo.HasValue ? (object)ngaySinhTo.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@Email", email ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@LoaiNV", loaiNV ?? (object)DBNull.Value);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}