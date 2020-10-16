namespace QuanLyNhanSu.GUI
{
    partial class FrmQuaTrinhHocTap
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
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuaTrinhHocTap));
               DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
               this.cboQuaTrinhHocTap = new System.Windows.Forms.ComboBox();
               this.btnThem = new DevExpress.XtraEditors.SimpleButton();
               this.groupBox1 = new System.Windows.Forms.GroupBox();
               this.dtpBatDau = new DevExpress.XtraEditors.DateEdit();
               this.label5 = new System.Windows.Forms.Label();
               this.txbNoiDung = new System.Windows.Forms.TextBox();
               this.dtpKetThuc = new DevExpress.XtraEditors.DateEdit();
               this.label4 = new System.Windows.Forms.Label();
               this.label2 = new System.Windows.Forms.Label();
               this.btnSua = new DevExpress.XtraEditors.SimpleButton();
               this.grvQuaTrinhhocTap = new DevExpress.XtraGrid.Views.Grid.GridView();
               this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
               this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
               this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
               this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
               this.dgrQuaTrinhHocTap = new DevExpress.XtraGrid.GridControl();
               this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
               this.btnDong = new DevExpress.XtraEditors.SimpleButton();
               this.label3 = new System.Windows.Forms.Label();
               this.groupBox1.SuspendLayout();
               ((System.ComponentModel.ISupportInitialize)(this.dtpBatDau.Properties.CalendarTimeProperties)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.dtpBatDau.Properties)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.dtpKetThuc.Properties.CalendarTimeProperties)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.dtpKetThuc.Properties)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.grvQuaTrinhhocTap)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.dgrQuaTrinhHocTap)).BeginInit();
               this.SuspendLayout();
               // 
               // cboQuaTrinhHocTap
               // 
               this.cboQuaTrinhHocTap.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
               this.cboQuaTrinhHocTap.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.cboQuaTrinhHocTap.FormattingEnabled = true;
               this.cboQuaTrinhHocTap.Location = new System.Drawing.Point(292, 20);
               this.cboQuaTrinhHocTap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.cboQuaTrinhHocTap.Name = "cboQuaTrinhHocTap";
               this.cboQuaTrinhHocTap.Size = new System.Drawing.Size(261, 24);
               this.cboQuaTrinhHocTap.TabIndex = 51;
               this.cboQuaTrinhHocTap.SelectedValueChanged += new System.EventHandler(this.cboQuaTrinhHocTap_SelectedValueChanged);
               // 
               // btnThem
               // 
               this.btnThem.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnThem.Appearance.Options.UseFont = true;
               this.btnThem.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
               this.btnThem.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.ImageOptions.Image")));
               this.btnThem.Location = new System.Drawing.Point(963, 459);
               this.btnThem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.btnThem.Name = "btnThem";
               this.btnThem.Size = new System.Drawing.Size(336, 53);
               this.btnThem.TabIndex = 56;
               this.btnThem.Text = "Thêm";
               this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
               // 
               // groupBox1
               // 
               this.groupBox1.BackColor = System.Drawing.Color.White;
               this.groupBox1.Controls.Add(this.dtpBatDau);
               this.groupBox1.Controls.Add(this.label5);
               this.groupBox1.Controls.Add(this.txbNoiDung);
               this.groupBox1.Controls.Add(this.dtpKetThuc);
               this.groupBox1.Controls.Add(this.label4);
               this.groupBox1.Controls.Add(this.label2);
               this.groupBox1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.groupBox1.Location = new System.Drawing.Point(963, 92);
               this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.groupBox1.Name = "groupBox1";
               this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.groupBox1.Size = new System.Drawing.Size(680, 315);
               this.groupBox1.TabIndex = 53;
               this.groupBox1.TabStop = false;
               this.groupBox1.Text = "Chi tiết quá trình học tập";
               // 
               // dtpBatDau
               // 
               this.dtpBatDau.EditValue = new System.DateTime(2017, 7, 3, 22, 51, 27, 727);
               this.dtpBatDau.Location = new System.Drawing.Point(240, 50);
               this.dtpBatDau.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.dtpBatDau.Name = "dtpBatDau";
               this.dtpBatDau.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
               this.dtpBatDau.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
               this.dtpBatDau.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
               this.dtpBatDau.Size = new System.Drawing.Size(219, 24);
               this.dtpBatDau.TabIndex = 21;
               // 
               // label5
               // 
               this.label5.AutoSize = true;
               this.label5.Location = new System.Drawing.Point(72, 182);
               this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.label5.Name = "label5";
               this.label5.Size = new System.Drawing.Size(114, 17);
               this.label5.TabIndex = 20;
               this.label5.Text = "Nội dung học tập";
               // 
               // txbNoiDung
               // 
               this.txbNoiDung.Location = new System.Drawing.Point(240, 178);
               this.txbNoiDung.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.txbNoiDung.Multiline = true;
               this.txbNoiDung.Name = "txbNoiDung";
               this.txbNoiDung.Size = new System.Drawing.Size(365, 96);
               this.txbNoiDung.TabIndex = 19;
               // 
               // dtpKetThuc
               // 
               this.dtpKetThuc.EditValue = new System.DateTime(2017, 7, 3, 22, 51, 2, 337);
               this.dtpKetThuc.Location = new System.Drawing.Point(240, 114);
               this.dtpKetThuc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.dtpKetThuc.Name = "dtpKetThuc";
               this.dtpKetThuc.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
               this.dtpKetThuc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
               this.dtpKetThuc.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
               this.dtpKetThuc.Size = new System.Drawing.Size(219, 24);
               this.dtpKetThuc.TabIndex = 17;
               // 
               // label4
               // 
               this.label4.AutoSize = true;
               this.label4.Location = new System.Drawing.Point(72, 55);
               this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.label4.Name = "label4";
               this.label4.Size = new System.Drawing.Size(114, 17);
               this.label4.TabIndex = 15;
               this.label4.Text = "Thời gian bắt đầu";
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.Location = new System.Drawing.Point(72, 119);
               this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(118, 17);
               this.label2.TabIndex = 0;
               this.label2.Text = "Thời gian kết thúc";
               // 
               // btnSua
               // 
               this.btnSua.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnSua.Appearance.Options.UseFont = true;
               this.btnSua.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
               this.btnSua.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.ImageOptions.Image")));
               this.btnSua.Location = new System.Drawing.Point(1307, 459);
               this.btnSua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.btnSua.Name = "btnSua";
               this.btnSua.Size = new System.Drawing.Size(336, 53);
               this.btnSua.TabIndex = 57;
               this.btnSua.Text = "Sửa";
               this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
               // 
               // grvQuaTrinhhocTap
               // 
               this.grvQuaTrinhhocTap.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
               this.grvQuaTrinhhocTap.DetailHeight = 431;
               this.grvQuaTrinhhocTap.GridControl = this.dgrQuaTrinhHocTap;
               this.grvQuaTrinhhocTap.Name = "grvQuaTrinhhocTap";
               this.grvQuaTrinhhocTap.OptionsView.ShowGroupPanel = false;
               this.grvQuaTrinhhocTap.PaintStyleName = "Flat";
               this.grvQuaTrinhhocTap.RowHeight = 37;
               // 
               // gridColumn1
               // 
               this.gridColumn1.Caption = "Mã quá trình học tập";
               this.gridColumn1.FieldName = "QUATRINHOCTAPID";
               this.gridColumn1.MinWidth = 27;
               this.gridColumn1.Name = "gridColumn1";
               this.gridColumn1.Visible = true;
               this.gridColumn1.VisibleIndex = 0;
               this.gridColumn1.Width = 100;
               // 
               // gridColumn2
               // 
               this.gridColumn2.Caption = "thời gian bắt đầu";
               this.gridColumn2.FieldName = "THOIGIANBATDAU";
               this.gridColumn2.MinWidth = 27;
               this.gridColumn2.Name = "gridColumn2";
               this.gridColumn2.Visible = true;
               this.gridColumn2.VisibleIndex = 1;
               this.gridColumn2.Width = 100;
               // 
               // gridColumn3
               // 
               this.gridColumn3.Caption = "Thời gian kết thúc";
               this.gridColumn3.FieldName = "THOIGIANKETTHUC";
               this.gridColumn3.MinWidth = 27;
               this.gridColumn3.Name = "gridColumn3";
               this.gridColumn3.Visible = true;
               this.gridColumn3.VisibleIndex = 2;
               this.gridColumn3.Width = 100;
               // 
               // gridColumn4
               // 
               this.gridColumn4.Caption = "Nội dung học tập";
               this.gridColumn4.FieldName = "NOIDUNGHOCTAP";
               this.gridColumn4.MinWidth = 27;
               this.gridColumn4.Name = "gridColumn4";
               this.gridColumn4.Visible = true;
               this.gridColumn4.VisibleIndex = 3;
               this.gridColumn4.Width = 100;
               // 
               // dgrQuaTrinhHocTap
               // 
               this.dgrQuaTrinhHocTap.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.dgrQuaTrinhHocTap.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               gridLevelNode1.RelationName = "Level1";
               this.dgrQuaTrinhHocTap.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
               this.dgrQuaTrinhHocTap.Location = new System.Drawing.Point(20, 64);
               this.dgrQuaTrinhHocTap.MainView = this.grvQuaTrinhhocTap;
               this.dgrQuaTrinhHocTap.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.dgrQuaTrinhHocTap.Name = "dgrQuaTrinhHocTap";
               this.dgrQuaTrinhHocTap.Size = new System.Drawing.Size(904, 569);
               this.dgrQuaTrinhHocTap.TabIndex = 52;
               this.dgrQuaTrinhHocTap.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvQuaTrinhhocTap});
               // 
               // btnXoa
               // 
               this.btnXoa.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnXoa.Appearance.Options.UseFont = true;
               this.btnXoa.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
               this.btnXoa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.ImageOptions.Image")));
               this.btnXoa.Location = new System.Drawing.Point(963, 519);
               this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.btnXoa.Name = "btnXoa";
               this.btnXoa.Size = new System.Drawing.Size(680, 53);
               this.btnXoa.TabIndex = 55;
               this.btnXoa.Text = "Xóa";
               this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
               // 
               // btnDong
               // 
               this.btnDong.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnDong.Appearance.Options.UseFont = true;
               this.btnDong.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
               this.btnDong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.ImageOptions.Image")));
               this.btnDong.Location = new System.Drawing.Point(963, 580);
               this.btnDong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.btnDong.Name = "btnDong";
               this.btnDong.Size = new System.Drawing.Size(680, 53);
               this.btnDong.TabIndex = 54;
               this.btnDong.Text = "Đóng chức năng";
               this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
               // 
               // label3
               // 
               this.label3.AutoSize = true;
               this.label3.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label3.Location = new System.Drawing.Point(47, 23);
               this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.label3.Name = "label3";
               this.label3.Size = new System.Drawing.Size(206, 17);
               this.label3.TabIndex = 58;
               this.label3.Text = "Quá trình học tập của nhân viên";
               // 
               // FrmQuaTrinhHocTap
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(1661, 652);
               this.Controls.Add(this.cboQuaTrinhHocTap);
               this.Controls.Add(this.btnThem);
               this.Controls.Add(this.groupBox1);
               this.Controls.Add(this.btnSua);
               this.Controls.Add(this.dgrQuaTrinhHocTap);
               this.Controls.Add(this.btnXoa);
               this.Controls.Add(this.btnDong);
               this.Controls.Add(this.label3);
               this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
               this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.Name = "FrmQuaTrinhHocTap";
               this.Text = "FrmQuaTrinhHocTap";
               this.groupBox1.ResumeLayout(false);
               this.groupBox1.PerformLayout();
               ((System.ComponentModel.ISupportInitialize)(this.dtpBatDau.Properties.CalendarTimeProperties)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.dtpBatDau.Properties)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.dtpKetThuc.Properties.CalendarTimeProperties)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.dtpKetThuc.Properties)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.grvQuaTrinhhocTap)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.dgrQuaTrinhHocTap)).EndInit();
               this.ResumeLayout(false);
               this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboQuaTrinhHocTap;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbNoiDung;
        private DevExpress.XtraEditors.DateEdit dtpKetThuc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraGrid.Views.Grid.GridView grvQuaTrinhhocTap;
        private DevExpress.XtraGrid.GridControl dgrQuaTrinhHocTap;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnDong;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.DateEdit dtpBatDau;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;

    }
}