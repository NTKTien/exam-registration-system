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
    public partial class createdRegForm : Form
    {
        public createdRegForm()
        {
            InitializeComponent();
        }

        private void butSelectCalenderEx_Click(object sender, EventArgs e)
        {
            ViewExamSchedule frm = new ViewExamSchedule();
            frm.Show();
        }
    }
}
