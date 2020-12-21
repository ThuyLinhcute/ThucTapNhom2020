using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TTNhom_QuanLyHocSinh.Views;
using TTNhom_QuanLyHocSinh.QLHocSinh;
using TTNhom_QuanLyHocSinh.Object;
using TTNhom_QuanLyHocSinh.QLGiaoVien;

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
        public static GiaoVienSql giaoVienSql;
        public static GiaoVien gv;
        public static QLGV qLGV;
        public static GiangDay giangDay;
        public static GiangDaySql giangDaySql;
        public static Lop lop;
        public static LopSql lopSql;
        public static Diem diem;
        public static DiemSql diemSql;
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
            giaoVienSql = new GiaoVienSql();
            gv = new GiaoVien();
            qLGV = new QLGV();
            giangDay = new GiangDay();
            giangDaySql = new GiangDaySql();
            lop = new Lop();
            lopSql = new LopSql();
            diem = new Diem();
            diemSql = new DiemSql();
            userSql = new UserSql();
            Application.Run(lg);
        }
    }
}
