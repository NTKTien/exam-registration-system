using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using exam_registration_system.Utils;
using System;
using System.Data;
using System.Data.SqlClient;
using exam_registration_system.Business;

namespace exam_registration_system.DataAccess
{
    public class CertificatesFormDAO
    {
        public static CertificateInfo GetCertificateInfo(string maPDK)
        {
            SqlParameter[] parameters = { new SqlParameter("@MaPDK", maPDK) };
            DataTable dt = SqlServerHelper.ExecuteQuery("EXEC sp_GetCertificateInfo @MaPDK", parameters);

            if (dt.Rows.Count == 0) return null;

            var row = dt.Rows[0];
            return new CertificateInfo
            {
                HoTen = row["HoTen"].ToString(),
                LoaiPDK = row["LoaiPDK"].ToString(),
                LoaiCC = row["LoaiCC"].ToString(),
                KetQua = row["KetQua"].ToString(),
                NgayThi = Convert.ToDateTime(row["NgayThi"]),
                TrangThai = row["TrangThai"].ToString()
            };
        }

        public static bool UpdateCertificateStatus(string maTS)
        {
            SqlParameter[] param = { new SqlParameter("@MaTS", maTS) };
            DataTable dt = SqlServerHelper.ExecuteQuery("EXEC sp_ConfirmCertificateDelivery @MaTS", param);
            return dt.Rows.Count > 0;
        }
    }
}