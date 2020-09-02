using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.DAO
{
    public class QuaTrinhHocTapDAO
    {
        public static DataTable LoadQuaTrinhHocTap(int idnv)
        {
            string query = "select * from quatrinhhoctap where nhanvienid = " + idnv + "";

            return SqlServerHelper.ExecuteQuery(query);
        }
        public static int InsertQTHT(int idnv, DateTime tgbatdau, DateTime tgketthuc, string noidung)
        {
            string query = "INSERTQUATRINHHOCTAP @IDNV , @TGBATDAU , @TGKETTHUC , @NOIDUNG ";

            return SqlServerHelper.ExecuteNonQuery(query, new object[] { idnv, tgbatdau, tgketthuc, noidung });
        }
        public static int UpdateQTHT(int idQTHT, int idnv, DateTime tgbatdau, DateTime tgketthuc, string noidung)
        {
            string query = "UPDATEQUATRINHHOCTAP @IDQTHT , @IDNV , @TGBATDAU , @TGKETTHUC , @NOIDUNG ";

            return SqlServerHelper.ExecuteNonQuery(query, new object[] { idQTHT, idnv, tgbatdau, tgketthuc, noidung });
        }
        public static int DeleteQTHT(int idQTHT)
        {
            string query = "DELETEQUATRINHHOCTAP @IDQTHT ";

            try
            {
                return SqlServerHelper.ExecuteNonQuery(query, new object[] { idQTHT });
            }
            catch
            {
                return 0;
            }
        }
    }
}
