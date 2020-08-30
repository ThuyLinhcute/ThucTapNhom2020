namespace QuanLyNhanSu
{
    partial class FrmMain
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
               this.components = new System.ComponentModel.Container();
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
               this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
               this.barQuanLyNhanVien = new DevExpress.XtraBars.BarButtonItem();
               this.barDanhMucChucVu = new DevExpress.XtraBars.BarButtonItem();
               this.barDanhMucPhongBan = new DevExpress.XtraBars.BarButtonItem();
               this.barHopDongLaoDong = new DevExpress.XtraBars.BarButtonItem();
               this.barBaoHiemXaHoi = new DevExpress.XtraBars.BarButtonItem();
               this.barBaoHiemYTe = new DevExpress.XtraBars.BarButtonItem();
               this.barQuaTrinhCongTac = new DevExpress.XtraBars.BarButtonItem();
               this.barBangCap = new DevExpress.XtraBars.BarButtonItem();
               this.barQuaTrinhHocTap = new DevExpress.XtraBars.BarButtonItem();
               this.barThongTinGiaDinh = new DevExpress.XtraBars.BarButtonItem();
               this.barThongTinDang = new DevExpress.XtraBars.BarButtonItem();
               this.barThongTinKhenThuongKiLuat = new DevExpress.XtraBars.BarButtonItem();
               this.barChamCong = new DevExpress.XtraBars.BarButtonItem();
               this.barTinhLuong = new DevExpress.XtraBars.BarButtonItem();
               this.barThongKeTheoNhanVien = new DevExpress.XtraBars.BarButtonItem();
               this.barThongKeNhanVienSapNghiHuu = new DevExpress.XtraBars.BarButtonItem();
               this.barThongKeDangVien = new DevExpress.XtraBars.BarButtonItem();
               this.barThongKeSinhNhatTheoThang = new DevExpress.XtraBars.BarButtonItem();
               this.barQLChamCong = new DevExpress.XtraBars.BarButtonItem();
               this.barUser = new DevExpress.XtraBars.BarButtonItem();
               this.logout = new DevExpress.XtraBars.BarButtonItem();
               this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
               this.logOutbutton = new DevExpress.XtraBars.BarButtonItem();
               this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
               this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
               this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
               this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
               this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
               this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
               this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
               this.panelMain = new DevExpress.XtraEditors.PanelControl();
               ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.panelMain)).BeginInit();
               this.SuspendLayout();
               // 
               // ribbonControl1
               // 
               this.ribbonControl1.ExpandCollapseItem.Id = 0;
               this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.barQuanLyNhanVien,
            this.barDanhMucChucVu,
            this.barDanhMucPhongBan,
            this.barHopDongLaoDong,
            this.barBaoHiemXaHoi,
            this.barBaoHiemYTe,
            this.barQuaTrinhCongTac,
            this.barBangCap,
            this.barQuaTrinhHocTap,
            this.barThongTinGiaDinh,
            this.barThongTinDang,
            this.barThongTinKhenThuongKiLuat,
            this.barChamCong,
            this.barTinhLuong,
            this.barThongKeTheoNhanVien,
            this.barThongKeNhanVienSapNghiHuu,
            this.barThongKeDangVien,
            this.barThongKeSinhNhatTheoThang,
            this.barQLChamCong,
            this.barUser,
            this.logout,
            this.barButtonItem1,
            this.logOutbutton});
               this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
               this.ribbonControl1.Margin = new System.Windows.Forms.Padding(4);
               this.ribbonControl1.MaxItemId = 30;
               this.ribbonControl1.Name = "ribbonControl1";
               this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
               this.ribbonControl1.Size = new System.Drawing.Size(1524, 176);
               // 
               // barQuanLyNhanVien
               // 
               this.barQuanLyNhanVien.Caption = "Quản lý nhân viên";
               this.barQuanLyNhanVien.Id = 1;
               this.barQuanLyNhanVien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barQuanLyNhanVien.ImageOptions.Image")));
               this.barQuanLyNhanVien.Name = "barQuanLyNhanVien";
               this.barQuanLyNhanVien.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
               this.barQuanLyNhanVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barQuanLyNhanVien_ItemClick);
               // 
               // barDanhMucChucVu
               // 
               this.barDanhMucChucVu.Caption = "Chức vụ";
               this.barDanhMucChucVu.Id = 2;
               this.barDanhMucChucVu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barDanhMucChucVu.ImageOptions.Image")));
               this.barDanhMucChucVu.Name = "barDanhMucChucVu";
               this.barDanhMucChucVu.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
               this.barDanhMucChucVu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barDanhMucChucVu_ItemClick);
               // 
               // barDanhMucPhongBan
               // 
               this.barDanhMucPhongBan.Caption = "Phòng ban";
               this.barDanhMucPhongBan.Id = 3;
               this.barDanhMucPhongBan.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barDanhMucPhongBan.ImageOptions.Image")));
               this.barDanhMucPhongBan.Name = "barDanhMucPhongBan";
               this.barDanhMucPhongBan.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
               this.barDanhMucPhongBan.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barDanhMucPhongBan_ItemClick);
               // 
               // barHopDongLaoDong
               // 
               this.barHopDongLaoDong.Id = 24;
               this.barHopDongLaoDong.Name = "barHopDongLaoDong";
               // 
               // barBaoHiemXaHoi
               // 
               this.barBaoHiemXaHoi.Caption = "Bảo hiểm xã hội";
               this.barBaoHiemXaHoi.Id = 5;
               this.barBaoHiemXaHoi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBaoHiemXaHoi.ImageOptions.Image")));
               this.barBaoHiemXaHoi.Name = "barBaoHiemXaHoi";
               this.barBaoHiemXaHoi.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
               this.barBaoHiemXaHoi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBaoHiemXaHoi_ItemClick);
               // 
               // barBaoHiemYTe
               // 
               this.barBaoHiemYTe.Caption = "Bảo hiểm y tế";
               this.barBaoHiemYTe.Id = 6;
               this.barBaoHiemYTe.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBaoHiemYTe.ImageOptions.Image")));
               this.barBaoHiemYTe.Name = "barBaoHiemYTe";
               this.barBaoHiemYTe.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
               this.barBaoHiemYTe.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBaoHiemYTe_ItemClick);
               // 
               // barQuaTrinhCongTac
               // 
               this.barQuaTrinhCongTac.Caption = "Quá trình công tác";
               this.barQuaTrinhCongTac.Id = 7;
               this.barQuaTrinhCongTac.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barQuaTrinhCongTac.ImageOptions.Image")));
               this.barQuaTrinhCongTac.Name = "barQuaTrinhCongTac";
               this.barQuaTrinhCongTac.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
               this.barQuaTrinhCongTac.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barQuaTrinhCongTac_ItemClick);
               // 
               // barBangCap
               // 
               this.barBangCap.Caption = "Bằng cấp";
               this.barBangCap.Id = 8;
               this.barBangCap.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBangCap.ImageOptions.Image")));
               this.barBangCap.Name = "barBangCap";
               this.barBangCap.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
               this.barBangCap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBangCap_ItemClick);
               // 
               // barQuaTrinhHocTap
               // 
               this.barQuaTrinhHocTap.Caption = "Quá trình học tập";
               this.barQuaTrinhHocTap.Id = 9;
               this.barQuaTrinhHocTap.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barQuaTrinhHocTap.ImageOptions.Image")));
               this.barQuaTrinhHocTap.Name = "barQuaTrinhHocTap";
               this.barQuaTrinhHocTap.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
               this.barQuaTrinhHocTap.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barQuaTrinhHocTap_ItemClick);
               // 
               // barThongTinGiaDinh
               // 
               this.barThongTinGiaDinh.Caption = "Thông tin gia đình";
               this.barThongTinGiaDinh.Id = 10;
               this.barThongTinGiaDinh.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barThongTinGiaDinh.ImageOptions.Image")));
               this.barThongTinGiaDinh.Name = "barThongTinGiaDinh";
               this.barThongTinGiaDinh.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
               this.barThongTinGiaDinh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barThongTinGiaDinh_ItemClick);
               // 
               // barThongTinDang
               // 
               this.barThongTinDang.Id = 25;
               this.barThongTinDang.Name = "barThongTinDang";
               // 
               // barThongTinKhenThuongKiLuat
               // 
               this.barThongTinKhenThuongKiLuat.Caption = "Thông tin khen thưởng kỉ luật";
               this.barThongTinKhenThuongKiLuat.Id = 12;
               this.barThongTinKhenThuongKiLuat.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barThongTinKhenThuongKiLuat.ImageOptions.SvgImage")));
               this.barThongTinKhenThuongKiLuat.Name = "barThongTinKhenThuongKiLuat";
               this.barThongTinKhenThuongKiLuat.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barThongTinKhenThuongKiLuat_ItemClick);
               // 
               // barChamCong
               // 
               this.barChamCong.Id = 21;
               this.barChamCong.Name = "barChamCong";
               // 
               // barTinhLuong
               // 
               this.barTinhLuong.Id = 22;
               this.barTinhLuong.Name = "barTinhLuong";
               // 
               // barThongKeTheoNhanVien
               // 
               this.barThongKeTheoNhanVien.Caption = "Nhân viên theo phòng ban";
               this.barThongKeTheoNhanVien.Id = 16;
               this.barThongKeTheoNhanVien.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barThongKeTheoNhanVien.ImageOptions.Image")));
               this.barThongKeTheoNhanVien.Name = "barThongKeTheoNhanVien";
               this.barThongKeTheoNhanVien.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
               this.barThongKeTheoNhanVien.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barThongKeTheoNhanVien_ItemClick);
               // 
               // barThongKeNhanVienSapNghiHuu
               // 
               this.barThongKeNhanVienSapNghiHuu.Caption = "Nhân viên sắp nghỉ hưu";
               this.barThongKeNhanVienSapNghiHuu.Id = 17;
               this.barThongKeNhanVienSapNghiHuu.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barThongKeNhanVienSapNghiHuu.ImageOptions.Image")));
               this.barThongKeNhanVienSapNghiHuu.Name = "barThongKeNhanVienSapNghiHuu";
               this.barThongKeNhanVienSapNghiHuu.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
               this.barThongKeNhanVienSapNghiHuu.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barThongKeNhanVienSapNghiHuu_ItemClick);
               // 
               // barThongKeDangVien
               // 
               this.barThongKeDangVien.Id = 26;
               this.barThongKeDangVien.Name = "barThongKeDangVien";
               // 
               // barThongKeSinhNhatTheoThang
               // 
               this.barThongKeSinhNhatTheoThang.Caption = "Sinh nhật theo tháng";
               this.barThongKeSinhNhatTheoThang.Id = 19;
               this.barThongKeSinhNhatTheoThang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barThongKeSinhNhatTheoThang.ImageOptions.Image")));
               this.barThongKeSinhNhatTheoThang.Name = "barThongKeSinhNhatTheoThang";
               this.barThongKeSinhNhatTheoThang.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
               this.barThongKeSinhNhatTheoThang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barThongKeSinhNhatTheoThang_ItemClick);
               // 
               // barQLChamCong
               // 
               this.barQLChamCong.Caption = "Chấm công";
               this.barQLChamCong.Id = 20;
               this.barQLChamCong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barQLChamCong.ImageOptions.Image")));
               this.barQLChamCong.Name = "barQLChamCong";
               this.barQLChamCong.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
               this.barQLChamCong.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barQLChamCong_ItemClick);
               // 
               // barUser
               // 
               this.barUser.Caption = "Quản lý người dùng";
               this.barUser.Id = 23;
               this.barUser.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barUser.ImageOptions.Image")));
               this.barUser.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barUser.ImageOptions.LargeImage")));
               this.barUser.Name = "barUser";
               this.barUser.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barUser_ItemClick);
               // 
               // logout
               // 
               this.logout.Caption = "Đăng xuất";
               this.logout.Id = 27;
               this.logout.Name = "logout";
               // 
               // barButtonItem1
               // 
               this.barButtonItem1.Caption = "Đăng xuất";
               this.barButtonItem1.Id = 28;
               this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
               this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
               this.barButtonItem1.Name = "barButtonItem1";
               // 
               // logOutbutton
               // 
               this.logOutbutton.Caption = "Đăng xuất";
               this.logOutbutton.Id = 29;
               this.logOutbutton.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("logOutbutton.ImageOptions.Image")));
               this.logOutbutton.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("logOutbutton.ImageOptions.LargeImage")));
               this.logOutbutton.Name = "logOutbutton";
               this.logOutbutton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.logOutbutton_ItemClick);
               // 
               // ribbonPage1
               // 
               this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup1,
            this.ribbonPageGroup4,
            this.ribbonPageGroup5,
            this.ribbonPageGroup3});
               this.ribbonPage1.Name = "ribbonPage1";
               this.ribbonPage1.Text = "Quản lý nhân sự";
               // 
               // ribbonPageGroup2
               // 
               this.ribbonPageGroup2.ItemLinks.Add(this.barDanhMucChucVu);
               this.ribbonPageGroup2.ItemLinks.Add(this.barDanhMucPhongBan);
               this.ribbonPageGroup2.Name = "ribbonPageGroup2";
               this.ribbonPageGroup2.Text = "Danh mục";
               // 
               // ribbonPageGroup1
               // 
               this.ribbonPageGroup1.ItemLinks.Add(this.barQuanLyNhanVien);
               this.ribbonPageGroup1.ItemLinks.Add(this.barBaoHiemXaHoi);
               this.ribbonPageGroup1.ItemLinks.Add(this.barBaoHiemYTe);
               this.ribbonPageGroup1.ItemLinks.Add(this.barQuaTrinhCongTac);
               this.ribbonPageGroup1.ItemLinks.Add(this.barBangCap);
               this.ribbonPageGroup1.ItemLinks.Add(this.barQuaTrinhHocTap);
               this.ribbonPageGroup1.ItemLinks.Add(this.barThongTinGiaDinh);
               this.ribbonPageGroup1.ItemLinks.Add(this.barUser);
               this.ribbonPageGroup1.ItemLinks.Add(this.barThongTinKhenThuongKiLuat);
               this.ribbonPageGroup1.Name = "ribbonPageGroup1";
               this.ribbonPageGroup1.Text = "Quản lý nhân sự";
               // 
               // ribbonPageGroup4
               // 
               this.ribbonPageGroup4.ItemLinks.Add(this.barThongKeTheoNhanVien);
               this.ribbonPageGroup4.ItemLinks.Add(this.barThongKeNhanVienSapNghiHuu);
               this.ribbonPageGroup4.ItemLinks.Add(this.barThongKeSinhNhatTheoThang);
               this.ribbonPageGroup4.Name = "ribbonPageGroup4";
               this.ribbonPageGroup4.Text = "Thống kê";
               // 
               // ribbonPageGroup5
               // 
               this.ribbonPageGroup5.ItemLinks.Add(this.barQLChamCong);
               this.ribbonPageGroup5.Name = "ribbonPageGroup5";
               this.ribbonPageGroup5.Text = "Quản lý lương";
               // 
               // ribbonPageGroup3
               // 
               this.ribbonPageGroup3.ItemLinks.Add(this.logOutbutton);
               this.ribbonPageGroup3.Name = "ribbonPageGroup3";
               this.ribbonPageGroup3.Text = "ribbonPageGroup3";
               // 
               // panelMain
               // 
               this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
               this.panelMain.Location = new System.Drawing.Point(0, 176);
               this.panelMain.Margin = new System.Windows.Forms.Padding(4);
               this.panelMain.Name = "panelMain";
               this.panelMain.Size = new System.Drawing.Size(1524, 661);
               this.panelMain.TabIndex = 1;
               // 
               // FrmMain
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(1524, 837);
               this.Controls.Add(this.panelMain);
               this.Controls.Add(this.ribbonControl1);
               this.Margin = new System.Windows.Forms.Padding(4);
               this.MaximizeBox = false;
               this.Name = "FrmMain";
               this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
               this.Text = "Quản lý nhân sự";
               ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.panelMain)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem barQuanLyNhanVien;
        private DevExpress.XtraBars.BarButtonItem barDanhMucChucVu;
        private DevExpress.XtraBars.BarButtonItem barDanhMucPhongBan;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.BarButtonItem barHopDongLaoDong;
        private DevExpress.XtraBars.BarButtonItem barBaoHiemXaHoi;
        private DevExpress.XtraBars.BarButtonItem barBaoHiemYTe;
        private DevExpress.XtraBars.BarButtonItem barQuaTrinhCongTac;
        private DevExpress.XtraBars.BarButtonItem barBangCap;
        private DevExpress.XtraBars.BarButtonItem barQuaTrinhHocTap;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraBars.BarButtonItem barThongTinGiaDinh;
        private DevExpress.XtraBars.BarButtonItem barThongTinDang;
        private DevExpress.XtraBars.BarButtonItem barThongTinKhenThuongKiLuat;
        //private DevExpress.XtraBars.BarButtonItem barThongTinTaiSan;
        private DevExpress.XtraBars.BarButtonItem barChamCong;
        private DevExpress.XtraBars.BarButtonItem barTinhLuong;
        private DevExpress.XtraBars.BarButtonItem barThongKeTheoNhanVien;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraEditors.PanelControl panelMain;
        private DevExpress.XtraBars.BarButtonItem barThongKeNhanVienSapNghiHuu;
        private DevExpress.XtraBars.BarButtonItem barThongKeDangVien;
        private DevExpress.XtraBars.BarButtonItem barThongKeSinhNhatTheoThang;
        private DevExpress.XtraBars.BarButtonItem barQLChamCong;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem barUser;
          private DevExpress.XtraBars.BarButtonItem logout;
          private DevExpress.XtraBars.BarButtonItem barButtonItem1;
          private DevExpress.XtraBars.BarButtonItem logOutbutton;
          private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
     }
}

