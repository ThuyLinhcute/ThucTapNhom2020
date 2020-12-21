using DevExpress.XtraEditors;
using DXApplication1.Models;
using DXApplication1.Utilizes;
using System;

using System.Collections.Generic;

namespace DXApplication1.Views
{
    public partial class frmDky : DevExpress.XtraEditors.XtraForm
    {
        
        
        public frmDky()
        {
            InitializeComponent();
            
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

            // Bắt lỗi nhập thông tin.
            try
            {
                if (txtUser.Text == "" || txtPass.Text == "" || txtRePass.Text == ""
                   || txtHoTen.Text == "")
                    throw new Exception("Bạn phải nhập đầy đủ thông tin!");
                if (txtDiaChi.Text == "")
                    txtDiaChi.Text = null;
                if (txtEmail.Text == "")
                    txtEmail.Text = null;
                if (dateNgaySinh.Text == "")
                    dateNgaySinh.Text = null;
                if (txtSoDienThoai.Text == "")
                    txtSoDienThoai.Text = null;
                if (txtRePass.Text != txtPass.Text)
                    throw new Exception("Mật khẩu xác nhận không đúng!");
                if (!UserUtilizes.IsValidEmail(txtEmail.Text) && txtEmail.Text != "")
                {
                    throw new Exception("Hãy nhập một email hợp lệ");
                }

                if (!UserUtilizes.IsPhoneNumber(txtSoDienThoai.Text) && txtSoDienThoai.Text != "")
                {
                    throw new Exception("Hãy nhập vào số điện thoại đúng");
                }
                if (!UserUtilizes.IsValidDay(dateNgaySinh.DateTime.Date) && dateNgaySinh.Text != "")
                {
                    throw new Exception("Hãy nhập vào ngày sinh đúng");
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
                return;
            }

            //// Đăng kí tài khoản
            ///

            DangKy(txtUser.Text.ToLower(), txtPass.Text.ToLower(), txtHoTen.Text,
                txtEmail.Text, txtSoDienThoai.Text, txtDiaChi.Text, dateNgaySinh.DateTime);
        }


        public bool DangKy(string maDangNhap, string matKhau, string hoTen, string email, string soDienThoai, string diaChi, DateTime ngaySinh)
        {
            string hashedPassword = Utilizes.UserUtilizes.GetHashString(matKhau);
           
            ThongTinNguoiDung thongTinNguoiDung = new ThongTinNguoiDung
            {
                MaDangNhapNguoiDung = maDangNhap,
                HoTen = hoTen,
                Email = email,
                SoDienThoai = soDienThoai,
                DiaChi = diaChi,
                NgaySinh = ngaySinh
            };
            NguoiDung nguoiDung = new NguoiDung
            {
                MaDangNhapNguoiDung = maDangNhap,
                MatKhau = hashedPassword,
                ThongTinNguoiDung = thongTinNguoiDung
            };
            if (Program.ndSql.Register(nguoiDung))
            {
                return true;
            }    
                
            return false;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkEditHienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEditHienMatKhau.Checked == true)
                txtPass.Properties.UseSystemPasswordChar = false;
            else
            {
                txtPass.Properties.UseSystemPasswordChar = true;
           
            }
        }

        private void checkEditHienMatKhauNhapLai_CheckedChanged(object sender, EventArgs e)
        {
            if (checkEditHienMatKhauNhapLai.Checked == true)
               
                txtRePass.Properties.UseSystemPasswordChar = false;
            else
            {
                txtRePass.Properties.UseSystemPasswordChar = true;
            
            }
        }

        private void frmDky_Load(object sender, EventArgs e)
        {
            
        }
    }
}