using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.DAO
{
    public class BaoHiemXaHoiDAO
    {
        public static DataTable LoadBaoHiemXaHoi()
        {
            string query = "SELECT HOTEN, BAOHIEMXAHOIID, SOTIEN, NGAYNOP, B.NHANVIENID FROM BAOHIEMXAHOI B, NHANVIEN N WHERE B.NHANVIENID = N.NHANVIENID";

            DataTable data = SqlServerHelper.ExecuteQuery(query);

            return data;
        }
        public static int InsertBaoHiemXaHoi(int idnv, int sotien, DateTime ngaynop)
        {
            string query = "INSERTBAOHIEMXAHOI @IDNV , @SOTIEN , @NGAYNOP ";

            return SqlServerHelper.ExecuteNonQuery(query, new object[] { idnv, sotien, ngaynop });
        }
        public static int UpdateBaoHiemXaHoi(int idbh, int idnv, int sotien, DateTime ngaynop)
        {
            string query = "UPDATEBAOHIEMXAHOI @IDBAOHIEM , @IDNV , @SOTIEN , @NGAYNOP ";

            return SqlServerHelper.ExecuteNonQuery(query, new object[] { idbh, idnv, sotien, ngaynop });
        }
        public static int DeleteBaoHiemXaHoi(int idbh)
        {
            string query = "DELETEBAOHIEMXAHOI @IDBAOHIEM ";
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
