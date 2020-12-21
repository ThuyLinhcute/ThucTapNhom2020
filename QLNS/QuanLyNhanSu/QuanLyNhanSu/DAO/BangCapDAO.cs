using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.DAO
{
    public class BangCapDAO
    {
        public static DataTable LoadBangCap(int idnv)
        {
            string query = "select * from bangcap where nhanvienid = " + idnv + "";

            return SqlServerHelper.ExecuteQuery(query);
        }
        public static int InsertBangCap(int idnv, string trinhdohocvan, DateTime thoigian, string chitiet)
        {
            string query = "INSERTBANGCAP @IDNV , @TRINHDOHOCVAN , @THOIGIAN , @CHITIET ";

            return SqlServerHelper.ExecuteNonQuery(query, new object[] { idnv, trinhdohocvan, thoigian, chitiet });
        }
        public static int UpdateBangCap(int idbangcap, int idnv, string trinhdohocvan, DateTime thoigian, string chitiet)
        {
            string query = "UPDATEBANGCAP @IDBANGCAP , @IDNV , @TRINHDOHOCVAN , @THOIGIAN , @CHITIET ";

            return SqlServerHelper.ExecuteNonQuery(query, new object[] { idbangcap, idnv, trinhdohocvan, thoigian, chitiet });
        }
        public static int DeleteBangCap(int idbangcap)
        {
            string query = "DELETEBANGCAP @IDBANGCAP ";

            try
            {
                return SqlServerHelper.ExecuteNonQuery(query, new object[] { idbangcap });
            }
            catch
            {
                return 0;
            }
        }
    }
}
