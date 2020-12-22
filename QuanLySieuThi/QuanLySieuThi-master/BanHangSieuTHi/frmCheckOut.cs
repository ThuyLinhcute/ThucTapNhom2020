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
    public partial class frmCheckOut : Form
    {
        public static string MaNV = string.Empty;
        public int TongTien;
        public string MaKH;

        public frmCheckOut(int _TongTien,string _MaKH)
        {
            InitializeComponent();
            TongTien = _TongTien;
            MaKH = _MaKH;
        }

        private void frmCheckOut_Load(object sender, EventArgs e)
        {
            txtPhaiTra.Text = TongTien.ToString();
            txtDaTra.KeyUp += new KeyEventHandler(txtDaTra_KeyUp);
        }

        private void txtDaTra_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int soDu = Convert.ToInt32(txtDaTra.Text) - Convert.ToInt16(txtPhaiTra.Text);
                txtSoDu.Text = soDu.ToString();
            }
        }

        private void btnTT_Click(object sender, EventArgs e)
        {           
        //     Random random = new Random(); 
        //     int SoHDX = random.Next(1000, 1999);
            
        //    while(KiemTraTrungLap(SoHDX.ToString()))
        //     {
        //         SoHDX = random.Next(1000, 1999);
        //     }

        //     DialogResult result;
        //     result = MessageBox.Show("BẠN CÓ CHẮC CHẮN MUỐN THANH TOÁN ĐƠN HÀNG NÀY", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        //     if (result == DialogResult.Yes)
        //     {

        //         //sqlQuery truyVan = new sqlQuery();
        //         //truyVan.ExecuteNoneQuery("Insert into HOADONXUAT(SoHDX,NgayXuat,ThanhTienXuat,MaNV,MaKH) values('"+SoHDX.ToString()+"','"+DateTime.Now+"','"+TongTien.ToString()+"','"+MaNV+"','"+DBNull.Value+"')");
        //         string connectionString = @"Data Source=DESKTOP-09FMHR8;Initial Catalog=QLKhoHang;Integrated Security=True";
        //         SqlConnection con = new SqlConnection(connectionString);
        //         con.Open();
        //         string str = "insert into HOADONXUAT values(@SoHDX,@NgayXuat,@ThanhTienXuat,@MaNV,@MaKH)";
        //         SqlCommand cmd = new SqlCommand(str, con);
        //         cmd.CommandType = CommandType.Text;
        //         cmd.Parameters.AddWithValue("@SoHDX", SoHDX.ToString());
        //         cmd.Parameters.AddWithValue("@NgayXuat", DateTime.Now);
        //         cmd.Parameters.AddWithValue("@ThanhTienXuat", TongTien.ToString());
        //         cmd.Parameters.AddWithValue("@MaNV", MaNV);
        //         if (MaKH == "")
        //         {
        //             cmd.Parameters.AddWithValue("@MaKH", DBNull.Value); }
        //         else
        //         {
        //             cmd.Parameters.AddWithValue("@MaKH", MaKH);
        //         }
        //         cmd.ExecuteNonQuery(); //thực thi            

        //         if (con.State == ConnectionState.Open)
        //             con.Close();

        //         MessageBox.Show("THANH TOÁN THÀNH CÔNG", "THÔNG BÁO");
        //         this.Close();
        //     }
           
        }

        private bool KiemTraTrungLap(string x)
        {
            // int temp=0;
            // sqlQuery truyVan = new sqlQuery();
            // DataTable td = truyVan.LayDuLieu("select SoHDX from HOADONXUAT ");
            // for(int i = 0; i < td.Rows.Count; i++)
            // {
            //     if (x == td.Rows[i][0].ToString())
            //     {
            //         temp = 1;
            //     }
            //     else { temp = 0; }

            // }
            // if (temp == 0)
            // {
            //     return false;
            // }
            // else { return true; }
        }
    }
}
