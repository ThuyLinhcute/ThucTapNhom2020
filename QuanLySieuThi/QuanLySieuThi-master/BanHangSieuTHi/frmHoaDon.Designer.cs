namespace BanHangSieuTHi
{
    partial class frmHoaDon
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtNhanVien = new System.Windows.Forms.TextBox();
            this.txtKhachHang = new System.Windows.Forms.TextBox();
            this.dTPNgayXuat = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMaHDX = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lsvDSHDX = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnXoaX = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cmbNhaCungCap = new System.Windows.Forms.ComboBox();
            this.cmbNhanVienN = new System.Windows.Forms.ComboBox();
            this.dTPNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMaHDN = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dtgvDSHDN = new System.Windows.Forms.DataGridView();
            this.SoHDN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTienNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThemN = new System.Windows.Forms.Button();
            this.btnSuaN = new System.Windows.Forms.Button();
            this.btnXoaN = new System.Windows.Forms.Button();
            this.btnInHoaDonN = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSHDN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(3, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(872, 512);
            this.tabControl1.TabIndex = 12;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.btnXoaX);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Location = new System.Drawing.Point(4, 31);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(864, 477);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Xuất";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtNhanVien);
            this.groupBox1.Controls.Add(this.txtKhachHang);
            this.groupBox1.Controls.Add(this.dTPNgayXuat);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtMaHDX);
            this.groupBox1.Location = new System.Drawing.Point(0, 8);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(836, 126);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin hóa đơn xuất";
            // 
            // txtNhanVien
            // 
            this.txtNhanVien.Location = new System.Drawing.Point(566, 29);
            this.txtNhanVien.Margin = new System.Windows.Forms.Padding(4);
            this.txtNhanVien.Name = "txtNhanVien";
            this.txtNhanVien.ReadOnly = true;
            this.txtNhanVien.Size = new System.Drawing.Size(138, 30);
            this.txtNhanVien.TabIndex = 40;
            // 
            // txtKhachHang
            // 
            this.txtKhachHang.Location = new System.Drawing.Point(566, 67);
            this.txtKhachHang.Margin = new System.Windows.Forms.Padding(4);
            this.txtKhachHang.Name = "txtKhachHang";
            this.txtKhachHang.ReadOnly = true;
            this.txtKhachHang.Size = new System.Drawing.Size(138, 30);
            this.txtKhachHang.TabIndex = 22;
            // 
            // dTPNgayXuat
            // 
            this.dTPNgayXuat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTPNgayXuat.Location = new System.Drawing.Point(245, 68);
            this.dTPNgayXuat.Name = "dTPNgayXuat";
            this.dTPNgayXuat.Size = new System.Drawing.Size(130, 30);
            this.dTPNgayXuat.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(438, 72);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(438, 29);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nhân viên lập";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 73);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ngày xuất";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã hóa đơn";
            // 
            // txtMaHDX
            // 
            this.txtMaHDX.Location = new System.Drawing.Point(245, 29);
            this.txtMaHDX.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaHDX.Name = "txtMaHDX";
            this.txtMaHDX.ReadOnly = true;
            this.txtMaHDX.Size = new System.Drawing.Size(130, 30);
            this.txtMaHDX.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lsvDSHDX);
            this.groupBox2.Location = new System.Drawing.Point(3, 198);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox2.Size = new System.Drawing.Size(833, 278);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách hóa đơn xuất";
            // 
            // lsvDSHDX
            // 
            this.lsvDSHDX.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lsvDSHDX.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lsvDSHDX.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader2,
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lsvDSHDX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvDSHDX.FullRowSelect = true;
            this.lsvDSHDX.GridLines = true;
            this.lsvDSHDX.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lsvDSHDX.Location = new System.Drawing.Point(5, 28);
            this.lsvDSHDX.Name = "lsvDSHDX";
            this.lsvDSHDX.Size = new System.Drawing.Size(823, 245);
            this.lsvDSHDX.TabIndex = 0;
            this.lsvDSHDX.UseCompatibleStateImageBehavior = false;
            this.lsvDSHDX.View = System.Windows.Forms.View.Details;
            this.lsvDSHDX.SelectedIndexChanged += new System.EventHandler(this.lsvDSHDX_SelectedIndexChanged);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "STT";
            this.columnHeader6.Width = 40;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số HĐX";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 131;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ngày Xuất";
            this.columnHeader1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader1.Width = 179;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Thành tiền";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 172;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Nhân Viên";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader4.Width = 159;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Khách hàng";
            this.columnHeader5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader5.Width = 130;
            // 
            // btnXoaX
            // 
            this.btnXoaX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaX.Location = new System.Drawing.Point(478, 142);
            this.btnXoaX.Name = "btnXoaX";
            this.btnXoaX.Size = new System.Drawing.Size(129, 48);
            this.btnXoaX.TabIndex = 6;
            this.btnXoaX.Text = "Xóa hóa đơn";
            this.btnXoaX.UseVisualStyleBackColor = true;
            this.btnXoaX.Click += new System.EventHandler(this.btnXoaX_Click);
            // 
            // button4
            // 
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(257, 142);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(152, 48);
            this.button4.TabIndex = 7;
            this.button4.Text = "Chi tiết hóa đơn";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox6);
            this.tabPage2.Controls.Add(this.btnThemN);
            this.tabPage2.Controls.Add(this.btnSuaN);
            this.tabPage2.Controls.Add(this.btnXoaN);
            this.tabPage2.Controls.Add(this.btnInHoaDonN);
            this.tabPage2.Location = new System.Drawing.Point(4, 31);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(864, 477);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Nhập";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cmbNhaCungCap);
            this.groupBox4.Controls.Add(this.cmbNhanVienN);
            this.groupBox4.Controls.Add(this.dTPNgayNhap);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.txtMaHDN);
            this.groupBox4.Location = new System.Drawing.Point(-1, 7);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox4.Size = new System.Drawing.Size(836, 126);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông tin hóa đơn nhập";
            // 
            // cmbNhaCungCap
            // 
            this.cmbNhaCungCap.FormattingEnabled = true;
            this.cmbNhaCungCap.Location = new System.Drawing.Point(485, 78);
            this.cmbNhaCungCap.Name = "cmbNhaCungCap";
            this.cmbNhaCungCap.Size = new System.Drawing.Size(154, 30);
            this.cmbNhaCungCap.TabIndex = 23;
            // 
            // cmbNhanVienN
            // 
            this.cmbNhanVienN.FormattingEnabled = true;
            this.cmbNhanVienN.Location = new System.Drawing.Point(485, 27);
            this.cmbNhanVienN.Name = "cmbNhanVienN";
            this.cmbNhanVienN.Size = new System.Drawing.Size(154, 30);
            this.cmbNhanVienN.TabIndex = 22;
            // 
            // dTPNgayNhap
            // 
            this.dTPNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTPNgayNhap.Location = new System.Drawing.Point(103, 77);
            this.dTPNgayNhap.Name = "dTPNgayNhap";
            this.dTPNgayNhap.Size = new System.Drawing.Size(130, 30);
            this.dTPNgayNhap.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(370, 78);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 22);
            this.label5.TabIndex = 7;
            this.label5.Text = "Nhà cung cấp";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(370, 29);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(120, 22);
            this.label10.TabIndex = 5;
            this.label10.Text = "Nhân viên lập";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 81);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 22);
            this.label11.TabIndex = 3;
            this.label11.Text = "Ngày nhập";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 30);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(104, 22);
            this.label12.TabIndex = 1;
            this.label12.Text = "Mã hóa đơn";
            // 
            // txtMaHDN
            // 
            this.txtMaHDN.Location = new System.Drawing.Point(104, 30);
            this.txtMaHDN.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaHDN.Name = "txtMaHDN";
            this.txtMaHDN.ReadOnly = true;
            this.txtMaHDN.Size = new System.Drawing.Size(130, 30);
            this.txtMaHDN.TabIndex = 0;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dtgvDSHDN);
            this.groupBox6.Location = new System.Drawing.Point(2, 210);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox6.Size = new System.Drawing.Size(854, 265);
            this.groupBox6.TabIndex = 11;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Danh sách hóa đơn nhập";
            // 
            // dtgvDSHDN
            // 
            this.dtgvDSHDN.AllowUserToAddRows = false;
            this.dtgvDSHDN.AllowUserToDeleteRows = false;
            this.dtgvDSHDN.BackgroundColor = System.Drawing.SystemColors.InactiveBorder;
            this.dtgvDSHDN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvDSHDN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SoHDN,
            this.MaNV,
            this.MaNCC,
            this.NgayNhap,
            this.ThanhTienNhap});
            this.dtgvDSHDN.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvDSHDN.Location = new System.Drawing.Point(5, 28);
            this.dtgvDSHDN.Margin = new System.Windows.Forms.Padding(5);
            this.dtgvDSHDN.Name = "dtgvDSHDN";
            this.dtgvDSHDN.ReadOnly = true;
            this.dtgvDSHDN.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvDSHDN.Size = new System.Drawing.Size(844, 232);
            this.dtgvDSHDN.TabIndex = 0;
            this.dtgvDSHDN.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvDSHDN_CellClick);
            // 
            // SoHDN
            // 
            this.SoHDN.DataPropertyName = "SoHDN";
            this.SoHDN.HeaderText = "Số HĐN";
            this.SoHDN.Name = "SoHDN";
            this.SoHDN.ReadOnly = true;
            this.SoHDN.Width = 150;
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "MaNV";
            this.MaNV.HeaderText = "Mã NV";
            this.MaNV.Name = "MaNV";
            this.MaNV.ReadOnly = true;
            this.MaNV.Width = 120;
            // 
            // MaNCC
            // 
            this.MaNCC.DataPropertyName = "MaNCC";
            this.MaNCC.HeaderText = "Mã NCC";
            this.MaNCC.Name = "MaNCC";
            this.MaNCC.ReadOnly = true;
            this.MaNCC.Width = 120;
            // 
            // NgayNhap
            // 
            this.NgayNhap.DataPropertyName = "NgayNhap";
            this.NgayNhap.HeaderText = "Ngày Nhập";
            this.NgayNhap.Name = "NgayNhap";
            this.NgayNhap.ReadOnly = true;
            this.NgayNhap.Width = 200;
            // 
            // ThanhTienNhap
            // 
            this.ThanhTienNhap.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ThanhTienNhap.DataPropertyName = "ThanhTienNhap";
            this.ThanhTienNhap.HeaderText = "Thành Tiền";
            this.ThanhTienNhap.Name = "ThanhTienNhap";
            this.ThanhTienNhap.ReadOnly = true;
            // 
            // btnThemN
            // 
            this.btnThemN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemN.Location = new System.Drawing.Point(109, 146);
            this.btnThemN.Name = "btnThemN";
            this.btnThemN.Size = new System.Drawing.Size(72, 48);
            this.btnThemN.TabIndex = 12;
            this.btnThemN.Text = "Tạo mới hóa đơn";
            this.btnThemN.UseVisualStyleBackColor = true;
            this.btnThemN.Click += new System.EventHandler(this.btnThemN_Click);
            // 
            // btnSuaN
            // 
            this.btnSuaN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaN.Location = new System.Drawing.Point(278, 146);
            this.btnSuaN.Name = "btnSuaN";
            this.btnSuaN.Size = new System.Drawing.Size(72, 48);
            this.btnSuaN.TabIndex = 16;
            this.btnSuaN.Text = "Sửa hóa đơn";
            this.btnSuaN.UseVisualStyleBackColor = true;
            this.btnSuaN.Click += new System.EventHandler(this.btnSuaN_Click);
            // 
            // btnXoaN
            // 
            this.btnXoaN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaN.Location = new System.Drawing.Point(621, 146);
            this.btnXoaN.Name = "btnXoaN";
            this.btnXoaN.Size = new System.Drawing.Size(72, 48);
            this.btnXoaN.TabIndex = 13;
            this.btnXoaN.Text = "Xóa hóa đơn";
            this.btnXoaN.UseVisualStyleBackColor = true;
            this.btnXoaN.Click += new System.EventHandler(this.btnXoaN_Click);
            // 
            // btnInHoaDonN
            // 
            this.btnInHoaDonN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInHoaDonN.Location = new System.Drawing.Point(448, 146);
            this.btnInHoaDonN.Name = "btnInHoaDonN";
            this.btnInHoaDonN.Size = new System.Drawing.Size(72, 48);
            this.btnInHoaDonN.TabIndex = 14;
            this.btnInHoaDonN.Text = "Chi tiết";
            this.btnInHoaDonN.UseVisualStyleBackColor = true;
            this.btnInHoaDonN.Click += new System.EventHandler(this.btnInHoaDonN_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(918, 547);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmHoaDon";
            this.Text = "frmHoaDon";
            this.Load += new System.EventHandler(this.frmHoaDon_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvDSHDN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMaHDX;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnXoaX;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridViewTextBoxColumn soHDXDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayXuatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thanhTienXuatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maNVDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKHDataGridViewTextBoxColumn;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DateTimePicker dTPNgayXuat;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DateTimePicker dTPNgayNhap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtMaHDN;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.DataGridView dtgvDSHDN;
        private System.Windows.Forms.Button btnThemN;
        private System.Windows.Forms.Button btnSuaN;
        private System.Windows.Forms.Button btnXoaN;
        private System.Windows.Forms.Button btnInHoaDonN;
        private System.Windows.Forms.ListView lsvDSHDX;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.TextBox txtKhachHang;
        private System.Windows.Forms.ComboBox cmbNhanVienN;
        private System.Windows.Forms.ComboBox cmbNhaCungCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoHDN;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTienNhap;
        private System.Windows.Forms.TextBox txtNhanVien;
    }
}