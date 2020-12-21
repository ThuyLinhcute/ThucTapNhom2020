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
    class DiemSql
    {
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

        public void LayDSDiem(DataGridView dataGridView, SearchLookUpEdit searchLookUpEdit,string mlop,string mmonhoc)
        {
            string query = "DanhSachDiem";
            string[] para;
            para = new string[2];
            para[0] = "@malop";
            para[1] = "@mamonhoc";
            object[] values;
            values = new object[2];
            values[0] = mlop;
            values[1] = mmonhoc;
            DataSet dataSet = new DataSet();
            dataSet = connection.FillDataSet(query, CommandType.StoredProcedure, para, values);
            dataGridView.DataSource = dataSet.Tables[0];
            searchLookUpEdit.Properties.DataSource = dataSet.Tables[0];
        }

        public bool NhapDiem(Diem diem)
        {
            string query = "NhapDiem";
            string[] para;
            para = new string[6];
            para[0] = "@mahs";
            para[1] = "@mamonhoc";
            para[2] = "@diemmieng";
            para[3] = "@diem15phut";
            para[4] = "@diem1tiet";
            para[5] = "@diemhocki";
            object[] values;
            values = new object[6];
            values[0] = diem.Mahs;
            values[1] = diem.Mamonhoc;
            values[2] = diem.Diemmieng;
            values[3] = diem.Diem15phut;
            values[4] = diem.Diem1tiet;
            values[5] = diem.Diemhocki;
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

        public bool SuaDiem(Diem diem)
        {
            string query = "SuaDiem";
            string[] para;
            para = new string[6];
            para[0] = "@mahs";
            para[1] = "@mamonhoc";
            para[2] = "@diemmieng";
            para[3] = "@diem15phut";
            para[4] = "@diem1tiet";
            para[5] = "@diemhocki";
            object[] values;
            values = new object[6];
            values[0] = diem.Mahs;
            values[1] = diem.Mamonhoc;
            values[2] = diem.Diemmieng;
            values[3] = diem.Diem15phut;
            values[4] = diem.Diem1tiet;
            values[5] = diem.Diemhocki;
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
