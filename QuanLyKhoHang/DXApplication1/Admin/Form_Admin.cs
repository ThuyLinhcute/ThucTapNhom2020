
using DevExpress.Utils.Extensions;
using DevExpress.XtraEditors;
using DXApplication1.Account;
using DXApplication1.Models;
using DXApplication1.Views;
using DXApplication1.Views.User_Control;
using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace DXApplication1
{


     public partial class FrmMain_Admin : DevExpress.XtraBars.Ribbon.RibbonForm
     {
          int chk = 0;
          int aa = 0;
          public FrmMain_Admin()
          {

               InitializeComponent();
          }
          //set form mặc định
          public void Skins()
          {
               DevExpress.LookAndFeel.DefaultLookAndFeel themes = new DevExpress.LookAndFeel.DefaultLookAndFeel();
               themes.LookAndFeel.SkinName = "Blue";       //tên giao diện set mặc định
          }

          private void FrmMain_Load(object sender, EventArgs e)
          {
               Skins();
          }

          private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
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

          private void btnLogin_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
          {
               frmLogin login = new frmLogin();
               login.Show();

          }
          private void barButtonItemPhanQuyen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
          {

          }

          public void barButtonItemNhanVien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
          {

          }

          private void btnThongTinCaNhan_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
          {


               Program.detail_user = new ThongTinNguoiDung();
               Program.detail_userSql.Select_Detail(Program.detail_user, Program.lg.UserLogin.MaDangNhapNguoiDung);
               Detail_User detail_form = new Detail_User();
               detail_form.ShowDialog();




          }

          private void btnChangePass_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
          {

               Program.up_datePass = new UpdatePass();
               Program.up_datePass.Show();


          }

          private void btnLogout_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
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
          private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
          {
          }

          private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
          {

          }

          private void barButtonItemQLBanDo_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
          {

          }

          private void barButtonItemQuanLyDuLieuTranDau_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
          {

          }

          private void barButtonItemQLPhuongAn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
          {

          }

          private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
          {

            panelMain.Controls.Clear();

            panelMain.Controls.Add(new Nhacungcap());

          }

          private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
          {
               //panelMain.Controls.Clear();
               //panelMain.Controls.Add(new Khachhang());
          }

          private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
          {
               //panelMain.Controls.Clear();
               //panelMain.Controls.Add(new Phieunhap());
          }

          private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
          {
               panelMain.Controls.Clear();
               panelMain.Controls.Add(new Sanpham());
          }

          private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            panelMain.Controls.Clear();
            panelMain.Controls.Add(new Phieuxuat());
        }
     }
}
