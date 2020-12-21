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
            this.txbSoTien = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnXuat = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
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
            this.cboNhanVien.Location = new System.Drawing.Point(181, 39);
            this.cboNhanVien.Name = "cboNhanVien";
            this.cboNhanVien.Size = new System.Drawing.Size(197, 21);
            this.cboNhanVien.TabIndex = 18;
            // 
            // dtpNgayNop
            // 
            this.dtpNgayNop.EditValue = new System.DateTime(2017, 7, 3, 22, 29, 3, 891);
            this.dtpNgayNop.Location = new System.Drawing.Point(181, 141);
            this.dtpNgayNop.Name = "dtpNgayNop";
            this.dtpNgayNop.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.dtpNgayNop.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpNgayNop.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpNgayNop.Size = new System.Drawing.Size(132, 22);
            this.dtpNgayNop.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Số tiền";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nhân viên";
            // 
            // dgrBaoHiemXH
            // 
            gridLevelNode1.RelationName = "Level1";
            this.dgrBaoHiemXH.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.dgrBaoHiemXH.Location = new System.Drawing.Point(15, 34);
            this.dgrBaoHiemXH.MainView = this.grvBaoHiemXH;
            this.dgrBaoHiemXH.Name = "dgrBaoHiemXH";
            this.dgrBaoHiemXH.Size = new System.Drawing.Size(678, 479);
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
            this.grvBaoHiemXH.GridControl = this.dgrBaoHiemXH;
            this.grvBaoHiemXH.Name = "grvBaoHiemXH";
            this.grvBaoHiemXH.OptionsBehavior.ReadOnly = true;
            this.grvBaoHiemXH.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.grvBaoHiemXH.PaintStyleName = "Flat";
            this.grvBaoHiemXH.RowHeight = 30;
            // 
            // BAOHIEMXAHOIID
            // 
            this.BAOHIEMXAHOIID.Caption = "Mã bảo hiểm xã hội";
            this.BAOHIEMXAHOIID.FieldName = "BAOHIEMXAHOIID";
            this.BAOHIEMXAHOIID.Name = "BAOHIEMXAHOIID";
            this.BAOHIEMXAHOIID.Visible = true;
            this.BAOHIEMXAHOIID.VisibleIndex = 0;
            this.BAOHIEMXAHOIID.Width = 126;
            // 
            // NHANVIENID
            // 
            this.NHANVIENID.Caption = "Nhân viên";
            this.NHANVIENID.FieldName = "HOTEN";
            this.NHANVIENID.Name = "NHANVIENID";
            this.NHANVIENID.Visible = true;
            this.NHANVIENID.VisibleIndex = 1;
            this.NHANVIENID.Width = 177;
            // 
            // SOTIEN
            // 
            this.SOTIEN.Caption = "Số tiền";
            this.SOTIEN.FieldName = "SOTIEN";
            this.SOTIEN.Name = "SOTIEN";
            this.SOTIEN.Visible = true;
            this.SOTIEN.VisibleIndex = 2;
            this.SOTIEN.Width = 177;
            // 
            // NGAYNOP
            // 
            this.NGAYNOP.Caption = "Ngày nộp";
            this.NGAYNOP.FieldName = "NGAYNOP";
            this.NGAYNOP.Name = "NGAYNOP";
            this.NGAYNOP.Visible = true;
            this.NGAYNOP.VisibleIndex = 3;
            this.NGAYNOP.Width = 181;
            // 
            // txbSoTien
            // 
            this.txbSoTien.Location = new System.Drawing.Point(181, 90);
            this.txbSoTien.Name = "txbSoTien";
            this.txbSoTien.Size = new System.Drawing.Size(245, 20);
            this.txbSoTien.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ngày nộp";
            // 
            // btnSua
            // 
            this.btnSua.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.Location = new System.Drawing.Point(980, 372);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(252, 43);
            this.btnSua.TabIndex = 27;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Location = new System.Drawing.Point(722, 372);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(252, 43);
            this.btnThem.TabIndex = 26;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(722, 421);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(510, 43);
            this.btnXoa.TabIndex = 25;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnXuat
            // 
            this.btnXuat.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnXuat.Image = ((System.Drawing.Image)(resources.GetObject("btnXuat.Image")));
            this.btnXuat.Location = new System.Drawing.Point(722, 470);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(510, 43);
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
            this.groupBox1.Location = new System.Drawing.Point(722, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(510, 215);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin bảo hiểm xã hội";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Danh sách bảo hiểm xã hội";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "gridColumn1";
            this.gridColumn1.FieldName = "NHANVIENID";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // FrmBaoHiemXaHoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 530);
            this.Controls.Add(this.dgrBaoHiemXH);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnXuat);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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