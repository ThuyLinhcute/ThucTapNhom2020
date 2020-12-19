using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TTNhom_QuanLyHocSinh.Views;

using TTNhom_QuanLyHocSinh.Object;


namespace TTNhom_QuanLyHocSinh
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
 
        public static frmLogin lg;
        public static QuanLyChung quanLyChung;
        public static int opt;
 
        public static string mamonhoc;
        public static UserSql userSql;
        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
 
            lg = new frmLogin();
            quanLyChung = new QuanLyChung();
           
            userSql = new UserSql();
            Application.Run(lg);
        }
    }
}
