using exam_registration_system.MainForms.NVTN;
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
    public partial class recordCertificateInfoForm : Form
    {
        public recordCertificateInfoForm()
        {
            InitializeComponent();
        }

        private void recordCertificateInfoForm_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewCandidates_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnSendResult_Click(object sender, EventArgs e)
        {
            // Mở form viewDetailCard và truyền MaPDK, TrangThaiXuatPDT
            sendCerResult scr = new sendCerResult();
            scr.ShowDialog();
        }
    }
}
