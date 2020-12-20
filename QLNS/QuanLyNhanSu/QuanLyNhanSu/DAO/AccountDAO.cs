using QuanLyNhanSu.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.DAO
{
    public class AccountDAO
    {
        public static bool Login(string username, string password)
        {

            string query = "USP_LOGIN @username , @password ";

            DataTable data = SqlServerHelper.ExecuteQuery(query, new object[] { username, password });

            return data.Rows.Count > 0;
        }

        public static AccountDTO GetAccount(string username)
        {
            string query = "select * from Account where UserName = '" + username + "'";

            DataTable data = SqlServerHelper.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                AccountDTO acc = new AccountDTO(item);

                return acc;
            }

            return null;
        }

        public static DataTable LoadAccount()
        {
            string query = "SELECT * FROM ACCOUNT";

            return SqlServerHelper.ExecuteQuery(query);
        }
        public static int InsertAccount(string username, string password, string type)
        {
            string query = "INSERT INTO ACCOUNT(USERNAME,PASSWORD,TYPE) VALUES('" + username + "','" + password + "','" + type + "')";

            return SqlServerHelper.ExecuteNonQuery(query);
        }
        public static int UpdateAccount(string username, string password, string type)
        {
            string query = "UPDATE ACCOUNT SET PASSWORD = '" + password + "', TYPE = '" + type + "' WHERE USERNAME = '" + username + "'";

            return SqlServerHelper.ExecuteNonQuery(query);
        }
        public static int DeleteAccount(string username)
        {
            string query = "DELETE ACCOUNT WHERE USERNAME = '" + username + "'";
            try
            {
                return SqlServerHelper.ExecuteNonQuery(query);
            }
            catch
            {
                return 0;
            }
            
        }
    }
}
