using BanHangSieuTHi.Class;
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
    public partial class frmThemUser : Form
    {
        public frmThemUser()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbMatKhau.Text == tbMatKhau2.Text)
                {
                    DialogResult result;
                    result = MessageBox.Show("BẠN CÓ MUỐN XÓA NGƯỜI DÙNG NÀY KHÔNG?", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        string[] name = { "@TenDangNhap", "@TenNguoiDung", "@MatKhau", "@HinhAnh", "@QuyenTruyCap" };
                        string[] value = { tbTenDangNhap.Text, tbTenNguoiDung.Text, tbMatKhau.Text, tbImage.Text, cbQuyen.SelectedItem.ToString() };
                        sqlQuery sql = new sqlQuery();
                        sql.update("ADD_USER", name, value, 5);
                        MessageBox.Show("THÊM NGƯỜI DÙNG THÀNH CÔNG !", "");
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Kiểm tra lại phần xác nhận mật khẩu và mật khẩu ko giống nhau!", "THÔNG BÁO");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Bạn đã nhập đủ các trường cần thiết chưa??", "Warning");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnImage_Click(object sender, EventArgs e)
        {

        }
    }
}
