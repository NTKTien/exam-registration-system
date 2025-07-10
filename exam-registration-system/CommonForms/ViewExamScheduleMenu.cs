using exam_registration_system.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exam_registration_system.CommonForms
{
    public partial class ViewExamScheduleMenu : UserControl
    {
        public ViewExamScheduleMenu()
        {
            InitializeComponent();
            LoadAvailableSchedules();
        }

        private void LoadAvailableSchedules()
        {
            DataTable dt = ExamScheduleService.GetAllAvailableSchedules();
            dgvExamSchedule.DataSource = dt;
        }
    }


}
