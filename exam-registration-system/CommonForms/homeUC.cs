using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using exam_registration_system.Utils;

namespace exam_registration_system.CommonForms
{
    public partial class homeUC : UserControl
    {
        public homeUC()
        {
            InitializeComponent();

            InitializeData();
        }

        private void InitializeData()
        {
            textFullName.Text = GlobalInfo.CurrentUsername;
            if (GlobalInfo.Role == "TN")
            {
                textRole.Text = "Tiếp Nhận";
            }
            else if (GlobalInfo.Role == "KT")
            {
                textRole.Text = "Kế Toán";
            }
            else if (GlobalInfo.Role == "NL")
            {
                textRole.Text = "Nhập Liệu";
            }
            else
            {
                textRole.Text = "Unknown";
            }
            textLoginDate.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }
    }
}
