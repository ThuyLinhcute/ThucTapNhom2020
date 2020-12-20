using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTNhom_QuanLyHocSinh.Object
{
    public class GiangDay
    {
        string magv;
        string hotengv;
        string malop;
        string tenlop;
        string mamonhoc;
        string tenmonhoc;
        int sotiet;

        public string Magv { get => magv; set => magv = value; }
        public string Hotengv { get => hotengv; set => hotengv = value; }
        public string Malop { get => malop; set => malop = value; }
        public string Tenlop { get => tenlop; set => tenlop = value; }
        public string Mamonhoc { get => mamonhoc; set => mamonhoc = value; }
        public string Tenmonhoc { get => tenmonhoc; set => tenmonhoc = value; }
        public int Sotiet { get => sotiet; set => sotiet = value; }

        public GiangDay()
        {

        }

        public GiangDay(string magv,string hotengv,string malop,string tenlop,string mamonhoc,string tenmonhoc,int sotiet)
        {
            Magv = magv;
            Hotengv = hotengv;
            Malop = malop;
            Tenlop = tenlop;
            Mamonhoc = mamonhoc;
            Tenmonhoc = tenmonhoc;
            Sotiet = sotiet;
        }

        public GiangDay(string magv,string malop,string mamonhoc)
        {
            Magv = magv;
            Malop = malop;
            Mamonhoc = mamonhoc;
        }
    }
}
