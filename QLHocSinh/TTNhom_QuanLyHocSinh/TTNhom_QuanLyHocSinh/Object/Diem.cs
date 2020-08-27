using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TTNhom_QuanLyHocSinh.Object
{
    public class Diem
    {
        int mahs;
        string hotenhs;
        string ngaysinh;
        string gioitinh;
        double diemmieng;
        double diem15phut;
        double diem1tiet;
        double diemhocki;
        double diemtrungbinhmon;
        string mamonhoc;

        public int Mahs { get => mahs; set => mahs = value; }
        public double Diemmieng { get => diemmieng; set => diemmieng = value; }
        public double Diem15phut { get => diem15phut; set => diem15phut = value; }
        public double Diem1tiet { get => diem1tiet; set => diem1tiet = value; }
        public double Diemhocki { get => diemhocki; set => diemhocki = value; }
        public double Diemtrungbinhmon { get => diemtrungbinhmon; set => diemtrungbinhmon = value; }
        public string Mamonhoc { get => mamonhoc; set => mamonhoc = value; }
        public string Hotenhs { get => hotenhs; set => hotenhs = value; }
        public string Ngaysinh { get => ngaysinh; set => ngaysinh = value; }
        public string Gioitinh { get => gioitinh; set => gioitinh = value; }

        public Diem()
        {

        }

        public Diem(int mahs, string hotenhs,string ngaysinh, string gioitinh, string mamonhoc,double diemmieng,double diem15phut,double diem1tiet,double diemhocki,double diemtrungbinhmon)
        {
            Mahs = mahs;
            Hotenhs = hotenhs;
            Ngaysinh = ngaysinh;
            Gioitinh = gioitinh;
            Mamonhoc = mamonhoc;
            Diemmieng = diemmieng;
            Diem15phut = diem15phut;
            Diem1tiet = diem1tiet;
            Diemhocki = diemhocki;
            Diemtrungbinhmon = diemtrungbinhmon;
        }
    }
}
