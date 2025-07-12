using exam_registration_system.Utils;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_registration_system.DataAccess
{
    public class CandidateDAO
    {
        public static string InsertCandidate(
        string hoTen,
        string gioiTinh,
        DateTime ngaySinh,
        string soDienThoai,
        string cccd,
        string email)
        {
            using (SqlConnection conn = new SqlConnection(GlobalInfo.ConnectionString))
            using (SqlCommand cmd = new SqlCommand("sp_InsertCandidate", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@HoTen", hoTen);
                cmd.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                cmd.Parameters.AddWithValue("@Ngaysinh", ngaySinh);
                cmd.Parameters.AddWithValue("@SoDienThoai", soDienThoai);
                cmd.Parameters.AddWithValue("@CCCD", cccd);
                cmd.Parameters.AddWithValue("@Email", email);

                // Khai báo biến OUTPUT
                SqlParameter outMaDSParam = new SqlParameter("@OutMaDS", SqlDbType.Char, 5)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(outMaDSParam);

                conn.Open();
                cmd.ExecuteNonQuery();

                // Lấy giá trị OUTPUT
                return outMaDSParam.Value?.ToString();
            }
        }

        public static DataTable GetCandidateByMaPDK(string maPDK)
        {
            using (SqlConnection conn = new SqlConnection(GlobalInfo.ConnectionString))
            using (SqlCommand cmd = new SqlCommand("sp_GetCandidateByMaPDK", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@MaPDK", maPDK);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
        }
    }
}
