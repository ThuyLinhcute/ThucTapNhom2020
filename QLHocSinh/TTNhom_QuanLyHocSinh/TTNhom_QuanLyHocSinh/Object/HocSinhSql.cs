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
    class HocSinhSql
    {
        public void LayDSHocSinh(DataGridView dataGridView, SearchLookUpEdit searchLookUpEdit)
        {
            string query = "LayDanhSachHocSinh";
            DataSet dataSet = connection.FillDataSet(query, CommandType.StoredProcedure);
            dataGridView.DataSource = dataSet.Tables[0];
            searchLookUpEdit.Properties.DataSource = dataSet.Tables[0];
        }
        public int TaoMaHS()
        {
            string sql = "select max(MaHocSinh) from HocSinh";
            object result = connection.docGiaTri(sql);
            int kq = (int)result + 1;
            return kq;
        }

        public List<string> LayDSLop(GridLookUpEdit grid)
        {
            List<string> list = new List<string>();
            string query = "select * from Lop";
            DataSet data = new DataSet();
            data = connection.FillDataSet(query, CommandType.Text);
            string field = "MaLop";
            grid.Properties.DataSource = null;
            grid.Properties.DataSource = data.Tables[0];
            grid.Properties.DisplayMember = field;
            foreach (DataRow row in data.Tables[0].Rows)
            {
                list.Add(row[field].ToString());
            }
            return list;
        }

        public bool Them_HS(HocSinh hs)
        {
            string query = "ThemHocSinh";
            string[] para;
            para = new string[10];
            para[0] = "@mahs";
            para[1] = "@malop";
            para[2] = "@hotenhs";
            para[3] = "@ngaysinh";
            para[4] = "@diachi";
            para[5] = "@gioitinh";
            para[6] = "@dantoc";
            para[7] = "@hotenphuhuynh";
            para[8] = "@sdtphuhuynh";
            para[9] = "@namnhaphoc";
            object[] values;
            values = new object[10];
            values[0] = hs.Mahocsinh;
            values[1] = hs.Malop;
            values[2] = hs.Hotenhs;
            values[3] = hs.Ngaysinh;
            values[4] = hs.Diachi;
            values[5] = hs.Gioitinh;
            values[6] = hs.Dantoc;
            values[7] = hs.Hotenphuhuynh;
            values[8] = hs.Sdtphuhuynh;
            values[9] = hs.Namnhaphoc;

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

        public bool Sua_HS(HocSinh hs)
        {
            string query = "SuaHocSinh";
            string[] para;
            para = new string[10];
            para[0] = "@mahs";
            para[1] = "@malop";
            para[2] = "@hotenhs";
            para[3] = "@ngaysinh";
            para[4] = "@diachi";
            para[5] = "@gioitinh";
            para[6] = "@dantoc";
            para[7] = "@hotenphuhuynh";
            para[8] = "@sdtphuhuynh";
            para[9] = "@namnhaphoc";
            object[] values;
            values = new object[10];
            values[0] = hs.Mahocsinh;
            values[1] = hs.Malop;
            values[2] = hs.Hotenhs;
            values[3] = hs.Ngaysinh;
            values[4] = hs.Diachi;
            values[5] = hs.Gioitinh;
            values[6] = hs.Dantoc;
            values[7] = hs.Hotenphuhuynh;
            values[8] = hs.Sdtphuhuynh;
            values[9] = hs.Namnhaphoc;

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

        public bool Xoa_HS(int mahs)
        {
            string query = "XoaHocSinh";
            string[] para;
            para = new string[1];
            para[0] = "@mahs";          
            object[] values;
            values = new object[1];
            values[0] = mahs;
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
            data = connection.FillDataSet(query, CommandType.StoredProcedure,para,values);
            comboBox.DataSource = data.Tables[0];
            comboBox.DisplayMember = "TenHuyen_Quan";
            comboBox.ValueMember = "TenHuyen_Quan";
            comboBox.Text = string.Empty;
        }

        public void LayDanhSachXa(System.Windows.Forms.ComboBox comboBox,string tinh, string huyen)
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
