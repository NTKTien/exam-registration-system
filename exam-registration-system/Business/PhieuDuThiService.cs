using exam_registration_system.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_registration_system.Business
{
    public class PhieuDuThiService
    {
        public static DataTable GetPhieuDuThi(string maPDK)
        {
            try
            {
                return PhieuDuThiDAO.GetPhieuDuThi(maPDK);
            }
            catch (Exception ex)
            {
                throw new Exception($"Business layer error: {ex.Message}");
            }
        }



        public static bool IssuePhieuDuThi(string maPDK)
        {
            try
            {
                return PhieuDuThiDAO.IssuePhieuDuThi(maPDK);
            }
            catch (Exception ex)
            {
                throw new Exception($"Business layer error: {ex.Message}");
            }
        }
    }
}
