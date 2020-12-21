namespace QuanLyNhanSu.GUI
{
    partial class FrmQuanLyNhanVien
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuanLyNhanVien));
            this.dgrQuanLyNhanVien = new DevExpress.XtraGrid.GridControl();
            this.grvQuanLyNhanVien = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.NhanVienID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HoTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BIDANH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DIACHI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGAYSINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.MASOTHUE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GIOITINH = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SOTKNGANHANG = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Email = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ChucVuID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PhongBanID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Lue_GioiTinh = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txbSoTaiKhoan = new System.Windows.Forms.TextBox();
            this.cboGioiTinh = new System.Windows.Forms.ComboBox();
            this.txbMaSoThua = new System.Windows.Forms.TextBox();
            this.txbSoDienThoai = new System.Windows.Forms.TextBox();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.dtpNgaySinh = new DevExpress.XtraEditors.DateEdit();
            this.txbDiaChi = new System.Windows.Forms.TextBox();
            this.cboChucVu = new System.Windows.Forms.ComboBox();
            this.cboDonVi = new System.Windows.Forms.ComboBox();
            this.txbBiDanh = new System.Windows.Forms.TextBox();
            this.txbHoTen = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnDong = new DevExpress.XtraEditors.SimpleButton();
            this.btnXuat = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgrQuanLyNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvQuanLyNhanVien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lue_GioiTinh)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgaySinh.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgaySinh.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dgrQuanLyNhanVien
            // 
            this.dgrQuanLyNhanVien.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4);
            this.dgrQuanLyNhanVien.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gridLevelNode1.RelationName = "Level1";
            this.dgrQuanLyNhanVien.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.dgrQuanLyNhanVien.Location = new System.Drawing.Point(23, 41);
            this.dgrQuanLyNhanVien.MainView = this.grvQuanLyNhanVien;
            this.dgrQuanLyNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.dgrQuanLyNhanVien.Name = "dgrQuanLyNhanVien";
            this.dgrQuanLyNhanVien.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.Lue_GioiTinh});
            this.dgrQuanLyNhanVien.Size = new System.Drawing.Size(904, 590);
            this.dgrQuanLyNhanVien.TabIndex = 8;
            this.dgrQuanLyNhanVien.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvQuanLyNhanVien});
            // 
            // grvQuanLyNhanVien
            // 
            this.grvQuanLyNhanVien.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.NhanVienID,
            this.HoTen,
            this.BIDANH,
            this.DIACHI,
            this.NGAYSINH,
            this.MASOTHUE,
            this.GIOITINH,
            this.SOTKNGANHANG,
            this.SDT,
            this.Email,
            this.ChucVuID,
            this.PhongBanID,
            this.gridColumn1,
            this.gridColumn2});
            this.grvQuanLyNhanVien.DetailHeight = 431;
            this.grvQuanLyNhanVien.GridControl = this.dgrQuanLyNhanVien;
            this.grvQuanLyNhanVien.Name = "grvQuanLyNhanVien";
            this.grvQuanLyNhanVien.OptionsBehavior.ReadOnly = true;
            this.grvQuanLyNhanVien.OptionsView.ShowGroupPanel = false;
            this.grvQuanLyNhanVien.PaintStyleName = "Flat";
            this.grvQuanLyNhanVien.RowHeight = 37;
            // 
            // NhanVienID
            // 
            this.NhanVienID.Caption = "Mã nhân viên";
            this.NhanVienID.FieldName = "NhanVienID";
            this.NhanVienID.MinWidth = 27;
            this.NhanVienID.Name = "NhanVienID";
            this.NhanVienID.Width = 236;
            // 
            // HoTen
            // 
            this.HoTen.Caption = "Họ tên";
            this.HoTen.FieldName = "HOTEN";
            this.HoTen.MinWidth = 27;
            this.HoTen.Name = "HoTen";
            this.HoTen.Visible = true;
            this.HoTen.VisibleIndex = 0;
            this.HoTen.Width = 197;
            // 
            // BIDANH
            // 
            this.BIDANH.Caption = "Bí danh";
            this.BIDANH.FieldName = "BIDANH";
            this.BIDANH.MinWidth = 27;
            this.BIDANH.Name = "BIDANH";
            this.BIDANH.Width = 100;
            // 
            // DIACHI
            // 
            this.DIACHI.Caption = "Địa chỉ";
            this.DIACHI.FieldName = "DIACHI";
            this.DIACHI.MinWidth = 27;
            this.DIACHI.Name = "DIACHI";
            this.DIACHI.Width = 100;
            // 
            // NGAYSINH
            // 
            this.NGAYSINH.Caption = "Ngày sinh";
            this.NGAYSINH.FieldName = "NGAYSINH";
            this.NGAYSINH.MinWidth = 27;
            this.NGAYSINH.Name = "NGAYSINH";
            this.NGAYSINH.Width = 100;
            // 
            // MASOTHUE
            // 
            this.MASOTHUE.Caption = "Mã số thuế";
            this.MASOTHUE.FieldName = "MASOTHUE";
            this.MASOTHUE.MinWidth = 27;
            this.MASOTHUE.Name = "MASOTHUE";
            this.MASOTHUE.Width = 100;
            // 
            // GIOITINH
            // 
            this.GIOITINH.Caption = "Giới tính";
            this.GIOITINH.FieldName = "TENGIOITINH";
            this.GIOITINH.MinWidth = 27;
            this.GIOITINH.Name = "GIOITINH";
            this.GIOITINH.Visible = true;
            this.GIOITINH.VisibleIndex = 1;
            this.GIOITINH.Width = 291;
            // 
            // SOTKNGANHANG
            // 
            this.SOTKNGANHANG.Caption = "Số tài khoản";
            this.SOTKNGANHANG.FieldName = "SOTKNGANHANG";
            this.SOTKNGANHANG.MinWidth = 27;
            this.SOTKNGANHANG.Name = "SOTKNGANHANG";
            this.SOTKNGANHANG.Width = 100;
            // 
            // SDT
            // 
            this.SDT.Caption = "SĐT";
            this.SDT.FieldName = "SDT";
            this.SDT.MinWidth = 27;
            this.SDT.Name = "SDT";
            this.SDT.Width = 100;
            // 
            // Email
            // 
            this.Email.Caption = "Email";
            this.Email.FieldName = "EMAIL";
            this.Email.MinWidth = 27;
            this.Email.Name = "Email";
            this.Email.Width = 100;
            // 
            // ChucVuID
            // 
            this.ChucVuID.Caption = "Chức vụ";
            this.ChucVuID.FieldName = "TENCV";
            this.ChucVuID.MinWidth = 27;
            this.ChucVuID.Name = "ChucVuID";
            this.ChucVuID.Visible = true;
            this.ChucVuID.VisibleIndex = 2;
            this.ChucVuID.Width = 189;
            // 
            // PhongBanID
            // 
            this.PhongBanID.Caption = "Đơn vị";
            this.PhongBanID.FieldName = "TENPB";
            this.PhongBanID.MinWidth = 27;
            this.PhongBanID.Name = "PhongBanID";
            this.PhongBanID.Visible = true;
            this.PhongBanID.VisibleIndex = 3;
            this.PhongBanID.Width = 204;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "gridColumn1";
            this.gridColumn1.FieldName = "CHUCVUID";
            this.gridColumn1.MinWidth = 27;
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Width = 100;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "gridColumn2";
            this.gridColumn2.FieldName = "PHONGBANID";
            this.gridColumn2.MinWidth = 27;
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Width = 100;
            // 
            // Lue_GioiTinh
            // 
            this.Lue_GioiTinh.AutoHeight = false;
            this.Lue_GioiTinh.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Lue_GioiTinh.Name = "Lue_GioiTinh";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.txbSoTaiKhoan);
            this.groupBox1.Controls.Add(this.cboGioiTinh);
            this.groupBox1.Controls.Add(this.txbMaSoThua);
            this.groupBox1.Controls.Add(this.txbSoDienThoai);
            this.groupBox1.Controls.Add(this.txbEmail);
            this.groupBox1.Controls.Add(this.dtpNgaySinh);
            this.groupBox1.Controls.Add(this.txbDiaChi);
            this.groupBox1.Controls.Add(this.cboChucVu);
            this.groupBox1.Controls.Add(this.cboDonVi);
            this.groupBox1.Controls.Add(this.txbBiDanh);
            this.groupBox1.Controls.Add(this.txbHoTen);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(963, 42);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(680, 379);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhân viên";
            // 
            // txbSoTaiKhoan
            // 
            this.txbSoTaiKhoan.Location = new System.Drawing.Point(111, 250);
            this.txbSoTaiKhoan.Margin = new System.Windows.Forms.Padding(4);
            this.txbSoTaiKhoan.Name = "txbSoTaiKhoan";
            this.txbSoTaiKhoan.Size = new System.Drawing.Size(337, 23);
            this.txbSoTaiKhoan.TabIndex = 23;
            // 
            // cboGioiTinh
            // 
            this.cboGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGioiTinh.FormattingEnabled = true;
            this.cboGioiTinh.Items.AddRange(new object[] {
            "Nữ",
            "Nam"});
            this.cboGioiTinh.Location = new System.Drawing.Point(455, 112);
            this.cboGioiTinh.Margin = new System.Windows.Forms.Padding(4);
            this.cboGioiTinh.Name = "cboGioiTinh";
            this.cboGioiTinh.Size = new System.Drawing.Size(159, 24);
            this.cboGioiTinh.TabIndex = 22;
            // 
            // txbMaSoThua
            // 
            this.txbMaSoThua.Location = new System.Drawing.Point(111, 202);
            this.txbMaSoThua.Margin = new System.Windows.Forms.Padding(4);
            this.txbMaSoThua.Name = "txbMaSoThua";
            this.txbMaSoThua.Size = new System.Drawing.Size(453, 23);
            this.txbMaSoThua.TabIndex = 21;
            // 
            // txbSoDienThoai
            // 
            this.txbSoDienThoai.Location = new System.Drawing.Point(455, 158);
            this.txbSoDienThoai.Margin = new System.Windows.Forms.Padding(4);
            this.txbSoDienThoai.Name = "txbSoDienThoai";
            this.txbSoDienThoai.Size = new System.Drawing.Size(199, 23);
            this.txbSoDienThoai.TabIndex = 20;
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(111, 158);
            this.txbEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(195, 23);
            this.txbEmail.TabIndex = 19;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.EditValue = new System.DateTime(2017, 7, 3, 22, 45, 34, 428);
            this.dtpNgaySinh.Location = new System.Drawing.Point(111, 114);
            this.dtpNgaySinh.Margin = new System.Windows.Forms.Padding(4);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.dtpNgaySinh.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpNgaySinh.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpNgaySinh.Size = new System.Drawing.Size(157, 24);
            this.dtpNgaySinh.TabIndex = 18;
            // 
            // txbDiaChi
            // 
            this.txbDiaChi.Location = new System.Drawing.Point(111, 293);
            this.txbDiaChi.Margin = new System.Windows.Forms.Padding(4);
            this.txbDiaChi.Multiline = true;
            this.txbDiaChi.Name = "txbDiaChi";
            this.txbDiaChi.Size = new System.Drawing.Size(545, 53);
            this.txbDiaChi.TabIndex = 17;
            // 
            // cboChucVu
            // 
            this.cboChucVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboChucVu.FormattingEnabled = true;
            this.cboChucVu.Location = new System.Drawing.Point(455, 66);
            this.cboChucVu.Margin = new System.Windows.Forms.Padding(4);
            this.cboChucVu.Name = "cboChucVu";
            this.cboChucVu.Size = new System.Drawing.Size(199, 24);
            this.cboChucVu.TabIndex = 16;
            // 
            // cboDonVi
            // 
            this.cboDonVi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboDonVi.FormattingEnabled = true;
            this.cboDonVi.Location = new System.Drawing.Point(111, 66);
            this.cboDonVi.Margin = new System.Windows.Forms.Padding(4);
            this.cboDonVi.Name = "cboDonVi";
            this.cboDonVi.Size = new System.Drawing.Size(201, 24);
            this.cboDonVi.TabIndex = 15;
            // 
            // txbBiDanh
            // 
            this.txbBiDanh.Location = new System.Drawing.Point(455, 24);
            this.txbBiDanh.Margin = new System.Windows.Forms.Padding(4);
            this.txbBiDanh.Name = "txbBiDanh";
            this.txbBiDanh.Size = new System.Drawing.Size(199, 23);
            this.txbBiDanh.TabIndex = 14;
            // 
            // txbHoTen
            // 
            this.txbHoTen.Location = new System.Drawing.Point(111, 30);
            this.txbHoTen.Margin = new System.Windows.Forms.Padding(4);
            this.txbHoTen.Name = "txbHoTen";
            this.txbHoTen.Size = new System.Drawing.Size(195, 23);
            this.txbHoTen.TabIndex = 13;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(373, 73);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 17);
            this.label12.TabIndex = 12;
            this.label12.Text = "Chức vụ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 76);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 17);
            this.label11.TabIndex = 11;
            this.label11.Text = "Đơn vị";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 158);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 17);
            this.label10.TabIndex = 10;
            this.label10.Text = "Email";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(373, 166);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 17);
            this.label9.TabIndex = 9;
            this.label9.Text = "SĐT";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 256);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Số TK";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(373, 118);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Giới tính";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 205);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Mã số thuế";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 119);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ngày sinh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 296);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Địa chỉ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(373, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bí danh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 38);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Danh sách nhân viên";
            // 
            // btnSua
            // 
            this.btnSua.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Appearance.Options.UseFont = true;
            this.btnSua.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
            this.btnSua.Location = new System.Drawing.Point(1307, 458);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(336, 53);
            this.btnSua.TabIndex = 13;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
            this.btnThem.Location = new System.Drawing.Point(963, 458);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(336, 53);
            this.btnThem.TabIndex = 12;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
            this.btnXoa.Location = new System.Drawing.Point(963, 518);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(336, 53);
            this.btnXoa.TabIndex = 11;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnDong
            // 
            this.btnDong.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.Appearance.Options.UseFont = true;
            this.btnDong.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnDong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.ImageOptions.Image")));
            this.btnDong.Location = new System.Drawing.Point(963, 578);
            this.btnDong.Margin = new System.Windows.Forms.Padding(4);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(680, 53);
            this.btnDong.TabIndex = 10;
            this.btnDong.Text = "Đóng chức năng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnXuat
            // 
            this.btnXuat.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuat.Appearance.Options.UseFont = true;
            this.btnXuat.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnXuat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXuat.ImageOptions.Image")));
            this.btnXuat.Location = new System.Drawing.Point(1307, 518);
            this.btnXuat.Margin = new System.Windows.Forms.Padding(4);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(336, 53);
            this.btnXuat.TabIndex = 83;
            this.btnXuat.Text = "Xuất ra file excel";
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // FrmQuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1661, 652);
            this.Controls.Add(this.btnXuat);
            this.Controls.Add(this.dgrQuanLyNhanVien);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnDong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmQuanLyNhanVien";
            this.Text = "FrmQuanLyNhanVien";
            ((System.ComponentModel.ISupportInitialize)(this.dgrQuanLyNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvQuanLyNhanVien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lue_GioiTinh)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgaySinh.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgaySinh.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dgrQuanLyNhanVien;
        private DevExpress.XtraGrid.Views.Grid.GridView grvQuanLyNhanVien;
        private DevExpress.XtraGrid.Columns.GridColumn NhanVienID;
        private DevExpress.XtraGrid.Columns.GridColumn HoTen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnDong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txbBiDanh;
        private System.Windows.Forms.TextBox txbHoTen;
        private System.Windows.Forms.TextBox txbDiaChi;
        private System.Windows.Forms.ComboBox cboChucVu;
        private System.Windows.Forms.ComboBox cboDonVi;
        private DevExpress.XtraEditors.DateEdit dtpNgaySinh;
        private System.Windows.Forms.TextBox txbSoDienThoai;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.TextBox txbMaSoThua;
        private System.Windows.Forms.TextBox txbSoTaiKhoan;
        private System.Windows.Forms.ComboBox cboGioiTinh;
        private DevExpress.XtraGrid.Columns.GridColumn BIDANH;
        private DevExpress.XtraGrid.Columns.GridColumn DIACHI;
        private DevExpress.XtraGrid.Columns.GridColumn NGAYSINH;
        private DevExpress.XtraGrid.Columns.GridColumn MASOTHUE;
        private DevExpress.XtraGrid.Columns.GridColumn GIOITINH;
        private DevExpress.XtraGrid.Columns.GridColumn SOTKNGANHANG;
        private DevExpress.XtraGrid.Columns.GridColumn SDT;
        private DevExpress.XtraGrid.Columns.GridColumn Email;
        private DevExpress.XtraGrid.Columns.GridColumn ChucVuID;
        private DevExpress.XtraGrid.Columns.GridColumn PhongBanID;
        private DevExpress.XtraEditors.SimpleButton btnXuat;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit Lue_GioiTinh;

    }
}