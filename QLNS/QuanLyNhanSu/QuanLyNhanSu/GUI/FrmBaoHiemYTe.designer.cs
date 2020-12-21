namespace QuanLyNhanSu.GUI
{
    partial class FrmBaoHiemYTe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBaoHiemYTe));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            this.cboNhanVien = new System.Windows.Forms.ComboBox();
            this.dtpNgayNop = new DevExpress.XtraEditors.DateEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnXuat = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.grvBaoHiemYT = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.BAOHIEMYTEID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NHANVIENID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SOTHE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NGAYNOP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dgrBaoHiemYT = new DevExpress.XtraGrid.GridControl();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbSoThe = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayNop.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayNop.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvBaoHiemYT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrBaoHiemYT)).BeginInit();
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
            this.dtpNgayNop.EditValue = new System.DateTime(2017, 7, 3, 22, 31, 21, 436);
            this.dtpNgayNop.Location = new System.Drawing.Point(181, 103);
            this.dtpNgayNop.Name = "dtpNgayNop";
            this.dtpNgayNop.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.dtpNgayNop.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpNgayNop.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpNgayNop.Size = new System.Drawing.Size(132, 22);
            this.dtpNgayNop.TabIndex = 17;
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
            // btnXoa
            // 
            this.btnXoa.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(722, 421);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(510, 43);
            this.btnXoa.TabIndex = 32;
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
            this.btnXuat.TabIndex = 31;
            this.btnXuat.Text = "Đóng chức năng";
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "Danh sách bảo hiểm y tế";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 107);
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
            this.btnSua.TabIndex = 34;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // grvBaoHiemYT
            // 
            this.grvBaoHiemYT.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.BAOHIEMYTEID,
            this.NHANVIENID,
            this.SOTHE,
            this.NGAYNOP,
            this.gridColumn1});
            this.grvBaoHiemYT.GridControl = this.dgrBaoHiemYT;
            this.grvBaoHiemYT.Name = "grvBaoHiemYT";
            this.grvBaoHiemYT.OptionsBehavior.ReadOnly = true;
            this.grvBaoHiemYT.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.grvBaoHiemYT.PaintStyleName = "Flat";
            this.grvBaoHiemYT.RowHeight = 30;
            // 
            // BAOHIEMYTEID
            // 
            this.BAOHIEMYTEID.Caption = "Mã bảo hiểm y tế";
            this.BAOHIEMYTEID.FieldName = "BAOHIEMYTEID";
            this.BAOHIEMYTEID.Name = "BAOHIEMYTEID";
            this.BAOHIEMYTEID.Visible = true;
            this.BAOHIEMYTEID.VisibleIndex = 0;
            // 
            // NHANVIENID
            // 
            this.NHANVIENID.Caption = "Nhân viên";
            this.NHANVIENID.FieldName = "HOTEN";
            this.NHANVIENID.Name = "NHANVIENID";
            this.NHANVIENID.Visible = true;
            this.NHANVIENID.VisibleIndex = 1;
            // 
            // SOTHE
            // 
            this.SOTHE.Caption = "Số thẻ";
            this.SOTHE.FieldName = "SOTHE";
            this.SOTHE.Name = "SOTHE";
            this.SOTHE.Visible = true;
            this.SOTHE.VisibleIndex = 2;
            // 
            // NGAYNOP
            // 
            this.NGAYNOP.Caption = "Ngày nộp";
            this.NGAYNOP.FieldName = "NGAYNOP";
            this.NGAYNOP.Name = "NGAYNOP";
            this.NGAYNOP.Visible = true;
            this.NGAYNOP.VisibleIndex = 3;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "gridColumn1";
            this.gridColumn1.FieldName = "NHANVIENID";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsEditForm.Visible = DevExpress.Utils.DefaultBoolean.False;
            // 
            // dgrBaoHiemYT
            // 
            gridLevelNode2.RelationName = "Level1";
            this.dgrBaoHiemYT.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode2});
            this.dgrBaoHiemYT.Location = new System.Drawing.Point(15, 34);
            this.dgrBaoHiemYT.MainView = this.grvBaoHiemYT;
            this.dgrBaoHiemYT.Name = "dgrBaoHiemYT";
            this.dgrBaoHiemYT.Size = new System.Drawing.Size(678, 479);
            this.dgrBaoHiemYT.TabIndex = 29;
            this.dgrBaoHiemYT.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvBaoHiemYT});
            // 
            // btnThem
            // 
            this.btnThem.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Location = new System.Drawing.Point(722, 372);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(252, 43);
            this.btnThem.TabIndex = 33;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txbSoThe);
            this.groupBox1.Controls.Add(this.cboNhanVien);
            this.groupBox1.Controls.Add(this.dtpNgayNop);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(722, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(510, 256);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin bảo hiểm y tế";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(78, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Số thẻ";
            // 
            // txbSoThe
            // 
            this.txbSoThe.Location = new System.Drawing.Point(181, 167);
            this.txbSoThe.Name = "txbSoThe";
            this.txbSoThe.Size = new System.Drawing.Size(197, 20);
            this.txbSoThe.TabIndex = 19;
            // 
            // FrmBaoHiemYTe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 530);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnXuat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.dgrBaoHiemYT);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBaoHiemYTe";
            this.Text = "FrmBaoHiemYTe";
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayNop.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayNop.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvBaoHiemYT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgrBaoHiemYT)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboNhanVien;
        private DevExpress.XtraEditors.DateEdit dtpNgayNop;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnXuat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraGrid.Views.Grid.GridView grvBaoHiemYT;
        private DevExpress.XtraGrid.GridControl dgrBaoHiemYT;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbSoThe;
        private DevExpress.XtraGrid.Columns.GridColumn BAOHIEMYTEID;
        private DevExpress.XtraGrid.Columns.GridColumn NHANVIENID;
        private DevExpress.XtraGrid.Columns.GridColumn SOTHE;
        private DevExpress.XtraGrid.Columns.GridColumn NGAYNOP;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;

    }
}