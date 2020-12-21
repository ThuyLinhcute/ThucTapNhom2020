using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.DAO
{
    public class NhanVienDAO
    {
        public static DataTable LoadCboNhanVien()
        {
            string query = "SELECT NHANVIENID, HOTEN FROM NHANVIEN";

            DataTable data = SqlServerHelper.ExecuteQuery(query);

            return data;
        }
        public static DataTable LoadNhanVien()
        {
            string query = "SELECT NHANVIENID, HOTEN,BIDANH,DIACHI,NGAYSINH,MASOTHUE,GIOITINH,SOTKNGANHANG,SDT,EMAIL,N.CHUCVUID,N.PHONGBANID, C.TEN AS TENCV, P.TEN AS TENPB, G.TEN AS TENGIOITINH FROM NHANVIEN N, PHONGBAN P, CHUCVU C, GIOITINH G WHERE N.PHONGBANID = P.PHONGBANID AND N.CHUCVUID = C.CHUCVUID AND N.GIOITINH = G.GIOITINHID";

            DataTable data = SqlServerHelper.ExecuteQuery(query);

            return data;
        }
        public static int InsertNhanVien(string hoten, string bidanh, string diachi, DateTime ngaysinh, string masothue, int gioitinh, string sotknganhang, string sdt, string email, int chucvuid, int phongbanid)
        {
            string query = "INSERTNHANVIEN @HOTEN , @BIDANH , @DIACHI , @NGAYSINH , @MASOTHUE , @GIOITINH , @SOTKNGANHANG , @SDT , @EMAIL , @CHUCVUID , @PHONGBANID ";

            return SqlServerHelper.ExecuteNonQuery(query, new object[] { hoten, bidanh, diachi, ngaysinh, masothue, gioitinh, sotknganhang, sdt, email, chucvuid, phongbanid });
        }
        public static int UpdateNhanVien(int nhanvienid, string hoten, string bidanh, string diachi, DateTime ngaysinh, string masothue, int gioitinh, string sotknganhang, string sdt, string email, int chucvuid, int phongbanid)
        {
            string query = "UPDATENHANVIEN @NHANVIENID , @HOTEN , @BIDANH , @DIACHI , @NGAYSINH , @MASOTHUE , @GIOITINH , @SOTKNGANHANG , @SDT , @EMAIL , @CHUCVUID , @PHONGBANID ";

            return SqlServerHelper.ExecuteNonQuery(query, new object[] { nhanvienid, hoten, bidanh, diachi, ngaysinh, masothue, gioitinh, sotknganhang, sdt, email, chucvuid, phongbanid });
        }
        public static int DeleteNhanVien(int nhanvienid)
        {
            string query = "DELETENHANVIEN @NHANVIENID ";

            try
            {
                return SqlServerHelper.ExecuteNonQuery(query, new object[] { nhanvienid });
            }
            catch
            {
                return 0;
            }
        }
    }
}
