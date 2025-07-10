using exam_registration_system.CommonForms;
using exam_registration_system.MainForms.NVKT;
using exam_registration_system.MainForms.NVNL;
using exam_registration_system.MainForms.NVTN;
using PdfSharp.Drawing;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exam_registration_system
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SqlServerHelper.SetConnectionWindowsAuth();
            Application.Run(new Login());
            Console.WriteLine(typeof(XFontStyle).FullName);
        }
    }
}
