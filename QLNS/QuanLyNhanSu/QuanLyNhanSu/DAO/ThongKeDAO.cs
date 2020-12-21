using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.DAO
{
    public class ThongKeDAO
    {
        public static DataTable ThongKeSinhNhat(int thang)
        {
            string query = "SELECT N.HOTEN, N.GIOITINH, N.CHUCVUID, N.PHONGBANID, C.TEN AS TENCV, P.TEN AS TENPB, G.TEN AS TENGIOITINH  FROM NHANVIEN N, GIOITINH G, CHUCVU C, PHONGBAN P WHERE MONTH(N.NGAYSINH) = " + thang + " AND N.CHUCVUID = C.CHUCVUID AND N.GIOITINH = G.GIOITINHID AND N.PHONGBANID = P.PHONGBANID";

            return SqlServerHelper.ExecuteQuery(query);
        }
        public static DataTable ThongKeNVTheoPhongBan(int idpb)
        {
            string query = "SELECT N.HOTEN, N.GIOITINH, N.CHUCVUID, N.PHONGBANID, C.TEN AS TENCV, P.TEN AS TENPB, G.TEN AS TENGIOITINH  FROM NHANVIEN N, GIOITINH G, CHUCVU C, PHONGBAN P WHERE N.PHONGBANID = " + idpb + " AND N.CHUCVUID = C.CHUCVUID AND N.GIOITINH = G.GIOITINHID AND N.PHONGBANID = P.PHONGBANID";

            return SqlServerHelper.ExecuteQuery(query);
        }
        public static DataTable ThongKeNVTheoChucVu(int idcv)
        {
            string query = "SELECT N.HOTEN, N.GIOITINH, N.CHUCVUID, N.PHONGBANID, C.TEN AS TENCV, P.TEN AS TENPB, G.TEN AS TENGIOITINH  FROM NHANVIEN N, GIOITINH G, CHUCVU C, PHONGBAN P WHERE N.CHUCVUID = " + idcv + " AND N.CHUCVUID = C.CHUCVUID AND N.GIOITINH = G.GIOITINHID AND N.PHONGBANID = P.PHONGBANID";

            return SqlServerHelper.ExecuteQuery(query);
        }
        public static DataTable ThongKeDangVien()
        {
            string query = "SELECT N.HOTEN, N.GIOITINH, N.CHUCVUID, N.PHONGBANID, C.TEN AS TENCV, P.TEN AS TENPB, G.TEN AS TENGIOITINH FROM NHANVIEN N, GIOITINH G, CHUCVU C, PHONGBAN P, THONGTINDANG T WHERE T.NHANVIENID = N.NHANVIENID AND N.CHUCVUID = C.CHUCVUID AND N.GIOITINH = G.GIOITINHID AND N.PHONGBANID = P.PHONGBANID";

            return SqlServerHelper.ExecuteQuery(query);
        }
        public static DataTable ThongKeNghiHuu(DateTime time)
        {
            string query = "THONGKE_NGHIHUU @NGAY ";

            return SqlServerHelper.ExecuteQuery(query, new object[] { time });
        }
        public static DataTable ThongKeNVMoi(DateTime time)
        {
            string query = "THONGKE_NVMOI @NGAY ";

            return SqlServerHelper.ExecuteQuery(query, new object[] { time });
        }
        public static DataTable LoadChamCong(int idnv, int thang)
        {
            string query = "SELECT CHAMCONGID, C.NHANVIENID, HOTEN, C.NGAY, C.LOAI FROM NHANVIEN N, CHAMCONG C WHERE MONTH(NGAY) = " + thang + " AND C.NHANVIENID = " + idnv + " AND N.NHANVIENID = C.NHANVIENID";

            return SqlServerHelper.ExecuteQuery(query);
        }
        public static int InsertChamCong(int idnv, DateTime ngay, int loai)
        {
            string query = "INSERTCHAMCONG @NHANVIENID , @NGAY , @LOAI ";

            return SqlServerHelper.ExecuteNonQuery(query, new object[] { idnv, ngay, loai });
        }
        public static int UpdateChamCong(int idcc, int idnv, DateTime ngay, int loai)
        {
            string query = "UPDATECHAMCONG @CHAMCONGID , @NHANVIENID , @NGAY , @LOAI ";

            return SqlServerHelper.ExecuteNonQuery(query, new object[] { idcc, idnv, ngay, loai });
        }
        public static int DeleteChamCong(int idcc)
        {
            string query = "DELETECHAMCONG @CHAMCONGID ";

            return SqlServerHelper.ExecuteNonQuery(query, new object[] { idcc });
        }
    }
}
