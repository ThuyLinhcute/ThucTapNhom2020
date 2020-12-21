using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.DAO
{
    public class ChucVuDAO
    {
        public static DataTable LoadChucVu()
        {
            string query = "SELECT * FROM CHUCVU";

            DataTable data = SqlServerHelper.ExecuteQuery(query);

            return data;
        }
        public static int InsertChucVu(string tenpb)
        {
            string query = "INSERTCHUCVU @TENCV ";

            return SqlServerHelper.ExecuteNonQuery(query, new object[] { tenpb });
        }
        public static int UpdateChucVu(int idcv, string tencv)
        {
            string query = "UPDATECHUCVU @IDCV , @TENCV ";

            return SqlServerHelper.ExecuteNonQuery(query, new object[] { idcv, tencv });
        }
        public static int DeleteChucVu(int idcv)
        {
            string query = "DELETECHUCVU @IDCV ";

            try
            {
                return SqlServerHelper.ExecuteNonQuery(query, new object[] { idcv });
            }
            catch
            {
                return 0;
            }
        }
    }
}
