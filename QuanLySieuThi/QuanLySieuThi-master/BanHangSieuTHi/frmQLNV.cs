using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BanHangSieuTHi.Class;

namespace BanHangSieuTHi
{
    public partial class frmQLNV : Form
    {
        public frmQLNV()
        {
            InitializeComponent();           
        }

        string temp;
        public void LoadListView1()
        {
<<<<<<< HEAD
            // listView1.Items.Clear();
            // sqlQuery sql = new sqlQuery();
            // DataTable dt = sql.LayDuLieu("Select * from NHANVIEN");
            // for (int i = 0; i < dt.Rows.Count; i++)
            // {
            //     ListViewItem item = new ListViewItem((i + 1).ToString());
            //     item.SubItems.Add(dt.Rows[i][0].ToString());
            //     item.SubItems.Add(dt.Rows[i][1].ToString());
            //     item.SubItems.Add(dt.Rows[i][2].ToString());
            //     item.SubItems.Add(dt.Rows[i][5].ToString());
            //     item.SubItems.Add(dt.Rows[i][3].ToString());
            //     item.SubItems.Add(dt.Rows[i][6].ToString());
            //     item.SubItems.Add(dt.Rows[i][4].ToString());
            //     listView1.Items.Add(item);
            // }
=======
            listView1.Items.Clear();
            sqlQuery sql = new sqlQuery();
            DataTable dt = sql.LayDuLieu("Select * from NHANVIEN");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem item = new ListViewItem((i + 1).ToString());
                item.SubItems.Add(dt.Rows[i][0].ToString());
                item.SubItems.Add(dt.Rows[i][1].ToString());
                item.SubItems.Add(dt.Rows[i][2].ToString());
                item.SubItems.Add(dt.Rows[i][5].ToString());
                item.SubItems.Add(dt.Rows[i][3].ToString());
                item.SubItems.Add(dt.Rows[i][6].ToString());
                item.SubItems.Add(dt.Rows[i][4].ToString());
                listView1.Items.Add(item);
            }
>>>>>>> d33bb03dc2edf1bf7f777b7fe4d851047eabcb28
        }
        private void frmQLNV_Load(object sender, EventArgs e)
        {
            LoadListView1();
        }







        private void btnDelete_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            // try
            // {
            //     if (txtMa.Text != "")
            //     {
            //         DialogResult result;
            //         result = MessageBox.Show("BẠN CÓ MUỐN XÓA NHÂN VIÊN NÀY KHÔNG?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //         if (result == DialogResult.Yes)
            //         {
            //             string[] name = { "@MaNV" };
            //             string[] value = { txtMa.Text };
            //             sqlQuery sql = new sqlQuery();
            //             sql.update("DELETE_NV", name, value, 1);
            //             MessageBox.Show("Xóa thành công .");
            //             listView1.Items.Clear();
            //             LoadListView1();
            //         }
            //     }
            //     else { MessageBox.Show("Hãy chọn một nhân viên bạn muốn thao tác !!", "Warning"); }

            // }
            // catch (Exception)
            // {
            //         MessageBox.Show("Thông tin nhân viên đã lưu!Không thế xóa!!", "Warning");
            // }
=======
            try
            {
                if (txtMa.Text != "")
                {
                    DialogResult result;
                    result = MessageBox.Show("BẠN CÓ MUỐN XÓA NHÂN VIÊN NÀY KHÔNG?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        string[] name = { "@MaNV" };
                        string[] value = { txtMa.Text };
                        sqlQuery sql = new sqlQuery();
                        sql.update("DELETE_NV", name, value, 1);
                        MessageBox.Show("Xóa thành công .");
                        listView1.Items.Clear();
                        LoadListView1();
                    }
                }
                else { MessageBox.Show("Hãy chọn một nhân viên bạn muốn thao tác !!", "Warning"); }

            }
            catch (Exception)
            {
                MessageBox.Show("Thông tin nhân viên đã lưu!Không thế xóa!!", "Warning");
            }
>>>>>>> d33bb03dc2edf1bf7f777b7fe4d851047eabcb28
        }

       



        private void btnChange_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            // try
            // {
            //     if (txtMa.Text != "")
            //     {
            //         DialogResult result;
            //         result = MessageBox.Show("BẠN CÓ MUỐN SỬA THÔNG TIN NHÂN VIÊN NÀY KHÔNG?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //         if (result == DialogResult.Yes)
            //         {
            //             string[] name = {  "@MaNV", "@HoTenNV", "@DiaChiNV", "@SdtNV", "@ChucVu", "@NgaySinh", "@GioiTinh" };
            //             string[] value = { txtMa.Text, txtTen.Text, txtDiaChi.Text, txtSdt.Text, cbCV.SelectedItem.ToString(), "2000-9-13", cbGT.SelectedItem.ToString() };
            //             sqlQuery sql = new sqlQuery();
            //             sql.update("UPDATE_NV", name, value, 7);
            //             MessageBox.Show("Cập nhật thành công");
            //             listView1.Items.Clear();
            //             LoadListView1();
            //         }
            //     }
            //     else { MessageBox.Show("Hãy chọn một nhân viên bạn muốn thao tác !!", "Warning"); }
            // }
            // catch(Exception Ex)
            // {
            //         MessageBox.Show(Ex.ToString(), "Warning");
            // }
            
=======
            try
            {
                if (txtMa.Text != "")
                {
                    DialogResult result;
                    result = MessageBox.Show("BẠN CÓ MUỐN SỬA THÔNG TIN NHÂN VIÊN NÀY KHÔNG?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        string[] name = { "@MaNV", "@HoTenNV", "@DiaChiNV", "@SdtNV", "@ChucVu", "@NgaySinh", "@GioiTinh" };
                        string[] value = { txtMa.Text, txtTen.Text, txtDiaChi.Text, txtSdt.Text, cbCV.SelectedItem.ToString(), "2000-9-13", cbGT.SelectedItem.ToString() };
                        sqlQuery sql = new sqlQuery();
                        sql.update("UPDATE_NV", name, value, 7);
                        MessageBox.Show("Cập nhật thành công");
                        listView1.Items.Clear();
                        LoadListView1();
                    }
                }
                else { MessageBox.Show("Hãy chọn một nhân viên bạn muốn thao tác !!", "Warning"); }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.ToString(), "Warning");
            }

>>>>>>> d33bb03dc2edf1bf7f777b7fe4d851047eabcb28
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            // try
            // {
            //     if (txtMa.Text != "")
            //     {
            //         DialogResult result;
            //         result = MessageBox.Show("BẠN CÓ MUỐN THÊM NHÂN VIÊN NÀY KHÔNG?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //         if (result == DialogResult.Yes)
            //         {
            //             string[] name = { "@MaNV", "@HoTenNV", "@DiaChiNV", "@SdtNV", "@ChucVu", "@NgaySinh", "@GioiTinh" };
            //             string[] value = { txtMa.Text, txtTen.Text, txtDiaChi.Text, txtSdt.Text, cbCV.SelectedItem.ToString(), dateTimePicker1.Value.ToString(), cbGT.SelectedItem.ToString() };
            //             sqlQuery sql = new sqlQuery();
            //             sql.update("ADD_NV", name, value, 7);
            //             MessageBox.Show("THÊM NHÂN VIÊN THÀNH CÔNG !", "");
                        
            //             LoadListView1();
            //         }
            //     }
            //     else
            //     {
            //         MessageBox.Show("Mời kiểm tra lại !", "THÔNG BÁO");
            //     }
            // }
            // catch (Exception)
            // {
            //     MessageBox.Show("Bạn đã nhập đủ các trường cần thiết chưa??", "Warning");
            // }
=======
            try
            {
                if (txtMa.Text != "")
                {
                    DialogResult result;
                    result = MessageBox.Show("BẠN CÓ MUỐN THÊM NHÂN VIÊN NÀY KHÔNG?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        string[] name = { "@MaNV", "@HoTenNV", "@DiaChiNV", "@SdtNV", "@ChucVu", "@NgaySinh", "@GioiTinh" };
                        string[] value = { txtMa.Text, txtTen.Text, txtDiaChi.Text, txtSdt.Text, cbCV.SelectedItem.ToString(), dateTimePicker1.Value.ToString(), cbGT.SelectedItem.ToString() };
                        sqlQuery sql = new sqlQuery();
                        sql.update("ADD_NV", name, value, 7);
                        MessageBox.Show("THÊM NHÂN VIÊN THÀNH CÔNG !", "");

                        LoadListView1();
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
>>>>>>> d33bb03dc2edf1bf7f777b7fe4d851047eabcb28
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkbox1_SelectedIndexChanged(object sender, EventArgs e)
        {
                      
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void listView1_ItemActivate_1(object sender, EventArgs e)
        {
            int row = this.listView1.SelectedItems[0].Index;
            txtMa.Text = this.listView1.Items[row].SubItems[1].Text;
            txtTen.Text = this.listView1.Items[row].SubItems[2].Text;
            temp = this.listView1.Items[row].SubItems[1].Text;
            txtDiaChi.Text = this.listView1.Items[row].SubItems[3].Text;
            txtSdt.Text = this.listView1.Items[row].SubItems[4].Text;
            cbCV.Text = this.listView1.Items[row].SubItems[5].Text;
            dateTimePicker1.Text = this.listView1.Items[row].SubItems[6].Text;
            cbGT.Text = this.listView1.Items[row].SubItems[7].Text;
        }
    }
}
