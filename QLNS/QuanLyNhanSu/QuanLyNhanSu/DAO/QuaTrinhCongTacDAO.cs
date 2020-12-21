using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.DAO
{
    public class QuaTrinhCongTacDAO
    {
        public static DataTable LoadQuaTrinhCongTac(int idnv)
        {
            string query = "select * from quatrinhcongtac where nhanvienid = " + idnv + "";

            return SqlServerHelper.ExecuteQuery(query);
        }
        public static int InsertQTCT(int idnv, DateTime tgbatdau, DateTime tgketthuc, string noidung)
        {
            string query = "INSERTQUATRINHCONGTAC @IDNV , @TGBATDAU , @TGKETTHUC , @NOIDUNG ";

            return SqlServerHelper.ExecuteNonQuery(query, new object[] { idnv, tgbatdau, tgketthuc, noidung });
        }
        public static int UpdateQTCT(int idqtct, int idnv, DateTime tgbatdau, DateTime tgketthuc, string noidung)
        {
            string query = "UPDATEQUATRINHCONGTAC @IDQTCT , @IDNV , @TGBATDAU , @TGKETTHUC , @NOIDUNG ";

            return SqlServerHelper.ExecuteNonQuery(query, new object[] { idqtct, idnv, tgbatdau, tgketthuc, noidung });
        }
        public static int DeleteQTCT(int idqtct)
        {
            string query = "DELETEQUATRINHCONGTAC @IDQTCT ";

            try
            {
                return SqlServerHelper.ExecuteNonQuery(query, new object[] { idqtct });
            }
            catch
            {
                return 0;
            }
        }
    }
}
