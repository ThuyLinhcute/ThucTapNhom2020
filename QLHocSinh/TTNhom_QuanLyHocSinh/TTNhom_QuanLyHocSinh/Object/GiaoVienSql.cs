using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TTNhom_QuanLyHocSinh.CSDL;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using DevExpress.XtraEditors;

namespace TTNhom_QuanLyHocSinh.Object
{
    class GiaoVienSql
    {
        public void LayDSGiaoVien(DataGridView dataGridView, SearchLookUpEdit searchLookUpEdit)
        {
            string query = "LayDanhSachGiaoVien";
            DataSet dataSet = connection.FillDataSet(query, CommandType.StoredProcedure);
            dataGridView.DataSource = dataSet.Tables[0];
            searchLookUpEdit.Properties.DataSource = dataSet.Tables[0];
        }
        public string TaoMaGV()
        {
            string sql = "SELECT MAX(MaGiaoVien) FROM dbo.GiaoVien";
            object result = connection.docGiaTri(sql);
            string kq = (string)result;
            string kq2 = kq.Substring(2);
            int temp = Convert.ToInt32(kq2) + 1;
            string kq3 = "GV" + temp.ToString();
            return kq3;
        }

        public bool Them_GV(GiaoVien gv)
        {
            string query = "ThemGiaoVien";
            string[] para;
            para = new string[8];
            para[0] = "@magv";
            para[1] = "@hotengv";
            para[2] = "@ngaysinh";
            para[3] = "@diachi";
            para[4] = "@gioitinh";
            para[5] = "@luong";
            para[6] = "@ngayvaolam";
            para[7] = "@chucvu";
            object[] values;
            values = new object[8];
            values[0] = gv.Magv;
            values[1] = gv.Hotengv;
            values[2] = gv.Ngaysinh;
            values[3] = gv.Diachi;
            values[4] = gv.Gioitinh;
            values[5] = gv.Luong;
            values[6] = gv.Ngayvaolam;
            values[7] = gv.Chucvu;

            try
            {
                int a = connection.Excute_Sql(query, CommandType.StoredProcedure, para, values);
                if (a != 0)
                    return true;
                return false;
            }
            catch (SqlException ex)
            {
                //DialogResult d;
                //d = MessageBox.Show("Thông tin thêm không hợp lệ!");
                return false;
            }
            finally
            {
                connection.close();
            }
        }

        public bool Sua_GV(GiaoVien gv)
        {
            string query = "SuaGiaoVien";
            string[] para;
            para = new string[8];
            para[0] = "@magv";
            para[1] = "@hotengv";
            para[2] = "@ngaysinh";
            para[3] = "@diachi";
            para[4] = "@gioitinh";
            para[5] = "@luong";
            para[6] = "@ngayvaolam";
            para[7] = "@chucvu";
            object[] values;
            values = new object[8];
            values[0] = gv.Magv;
            values[1] = gv.Hotengv;
            values[2] = gv.Ngaysinh;
            values[3] = gv.Diachi;
            values[4] = gv.Gioitinh;
            values[5] = gv.Luong;
            values[6] = gv.Ngayvaolam;
            values[7] = gv.Chucvu;

            try
            {
                int a = connection.Excute_Sql(query, CommandType.StoredProcedure, para, values);
                if (a != 0)
                    return true;
                return false;
            }
            catch (SqlException ex)
            {
                //DialogResult d;
                //d = MessageBox.Show("Thông tin thêm không hợp lệ!");
                return false;
            }
            finally
            {
                connection.close();
            }
        }

        public bool Xoa_GV(string magv)
        {
            string query = "XoaGiaoVien";
            string[] para;
            para = new string[1];
            para[0] = "@magv";
            object[] values;
            values = new object[1];
            values[0] = magv;
            try
            {
                int a = connection.Excute_Sql(query, CommandType.StoredProcedure, para, values);
                if (a != 0)
                    return true;
                return false;
            }
            catch (SqlException ex)
            {
                //DialogResult d;
                //d = MessageBox.Show("Thông tin thêm không hợp lệ!");
                return false;
            }
            finally
            {
                connection.close();
            }
        }


        public void LayDanhSachTinh(System.Windows.Forms.ComboBox comboBox)
        {
            string query = "SELECT DISTINCT TenTinh_ThanhPho FROM dbo.DiaChi";
            DataSet data = new DataSet();
            data = connection.FillDataSet(query, CommandType.Text);
            comboBox.DataSource = data.Tables[0];
            comboBox.DisplayMember = "TenTinh_ThanhPho";
            comboBox.ValueMember = "TenTinh_ThanhPho";
        }

        public void LayDanhSachHuyen(System.Windows.Forms.ComboBox comboBox, string tinh)
        {
            string query = "LayDSHuyen";
            string[] para;
            para = new string[1];
            para[0] = "@tentinh";
            object[] values;
            values = new object[1];
            values[0] = tinh;
            DataSet data = new DataSet();
            data = connection.FillDataSet(query, CommandType.StoredProcedure, para, values);
            comboBox.DataSource = data.Tables[0];
            comboBox.DisplayMember = "TenHuyen_Quan";
            comboBox.ValueMember = "TenHuyen_Quan";
            comboBox.Text = string.Empty;
        }

        public void LayDanhSachXa(System.Windows.Forms.ComboBox comboBox, string tinh, string huyen)
        {
            string query = "LayDSXa";
            string[] para;
            para = new string[2];
            para[0] = "@tentinh";
            para[1] = "@tenhuyen";
            object[] values;
            values = new object[2];
            values[0] = tinh;
            values[1] = huyen;
            DataSet data = new DataSet();
            data = connection.FillDataSet(query, CommandType.StoredProcedure, para, values);
            comboBox.DataSource = data.Tables[0];
            comboBox.DisplayMember = "TenXa_Phuong";
            comboBox.ValueMember = "TenXa_Phuong";
            comboBox.Text = string.Empty;
        }

        public bool KiemTraNgaySinh(DateTimePicker dateTimePicker)
        {
            if (dateTimePicker.Value.Date >= DateTime.Now.Date)
                return false;
            else
                return true;
        }

        public string KiemTraGioiTinh(RadioButton nam, RadioButton nu)
        {
            string str = "";
            if (nam.Checked == false && nu.Checked == false)
                return null;
            else
            {
                if (nam.Checked == true)
                    str = "Nam";
                else
                {
                    if (nu.Checked == true)
                        str = "Nu";
                }
            }
            return str;
        }
    }
}
