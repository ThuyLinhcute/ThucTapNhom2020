using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTNhom_QuanLyHocSinh.Object
{
    public class GiaoVien
    {
        string magv;
        string hotengv;
        string gioitinh;
        DateTime ngaysinh;
        string diachi;
        int luong;
        DateTime ngayvaolam;
        string chucvu;

        public string Magv { get => magv; set => magv = value; }
        public string Hotengv { get => hotengv; set => hotengv = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }
        public DateTime Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string Diachi { get => diachi; set => diachi = value; }
        public int Luong { get => luong; set => luong = value; }
        public DateTime Ngayvaolam { get => ngayvaolam; set => ngayvaolam = value; }
        public string Chucvu { get => chucvu; set => chucvu = value; }

        public GiaoVien(string magv, string hotengv, string gioitinh,DateTime ngaysinh, string diachi,int luong,DateTime ngayvaolam,string chucvu)
        {
            Magv = magv;
            Hotengv = hotengv;
            Gioitinh = gioitinh;
            Ngaysinh = ngaysinh;
            Diachi = diachi;
            Luong = luong;
            Ngayvaolam = ngayvaolam;
            Chucvu = chucvu;
        }

        public GiaoVien()
        {

        }
    }
}
