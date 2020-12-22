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
    public partial class frmChiTietHoaDonXuat : Form
    {
        
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-09FMHR8;Initial Catalog=QLKhoHang;Integrated Security=True");
        sqlQuery truyVanDL = new sqlQuery();
        private string MaHD;

        public frmChiTietHoaDonXuat()
        {
            InitializeComponent();
        }

        public frmChiTietHoaDonXuat(string MaHDX) : this()
        {
            MaHD = MaHDX;
            txtHDX.Text = MaHD;
        }
        private void frmChiTietHoaDonXuat_Load(object sender, EventArgs e)
        {
            LoadDatagridView();
            txtTongTien.Text = Convert.ToString(truyVanDL.LayDuLieu("Select ThanhTienXuat from HOADONXUAT where SoHDX='"+txtHDX.Text +"'").Rows[0][0].ToString().Trim());
            
        }
        //load lại datagridview
        public void LoadDatagridView()
        {           
            DataTable dt = truyVanDL.LayDuLieu("select * from CHITIETXUAT where SoHDX= '" + txtHDX.Text.Trim() + "' ");
            dgvHangHoa.DataSource = dt;
        }


        private void dgvHangHoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {        
             if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
             {
                 txtHDX.Text = dgvHangHoa.CurrentRow.Cells["SoHDX"].Value.ToString().Trim();
                 txtMaLoai.Text = dgvHangHoa.CurrentRow.Cells["MaLoai"].Value.ToString().Trim();
                 txtMaHang.Text = dgvHangHoa.CurrentRow.Cells["MaHang"].Value.ToString().Trim();
                 txtSoLuong.Text = dgvHangHoa.CurrentRow.Cells["SoLuong"].Value.ToString().Trim();
                txtDonGia.Text = dgvHangHoa.CurrentRow.Cells["DonGia"].Value.ToString().Trim();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
