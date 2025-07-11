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

        public static DataTable SearchRegistration(string maPDK = null, 
                                                   DateTime? ngayLapFrom = null,
                                                   DateTime? ngayLapTo = null,
                                                   string trangThai = null,
                                                   string maDS = null,
                                                   string maLT = null,
                                                   string tenDonVi = null,
                                                   string loaiPDK = null,
                                                   string loaiCC = null) {
            using (SqlConnection conn = new SqlConnection(GlobalInfo.ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("sp_SearchRegistration", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@MaPDK", maPDK != null ? (object)maPDK : DBNull.Value);
                    cmd.Parameters.AddWithValue("@NgayLapFrom", ngayLapFrom.HasValue ? (object)ngayLapFrom.Value : DBNull.Value);
                    cmd.Parameters.AddWithValue("@NgayLapTo", ngayLapTo.HasValue ? (object)ngayLapTo.Value : DBNull.Value);
                    cmd.Parameters.AddWithValue("@TrangThai", trangThai != null ? (object)trangThai : DBNull.Value);
                    cmd.Parameters.AddWithValue("@MaDS", maDS != null ? (object)maDS : DBNull.Value);
                    cmd.Parameters.AddWithValue("@MaLT", maLT != null ? (object)maLT : DBNull.Value);
                    cmd.Parameters.AddWithValue("@TenDonVi", tenDonVi != null ? (object)tenDonVi : DBNull.Value);
                    cmd.Parameters.AddWithValue("@LoaiPDK", loaiPDK != null ? (object)loaiPDK : DBNull.Value);
                    cmd.Parameters.AddWithValue("@LoaiCC", loaiCC != null ? (object)loaiCC : DBNull.Value);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
        }

        public static bool UpdateRegistration(
            string maPDK,
            DateTime? ngayLap = null,
            string trangThai = null,
            string maDS = null,
            string maLT = null,
            string tenDonVi = null,
            string loaiPDK = null,
            string loaiCC = null)
        {
            using (SqlConnection conn = new SqlConnection(GlobalInfo.ConnectionString))
            using (SqlCommand cmd = new SqlCommand("sp_UpdateRegistration", conn))
            {
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MaPDK", maPDK);
                cmd.Parameters.AddWithValue("@NgayLap", ngayLap.HasValue ? (object)ngayLap.Value : DBNull.Value);
                cmd.Parameters.AddWithValue("@TrangThai", trangThai ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@MaDS", maDS ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@MaLT", maLT ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@TenDonVi", tenDonVi ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@LoaiPDK", loaiPDK ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@LoaiCC", loaiCC ?? (object)DBNull.Value);

                conn.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public static DataTable FilterRegistrations(string maPDK, string loaiKyThi, string trangThai)
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
                        cmd.Parameters.AddWithValue("@TrangThai", string.IsNullOrEmpty(trangThai) ? (object)DBNull.Value : (object)trangThai);
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

        public static DataTable GetPhieuDangKy(string maPDK)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(GlobalInfo.ConnectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand("XemPhieuDangKy", conn))
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
                throw new Exception($"Lỗi khi tải dữ liệu Phiếu Đăng Ký: {ex.Message}");
            }
        }

    }
}
