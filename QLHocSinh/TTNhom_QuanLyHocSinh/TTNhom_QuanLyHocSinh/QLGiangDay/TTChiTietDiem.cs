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

namespace TTNhom_QuanLyHocSinh.QLGiangDay
{
    public partial class TTChiTietDiem : DevExpress.XtraEditors.XtraForm
    {
        public TTChiTietDiem()
        {
            InitializeComponent();
        }

        private void buttonLưu_Click(object sender, EventArgs e)
        {
            Diem d = new Object.Diem(Convert.ToInt32(textBoxmahs.Text), textBoxhotenhs.Text, textBoxngaysinh.Text, textBoxgioitinh.Text,
                Program.mamonhoc, Convert.ToDouble(textBoxdiemmieng.Text), Convert.ToDouble(textBoxdiem15phut.Text),
                Convert.ToDouble(textBoxdiem1tiet.Text), Convert.ToDouble(textBoxdiemhk.Text), Convert.ToDouble(textBoxdtbmon.Text));
            if (Program.opt == 1) // them
            {
                bool kq = Program.diemSql.NhapDiem(d);
                if (kq)
                {
                    DialogResult result = MessageBox.Show("Thêm thông tin thành công", "Notice message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                    {
                        this.Close();
                        Program.qLDiem = new QLDiem();
                        Program.qLDiem.Refresh();
                        Program.quanLyChung.barButtonItemQLLop_Diem_ItemClick(sender as QLDiem, null);
                    }
                }
                else
                {
                    MessageBox.Show("Thêm thông tin không thành công");
                }
            }
            if (Program.opt == 2)
            {
                bool kq = Program.diemSql.SuaDiem(d);
                if (kq)
                {
                    DialogResult result = MessageBox.Show("Sửa thông tin thành công", "Notice message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (result == DialogResult.OK)
                    {
                        this.Close();
                        Program.qLDiem = new QLDiem();
                        Program.qLDiem.Refresh();
                        Program.quanLyChung.barButtonItemQLLop_Diem_ItemClick(sender as QLDiem, null);
                    }
                }
                else
                {
                    MessageBox.Show("Sửa thông tin không thành công");
                }
            }
        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TTChiTietDiem_Load(object sender, EventArgs e)
        {
            textBoxmahs.Text = Program.diem.Mahs.ToString();
            textBoxhotenhs.Text = Program.diem.Hotenhs;
            textBoxgioitinh.Text = Program.diem.Gioitinh;
            textBoxngaysinh.Text = Program.diem.Ngaysinh;
            if(Program.opt==2) // sua
            {
                textBoxdiemmieng.Text = Program.diem.Diemmieng.ToString();
                textBoxdiem15phut.Text = Program.diem.Diem15phut.ToString();
                textBoxdiem1tiet.Text = Program.diem.Diem1tiet.ToString();
                textBoxdiemhk.Text = Program.diem.Diemhocki.ToString();
                textBoxdtbmon.Text = Program.diem.Diemtrungbinhmon.ToString();
            }    
        }

        private void textBoxdiemmieng_TextChanged(object sender, EventArgs e)
        {
            double diemmieng;
            double.TryParse(textBoxdiemmieng.Text,out diemmieng);
            double diem15phut;
            double diem1tiet;
            double diemhocky;
            double.TryParse(textBoxdiem15phut.Text, out diem15phut);
            double.TryParse(textBoxdiem1tiet.Text, out diem1tiet);
            double.TryParse(textBoxdiemhk.Text, out diemhocky);
            double diemtbmon = (diemmieng + diem15phut + diem1tiet * 2 + diemhocky * 3) / 7;
            diemtbmon = Math.Round(diemtbmon, 2);
            textBoxdtbmon.Text = diemtbmon.ToString();

        }

        private void textBoxdiem15phut_TextChanged(object sender, EventArgs e)
        {
            double diemmieng;
            double diem15phut;
            double diem1tiet;
            double diemhocky;
            double.TryParse(textBoxdiem15phut.Text, out diem15phut);
            double.TryParse(textBoxdiemmieng.Text, out diemmieng);
            double.TryParse(textBoxdiem1tiet.Text, out diem1tiet);
            double.TryParse(textBoxdiemhk.Text, out diemhocky);
            double diemtbmon = (diemmieng + diem15phut + diem1tiet * 2 + diemhocky * 3) / 7;
            diemtbmon = Math.Round(diemtbmon, 2);
            textBoxdtbmon.Text = diemtbmon.ToString();
        }

        private void textBoxdiem1tiet_TextChanged(object sender, EventArgs e)
        {
            double diemmieng;
            double diem15phut;
            double diem1tiet;
            double diemhocky;
            double.TryParse(textBoxdiem1tiet.Text, out diem1tiet);
            double.TryParse(textBoxdiem15phut.Text, out diem15phut);
            double.TryParse(textBoxdiemmieng.Text, out diemmieng);
            double.TryParse(textBoxdiemhk.Text, out diemhocky);
            double diemtbmon = (diemmieng + diem15phut + diem1tiet * 2 + diemhocky * 3) / 7;
            diemtbmon = Math.Round(diemtbmon, 2);
            textBoxdtbmon.Text = diemtbmon.ToString();
        }

        private void textBoxdiemhk_TextChanged(object sender, EventArgs e)
        {
            double diemmieng;
            double diem15phut;
            double diem1tiet;
            double diemhocky;
            double.TryParse(textBoxdiemhk.Text,out diemhocky);
            double.TryParse(textBoxdiem15phut.Text, out diem15phut);
            double.TryParse(textBoxdiem1tiet.Text, out diem1tiet);
            double.TryParse(textBoxdiemmieng.Text, out diemmieng);
            double diemtbmon = (diemmieng + diem15phut + diem1tiet * 2 + diemhocky * 3) / 7;
            diemtbmon = Math.Round(diemtbmon, 2);
            textBoxdtbmon.Text = diemtbmon.ToString();
        }
    }
}