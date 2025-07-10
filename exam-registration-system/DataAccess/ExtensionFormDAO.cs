using System;
using System.Data;
using System.Data.SqlClient;
using exam_registration_system.Utils;

namespace exam_registration_system.DataAccess
{
    public class ExtensionFormDAO
    {
        public static DataTable GetPendingExtensionForms()
        {
            string sql = "EXEC sp_GetPendingExtends";
            return SqlServerHelper.ExecuteQuery(sql);
        }
    }
}
