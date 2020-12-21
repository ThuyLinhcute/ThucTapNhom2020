namespace QuanLyNhanSu
{
    partial class FrmLogin
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
               this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
               this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
               this.textBox1 = new System.Windows.Forms.TextBox();
               this.textBox2 = new System.Windows.Forms.TextBox();
               this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
               this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
               this.SuspendLayout();
               // 
               // labelControl1
               // 
               this.labelControl1.Location = new System.Drawing.Point(106, 13);
               this.labelControl1.Margin = new System.Windows.Forms.Padding(4);
               this.labelControl1.Name = "labelControl1";
               this.labelControl1.Size = new System.Drawing.Size(93, 17);
               this.labelControl1.TabIndex = 0;
               this.labelControl1.Text = "Tên đăng nhập";
               // 
               // labelControl2
               // 
               this.labelControl2.Location = new System.Drawing.Point(106, 89);
               this.labelControl2.Margin = new System.Windows.Forms.Padding(4);
               this.labelControl2.Name = "labelControl2";
               this.labelControl2.Size = new System.Drawing.Size(56, 17);
               this.labelControl2.TabIndex = 1;
               this.labelControl2.Text = "Mật khẩu";
               // 
               // textBox1
               // 
               this.textBox1.Location = new System.Drawing.Point(106, 49);
               this.textBox1.Margin = new System.Windows.Forms.Padding(4);
               this.textBox1.Name = "textBox1";
               this.textBox1.Size = new System.Drawing.Size(269, 22);
               this.textBox1.TabIndex = 2;
               this.textBox1.Text = "Admin";
               this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
               // 
               // textBox2
               // 
               this.textBox2.Location = new System.Drawing.Point(106, 114);
               this.textBox2.Margin = new System.Windows.Forms.Padding(4);
               this.textBox2.Name = "textBox2";
               this.textBox2.Size = new System.Drawing.Size(269, 22);
               this.textBox2.TabIndex = 3;
               this.textBox2.Text = "1";
               this.textBox2.UseSystemPasswordChar = true;
               // 
               // simpleButton1
               // 
               this.simpleButton1.Location = new System.Drawing.Point(99, 168);
               this.simpleButton1.Margin = new System.Windows.Forms.Padding(4);
               this.simpleButton1.Name = "simpleButton1";
               this.simpleButton1.Size = new System.Drawing.Size(100, 28);
               this.simpleButton1.TabIndex = 4;
               this.simpleButton1.Text = "Đăng nhập";
               this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
               // 
               // simpleButton2
               // 
               this.simpleButton2.Location = new System.Drawing.Point(265, 168);
               this.simpleButton2.Margin = new System.Windows.Forms.Padding(4);
               this.simpleButton2.Name = "simpleButton2";
               this.simpleButton2.Size = new System.Drawing.Size(100, 28);
               this.simpleButton2.TabIndex = 5;
               this.simpleButton2.Text = "Thoát";
               this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
               // 
               // FrmLogin
               // 
               this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
               this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
               this.ClientSize = new System.Drawing.Size(481, 215);
               this.Controls.Add(this.simpleButton2);
               this.Controls.Add(this.simpleButton1);
               this.Controls.Add(this.textBox2);
               this.Controls.Add(this.textBox1);
               this.Controls.Add(this.labelControl2);
               this.Controls.Add(this.labelControl1);
               this.Margin = new System.Windows.Forms.Padding(4);
               this.MaximizeBox = false;
               this.Name = "FrmLogin";
               this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
               this.Text = "Đăng nhập";
               this.ResumeLayout(false);
               this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.Button button1;
    }
}