using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.DTO
{
    public class AccountDTO
    {
        public AccountDTO(string username, string type, string password = null)
        {
            this.UserName = username;
            this.PassWord = password;
            this.Type = type;
        }

        public AccountDTO(DataRow row)
        {
            this.UserName = row["USERNAME"].ToString();
            this.PassWord = row["PASSWORD"].ToString();
            this.Type = row["TYPE"].ToString();
        }

        private string userName;
    
        public string UserName
        {
          get { return userName; }
          set { userName = value; }
        }

        private string passWord;

        public string PassWord
        {
            get { return passWord; }
            set { passWord = value; }
        }

        private string type;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }
    }
}
