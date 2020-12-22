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

namespace TTNhom_QuanLyHocSinh.QLGiangDay.QLLop
{
    public partial class TTChiTietLop : DevExpress.XtraEditors.XtraForm
    {
        private bool flag_gv;
        private string magv;
        public TTChiTietLop()
        {
            InitializeComponent();
        }

        private void buttonHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonLưu_Click(object sender, EventArgs e)
        {
            if (!KiemTra_Lop())
                return;
            else
            {
                Lop lop = TaoDoiTuongLop();
                if (Program.opt == 1) // them
                {
                    bool kq = Program.lopSql.Them_Lop(lop);
                    if (kq) // them thanh cong
                    {
                        DialogResult result = MessageBox.Show("Thêm thông tin thành công", "Notice message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (result == DialogResult.OK)
                        {
                            this.Close();
                            Program.qLyLop = new QLyLop();
                            Program.qLyLop.Refresh();
                            Program.quanLyChung.barButtonItemqllop_ItemClick(sender as QLyLop, null);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Thêm thông tin không thành công");
                    }
                }
                if (Program.opt == 2) // sua
                {
                    bool kq = Program.lopSql.Sua_Lop(lop);
                    if (kq) // them thanh cong
                    {
                        DialogResult result = MessageBox.Show("Sửa thông tin thành công", "Notice message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (result == DialogResult.OK)
                        {
                            this.Close();
                            Program.qLyLop = new QLyLop();
                            Program.qLyLop.Refresh();
                            Program.quanLyChung.barButtonItemqllop_ItemClick(sender as QLyLop, null);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Sửa thông tin không thành công");
                    }
                }
            }
        }


        private Lop TaoDoiTuongLop()
        {
            Lop hs = new Lop(textBoxmalop.Text,textBoxtenlop.Text,magv);
            return hs;
        }

        public bool KiemTra_Lop()
        {
            if (flag_gv == false || textBoxtenlop.Text == "")
            {
                DialogResult result = MessageBox.Show("Điền đầy đủ thông tin", "Alert Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;

        }

        private void TTChiTietLop_Load(object sender, EventArgs e)
        {
            List<string> list_magv = Program.lopSql.LayDSGV(gridLookUpEditMaGV);
            if(Program.opt == 1) // them
            {
                textBoxmalop.Text = Program.lopSql.TaoMaLop();
            }
            if(Program.opt == 2)
            {
                HienThongTinLenEditValue(gridLookUpEditMaGV, list_magv, Program.lop.Magvcn);
                textBoxtenlop.Text = Program.lop.Tenlop;
                textBoxmalop.Text = Program.lop.Malop;
            }
        }

        private void HienThongTinLenEditValue(GridLookUpEdit grid, List<string> list, string ma)
        {
            int index = list.BinarySearch(ma);
            grid.EditValue = grid.Properties.GetKeyValue(index);
        }

        private void gridLookUpEditMaGV_EditValueChanged(object sender, EventArgs e)
        {
            var edit = sender as GridLookUpEdit;

            DataRow dr = (edit.Properties.GetRowByKeyValue(edit.EditValue) as DataRowView).Row;
            magv = dr["MaGiaoVien"].ToString();
            flag_gv = true;
        }
    }
}