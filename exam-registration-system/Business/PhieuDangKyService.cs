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

        public static bool InsertFreeReg(string maPDK, string maDS, DateTime ngayDangKy, string loaiDGNL, string LoaiPDK, string maLichThi)
        {
            return PhieuDangKyDAO.InsertFreeReg(maPDK, maDS, ngayDangKy, loaiDGNL, LoaiPDK, maLichThi);
        }
        public static string GetNextMaPhieuDK()
        {
            return PhieuDangKyDAO.GetNextMaPhieuDK();
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
            return PhieuDangKyDAO.SearchRegistration(maPDK, ngayLapFrom, ngayLapTo, trangThai, maDS, maLT, tenDonVi, loaiPDK, loaiCC);
        }

        public static bool UpdateRegistration(string maPDK, DateTime? ngayLap = null, string trangThai = null, string maDS = null, string maLT = null, string tenDonVi = null, string loaiPDK = null, string loaiCC = null)
        {
            return PhieuDangKyDAO.UpdateRegistration(maPDK, ngayLap, trangThai, maDS, maLT, tenDonVi, loaiPDK, loaiCC);
        }

        public static DataTable FilterRegistrations(string maPDK, string loaiKyThi, string trangThai)
        {
            try
            {
                return PhieuDangKyDAO.FilterRegistrations(maPDK, loaiKyThi, trangThai);
            }
            catch (Exception ex)
            {
                throw new Exception($"Business layer error: {ex.Message}");
            }
        }

        public static DataTable GetPhieuDangKy(string maPDK)
        {
            try
            {
                return PhieuDangKyDAO.GetPhieuDangKy(maPDK);
            }
            catch (Exception ex)
            {
                throw new Exception($"Business layer error: {ex.Message}");
            }
        }

        public static DataTable XemPDKDeXuatPhieu()
        {
            return PhieuDangKyDAO.XemPDKDeXuatPhieu();
        }
    }
}
