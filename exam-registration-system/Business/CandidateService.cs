using exam_registration_system.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exam_registration_system.Business
{
    public class CandidateService
    {
        public static string AddCandidate(
        string hoTen,
        string gioiTinh,
        DateTime ngaySinh,
        string soDienThoai,
        string cccd,
        string email)
        {
            // Gọi DAO, nhận MaDS vừa tạo
            return CandidateDAO.InsertCandidate(
                hoTen,
                gioiTinh,
                ngaySinh,
                soDienThoai,
                cccd,
                email
            );
        }

        // Lấy thông tin thí sinh theo mã phiếu đăng ký
        public static DataTable GetCandidateByMaPDK(string maPDK)
        {
            return CandidateDAO.GetCandidateByMaPDK(maPDK);
        }

    }
}
