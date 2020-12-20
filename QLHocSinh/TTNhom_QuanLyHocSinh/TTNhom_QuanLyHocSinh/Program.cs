using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TTNhom_QuanLyHocSinh.Views;
using TTNhom_QuanLyHocSinh.QLHocSinh;
using TTNhom_QuanLyHocSinh.Object;

namespace TTNhom_QuanLyHocSinh
{
     static class Program
     {
          /// <summary>
          /// The main entry point for the application.
          /// </summary>
          public static QLHS qLHS;
          public static frmLogin lg;
          public static QuanLyChung quanLyChung;
          public static int opt;
          public static HocSinhSql hocSinhSql;
          public static HocSinh hs;
         
          public static string mamonhoc;
          public static UserSql userSql;
          [STAThread]

          static void Main()
          {
               Application.EnableVisualStyles();
               Application.SetCompatibleTextRenderingDefault(false);
               qLHS = new QLHS();
               lg = new frmLogin();
               quanLyChung = new QuanLyChung();
               hocSinhSql = new HocSinhSql();
               hs = new HocSinh();
               userSql = new UserSql();
               Application.Run(lg);
          }
     }
}
