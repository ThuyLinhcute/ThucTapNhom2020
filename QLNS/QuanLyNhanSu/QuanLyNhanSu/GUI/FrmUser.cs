using QuanLyNhanSu.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu.GUI
{
    public partial class FrmUser : Form
    {
        BindingSource list = new BindingSource();
        public FrmUser()
        {
            InitializeComponent();
            dgrQuanLyNguoiDung.DataSource = list;
            LoadAccount();
            AddNguoiDungBinding();
        }
        void LoadAccount()
        {
            list.DataSource = AccountDAO.LoadAccount();
        }
        void AddNguoiDungBinding()
        {
            txbMatKhau.DataBindings.Add(new Binding("Text", dgrQuanLyNguoiDung.DataSource, "PASSWORD", true, DataSourceUpdateMode.Never));
            txbTenDangNhap.DataBindings.Add(new Binding("Text", dgrQuanLyNguoiDung.DataSource, "USERNAME", true, DataSourceUpdateMode.Never));
            cboPhanQuyen.DataBindings.Add(new Binding("Text", dgrQuanLyNguoiDung.DataSource, "TYPE", true, DataSourceUpdateMode.Never));
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txbTenDangNhap.Text;
                string password = txbMatKhau.Text;
                string type = cboPhanQuyen.Text;
                if(AccountDAO.InsertAccount(username, password, type) == 1)
                {
                    MessageBox.Show("Thành công");
                }
                else
                {
                    MessageBox.Show("Thất bại");
                }
            }
            catch
            {
                return;
            }
            LoadAccount();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txbTenDangNhap.Text;
                string password = txbMatKhau.Text;
                string type = cboPhanQuyen.Text;
                if (AccountDAO.UpdateAccount(username, password, type) == 1)
                {
                    MessageBox.Show("Thành công");
                }
                else
                {
                    MessageBox.Show("Thất bại");
                }
            }
            catch
            {
                return;
            }
            LoadAccount();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txbTenDangNhap.Text;
                if (AccountDAO.DeleteAccount(username) == 1)
                {
                    MessageBox.Show("Thành công");
                }
                else
                {
                    MessageBox.Show("Thất bại");
                }
            }
            catch
            {
                return;
            }
            LoadAccount();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
