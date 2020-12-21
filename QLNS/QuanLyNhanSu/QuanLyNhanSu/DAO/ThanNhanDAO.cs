using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.DAO
{
    public class ThanNhanDAO
    {
        public static DataTable LoadThanNha(int idnv)
        {
            string query = "SELECT THANNHANID, HOTEN, GIOITINH, T.CHUCVUID, C.TEN AS TENCV, G.TEN AS TENGIOITINH  FROM THANNHAN T, GIOITINH G, CHUCVU C WHERE T.NHANVIENID = " + idnv + " AND T.CHUCVUID = C.CHUCVUID AND T.GIOITINH = G.GIOITINHID";

            return SqlServerHelper.ExecuteQuery(query);
        }
        public static int InsertThanNhan(int idnv, string hoten, int gioitinh, int chucvu)
        {
            string query = "INSERTTHANNHAN @IDNHANVIEN , @HOTEN , @GIOITINH , @CHUCVUID ";

            return SqlServerHelper.ExecuteNonQuery(query, new object[] {idnv, hoten, gioitinh, chucvu });
        }
        public static int UpdateThanNhan(int idtn, int idnv, string hoten, int gioitinh, int chucvu)
        {
            string query = "UPDATETHANNHAN @IDTHANHNHAN , @IDNHANVIEN , @HOTEN , @GIOITINH , @CHUCVUID ";

            return SqlServerHelper.ExecuteNonQuery(query, new object[] { idtn, idnv, hoten, gioitinh, chucvu });
        }
        public static int DeleteThanNhan(int idtn)
        {
            string query = "DELETETHANNHAN @IDTHANNHAN ";

            try
            {
                return SqlServerHelper.ExecuteNonQuery(query, new object[] { idtn });
            }
            catch
            {
                return 0;
            }
        }
    }
}
