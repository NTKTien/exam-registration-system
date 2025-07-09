using exam_registration_system.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_registration_system.Business
{
    public class PhieuDangKyService
    {
        public static DataTable GetAllReg()
        {
            return PhieuDangKyDAO.GetAll();
        }

        public static DataTable GetDetailRegByID(string registrationId)
        {
            return PhieuDangKyDAO.GetDetailRegByID(registrationId);
        }

        public static bool InsertFreeReg(string maPDK, DateTime ngayDangKy, string loaiDGNL, string LoaiPDK, string maLichThi)
        {
            return PhieuDangKyDAO.InsertFreeReg(maPDK, ngayDangKy, loaiDGNL, LoaiPDK, maLichThi);
        }
        public static string GetNextMaPhieuDK()
        {
            return PhieuDangKyDAO.GetNextMaPhieuDK();
        }
        
    }
}
