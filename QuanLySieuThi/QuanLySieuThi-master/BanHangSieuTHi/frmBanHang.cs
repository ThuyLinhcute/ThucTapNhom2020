using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BanHangSieuTHi.Class;
using System.Collections;

namespace BanHangSieuTHi
{
    public partial class frmBanHang : Form
    {
        SqlCommand cmd;
        sqlQuery truyVanDL = new sqlQuery();
        public frmBanHang()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-09FMHR8;Initial Catalog=QLBanHangSieuThi;Integrated Security=True");

        private void frmBanHang_Load(object sender, EventArgs e)
        {

            loadDBSdtKhachHang();
            loadDBComBoxHangHoa();
            loadDBComBoxNhanVien();
        }

        public void loadDBSdtKhachHang()
        {
            DataTable sdt = truyVanDL.LayDuLieu("select * from KHACHHANG ");

            cmbSdtKH.DataSource = sdt;

            cmbSdtKH.DisplayMember = "SdtKH".ToString().Trim();
            cmbSdtKH.SelectedIndex = -1;
        }

        private void cmbSdtKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmd = new SqlCommand("SELECT * FROM KHACHHANG WHERE SdtKH = '" + cmbSdtKH.Text.Trim() + "'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string tenKH = (string)dr["TenKH"].ToString();
                txtTenKH.Text = tenKH;

                string maKH = (string)dr["MaKH"].ToString();
                txtMaKH.Text = maKH;

                string diachi = (string)dr["DiaChiKH"].ToString();
                txtDiaChi.Text = diachi;
            }
            con.Close();
        }

        public void loadDBComBoxHangHoa()
        {
            DataTable SP = truyVanDL.LayDuLieu("select TenHang from HANGHOA");
            cmbSanPham.DataSource = SP;
            cmbSanPham.DisplayMember = "TenHang".ToString().Trim();
            cmbSanPham.SelectedIndex = -1;
        }

        private void cmbSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSoLuong.Text = "1";
            cmd = new SqlCommand("SELECT MaLoai,MaHang,GiaDeNghi FROM HANGHOA WHERE TenHang = N'" + cmbSanPham.Text.Trim() + "'", con);
            con.Open();
            cmd.ExecuteNonQuery();
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string maLoai = (string)dr["MaLoai"].ToString();
                txtMaLoai.Text = maLoai;

                string maHang = (string)dr["MaHang"].ToString();
                txtMaHang.Text = maHang;

                string donGia = (string)dr["GiaDeNghi"].ToString();
                txtDonGia.Text = donGia;
            }
            con.Close();
        }


        public void loadDBComBoxNhanVien()
        {
            sqlQuery truyvanDL = new sqlQuery();
            DataTable NV = truyvanDL.LayDuLieu("select MaNV from NHANVIEN");
            cmbNhanVien.DataSource = NV;
            cmbNhanVien.DisplayMember = "MaNV";
        }

        public void LoadDatagridView()
        {
            DataTable dt = truyVanDL.LayDuLieu("select * from CHITIETXUAT where SoHDX= '" + txtMaHD.Text.Trim() + "' ");
            dgvSanPham.DataSource = dt;
        }

        private void btnTaoHD_Click(object sender, EventArgs e)
        {
            int dem = Convert.ToInt32(truyVanDL.LayDuLieu("Select count(*) from HOADONXUAT").Rows[0][0].ToString().Trim());

            if (dem >= 0)
            {
                txtMaHD.Text = "HD0" + (dem + 1);
            }
            else if (dem >= 10)
            {
                txtMaHD.Text = "HD" + (dem + 1);
            }

            txbTongTien.Text = "0";
            if (txtMaHD.Text == "") { MessageBox.Show("Bạn chưa nhập mã HĐ"); }
            int dem1 = Convert.ToInt32(truyVanDL.LayDuLieu("Select count(*) from HOADONXUAT where SoHDX = '" + txtMaHD.Text.Trim() + "'").Rows[0][0].ToString().Trim());
            if (dem1 > 0)
            {
                MessageBox.Show("Đơn hàng này đã tồn tại!");
            }
            else
            {
                if (txtMaHD.Text != "")
                {

                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    SqlCommand cmd = new SqlCommand("HOADONXUAT_ThemHoaDon", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("SoHDX", SqlDbType.NChar)).Value = txtMaHD.Text;
                    cmd.Parameters.Add(new SqlParameter("NgayXuat", SqlDbType.Date)).Value = dTPNgayBan.Text;
                    cmd.Parameters.Add(new SqlParameter("ThanhTienXuat", SqlDbType.BigInt)).Value = Convert.ToInt32(txbTongTien.Text);
                    cmd.Parameters.Add(new SqlParameter("MaNV", SqlDbType.NChar)).Value = cmbNhanVien.Text;
                    cmd.Parameters.Add(new SqlParameter("MaKH", SqlDbType.NChar)).Value = txtMaKH.Text;
                    cmd.ExecuteNonQuery(); //thực thi

                    if (con.State == ConnectionState.Open)
                        con.Close();
                    frmBanHang_Load(sender, e);
                    MessageBox.Show("Thêm thành công!");

                }
            }

        }

        private void btnThemHH_Click(object sender, EventArgs e)
        {
            int dem2 = Convert.ToInt32(truyVanDL.LayDuLieu("Select count(*) from chitietxuat where mahang = '" + txtMaHang.Text.Trim() + "' and SoHDX = '" + txtMaHD.Text.Trim() + "'").Rows[0][0].ToString().Trim());
            float tien = Convert.ToInt32(truyVanDL.LayDuLieu("select GiaDeNghi from HANGHOA where MaHang = '" + txtMaHang.Text.Trim() + "'").Rows[0][0].ToString().Trim()) * Convert.ToInt32(txtSoLuong.Text.Trim());

            if (dem2 > 0)
            {
                MessageBox.Show("Hàng này đã có");
            }
            else
            {

                if (con.State == ConnectionState.Closed)
                    con.Open();
                SqlCommand cmd = new SqlCommand("CHITIETXUAT_ThemChiTietHoaDon", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("SoHDX", SqlDbType.NChar)).Value = txtMaHD.Text;
                cmd.Parameters.Add(new SqlParameter("MaLoai", SqlDbType.NChar)).Value = txtMaLoai.Text;
                cmd.Parameters.Add(new SqlParameter("MaHang", SqlDbType.NChar)).Value = txtMaHang.Text;
                cmd.Parameters.Add(new SqlParameter("SoLuong", SqlDbType.Int)).Value = Convert.ToInt32(txtSoLuong.Text);
                cmd.Parameters.Add(new SqlParameter("DonGia", SqlDbType.BigInt)).Value = tien;
                cmd.ExecuteNonQuery(); //thực thi            

                if (con.State == ConnectionState.Open)
                    con.Close();
                //load lại datagridview 
                LoadDatagridView();
                float tongtien = Convert.ToInt32(truyVanDL.LayDuLieu("select sum(DonGia) from CHITIETXUAT where SoHDX = '" + txtMaHD.Text.Trim() + "'").Rows[0][0].ToString().Trim());
                txbTongTien.Text = tongtien.ToString().Trim();

            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            float tienThua = Convert.ToInt32(txbTienKhachDua.Text) - Convert.ToInt32(txbTongTien.Text);
            txbTienThua.Text = tienThua.ToString().Trim();

            try
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                cmd = new SqlCommand("UPDATE HOADONXUAT SET THANHTIENXUAT = '" + txbTongTien.Text + "' WHERE SoHDX = '" + txtMaHD.Text + "' ", con);

                cmd.ExecuteNonQuery();

                if (con.State == ConnectionState.Open)
                    con.Close();
                MessageBox.Show("Thanh toán thành công!");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi Thanh toán");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn hủy đơn hàng?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    if (con.State == ConnectionState.Closed)
                        con.Open();

                    cmd = new SqlCommand("DELETE FROM CHITIETXUAT WHERE SoHDX = '" + txtMaHD.Text + "'" + "DELETE FROM HOADONXUAT WHERE SoHDX = '" + txtMaHD.Text + "'", con);
                    cmd.ExecuteNonQuery();

                    if (con.State == ConnectionState.Open)
                        con.Close();
                    frmBanHang_Load(sender, e);
                    LoadDatagridView();
                }
                catch (Exception)
                {

                    throw;
                }

            }
        }
    }
}
