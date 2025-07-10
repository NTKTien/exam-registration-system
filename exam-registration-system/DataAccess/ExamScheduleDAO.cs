using exam_registration_system.Utils;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_registration_system.DataAccess
{
    public class ExamScheduleDAO
    {
        public static DataTable GetAllAvailableSchedulesByTypeCC(string loaiDGNL)
        {
            using (SqlConnection conn = new SqlConnection(GlobalInfo.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_GetAllExamScheduleByTypeCC", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@LoaiDGNL", loaiDGNL);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }

        public static DataTable GetAllAvailableSchedules()
        {
            using (SqlConnection conn = new SqlConnection(GlobalInfo.ConnectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_GetAllExamSchedule", conn);
                cmd.CommandType = CommandType.StoredProcedure;

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
        }
    }
}
