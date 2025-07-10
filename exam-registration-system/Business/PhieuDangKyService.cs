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

        public static DataTable GetRegistrationList(string maPDK = null,
                                                DateTime? ngayLapFrom = null,
                                                DateTime? ngayLapTo = null,
                                                string trangThai = null,
                                                string maDS = null,
                                                string maLT = null,
                                                string tenDonVi = null,
                                                string loaiPDK = null,
                                                string loaiCC = null) {
            return PhieuDangKyDAO.TraCuuPDK(maPDK, ngayLapFrom, ngayLapTo, trangThai, maDS, maLT, tenDonVi, loaiPDK, loaiCC);
        }

        public static bool UpdateRegistration(string maPDK, DateTime? ngayLap = null, string trangThai = null, string maDS = null, string maLT = null, string tenDonVi = null, string loaiPDK = null, string loaiCC = null)
        {
            return PhieuDangKyDAO.CapNhatPDK(maPDK, ngayLap, trangThai, maDS, maLT, tenDonVi, loaiPDK, loaiCC);
        }
    }
}
