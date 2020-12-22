namespace BanHangSieuTHi.Add
{
    partial class frmHangHoa
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.Ma = new System.Windows.Forms.TextBox();
            this.Ten = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DonVi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TenNhaSX = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.GiaDeNghi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.SoLuong = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Loai = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ma";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Ma
            // 
            this.Ma.Enabled = false;
            this.Ma.Location = new System.Drawing.Point(199, 20);
            this.Ma.Multiline = true;
            this.Ma.Name = "Ma";
            this.Ma.Size = new System.Drawing.Size(642, 32);
            this.Ma.TabIndex = 1;
            // 
            // Ten
            // 
            this.Ten.Location = new System.Drawing.Point(199, 101);
            this.Ten.Multiline = true;
            this.Ten.Name = "Ten";
            this.Ten.Size = new System.Drawing.Size(642, 32);
            this.Ten.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ten";
            // 
            // DonVi
            // 
            this.DonVi.Location = new System.Drawing.Point(199, 199);
            this.DonVi.Multiline = true;
            this.DonVi.Name = "DonVi";
            this.DonVi.Size = new System.Drawing.Size(642, 32);
            this.DonVi.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Don Vi";
            // 
            // TenNhaSX
            // 
            this.TenNhaSX.Location = new System.Drawing.Point(199, 301);
            this.TenNhaSX.Multiline = true;
            this.TenNhaSX.Name = "TenNhaSX";
            this.TenNhaSX.Size = new System.Drawing.Size(642, 32);
            this.TenNhaSX.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 307);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 26);
            this.label4.TabIndex = 6;
            this.label4.Text = "Ten Nha SX";
            // 
            // GiaDeNghi
            // 
            this.GiaDeNghi.Location = new System.Drawing.Point(199, 411);
            this.GiaDeNghi.Multiline = true;
            this.GiaDeNghi.Name = "GiaDeNghi";
            this.GiaDeNghi.Size = new System.Drawing.Size(642, 32);
            this.GiaDeNghi.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 417);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 26);
            this.label5.TabIndex = 8;
            this.label5.Text = "Gia De Nghi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 540);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 26);
            this.label6.TabIndex = 10;
            this.label6.Text = "Loai";
            // 
            // SoLuong
            // 
            this.SoLuong.Location = new System.Drawing.Point(199, 654);
            this.SoLuong.Multiline = true;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Size = new System.Drawing.Size(642, 32);
            this.SoLuong.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 660);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 26);
            this.label7.TabIndex = 11;
            this.label7.Text = "So Luong";
            // 
            // Loai
            // 
            this.Loai.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Loai.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Loai.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Loai.FormattingEnabled = true;
            this.Loai.Location = new System.Drawing.Point(199, 552);
            this.Loai.Name = "Loai";
            this.Loai.Size = new System.Drawing.Size(642, 33);
            this.Loai.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(392, 746);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 85);
            this.button1.TabIndex = 15;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 886);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Loai);
            this.Controls.Add(this.SoLuong);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.GiaDeNghi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TenNhaSX);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DonVi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Ten);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Ma);
            this.Controls.Add(this.label1);
            this.Name = "frmHangHoa";
            this.Text = "frmHangHoa";
            this.Load += new System.EventHandler(this.frmHangHoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Ma;
        private System.Windows.Forms.TextBox Ten;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DonVi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TenNhaSX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox GiaDeNghi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox SoLuong;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox Loai;
        private System.Windows.Forms.Button button1;
    }
}