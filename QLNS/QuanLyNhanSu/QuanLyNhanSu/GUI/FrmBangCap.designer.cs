namespace QuanLyNhanSu.GUI
{
    partial class FrmBangCap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBangCap));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.dtpThoiGian = new DevExpress.XtraEditors.DateEdit();
            this.cboBangCap = new System.Windows.Forms.ComboBox();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txbTrinhDoHocvan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbBangCap = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.dgrBangCap = new DevExpress.XtraGrid.GridControl();
            this.grvBangCap = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.btnXuat = new DevExpress.XtraEditors.SimpleButton();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtpThoiGian.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpThoiGian.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrBangCap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvBangCap)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpThoiGian
            // 
            this.dtpThoiGian.EditValue = new System.DateTime(2017, 7, 3, 22, 25, 44, 565);
            this.dtpThoiGian.Location = new System.Drawing.Point(180, 93);
            this.dtpThoiGian.Name = "dtpThoiGian";
            this.dtpThoiGian.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.dtpThoiGian.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpThoiGian.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtpThoiGian.Size = new System.Drawing.Size(164, 22);
            this.dtpThoiGian.TabIndex = 17;
            // 
            // cboBangCap
            // 
            this.cboBangCap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBangCap.FormattingEnabled = true;
            this.cboBangCap.Location = new System.Drawing.Point(219, 16);
            this.cboBangCap.Name = "cboBangCap";
            this.cboBangCap.Size = new System.Drawing.Size(197, 21);
            this.cboBangCap.TabIndex = 43;
            this.cboBangCap.SelectedValueChanged += new System.EventHandler(this.cboBangCap_SelectedValueChanged);
            // 
            // btnThem
            // 
            this.btnThem.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Location = new System.Drawing.Point(722, 324);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(252, 43);
            this.btnThem.TabIndex = 48;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.txbTrinhDoHocvan);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txbBangCap);
            this.groupBox1.Controls.Add(this.dtpThoiGian);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(722, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(510, 256);
            this.groupBox1.TabIndex = 45;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chi tiết quá trình bằng cấp";
            // 
            // txbTrinhDoHocvan
            // 
            this.txbTrinhDoHocvan.Location = new System.Drawing.Point(180, 42);
            this.txbTrinhDoHocvan.Name = "txbTrinhDoHocvan";
            this.txbTrinhDoHocvan.Size = new System.Drawing.Size(275, 20);
            this.txbTrinhDoHocvan.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Nội dung bằng cấp";
            // 
            // txbBangCap
            // 
            this.txbBangCap.Location = new System.Drawing.Point(180, 145);
            this.txbBangCap.Multiline = true;
            this.txbBangCap.Name = "txbBangCap";
            this.txbBangCap.Size = new System.Drawing.Size(275, 79);
            this.txbBangCap.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Trình độ học vấn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Thời gian";
            // 
            // btnSua
            // 
            this.btnSua.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.Location = new System.Drawing.Point(980, 324);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(252, 43);
            this.btnSua.TabIndex = 49;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // dgrBangCap
            // 
            gridLevelNode1.RelationName = "Level1";
            this.dgrBangCap.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.dgrBangCap.Location = new System.Drawing.Point(15, 52);
            this.dgrBangCap.MainView = this.grvBangCap;
            this.dgrBangCap.Name = "dgrBangCap";
            this.dgrBangCap.Size = new System.Drawing.Size(678, 462);
            this.dgrBangCap.TabIndex = 44;
            this.dgrBangCap.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvBangCap});
            // 
            // grvBangCap
            // 
            this.grvBangCap.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.grvBangCap.GridControl = this.dgrBangCap;
            this.grvBangCap.Name = "grvBangCap";
            this.grvBangCap.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Default;
            this.grvBangCap.PaintStyleName = "Flat";
            this.grvBangCap.RowHeight = 30;
            // 
            // btnXoa
            // 
            this.btnXoa.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(722, 373);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(510, 43);
            this.btnXoa.TabIndex = 47;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(722, 471);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(510, 43);
            this.simpleButton1.TabIndex = 46;
            this.simpleButton1.Text = "Đóng chức năng";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 13);
            this.label3.TabIndex = 50;
            this.label3.Text = "Danh sách bằng cấp của nhân viên";
            // 
            // btnXuat
            // 
            this.btnXuat.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
            this.btnXuat.Image = ((System.Drawing.Image)(resources.GetObject("btnXuat.Image")));
            this.btnXuat.Location = new System.Drawing.Point(722, 422);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Size = new System.Drawing.Size(510, 43);
            this.btnXuat.TabIndex = 83;
            this.btnXuat.Text = "Xuất ra file excel";
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Mã bằng";
            this.gridColumn1.FieldName = "BANGCAPID";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Trình độ học vấn";
            this.gridColumn2.FieldName = "TRINHDOHOCVAN";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Thời gian";
            this.gridColumn3.FieldName = "THOIGIAN";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Chi tiết";
            this.gridColumn4.FieldName = "CHITIETBANGCAP";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // FrmBangCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1246, 530);
            this.Controls.Add(this.btnXuat);
            this.Controls.Add(this.cboBangCap);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.dgrBangCap);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBangCap";
            this.Text = "FrmBangCap";
            ((System.ComponentModel.ISupportInitialize)(this.dtpThoiGian.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtpThoiGian.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrBangCap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvBangCap)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.DateEdit dtpThoiGian;
        private System.Windows.Forms.ComboBox cboBangCap;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbBangCap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraGrid.GridControl dgrBangCap;
        private DevExpress.XtraGrid.Views.Grid.GridView grvBangCap;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbTrinhDoHocvan;
        private DevExpress.XtraEditors.SimpleButton btnXuat;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;

    }
}