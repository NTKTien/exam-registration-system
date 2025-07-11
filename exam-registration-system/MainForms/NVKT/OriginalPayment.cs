using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using exam_registration_system.Utils;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using System.Diagnostics;
using System.IO;
using System.Drawing;
using exam_registration_system.Business;

namespace exam_registration_system.MainForms.NVKT
{
    public partial class OriginalPayment : Form
    {
        private readonly string _placeholderText = "Nhập tìm phiếu đăng ký";
        private Color _placeholderColor = SystemColors.GrayText;
        private Color _defaultForeColor;

        private readonly Color colorMoney = Color.FromArgb(41, 128, 185);
        private readonly Color colorSupport = Color.FromArgb(41, 128, 185);
        private readonly Color colorFinal = Color.FromArgb(231, 76, 60);

        private string currentMaHD = "";
        private decimal totalCost = 0;
        private decimal subsidy = 0;
        private decimal finalCost = 0;

        public OriginalPayment()
        {
            InitializeComponent();

            _defaultForeColor = tbRegistrationID.ForeColor;

            tbRegistrationID.GotFocus += TbRegistrationID_GotFocus;
            tbRegistrationID.LostFocus += TbRegistrationID_LostFocus;

            btnSearch.Click += btnSearch_Click;
            btnConfirmPayment.Click += btnConfirmPayment_Click;
            btnCreateInvoice.Click += btnCreateInvoice_Click;

            ClearForm();
            SetPlaceholder();
        }

        private void TbRegistrationID_GotFocus(object sender, EventArgs e)
        {
            if (tbRegistrationID.Text == _placeholderText)
            {
                tbRegistrationID.Text = "";
                tbRegistrationID.ForeColor = _defaultForeColor;
            }
        }

        private void TbRegistrationID_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbRegistrationID.Text))
            {
                SetPlaceholder();
            }
        }

        private void SetPlaceholder()
        {
            tbRegistrationID.Text = _placeholderText;
            tbRegistrationID.ForeColor = _placeholderColor;
        }

        private bool IsPlaceholder()
        {
            return tbRegistrationID.Text == _placeholderText;
        }

        private decimal GetFreeCusCos(string loaiCC)
        {
            string searchContent = "";
            if (loaiCC == "Tin học")
                searchContent = "Lệ phí thi Tin học của khách hàng tự do";
            else if (loaiCC == "Ngoại ngữ")
                searchContent = "Lệ phí thi Ngoại ngữ của khách hàng tự do";
            else
                return 0;

            decimal? giaTri = RegulationService.GetMostRelevantGiaTri(searchContent);
            return giaTri ?? 0;
        }

        private decimal GetFreeCusSubsidy()
        {
            decimal? giaTri = RegulationService.GetMostRelevantGiaTri("trợ giá lệ phí thi cho khách hàng tự do");
            return giaTri ?? 0;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            ClearCustomerFields();
            ClearChiPhiFields();
            currentMaHD = "";
            totalCost = 0;
            subsidy = 0;
            finalCost = 0;

            if (IsPlaceholder() || string.IsNullOrWhiteSpace(tbRegistrationID.Text))
            {
                MessageBox.Show("Vui lòng nhập mã phiếu đăng ký!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maPDK = tbRegistrationID.Text.Trim();

            if (maPDK.Length > 5)
            {
                MessageBox.Show("Mã phiếu đăng ký không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataTable regDT = PhieuDangKyService.SearchRegistration(maPDK: maPDK);
            if (regDT == null || regDT.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy phiếu đăng ký!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                return;
            }

            DataRow regRow = regDT.Rows[0];
            string loaiPDK = regRow["LoaiPDK"]?.ToString();
            if (loaiPDK == "KHĐV")
            {
                MessageBox.Show("Vui lòng thực hiện thanh toán cho khách hàng đơn vị ở màn hình khác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearForm();
                return;
            }

            DateTime ngayLap = Convert.ToDateTime(regRow["NgayLap"]);
            DateTime now = DateTime.Now.Date;
            DateTime expiryDate = ngayLap.AddDays(3).Date;
            DateTime cancelDate = ngayLap.AddDays(4).Date;

            string currentStatus = regRow.Table.Columns.Contains("TrangThai") ? regRow["TrangThai"]?.ToString() : regRow["TrangThaiThanhToan"]?.ToString();

            bool isExpired = now >= cancelDate;

            if (isExpired && currentStatus != "Đã hủy" && currentStatus != "Đã thanh toán")
            {
                try
                {
                    bool updateStatus = PhieuDangKyService.UpdateRegistration(maPDK: maPDK, trangThai: "Đã hủy");
                    if (updateStatus)
                    {
                        tbStatus.Text = "Đã hủy";
                        MessageBox.Show("Phiếu đăng ký này đã quá hạn thanh toán (quá 3 ngày kể từ ngày lập) nên đã được tự động chuyển sang trạng thái 'Đã hủy'.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Không thể cập nhật trạng thái phiếu đăng ký sang 'Đã hủy'.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi cập nhật trạng thái phiếu đăng ký: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                currentStatus = "Đã hủy";
            }

            DataTable cusDT = CustomerService.SearchRegistor(maPDK: maPDK);
            string tenKH = "";
            if (cusDT != null && cusDT.Rows.Count > 0)
                tenKH = cusDT.Rows[0]["HoTen"]?.ToString();

            tbCustomerName.Text = tenKH;
            tbRegistrationDate.Text = ngayLap.ToString("dd/MM/yyyy");
            tbExpiryDate.Text = expiryDate.ToString("dd/MM/yyyy");
            tbStatus.Text = currentStatus;
            tbCertificateType.Text = regRow["LoaiCC"]?.ToString();

            string loaiCC = regRow["LoaiCC"]?.ToString();

            DataTable hdDT = InvoiceService.SearchInvoice(maPDK: maPDK);
            if (hdDT != null && hdDT.Rows.Count > 0)
            {
                DataRow hdRow = hdDT.Rows[0];
                currentMaHD = hdRow["MaHD"]?.ToString() ?? "";

                try
                {
                    totalCost = GetFreeCusCos(loaiCC);
                    subsidy = GetFreeCusSubsidy();
                    finalCost = totalCost - subsidy;

                    tbTotalCost.Text = totalCost.ToString("N0");
                    tbSupportAmount.Text = subsidy.ToString("N0");
                    tbFinalAmount.Text = finalCost.ToString("N0");

                    tbTotalCost.ForeColor = colorMoney;
                    tbSupportAmount.ForeColor = colorSupport;
                    tbFinalAmount.ForeColor = colorFinal;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Xảy ra lỗi khi tính toán hóa đơn: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ClearChiPhiFields();
                    return;
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy hóa đơn của phiếu đăng ký", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearCustomerFields()
        {
            tbCustomerName.Text = "";
            tbRegistrationDate.Text = "";
            tbExpiryDate.Text = "";
            tbStatus.Text = "";
            tbCertificateType.Text = "";
        }
        private void ClearChiPhiFields()
        {
            tbTotalCost.Text = "";
            tbSupportAmount.Text = "";
            tbFinalAmount.Text = "";

            tbTotalCost.ForeColor = colorMoney;
            tbSupportAmount.ForeColor = colorSupport;
            tbFinalAmount.ForeColor = colorFinal;
        }

        private void ClearForm()
        {
            ClearCustomerFields();
            ClearChiPhiFields();

            tbRegistrationID.Text = "";
            SetPlaceholder();

            currentMaHD = "";
            totalCost = 0;
            subsidy = 0;
            finalCost = 0;
            totalCost = 0;
            subsidy = 0;
            finalCost = 0;
        }

        private void btnConfirmPayment_Click(object sender, EventArgs e)
        {
            if (IsPlaceholder() || string.IsNullOrWhiteSpace(tbRegistrationID.Text))
            {
                MessageBox.Show("Vui lòng tìm phiếu đăng ký trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string maPDK = tbRegistrationID.Text.Trim();

            string trangThai = tbStatus.Text.Trim();
            if (string.IsNullOrEmpty(trangThai))
            {
                MessageBox.Show("Vui lòng tìm phiếu đăng ký trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (trangThai != "Chưa thanh toán")
            {
                MessageBox.Show($"Không thể xác nhận thanh toán!\nTrạng thái hiện tại của phiếu: {trangThai}", "Không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("Chắc chắn xác nhận thanh toán cho phiếu đăng ký " + maPDK + "?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    bool updateInvoice = false;
                    if (!string.IsNullOrEmpty(currentMaHD))
                    {
                        updateInvoice = InvoiceService.UpdateInvoice(
                            maHD: currentMaHD,
                            tongTien: totalCost,
                            troGia: subsidy,
                            thanhTien: finalCost,
                            maPDK: maPDK
                        );
                    }
                    bool updatePDK = PhieuDangKyService.UpdateRegistration(maPDK: maPDK, trangThai: "Đã thanh toán");
                    if (updatePDK && (string.IsNullOrEmpty(currentMaHD) || updateInvoice))
                    {
                        tbStatus.Text = "Đã thanh toán";
                        MessageBox.Show("Thanh toán thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Không thể cập nhật trạng thái hoặc hóa đơn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi cập nhật dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnCreateInvoice_Click(object sender, EventArgs e)
        {
            if (IsPlaceholder() || string.IsNullOrWhiteSpace(tbRegistrationID.Text))
            {
                MessageBox.Show("Vui lòng tìm phiếu đăng ký trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string trangThai = tbStatus.Text.Trim();
            if (string.IsNullOrEmpty(trangThai))
            {
                MessageBox.Show("Vui lòng tìm phiếu đăng ký trước!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (trangThai != "Đã thanh toán")
            {
                MessageBox.Show($"Chỉ xuất hóa đơn khi phiếu đã thanh toán!\nTrạng thái hiện tại: {trangThai}", "Không hợp lệ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(currentMaHD))
            {
                MessageBox.Show("Không tìm thấy hóa đơn để xuất cho phiếu này!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ExportInvoicePDF(
                currentMaHD,
                tbRegistrationID.Text.Trim(),
                totalCost,
                subsidy,
                finalCost
            );
        }
        private void ExportInvoicePDF(string maHD, string maPDK, decimal tongTien, decimal troGia, decimal thanhTien)
        {
            string tenKH = tbCustomerName.Text;
            string loaiCC = tbCertificateType.Text;
            string ngayLap = DateTime.Now.ToString("dd/MM/yyyy");

            // Tạo tài liệu PDF
            PdfDocument doc = new PdfDocument();
            doc.Info.Title = "HÓA ĐƠN THANH TOÁN";
            PdfPage page = doc.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);

            XFont fontHeader = new XFont("Arial", 18, XFontStyleEx.Bold);
            XFont fontSubtitle = new XFont("Arial", 10, XFontStyleEx.Regular);
            XFont fontLabel = new XFont("Arial", 12, XFontStyleEx.Regular);
            XFont fontLabelBold = new XFont("Arial", 12, XFontStyleEx.Bold);
            XFont fontRed = new XFont("Arial", 12, XFontStyleEx.Bold);
            XBrush brushRed = new XSolidBrush(XColor.FromArgb(231, 76, 60));
            XFont fontBlue = new XFont("Arial", 12, XFontStyleEx.Bold);
            XBrush brushBlue = new XSolidBrush(XColor.FromArgb(41, 128, 185));
            XFont fontSmall = new XFont("Arial", 10, XFontStyleEx.Regular);

            double y = 40;
            double left = 90;
            double right = page.Width - 90;

            gfx.DrawString("Trung tâm tổ chức thi chứng chỉ anh ngữ và tin học ACCI", fontLabelBold, XBrushes.Black, new XRect(0, y, page.Width, 30), XStringFormats.TopCenter);
            y += 35;

            gfx.DrawString("HÓA ĐƠN THANH TOÁN", fontHeader, XBrushes.Black, new XRect(0, y, page.Width, 30), XStringFormats.TopCenter);
            y += 30;

            gfx.DrawString("(thu lệ phí thi)", fontSubtitle, XBrushes.Black, new XRect(0, y, page.Width, 15), XStringFormats.TopCenter);
            y += 30;

            double labelX = left;
            double valueX = left + 130;
            double rightLabelX = left + 320;
            double rightValueX = left + 370;
            double lineSpacing = 28;

            gfx.DrawString("Mã hóa đơn:", fontLabel, XBrushes.Black, labelX, y);
            gfx.DrawString(maHD, fontLabelBold, brushRed, valueX, y);
            y += lineSpacing;

            gfx.DrawString("Khách hàng:", fontLabel, XBrushes.Black, labelX, y);
            gfx.DrawString(tenKH, fontLabelBold, XBrushes.Black, valueX, y);
            y += lineSpacing - 8;

            gfx.DrawString("Mã phiếu đăng ký:", fontLabel, XBrushes.Black, labelX, y);
            gfx.DrawString(maPDK, fontLabelBold, XBrushes.Black, valueX, y);
            y += lineSpacing - 8;

            gfx.DrawString("Nội dung thu:", fontLabel, XBrushes.Black, labelX, y);
            gfx.DrawString($"Lệ phí thi chứng chỉ {loaiCC}", fontLabelBold, XBrushes.Black, valueX, y);
            y += lineSpacing - 8;

            gfx.DrawString("Tổng chi phí:", fontLabel, XBrushes.Black, labelX, y);
            gfx.DrawString($"{tongTien:N0} VNĐ", fontBlue, brushBlue, valueX, y);

            gfx.DrawString("Trợ giá:", fontLabel, XBrushes.Black, rightLabelX, y);
            gfx.DrawString($"{troGia:N0} VNĐ", fontBlue, brushBlue, rightValueX, y);
            y += lineSpacing - 8;

            gfx.DrawString("Số tiền thu:", fontLabel, XBrushes.Black, labelX, y);
            gfx.DrawString($"{thanhTien:N0} VNĐ", fontLabelBold, brushRed, valueX, y);
            y += lineSpacing - 8;

            gfx.DrawString("Hình thức thanh toán:", fontLabel, XBrushes.Black, labelX, y);
            gfx.DrawString("Tiền mặt hoặc chuyển khoản", fontLabel, XBrushes.Black, valueX, y);
            y += lineSpacing - 8;

            gfx.DrawString("Ngày lập: ", fontLabel, XBrushes.Black, labelX, y);
            gfx.DrawString(ngayLap, fontLabel, XBrushes.Black, valueX, y);
            y += lineSpacing + 20;

            double signBoxWidth = 180;
            double signBoxHeight = 40;
            double signY = y + 10;
            double pageCenter = page.Width / 2.0;
            double offset = 120;

            double signLeft = pageCenter - offset - signBoxWidth / 2;
            gfx.DrawString("Người nộp tiền", fontLabel, XBrushes.Black, new XRect(signLeft, signY, signBoxWidth, 20), XStringFormats.TopCenter);
            gfx.DrawString("(Ký, ghi rõ họ tên)", fontSmall, XBrushes.Black, new XRect(signLeft, signY + 18, signBoxWidth, 20), XStringFormats.TopCenter);

            double signRight = pageCenter + offset - signBoxWidth / 2;
            gfx.DrawString("Người thu tiền", fontLabel, XBrushes.Black, new XRect(signRight, signY, signBoxWidth, 20), XStringFormats.TopCenter);
            gfx.DrawString("(Ký, ghi rõ họ tên)", fontSmall, XBrushes.Black, new XRect(signRight, signY + 18, signBoxWidth, 20), XStringFormats.TopCenter);

            // Lưu file và mở
            string folder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "HoaDonPDF");
            if (!Directory.Exists(folder)) Directory.CreateDirectory(folder);
            string filePath = Path.Combine(folder, $"HoaDon_{maHD}_{maPDK}.pdf");
            doc.Save(filePath);
            Process.Start(new ProcessStartInfo(filePath) { UseShellExecute = true });
        }
    }
}