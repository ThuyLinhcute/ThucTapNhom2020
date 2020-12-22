namespace BanHangSieuTHi
{
    partial class frmChiTietHoaDonNhap
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.cmbHangHoa = new System.Windows.Forms.ComboBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dTPHSD = new System.Windows.Forms.DateTimePicker();
            this.dTPNSX = new System.Windows.Forms.DateTimePicker();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMaHang = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaLoai = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHDN = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvHangHoa = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoHDN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGiaN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgaySX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HSD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangHoa)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.btnSave);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnExit);
            this.groupBox2.Controls.Add(this.btnEdit);
            this.groupBox2.Controls.Add(this.label23);
            this.groupBox2.Controls.Add(this.cmbHangHoa);
            this.groupBox2.Controls.Add(this.btnThem);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 118);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(1199, 94);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thao tác";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(777, 28);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 36);
            this.btnSave.TabIndex = 45;
            this.btnSave.Text = "Lưu";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(921, 28);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 36);
            this.btnDelete.TabIndex = 41;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(1053, 28);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(120, 36);
            this.btnExit.TabIndex = 44;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(645, 28);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(120, 36);
            this.btnEdit.TabIndex = 42;
            this.btnEdit.Text = "Cập Nhật";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(32, 38);
            this.label23.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(79, 19);
            this.label23.TabIndex = 26;
            this.label23.Text = "Tên Hàng";
            // 
            // cmbHangHoa
            // 
            this.cmbHangHoa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbHangHoa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbHangHoa.FormattingEnabled = true;
            this.cmbHangHoa.Location = new System.Drawing.Point(121, 37);
            this.cmbHangHoa.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.cmbHangHoa.Name = "cmbHangHoa";
            this.cmbHangHoa.Size = new System.Drawing.Size(256, 27);
            this.cmbHangHoa.TabIndex = 27;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(391, 32);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(100, 36);
            this.btnThem.TabIndex = 28;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.dTPHSD);
            this.groupBox1.Controls.Add(this.dTPNSX);
            this.groupBox1.Controls.Add(this.txtDonGia);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtMaHang);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtMaLoai);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtTongTien);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtHDN);
            this.groupBox1.Controls.Add(this.txtSoLuong);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(899, 238);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(311, 501);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi Tiết Mặt Hàng";
            // 
            // dTPHSD
            // 
            this.dTPHSD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTPHSD.Location = new System.Drawing.Point(131, 303);
            this.dTPHSD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dTPHSD.Name = "dTPHSD";
            this.dTPHSD.Size = new System.Drawing.Size(156, 27);
            this.dTPHSD.TabIndex = 49;
            // 
            // dTPNSX
            // 
            this.dTPNSX.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTPNSX.Location = new System.Drawing.Point(131, 263);
            this.dTPNSX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dTPNSX.Name = "dTPNSX";
            this.dTPNSX.Size = new System.Drawing.Size(156, 27);
            this.dTPNSX.TabIndex = 48;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Location = new System.Drawing.Point(131, 183);
            this.txtDonGia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.ReadOnly = true;
            this.txtDonGia.Size = new System.Drawing.Size(156, 27);
            this.txtDonGia.TabIndex = 47;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 186);
            this.label8.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 19);
            this.label8.TabIndex = 46;
            this.label8.Text = "Đơn giá";
            // 
            // txtMaHang
            // 
            this.txtMaHang.Location = new System.Drawing.Point(131, 143);
            this.txtMaHang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaHang.Name = "txtMaHang";
            this.txtMaHang.ReadOnly = true;
            this.txtMaHang.Size = new System.Drawing.Size(156, 27);
            this.txtMaHang.TabIndex = 45;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 145);
            this.label7.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 19);
            this.label7.TabIndex = 44;
            this.label7.Text = "Mã Hàng";
            // 
            // txtMaLoai
            // 
            this.txtMaLoai.Location = new System.Drawing.Point(131, 103);
            this.txtMaLoai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMaLoai.Name = "txtMaLoai";
            this.txtMaLoai.ReadOnly = true;
            this.txtMaLoai.Size = new System.Drawing.Size(156, 27);
            this.txtMaLoai.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 104);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 19);
            this.label4.TabIndex = 42;
            this.label4.Text = "Mã Loại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 309);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 19);
            this.label3.TabIndex = 40;
            this.label3.Text = "Hạn SD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 268);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 19);
            this.label2.TabIndex = 38;
            this.label2.Text = "Ngày SX";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(131, 343);
            this.txtTongTien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(156, 27);
            this.txtTongTien.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 63);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 19);
            this.label1.TabIndex = 26;
            this.label1.Text = "Số HĐN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 350);
            this.label6.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 19);
            this.label6.TabIndex = 36;
            this.label6.Text = "Tổng Tiền";
            // 
            // txtHDN
            // 
            this.txtHDN.Location = new System.Drawing.Point(131, 63);
            this.txtHDN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHDN.Name = "txtHDN";
            this.txtHDN.ReadOnly = true;
            this.txtHDN.Size = new System.Drawing.Size(156, 27);
            this.txtHDN.TabIndex = 27;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(131, 223);
            this.txtSoLuong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(156, 27);
            this.txtSoLuong.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 227);
            this.label5.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 19);
            this.label5.TabIndex = 34;
            this.label5.Text = "Số Lượng";
            // 
            // dgvHangHoa
            // 
            this.dgvHangHoa.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvHangHoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHangHoa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.SoHDN,
            this.MaLoai,
            this.MaHang,
            this.SoLuongNhap,
            this.DonGiaN,
            this.NgaySX,
            this.HSD});
            this.dgvHangHoa.Location = new System.Drawing.Point(11, 238);
            this.dgvHangHoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvHangHoa.Name = "dgvHangHoa";
            this.dgvHangHoa.ReadOnly = true;
            this.dgvHangHoa.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHangHoa.Size = new System.Drawing.Size(880, 501);
            this.dgvHangHoa.TabIndex = 43;
            this.dgvHangHoa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHangHoa_CellClick);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // SoHDN
            // 
            this.SoHDN.DataPropertyName = "SoHDN";
            this.SoHDN.HeaderText = "Mã HĐN";
            this.SoHDN.Name = "SoHDN";
            this.SoHDN.ReadOnly = true;
            // 
            // MaLoai
            // 
            this.MaLoai.DataPropertyName = "MaLoai";
            this.MaLoai.HeaderText = "Mã Loại";
            this.MaLoai.Name = "MaLoai";
            this.MaLoai.ReadOnly = true;
            this.MaLoai.Width = 80;
            // 
            // MaHang
            // 
            this.MaHang.DataPropertyName = "MaHang";
            this.MaHang.HeaderText = "Mã Hàng";
            this.MaHang.Name = "MaHang";
            this.MaHang.ReadOnly = true;
            this.MaHang.Width = 80;
            // 
            // SoLuongNhap
            // 
            this.SoLuongNhap.DataPropertyName = "SoLuongNhap";
            this.SoLuongNhap.HeaderText = "Số Lượng";
            this.SoLuongNhap.Name = "SoLuongNhap";
            this.SoLuongNhap.ReadOnly = true;
            this.SoLuongNhap.Width = 80;
            // 
            // DonGiaN
            // 
            this.DonGiaN.DataPropertyName = "DonGiaN";
            this.DonGiaN.HeaderText = "Đơn Giá";
            this.DonGiaN.Name = "DonGiaN";
            this.DonGiaN.ReadOnly = true;
            this.DonGiaN.Width = 80;
            // 
            // NgaySX
            // 
            this.NgaySX.DataPropertyName = "NgaySX";
            this.NgaySX.HeaderText = "Ngày SX";
            this.NgaySX.Name = "NgaySX";
            this.NgaySX.ReadOnly = true;
            this.NgaySX.Width = 90;
            // 
            // HSD
            // 
            this.HSD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.HSD.DataPropertyName = "HSD";
            this.HSD.HeaderText = "Hạn SD";
            this.HSD.Name = "HSD";
            this.HSD.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.label9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1223, 85);
            this.panel1.TabIndex = 45;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(471, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(296, 33);
            this.label9.TabIndex = 0;
            this.label9.Text = "CHI TIẾT HÓA ĐƠN";
            // 
            // frmChiTietHoaDonNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 756);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvHangHoa);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmChiTietHoaDonNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "frmChiTietHoaDonNhap";
            this.Load += new System.EventHandler(this.frmChiTietHoaDonNhap_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHangHoa)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox cmbHangHoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHDN;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvHangHoa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtMaHang;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMaLoai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dTPHSD;
        private System.Windows.Forms.DateTimePicker dTPNSX;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoHDN;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGiaN;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgaySX;
        private System.Windows.Forms.DataGridViewTextBoxColumn HSD;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
    }
}