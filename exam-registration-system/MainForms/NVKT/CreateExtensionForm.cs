using System;
using System.Data;
using System.Windows.Forms;
using exam_registration_system.Utils;
using exam_registration_system.Business;

namespace exam_registration_system.MainForms.NVKT
{
    public partial class CreateExtensionForm : Form
    {
        private string maPGH;

        public CreateExtensionForm(string maPhieuGiaHan)
        {
            InitializeComponent();
            maPGH = maPhieuGiaHan?.Trim();
            if (string.IsNullOrWhiteSpace(maPGH))
            {
                this.Close();
                return;
            }

            maPGH = maPGH.PadRight(5, ' ');
            SqlServerHelper.SetConnectionWindowsAuth();
            if (!SqlServerHelper.TestConnection())
            {
                this.Close();
                return;
            }

            tbFullName.ReadOnly = true;
            guna2TextBox2.ReadOnly = true;
            guna2TextBox3.ReadOnly = true;
            guna2TextBox1.ReadOnly = false;

            LoadExtensionDetails();
        }

        private void LoadExtensionDetails()
        {
            if (string.IsNullOrWhiteSpace(maPGH.Trim()))
                return;

            DataTable dt = ExtensionFormService.GetExtensionDetails(maPGH);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                tbFullName.Text = row["MaPhieuDuThi"]?.ToString().Trim() ?? "";
                guna2TextBox2.Text = row["LoaiGH"]?.ToString().Trim() ?? "";
                guna2TextBox3.Text = row["ThoiGian"] != DBNull.Value ? Convert.ToDateTime(row["ThoiGian"]).ToString("dd/MM/yyyy HH:mm") : "";
                guna2TextBox1.Text = "";
            }
        }

        private void btnLapPhieuClick
            (object sender, EventArgs e)
        {
            try
            {
                string formattedMaPGH = maPGH.PadRight(5, ' ');
                decimal phiGiaHan;
                if (!decimal.TryParse(guna2TextBox1.Text, out phiGiaHan))
                    phiGiaHan = 0;

                ExtensionFormService.SaveExtension(formattedMaPGH, phiGiaHan);
                MessageBox.Show("Lập phiếu thành công cho MaPGH: " + maPGH.Trim(), "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu phiếu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkThanhToan
            (object sender, EventArgs e)
        {
            if (Xacnhan.Checked)
            {
                BtnLapPhieu.Enabled = true;
                BtnLapPhieu.FillColor = System.Drawing.Color.FromArgb(94, 148, 255);
            }
            else
            {
                BtnLapPhieu.Enabled = false;
                BtnLapPhieu.FillColor = System.Drawing.Color.DarkGray;
            }
        }

        private void labelFullName_Click(object sender, EventArgs e)
        {

        }
    }
}
