using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using exam_registration_system.Utils;

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

            // Set textboxes to read-only except for guna2TextBox1 (PhiGiaHan)
            tbFullName.ReadOnly = true;
            guna2TextBox2.ReadOnly = true;
            guna2TextBox3.ReadOnly = true;
            guna2TextBox1.ReadOnly = false; // Allow editing for PhiGiaHan

            LoadExtensionDetails();
        }

        private void LoadExtensionDetails()
        {
            if (string.IsNullOrWhiteSpace(maPGH.Trim()))
                return;

            DataTable dt = ExecuteStoredProcedure("sp_GetExtensionDetails", new SqlParameter("@MaPGH", SqlDbType.Char, 5) { Value = maPGH });

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                tbFullName.Text = row["MaPhieuDuThi"]?.ToString().Trim() ?? "";
                guna2TextBox2.Text = row["LoaiGH"]?.ToString().Trim() ?? "";
                guna2TextBox3.Text = row["ThoiGian"] != DBNull.Value ? Convert.ToDateTime(row["ThoiGian"]).ToString("dd/MM/yyyy HH:mm") : "";
                guna2TextBox1.Text = "";
            }
        }

        private DataTable ExecuteStoredProcedure(string storedProcedureName, params SqlParameter[] parameters)
        {
            using (SqlConnection conn = new SqlConnection(GlobalInfo.ConnectionString))
            {
                conn.Open();
                using (var cmd = new SqlCommand(storedProcedureName, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    if (parameters != null)
                        cmd.Parameters.AddRange(parameters);

                    using (var da = new SqlDataAdapter(cmd))
                    {
                        var dt = new DataTable();
                        da.Fill(dt);
                        return dt;
                    }
                }
            }
        }

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                string formattedMaPGH = maPGH.PadRight(5, ' ');
                decimal phiGiaHan;
                if (!decimal.TryParse(guna2TextBox1.Text, out phiGiaHan))
                    phiGiaHan = 0;

                SqlParameter[] parameters = new SqlParameter[]
                {
                    new SqlParameter("@MaPGH", SqlDbType.Char, 5) { Value = formattedMaPGH },
                    new SqlParameter("@PhiGiaHan", SqlDbType.Decimal) { Value = phiGiaHan },
                };

                ExecuteStoredProcedure("sp_SaveExtension", parameters);
                MessageBox.Show("Lập phiếu thành công cho MaPGH: " + maPGH.Trim(), "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi khi lưu phiếu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void butCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (Xacnhan.Checked)
            {
                guna2Button2.Enabled = true;
                guna2Button2.FillColor = System.Drawing.Color.FromArgb(94, 148, 255); // Màu xanh chuẩn của Guna2
            }
            else
            {
                guna2Button2.Enabled = false;
                guna2Button2.FillColor = System.Drawing.Color.DarkGray;
            }
        }


    }
}