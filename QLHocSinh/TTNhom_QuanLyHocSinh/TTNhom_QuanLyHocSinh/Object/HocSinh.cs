using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTNhom_QuanLyHocSinh.Object
{
    public class HocSinh
    {
        int mahocsinh;
        string malop;
        string hotenhs;
        DateTime ngaysinh;
        string diachi;
        string gioitinh;
        string dantoc;
        string hotenphuhuynh;
        string sdtphuhuynh;
        int namnhaphoc;

        public int Mahocsinh { get => mahocsinh; set => mahocsinh = value; }
        public string Malop { get => malop; set => malop = value; }
        public string Hotenhs { get => hotenhs; set => hotenhs = value; }
        public DateTime Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public string Dantoc { get => dantoc; set => dantoc = value; }
        public string Hotenphuhuynh { get => hotenphuhuynh; set => hotenphuhuynh = value; }
        public string Sdtphuhuynh { get => sdtphuhuynh; set => sdtphuhuynh = value; }
        public int Namnhaphoc { get => namnhaphoc; set => namnhaphoc = value; }

        public HocSinh(int mahs,string malop,string hoten,DateTime ns,string diachi,string gt,string dantoc,string hotenphuhuynh,string sdtphuhuynh,int namnhaphoc)
        {
            Mahocsinh = mahs;
            Malop = malop;
            Hotenhs = hoten;
            Ngaysinh = ns;
            Diachi = diachi;
            Gioitinh = gt;
            Dantoc = dantoc;
            Hotenphuhuynh = hotenphuhuynh;
            Sdtphuhuynh = sdtphuhuynh;
            Namnhaphoc = namnhaphoc;
        }

        public HocSinh()
        {

        }
    } 
}
