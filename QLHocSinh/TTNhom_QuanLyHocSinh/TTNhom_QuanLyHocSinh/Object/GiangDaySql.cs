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
    class GiangDaySql
    {
        public void LayDSGiangDay(DataGridView dataGridView,SearchLookUpEdit searchLookUpEdit)
        {
            string query = "DSGiangDay";
            DataSet dataSet = connection.FillDataSet(query, CommandType.StoredProcedure);
            dataGridView.DataSource = dataSet.Tables[0];
            searchLookUpEdit.Properties.DataSource = dataSet.Tables[0];
        }

        public List<string> LayDSGV(GridLookUpEdit grid)
        {
            List<string> list = new List<string>();
            string query = "SELECT * FROM dbo.GiaoVien";
            DataSet data = new DataSet();
            data = connection.FillDataSet(query, CommandType.Text);
            string field = "MaGiaoVien";
            grid.Properties.DataSource = null;
            grid.Properties.DataSource = data.Tables[0];
            grid.Properties.DisplayMember = field;
            foreach (DataRow row in data.Tables[0].Rows)
            {
                list.Add(row[field].ToString());
            }
            return list;
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
        public List<string> LayDSMonHoc(GridLookUpEdit grid)
        {
            List<string> list = new List<string>();
            string query = "SELECT * FROM dbo.MonHoc";
            DataSet data = new DataSet();
            data = connection.FillDataSet(query, CommandType.Text);
            string field = "MaMonHoc";
            grid.Properties.DataSource = null;
            grid.Properties.DataSource = data.Tables[0];
            grid.Properties.DisplayMember = field;
            foreach (DataRow row in data.Tables[0].Rows)
            {
                list.Add(row[field].ToString());
            }
            return list;
        }

        public bool Them_GD(GiangDay gd)
        {
            string query = "ThemGiangDay";
            string[] para;
            para = new string[3];
            para[0] = "@magv";
            para[1] = "@malop";
            para[2] = "@mamonhoc";
            object[] values;
            values = new object[3];
            values[0] = gd.Magv;
            values[1] = gd.Malop;
            values[2] = gd.Mamonhoc;
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

        public bool Sua_GD(GiangDay gd,GiangDay gdcu)
        {
            string query = "SuaGiangDay";
            string[] para;
            para = new string[6];
            para[0] = "@magv";
            para[1] = "@malop";
            para[2] = "@mamonhoc";
            para[3] = "@magvcu";
            para[4] = "@malopcu";
            para[5] = "@mamonhoccu";
            object[] values;
            values = new object[6];
            values[0] = gd.Magv;
            values[1] = gd.Malop;
            values[2] = gd.Mamonhoc;
            values[3] = gdcu.Magv;
            values[4] = gdcu.Malop;
            values[5] = gdcu.Mamonhoc;
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

        public bool Xoa_GD(GiangDay gd)
        {
            string query = "XoaGiangDay";
            string[] para;
            para = new string[3];
            para[0] = "@magv";
            para[1] = "@malop";
            para[2] = "@mamonhoc";
            object[] values;
            values = new object[3];
            values[0] = gd.Magv;
            values[1] = gd.Malop;
            values[2] = gd.Mamonhoc;
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

    }
}
