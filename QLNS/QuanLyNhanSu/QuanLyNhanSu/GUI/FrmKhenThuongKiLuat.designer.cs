namespace QuanLyNhanSu.GUI
{
    partial class FrmKhenThuongKiLuat
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
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKhenThuongKiLuat));
               this.label4 = new System.Windows.Forms.Label();
               this.cboNhanVien = new System.Windows.Forms.ComboBox();
               this.dgrKTKL = new DevExpress.XtraGrid.GridControl();
               this.grvKTKL = new DevExpress.XtraGrid.Views.Grid.GridView();
               this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
               this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
               this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
               this.btnDong = new DevExpress.XtraEditors.SimpleButton();
               this.btnSua = new DevExpress.XtraEditors.SimpleButton();
               this.label3 = new System.Windows.Forms.Label();
               this.btnThem = new DevExpress.XtraEditors.SimpleButton();
               this.groupBox1 = new System.Windows.Forms.GroupBox();
               this.dtpThoiGian = new DevExpress.XtraEditors.DateEdit();
               this.label2 = new System.Windows.Forms.Label();
               this.txbNoiDung = new System.Windows.Forms.TextBox();
               this.label1 = new System.Windows.Forms.Label();
               this.cboKTKL = new System.Windows.Forms.ComboBox();
               this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
               this.btnXuat = new DevExpress.XtraEditors.SimpleButton();
               ((System.ComponentModel.ISupportInitialize)(this.dgrKTKL)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.grvKTKL)).BeginInit();
               this.groupBox1.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.dtpThoiGian.Properties.CalendarTimeProperties)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.dtpThoiGian.Properties)).BeginInit();
               this.SuspendLayout();
               // 
               // label4
               // 
               this.label4.AutoSize = true;
               this.label4.Location = new System.Drawing.Point(73, 122);
               this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.label4.Name = "label4";
               this.label4.Size = new System.Drawing.Size(148, 17);
               this.label4.TabIndex = 15;
               this.label4.Text = "(Khen thưởng / Kỉ luật)";
               // 
               // cboNhanVien
               // 
               this.cboNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
               this.cboNhanVien.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.cboNhanVien.FormattingEnabled = true;
               this.cboNhanVien.Location = new System.Drawing.Point(398, 9);
               this.cboNhanVien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.cboNhanVien.Name = "cboNhanVien";
               this.cboNhanVien.Size = new System.Drawing.Size(261, 24);
               this.cboNhanVien.TabIndex = 67;
               this.cboNhanVien.SelectedValueChanged += new System.EventHandler(this.cboNhanVien_SelectedValueChanged);
               // 
               // dgrKTKL
               // 
               this.dgrKTKL.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.dgrKTKL.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               gridLevelNode1.RelationName = "Level1";
               this.dgrKTKL.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
               this.dgrKTKL.Location = new System.Drawing.Point(20, 48);
               this.dgrKTKL.MainView = this.grvKTKL;
               this.dgrKTKL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.dgrKTKL.Name = "dgrKTKL";
               this.dgrKTKL.Size = new System.Drawing.Size(904, 590);
               this.dgrKTKL.TabIndex = 75;
               this.dgrKTKL.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvKTKL});
               // 
               // grvKTKL
               // 
               this.grvKTKL.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
               this.grvKTKL.DetailHeight = 431;
               this.grvKTKL.GridControl = this.dgrKTKL;
               this.grvKTKL.Name = "grvKTKL";
               this.grvKTKL.PaintStyleName = "Flat";
               this.grvKTKL.RowHeight = 37;
               // 
               // gridColumn1
               // 
               this.gridColumn1.Caption = "Mã khen thưởng kỷ luật";
               this.gridColumn1.FieldName = "KHENTHUONGKYLUATID";
               this.gridColumn1.MinWidth = 27;
               this.gridColumn1.Name = "gridColumn1";
               this.gridColumn1.Visible = true;
               this.gridColumn1.VisibleIndex = 0;
               this.gridColumn1.Width = 100;
               // 
               // gridColumn2
               // 
               this.gridColumn2.Caption = "Hình thức";
               this.gridColumn2.FieldName = "HINHTHUC";
               this.gridColumn2.MinWidth = 27;
               this.gridColumn2.Name = "gridColumn2";
               this.gridColumn2.Visible = true;
               this.gridColumn2.VisibleIndex = 1;
               this.gridColumn2.Width = 100;
               // 
               // gridColumn3
               // 
               this.gridColumn3.Caption = "Nội dung";
               this.gridColumn3.FieldName = "NOIDUNG";
               this.gridColumn3.MinWidth = 27;
               this.gridColumn3.Name = "gridColumn3";
               this.gridColumn3.Visible = true;
               this.gridColumn3.VisibleIndex = 2;
               this.gridColumn3.Width = 100;
               // 
               // btnDong
               // 
               this.btnDong.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnDong.Appearance.Options.UseFont = true;
               this.btnDong.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
               this.btnDong.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDong.ImageOptions.SvgImage")));
               this.btnDong.Location = new System.Drawing.Point(1041, 586);
               this.btnDong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.btnDong.Name = "btnDong";
               this.btnDong.Size = new System.Drawing.Size(572, 53);
               this.btnDong.TabIndex = 77;
               this.btnDong.Text = "Đóng chức năng";
               this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
               // 
               // btnSua
               // 
               this.btnSua.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnSua.Appearance.Options.UseFont = true;
               this.btnSua.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
               this.btnSua.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSua.ImageOptions.SvgImage")));
               this.btnSua.Location = new System.Drawing.Point(1385, 406);
               this.btnSua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.btnSua.Name = "btnSua";
               this.btnSua.Size = new System.Drawing.Size(228, 53);
               this.btnSua.TabIndex = 80;
               this.btnSua.Text = "Sửa";
               this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
               // 
               // label3
               // 
               this.label3.AutoSize = true;
               this.label3.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label3.Location = new System.Drawing.Point(40, 16);
               this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.label3.Name = "label3";
               this.label3.Size = new System.Drawing.Size(280, 17);
               this.label3.TabIndex = 81;
               this.label3.Text = "Thông tin khen thưởng kỉ luật của nhân viên";
               // 
               // btnThem
               // 
               this.btnThem.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnThem.Appearance.Options.UseFont = true;
               this.btnThem.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
               this.btnThem.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnThem.ImageOptions.SvgImage")));
               this.btnThem.Location = new System.Drawing.Point(1041, 406);
               this.btnThem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.btnThem.Name = "btnThem";
               this.btnThem.Size = new System.Drawing.Size(228, 53);
               this.btnThem.TabIndex = 79;
               this.btnThem.Text = "Thêm";
               this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
               // 
               // groupBox1
               // 
               this.groupBox1.BackColor = System.Drawing.Color.White;
               this.groupBox1.Controls.Add(this.dtpThoiGian);
               this.groupBox1.Controls.Add(this.label2);
               this.groupBox1.Controls.Add(this.txbNoiDung);
               this.groupBox1.Controls.Add(this.label1);
               this.groupBox1.Controls.Add(this.cboKTKL);
               this.groupBox1.Controls.Add(this.label4);
               this.groupBox1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.groupBox1.Location = new System.Drawing.Point(965, 96);
               this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.groupBox1.Name = "groupBox1";
               this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.groupBox1.Size = new System.Drawing.Size(680, 302);
               this.groupBox1.TabIndex = 76;
               this.groupBox1.TabStop = false;
               this.groupBox1.Text = "Chi tiết khen thưởng kỉ luật";
               // 
               // dtpThoiGian
               // 
               this.dtpThoiGian.EditValue = new System.DateTime(2017, 7, 3, 22, 39, 47, 97);
               this.dtpThoiGian.Location = new System.Drawing.Point(233, 52);
               this.dtpThoiGian.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.dtpThoiGian.Name = "dtpThoiGian";
               this.dtpThoiGian.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
               this.dtpThoiGian.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
               this.dtpThoiGian.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
               this.dtpThoiGian.Size = new System.Drawing.Size(219, 24);
               this.dtpThoiGian.TabIndex = 20;
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.Location = new System.Drawing.Point(73, 57);
               this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(63, 17);
               this.label2.TabIndex = 19;
               this.label2.Text = "Thời gian";
               // 
               // txbNoiDung
               // 
               this.txbNoiDung.Location = new System.Drawing.Point(233, 185);
               this.txbNoiDung.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.txbNoiDung.Multiline = true;
               this.txbNoiDung.Name = "txbNoiDung";
               this.txbNoiDung.Size = new System.Drawing.Size(377, 83);
               this.txbNoiDung.TabIndex = 18;
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Location = new System.Drawing.Point(73, 188);
               this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(63, 17);
               this.label1.TabIndex = 17;
               this.label1.Text = "Nội dung";
               // 
               // cboKTKL
               // 
               this.cboKTKL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
               this.cboKTKL.FormattingEnabled = true;
               this.cboKTKL.Items.AddRange(new object[] {
            "Kỷ luật",
            "Khen thưởng"});
               this.cboKTKL.Location = new System.Drawing.Point(233, 118);
               this.cboKTKL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.cboKTKL.Name = "cboKTKL";
               this.cboKTKL.Size = new System.Drawing.Size(299, 24);
               this.cboKTKL.TabIndex = 16;
               // 
               // btnXoa
               // 
               this.btnXoa.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnXoa.Appearance.Options.UseFont = true;
               this.btnXoa.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
               this.btnXoa.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnXoa.ImageOptions.SvgImage")));
               this.btnXoa.Location = new System.Drawing.Point(1041, 466);
               this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.btnXoa.Name = "btnXoa";
               this.btnXoa.Size = new System.Drawing.Size(572, 53);
               this.btnXoa.TabIndex = 78;
               this.btnXoa.Text = "Xóa";
               this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
               // 
               // btnXuat
               // 
               this.btnXuat.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnXuat.Appearance.Options.UseFont = true;
               this.btnXuat.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
               this.btnXuat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXuat.ImageOptions.Image")));
               this.btnXuat.Location = new System.Drawing.Point(1041, 527);
               this.btnXuat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.btnXuat.Name = "btnXuat";
               this.btnXuat.Size = new System.Drawing.Size(572, 53);
               this.btnXuat.TabIndex = 82;
               this.btnXuat.Text = "Xuất ra file excel";
               this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
               // 
               // FrmKhenThuongKiLuat
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(1661, 652);
               this.Controls.Add(this.btnXuat);
               this.Controls.Add(this.dgrKTKL);
               this.Controls.Add(this.btnDong);
               this.Controls.Add(this.btnSua);
               this.Controls.Add(this.label3);
               this.Controls.Add(this.btnThem);
               this.Controls.Add(this.cboNhanVien);
               this.Controls.Add(this.groupBox1);
               this.Controls.Add(this.btnXoa);
               this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
               this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.Name = "FrmKhenThuongKiLuat";
               this.Text = "FrmKhenThuongKiLuat";
               ((System.ComponentModel.ISupportInitialize)(this.dgrKTKL)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.grvKTKL)).EndInit();
               this.groupBox1.ResumeLayout(false);
               this.groupBox1.PerformLayout();
               ((System.ComponentModel.ISupportInitialize)(this.dtpThoiGian.Properties.CalendarTimeProperties)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.dtpThoiGian.Properties)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboNhanVien;
        private DevExpress.XtraGrid.GridControl dgrKTKL;
        private DevExpress.XtraGrid.Views.Grid.GridView grvKTKL;
        private DevExpress.XtraEditors.SimpleButton btnDong;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private System.Windows.Forms.TextBox txbNoiDung;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboKTKL;
        private DevExpress.XtraEditors.DateEdit dtpThoiGian;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton btnXuat;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;

    }
}