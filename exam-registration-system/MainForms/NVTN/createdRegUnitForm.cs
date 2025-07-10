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
    public partial class createdRegUnitForm : Form
    {
        public createdRegUnitForm()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            viewListCandidate frm = new viewListCandidate();
            frm.Show();
        }

        private void butSelectCalenderEx_Click(object sender, EventArgs e)
        {
            if (cmbTypeDGNL.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn loại ĐGNL trước!", "Thiếu thông tin", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string loaiDGNL = cmbTypeDGNL.SelectedItem.ToString();
            ViewExamSchedule frm = new ViewExamSchedule(loaiDGNL);
            frm.Show();
        }
    }
}
