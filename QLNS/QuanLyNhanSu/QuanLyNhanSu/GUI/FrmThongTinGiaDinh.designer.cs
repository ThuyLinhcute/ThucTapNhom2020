namespace QuanLyNhanSu.GUI
{
    partial class FrmThongTinGiaDinh
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
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmThongTinGiaDinh));
               this.dgrGiaDinh = new DevExpress.XtraGrid.GridControl();
               this.grvGiaDinh = new DevExpress.XtraGrid.Views.Grid.GridView();
               this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
               this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
               this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
               this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
               this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
               this.btnDong = new DevExpress.XtraEditors.SimpleButton();
               this.btnSua = new DevExpress.XtraEditors.SimpleButton();
               this.label3 = new System.Windows.Forms.Label();
               this.label5 = new System.Windows.Forms.Label();
               this.label4 = new System.Windows.Forms.Label();
               this.label2 = new System.Windows.Forms.Label();
               this.btnThem = new DevExpress.XtraEditors.SimpleButton();
               this.groupBox1 = new System.Windows.Forms.GroupBox();
               this.cboGioiTinh = new System.Windows.Forms.ComboBox();
               this.cboChucVu = new System.Windows.Forms.ComboBox();
               this.txbHoTen = new System.Windows.Forms.TextBox();
               this.cboNhanVien = new System.Windows.Forms.ComboBox();
               this.btnXuat = new DevExpress.XtraEditors.SimpleButton();
               ((System.ComponentModel.ISupportInitialize)(this.dgrGiaDinh)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.grvGiaDinh)).BeginInit();
               this.groupBox1.SuspendLayout();
               this.SuspendLayout();
               // 
               // dgrGiaDinh
               // 
               this.dgrGiaDinh.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               gridLevelNode1.RelationName = "Level1";
               this.dgrGiaDinh.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
               this.dgrGiaDinh.Location = new System.Drawing.Point(20, 64);
               this.dgrGiaDinh.MainView = this.grvGiaDinh;
               this.dgrGiaDinh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.dgrGiaDinh.Name = "dgrGiaDinh";
               this.dgrGiaDinh.Size = new System.Drawing.Size(904, 569);
               this.dgrGiaDinh.TabIndex = 60;
               this.dgrGiaDinh.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvGiaDinh});
               // 
               // grvGiaDinh
               // 
               this.grvGiaDinh.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
               this.grvGiaDinh.DetailHeight = 431;
               this.grvGiaDinh.GridControl = this.dgrGiaDinh;
               this.grvGiaDinh.Name = "grvGiaDinh";
               this.grvGiaDinh.PaintStyleName = "Flat";
               this.grvGiaDinh.RowHeight = 37;
               // 
               // gridColumn1
               // 
               this.gridColumn1.Caption = "Mã thân nhân";
               this.gridColumn1.FieldName = "THANNHANID";
               this.gridColumn1.MinWidth = 27;
               this.gridColumn1.Name = "gridColumn1";
               this.gridColumn1.Visible = true;
               this.gridColumn1.VisibleIndex = 0;
               this.gridColumn1.Width = 100;
               // 
               // gridColumn2
               // 
               this.gridColumn2.Caption = "Họ tên";
               this.gridColumn2.FieldName = "HOTEN";
               this.gridColumn2.MinWidth = 27;
               this.gridColumn2.Name = "gridColumn2";
               this.gridColumn2.Visible = true;
               this.gridColumn2.VisibleIndex = 1;
               this.gridColumn2.Width = 100;
               // 
               // gridColumn3
               // 
               this.gridColumn3.Caption = "giơi tính";
               this.gridColumn3.FieldName = "TENGIOITINH";
               this.gridColumn3.MinWidth = 27;
               this.gridColumn3.Name = "gridColumn3";
               this.gridColumn3.Visible = true;
               this.gridColumn3.VisibleIndex = 2;
               this.gridColumn3.Width = 100;
               // 
               // gridColumn4
               // 
               this.gridColumn4.Caption = "Chức vụ";
               this.gridColumn4.FieldName = "TENCV";
               this.gridColumn4.MinWidth = 27;
               this.gridColumn4.Name = "gridColumn4";
               this.gridColumn4.Visible = true;
               this.gridColumn4.VisibleIndex = 3;
               this.gridColumn4.Width = 100;
               // 
               // btnXoa
               // 
               this.btnXoa.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
               this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
               this.btnXoa.Location = new System.Drawing.Point(963, 462);
               this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.btnXoa.Name = "btnXoa";
               this.btnXoa.Size = new System.Drawing.Size(680, 53);
               this.btnXoa.TabIndex = 63;
               this.btnXoa.Text = "Xóa";
               this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
               // 
               // btnDong
               // 
               this.btnDong.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
               this.btnDong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.ImageOptions.Image")));
               this.btnDong.Location = new System.Drawing.Point(963, 580);
               this.btnDong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.btnDong.Name = "btnDong";
               this.btnDong.Size = new System.Drawing.Size(680, 53);
               this.btnDong.TabIndex = 62;
               this.btnDong.Text = "Đóng chức năng";
               this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
               // 
               // btnSua
               // 
               this.btnSua.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
               this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
               this.btnSua.Location = new System.Drawing.Point(1307, 401);
               this.btnSua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.btnSua.Name = "btnSua";
               this.btnSua.Size = new System.Drawing.Size(336, 53);
               this.btnSua.TabIndex = 65;
               this.btnSua.Text = "Sửa";
               this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
               // 
               // label3
               // 
               this.label3.AutoSize = true;
               this.label3.Location = new System.Drawing.Point(47, 23);
               this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.label3.Name = "label3";
               this.label3.Size = new System.Drawing.Size(215, 17);
               this.label3.TabIndex = 66;
               this.label3.Text = "Thông tin gia đình của nhân viên";
               // 
               // label5
               // 
               this.label5.AutoSize = true;
               this.label5.Location = new System.Drawing.Point(72, 182);
               this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.label5.Name = "label5";
               this.label5.Size = new System.Drawing.Size(59, 17);
               this.label5.TabIndex = 20;
               this.label5.Text = "Chức vụ";
               // 
               // label4
               // 
               this.label4.AutoSize = true;
               this.label4.Location = new System.Drawing.Point(72, 55);
               this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.label4.Name = "label4";
               this.label4.Size = new System.Drawing.Size(50, 17);
               this.label4.TabIndex = 15;
               this.label4.Text = "Họ tên";
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.Location = new System.Drawing.Point(72, 119);
               this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(60, 17);
               this.label2.TabIndex = 0;
               this.label2.Text = "Giới tính";
               // 
               // btnThem
               // 
               this.btnThem.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
               this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
               this.btnThem.Location = new System.Drawing.Point(963, 401);
               this.btnThem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.btnThem.Name = "btnThem";
               this.btnThem.Size = new System.Drawing.Size(336, 53);
               this.btnThem.TabIndex = 64;
               this.btnThem.Text = "Thêm";
               this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
               // 
               // groupBox1
               // 
               this.groupBox1.BackColor = System.Drawing.Color.White;
               this.groupBox1.Controls.Add(this.cboGioiTinh);
               this.groupBox1.Controls.Add(this.cboChucVu);
               this.groupBox1.Controls.Add(this.txbHoTen);
               this.groupBox1.Controls.Add(this.label5);
               this.groupBox1.Controls.Add(this.label4);
               this.groupBox1.Controls.Add(this.label2);
               this.groupBox1.Location = new System.Drawing.Point(963, 108);
               this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.groupBox1.Name = "groupBox1";
               this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.groupBox1.Size = new System.Drawing.Size(680, 261);
               this.groupBox1.TabIndex = 61;
               this.groupBox1.TabStop = false;
               this.groupBox1.Text = "Thông tin thân nhân";
               // 
               // cboGioiTinh
               // 
               this.cboGioiTinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
               this.cboGioiTinh.FormattingEnabled = true;
               this.cboGioiTinh.Items.AddRange(new object[] {
            "Nữ",
            "Nam"});
               this.cboGioiTinh.Location = new System.Drawing.Point(199, 116);
               this.cboGioiTinh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.cboGioiTinh.Name = "cboGioiTinh";
               this.cboGioiTinh.Size = new System.Drawing.Size(177, 24);
               this.cboGioiTinh.TabIndex = 23;
               // 
               // cboChucVu
               // 
               this.cboChucVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
               this.cboChucVu.FormattingEnabled = true;
               this.cboChucVu.Location = new System.Drawing.Point(199, 182);
               this.cboChucVu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.cboChucVu.Name = "cboChucVu";
               this.cboChucVu.Size = new System.Drawing.Size(327, 24);
               this.cboChucVu.TabIndex = 22;
               // 
               // txbHoTen
               // 
               this.txbHoTen.Location = new System.Drawing.Point(199, 52);
               this.txbHoTen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.txbHoTen.Name = "txbHoTen";
               this.txbHoTen.Size = new System.Drawing.Size(309, 22);
               this.txbHoTen.TabIndex = 21;
               // 
               // cboNhanVien
               // 
               this.cboNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
               this.cboNhanVien.FormattingEnabled = true;
               this.cboNhanVien.Location = new System.Drawing.Point(292, 20);
               this.cboNhanVien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.cboNhanVien.Name = "cboNhanVien";
               this.cboNhanVien.Size = new System.Drawing.Size(261, 24);
               this.cboNhanVien.TabIndex = 59;
               this.cboNhanVien.SelectedValueChanged += new System.EventHandler(this.cboNhanVien_SelectedValueChanged);
               // 
               // btnXuat
               // 
               this.btnXuat.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
               this.btnXuat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXuat.ImageOptions.Image")));
               this.btnXuat.Location = new System.Drawing.Point(963, 519);
               this.btnXuat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.btnXuat.Name = "btnXuat";
               this.btnXuat.Size = new System.Drawing.Size(680, 53);
               this.btnXuat.TabIndex = 83;
               this.btnXuat.Text = "Xuất ra file excel";
               this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
               // 
               // FrmThongTinGiaDinh
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(1661, 652);
               this.Controls.Add(this.btnXuat);
               this.Controls.Add(this.dgrGiaDinh);
               this.Controls.Add(this.btnXoa);
               this.Controls.Add(this.btnDong);
               this.Controls.Add(this.btnSua);
               this.Controls.Add(this.label3);
               this.Controls.Add(this.btnThem);
               this.Controls.Add(this.groupBox1);
               this.Controls.Add(this.cboNhanVien);
               this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
               this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.Name = "FrmThongTinGiaDinh";
               this.Text = "FrmThongTinGiaDinh";
               ((System.ComponentModel.ISupportInitialize)(this.dgrGiaDinh)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.grvGiaDinh)).EndInit();
               this.groupBox1.ResumeLayout(false);
               this.groupBox1.PerformLayout();
               this.ResumeLayout(false);
               this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dgrGiaDinh;
        private DevExpress.XtraGrid.Views.Grid.GridView grvGiaDinh;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnDong;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboChucVu;
        private System.Windows.Forms.TextBox txbHoTen;
        private System.Windows.Forms.ComboBox cboNhanVien;
        private System.Windows.Forms.ComboBox cboGioiTinh;
        private DevExpress.XtraEditors.SimpleButton btnXuat;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;

    }
}