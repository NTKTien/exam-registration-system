using exam_registration_system.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace exam_registration_system.Business
{
    public class ReleaseCardBS
    {
        public static DataTable GetAllRegistrations()
        {
            try
            {
                return releaseCardDAO.GetAllRegistrations();
            }
            catch (Exception ex)
            {
                throw new Exception($"Business layer error: {ex.Message}");
            }
        }

        public static DataTable FilterRegistrations(string maPDK, string loaiKyThi, string trangThaiXuatPDT)
        {
            try
            {
                return releaseCardDAO.FilterRegistrations(maPDK, loaiKyThi, trangThaiXuatPDT);
            }
            catch (Exception ex)
            {
                throw new Exception($"Business layer error: {ex.Message}");
            }
        }
    }
}
