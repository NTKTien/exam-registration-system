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
    public class PhieuDuThiDAO
    {
        public static DataTable GetPhieuDuThi(string maPDK)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(GlobalInfo.ConnectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("XemPhieuDuThi", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MaPDK", maPDK);

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            return dt;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi tải dữ liệu Phiếu Dự Thi: {ex.Message}");
            }
        }



        public static bool IssuePhieuDuThi(string maPDK)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(GlobalInfo.ConnectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("XuatPhieuDuThi", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MaPDK", maPDK);
                        return cmd.ExecuteNonQuery() > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Lỗi khi phát hành Phiếu Dự Thi: {ex.Message}");
            }
        }
    }
}
