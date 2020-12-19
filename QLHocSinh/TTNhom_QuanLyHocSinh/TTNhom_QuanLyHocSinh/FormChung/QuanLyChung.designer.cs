namespace TTNhom_QuanLyHocSinh.Views
{
    partial class QuanLyChung
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyChung));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItemQLHocSinh = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemGiaoVien = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemQLLop_Diem = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemGiangDay = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemDoiMatKhau = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemdanguat = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItemqllop = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.panelMain = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.barButtonItemQLHocSinh,
            this.barButtonItemGiaoVien,
            this.barButtonItemQLLop_Diem,
            this.barButtonItemGiangDay,
            this.barButtonItemDoiMatKhau,
            this.barButtonItemdanguat,
            this.barButtonItemqllop});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbon.MaxItemId = 8;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage3});
            this.ribbon.Size = new System.Drawing.Size(1401, 178);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // barButtonItemQLHocSinh
            // 
            this.barButtonItemQLHocSinh.Caption = "Quản lý học sinh";
            this.barButtonItemQLHocSinh.Id = 1;
            this.barButtonItemQLHocSinh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemQLHocSinh.ImageOptions.Image")));
            this.barButtonItemQLHocSinh.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItemQLHocSinh.ImageOptions.LargeImage")));
            this.barButtonItemQLHocSinh.Name = "barButtonItemQLHocSinh";
            this.barButtonItemQLHocSinh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemQLHocSinh_ItemClick);
            // 
            // barButtonItemGiaoVien
            // 
            this.barButtonItemGiaoVien.Caption = "Quản lý giáo viên";
            this.barButtonItemGiaoVien.Id = 2;
            this.barButtonItemGiaoVien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemGiaoVien.ImageOptions.Image")));
            this.barButtonItemGiaoVien.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItemGiaoVien.ImageOptions.LargeImage")));
            this.barButtonItemGiaoVien.Name = "barButtonItemGiaoVien";
            this.barButtonItemGiaoVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemGiaoVien_ItemClick);
            // 
            // barButtonItemQLLop_Diem
            // 
            this.barButtonItemQLLop_Diem.Caption = "Quản lý điểm";
            this.barButtonItemQLLop_Diem.Id = 3;
            this.barButtonItemQLLop_Diem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemQLLop_Diem.ImageOptions.Image")));
            this.barButtonItemQLLop_Diem.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItemQLLop_Diem.ImageOptions.LargeImage")));
            this.barButtonItemQLLop_Diem.Name = "barButtonItemQLLop_Diem";
            this.barButtonItemQLLop_Diem.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemQLLop_Diem_ItemClick);
            // 
            // barButtonItemGiangDay
            // 
            this.barButtonItemGiangDay.Caption = "Giảng dạy";
            this.barButtonItemGiangDay.Id = 4;
            this.barButtonItemGiangDay.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemGiangDay.ImageOptions.Image")));
            this.barButtonItemGiangDay.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItemGiangDay.ImageOptions.LargeImage")));
            this.barButtonItemGiangDay.Name = "barButtonItemGiangDay";
            this.barButtonItemGiangDay.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemGiangDay_ItemClick);
            // 
            // barButtonItemDoiMatKhau
            // 
            this.barButtonItemDoiMatKhau.Caption = "Đổi mật khẩu";
            this.barButtonItemDoiMatKhau.Id = 5;
            this.barButtonItemDoiMatKhau.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemDoiMatKhau.ImageOptions.Image")));
            this.barButtonItemDoiMatKhau.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItemDoiMatKhau.ImageOptions.LargeImage")));
            this.barButtonItemDoiMatKhau.Name = "barButtonItemDoiMatKhau";
            this.barButtonItemDoiMatKhau.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemDoiMatKhau_ItemClick);
            // 
            // barButtonItemdanguat
            // 
            this.barButtonItemdanguat.Caption = "Đăng xuất";
            this.barButtonItemdanguat.Id = 6;
            this.barButtonItemdanguat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemdanguat.ImageOptions.Image")));
            this.barButtonItemdanguat.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItemdanguat.ImageOptions.LargeImage")));
            this.barButtonItemdanguat.Name = "barButtonItemdanguat";
            this.barButtonItemdanguat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemdanguat_ItemClick);
            // 
            // barButtonItemqllop
            // 
            this.barButtonItemqllop.Caption = "Quản lý lớp";
            this.barButtonItemqllop.Id = 7;
            this.barButtonItemqllop.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItemqllop.ImageOptions.Image")));
            this.barButtonItemqllop.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItemqllop.ImageOptions.LargeImage")));
            this.barButtonItemqllop.Name = "barButtonItemqllop";
            this.barButtonItemqllop.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItemqllop_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Quản trị hệ thống";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemDoiMatKhau);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItemdanguat);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Tài khoản";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup4,
            this.ribbonPageGroup5});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Quản lý nghiệp vụ";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.barButtonItemQLHocSinh);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Học sinh";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.barButtonItemGiaoVien);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Giáo viên";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.barButtonItemqllop);
            this.ribbonPageGroup5.ItemLinks.Add(this.barButtonItemQLLop_Diem);
            this.ribbonPageGroup5.ItemLinks.Add(this.barButtonItemGiangDay);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Giảng dạy";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Tài liệu hướng dẫn";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "ribbonPageGroup3";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 561);
            this.ribbonStatusBar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1401, 37);
            // 
            // panelMain
            // 
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 178);
            this.panelMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1401, 383);
            this.panelMain.TabIndex = 2;
            // 
            // QuanLyChung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1401, 598);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "QuanLyChung";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Quản lý học sinh giáo viên";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QuanLyChung_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem barButtonItemQLHocSinh;
        private DevExpress.XtraBars.BarButtonItem barButtonItemGiaoVien;
        private DevExpress.XtraBars.BarButtonItem barButtonItemQLLop_Diem;
        private DevExpress.XtraBars.BarButtonItem barButtonItemGiangDay;
        private DevExpress.XtraBars.BarButtonItem barButtonItemDoiMatKhau;
        private DevExpress.XtraBars.BarButtonItem barButtonItemdanguat;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private System.Windows.Forms.Panel panelMain;
        private DevExpress.XtraBars.BarButtonItem barButtonItemqllop;
    }
}