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
using System.Collections;

using System.Data;


namespace BanHangSieuTHi
{
    public partial class frmHangHoaMain : Form
    {
        public frmHangHoaMain()
        {
            InitializeComponent();
        }
        string MaHH;
        public void LoadListView1()
        {
            // listView1.Items.Clear();
            // sqlQuery sql = new sqlQuery();
            // DataTable dt = sql.LayDuLieu("Select * from HANGHOA");
            // for (int i = 0; i < dt.Rows.Count; i++)
            // {
            //     ListViewItem item = new ListViewItem((i + 1).ToString());
            //     item.SubItems.Add(dt.Rows[i][0].ToString());
            //     item.SubItems.Add(dt.Rows[i][1].ToString());
            //     item.SubItems.Add(dt.Rows[i][2].ToString());
            //     item.SubItems.Add(dt.Rows[i][3].ToString());
            //     item.SubItems.Add(dt.Rows[i][4].ToString());
            //     item.SubItems.Add(dt.Rows[i][5].ToString());
            //     item.SubItems.Add(dt.Rows[i][6].ToString());
            //     listView1.Items.Add(item);
            // }
        }
        public void LoadLoaiHH()
        {
            sqlQuery truyVanDL = new sqlQuery();
            DataTable dt = truyVanDL.LayDuLieu("select * from LOAIHANG");
            ArrayList arLH = new ArrayList();

            foreach (DataRow row in dt.Rows)
            {
                arLH.Add(row["DienGiai"]);
            }

            txtLoai.DataSource = arLH;
        }

        private void frmHangHoaMain_Load(object sender, EventArgs e)
        {
            LoadListView1(); // Hien list view

            LoadLoaiHH(); // Load loai hàng hóa
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // try
            // {
            //     if (txtTen.Text != "")
            //     {
            //         DialogResult result;
            //         result = MessageBox.Show("BẠN CÓ MUỐN XÓA HÀNG HÓA NÀY KHÔNG?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //         if (result == DialogResult.Yes)
            //         {
            //             sqlQuery truyVan = new sqlQuery();

            //             DataTable dtHH = truyVan.LayDuLieu("select * from HANGHOA where MaHang = N'"+ MaHH+"'");                       
            //             string[] name = { "@MaHH" };
            //             string[] value = { MaHH };
            //             sqlQuery sql = new sqlQuery();
            //             sql.update("DELETE_HH", name, value, 1);
            //             MessageBox.Show("Xóa thành công .");
            //             listView1.Items.Clear();
            //             LoadListView1();
            //         }
            //     }
            //     else { MessageBox.Show("Hãy chọn một hàng hóa bạn muốn thao tác !!", "Warning"); }

            // }
            // catch (Exception)
            // {
            //         MessageBox.Show("Bạn hãy đảm bảo mặt hàng này không được bán ra !!", "Warning");
            // }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            //try
            //{
                // if (txtTen.Text != "")
                // {
                    
                //     DialogResult result;
                //     result = MessageBox.Show("BẠN CÓ MUỐN SỬA THÔNG TIN HÀNG HÓA NÀY KHÔNG?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //     if (result == DialogResult.Yes)
                //     {
                //         sqlQuery truyVan = new sqlQuery();
                //         DataTable dt = truyVan.LayDuLieu("select * from LOAIHANG where DienGiai = N'" + txtLoai.Text + "'");
                //         Object MaLoai = "";
                //         foreach (DataRow row in dt.Rows)
                //         {
                //             MaLoai = row["MaLoai"];
                //         }

                //         string[] name = { "@MaHang", "@TenHang", "@DonVi", "@TenNhaSX", "@GiaDeNghi", "@MaLoai", "@SoLuongSP" };
                //         string[] value = { MaHH, txtTen.Text, txtDonVi.Text, txtTenNSX.Text, txtGia.Text, MaLoai.ToString(), txtSoLuong.Text };
                        
                //         truyVan.update("UPDATE_HH", name, value, 7);
                //         MessageBox.Show("Cập nhật thành công");
                //         listView1.Items.Clear();
                //         LoadListView1();
                //     }
                // }
                // else { MessageBox.Show("Hãy chọn một hàng hóa bạn muốn thao tác !!", "Warning"); }
            //}
            //catch (Exception)
            //{

            //}
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //try
            //{
                // if (txtTen.Text != "")
                // {
                //     DialogResult result;
                //     result = MessageBox.Show("BẠN CÓ MUỐN THÊM HÀNG HÓA NÀY KHÔNG?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //     if (result == DialogResult.Yes)
                //     {
                //         sqlQuery truyVan = new sqlQuery();

                //         DataTable dtHH = truyVan.LayDuLieu("select * from HANGHOA order by MaHang desc");
                //         string MaHang = "";
                //         foreach (DataRow row in dtHH.Rows)
                //         {
                //             MaHang = row["MaHang"].ToString();
                //             int k = MaHang.IndexOf("h");
                //             int t = int.Parse(MaHang.Substring(k + 1)) + 1;
                //             MaHang = "h" + t;
                //             break;
                //         }

                //         DataTable dt = truyVan.LayDuLieu("select * from LOAIHANG where DienGiai = N'" + txtLoai.Text + "'");
                //         Object MaLoai = "";
                //         foreach (DataRow row in dt.Rows)
                //         {
                //             MaLoai = row["MaLoai"];
                //         }

                //         string[] name = { "@MaHang", "@TenHang", "@DonVi", "@TenNhaSX", "@GiaDeNghi", "@MaLoai", "@SoLuongSP" };
                //         string[] value = { MaHang, txtTen.Text, txtDonVi.Text, txtTenNSX.Text, txtGia.Text, MaLoai.ToString(), txtSoLuong.Text };
                //         sqlQuery sql = new sqlQuery();
                //         sql.update("ADD_HH", name, value, 7);
                //         MessageBox.Show("THÊM HÀNG HÓA THÀNH CÔNG !", "");

                //         LoadListView1();
                //     }
                // }
                // else
                // {
                //     MessageBox.Show("Mời kiểm tra lại !", "THÔNG BÁO");
                // }
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("Bạn đã nhập đủ các trường cần thiết chưa??", "Warning");
            //}
        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            // int row = this.listView1.SelectedItems[0].Index;
            // MaHH = listView1.Items[row].SubItems[1].Text;
            // txtTen.Text = this.listView1.Items[row].SubItems[2].Text;
            // txtDonVi.Text = this.listView1.Items[row].SubItems[3].Text;
            // txtTenNSX.Text = this.listView1.Items[row].SubItems[4].Text;
            // txtGia.Text = this.listView1.Items[row].SubItems[5].Text;

            // sqlQuery truyVanDL = new sqlQuery();
            // DataTable dt = truyVanDL.LayDuLieu("select * from LOAIHANG");
            // ArrayList arLH = new ArrayList();
            // foreach (DataRow rowT in dt.Rows)
            // {
            //     if (rowT["MaLoai"].Equals(listView1.Items[row].SubItems[6].Text))
            //     {
            //         arLH.Insert(0, rowT["DienGiai"]);
            //     }
            //     else
            //     {
            //         arLH.Add(rowT["DienGiai"]);
            //     }
            // }
            // txtLoai.DataSource = arLH;

            // txtSoLuong.Text = this.listView1.Items[row].SubItems[7].Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //sqlQuery truyVanDL = new sqlQuery();
            //if(!"".Equals(textBox1.Text))
            //{
            //    DataTable dt = truyVanDL.LayDuLieu("select * from HANGHOA where TenHang like N'%" + textBox1.Text + "%' or " +
            //        "MaHang like N'%" + textBox1.Text + "%' or MaLoai like N'%" + textBox1.Text + "%' or " +
            //        "DonVi like N'%" + textBox1.Text + "%' or TenNhaSX like N'%" + textBox1.Text + "%' or " +
            //        "GiaDeNghi like '%" + textBox1.Text + "%' or SoLuongSP like '%" + textBox1.Text + "%'");
            //    dataGridView1.DataSource = dt;
                

            //}
            //else
            //{
            //    DataTable dt = truyVanDL.LayDuLieu("select * from HANGHOA");
            //    dataGridView1.DataSource = dt;
            //}
            

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void tableLayoutPanel1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //ArrayList arHH = new ArrayList();
            //Add.frmHangHoa frmHH = new Add.frmHangHoa(arHH);

            //frmHH.ShowDialog();
            //sqlQuery truyVanDL = new sqlQuery();
            //DataTable dt = truyVanDL.LayDuLieu("select * from HANGHOA");
            //dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //ArrayList arHH = new ArrayList();
            //arHH.Add(dataGridView1.CurrentRow.Cells["MaHang"].Value.ToString());
            //arHH.Add(dataGridView1.CurrentRow.Cells["TenHang"].Value.ToString());
            //arHH.Add(dataGridView1.CurrentRow.Cells["DonVi"].Value.ToString());
            //arHH.Add(dataGridView1.CurrentRow.Cells["TenNhaSX"].Value.ToString());
            //arHH.Add(dataGridView1.CurrentRow.Cells["GiaDeNghi"].Value.ToString());
            //arHH.Add(dataGridView1.CurrentRow.Cells["MaLoai"].Value.ToString());
            //arHH.Add(dataGridView1.CurrentRow.Cells["SoLuongSP"].Value.ToString());
            //Edit.frmHangHoa frmHH = new Edit.frmHangHoa(arHH);

            //frmHH.ShowDialog();

            //sqlQuery truyVanDL = new sqlQuery();
            //DataTable dt = truyVanDL.LayDuLieu("select * from HANGHOA");
            //dataGridView1.DataSource = dt;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
