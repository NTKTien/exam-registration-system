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
    public class InvoiceDAO
    {
        public static bool InsertHoaDon(string maPDK, string maNV)
        {
            using (SqlConnection conn = new SqlConnection(GlobalInfo.ConnectionString))
            using (SqlCommand cmd = new SqlCommand("sp_InsertInvoice", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MaPDK", maPDK);
                cmd.Parameters.AddWithValue("@MaNV", maNV);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
        public static DataTable SearchInvoice(
        string maHD = null,
        decimal? tongTienFrom = null,
        decimal? tongTienTo = null,
        decimal? troGiaFrom = null,
        decimal? troGiaTo = null,
        decimal? thanhTienFrom = null,
        decimal? thanhTienTo = null,
        string maPDK = null,
        string maNV = null)
        {
            using (SqlConnection conn = new SqlConnection(GlobalInfo.ConnectionString))
            using (SqlCommand cmd = new SqlCommand("sp_SearchInvoice", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MaHD", maHD ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@TongTienFrom", tongTienFrom.HasValue ? (object)tongTienFrom.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@TongTienTo", tongTienTo.HasValue ? (object)tongTienTo.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@TroGiaFrom", troGiaFrom.HasValue ? (object)troGiaFrom.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@TroGiaTo", troGiaTo.HasValue ? (object)troGiaTo.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@ThanhTienFrom", thanhTienFrom.HasValue ? (object)thanhTienFrom.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@ThanhTienTo", thanhTienTo.HasValue ? (object)thanhTienTo.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@MaPDK", maPDK ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@MaNV", maNV ?? (object)DBNull.Value);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public static bool UpdateInvoice(string maHD, decimal? tongTien = null, decimal? troGia = null, decimal? thanhTien = null, string maPDK = null, string maNV = null)
        {
            using (SqlConnection conn = new SqlConnection(GlobalInfo.ConnectionString))
            using (SqlCommand cmd = new SqlCommand("sp_UpdateInvoice", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MaHD", maHD);
                cmd.Parameters.AddWithValue("@TongTien", tongTien.HasValue ? (object)tongTien.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@TroGia", troGia.HasValue ? (object)troGia.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@ThanhTien", thanhTien.HasValue ? (object)thanhTien.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@MaPDK", maPDK ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@MaNV", maNV ?? (object)DBNull.Value);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
