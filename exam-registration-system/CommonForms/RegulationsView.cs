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

namespace exam_registration_system.CommonForms
{
    public partial class RegulationsView : Form
    {
        private string currentRegulationType = "DK";

        public RegulationsView()
        {
            InitializeComponent();
            InitializeEvents();
            LoadRegulations("DK");
            SetActiveButton(btnRegistrationRules);
        }

        private void InitializeEvents()
        {
            btnRegistrationRules.Click += (s, e) => LoadRegulationsByType("DK", btnRegistrationRules);
            btnPaymentRules.Click += (s, e) => LoadRegulationsByType("TT", btnPaymentRules);
            btnExtensionRules.Click += (s, e) => LoadRegulationsByType("GH", btnExtensionRules);
            btnSpecialHandling.Click += (s, e) => LoadRegulationsByType("DB", btnSpecialHandling);
            btnRefundPolicy.Click += (s, e) => LoadRegulationsByType("HT", btnRefundPolicy);

            btnSearch.Click += BtnSearch_Click;
            tbSearch.KeyPress += TbSearch_KeyPress;

            btnDownload.Click += BtnDownload_Click;
        }

        private void LoadRegulationsByType(string regulationType, Guna.UI2.WinForms.Guna2Button activeButton)
        {
            currentRegulationType = regulationType;
            LoadRegulations(regulationType);
            SetActiveButton(activeButton);
        }

        private void LoadRegulations(string regulationType)
        {
            try
            {
                string sql = @"SELECT MaQD, NoiDung, GiaTri 
                              FROM QuyDinh 
                              WHERE DoiTuong = @DoiTuong 
                              ORDER BY MaQD";

                SqlParameter[] parameters = {
                    new SqlParameter("@DoiTuong", regulationType)
                };

                DataTable dt = SqlServerHelper.ExecuteQuery(sql, parameters);

                dgvRegulations.Rows.Clear();

                foreach (DataRow row in dt.Rows)
                {
                    string maQD = row["MaQD"].ToString();
                    string noiDung = row["NoiDung"].ToString();

                    dgvRegulations.Rows.Add(maQD, noiDung);
                }
                dgvRegulations.ClearSelection();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải dữ liệu quy định: {ex.Message}",
                               "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SetActiveButton(Guna.UI2.WinForms.Guna2Button activeButton)
        {
            ResetButtonStyles();

            activeButton.FillColor = Color.FromArgb(241, 196, 15);
            activeButton.ForeColor = Color.White;
        }

        private void ResetButtonStyles()
        {
            var buttons = new[] { btnRegistrationRules, btnPaymentRules, btnExtensionRules,
                                 btnSpecialHandling, btnRefundPolicy };

            foreach (var btn in buttons)
            {
                btn.FillColor = Color.White;
                btn.ForeColor = Color.FromArgb(52, 73, 94);
            }
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            SearchRegulations();
        }

        private void TbSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                SearchRegulations();
            }
        }

        private void SearchRegulations()
        {
            string searchText = tbSearch.Text.Trim();

            if (string.IsNullOrEmpty(searchText))
            {
                LoadRegulations(currentRegulationType);
                return;
            }

            try
            {
                string sql = @"SELECT MaQD, NoiDung, GiaTri 
                              FROM QuyDinh 
                              WHERE DoiTuong = @DoiTuong 
                              AND (MaQD LIKE @SearchText OR NoiDung LIKE @SearchText)
                              ORDER BY MaQD";

                SqlParameter[] parameters = {
                    new SqlParameter("@DoiTuong", currentRegulationType),
                    new SqlParameter("@SearchText", $"%{searchText}%")
                };

                DataTable dt = SqlServerHelper.ExecuteQuery(sql, parameters);

                dgvRegulations.Rows.Clear();

                foreach (DataRow row in dt.Rows)
                {
                    string maQD = row["MaQD"].ToString();
                    string noiDung = row["NoiDung"].ToString();

                    dgvRegulations.Rows.Add(maQD, noiDung);
                }

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy quy định nào phù hợp!",
                                   "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tìm kiếm: {ex.Message}",
                               "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnDownload_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvRegulations.Rows.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu để tải xuống!",
                                   "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Create SaveFileDialog
                SaveFileDialog saveDialog = new SaveFileDialog
                {
                    Filter = "Excel Files|*.xlsx|CSV Files|*.csv|Text Files|*.txt",
                    Title = "Lưu danh sách quy định",
                    FileName = $"QuyDinh_{GetRegulationTypeCode(currentRegulationType)}_{DateTime.Now:yyyyMMdd}"
                };

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    string extension = System.IO.Path.GetExtension(saveDialog.FileName).ToLower();

                    switch (extension)
                    {
                        case ".csv":
                            ExportToCSV(saveDialog.FileName);
                            break;
                        case ".txt":
                            ExportToText(saveDialog.FileName);
                            break;
                        default:
                            MessageBox.Show("Hiện tại chỉ hỗ trợ xuất file CSV và TXT!",
                                           "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tải xuống: {ex.Message}",
                               "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetRegulationTypeCode(string regulationType)
        {
            switch (regulationType)
            {
                case "DK": return "DangKy";
                case "TT": return "ThanhToan";
                case "GH": return "GiaHan";
                case "DB": return "DacBiet";
                case "HT": return "HoanTien";
                default: return "QuyDinh";
            }
        }

        private void ExportToCSV(string fileName)
        {
            StringBuilder csv = new StringBuilder();
            csv.AppendLine("Mã Quy Định,Nội Dung");

            foreach (DataGridViewRow row in dgvRegulations.Rows)
            {
                if (row.IsNewRow) continue;

                string maQD = row.Cells["RegulationID"].Value?.ToString() ?? "";
                string noiDung = row.Cells["RegulationContent"].Value?.ToString() ?? "";

                noiDung = noiDung.Replace("\"", "\"\"");
                if (noiDung.Contains(",") || noiDung.Contains("\"") || noiDung.Contains("\n"))
                {
                    noiDung = $"\"{noiDung}\"";
                }

                csv.AppendLine($"{maQD},{noiDung}");
            }

            System.IO.File.WriteAllText(fileName, csv.ToString(), Encoding.UTF8);
            MessageBox.Show($"Đã xuất dữ liệu ra file: {fileName}",
                           "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ExportToText(string fileName)
        {
            StringBuilder txt = new StringBuilder();
            txt.AppendLine($"DANH SÁCH QUY ĐỊNH");
            txt.AppendLine($"Ngày xuất: {DateTime.Now:dd/MM/yyyy HH:mm:ss}");
            txt.AppendLine(new string('=', 80));

            foreach (DataGridViewRow row in dgvRegulations.Rows)
            {
                if (row.IsNewRow) continue;

                string maQD = row.Cells["RegulationID"].Value?.ToString() ?? "";
                string noiDung = row.Cells["RegulationContent"].Value?.ToString() ?? "";

                txt.AppendLine($"Mã: {maQD}");
                txt.AppendLine($"Nội dung: {noiDung}");
                txt.AppendLine(new string('-', 40));
            }

            System.IO.File.WriteAllText(fileName, txt.ToString(), Encoding.UTF8);
            MessageBox.Show($"Đã xuất dữ liệu ra file: {fileName}",
                           "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public void RefreshData()
        {
            LoadRegulations(currentRegulationType);
        }

        public void LoadSpecificRegulation(string regulationType)
        {
            if (new[] { "DK", "TT", "GH", "DB", "HT" }.Contains(regulationType))
            {
                LoadRegulations(regulationType);
                currentRegulationType = regulationType;

                switch (regulationType)
                {
                    case "DK": SetActiveButton(btnRegistrationRules); break;
                    case "TT": SetActiveButton(btnPaymentRules); break;
                    case "GH": SetActiveButton(btnExtensionRules); break;
                    case "DB": SetActiveButton(btnSpecialHandling); break;
                    case "HT": SetActiveButton(btnRefundPolicy); break;
                }
            }
        }
    }
}