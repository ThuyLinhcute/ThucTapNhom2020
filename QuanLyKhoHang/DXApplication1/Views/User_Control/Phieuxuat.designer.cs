namespace DXApplication1.Views.User_Control
{
    partial class Phieuxuat
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTKNhanvien = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTKTenKH = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtPXID = new System.Windows.Forms.TextBox();
            this.txtNVID = new System.Windows.Forms.TextBox();
            this.txtKHID = new System.Windows.Forms.TextBox();
            this.btnNhanvien = new System.Windows.Forms.Button();
            this.btnKH = new System.Windows.Forms.Button();
            this.btnChitietPX = new System.Windows.Forms.Button();
            this.dtPNgayxuat = new System.Windows.Forms.DateTimePicker();
            this.txtTongsoluong = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.txtTongtien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNhanvien = new System.Windows.Forms.TextBox();
            this.diachi = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnLuu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.Location = new System.Drawing.Point(1104, 478);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(178, 44);
            this.btnLuu.TabIndex = 35;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click_1);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(1104, 403);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(178, 44);
            this.btnXoa.TabIndex = 34;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click_1);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(1104, 328);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(178, 44);
            this.btnSua.TabIndex = 33;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click_1);
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnHuy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Location = new System.Drawing.Point(1104, 553);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(178, 44);
            this.btnHuy.TabIndex = 36;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = false;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(861, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 21);
            this.label9.TabIndex = 8;
            this.label9.Text = "Nhân viên:";
            // 
            // txtTKNhanvien
            // 
            this.txtTKNhanvien.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTKNhanvien.ForeColor = System.Drawing.Color.Black;
            this.txtTKNhanvien.Location = new System.Drawing.Point(966, 40);
            this.txtTKNhanvien.Name = "txtTKNhanvien";
            this.txtTKNhanvien.Size = new System.Drawing.Size(212, 28);
            this.txtTKNhanvien.TabIndex = 7;
            this.txtTKNhanvien.TextChanged += new System.EventHandler(this.txtTKTenKH_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(38, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 21);
            this.label8.TabIndex = 6;
            this.label8.Text = "Khách hàng:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtTKNhanvien);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.txtTKTenKH);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Red;
            this.groupBox2.Location = new System.Drawing.Point(5, 144);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1311, 89);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm";
            // 
            // txtTKTenKH
            // 
            this.txtTKTenKH.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTKTenKH.ForeColor = System.Drawing.Color.Black;
            this.txtTKTenKH.Location = new System.Drawing.Point(168, 37);
            this.txtTKTenKH.Name = "txtTKTenKH";
            this.txtTKTenKH.Size = new System.Drawing.Size(216, 28);
            this.txtTKTenKH.TabIndex = 5;
            this.txtTKTenKH.TextChanged += new System.EventHandler(this.txtTKTenKH_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 24);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.Size = new System.Drawing.Size(1074, 382);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Red;
            this.groupBox3.Location = new System.Drawing.Point(5, 239);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1080, 409);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Danh sách phiếu xuất";
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(1104, 253);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(178, 44);
            this.btnThem.TabIndex = 31;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // txtPXID
            // 
            this.txtPXID.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPXID.ForeColor = System.Drawing.Color.Black;
            this.txtPXID.Location = new System.Drawing.Point(662, 115);
            this.txtPXID.Name = "txtPXID";
            this.txtPXID.Size = new System.Drawing.Size(163, 28);
            this.txtPXID.TabIndex = 26;
            this.txtPXID.Visible = false;
            // 
            // txtNVID
            // 
            this.txtNVID.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNVID.ForeColor = System.Drawing.Color.Black;
            this.txtNVID.Location = new System.Drawing.Point(662, 7);
            this.txtNVID.Name = "txtNVID";
            this.txtNVID.Size = new System.Drawing.Size(163, 28);
            this.txtNVID.TabIndex = 25;
            this.txtNVID.Visible = false;
            // 
            // txtKHID
            // 
            this.txtKHID.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKHID.ForeColor = System.Drawing.Color.Black;
            this.txtKHID.Location = new System.Drawing.Point(157, 2);
            this.txtKHID.Name = "txtKHID";
            this.txtKHID.Size = new System.Drawing.Size(163, 28);
            this.txtKHID.TabIndex = 24;
            this.txtKHID.Visible = false;
            // 
            // btnNhanvien
            // 
            this.btnNhanvien.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanvien.ForeColor = System.Drawing.Color.Black;
            this.btnNhanvien.Location = new System.Drawing.Point(832, 34);
            this.btnNhanvien.Name = "btnNhanvien";
            this.btnNhanvien.Size = new System.Drawing.Size(31, 21);
            this.btnNhanvien.TabIndex = 23;
            this.btnNhanvien.Text = "...";
            this.btnNhanvien.UseVisualStyleBackColor = true;
            this.btnNhanvien.Visible = false;
            this.btnNhanvien.Click += new System.EventHandler(this.btnNhanvien_Click_1);
            // 
            // btnKH
            // 
            this.btnKH.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKH.ForeColor = System.Drawing.Color.Black;
            this.btnKH.Location = new System.Drawing.Point(327, 29);
            this.btnKH.Name = "btnKH";
            this.btnKH.Size = new System.Drawing.Size(31, 21);
            this.btnKH.TabIndex = 22;
            this.btnKH.Text = "...";
            this.btnKH.UseVisualStyleBackColor = true;
            this.btnKH.Visible = false;
            this.btnKH.Click += new System.EventHandler(this.btnKH_Click_1);
            // 
            // btnChitietPX
            // 
            this.btnChitietPX.BackColor = System.Drawing.Color.LightGray;
            this.btnChitietPX.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChitietPX.ForeColor = System.Drawing.Color.Black;
            this.btnChitietPX.Location = new System.Drawing.Point(1031, 81);
            this.btnChitietPX.Name = "btnChitietPX";
            this.btnChitietPX.Size = new System.Drawing.Size(199, 25);
            this.btnChitietPX.TabIndex = 21;
            this.btnChitietPX.Text = "Chi tiết phiếu xuất";
            this.btnChitietPX.UseVisualStyleBackColor = false;
            this.btnChitietPX.Click += new System.EventHandler(this.btnChitietPN_Click);
            // 
            // dtPNgayxuat
            // 
            this.dtPNgayxuat.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPNgayxuat.Location = new System.Drawing.Point(155, 84);
            this.dtPNgayxuat.Name = "dtPNgayxuat";
            this.dtPNgayxuat.Size = new System.Drawing.Size(163, 28);
            this.dtPNgayxuat.TabIndex = 13;
            // 
            // txtTongsoluong
            // 
            this.txtTongsoluong.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongsoluong.ForeColor = System.Drawing.Color.Black;
            this.txtTongsoluong.Location = new System.Drawing.Point(1136, 26);
            this.txtTongsoluong.Name = "txtTongsoluong";
            this.txtTongsoluong.ReadOnly = true;
            this.txtTongsoluong.Size = new System.Drawing.Size(94, 28);
            this.txtTongsoluong.TabIndex = 12;
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.ForeColor = System.Drawing.Color.Black;
            this.email.Location = new System.Drawing.Point(1006, 32);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(124, 21);
            this.email.TabIndex = 11;
            this.email.Text = "Tổng số lượng:";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.Black;
            this.label.Location = new System.Drawing.Point(549, 91);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(85, 21);
            this.label.TabIndex = 9;
            this.label.Text = "Tổng tiền:";
            // 
            // txtTongtien
            // 
            this.txtTongtien.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongtien.ForeColor = System.Drawing.Color.Black;
            this.txtTongtien.Location = new System.Drawing.Point(662, 88);
            this.txtTongtien.Name = "txtTongtien";
            this.txtTongtien.ReadOnly = true;
            this.txtTongtien.Size = new System.Drawing.Size(163, 28);
            this.txtTongtien.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(610, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 21);
            this.label5.TabIndex = 7;
            // 
            // txtNhanvien
            // 
            this.txtNhanvien.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhanvien.ForeColor = System.Drawing.Color.Black;
            this.txtNhanvien.Location = new System.Drawing.Point(662, 34);
            this.txtNhanvien.Name = "txtNhanvien";
            this.txtNhanvien.Size = new System.Drawing.Size(163, 28);
            this.txtNhanvien.TabIndex = 6;
            // 
            // diachi
            // 
            this.diachi.AutoSize = true;
            this.diachi.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.diachi.ForeColor = System.Drawing.Color.Black;
            this.diachi.Location = new System.Drawing.Point(549, 36);
            this.diachi.Name = "diachi";
            this.diachi.Size = new System.Drawing.Size(88, 21);
            this.diachi.TabIndex = 5;
            this.diachi.Text = "Nhân viên:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 21);
            this.label2.TabIndex = 2;
            // 
            // txtKH
            // 
            this.txtKH.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKH.ForeColor = System.Drawing.Color.Black;
            this.txtKH.Location = new System.Drawing.Point(157, 29);
            this.txtKH.Name = "txtKH";
            this.txtKH.Size = new System.Drawing.Size(163, 28);
            this.txtKH.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(25, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Khách hàng:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtPXID);
            this.groupBox1.Controls.Add(this.txtNVID);
            this.groupBox1.Controls.Add(this.txtKHID);
            this.groupBox1.Controls.Add(this.btnNhanvien);
            this.groupBox1.Controls.Add(this.btnKH);
            this.groupBox1.Controls.Add(this.btnChitietPX);
            this.groupBox1.Controls.Add(this.dtPNgayxuat);
            this.groupBox1.Controls.Add(this.txtTongsoluong);
            this.groupBox1.Controls.Add(this.email);
            this.groupBox1.Controls.Add(this.label);
            this.groupBox1.Controls.Add(this.txtTongtien);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtNhanvien);
            this.groupBox1.Controls.Add(this.diachi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtKH);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(5, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1311, 137);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin phiếu xuất";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(25, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngày nhập:";
            // 
            // Phieuxuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox1);
            this.Name = "Phieuxuat";
            this.Size = new System.Drawing.Size(1323, 698);
            this.Load += new System.EventHandler(this.Phieuxuat_Load_1);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTKNhanvien;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTKTenKH;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtPXID;
        private System.Windows.Forms.TextBox txtNVID;
        private System.Windows.Forms.TextBox txtKHID;
        private System.Windows.Forms.Button btnNhanvien;
        private System.Windows.Forms.Button btnKH;
        private System.Windows.Forms.Button btnChitietPX;
        private System.Windows.Forms.DateTimePicker dtPNgayxuat;
        private System.Windows.Forms.TextBox txtTongsoluong;
        private System.Windows.Forms.Label email;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox txtTongtien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNhanvien;
        private System.Windows.Forms.Label diachi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
    }
}
