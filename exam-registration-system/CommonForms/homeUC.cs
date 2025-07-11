using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exam_registration_system.CommonForms
{
    public partial class homeUC : UserControl
    {
        private string username;
        private string role;
        public homeUC(string username, string role)
        {
            InitializeComponent();
            this.username = username;
            this.role = role;

            InitializeData();
        }

        private void InitializeData()
        {
            textFullName.Text = username;
            if (role == "TN")
            {
                textRole.Text = "Tiếp Nhận";
            }
            else if (role == "KT")
            {
                textRole.Text = "Kế Toán";
            }
            else if (role == "NL")
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
