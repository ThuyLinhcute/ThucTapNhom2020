using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.DAO
{
    public class KhenThuongKyLuatDAO
    {
        public static DataTable LoadKhenThuongKyLuat(int idnv)
        {
            string query = "SELECT * FROM KHENTHUONGKYLUAT K WHERE K.NHANVIENID = " + idnv + "";

            DataTable data = SqlServerHelper.ExecuteQuery(query);

            return data;
        }
        public static int InsertKTKL(int idnv, int hinhthuc, string noidung, DateTime thoigian)
        {
            string query = "INSERTKHENTHUONGKYLUAT @IDNV ,  @HINHTHUC , @NOIDUNG , @THOIGIAN ";

            return SqlServerHelper.ExecuteNonQuery(query, new object[] { idnv, hinhthuc, noidung, thoigian });
        }
        public static int UpdateKTKL(int idktkl, int idnv, int hinhthuc, string noidung, DateTime thoigian)
        {
            string query = "UPDATEKHENTHUONGKYLUAT @IDKTKL , @IDNV ,  @HINHTHUC , @NOIDUNG , @THOIGIAN ";

            return SqlServerHelper.ExecuteNonQuery(query, new object[] { idktkl, idnv, hinhthuc, noidung, thoigian });
        }
        public static int DeleteKTKL(int idktkl)
        {
            string query = "DELETEKHENTHUONGKYLUAT @IDKTKL ";

            try
            {
                return SqlServerHelper.ExecuteNonQuery(query, new object[] { idktkl });
            }
            catch
            {
                return 0;
            }
        }
    }
}
