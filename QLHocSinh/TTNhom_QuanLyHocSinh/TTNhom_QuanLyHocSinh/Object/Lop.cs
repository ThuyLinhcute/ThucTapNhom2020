using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTNhom_QuanLyHocSinh.Object
{
    public class Lop
    {
        string malop;
        string tenlop;
        string magvcn;
        string hotengvcn;
        int siso;

        public string Malop { get => malop; set => malop = value; }
        public string Tenlop { get => tenlop; set => tenlop = value; }
        public string Magvcn { get => magvcn; set => magvcn = value; }
        public string Hotengvcn { get => hotengvcn; set => hotengvcn = value; }
        public int Siso { get => siso; set => siso = value; }

        public Lop()
        {

        }

        public Lop(string malop,string tenlop,string magvcn,string hotengvcn,int siso)
        {
            Malop = malop;
            Tenlop = tenlop;
            Magvcn = magvcn;
            Hotengvcn = hotengvcn;
            Siso = siso;
        }

        public Lop(string malop,string tenlop,string magvcn)
        {
            Malop = malop;
            Tenlop = tenlop;
            Magvcn = magvcn;
        }
    }
}
