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
    class LopSql
    {
        public void LayDSLop(DataGridView dataGridView, SearchLookUpEdit searchLookUpEdit)
        {
            string query = "LayDanhSachLop";
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

        public string TaoMaLop()
        {
            string sql = "SELECT MAX(MaLop) FROM dbo.Lop";
            object result = connection.docGiaTri(sql);
            string kq = (string)result;
            string kq2 = kq.Substring(1);
            int temp = Convert.ToInt32(kq2) + 1;
            string kq3 = "L" + temp.ToString();
            return kq3;
        }


        public bool Them_Lop(Lop lop)
        {
            string query = "ThemLop";
            string[] para;
            para = new string[3];
            para[0] = "@malop";
            para[1] = "@tenlop";
            para[2] = "@magvcn";
            object[] values;
            values = new object[3];
            values[0] = lop.Malop;
            values[1] = lop.Tenlop;
            values[2] = lop.Magvcn;
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

        public bool Sua_Lop(Lop lop)
        {
            string query = "SuaLop";
            string[] para;
            para = new string[3];
            para[0] = "@malop";
            para[1] = "@tenlop";
            para[2] = "@magvcn";
            object[] values;
            values = new object[3];
            values[0] = lop.Malop;
            values[1] = lop.Tenlop;
            values[2] = lop.Magvcn;
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
