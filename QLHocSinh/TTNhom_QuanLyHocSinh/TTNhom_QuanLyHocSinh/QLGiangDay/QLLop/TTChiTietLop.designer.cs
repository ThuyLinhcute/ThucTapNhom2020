namespace TTNhom_QuanLyHocSinh.QLGiangDay.QLLop
{
    partial class TTChiTietLop
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
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxmalop = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxtenlop = new System.Windows.Forms.TextBox();
            this.gridLookUpEditMaGV = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonHuy = new System.Windows.Forms.Button();
            this.buttonLưu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEditMaGV.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 22);
            this.label4.TabIndex = 11;
            this.label4.Text = "Mã lớp";
            // 
            // textBoxmalop
            // 
            this.textBoxmalop.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxmalop.Location = new System.Drawing.Point(142, 32);
            this.textBoxmalop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxmalop.Name = "textBoxmalop";
            this.textBoxmalop.ReadOnly = true;
            this.textBoxmalop.Size = new System.Drawing.Size(250, 30);
            this.textBoxmalop.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 22);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tên lớp";
            // 
            // textBoxtenlop
            // 
            this.textBoxtenlop.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxtenlop.Location = new System.Drawing.Point(142, 77);
            this.textBoxtenlop.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxtenlop.Name = "textBoxtenlop";
            this.textBoxtenlop.Size = new System.Drawing.Size(250, 30);
            this.textBoxtenlop.TabIndex = 8;
            // 
            // gridLookUpEditMaGV
            // 
            this.gridLookUpEditMaGV.Location = new System.Drawing.Point(142, 125);
            this.gridLookUpEditMaGV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gridLookUpEditMaGV.Name = "gridLookUpEditMaGV";
            this.gridLookUpEditMaGV.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridLookUpEditMaGV.Properties.Appearance.Options.UseFont = true;
            this.gridLookUpEditMaGV.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.gridLookUpEditMaGV.Properties.PopupView = this.gridLookUpEdit1View;
            this.gridLookUpEditMaGV.Size = new System.Drawing.Size(250, 28);
            this.gridLookUpEditMaGV.TabIndex = 50;
            this.gridLookUpEditMaGV.EditValueChanged += new System.EventHandler(this.gridLookUpEditMaGV_EditValueChanged);
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 22);
            this.label1.TabIndex = 49;
            this.label1.Text = "Mã giáo viên";
            // 
            // buttonHuy
            // 
            this.buttonHuy.BackColor = System.Drawing.SystemColors.Info;
            this.buttonHuy.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHuy.Location = new System.Drawing.Point(225, 166);
            this.buttonHuy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonHuy.Name = "buttonHuy";
            this.buttonHuy.Size = new System.Drawing.Size(122, 36);
            this.buttonHuy.TabIndex = 64;
            this.buttonHuy.Text = "Huỷ";
            this.buttonHuy.UseVisualStyleBackColor = false;
            this.buttonHuy.Click += new System.EventHandler(this.buttonHuy_Click);
            // 
            // buttonLưu
            // 
            this.buttonLưu.BackColor = System.Drawing.SystemColors.Info;
            this.buttonLưu.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLưu.Location = new System.Drawing.Point(65, 166);
            this.buttonLưu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonLưu.Name = "buttonLưu";
            this.buttonLưu.Size = new System.Drawing.Size(122, 36);
            this.buttonLưu.TabIndex = 63;
            this.buttonLưu.Text = "Lưu";
            this.buttonLưu.UseVisualStyleBackColor = false;
            this.buttonLưu.Click += new System.EventHandler(this.buttonLưu_Click);
            // 
            // TTChiTietLop
            // 
            this.Appearance.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 225);
            this.Controls.Add(this.buttonHuy);
            this.Controls.Add(this.buttonLưu);
            this.Controls.Add(this.gridLookUpEditMaGV);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxmalop);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxtenlop);
            this.Name = "TTChiTietLop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TTChiTietLop";
            this.Load += new System.EventHandler(this.TTChiTietLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEditMaGV.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxmalop;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxtenlop;
        private DevExpress.XtraEditors.GridLookUpEdit gridLookUpEditMaGV;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonHuy;
        private System.Windows.Forms.Button buttonLưu;
    }
}