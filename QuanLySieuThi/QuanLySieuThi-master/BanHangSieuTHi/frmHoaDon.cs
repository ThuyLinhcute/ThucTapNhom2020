using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Data.SqlClient;
using BanHangSieuTHi.Class;

namespace BanHangSieuTHi
{
    public partial class frmHoaDon : Form
    {
        private string TongTien;
        
        public frmHoaDon()
        {
            InitializeComponent();                   
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-09FMHR8;Initial Catalog=QLBanHangSieuThi;Integrated Security=True");

        private void frmHoaDon_Load(object sender, EventArgs e)
        {
            loadListView();

            loadDBComBoxNhanVienN();
            loadDBComBoxNhaCC();
            sqlQuery truyVanDL = new sqlQuery();
            DataTable da = truyVanDL.LayDuLieu("select N.SoHDN, N.MaNV, N.MaNCC, N.NgayNhap, N.ThanhTienNhap from HOADONNHAP N");
            dtgvDSHDN.DataSource = da;
        }

        public void loadListView()
        {
            lsvDSHDX.Items.Clear();
            sqlQuery truyVanDL = new sqlQuery();
            DataTable dt = truyVanDL.LayDuLieu("select * from HOADONXUAT ");                      

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ListViewItem item = new ListViewItem((i+1).ToString());
                
                item.SubItems.Add(dt.Rows[i][0].ToString());
                item.SubItems.Add(dt.Rows[i][1].ToString());
                item.SubItems.Add(dt.Rows[i][2].ToString());
                item.SubItems.Add(dt.Rows[i][3].ToString());
                item.SubItems.Add(dt.Rows[i][4].ToString());
                lsvDSHDX.Items.Add(item);
            }
        }
        //Load data lên txt
        private void lsvDSHDX_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in lsvDSHDX.SelectedItems)
            {             
                txtMaHDX.Text = item.SubItems[1].Text.Trim();
                dTPNgayXuat.Text = item.SubItems[2].Text.Trim();
                txtNhanVien.Text = item.SubItems[4].Text.Trim();
                txtKhachHang.Text = item.SubItems[5].Text.Trim();
            }
        }


        public void XoaHoaDon(string SoHDX)
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            string sql = "HOADONXUAT_XoaHoaDon";
            SqlCommand comd = new SqlCommand(sql, con);
            comd.CommandType = CommandType.StoredProcedure;
            comd.Parameters.Add(new SqlParameter("SoHDX", SqlDbType.NChar)).Value = SoHDX;
            comd.ExecuteNonQuery(); //thực thi

        }
        private void btnXoaX_Click(object sender, EventArgs e)
        {
            if (txtMaHDX.Text == "") { MessageBox.Show("Bạn chưa chọn hóa đơn"); }

            if (txtMaHDX.Text != "")
            {
                if (MessageBox.Show("Bạn muốn Xóa hóa đơn?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    sqlQuery truyVanDL = new sqlQuery();
                    truyVanDL.ExecuteNoneQuery("DELETE fROM CHITIETXUAT WHERE SoHDX='"+ txtMaHDX.Text+"'"); //Xóa phần chi tiết
                    XoaHoaDon(txtMaHDX.Text);
                    frmHoaDon_Load(sender, e);
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmChiTietHoaDonXuat frm = new frmChiTietHoaDonXuat(txtMaHDX.Text);
            frm.ShowDialog();    
        }

        //THÊM SỬA XÓA HOADONNHAP

        public void loadDBComBoxNhanVienN()
        {
            sqlQuery truyvanDL = new sqlQuery();
            DataTable NV = truyvanDL.LayDuLieu("select MaNV from NHANVIEN");
            cmbNhanVienN.DataSource = NV;
            cmbNhanVienN.DisplayMember = "MaNV";
        }

        public void loadDBComBoxNhaCC()
        {
            sqlQuery truyvanDL = new sqlQuery();
            DataTable NCC = truyvanDL.LayDuLieu("select MaNCC from NHACUNGCAP");
            cmbNhaCungCap.DataSource = NCC;
            cmbNhaCungCap.DisplayMember = "MaNCC";
        }

        private void dtgvDSHDN_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                txtMaHDN.Text = dtgvDSHDN.CurrentRow.Cells["SoHDN"].Value.ToString().Trim();
                dTPNgayNhap.Text = dtgvDSHDN.CurrentRow.Cells["NgayNhap"].Value.ToString().Trim();
                cmbNhanVienN.Text = dtgvDSHDN.CurrentRow.Cells["MaNV"].Value.ToString().Trim();
                cmbNhaCungCap.Text = dtgvDSHDN.CurrentRow.Cells["MaNCC"].Value.ToString().Trim();
            }
        }

        private void btnThemN_Click(object sender, EventArgs e)
        {
            int count = 0;
            count = dtgvDSHDN.Rows.Count; // đếm các dòng trong datagridview

            if (count >= 0)
            {
                txtMaHDN.Text = "HDN0" + (count + 1);
            }
            else if (count >= 10)
            {
                txtMaHDN.Text = "HDN" + (count + 1);
            }

            
            if (cmbNhanVienN.Text == "") { MessageBox.Show("Nhân viên lập chưa có"); }
            if (cmbNhaCungCap.Text == "") { MessageBox.Show("Nhà cung cấp chưa có"); }

            if (cmbNhaCungCap.Text != "" && cmbNhanVienN.Text != "")
            {
                int thanhTien = 0;                                                                

                if (con.State == ConnectionState.Closed)
                    con.Open();
                string sql = "HOADONNHAP_ThemHoaDonN";
                SqlCommand comd = new SqlCommand(sql, con);
                comd.CommandType = CommandType.StoredProcedure;
                comd.Parameters.Add(new SqlParameter("SoHDN", SqlDbType.NChar)).Value = txtMaHDN.Text;
                comd.Parameters.Add(new SqlParameter("NgayNhap", SqlDbType.Date)).Value = dTPNgayNhap.Text;
                comd.Parameters.Add(new SqlParameter("ThanhTienNhap", SqlDbType.BigInt)).Value = thanhTien;
                comd.Parameters.Add(new SqlParameter("MaNV", SqlDbType.NChar)).Value = cmbNhanVienN.Text;
                comd.Parameters.Add(new SqlParameter("MaNCC", SqlDbType.NChar)).Value = cmbNhaCungCap.Text;
                comd.ExecuteNonQuery(); //thực thi

                frmHoaDon_Load(sender, e);

                frmChiTietHoaDonNhap frm = new frmChiTietHoaDonNhap(txtMaHDN.Text);
                frm.ShowDialog();
            }
        }

        private void btnXoaN_Click(object sender, EventArgs e)
        {
            if (txtMaHDN.Text == "") { MessageBox.Show("Bạn chưa chọn hóa đơn"); }

            if (txtMaHDN.Text != "")
            {
                if (MessageBox.Show("Bạn muốn Xóa hóa đơn?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    sqlQuery truyVanDL = new sqlQuery();
                    truyVanDL.ExecuteNoneQuery("DELETE fROM CHITIETNHAP WHERE SoHDN='" + txtMaHDN.Text + "'"); //Xóa phần chi tiết

                    //Thủ tục xóa phần hóa đơn
                    if (con.State == ConnectionState.Closed)
                        con.Open();
                    string sql = "HOADONNHAP_XoaHoaDonN";
                    SqlCommand comd = new SqlCommand(sql, con);
                    comd.CommandType = CommandType.StoredProcedure;
                    comd.Parameters.Add(new SqlParameter("SoHDN", SqlDbType.NChar)).Value = txtMaHDN.Text;
                    comd.ExecuteNonQuery(); //thực thi

                    frmHoaDon_Load(sender, e);
                }
            }
        }

        private void btnSuaN_Click(object sender, EventArgs e)
        {
            if (txtMaHDN.Text == "") { MessageBox.Show("Bạn chưa chọn hóa đơn"); }

            if (txtMaHDN.Text != "")
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string sql = "HOADONNHAP_SuaHoaDonN";
                SqlCommand comd = new SqlCommand(sql, con);
                comd.CommandType = CommandType.StoredProcedure;
                comd.Parameters.Add(new SqlParameter("SoHDN", SqlDbType.NChar)).Value = txtMaHDN.Text;
                comd.Parameters.Add(new SqlParameter("NgayNhap", SqlDbType.Date)).Value = dTPNgayNhap.Text;
                comd.Parameters.Add(new SqlParameter("MaNV", SqlDbType.NChar)).Value = cmbNhanVienN.Text;
                comd.Parameters.Add(new SqlParameter("MaNCC", SqlDbType.NChar)).Value = cmbNhaCungCap.Text;
                comd.ExecuteNonQuery(); //thực thi

                frmHoaDon_Load(sender, e);
            }
        }

        private void btnInHoaDonN_Click(object sender, EventArgs e)
        {
            frmChiTietHoaDonNhap frm = new frmChiTietHoaDonNhap(txtMaHDN.Text);
            frm.ShowDialog();            
        }

          private void tabPage1_Click(object sender, EventArgs e)
          {

          }
     }
}
