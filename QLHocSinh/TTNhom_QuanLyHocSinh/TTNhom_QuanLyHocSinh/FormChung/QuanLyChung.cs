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
using TTNhom_QuanLyHocSinh.QLGiaoVien;
using TTNhom_QuanLyHocSinh.Object;
using TTNhom_QuanLyHocSinh.QLGiangDay;
using System.Diagnostics;
using System.IO;

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

        public void barButtonItemGiaoVien_ItemClick(object sender, ItemClickEventArgs e)
        {
            QLGV qLGV = new QLGV();
            qLGV.TopLevel = false;
            panelMain.Controls.Clear();
            panelMain.Dock = DockStyle.Fill;
            panelMain.Controls.Add(qLGV);
            qLGV.Dock = DockStyle.Fill;
            qLGV.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            qLGV.Show();
        }

        public void barButtonItemQLLop_Diem_ItemClick(object sender, ItemClickEventArgs e)
        {

            QLDiem qLLop_Diem = new QLDiem();

            qLLop_Diem.TopLevel = false;
            panelMain.Controls.Clear();
            panelMain.Dock = DockStyle.Fill;
            panelMain.Controls.Add(qLLop_Diem);
            qLLop_Diem.Dock = DockStyle.Fill;
            qLLop_Diem.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            qLLop_Diem.Show();
        }

        public void barButtonItemGiangDay_ItemClick(object sender, ItemClickEventArgs e)
        {
            QLyGiangDay giangDay = new QLyGiangDay();

            giangDay.TopLevel = false;
            panelMain.Controls.Clear();
            panelMain.Dock = DockStyle.Fill;
            panelMain.Controls.Add(giangDay);
            giangDay.Dock = DockStyle.Fill;
            giangDay.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            giangDay.Show();
        }



        public void barButtonItemqllop_ItemClick(object sender, ItemClickEventArgs e)
        {
            QLGiangDay.QLLop.QLyLop qLyLop = new QLGiangDay.QLLop.QLyLop();

            qLyLop.TopLevel = false;
            panelMain.Controls.Clear();
            panelMain.Dock = DockStyle.Fill;
            panelMain.Controls.Add(qLyLop);
            qLyLop.Dock = DockStyle.Fill;
            qLyLop.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            qLyLop.Show();
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

        private void barButtonItemhd_ItemClick(object sender, ItemClickEventArgs e)
        {
            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory).Parent.FullName + @"\HDSDPhanMem\Hướng dẫn sử dụng phần mềm.docx";
            Process.Start(projectDirectory);
        }
    }
}