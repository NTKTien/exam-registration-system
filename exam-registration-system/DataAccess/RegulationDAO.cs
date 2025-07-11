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
    public class RegulationDAO
    {
        public static DataTable SearchRegulation(
            string maQD = null,
            string doiTuong = null,
            string noiDung = null,
            decimal? giaTriFrom = null,
            decimal? giaTriTo = null)
        {
            using (SqlConnection conn = new SqlConnection(GlobalInfo.ConnectionString))
            using (SqlCommand cmd = new SqlCommand("sp_SearchRegulation", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MaQD", maQD ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@DoiTuong", doiTuong ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@NoiDung", noiDung ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@GiaTriFrom", giaTriFrom.HasValue ? (object)giaTriFrom.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@GiaTriTo", giaTriTo.HasValue ? (object)giaTriTo.Value : DBNull.Value);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}
