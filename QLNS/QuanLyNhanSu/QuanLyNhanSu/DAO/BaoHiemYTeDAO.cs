using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.DAO
{
    public class BaoHiemYTeDAO
    {
        public static DataTable LoadBaoHiemYTe()
        {
            string query = "SELECT HOTEN, BAOHIEMYTEID, SOTHE, NGAYNOP, B.NHANVIENID FROM BAOHIEMYTE B, NHANVIEN N WHERE B.NHANVIENID = N.NHANVIENID";

            DataTable data = SqlServerHelper.ExecuteQuery(query);

            return data;
        }
        public static int InsertBaoHiemYTe(int idnv, string sothe, DateTime ngaynop)
        {
            string query = "INSERTBAOHIEMYTE @IDNV , @SOTHE , @NGAYNOP ";

            return SqlServerHelper.ExecuteNonQuery(query, new object[] { idnv, sothe, ngaynop });
        }
        public static int UpdateBaoHiemYTe(int idbh, int idnv, string sothe, DateTime ngaynop)
        {
            string query = "UPDATEBAOHIEMYTE @IDBAOHIEM , @IDNV , @SOTHE , @NGAYNOP ";

            return SqlServerHelper.ExecuteNonQuery(query, new object[] { idbh, idnv, sothe, ngaynop });
        }
        public static int DeleteBaoHiemYTe(int idbh)
        {
            string query = "DELETEBAOHIEMYTE @IDBAOHIEM ";
            try
            {
                return SqlServerHelper.ExecuteNonQuery(query, new object[] { idbh });
            }
            catch
            {
                return 0;
            }
        }

    }
}
