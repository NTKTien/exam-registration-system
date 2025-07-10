using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exam_registration_system.Utils;
using System.Windows.Forms;

namespace exam_registration_system.DataAccess
{
    public class CustomerDAO
    {
        public static DataTable GetFreeCustomerInforByRegId(string registrationId)
        {
            using (SqlConnection conn = new SqlConnection(GlobalInfo.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_GetFreeCustomerInforByRegId", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@RegistrationId", registrationId);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public static bool InsertCustomer(string hoTen, string gioiTinh, DateTime ngaySinh, string cccd, string sdt, string email, string diaChi, string maPDK)
        {
            using (SqlConnection conn = new SqlConnection(GlobalInfo.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_InsertCustomer", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@HoTen", hoTen);
                cmd.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                cmd.Parameters.AddWithValue("@NgaySinh", ngaySinh);
                cmd.Parameters.AddWithValue("@CCCD", cccd);
                cmd.Parameters.AddWithValue("@SoDienThoai", sdt);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@DiaChi", diaChi);
                cmd.Parameters.AddWithValue("@MaPDK", maPDK);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public static DataTable TraCuuTTNguoiDangKy(
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
            using (SqlConnection conn = new SqlConnection(GlobalInfo.ConnectionString))
            using (SqlCommand cmd = new SqlCommand("sp_TraCuuTTNguoiDangKy", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MaNDK", maNDK ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@CCCD", cccd ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@HoTen", hoTen ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@GioiTinh", gioiTinh ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@NgaySinhFrom", ngaySinhFrom.HasValue ? (object)ngaySinhFrom.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@NgaySinhTo", ngaySinhTo.HasValue ? (object)ngaySinhTo.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@SoDienThoai", soDienThoai ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Email", email ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@DiaChi", diaChi ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@MaPDK", maPDK ?? (object)DBNull.Value);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

    }
}
