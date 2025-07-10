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
    }
}
