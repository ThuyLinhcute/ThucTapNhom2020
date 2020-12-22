using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BanHangSieuTHi.Class;



namespace BanHangSieuTHi
{
    public partial class frmQLKH : Form
    {
        public frmQLKH()
        {
            InitializeComponent();
        }

        string temp;

        public void LoadListView()
        {
            listView1.Items.Clear();
            sqlQuery sql = new sqlQuery();
            DataTable dt = sql.LayDuLieu("Select * from KHACHHANG");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem item = new ListViewItem((i + 1).ToString());
                item.SubItems.Add(dt.Rows[i][0].ToString());
                item.SubItems.Add(dt.Rows[i][1].ToString());
                item.SubItems.Add(dt.Rows[i][2].ToString());
                item.SubItems.Add(dt.Rows[i][3].ToString());                
                listView1.Items.Add(item);
            }
        }

        private void frmQLKH_Load(object sender, EventArgs e)
        {
            LoadListView();
        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            int row = this.listView1.SelectedItems[0].Index;
            txtMa.Text = this.listView1.Items[row].SubItems[1].Text;
            txtTen.Text = this.listView1.Items[row].SubItems[2].Text;
            temp = this.listView1.Items[row].SubItems[1].Text;
            txtDiaChi.Text = this.listView1.Items[row].SubItems[3].Text;
            txtSdt.Text = this.listView1.Items[row].SubItems[4].Text;        
        }


        private void txtMa_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {
     
        }

        private void txtDiaChi_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void txtSdt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMa.Text != "")
                {
                    DialogResult result;
                    result = MessageBox.Show("BẠN CÓ MUỐN THÊM KHÁCH HÀNG NÀY KHÔNG?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        string[] name = { "@MaKH", "@TenKH", "@DiaChiKH", "@SdtKH"};
                        string[] value = { txtMa.Text, txtTen.Text, txtDiaChi.Text, txtSdt.Text };
                        sqlQuery sql = new sqlQuery();
                        sql.update("ADD_KH", name, value, 4);
                        MessageBox.Show("THÊM KHÁCH HÀNG THÀNH CÔNG !", "");

                        LoadListView();
                    }
                }
                else
                {
                    MessageBox.Show("Mời kiểm tra lại !", "THÔNG BÁO");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bạn đã nhập đủ các trường cần thiết chưa??", "Warning");
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMa.Text != "")
                {
                    DialogResult result;
                    result = MessageBox.Show("BẠN CÓ MUỐN SỬA THÔNG TIN KHÁCH HÀNG NÀY KHÔNG?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        string[] name = {"@MaKH", "@TenKH", "@DiaChiKH", "@SdtKH"};
                        string[] value = {txtMa.Text, txtTen.Text, txtDiaChi.Text, txtSdt.Text };
                        sqlQuery sql = new sqlQuery();
                        sql.update("UPDATE_KH", name, value, 4);
                        MessageBox.Show("Cập nhật thành công");
                        listView1.Items.Clear();
                        LoadListView();
                    }
                }
                else { MessageBox.Show("Hãy chọn một khách hàng bạn muốn thao tác !!", "Thông tin"); }

            }
            catch (Exception)
            {
                    MessageBox.Show("Đã có lỗi trong quá trình sửa!!", "Thông tin");
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMa.Text != "")
                {
                    DialogResult result;
                    result = MessageBox.Show("BẠN CÓ MUỐN XÓA KHÁCH HÀNG NÀY KHÔNG?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        string[] name = { "@MaKH" };
                        string[] value = { temp };
                        sqlQuery sql = new sqlQuery();
                        sql.update("DELETE_KH", name, value, 1);
                        MessageBox.Show("Xóa thành công .");
                        listView1.Items.Clear();
                        LoadListView();
                    }
                }
                else { MessageBox.Show("Hãy chọn một khách hàng bạn muốn thao tác !!", "Warning"); }

            }
            catch (Exception)
            {
               MessageBox.Show("Thông tin khách hàng đã lưu!Không thể xóa", "Warning");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbl4_Click(object sender, EventArgs e)
        {

        }




    }

}