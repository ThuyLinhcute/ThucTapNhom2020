using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.DAO
{
    public class PhongBanDAO
    {
        public static DataTable LoadPhongBan()
        {
            string query = "SELECT * FROM PHONGBAN";

            DataTable data = SqlServerHelper.ExecuteQuery(query);

            return data;
        }
        public static int InsertPhongBan(string tenpb)
        {
            string query = "INSERTPHONGBAN @TENPB";

            return SqlServerHelper.ExecuteNonQuery(query, new object[] { tenpb });
        }
        public static int UpdatePhongBan(int idpb, string tenpb)
        {
            string query = "UPDATEPHONGBAN @IDPB , @TENPB ";

            return SqlServerHelper.ExecuteNonQuery(query, new object[] { idpb, tenpb });
        }
        public static int DeletePhongBan(int idpb)
        {
            string query = "DELETEPHONGBAN @IDPB ";

            try
            {
                return SqlServerHelper.ExecuteNonQuery(query, new object[] { idpb });
            }
            catch
            {
                return 0;
            }
        }
    }
}
