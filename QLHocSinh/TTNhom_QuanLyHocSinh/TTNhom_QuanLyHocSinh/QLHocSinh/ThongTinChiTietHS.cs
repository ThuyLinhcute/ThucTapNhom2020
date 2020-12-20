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

namespace TTNhom_QuanLyHocSinh.QLHocSinh
{
    public partial class ThongTinChiTietHS : DevExpress.XtraEditors.XtraForm
    {
        
        
        private string maLop;
        private string diachi;
        private string gt;
        public bool flag = false; // kiem tra da chon lop chua
        public ThongTinChiTietHS()
        {
            InitializeComponent();
        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool Kiemtra_HS()
        {
            if (!Program.hocSinhSql.KiemTraNgaySinh(dateTimePickerngaysinh))
            {
                DialogResult result = MessageBox.Show("Ngày sinh không hợp lệ", "Alert Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            gt = Program.hocSinhSql.KiemTraGioiTinh(radioButtonNam, radioButtonnu);
            if(gt == null)
            {
                DialogResult result = MessageBox.Show("Điền đầy đủ thông tin", "Alert Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }    
            if (textBoxhotenhs.Text == ""|| comboBoxtinh.Text == "" || comboBoxhuyen.Text == "" || comboBoxxa.Text == ""
                    || comboBoxdantoc.Text == "" || flag == false)
            {
                DialogResult result = MessageBox.Show("Điền đầy đủ thông tin", "Alert Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void buttonLưu_Click(object sender, EventArgs e)
        {
            if (!Kiemtra_HS())
                return;
            else
            {
                HocSinh hs = TaoDoiTuongHS();
                if (Program.opt == 1) // them
                {
                    bool kq = Program.hocSinhSql.Them_HS(hs);
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
                    bool kq = Program.hocSinhSql.Sua_HS(hs);
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
        private HocSinh TaoDoiTuongHS()
        {
            diachi = comboBoxxa.Text + "-" + comboBoxhuyen.Text + "-" + comboBoxtinh.Text;
            HocSinh hs = new HocSinh(Convert.ToInt32(textBoxmahs.Text), maLop, textBoxhotenhs.Text, dateTimePickerngaysinh.Value,diachi,gt,comboBoxdantoc.Text,textBoxhotenphuhuynh.Text,
                textBoxsdtphuhuynh.Text,Convert.ToInt32(textBoxnamnhaphoc.Text));
            return hs;
        }

        private void gridLookUpEditMaLop_EditValueChanged(object sender, EventArgs e)
        {
            var edit = sender as GridLookUpEdit;

            DataRow dr = (edit.Properties.GetRowByKeyValue(edit.EditValue) as DataRowView).Row;
            maLop = dr["MaLop"].ToString();
            flag = true;

        }

        private void comboBoxtinh_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboBoxhuyen.Enabled = true;
            Program.hocSinhSql.LayDanhSachHuyen(comboBoxhuyen, comboBoxtinh.Text);
        }

        private void comboBoxhuyen_SelectionChangeCommitted(object sender, EventArgs e)
        {
            comboBoxxa.Enabled = true;
            Program.hocSinhSql.LayDanhSachXa(comboBoxxa, comboBoxtinh.Text, comboBoxhuyen.Text);
        }

        private void ThongTinChiTietHS_Load(object sender, EventArgs e)
        {
            List<string> list_malop = Program.hocSinhSql.LayDSLop(gridLookUpEditMaLop);
            Program.hocSinhSql.LayDanhSachTinh(comboBoxtinh);
            if (Program.opt==1) //them
            {
                textBoxmahs.Text = Program.hocSinhSql.TaoMaHS().ToString();
                textBoxnamnhaphoc.Text = DateTime.Now.Year.ToString();
            }    
            if(Program.opt==2) // sua
            {
                comboBoxtinh.Enabled = true;
                comboBoxxa.Enabled = true;
                comboBoxhuyen.Enabled = true;
                setThongTinVaoFormDeSua(Program.hs, list_malop);
            }    
        }

        public void setThongTinVaoFormDeSua(HocSinh hs,List<string> list_malop)
        {
            textBoxmahs.Text = hs.Mahocsinh.ToString();
            textBoxhotenhs.Text = hs.Hotenhs;
            HienThongTinLenEditValue_Lop(gridLookUpEditMaLop, list_malop, hs.Malop);
            dateTimePickerngaysinh.Value = hs.Ngaysinh;
            if (hs.Diachi != "")
            {
                string[] chuoi = hs.Diachi.Split('-');
                Program.hocSinhSql.LayDanhSachHuyen(comboBoxhuyen, chuoi[2]);
                Program.hocSinhSql.LayDanhSachXa(comboBoxxa, chuoi[2], chuoi[1]);
                comboBoxxa.Text = chuoi[0];
                comboBoxhuyen.Text = chuoi[1];
                comboBoxtinh.Text = chuoi[2];
               
            }
            if (hs.Gioitinh == "Nu")
                radioButtonnu.Checked = true;
            else
            {
                if (hs.Gioitinh == "Nam")
                    radioButtonNam.Checked = true;
            }
            
            comboBoxdantoc.Text = hs.Dantoc;
            textBoxhotenphuhuynh.Text = hs.Hotenphuhuynh;
            textBoxsdtphuhuynh.Text = hs.Sdtphuhuynh;
            textBoxnamnhaphoc.Text = hs.Namnhaphoc.ToString();

        }
        private void HienThongTinLenEditValue_Lop(GridLookUpEdit grid,List<string> list,string ma)
        {
            int index = list.BinarySearch(ma);
            grid.EditValue = grid.Properties.GetKeyValue(index);
        }
    }
}