namespace QuanLyNhanSu.DAO
{
    partial class FrmQuanLyChucVu
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
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuanLyChucVu));
               this.dgrQuanLyChucVu = new DevExpress.XtraGrid.GridControl();
               this.grvQuanLyChucVu = new DevExpress.XtraGrid.Views.Grid.GridView();
               this.ChucVuID = new DevExpress.XtraGrid.Columns.GridColumn();
               this.Ten = new DevExpress.XtraGrid.Columns.GridColumn();
               this.groupBox1 = new System.Windows.Forms.GroupBox();
               this.txbTenChucVu = new System.Windows.Forms.TextBox();
               this.label2 = new System.Windows.Forms.Label();
               this.btnDong = new DevExpress.XtraEditors.SimpleButton();
               this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
               this.btnThem = new DevExpress.XtraEditors.SimpleButton();
               this.btnSua = new DevExpress.XtraEditors.SimpleButton();
               this.label3 = new System.Windows.Forms.Label();
               ((System.ComponentModel.ISupportInitialize)(this.dgrQuanLyChucVu)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.grvQuanLyChucVu)).BeginInit();
               this.groupBox1.SuspendLayout();
               this.SuspendLayout();
               // 
               // dgrQuanLyChucVu
               // 
               this.dgrQuanLyChucVu.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.dgrQuanLyChucVu.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               gridLevelNode1.RelationName = "Level1";
               this.dgrQuanLyChucVu.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
               this.dgrQuanLyChucVu.Location = new System.Drawing.Point(16, 31);
               this.dgrQuanLyChucVu.MainView = this.grvQuanLyChucVu;
               this.dgrQuanLyChucVu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.dgrQuanLyChucVu.Name = "dgrQuanLyChucVu";
               this.dgrQuanLyChucVu.Size = new System.Drawing.Size(904, 590);
               this.dgrQuanLyChucVu.TabIndex = 1;
               this.dgrQuanLyChucVu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvQuanLyChucVu});
               // 
               // grvQuanLyChucVu
               // 
               this.grvQuanLyChucVu.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ChucVuID,
            this.Ten});
               this.grvQuanLyChucVu.DetailHeight = 431;
               this.grvQuanLyChucVu.GridControl = this.dgrQuanLyChucVu;
               this.grvQuanLyChucVu.Name = "grvQuanLyChucVu";
               this.grvQuanLyChucVu.PaintStyleName = "Flat";
               this.grvQuanLyChucVu.RowHeight = 37;
               // 
               // ChucVuID
               // 
               this.ChucVuID.Caption = "Mã chức vụ";
               this.ChucVuID.FieldName = "CHUCVUID";
               this.ChucVuID.MinWidth = 27;
               this.ChucVuID.Name = "ChucVuID";
               this.ChucVuID.Visible = true;
               this.ChucVuID.VisibleIndex = 0;
               this.ChucVuID.Width = 236;
               // 
               // Ten
               // 
               this.Ten.Caption = "Tên chức vụ";
               this.Ten.FieldName = "TEN";
               this.Ten.MinWidth = 27;
               this.Ten.Name = "Ten";
               this.Ten.Visible = true;
               this.Ten.VisibleIndex = 1;
               this.Ten.Width = 645;
               // 
               // groupBox1
               // 
               this.groupBox1.BackColor = System.Drawing.Color.White;
               this.groupBox1.Controls.Add(this.txbTenChucVu);
               this.groupBox1.Controls.Add(this.label2);
               this.groupBox1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.groupBox1.Location = new System.Drawing.Point(959, 186);
               this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.groupBox1.Name = "groupBox1";
               this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.groupBox1.Size = new System.Drawing.Size(680, 133);
               this.groupBox1.TabIndex = 2;
               this.groupBox1.TabStop = false;
               this.groupBox1.Text = "Thông tin chức vụ";
               // 
               // txbTenChucVu
               // 
               this.txbTenChucVu.Location = new System.Drawing.Point(180, 54);
               this.txbTenChucVu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.txbTenChucVu.Name = "txbTenChucVu";
               this.txbTenChucVu.Size = new System.Drawing.Size(425, 23);
               this.txbTenChucVu.TabIndex = 1;
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.Location = new System.Drawing.Point(61, 58);
               this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(86, 17);
               this.label2.TabIndex = 0;
               this.label2.Text = "Tên chức vụ";
               // 
               // btnDong
               // 
               this.btnDong.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnDong.Appearance.Options.UseFont = true;
               this.btnDong.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
               this.btnDong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.ImageOptions.Image")));
               this.btnDong.Location = new System.Drawing.Point(1060, 517);
               this.btnDong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.btnDong.Name = "btnDong";
               this.btnDong.Size = new System.Drawing.Size(540, 53);
               this.btnDong.TabIndex = 3;
               this.btnDong.Text = "Đóng chức năng";
               this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
               // 
               // btnXoa
               // 
               this.btnXoa.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnXoa.Appearance.Options.UseFont = true;
               this.btnXoa.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
               this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
               this.btnXoa.Location = new System.Drawing.Point(1060, 457);
               this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.btnXoa.Name = "btnXoa";
               this.btnXoa.Size = new System.Drawing.Size(540, 53);
               this.btnXoa.TabIndex = 4;
               this.btnXoa.Text = "Xóa";
               this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
               // 
               // btnThem
               // 
               this.btnThem.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnThem.Appearance.Options.UseFont = true;
               this.btnThem.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
               this.btnThem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThem.ImageOptions.SvgImage")));
               this.btnThem.Location = new System.Drawing.Point(1060, 397);
               this.btnThem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.btnThem.Name = "btnThem";
               this.btnThem.Size = new System.Drawing.Size(196, 53);
               this.btnThem.TabIndex = 5;
               this.btnThem.Text = "Thêm";
               this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
               // 
               // btnSua
               // 
               this.btnSua.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnSua.Appearance.Options.UseFont = true;
               this.btnSua.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
               this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
               this.btnSua.Location = new System.Drawing.Point(1404, 397);
               this.btnSua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.btnSua.Name = "btnSua";
               this.btnSua.Size = new System.Drawing.Size(196, 53);
               this.btnSua.TabIndex = 6;
               this.btnSua.Text = "Sửa";
               this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
               // 
               // label3
               // 
               this.label3.AutoSize = true;
               this.label3.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label3.Location = new System.Drawing.Point(16, 11);
               this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.label3.Name = "label3";
               this.label3.Size = new System.Drawing.Size(128, 17);
               this.label3.TabIndex = 7;
               this.label3.Text = "Danh sách chức vụ";
               // 
               // FrmQuanLyChucVu
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
               this.Controls.Add(this.dgrQuanLyChucVu);
               this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
               this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.Name = "FrmQuanLyChucVu";
               this.Text = "FrmQuanLyChucVu";
               this.Load += new System.EventHandler(this.FrmQuanLyChucVu_Load);
               ((System.ComponentModel.ISupportInitialize)(this.dgrQuanLyChucVu)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.grvQuanLyChucVu)).EndInit();
               this.groupBox1.ResumeLayout(false);
               this.groupBox1.PerformLayout();
               this.ResumeLayout(false);
               this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dgrQuanLyChucVu;
        private DevExpress.XtraGrid.Views.Grid.GridView grvQuanLyChucVu;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txbTenChucVu;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton btnDong;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraGrid.Columns.GridColumn ChucVuID;
        private DevExpress.XtraGrid.Columns.GridColumn Ten;
    }
}