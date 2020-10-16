namespace QuanLyNhanSu.GUI
{
    partial class FrmChamCong
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
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChamCong));
               this.dgrChamCong = new DevExpress.XtraGrid.GridControl();
               this.grvChamCong = new DevExpress.XtraGrid.Views.Grid.GridView();
               this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
               this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
               this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
               this.groupBox1 = new System.Windows.Forms.GroupBox();
               this.cboLoai = new System.Windows.Forms.ComboBox();
               this.dtpNgay = new DevExpress.XtraEditors.DateEdit();
               this.label5 = new System.Windows.Forms.Label();
               this.label2 = new System.Windows.Forms.Label();
               this.label3 = new System.Windows.Forms.Label();
               this.btnSua = new DevExpress.XtraEditors.SimpleButton();
               this.btnThem = new DevExpress.XtraEditors.SimpleButton();
               this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
               this.btnDong = new DevExpress.XtraEditors.SimpleButton();
               this.groupBox2 = new System.Windows.Forms.GroupBox();
               this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
               this.cboThang = new System.Windows.Forms.ComboBox();
               this.cboNhanVien = new System.Windows.Forms.ComboBox();
               this.label4 = new System.Windows.Forms.Label();
               this.label1 = new System.Windows.Forms.Label();
               ((System.ComponentModel.ISupportInitialize)(this.dgrChamCong)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.grvChamCong)).BeginInit();
               this.groupBox1.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.dtpNgay.Properties.CalendarTimeProperties)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.dtpNgay.Properties)).BeginInit();
               this.groupBox2.SuspendLayout();
               this.SuspendLayout();
               // 
               // dgrChamCong
               // 
               this.dgrChamCong.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.dgrChamCong.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               gridLevelNode1.RelationName = "Level1";
               this.dgrChamCong.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
               this.dgrChamCong.Location = new System.Drawing.Point(21, 175);
               this.dgrChamCong.MainView = this.grvChamCong;
               this.dgrChamCong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.dgrChamCong.Name = "dgrChamCong";
               this.dgrChamCong.Size = new System.Drawing.Size(904, 462);
               this.dgrChamCong.TabIndex = 16;
               this.dgrChamCong.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvChamCong});
               // 
               // grvChamCong
               // 
               this.grvChamCong.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn3,
            this.gridColumn4});
               this.grvChamCong.DetailHeight = 431;
               this.grvChamCong.GridControl = this.dgrChamCong;
               this.grvChamCong.Name = "grvChamCong";
               this.grvChamCong.OptionsView.ShowGroupPanel = false;
               this.grvChamCong.PaintStyleName = "Flat";
               this.grvChamCong.RowHeight = 37;
               // 
               // gridColumn1
               // 
               this.gridColumn1.Caption = "Mã chấm công";
               this.gridColumn1.FieldName = "CHAMCONGID";
               this.gridColumn1.MinWidth = 27;
               this.gridColumn1.Name = "gridColumn1";
               this.gridColumn1.Visible = true;
               this.gridColumn1.VisibleIndex = 0;
               this.gridColumn1.Width = 100;
               // 
               // gridColumn3
               // 
               this.gridColumn3.Caption = "Ngày";
               this.gridColumn3.FieldName = "NGAY";
               this.gridColumn3.MinWidth = 27;
               this.gridColumn3.Name = "gridColumn3";
               this.gridColumn3.Visible = true;
               this.gridColumn3.VisibleIndex = 1;
               this.gridColumn3.Width = 100;
               // 
               // gridColumn4
               // 
               this.gridColumn4.Caption = "Loại";
               this.gridColumn4.FieldName = "LOAI";
               this.gridColumn4.MinWidth = 27;
               this.gridColumn4.Name = "gridColumn4";
               this.gridColumn4.Visible = true;
               this.gridColumn4.VisibleIndex = 2;
               this.gridColumn4.Width = 100;
               // 
               // groupBox1
               // 
               this.groupBox1.BackColor = System.Drawing.Color.White;
               this.groupBox1.Controls.Add(this.cboLoai);
               this.groupBox1.Controls.Add(this.dtpNgay);
               this.groupBox1.Controls.Add(this.label5);
               this.groupBox1.Controls.Add(this.label2);
               this.groupBox1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.groupBox1.Location = new System.Drawing.Point(964, 234);
               this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.groupBox1.Name = "groupBox1";
               this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.groupBox1.Size = new System.Drawing.Size(680, 201);
               this.groupBox1.TabIndex = 17;
               this.groupBox1.TabStop = false;
               this.groupBox1.Text = "Thống tin chấm công";
               // 
               // cboLoai
               // 
               this.cboLoai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
               this.cboLoai.FormattingEnabled = true;
               this.cboLoai.Items.AddRange(new object[] {
            "Ngày làm bình thường",
            "Ngày trực"});
               this.cboLoai.Location = new System.Drawing.Point(253, 123);
               this.cboLoai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.cboLoai.Name = "cboLoai";
               this.cboLoai.Size = new System.Drawing.Size(265, 24);
               this.cboLoai.TabIndex = 3;
               // 
               // dtpNgay
               // 
               this.dtpNgay.EditValue = new System.DateTime(2017, 7, 3, 22, 33, 16, 549);
               this.dtpNgay.Location = new System.Drawing.Point(253, 55);
               this.dtpNgay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.dtpNgay.Name = "dtpNgay";
               this.dtpNgay.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
               this.dtpNgay.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
               this.dtpNgay.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
               this.dtpNgay.Size = new System.Drawing.Size(267, 24);
               this.dtpNgay.TabIndex = 2;
               // 
               // label5
               // 
               this.label5.AutoSize = true;
               this.label5.Location = new System.Drawing.Point(153, 127);
               this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.label5.Name = "label5";
               this.label5.Size = new System.Drawing.Size(32, 17);
               this.label5.TabIndex = 1;
               this.label5.Text = "Loại";
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.Location = new System.Drawing.Point(153, 59);
               this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(40, 17);
               this.label2.TabIndex = 0;
               this.label2.Text = "Ngày";
               // 
               // label3
               // 
               this.label3.AutoSize = true;
               this.label3.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label3.Location = new System.Drawing.Point(17, 155);
               this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.label3.Name = "label3";
               this.label3.Size = new System.Drawing.Size(144, 17);
               this.label3.TabIndex = 22;
               this.label3.Text = "Danh sách phòng ban";
               // 
               // btnSua
               // 
               this.btnSua.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnSua.Appearance.Options.UseFont = true;
               this.btnSua.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
               this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
               this.btnSua.Location = new System.Drawing.Point(964, 523);
               this.btnSua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.btnSua.Name = "btnSua";
               this.btnSua.Size = new System.Drawing.Size(336, 53);
               this.btnSua.TabIndex = 21;
               this.btnSua.Text = "Sửa";
               this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
               // 
               // btnThem
               // 
               this.btnThem.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnThem.Appearance.Options.UseFont = true;
               this.btnThem.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
               this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
               this.btnThem.Location = new System.Drawing.Point(964, 463);
               this.btnThem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.btnThem.Name = "btnThem";
               this.btnThem.Size = new System.Drawing.Size(680, 53);
               this.btnThem.TabIndex = 20;
               this.btnThem.Text = "Thêm";
               this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
               // 
               // btnXoa
               // 
               this.btnXoa.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnXoa.Appearance.Options.UseFont = true;
               this.btnXoa.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
               this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
               this.btnXoa.Location = new System.Drawing.Point(1308, 523);
               this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.btnXoa.Name = "btnXoa";
               this.btnXoa.Size = new System.Drawing.Size(336, 53);
               this.btnXoa.TabIndex = 19;
               this.btnXoa.Text = "Xóa";
               this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
               // 
               // btnDong
               // 
               this.btnDong.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnDong.Appearance.Options.UseFont = true;
               this.btnDong.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
               this.btnDong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.ImageOptions.Image")));
               this.btnDong.Location = new System.Drawing.Point(964, 583);
               this.btnDong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.btnDong.Name = "btnDong";
               this.btnDong.Size = new System.Drawing.Size(680, 53);
               this.btnDong.TabIndex = 18;
               this.btnDong.Text = "Đóng chức năng";
               this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
               // 
               // groupBox2
               // 
               this.groupBox2.Controls.Add(this.simpleButton5);
               this.groupBox2.Controls.Add(this.cboThang);
               this.groupBox2.Controls.Add(this.cboNhanVien);
               this.groupBox2.Controls.Add(this.label4);
               this.groupBox2.Controls.Add(this.label1);
               this.groupBox2.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.groupBox2.Location = new System.Drawing.Point(21, 16);
               this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.groupBox2.Name = "groupBox2";
               this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.groupBox2.Size = new System.Drawing.Size(1623, 123);
               this.groupBox2.TabIndex = 23;
               this.groupBox2.TabStop = false;
               this.groupBox2.Text = "Chấm công";
               // 
               // simpleButton5
               // 
               this.simpleButton5.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
               this.simpleButton5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton5.ImageOptions.Image")));
               this.simpleButton5.Location = new System.Drawing.Point(1283, 52);
               this.simpleButton5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.simpleButton5.Name = "simpleButton5";
               this.simpleButton5.Size = new System.Drawing.Size(267, 42);
               this.simpleButton5.TabIndex = 13;
               this.simpleButton5.Text = "Hiển thị danh sách chấm công";
               this.simpleButton5.Click += new System.EventHandler(this.simpleButton5_Click);
               // 
               // cboThang
               // 
               this.cboThang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
               this.cboThang.FormattingEnabled = true;
               this.cboThang.Items.AddRange(new object[] {
            "Tháng 1",
            "Tháng 2",
            "Tháng 3",
            "Tháng 4",
            "Tháng 5",
            "Tháng 6",
            "Tháng 7",
            "Tháng 8",
            "Tháng 9",
            "Tháng 10",
            "Tháng 11",
            "Tháng 12"});
               this.cboThang.Location = new System.Drawing.Point(711, 60);
               this.cboThang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.cboThang.Name = "cboThang";
               this.cboThang.Size = new System.Drawing.Size(396, 24);
               this.cboThang.TabIndex = 3;
               // 
               // cboNhanVien
               // 
               this.cboNhanVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
               this.cboNhanVien.FormattingEnabled = true;
               this.cboNhanVien.Location = new System.Drawing.Point(256, 60);
               this.cboNhanVien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.cboNhanVien.Name = "cboNhanVien";
               this.cboNhanVien.Size = new System.Drawing.Size(328, 24);
               this.cboNhanVien.TabIndex = 2;
               this.cboNhanVien.SelectedValueChanged += new System.EventHandler(this.cboNhanVien_SelectedValueChanged);
               // 
               // label4
               // 
               this.label4.AutoSize = true;
               this.label4.Location = new System.Drawing.Point(652, 64);
               this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.label4.Name = "label4";
               this.label4.Size = new System.Drawing.Size(47, 17);
               this.label4.TabIndex = 1;
               this.label4.Text = "Tháng";
               // 
               // label1
               // 
               this.label1.AutoSize = true;
               this.label1.Location = new System.Drawing.Point(159, 64);
               this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.label1.Name = "label1";
               this.label1.Size = new System.Drawing.Size(69, 17);
               this.label1.TabIndex = 0;
               this.label1.Text = "Nhân viên";
               // 
               // FrmChamCong
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(1661, 652);
               this.Controls.Add(this.groupBox2);
               this.Controls.Add(this.dgrChamCong);
               this.Controls.Add(this.groupBox1);
               this.Controls.Add(this.label3);
               this.Controls.Add(this.btnSua);
               this.Controls.Add(this.btnThem);
               this.Controls.Add(this.btnXoa);
               this.Controls.Add(this.btnDong);
               this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
               this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.Name = "FrmChamCong";
               this.Text = "FrmChamCong";
               ((System.ComponentModel.ISupportInitialize)(this.dgrChamCong)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.grvChamCong)).EndInit();
               this.groupBox1.ResumeLayout(false);
               this.groupBox1.PerformLayout();
               ((System.ComponentModel.ISupportInitialize)(this.dtpNgay.Properties.CalendarTimeProperties)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.dtpNgay.Properties)).EndInit();
               this.groupBox2.ResumeLayout(false);
               this.groupBox2.PerformLayout();
               this.ResumeLayout(false);
               this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dgrChamCong;
        private DevExpress.XtraGrid.Views.Grid.GridView grvChamCong;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnDong;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboThang;
        private System.Windows.Forms.ComboBox cboNhanVien;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboLoai;
        private DevExpress.XtraEditors.DateEdit dtpNgay;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;

    }
}