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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string[] name = { "@TenDN", "@MK" };
            string[] value = { txtAcc.Text, txtPass.Text };
            sqlQuery sql = new sqlQuery();
            DataTable dt = sql.LayDuLieu("KiemTraDangNhap", name, value, 2);
            DataTable dt2= sql.LayDuLieu("KiemTraDangNhapNhanVien", name, value, 2);
            if (dt.Rows.Count != 0 || dt2.Rows.Count!=0)
            {
            MessageBox.Show("Đăng nhập thành công", "");
                Form1.TenDangNhap = txtAcc.Text;
                Form1.MatKhau = txtPass.Text;
                if (dt.Rows.Count != 0)
                {
                    Form1.Quyen = "Admin";
                }
                else Form1.Quyen = "Nhân Viên";
                this.Hide();
            Form1 frmmain = new Form1();                    
            frmmain.Show();
                frmCheckOut.MaNV = txtAcc.Text;
            
            }else
            {
                labelWarning.Visible = true;
            }
        }
    }
}
