using exam_registration_system.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exam_registration_system.Business
{
    public class RegulationService
    {
        public static DataTable SearchRegulation(
            string maQD = null,
            string doiTuong = null,
            string noiDung = null,
            decimal? giaTriFrom = null,
            decimal? giaTriTo = null)
        {
            return RegulationDAO.SearchRegulation(maQD, doiTuong, noiDung, giaTriFrom, giaTriTo);
        }

        public static decimal? GetMostRelevantGiaTri(string noiDungInput)
        {
            var dt = RegulationDAO.SearchRegulation(null, null, null, null, null);

            if (dt.Rows.Count == 0 || string.IsNullOrWhiteSpace(noiDungInput))
                return null;

            string[] inputWords = noiDungInput.ToLower().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            DataRow bestMatch = null;
            int maxMatchCount = -1;

            foreach (DataRow row in dt.Rows)
            {
                string rowNoiDung = row["NoiDung"]?.ToString()?.ToLower();
                if (string.IsNullOrWhiteSpace(rowNoiDung)) continue;

                int matchCount = inputWords.Count(word => rowNoiDung.Contains(word));

                if (matchCount > maxMatchCount)
                {
                    maxMatchCount = matchCount;
                    bestMatch = row;
                }
            }

            if (bestMatch != null && decimal.TryParse(bestMatch["GiaTri"]?.ToString(), out decimal giaTri))
            {
                return giaTri;
            }

            return null;
        }

    }
}
