namespace QuanLyNhanSu.GUI
{
    partial class FrmBaoHiemXaHoi
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
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBaoHiemXaHoi));
               this.cboNhanVien = new System.Windows.Forms.ComboBox();
               this.dtpNgayNop = new DevExpress.XtraEditors.DateEdit();
               this.label4 = new System.Windows.Forms.Label();
               this.label1 = new System.Windows.Forms.Label();
               this.dgrBaoHiemXH = new DevExpress.XtraGrid.GridControl();
               this.grvBaoHiemXH = new DevExpress.XtraGrid.Views.Grid.GridView();
               this.BAOHIEMXAHOIID = new DevExpress.XtraGrid.Columns.GridColumn();
               this.NHANVIENID = new DevExpress.XtraGrid.Columns.GridColumn();
               this.SOTIEN = new DevExpress.XtraGrid.Columns.GridColumn();
               this.NGAYNOP = new DevExpress.XtraGrid.Columns.GridColumn();
               this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
               this.txbSoTien = new System.Windows.Forms.TextBox();
               this.label2 = new System.Windows.Forms.Label();
               this.btnSua = new DevExpress.XtraEditors.SimpleButton();
               this.btnThem = new DevExpress.XtraEditors.SimpleButton();
               this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
               this.btnXuat = new DevExpress.XtraEditors.SimpleButton();
               this.groupBox1 = new System.Windows.Forms.GroupBox();
               this.label3 = new System.Windows.Forms.Label();
               ((System.ComponentModel.ISupportInitialize)(this.dtpNgayNop.Properties.CalendarTimeProperties)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.dtpNgayNop.Properties)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.dgrBaoHiemXH)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.grvBaoHiemXH)).BeginInit();
               this.groupBox1.SuspendLayout();
               this.SuspendLayout();
               // 
               // cboNhanVien
               // 
               this.cboNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
               this.cboNhanVien.FormattingEnabled = true;
               this.cboNhanVien.Location = new System.Drawing.Point(241, 48);
               this.cboNhanVien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.cboNhanVien.Name = "cboNhanVien";
               this.cboNhanVien.Size = new System.Drawing.Size(261, 24);
               this.cboNhanVien.TabIndex = 18;
               // 
               // dtpNgayNop
               // 
               this.dtpNgayNop.EditValue = new System.DateTime(2017, 7, 3, 22, 29, 3, 891);
               this.dtpNgayNop.Location = new System.Drawing.Point(241, 174);
               this.dtpNgayNop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.dtpNgayNop.Name = "dtpNgayNop";
               this.dtpNgayNop.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
               this.dtpNgayNop.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
               this.dtpNgayNop.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
               this.dtpNgayNop.Size = new System.Drawing.Size(176, 24);
               this.dtpNgayNop.TabIndex = 17;
               // 
               // label4
               // 
               this.label4.AutoSize = true;
               this.label4.Location = new System.Drawing.Point(104, 114);
               this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.label4.Name = "label4";
               this.label4.Size = new System.Drawing.Size(50, 17);
               this.label4.TabIndex = 15;
               this.label4.Text = "Số tiền";
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Location = new System.Drawing.Point(104, 52);
               this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(69, 17);
               this.label1.TabIndex = 14;
               this.label1.Text = "Nhân viên";
               // 
               // dgrBaoHiemXH
               // 
               this.dgrBaoHiemXH.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.dgrBaoHiemXH.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               gridLevelNode1.RelationName = "Level1";
               this.dgrBaoHiemXH.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
               this.dgrBaoHiemXH.Location = new System.Drawing.Point(20, 42);
               this.dgrBaoHiemXH.MainView = this.grvBaoHiemXH;
               this.dgrBaoHiemXH.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.dgrBaoHiemXH.Name = "dgrBaoHiemXH";
               this.dgrBaoHiemXH.Size = new System.Drawing.Size(904, 590);
               this.dgrBaoHiemXH.TabIndex = 22;
               this.dgrBaoHiemXH.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvBaoHiemXH});
               // 
               // grvBaoHiemXH
               // 
               this.grvBaoHiemXH.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.BAOHIEMXAHOIID,
            this.NHANVIENID,
            this.SOTIEN,
            this.NGAYNOP,
            this.gridColumn1});
               this.grvBaoHiemXH.DetailHeight = 431;
               this.grvBaoHiemXH.GridControl = this.dgrBaoHiemXH;
               this.grvBaoHiemXH.Name = "grvBaoHiemXH";
               this.grvBaoHiemXH.OptionsBehavior.ReadOnly = true;
               this.grvBaoHiemXH.OptionsView.ShowGroupPanel = false;
               this.grvBaoHiemXH.PaintStyleName = "Flat";
               this.grvBaoHiemXH.RowHeight = 37;
               // 
               // BAOHIEMXAHOIID
               // 
               this.BAOHIEMXAHOIID.Caption = "Mã bảo hiểm xã hội";
               this.BAOHIEMXAHOIID.FieldName = "BAOHIEMXAHOIID";
               this.BAOHIEMXAHOIID.MinWidth = 27;
               this.BAOHIEMXAHOIID.Name = "BAOHIEMXAHOIID";
               this.BAOHIEMXAHOIID.Visible = true;
               this.BAOHIEMXAHOIID.VisibleIndex = 0;
               this.BAOHIEMXAHOIID.Width = 168;
               // 
               // NHANVIENID
               // 
               this.NHANVIENID.Caption = "Nhân viên";
               this.NHANVIENID.FieldName = "HOTEN";
               this.NHANVIENID.MinWidth = 27;
               this.NHANVIENID.Name = "NHANVIENID";
               this.NHANVIENID.Visible = true;
               this.NHANVIENID.VisibleIndex = 1;
               this.NHANVIENID.Width = 236;
               // 
               // SOTIEN
               // 
               this.SOTIEN.Caption = "Số tiền";
               this.SOTIEN.FieldName = "SOTIEN";
               this.SOTIEN.MinWidth = 27;
               this.SOTIEN.Name = "SOTIEN";
               this.SOTIEN.Visible = true;
               this.SOTIEN.VisibleIndex = 2;
               this.SOTIEN.Width = 236;
               // 
               // NGAYNOP
               // 
               this.NGAYNOP.Caption = "Ngày nộp";
               this.NGAYNOP.FieldName = "NGAYNOP";
               this.NGAYNOP.MinWidth = 27;
               this.NGAYNOP.Name = "NGAYNOP";
               this.NGAYNOP.Visible = true;
               this.NGAYNOP.VisibleIndex = 3;
               this.NGAYNOP.Width = 241;
               // 
               // gridColumn1
               // 
               this.gridColumn1.Caption = "gridColumn1";
               this.gridColumn1.FieldName = "NHANVIENID";
               this.gridColumn1.MinWidth = 27;
               this.gridColumn1.Name = "gridColumn1";
               this.gridColumn1.Width = 100;
               // 
               // txbSoTien
               // 
               this.txbSoTien.Location = new System.Drawing.Point(241, 111);
               this.txbSoTien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.txbSoTien.Name = "txbSoTien";
               this.txbSoTien.Size = new System.Drawing.Size(325, 23);
               this.txbSoTien.TabIndex = 13;
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.Location = new System.Drawing.Point(104, 178);
               this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(68, 17);
               this.label2.TabIndex = 0;
               this.label2.Text = "Ngày nộp";
               // 
               // btnSua
               // 
               this.btnSua.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnSua.Appearance.Options.UseFont = true;
               this.btnSua.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
               this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
               this.btnSua.Location = new System.Drawing.Point(1307, 458);
               this.btnSua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.btnSua.Name = "btnSua";
               this.btnSua.Size = new System.Drawing.Size(336, 53);
               this.btnSua.TabIndex = 27;
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
               this.btnThem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.btnThem.Name = "btnThem";
               this.btnThem.Size = new System.Drawing.Size(336, 53);
               this.btnThem.TabIndex = 26;
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
               this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.btnXoa.Name = "btnXoa";
               this.btnXoa.Size = new System.Drawing.Size(680, 53);
               this.btnXoa.TabIndex = 25;
               this.btnXoa.Text = "Xóa";
               this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
               // 
               // btnXuat
               // 
               this.btnXuat.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnXuat.Appearance.Options.UseFont = true;
               this.btnXuat.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
               this.btnXuat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXuat.ImageOptions.Image")));
               this.btnXuat.Location = new System.Drawing.Point(963, 578);
               this.btnXuat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.btnXuat.Name = "btnXuat";
               this.btnXuat.Size = new System.Drawing.Size(680, 53);
               this.btnXuat.TabIndex = 24;
               this.btnXuat.Text = "Đóng chức năng";
               this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
               // 
               // groupBox1
               // 
               this.groupBox1.BackColor = System.Drawing.Color.White;
               this.groupBox1.Controls.Add(this.cboNhanVien);
               this.groupBox1.Controls.Add(this.dtpNgayNop);
               this.groupBox1.Controls.Add(this.label4);
               this.groupBox1.Controls.Add(this.label1);
               this.groupBox1.Controls.Add(this.txbSoTien);
               this.groupBox1.Controls.Add(this.label2);
               this.groupBox1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.groupBox1.Location = new System.Drawing.Point(963, 106);
               this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.groupBox1.Name = "groupBox1";
               this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.groupBox1.Size = new System.Drawing.Size(680, 265);
               this.groupBox1.TabIndex = 23;
               this.groupBox1.TabStop = false;
               this.groupBox1.Text = "Thông tin bảo hiểm xã hội";
               // 
               // label3
               // 
               this.label3.AutoSize = true;
               this.label3.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label3.Location = new System.Drawing.Point(20, 22);
               this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.label3.Name = "label3";
               this.label3.Size = new System.Drawing.Size(174, 17);
               this.label3.TabIndex = 28;
               this.label3.Text = "Danh sách bảo hiểm xã hội";
               // 
               // FrmBaoHiemXaHoi
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(1661, 652);
               this.Controls.Add(this.dgrBaoHiemXH);
               this.Controls.Add(this.btnSua);
               this.Controls.Add(this.btnThem);
               this.Controls.Add(this.btnXoa);
               this.Controls.Add(this.btnXuat);
               this.Controls.Add(this.groupBox1);
               this.Controls.Add(this.label3);
               this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
               this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.Name = "FrmBaoHiemXaHoi";
               this.Text = "FrmBaoHiemXaHoi";
               ((System.ComponentModel.ISupportInitialize)(this.dtpNgayNop.Properties.CalendarTimeProperties)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.dtpNgayNop.Properties)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.dgrBaoHiemXH)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.grvBaoHiemXH)).EndInit();
               this.groupBox1.ResumeLayout(false);
               this.groupBox1.PerformLayout();
               this.ResumeLayout(false);
               this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboNhanVien;
        private DevExpress.XtraEditors.DateEdit dtpNgayNop;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraGrid.GridControl dgrBaoHiemXH;
        private DevExpress.XtraGrid.Views.Grid.GridView grvBaoHiemXH;
        private System.Windows.Forms.TextBox txbSoTien;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnXuat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraGrid.Columns.GridColumn BAOHIEMXAHOIID;
        private DevExpress.XtraGrid.Columns.GridColumn NHANVIENID;
        private DevExpress.XtraGrid.Columns.GridColumn SOTIEN;
        private DevExpress.XtraGrid.Columns.GridColumn NGAYNOP;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;

    }
}