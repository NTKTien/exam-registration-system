using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using exam_registration_system.DataAccess;
using System;

namespace exam_registration_system.Business
{
    public class CertificatesFormService
    {
        public static CertificateInfo GetCertificateInfoByMaPDK(string maPDK)
        {
            return CertificatesFormDAO.GetCertificateInfo(maPDK);
        }

        public static bool ConfirmCertificateDelivery(string maTS)
        {
            return CertificatesFormDAO.UpdateCertificateStatus(maTS);
        }
    }

    public class CertificateInfo
    {
        public string HoTen { get; set; }
        public string LoaiPDK { get; set; }
        public string LoaiCC { get; set; }
        public string KetQua { get; set; }
        public DateTime NgayThi { get; set; }
        public string TrangThai { get; set; }
    }
}