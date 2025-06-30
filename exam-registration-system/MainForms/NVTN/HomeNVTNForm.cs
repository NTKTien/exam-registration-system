using exam_registration_system.CommonForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exam_registration_system.MainForms.NVTN
{
    public partial class HomeNVTNForm : Form
    {
        public HomeNVTNForm()
        {
            InitializeComponent();
        }

        bool menuExpand = false;
        private void menuTransaction_Tick(object sender, EventArgs e)
        {

            if (menuExpand == false)
            {
                menuContainer.Height += 10;
                if (menuContainer.Height >= 185)
                {
                    menuTransaction.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                menuContainer.Height -= 10;
                if (menuContainer.Height <= 45)
                {
                    menuTransaction.Stop();
                    menuExpand = false;
                }
            }
        }

        private void menu_Click(object sender, EventArgs e)
        {
            menuTransaction.Start();
        }

        private void ButHome_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            homeUC home = new homeUC();
            panelContent.Controls.Add(home);
        }

        private void HomeNVTNForm_Load(object sender, EventArgs e)
        {
            ButHome_Click(ButHome, EventArgs.Empty);
        }

        private void butProfile_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            createdRegForm frm = new createdRegForm();
            frm.TopLevel = false; 
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            panelContent.Controls.Add(frm);
            frm.Show();
        }

        private void butRegisteredCourse_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            RegListForm frm = new RegListForm();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            panelContent.Controls.Add(frm);
            frm.Show();
        }
    }
}
