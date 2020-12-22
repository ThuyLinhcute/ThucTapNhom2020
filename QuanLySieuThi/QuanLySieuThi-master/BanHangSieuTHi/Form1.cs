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
    public partial class Form1 : Form
    {
        public static string TenDangNhap= string.Empty;
        public static string MatKhau=string.Empty;
        public static string Quyen=string.Empty;
        public Form1()
        {
            InitializeComponent();
            lblAcc.Text = TenDangNhap;
            lblQuyen.Text = Quyen;
        }
  
        private void button1_Click_1(object sender, EventArgs e)
        {

            flowLayoutPanel1.Controls.Clear();
            frmBanHang frm = new frmBanHang();
            //frmBanHang2 frm = new frmBanHang2();
            frm.TopLevel = false;
            flowLayoutPanel1.Controls.Add(frm);
            frm.Size = new System.Drawing.Size(901, 533);
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            frmHoaDon frm = new frmHoaDon();
            frm.TopLevel = false;
            flowLayoutPanel1.Controls.Add(frm);
            frm.Size = new System.Drawing.Size(925, 574);
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            frmHangHoaMain frm = new frmHangHoaMain();
            frm.TopLevel = false; 
            frm.Size = new System.Drawing.Size(901, 550);
            flowLayoutPanel1.Controls.Add(frm);         
            frm.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            frmQLKH frm = new frmQLKH();
            frm.TopLevel = false;
            flowLayoutPanel1.Controls.Add(frm);
            frm.Size = new System.Drawing.Size(925, 574);
            frm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            frmQLNV frm = new frmQLNV();
            frm.TopLevel = false;
            flowLayoutPanel1.Controls.Add(frm);
            frm.Size = new System.Drawing.Size(1070, 614);
            frm.Show();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            frmThongKe frm = new frmThongKe();
            frm.TopLevel = false;
            flowLayoutPanel1.Controls.Add(frm);
            frm.Size = new System.Drawing.Size(901, 550);
            frm.Show();
        }
        private void btnQlNguoiDung_Click(object sender,EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            frmQLUser frm = new frmQLUser();
            frm.TopLevel = false;
            flowLayoutPanel1.Controls.Add(frm);
            frm.Size = new System.Drawing.Size(901, 550);
            frm.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
           Login frmLogin = new Login();
            frmLogin.Show();
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
