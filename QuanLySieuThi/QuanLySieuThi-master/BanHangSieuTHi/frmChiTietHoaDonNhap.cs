using BanHangSieuTHi.Class;
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

namespace BanHangSieuTHi
{
    public partial class frmChiTietHoaDonNhap : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-09FMHR8;Initial Catalog=QLKhoHang;Integrated Security=True");
        sqlQuery truyVanDL = new sqlQuery();
        private string MaHD;
        public frmChiTietHoaDonNhap()
        {
            InitializeComponent();
        }

        public frmChiTietHoaDonNhap(string MaHDN) : this()
        {
            MaHD = MaHDN;
            txtHDN.Text = MaHD;
        }
        private void frmChiTietHoaDonNhap_Load(object sender, EventArgs e)
        {
            loadDBComBoxHangHoa();
            LoadDatagridView();
        }

        public void loadDBComBoxHangHoa()
        {
            DataTable SP = truyVanDL.LayDuLieu("select * from HANGHOA");
            cmbHangHoa.DataSource = SP;
            cmbHangHoa.DisplayMember = "TenHang";
            //cmbHangHoa.ValueMember = "MaHang";   
            AddBinding();
        }

        void AddBinding()
        {
            //vd: lấy dữ liệu của cmbHangHoa, Lấy trường TenHang đổ vào thuộc tính text của control txtTenHang.
            txtMaHang.DataBindings.Add(new Binding("Text", cmbHangHoa.DataSource, "MaHang"));
            txtMaLoai.DataBindings.Add(new Binding("Text", cmbHangHoa.DataSource, "MaLoai"));
            txtDonGia.DataBindings.Add(new Binding("Text", cmbHangHoa.DataSource, "GiaDeNghi"));
        }

        public void LoadDatagridView()
        {
            DataTable dt = truyVanDL.LayDuLieu("select * from CHITIETNHAP where SoHDN= '" + txtHDN.Text.Trim() + "' ");
            dgvHangHoa.DataSource = dt;
        }

        private void dgvHangHoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            // {
            //     txtHDN.Text = dgvHangHoa.CurrentRow.Cells["SoHDN"].Value.ToString().Trim();
            //     txtMaLoai.Text = dgvHangHoa.CurrentRow.Cells["MaLoai"].Value.ToString().Trim();
            //     txtMaHang.Text = dgvHangHoa.CurrentRow.Cells["MaHang"].Value.ToString().Trim();
            //     txtSoLuong.Text = dgvHangHoa.CurrentRow.Cells["SoLuongNhap"].Value.ToString().Trim();
            //     txtDonGia.Text = dgvHangHoa.CurrentRow.Cells["DonGiaN"].Value.ToString().Trim();
            //     dTPNSX.Text = dgvHangHoa.CurrentRow.Cells["NgaySX"].Value.ToString().Trim();
            //     dTPHSD.Text = dgvHangHoa.CurrentRow.Cells["HSD"].Value.ToString().Trim();
            // }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // int dem = Convert.ToInt32(truyVanDL.LayDuLieu("Select count(*) from CHITIETNHAP where mahang = '" + txtMaHang.Text.Trim() + "' and SoHDN = '" + txtHDN.Text.Trim() + "'").Rows[0][0].ToString().Trim());

            // if (dem > 0)
            // {
            //     MessageBox.Show("Hàng này đã có");
            // }
            // else
            // {
            //     if (txtSoLuong.Text == "")
            //     {
            //         MessageBox.Show("Chưa nhập số lượng");
            //     }
            //     else
            //     {
            //         float tien = Convert.ToInt32(truyVanDL.LayDuLieu("select GiaDeNghi from HANGHOA where MaHang = '" + txtMaHang.Text.Trim() + "'").Rows[0][0].ToString().Trim()) * Convert.ToInt32(txtSoLuong.Text.Trim());
            //         if (con.State == ConnectionState.Closed)
            //             con.Open();
            //         SqlCommand cmd = new SqlCommand("CHITIETNHAP_ThemChiTietHoaDonN", con);
            //         cmd.CommandType = CommandType.StoredProcedure;
            //         cmd.Parameters.Add(new SqlParameter("SoHDN", SqlDbType.NChar)).Value = txtHDN.Text;
            //         cmd.Parameters.Add(new SqlParameter("MaLoai", SqlDbType.NChar)).Value = txtMaLoai.Text;
            //         cmd.Parameters.Add(new SqlParameter("MaHang", SqlDbType.NChar)).Value = txtMaHang.Text;
            //         cmd.Parameters.Add(new SqlParameter("SoLuongNhap", SqlDbType.Int)).Value = Convert.ToInt32(txtSoLuong.Text);
            //         cmd.Parameters.Add(new SqlParameter("DonGiaN", SqlDbType.BigInt)).Value = tien;
            //         cmd.Parameters.Add(new SqlParameter("NgaySX", SqlDbType.Date)).Value = dTPNSX.Text;
            //         cmd.Parameters.Add(new SqlParameter("HSD", SqlDbType.Date)).Value = dTPHSD.Text;
            //         cmd.ExecuteNonQuery(); //thực thi            

            //         //load lại datagridview 
            //         LoadDatagridView();
            //     }
            // }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            // float tien = Convert.ToInt32(truyVanDL.LayDuLieu("select GiaDeNghi from HANGHOA where MaHang = '" + txtMaHang.Text.Trim() + "'").Rows[0][0].ToString().Trim()) * Convert.ToInt32(txtSoLuong.Text.Trim());
            // float tongtien = Convert.ToInt32(truyVanDL.LayDuLieu("select sum(DonGiaN) from CHITIETNHAP where SoHDN = '" + txtHDN.Text.Trim() + "'").Rows[0][0].ToString().Trim());
            // int id = Convert.ToInt32(truyVanDL.LayDuLieu("select ID from CHITIETNHAP where MaHang = '" + txtMaHang.Text.Trim() + "' and SoHDN = '" + txtHDN.Text.Trim() + "'").Rows[0][0].ToString().Trim());
            // if (con.State == ConnectionState.Closed)
            //     con.Open();
            // SqlCommand cmd = new SqlCommand("CHITIETNHAP_SuaChiTietHoaDonN", con);
            // cmd.CommandType = CommandType.StoredProcedure;
            // cmd.Parameters.Add(new SqlParameter("ID", SqlDbType.Int)).Value = id;
            // cmd.Parameters.Add(new SqlParameter("SoLuongNhap", SqlDbType.Int)).Value = txtSoLuong.Text;
            // cmd.Parameters.Add(new SqlParameter("DonGiaN", SqlDbType.BigInt)).Value = tien;
            // cmd.Parameters.Add(new SqlParameter("NgaySX", SqlDbType.Date)).Value = dTPNSX.Text;
            // cmd.Parameters.Add(new SqlParameter("HSD", SqlDbType.Date)).Value = dTPHSD.Text;
            // cmd.ExecuteNonQuery(); //thực thi

            // LoadDatagridView();
            // txtTongTien.Text = tongtien.ToString().Trim();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            truyVanDL.ExecuteNoneQuery("UPDATE HOADONNHAP SET thanhtiennhap='"+ txtTongTien.Text +"' WHERE SoHDN='" + txtHDN.Text + "'");
            MessageBox.Show("Lưu thành công!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // if (MessageBox.Show("Bạn chắc chắn muốn xóa?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            // {
            //     if (con.State == ConnectionState.Closed)
            //         con.Open();
            //     SqlCommand cmd = new SqlCommand("CHITIETNHAP_XoaChiTietHoaDonN", con);
            //     cmd.CommandType = CommandType.StoredProcedure;
            //     cmd.Parameters.Add(new SqlParameter("ID", SqlDbType.Int)).Value = dgvHangHoa.CurrentRow.Cells["ID"].Value.ToString().Trim();
            //     cmd.ExecuteNonQuery(); //thực thi       

            //     LoadDatagridView();
            // }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
