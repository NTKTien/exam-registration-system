using exam_registration_system.Utils;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using exam_registration_system.MainForms.NVTN;


namespace exam_registration_system.DataAccess
{
    public class releaseCardDAO
    {
        public static DataTable GetAllRegistrations()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(GlobalInfo.ConnectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("XemTatCaPhieuDangKy", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        DataTable dt = new DataTable();
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                        return dt;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error loading data: {ex.Message}");
            }
        }

        public static DataTable FilterRegistrations(string maPDK, string loaiKyThi, string trangThaiXuatPDT)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(GlobalInfo.ConnectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("LocPhieuDangKy", conn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@MaPDK", string.IsNullOrWhiteSpace(maPDK) ? (object)DBNull.Value : (object)maPDK);
                        cmd.Parameters.AddWithValue("@LoaiKyThi", string.IsNullOrEmpty(loaiKyThi) ? (object)DBNull.Value : (object)loaiKyThi);
                        cmd.Parameters.AddWithValue("@TrangThaiXuatPDT", string.IsNullOrEmpty(trangThaiXuatPDT) ? (object)DBNull.Value : (object)trangThaiXuatPDT);
                        DataTable dt = new DataTable();
                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            adapter.Fill(dt);
                        }
                        return dt;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error filtering data: {ex.Message}");
            }
        }

    }
}
