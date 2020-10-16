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
               this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
               this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
               this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
               this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
               this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
               this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
               this.label3 = new System.Windows.Forms.Label();
               this.btnXuat = new DevExpress.XtraEditors.SimpleButton();
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
               this.dtpThoiGian.Location = new System.Drawing.Point(240, 114);
               this.dtpThoiGian.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.dtpThoiGian.Name = "dtpThoiGian";
               this.dtpThoiGian.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
               this.dtpThoiGian.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
               this.dtpThoiGian.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
               this.dtpThoiGian.Size = new System.Drawing.Size(219, 24);
               this.dtpThoiGian.TabIndex = 17;
               // 
               // cboBangCap
               // 
               this.cboBangCap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
               this.cboBangCap.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.cboBangCap.FormattingEnabled = true;
               this.cboBangCap.Location = new System.Drawing.Point(352, 16);
               this.cboBangCap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.cboBangCap.Name = "cboBangCap";
               this.cboBangCap.Size = new System.Drawing.Size(261, 24);
               this.cboBangCap.TabIndex = 43;
               this.cboBangCap.SelectedValueChanged += new System.EventHandler(this.cboBangCap_SelectedValueChanged);
               // 
               // btnThem
               // 
               this.btnThem.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnThem.Appearance.Options.UseFont = true;
               this.btnThem.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
               this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
               this.btnThem.Location = new System.Drawing.Point(963, 399);
               this.btnThem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.btnThem.Name = "btnThem";
               this.btnThem.Size = new System.Drawing.Size(336, 53);
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
               this.groupBox1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.groupBox1.Location = new System.Drawing.Point(963, 76);
               this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.groupBox1.Name = "groupBox1";
               this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.groupBox1.Size = new System.Drawing.Size(680, 315);
               this.groupBox1.TabIndex = 45;
               this.groupBox1.TabStop = false;
               this.groupBox1.Text = "Chi tiết quá trình bằng cấp";
               // 
               // txbTrinhDoHocvan
               // 
               this.txbTrinhDoHocvan.Location = new System.Drawing.Point(240, 52);
               this.txbTrinhDoHocvan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.txbTrinhDoHocvan.Name = "txbTrinhDoHocvan";
               this.txbTrinhDoHocvan.Size = new System.Drawing.Size(365, 23);
               this.txbTrinhDoHocvan.TabIndex = 21;
               // 
               // label5
               // 
               this.label5.AutoSize = true;
               this.label5.Location = new System.Drawing.Point(72, 182);
               this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.label5.Name = "label5";
               this.label5.Size = new System.Drawing.Size(124, 17);
               this.label5.TabIndex = 20;
               this.label5.Text = "Nội dung bằng cấp";
               // 
               // txbBangCap
               // 
               this.txbBangCap.Location = new System.Drawing.Point(240, 178);
               this.txbBangCap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.txbBangCap.Multiline = true;
               this.txbBangCap.Name = "txbBangCap";
               this.txbBangCap.Size = new System.Drawing.Size(365, 96);
               this.txbBangCap.TabIndex = 19;
               // 
               // label4
               // 
               this.label4.AutoSize = true;
               this.label4.Location = new System.Drawing.Point(72, 55);
               this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.label4.Name = "label4";
               this.label4.Size = new System.Drawing.Size(113, 17);
               this.label4.TabIndex = 15;
               this.label4.Text = "Trình độ học vấn";
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.Location = new System.Drawing.Point(72, 119);
               this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(63, 17);
               this.label2.TabIndex = 0;
               this.label2.Text = "Thời gian";
               // 
               // btnSua
               // 
               this.btnSua.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnSua.Appearance.Options.UseFont = true;
               this.btnSua.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
               this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
               this.btnSua.Location = new System.Drawing.Point(1307, 399);
               this.btnSua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.btnSua.Name = "btnSua";
               this.btnSua.Size = new System.Drawing.Size(336, 53);
               this.btnSua.TabIndex = 49;
               this.btnSua.Text = "Sửa";
               this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
               // 
               // dgrBangCap
               // 
               this.dgrBangCap.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.dgrBangCap.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               gridLevelNode1.RelationName = "Level1";
               this.dgrBangCap.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
               this.dgrBangCap.Location = new System.Drawing.Point(20, 64);
               this.dgrBangCap.MainView = this.grvBangCap;
               this.dgrBangCap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.dgrBangCap.Name = "dgrBangCap";
               this.dgrBangCap.Size = new System.Drawing.Size(904, 569);
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
               this.grvBangCap.DetailHeight = 431;
               this.grvBangCap.GridControl = this.dgrBangCap;
               this.grvBangCap.Name = "grvBangCap";
               this.grvBangCap.OptionsView.ShowGroupPanel = false;
               this.grvBangCap.PaintStyleName = "Flat";
               this.grvBangCap.RowHeight = 37;
               // 
               // gridColumn1
               // 
               this.gridColumn1.Caption = "Mã bằng";
               this.gridColumn1.FieldName = "BANGCAPID";
               this.gridColumn1.MinWidth = 27;
               this.gridColumn1.Name = "gridColumn1";
               this.gridColumn1.Visible = true;
               this.gridColumn1.VisibleIndex = 0;
               this.gridColumn1.Width = 100;
               // 
               // gridColumn2
               // 
               this.gridColumn2.Caption = "Trình độ học vấn";
               this.gridColumn2.FieldName = "TRINHDOHOCVAN";
               this.gridColumn2.MinWidth = 27;
               this.gridColumn2.Name = "gridColumn2";
               this.gridColumn2.Visible = true;
               this.gridColumn2.VisibleIndex = 1;
               this.gridColumn2.Width = 100;
               // 
               // gridColumn3
               // 
               this.gridColumn3.Caption = "Thời gian";
               this.gridColumn3.FieldName = "THOIGIAN";
               this.gridColumn3.MinWidth = 27;
               this.gridColumn3.Name = "gridColumn3";
               this.gridColumn3.Visible = true;
               this.gridColumn3.VisibleIndex = 2;
               this.gridColumn3.Width = 100;
               // 
               // gridColumn4
               // 
               this.gridColumn4.Caption = "Chi tiết";
               this.gridColumn4.FieldName = "CHITIETBANGCAP";
               this.gridColumn4.MinWidth = 27;
               this.gridColumn4.Name = "gridColumn4";
               this.gridColumn4.Visible = true;
               this.gridColumn4.VisibleIndex = 3;
               this.gridColumn4.Width = 100;
               // 
               // btnXoa
               // 
               this.btnXoa.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnXoa.Appearance.Options.UseFont = true;
               this.btnXoa.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
               this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
               this.btnXoa.Location = new System.Drawing.Point(963, 459);
               this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.btnXoa.Name = "btnXoa";
               this.btnXoa.Size = new System.Drawing.Size(680, 53);
               this.btnXoa.TabIndex = 47;
               this.btnXoa.Text = "Xóa";
               this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
               // 
               // simpleButton1
               // 
               this.simpleButton1.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.simpleButton1.Appearance.Options.UseFont = true;
               this.simpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
               this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
               this.simpleButton1.Location = new System.Drawing.Point(963, 580);
               this.simpleButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.simpleButton1.Name = "simpleButton1";
               this.simpleButton1.Size = new System.Drawing.Size(680, 53);
               this.simpleButton1.TabIndex = 46;
               this.simpleButton1.Text = "Đóng chức năng";
               this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
               // 
               // label3
               // 
               this.label3.AutoSize = true;
               this.label3.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label3.Location = new System.Drawing.Point(47, 23);
               this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.label3.Name = "label3";
               this.label3.Size = new System.Drawing.Size(224, 17);
               this.label3.TabIndex = 50;
               this.label3.Text = "Danh sách bằng cấp của nhân viên";
               // 
               // btnXuat
               // 
               this.btnXuat.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnXuat.Appearance.Options.UseFont = true;
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
               // FrmBangCap
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(1661, 652);
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
               this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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