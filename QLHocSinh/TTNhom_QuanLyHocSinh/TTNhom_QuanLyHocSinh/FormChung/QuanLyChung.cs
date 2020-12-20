using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using TTNhom_QuanLyHocSinh.QLHocSinh;

namespace TTNhom_QuanLyHocSinh.Views
{
    public partial class QuanLyChung : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        int chk = 0;
        public QuanLyChung()
        {
            InitializeComponent();
        }

        public void barButtonItemQLHocSinh_ItemClick(object sender, ItemClickEventArgs e)
        {
               QLHS qLHS = new QLHS();

               qLHS.TopLevel = false;
               panelMain.Controls.Clear();
               panelMain.Dock = DockStyle.Fill;
               panelMain.Controls.Add(qLHS);
               qLHS.Dock = DockStyle.Fill;
               qLHS.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
               qLHS.Show();
          }

        private void barButtonItemGiaoVien_ItemClick(object sender, ItemClickEventArgs e)
        {
           
        }

        private void barButtonItemQLLop_Diem_ItemClick(object sender, ItemClickEventArgs e)
        {
           
        }

        private void barButtonItemGiangDay_ItemClick(object sender, ItemClickEventArgs e)
        {
            
        }

        

        private void barButtonItemqllop_ItemClick(object sender, ItemClickEventArgs e)
        {
            
        }

        private void barButtonItemdanguat_ItemClick(object sender, ItemClickEventArgs e)
        {
            DialogResult dr;
            dr = XtraMessageBox.Show("Bạn có muốn đăng xuất ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                chk = 1;
                Program.lg = new frmLogin();
                Program.lg.Show();
                this.Hide();
            }
        }

        private void barButtonItemDoiMatKhau_ItemClick(object sender, ItemClickEventArgs e)
        {
            DoiMatKhau doiMatKhau = new DoiMatKhau();
            doiMatKhau.ShowDialog();
        }

        private void QuanLyChung_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (chk == 0)
            {
                DialogResult dr;
                dr = XtraMessageBox.Show("Bạn có muốn thoát ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    Program.lg.Close();
                }
            }
            else
            {
                Program.lg.Close();
            }
        }
    }
}