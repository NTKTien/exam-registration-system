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
            panelContent.Controls.Clear();
            homeUC home = new homeUC();
            panelContent.Controls.Add(home);
        }

        bool menuExpand = false;
        private void menuTransaction_Tick(object sender, EventArgs e)
        {

            if (menuExpand == false)
            {
                menuContainer.Height += 10;
                if (menuContainer.Height >= 327)
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

        private void butCreFreeReg_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            createdRegForm frm = new createdRegForm();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            panelContent.Controls.Add(frm);
            frm.Show();
        }

        private void butCreUnitReg_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            createdRegUnitForm frm = new createdRegUnitForm();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            panelContent.Controls.Add(frm);
            frm.Show();
        }

        private void butReleasePDT_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            releaseCard frm = new releaseCard();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            panelContent.Controls.Add(frm);
            frm.Show();
        }

        private void butViewCalendar_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            ViewExamScheduleMenu home = new ViewExamScheduleMenu();
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

        private void butViewBT_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            viewSpreadsheetForm frm = new viewSpreadsheetForm();
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

        private void butReleaseCertificateDV_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            CertificatesUnitForm frm = new CertificatesUnitForm();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            panelContent.Controls.Add(frm);
            frm.Show();
        }

        private void butReleaseCertificateCN_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            CertificatesForm frm = new CertificatesForm();
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
