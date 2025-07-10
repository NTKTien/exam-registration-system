using exam_registration_system.Business;
using exam_registration_system.CommonForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using exam_registration_system.Utils;
using System.Text.RegularExpressions;

namespace exam_registration_system.MainForms.NVTN
{
    public partial class viewDetailCard : Form
    {
        private string MaPDK;
        private string TrangThaiXuatPDT;
        private releaseCard parentForm;

        public viewDetailCard(string maPDK, string trangThaiXuatPDT, releaseCard parent = null)
        {
            InitializeComponent();
            MaPDK = maPDK;
            TrangThaiXuatPDT = trangThaiXuatPDT;
            parentForm = parent;
        }

        private void tbLocation_TextChanged(object sender, EventArgs e)
        {

        }

        private void DateTimePickerDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void viewDetailCard_Load(object sender, EventArgs e)
        {

            // Đặt padding để tránh cắt nội dung
            lbMaPDT.Padding = new Padding(2);
            lbID.Padding = new Padding(2);
            lbName.Padding = new Padding(2);
            lbDate.Padding = new Padding(2);
            lbType.Padding = new Padding(2);
            lbLocation.Padding = new Padding(2);
            lbDate.Padding= new Padding(2);
            

            // Gọi stored procedure dựa trên TrangThaiXuatPDT
            if (TrangThaiXuatPDT == "Đã xuất PDT")
            {
                LoadPhieuDuThi();
                lbMaPDT.Visible = true;
                txtboxMaPDT.Visible = true;
                lbID.Visible = true;
                tbID.Visible = true;
                btnIssueCard.Visible = false;
            }
            else if (TrangThaiXuatPDT == "Chưa xuất PDT")
            {
                LoadPhieuDangKy();
                lbMaPDT.Visible = false;
                txtboxMaPDT.Visible = false;
                lbID.Visible = false;
                tbID.Visible = false;
                btnIssueCard.Visible = true;
            }
            else
            {
                MessageBox.Show("Trạng thái Xuất PDT không hợp lệ.", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void LoadPhieuDuThi()
        {
            try
            {
                DataTable dt = viewDetailCardBS.GetPhieuDuThi(MaPDK);
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    txtboxMaPDT.Text = row["MaPDT"]?.ToString();
                    tbID.Text = row["SBD"]?.ToString();
                    tbName.Text = row["TenHienThi"]?.ToString();
                    tbType.Text = row["Loaidgnl"]?.ToString();
                    tbLocation.Text = row["DiaDiem"]?.ToString();
                    if (DateTime.TryParse(row["ThoiGian"]?.ToString(), out DateTime thoiGian))
                    {
                        DateTimePickerDate.Value = thoiGian;
                    }
                    else
                    {
                        DateTimePickerDate.Value = DateTime.Now;
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy dữ liệu cho Phiếu Dự Thi.", "Cảnh báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu Phiếu Dự Thi: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void LoadPhieuDangKy()
        {
            try
            {
                DataTable dt = viewDetailCardBS.GetPhieuDangKy(MaPDK);
                if (dt.Rows.Count > 0)
                {
                    DataRow row = dt.Rows[0];
                    tbName.Text = row["TenHienThi"]?.ToString();
                    tbType.Text = row["Loaidgnl"]?.ToString();
                    tbLocation.Text = row["DiaDiem"]?.ToString();
                    if (DateTime.TryParse(row["Ngaythi"]?.ToString(), out DateTime ngayThi))
                    {
                        DateTimePickerDate.Value = ngayThi;
                    }
                    else
                    {
                        DateTimePickerDate.Value = DateTime.Now;
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy dữ liệu cho Phiếu Đăng Ký.", "Cảnh báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu Phiếu Đăng Ký: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void btnIssueCard_Click(object sender, EventArgs e)
        {
            try
            {
                bool success = viewDetailCardBS.IssuePhieuDuThi(MaPDK);
                if (success)
                {
                    TrangThaiXuatPDT = "Đã xuất PDT";
                    LoadPhieuDuThi();
                    lbMaPDT.Visible = true;
                    txtboxMaPDT.Visible = true;
                    lbID.Visible = true;
                    tbID.Visible = true;
                    btnIssueCard.Visible = false;
                    MessageBox.Show("Phát hành Phiếu Dự Thi thành công!", "Thành công",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi phát hành Phiếu Dự Thi: {ex.Message}", "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtboxMaPDT_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbID_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbType_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // Làm mới dữ liệu trong form releaseCard nếu có
            if (parentForm != null && !parentForm.IsDisposed)
            {
                parentForm.LoadData();
            }
            this.Close();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
