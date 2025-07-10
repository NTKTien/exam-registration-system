using System;
using System.Data;
using System.Data.SqlClient;
using exam_registration_system.Utils;

namespace exam_registration_system.DataAccess
{
    public class ExtensionFormDAO
    {
        public static DataTable GetPendingExtensionForms()
        {
            string sql = "EXEC sp_GetPendingExtends";
            return SqlServerHelper.ExecuteQuery(sql);
        }

        public static DataTable GetExtensionDetails(string maPGH)
        {
            using (SqlConnection conn = new SqlConnection(GlobalInfo.ConnectionString))
            {
                conn.Open();
                using (var cmd = new SqlCommand("sp_GetExtensionDetails", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@MaPGH", SqlDbType.Char, 5) { Value = maPGH });

                    using (var da = new SqlDataAdapter(cmd))
                    {
                        var dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        public static void SaveExtension(string maPGH, decimal phiGiaHan)
        {
            using (SqlConnection conn = new SqlConnection(GlobalInfo.ConnectionString))
            {
                conn.Open();
                using (var cmd = new SqlCommand("sp_SaveExtension", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add(new SqlParameter("@MaPGH", SqlDbType.Char, 5) { Value = maPGH });
                    cmd.Parameters.Add(new SqlParameter("@PhiGiaHan", SqlDbType.Decimal) { Value = phiGiaHan });

                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
