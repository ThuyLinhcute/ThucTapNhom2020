using QuanLyNhanSu.DAO;
using QuanLyNhanSu.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string pass = textBox2.Text;
            if(AccountDAO.Login(username, pass))
            {
                AccountDTO acc = AccountDAO.GetAccount(username);
                string type = acc.Type.ToString();
                if(type == "Admin")
                {
                    FrmMain frm = new FrmMain(1);
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    FrmMain frm = new FrmMain(0);
                    frm.Show();
                    this.Hide();
                }
            }
            else
               {
                    MessageBox.Show(this, "Tên đăng nhập hoặc mật khẩu sai");
               }
        }

          private void textBox1_TextChanged(object sender, EventArgs e)
          {

          }
     }
}
