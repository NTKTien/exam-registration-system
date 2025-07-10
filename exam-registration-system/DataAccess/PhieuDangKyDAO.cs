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
    public class PhieuDangKyDAO
    {
        public static DataTable GetAll()
        {
            using (SqlConnection conn = new SqlConnection(GlobalInfo.ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand("P_GetAllReg", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        public static DataTable GetDetailRegByID (string registrationId)
        {
            using (SqlConnection conn = new SqlConnection(GlobalInfo.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_GetRegistrationById", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@RegistrationId", registrationId);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public static bool InsertFreeReg(string maPDK, DateTime ngayDangKy, string loaiDGNL, string LoaiPDK, string maLichThi)
        {
            using (SqlConnection conn = new SqlConnection(GlobalInfo.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_InsertFreeReg", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MaPDK", maPDK);
                cmd.Parameters.AddWithValue("@NgayDangKy", ngayDangKy);
                cmd.Parameters.AddWithValue("@LoaiDGNL", loaiDGNL);
                cmd.Parameters.AddWithValue("@MaLichThi", maLichThi);
                cmd.Parameters.AddWithValue("@LoaiPDK", LoaiPDK);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public static string GetNextMaPhieuDK()
        {
            using (SqlConnection conn = new SqlConnection(GlobalInfo.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_GetNextMaPhieuDK", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                conn.Open();
                object result = cmd.ExecuteScalar();

                return result?.ToString();
            }
        }
    }
}
