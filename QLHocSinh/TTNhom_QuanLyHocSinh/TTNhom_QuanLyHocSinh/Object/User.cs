using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTNhom_QuanLyHocSinh.Object
{
    public class User
    {
        string username;
        string password;
        public enum UserFields
        {
            tendangnhap,
            matkhau,
        }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
    }
}
