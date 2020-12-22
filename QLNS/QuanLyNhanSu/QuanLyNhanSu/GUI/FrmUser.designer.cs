namespace QuanLyNhanSu.GUI
{
    partial class FrmUser
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
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUser));
               DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
               this.label3 = new System.Windows.Forms.Label();
               this.btnSua = new DevExpress.XtraEditors.SimpleButton();
               this.btnThem = new DevExpress.XtraEditors.SimpleButton();
               this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
               this.btnDong = new DevExpress.XtraEditors.SimpleButton();
               this.groupBox1 = new System.Windows.Forms.GroupBox();
               this.cboPhanQuyen = new System.Windows.Forms.ComboBox();
               this.label4 = new System.Windows.Forms.Label();
               this.txbMatKhau = new System.Windows.Forms.TextBox();
               this.label1 = new System.Windows.Forms.Label();
               this.txbTenDangNhap = new System.Windows.Forms.TextBox();
               this.label2 = new System.Windows.Forms.Label();
               this.dgrQuanLyNguoiDung = new DevExpress.XtraGrid.GridControl();
               this.grvQuanLyNguoiDung = new DevExpress.XtraGrid.Views.Grid.GridView();
               this.ChucVuID = new DevExpress.XtraGrid.Columns.GridColumn();
               this.Ten = new DevExpress.XtraGrid.Columns.GridColumn();
               this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
               this.groupBox1.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.dgrQuanLyNguoiDung)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.grvQuanLyNguoiDung)).BeginInit();
               this.SuspendLayout();
               // 
               // label3
               // 
               this.label3.AutoSize = true;
               this.label3.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label3.Location = new System.Drawing.Point(20, 22);
               this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.label3.Name = "label3";
               this.label3.Size = new System.Drawing.Size(148, 17);
               this.label3.TabIndex = 14;
               this.label3.Text = "Danh sách người dùng";
               // 
               // btnSua
               // 
               this.btnSua.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
               this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
               this.btnSua.Location = new System.Drawing.Point(1373, 423);
               this.btnSua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.btnSua.Name = "btnSua";
               this.btnSua.Size = new System.Drawing.Size(179, 53);
               this.btnSua.TabIndex = 13;
               this.btnSua.Text = "Sửa";
               this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
               // 
               // btnThem
               // 
               this.btnThem.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
               this.btnThem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThem.ImageOptions.SvgImage")));
               this.btnThem.Location = new System.Drawing.Point(1143, 423);
               this.btnThem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.btnThem.Name = "btnThem";
               this.btnThem.Size = new System.Drawing.Size(199, 53);
               this.btnThem.TabIndex = 12;
               this.btnThem.Text = "Thêm";
               this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
               // 
               // btnXoa
               // 
               this.btnXoa.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
               this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
               this.btnXoa.Location = new System.Drawing.Point(1143, 493);
               this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.btnXoa.Name = "btnXoa";
               this.btnXoa.Size = new System.Drawing.Size(409, 53);
               this.btnXoa.TabIndex = 11;
               this.btnXoa.Text = "Xóa";
               this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
               // 
               // btnDong
               // 
               this.btnDong.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
               this.btnDong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.ImageOptions.Image")));
               this.btnDong.Location = new System.Drawing.Point(1143, 554);
               this.btnDong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.btnDong.Name = "btnDong";
               this.btnDong.Size = new System.Drawing.Size(409, 53);
               this.btnDong.TabIndex = 10;
               this.btnDong.Text = "Đóng chức năng";
               this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
               // 
               // groupBox1
               // 
               this.groupBox1.BackColor = System.Drawing.Color.White;
               this.groupBox1.Controls.Add(this.cboPhanQuyen);
               this.groupBox1.Controls.Add(this.label4);
               this.groupBox1.Controls.Add(this.txbMatKhau);
               this.groupBox1.Controls.Add(this.label1);
               this.groupBox1.Controls.Add(this.txbTenDangNhap);
               this.groupBox1.Controls.Add(this.label2);
               this.groupBox1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.groupBox1.Location = new System.Drawing.Point(963, 148);
               this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.groupBox1.Name = "groupBox1";
               this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.groupBox1.Size = new System.Drawing.Size(680, 196);
               this.groupBox1.TabIndex = 9;
               this.groupBox1.TabStop = false;
               this.groupBox1.Text = "Thông tin người dùng";
               // 
               // cboPhanQuyen
               // 
               this.cboPhanQuyen.FormattingEnabled = true;
               this.cboPhanQuyen.Items.AddRange(new object[] {
            "Admin",
            "User"});
               this.cboPhanQuyen.Location = new System.Drawing.Point(180, 126);
               this.cboPhanQuyen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.cboPhanQuyen.Name = "cboPhanQuyen";
               this.cboPhanQuyen.Size = new System.Drawing.Size(425, 24);
               this.cboPhanQuyen.TabIndex = 5;
               // 
               // label4
               // 
               this.label4.AutoSize = true;
               this.label4.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label4.Location = new System.Drawing.Point(61, 129);
               this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.label4.Name = "label4";
               this.label4.Size = new System.Drawing.Size(82, 17);
               this.label4.TabIndex = 4;
               this.label4.Text = "Phân quyền";
               // 
               // txbMatKhau
               // 
               this.txbMatKhau.Location = new System.Drawing.Point(180, 90);
               this.txbMatKhau.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.txbMatKhau.Name = "txbMatKhau";
               this.txbMatKhau.Size = new System.Drawing.Size(425, 23);
               this.txbMatKhau.TabIndex = 3;
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label1.Location = new System.Drawing.Point(61, 94);
               this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(64, 17);
               this.label1.TabIndex = 2;
               this.label1.Text = "Mật khẩu";
               // 
               // txbTenDangNhap
               // 
               this.txbTenDangNhap.Location = new System.Drawing.Point(180, 54);
               this.txbTenDangNhap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.txbTenDangNhap.Name = "txbTenDangNhap";
               this.txbTenDangNhap.Size = new System.Drawing.Size(425, 23);
               this.txbTenDangNhap.TabIndex = 1;
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label2.Location = new System.Drawing.Point(61, 58);
               this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(101, 17);
               this.label2.TabIndex = 0;
               this.label2.Text = "Tên đăng nhập";
               // 
               // dgrQuanLyNguoiDung
               // 
               this.dgrQuanLyNguoiDung.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.dgrQuanLyNguoiDung.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               gridLevelNode1.RelationName = "Level1";
               this.dgrQuanLyNguoiDung.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
               this.dgrQuanLyNguoiDung.Location = new System.Drawing.Point(20, 42);
               this.dgrQuanLyNguoiDung.MainView = this.grvQuanLyNguoiDung;
               this.dgrQuanLyNguoiDung.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.dgrQuanLyNguoiDung.Name = "dgrQuanLyNguoiDung";
               this.dgrQuanLyNguoiDung.Size = new System.Drawing.Size(889, 597);
               this.dgrQuanLyNguoiDung.TabIndex = 8;
               this.dgrQuanLyNguoiDung.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvQuanLyNguoiDung});
               // 
               // grvQuanLyNguoiDung
               // 
               this.grvQuanLyNguoiDung.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ChucVuID,
            this.Ten,
            this.gridColumn1});
               this.grvQuanLyNguoiDung.DetailHeight = 431;
               this.grvQuanLyNguoiDung.GridControl = this.dgrQuanLyNguoiDung;
               this.grvQuanLyNguoiDung.Name = "grvQuanLyNguoiDung";
               this.grvQuanLyNguoiDung.OptionsBehavior.ReadOnly = true;
               this.grvQuanLyNguoiDung.OptionsView.ShowGroupPanel = false;
               this.grvQuanLyNguoiDung.PaintStyleName = "Flat";
               this.grvQuanLyNguoiDung.RowHeight = 37;
               // 
               // ChucVuID
               // 
               this.ChucVuID.Caption = "Tên đăng nhập";
               this.ChucVuID.FieldName = "USERNAME";
               this.ChucVuID.MinWidth = 27;
               this.ChucVuID.Name = "ChucVuID";
               this.ChucVuID.Visible = true;
               this.ChucVuID.VisibleIndex = 0;
               this.ChucVuID.Width = 211;
               // 
               // Ten
               // 
               this.Ten.Caption = "mật khẩu";
               this.Ten.FieldName = "PASSWORD";
               this.Ten.MinWidth = 27;
               this.Ten.Name = "Ten";
               this.Ten.Visible = true;
               this.Ten.VisibleIndex = 1;
               this.Ten.Width = 267;
               // 
               // gridColumn1
               // 
               this.gridColumn1.Caption = "Phân quyền";
               this.gridColumn1.FieldName = "TYPE";
               this.gridColumn1.MinWidth = 27;
               this.gridColumn1.Name = "gridColumn1";
               this.gridColumn1.Visible = true;
               this.gridColumn1.VisibleIndex = 2;
               this.gridColumn1.Width = 404;
               // 
               // FrmUser
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(1661, 652);
               this.Controls.Add(this.label3);
               this.Controls.Add(this.btnSua);
               this.Controls.Add(this.btnThem);
               this.Controls.Add(this.btnXoa);
               this.Controls.Add(this.btnDong);
               this.Controls.Add(this.groupBox1);
               this.Controls.Add(this.dgrQuanLyNguoiDung);
               this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
               this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.Name = "FrmUser";
               this.Text = "FrmUser";
               this.groupBox1.ResumeLayout(false);
               this.groupBox1.PerformLayout();
               ((System.ComponentModel.ISupportInitialize)(this.dgrQuanLyNguoiDung)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.grvQuanLyNguoiDung)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnDong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboPhanQuyen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbMatKhau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbTenDangNhap;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraGrid.GridControl dgrQuanLyNguoiDung;
        private DevExpress.XtraGrid.Views.Grid.GridView grvQuanLyNguoiDung;
        private DevExpress.XtraGrid.Columns.GridColumn ChucVuID;
        private DevExpress.XtraGrid.Columns.GridColumn Ten;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
    }
}