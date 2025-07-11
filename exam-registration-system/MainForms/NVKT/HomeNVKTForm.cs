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

namespace exam_registration_system.MainForms.NVKT
{
    public partial class HomeNVKTForm : Form
    {
        private string username;
        private string role;
        public HomeNVKTForm(string username, string role)
        {
            InitializeComponent();
            panelContent.Controls.Clear();
            homeUC home = new homeUC(username, role);
            panelContent.Controls.Add(home);
            this.username = username;
            this.role = role;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in panelContent.Controls)
            {
                if (ctrl is Form frm)
                {
                    frm.Dispose();
                }
                else if (ctrl is IDisposable d)
                {
                    d.Dispose();
                }
            }

            Application.Exit();
        }

        bool menuExpand = false;
        private void menuTransaction_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                menuContainer.Height += 10;
                if (menuContainer.Height >= 270)
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
            homeUC home = new homeUC(username, role);
            panelContent.Controls.Add(home);
        }

        private void butViewReg_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            RegListForm frm = new RegListForm();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            panelContent.Controls.Add(frm);
            frm.Show();
        }

        private void butExtend_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            viewListExtensionRequest frm = new viewListExtensionRequest();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            panelContent.Controls.Add(frm);
            frm.Show();
        }

        private void butPayment_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            OriginalPayment frm = new OriginalPayment();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            panelContent.Controls.Add(frm);
            frm.Show();
        }

        private void butViewRegulation_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            RegulationsView frm = new RegulationsView();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            panelContent.Controls.Add(frm);
            frm.Show();
        }

        private void butPaymentUnit_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            OrganizationPayment frm = new OrganizationPayment();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            panelContent.Controls.Add(frm);
            frm.Show();
        }

        private void butLogout_Click(object sender, EventArgs e)
        {
            Login LoginForm = new Login();
            this.Hide();
            LoginForm.Show();
        }
    }
}
