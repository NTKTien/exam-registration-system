using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_registration_system.Utils
{
    public static class GlobalInfo
    {
        public static string ConnectionString { get; set; }
        public static string CurrentUsername { get; set; }
        public static string Role { get; set; }
        public static DateTime LoginTime { get; set; }
        public static bool IsSinhVien { get; set; }
        public static string DatabaseName { get; set; } = "QLToChucThiCC";
        public static string ServerName { get; set; } = "localhost";
    }
}
