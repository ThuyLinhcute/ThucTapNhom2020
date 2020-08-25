using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using TTNhom_QuanLyHocSinh.Object;

namespace TTNhom_QuanLyHocSinh.QLGiaoVien
{
    public partial class ThongTinChiTietGV : DevExpress.XtraEditors.XtraForm
    {
        private string diachi;
        private string gt;
        public bool flag = false;
        public ThongTinChiTietGV()
        {
            InitializeComponent();
        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool Kiemtra_GV()
        {
            if (!Program.giaoVienSql.KiemTraNgaySinh(dateTimePickerngaysinh))
            {
                DialogResult result = MessageBox.Show("Ngày sinh không hợp lệ", "Alert Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            gt = Program.giaoVienSql.KiemTraGioiTinh(radioButtonNam, radioButtonnu);
            if (gt == null)
            {
                DialogResult result = MessageBox.Show("Điền đầy đủ thông tin", "Alert Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (textBoxhotengv.Text == "" || comboBoxtinh.Text == "" || comboBoxhuyen.Text == "" || comboBoxxa.Text == "")
            {
                DialogResult result = MessageBox.Show("Điền đầy đủ thông tin", "Alert Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void buttonLưu_Click(object sender, EventArgs e)
        {
            if (!Kiemtra_GV())
                return;
            else
            {
                GiaoVien gv = TaoDoiTuongGV();
                if (Program.opt == 1) // them
                {
                    bool kq = Program.giaoVienSql.Them_GV(gv);
                    if (kq) // them thanh cong
                    {
                        DialogResult result = MessageBox.Show("Thêm thông tin thành công", "Notice message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (result == DialogResult.OK)
                        {
                            //Program.quanLyChung.barButtonItemQLHocSinh_ItemClick(null, null);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Thêm thông tin không thành công");
                    }
                }
                if (Program.opt == 2) // sua
                {
                    bool kq = Program.giaoVienSql.Sua_GV(gv);
                    if (kq) // them thanh cong
                    {
                        DialogResult result = MessageBox.Show("Sửa thông tin thành công", "Notice message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (result == DialogResult.OK)
                        {
                            //Program.quanLyChung.barButtonItemQLHocSinh_ItemClick(null, null);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Sửa thông tin không thành công");
                    }
                }

            }

        }

        private GiaoVien TaoDoiTuongGV()
        {
            diachi = comboBoxxa.Text + "-" + comboBoxhuyen.Text + "-" + comboBoxtinh.Text;
            GiaoVien gv = new GiaoVien(textBoxmagv.Text, textBoxhotengv.Text, gt,dateTimePickerngaysinh.Value, diachi,Convert.ToInt32(textBoxluong.Text),dateTimePickerngayvaolam.Value,
                textBoxchucvu.Text);
            return gv;
        }

        private void comboBoxtinh_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboBoxhuyen.Enabled = true;
            Program.giaoVienSql.LayDanhSachHuyen(comboBoxhuyen, comboBoxtinh.Text);
        }

        private void comboBoxhuyen_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboBoxxa.Enabled = true;
            Program.giaoVienSql.LayDanhSachXa(comboBoxxa, comboBoxtinh.Text, comboBoxhuyen.Text);
        }

        private void ThongTinChiTietGV_Load(object sender, EventArgs e)
        {
            Program.giaoVienSql.LayDanhSachTinh(comboBoxtinh);
            if (Program.opt == 1) //them
            {
                textBoxmagv.Text = Program.giaoVienSql.TaoMaGV();
            }
            if (Program.opt == 2) // sua
            {
                comboBoxtinh.Enabled = true;
                comboBoxxa.Enabled = true;
                comboBoxhuyen.Enabled = true;
                setThongTinVaoFormDeSua(Program.gv);
            }
        }

        public void setThongTinVaoFormDeSua(GiaoVien gv)
        {
            textBoxmagv.Text = gv.Magv;
            textBoxhotengv.Text = gv.Hotengv;
            dateTimePickerngaysinh.Value = gv.Ngaysinh;
            if (gv.Diachi != "")
            {
                string[] chuoi = gv.Diachi.Split('-');
                Program.giaoVienSql.LayDanhSachHuyen(comboBoxhuyen, chuoi[2]);
                Program.giaoVienSql.LayDanhSachXa(comboBoxxa, chuoi[2], chuoi[1]);
                comboBoxxa.Text = chuoi[0];
                comboBoxhuyen.Text = chuoi[1];
                comboBoxtinh.Text = chuoi[2];

            }
            if (gv.Gioitinh == "Nu")
            {
                radioButtonnu.Checked = true;
                radioButtonNam.Checked = false;
            }    
                
            if (gv.Gioitinh == "Nam")
            {
                radioButtonNam.Checked = true;
                radioButtonnu.Checked = false;
            }
            dateTimePickerngayvaolam.Value = gv.Ngayvaolam;
            textBoxchucvu.Text = gv.Chucvu;
            textBoxluong.Text = gv.Luong.ToString();
        }
    }
}