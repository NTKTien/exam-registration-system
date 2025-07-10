using exam_registration_system.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exam_registration_system.Business
{
    public class InvoiceService
    {
        public static bool InsertInvoice(string maPDK, string maNV)
        {
            return InvoiceDAO.InsertHoaDon(maPDK, maNV);
        }

        public static DataTable GetInvoiceList(
        string maHD = null,
        decimal? tongTienFrom = null,
        decimal? tongTienTo = null,
        decimal? troGiaFrom = null,
        decimal? troGiaTo = null,
        decimal? thanhTienFrom = null,
        decimal? thanhTienTo = null,
        string maPDK = null,
        string maNV = null) {
            return InvoiceDAO.TraCuuHoaDon(maHD, tongTienFrom, tongTienTo, troGiaFrom, troGiaTo, thanhTienFrom, thanhTienTo, maPDK, maNV);
        }

        public static bool UpdateInvoice(string maHD, decimal? tongTien = null, decimal? troGia = null, decimal? thanhTien = null, string maPDK = null, string maNV = null)
        {
            return InvoiceDAO.CapNhatHoaDon(maHD, tongTien, troGia, thanhTien, maPDK, maNV);
        }


    }
}
