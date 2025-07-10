using System;
using System.Data;
using exam_registration_system.DataAccess;

namespace exam_registration_system.Business
{
    public class ExtensionFormService
    {
        public static DataTable GetPendingExtensionForms()
        {
            return ExtensionFormDAO.GetPendingExtensionForms();
        }
        public static DataTable GetExtensionDetails(string maPGH)
        {
            return ExtensionFormDAO.GetExtensionDetails(maPGH);
        }

        public static void SaveExtension(string maPGH, decimal phiGiaHan)
        {
            ExtensionFormDAO.SaveExtension(maPGH, phiGiaHan);
        }

    }
}
