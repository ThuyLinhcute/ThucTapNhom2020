namespace QuanLyNhanSu.GUI
{
    partial class FrmQuanLyPhongBan
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
               System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmQuanLyPhongBan));
               this.dgrPhongBan = new DevExpress.XtraGrid.GridControl();
               this.grvPhongBan = new DevExpress.XtraGrid.Views.Grid.GridView();
               this.PhongBanID = new DevExpress.XtraGrid.Columns.GridColumn();
               this.Ten = new DevExpress.XtraGrid.Columns.GridColumn();
               this.groupBox1 = new System.Windows.Forms.GroupBox();
               this.txbTenPhogBan = new System.Windows.Forms.TextBox();
               this.label2 = new System.Windows.Forms.Label();
               this.label3 = new System.Windows.Forms.Label();
               this.btnSua = new DevExpress.XtraEditors.SimpleButton();
               this.btnThem = new DevExpress.XtraEditors.SimpleButton();
               this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
               this.btnDong = new DevExpress.XtraEditors.SimpleButton();
               ((System.ComponentModel.ISupportInitialize)(this.dgrPhongBan)).BeginInit();
               ((System.ComponentModel.ISupportInitialize)(this.grvPhongBan)).BeginInit();
               this.groupBox1.SuspendLayout();
               this.SuspendLayout();
               // 
               // dgrPhongBan
               // 
               this.dgrPhongBan.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.dgrPhongBan.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               gridLevelNode1.RelationName = "Level1";
               this.dgrPhongBan.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
               this.dgrPhongBan.Location = new System.Drawing.Point(20, 31);
               this.dgrPhongBan.MainView = this.grvPhongBan;
               this.dgrPhongBan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.dgrPhongBan.Name = "dgrPhongBan";
               this.dgrPhongBan.Size = new System.Drawing.Size(904, 601);
               this.dgrPhongBan.TabIndex = 9;
               this.dgrPhongBan.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grvPhongBan});
               // 
               // grvPhongBan
               // 
               this.grvPhongBan.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.PhongBanID,
            this.Ten});
               this.grvPhongBan.DetailHeight = 431;
               this.grvPhongBan.GridControl = this.dgrPhongBan;
               this.grvPhongBan.Name = "grvPhongBan";
               this.grvPhongBan.OptionsView.ShowGroupPanel = false;
               this.grvPhongBan.PaintStyleName = "Flat";
               this.grvPhongBan.RowHeight = 37;
               // 
               // PhongBanID
               // 
               this.PhongBanID.Caption = "Mã phòng ban";
               this.PhongBanID.FieldName = "PHONGBANID";
               this.PhongBanID.MinWidth = 27;
               this.PhongBanID.Name = "PhongBanID";
               this.PhongBanID.Visible = true;
               this.PhongBanID.VisibleIndex = 0;
               this.PhongBanID.Width = 236;
               // 
               // Ten
               // 
               this.Ten.Caption = "Tên phòng ban";
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
               this.groupBox1.Controls.Add(this.txbTenPhogBan);
               this.groupBox1.Controls.Add(this.label2);
               this.groupBox1.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.groupBox1.Location = new System.Drawing.Point(963, 197);
               this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.groupBox1.Name = "groupBox1";
               this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.groupBox1.Size = new System.Drawing.Size(680, 133);
               this.groupBox1.TabIndex = 10;
               this.groupBox1.TabStop = false;
               this.groupBox1.Text = "Thông tin phòng ban";
               // 
               // txbTenPhogBan
               // 
               this.txbTenPhogBan.Location = new System.Drawing.Point(180, 54);
               this.txbTenPhogBan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.txbTenPhogBan.Name = "txbTenPhogBan";
               this.txbTenPhogBan.Size = new System.Drawing.Size(425, 23);
               this.txbTenPhogBan.TabIndex = 1;
               // 
               // label2
               // 
               this.label2.AutoSize = true;
               this.label2.Location = new System.Drawing.Point(61, 58);
               this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.label2.Name = "label2";
               this.label2.Size = new System.Drawing.Size(102, 17);
               this.label2.TabIndex = 0;
               this.label2.Text = "Tên phòng ban";
               // 
               // label3
               // 
               this.label3.AutoSize = true;
               this.label3.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.label3.Location = new System.Drawing.Point(16, 11);
               this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
               this.label3.Name = "label3";
               this.label3.Size = new System.Drawing.Size(144, 17);
               this.label3.TabIndex = 15;
               this.label3.Text = "Danh sách phòng ban";
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
               this.btnSua.TabIndex = 14;
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
               this.btnThem.TabIndex = 13;
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
               this.btnXoa.TabIndex = 12;
               this.btnXoa.Text = "Xóa";
               this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
               // 
               // btnDong
               // 
               this.btnDong.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
               this.btnDong.Appearance.Options.UseFont = true;
               this.btnDong.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.Flat;
               this.btnDong.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.ImageOptions.Image")));
               this.btnDong.Location = new System.Drawing.Point(963, 578);
               this.btnDong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.btnDong.Name = "btnDong";
               this.btnDong.Size = new System.Drawing.Size(680, 53);
               this.btnDong.TabIndex = 11;
               this.btnDong.Text = "Đóng chức năng";
               this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
               // 
               // FrmQuanLyPhongBan
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(1661, 652);
               this.Controls.Add(this.dgrPhongBan);
               this.Controls.Add(this.groupBox1);
               this.Controls.Add(this.label3);
               this.Controls.Add(this.btnSua);
               this.Controls.Add(this.btnThem);
               this.Controls.Add(this.btnXoa);
               this.Controls.Add(this.btnDong);
               this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
               this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
               this.Name = "FrmQuanLyPhongBan";
               this.Text = "FrmQuanLyPhongBan";
               ((System.ComponentModel.ISupportInitialize)(this.dgrPhongBan)).EndInit();
               ((System.ComponentModel.ISupportInitialize)(this.grvPhongBan)).EndInit();
               this.groupBox1.ResumeLayout(false);
               this.groupBox1.PerformLayout();
               this.ResumeLayout(false);
               this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl dgrPhongBan;
        private DevExpress.XtraGrid.Views.Grid.GridView grvPhongBan;
        private DevExpress.XtraGrid.Columns.GridColumn PhongBanID;
        private DevExpress.XtraGrid.Columns.GridColumn Ten;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txbTenPhogBan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnDong;

    }
}