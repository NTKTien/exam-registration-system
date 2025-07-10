using exam_registration_system.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_registration_system.Business
{
    public class ExamScheduleService
    {
        public static DataTable GetAllAvailableSchedulesByTypeCC(string loaiDGNL)
        {
            return ExamScheduleDAO.GetAllAvailableSchedulesByTypeCC(loaiDGNL);
        }

        public static DataTable GetAllAvailableSchedules()
        {
            return ExamScheduleDAO.GetAllAvailableSchedules();
        }
    }
}
