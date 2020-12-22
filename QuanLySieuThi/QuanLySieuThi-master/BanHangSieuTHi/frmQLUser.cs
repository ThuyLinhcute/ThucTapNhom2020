using BanHangSieuTHi.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanHangSieuTHi
{
    public partial class frmQLUser : Form
    {
        string temp;
        public frmQLUser()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        public void LoadListView()
        {
            listView1.Items.Clear();
            sqlQuery sql = new sqlQuery();
            DataTable dt = sql.LayDuLieu("Select * from QLNGUOIDUNG");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem item = new ListViewItem((i + 1).ToString());
                item.SubItems.Add(dt.Rows[i][1].ToString());
                item.SubItems.Add(dt.Rows[i][0].ToString());
                item.SubItems.Add(dt.Rows[i][2].ToString());
                item.SubItems.Add(dt.Rows[i][3].ToString());
                item.SubItems.Add(dt.Rows[i][4].ToString());
                listView1.Items.Add(item);
            }
        }
        private void frmQLUser_Load(object sender,EventArgs e)
        {
            LoadListView();
        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            
            int row = this.listView1.SelectedItems[0].Index;
            txtTenUser.Text = this.listView1.Items[row].SubItems[1].Text;
            txtAccName.Text = this.listView1.Items[row].SubItems[2].Text;
            temp = this.listView1.Items[row].SubItems[2].Text;
            txtPassUser.Text= this.listView1.Items[row].SubItems[3].Text;         
            txtImage.Text= this.listView1.Items[row].SubItems[4].Text;
            cbPermiss.Text = this.listView1.Items[row].SubItems[5].Text;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAccName.Text != "")
                {
                    DialogResult result;
                    result = MessageBox.Show("BẠN CÓ MUỐN SỬA THÔNG TIN NGƯỜI DÙNG NÀY KHÔNG?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        string[] name = { "@AccBanDau", "@TenNguoiDung", "@TenDangNhap", "@MatKhau", "@HinhAnh", "@QuyenTruyCap" };
                        string[] value = { temp, txtTenUser.Text, txtAccName.Text, txtPassUser.Text, txtImage.Text, cbPermiss.SelectedItem.ToString() };
                        sqlQuery sql = new sqlQuery();
                        sql.update("UPDATE_USER", name, value, 6);
                        
                        LoadListView();
                    }
                }
                else { MessageBox.Show("Hãy chọn một người dùng bạn muốn thao tác !!", "Thông tin"); }
                        
            }
            catch (Exception)
            {
                
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAccName.Text != "")
                {
                    DialogResult result;
                    result = MessageBox.Show("BẠN CÓ MUỐN XÓA NGƯỜI DÙNG NÀY KHÔNG?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        string[] name = { "@TenDangNhap" };
                        string[] value = { temp };
                        sqlQuery sql = new sqlQuery();
                        sql.update("DELETE_USER", name, value, 1);
                        listView1.Items.Clear();
                        LoadListView();
                    }
                }
                else { MessageBox.Show("Hãy chọn một người dùng bạn muốn thao tác !!", "Thông tin"); }

            }
            catch (Exception)
            {
               
            }
        }

        private void btnThemUser_Click(object sender, EventArgs e)
        {
            frmThemUser frm = new frmThemUser();
            frm.Show();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
