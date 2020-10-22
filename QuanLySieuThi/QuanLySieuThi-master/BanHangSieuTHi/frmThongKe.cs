using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BanHangSieuTHi.Class;
using System.Windows.Forms;

namespace BanHangSieuTHi
{
    public partial class frmThongKe : Form
    {
        public frmThongKe()
        {
            InitializeComponent();
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int check;
            check = comboBox1.SelectedIndex;
            if(check == 0)
            {
                
                sqlQuery truyVanDL = new sqlQuery();
                DataTable dt = truyVanDL.LayDuLieu("select c.mahang,h.tenhang,l.diengiai,n.soluongnhap,c.soluong,h.soluongsp from LoaiHang as l,ChiTietXuat as c,HangHoa as h,ChiTietNhap as n where c.SoLuong > 5 and h.mahang=c.mahang  and n.mahang=c.mahang and c.maloai=l.maloai");
                listView1.Items.Clear();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    ListViewItem item = new ListViewItem(dt.Rows[i][0].ToString());
                    item.SubItems.Add(dt.Rows[i][1].ToString());
                    item.SubItems.Add(dt.Rows[i][2].ToString());
                    item.SubItems.Add(dt.Rows[i][3].ToString());
                    item.SubItems.Add(dt.Rows[i][4].ToString());
                    item.SubItems.Add(dt.Rows[i][5].ToString());
                    listView1.Items.Add(item);
                }
            }else if (check==1)
            {
                listView1.Items.Clear();
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            int check = comboBox1.SelectedIndex;
            if (check == 0) { 
            frmBaoCaoThongKe frm = new frmBaoCaoThongKe();
            frm.Show();
            }
        }

        private void frmThongKe_Load(object sender, EventArgs e)
        {
            sqlQuery truyVanDL = new sqlQuery();
            DataTable dt = truyVanDL.LayDuLieu("Select diengiai from LOAIHANG");
            DataTable dt1 = truyVanDL.LayDuLieu("Select tenNCC from NHACUNGCAP");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cbLoaiHang.Items.Add(dt.Rows[i][0].ToString());            
            }
            for (int j=0; j < dt1.Rows.Count; j++)
            {
                cbNhaCC.Items.Add(dt1.Rows[j][0].ToString());
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            listViewNhap.Items.Clear();
            listViewXuat.Items.Clear();
            sqlQuery truyVanDL = new sqlQuery();
                string addLoai, addNCC, MaLoai,MaNCC;
            if (cbLoaiHang.SelectedIndex == -1)
            {
                addLoai = "";
            }
            else
            {                
                DataTable dt2 = truyVanDL.LayDuLieu("select MaLoai from LOAIHANG where DienGiai=N'" + cbLoaiHang.SelectedItem.ToString() + "'");
                MaLoai = dt2.Rows[0][0].ToString();
                addLoai = " and c.MaLoai = '" + MaLoai + "'";
            }
            if (cbNhaCC.SelectedIndex==-1)
            {
                addNCC = "";
            }
            else
            {
                DataTable dt1 = truyVanDL.LayDuLieu("select MaNCC from NHACUNGCAP where TenNCC=N'" + cbNhaCC.SelectedItem.ToString() + "'");
                MaNCC = dt1.Rows[0][0].ToString();
                addNCC = " and hd.MaNCC='" + MaNCC + "'";
            }
                dateTimePicker1.ShowUpDown = true;
                dateTimePicker2.ShowUpDown = true;
           

            
            DataTable dt = truyVanDL.LayDuLieu("Select h.Mahang,h.TenHang,c.SoLuongNhap,c.DonGiaN from CHITIETNHAP as c , HANGHOA as h,HOADONNHAP as hd where c.SoHDN= hd.SoHDN and h.MaHang=c.MaHang and hd.NgayNhap between cast('"+ dateTimePicker1.Value.ToString("yyyy/MM/dd")+"' as date) and cast('" + dateTimePicker2.Value.ToString("yyyy/MM/dd")+"' as date)"+addLoai+addNCC+"");
            int soSPNhap = dt.Rows.Count, SLNhap = 0, thanhtien = 0;
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem item = new ListViewItem((i+1).ToString());
                item.SubItems.Add(dt.Rows[i][0].ToString());
                item.SubItems.Add(dt.Rows[i][1].ToString());
                item.SubItems.Add(dt.Rows[i][2].ToString());
                int tien =Int16.Parse(dt.Rows[i][3].ToString()) * Int16.Parse(dt.Rows[i][3].ToString());
                item.SubItems.Add(tien.ToString());          
                listViewNhap.Items.Add(item);              
                SLNhap = SLNhap + Int16.Parse(dt.Rows[i][2].ToString());
                thanhtien = thanhtien + tien;
            }
            txtSoSPNhap.Text = soSPNhap.ToString();
            txtSLNhap.Text = SLNhap.ToString();
            txtTienNhap.Text = thanhtien.ToString();

            DataTable dt4 = truyVanDL.LayDuLieu("Select h.Mahang,h.TenHang,c.SoLuong,c.DonGia from CHITIETXUAT as c , HANGHOA as h,HOADONXUAT as hd where c.SoHDX= hd.SoHDX and h.MaHang=c.MaHang and hd.NgayXuat between cast('" + dateTimePicker1.Value.ToString("yyyy/MM/dd") + "' as date) and cast('" + dateTimePicker2.Value.ToString("yyyy/MM/dd") + "' as date)" + addLoai + "");
            int soSPBan = dt4.Rows.Count, SLBan = 0, thanhtien1 = 0;
            for (int i = 0; i < dt4.Rows.Count; i++)
            {
                ListViewItem item = new ListViewItem((i + 1).ToString());
                item.SubItems.Add(dt4.Rows[i][0].ToString());
                item.SubItems.Add(dt4.Rows[i][1].ToString());
                item.SubItems.Add(dt4.Rows[i][2].ToString());
                int tien = Int16.Parse(dt4.Rows[i][3].ToString()) * Int16.Parse(dt4.Rows[i][3].ToString());
                item.SubItems.Add(tien.ToString());
                listViewXuat.Items.Add(item);
                SLBan = SLBan + Int16.Parse(dt4.Rows[i][2].ToString());
                thanhtien1 = thanhtien1 + tien;
            }
            txtSoSPBan.Text = soSPBan.ToString();
            txtSLBan.Text = SLBan.ToString();
            txtTienBan.Text = thanhtien1.ToString();
        }
            
        }
    }

