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

namespace exam_registration_system.MainForms.NVNL
{
    public partial class HomeNVNLForm : Form
    {
        public HomeNVNLForm()
        {
            InitializeComponent();
        }

        bool menuExpand = false;

        private void menuTransaction_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                menuContainer.Height += 10;
                if (menuContainer.Height >= 180)
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

        private void ButHome_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            homeUC home = new homeUC();
            panelContent.Controls.Add(home);
        }

        private void butViewSheet_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            viewSpreadsheetForm frm = new viewSpreadsheetForm();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            panelContent.Controls.Add(frm);
            frm.Show();
        }

        private void butHandleExtend_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            ExtensionReceiveForm frm = new ExtensionReceiveForm();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            panelContent.Controls.Add(frm);
            frm.Show();
        }

        private void butRecordCertificate_Click(object sender, EventArgs e)
        {
            panelContent.Controls.Clear();
            recordCertificateInfoForm rci = new recordCertificateInfoForm();
            rci.TopLevel = false;
            rci.FormBorderStyle = FormBorderStyle.None;
            rci.Dock = DockStyle.Fill;
            panelContent.Controls.Add(rci);
            rci.Show();
        }

        private void panelContent_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
