using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using exam_registration_system.MainForms.NVKT;
using exam_registration_system.MainForms.NVNL;
using exam_registration_system.MainForms.NVTN;
using System.Data.SqlClient;
using exam_registration_system.Business;

namespace exam_registration_system.CommonForms
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            tbPassword.UseSystemPasswordChar = true;
        }

        private void btnLogin_MouseEnter(object sender, EventArgs e)
        {
            btnLogin.BackColor = ColorTranslator.FromHtml("#2980B9");
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.BackColor = ColorTranslator.FromHtml("#3498DB");
        }

        private void pnlUsername_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Rectangle bounds = pnlUsername.ClientRectangle;
            int radius = 10;

            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(bounds.X, bounds.Y, radius, radius, 180, 90);
                path.AddArc(bounds.Right - radius, bounds.Y, radius, radius, 270, 90);
                path.AddArc(bounds.Right - radius, bounds.Bottom - radius, radius, radius, 0, 90);
                path.AddArc(bounds.X, bounds.Bottom - radius, radius, radius, 90, 90);
                path.CloseFigure();

                using (Pen pen = new Pen(ColorTranslator.FromHtml("#34495E"), 1.2f))
                {
                    g.DrawPath(pen, path);
                }
            }
        }

        private void pnlPassword_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            Rectangle bounds = pnlUsername.ClientRectangle;
            int radius = 10;

            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddArc(bounds.X, bounds.Y, radius, radius, 180, 90);
                path.AddArc(bounds.Right - radius, bounds.Y, radius, radius, 270, 90);
                path.AddArc(bounds.Right - radius, bounds.Bottom - radius, radius, radius, 0, 90);
                path.AddArc(bounds.X, bounds.Bottom - radius, radius, radius, 90, 90);
                path.CloseFigure();

                using (Pen pen = new Pen(ColorTranslator.FromHtml("#34495E"), 1.2f))
                {
                    g.DrawPath(pen, path);
                }
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text.Trim();
            string password = tbPassword.Text;

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string loaiNV = EmployeeService.CheckLogin(username);

            if (loaiNV == null || username.Length > 5 || username.Length < 5)
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác, kiểm tra lại.", "Lỗi đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Form nextForm = null;
            switch (loaiNV)
            {
                case "TN":
                    nextForm = new HomeNVTNForm(username, loaiNV);
                    break;
                case "KT":
                    nextForm = new HomeNVKTForm(username, loaiNV);
                    break;
                case "NL":
                    nextForm = new HomeNVNLForm(username, loaiNV);
                    break;
                default:
                    MessageBox.Show("Đăng nhập thất bại, kiểm tra lại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }
            this.Hide();
            nextForm.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
