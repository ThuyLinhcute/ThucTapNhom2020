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
    public partial class TTChiTietGiangDay : DevExpress.XtraEditors.XtraForm
    {
        private GiangDay giangday_new = new GiangDay();
        private bool flag_gv;
        private bool flag_lop;
        private bool flag_monhoc;
        public TTChiTietGiangDay()
        {
            InitializeComponent();
        }
        public bool KiemTra_GD()
        {
            if(flag_gv == false || flag_lop == false || flag_monhoc == false)
            {
                DialogResult result = MessageBox.Show("Điền đầy đủ thông tin", "Alert Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;

        }
        private void buttonLưu_Click(object sender, EventArgs e)
        {
            if (!KiemTra_GD())
                return;
            else
            {
                if (Program.opt == 1) // them
                {
                    bool kq = Program.giangDaySql.Them_GD(giangday_new);
                    if (kq)
                    {
                        DialogResult result = MessageBox.Show("Thêm thông tin thành công", "Notice message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (result == DialogResult.OK)
                        {
                            this.Close();
                            Program.qLyGiangDay = new QLyGiangDay();
                            Program.qLyGiangDay.Refresh();
                            Program.quanLyChung.barButtonItemGiangDay_ItemClick(sender as QLyGiangDay, null);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Thêm thông tin không thành công");
                    }
                }
                if (Program.opt == 2)
                {
                    bool kq = Program.giangDaySql.Sua_GD(giangday_new, Program.giangDay);
                    if (kq)
                    {
                        DialogResult result = MessageBox.Show("Sửa thông tin thành công", "Notice message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (result == DialogResult.OK)
                        {
                            this.Close();
                            Program.qLyGiangDay = new QLyGiangDay();
                            Program.qLyGiangDay.Refresh();
                            Program.quanLyChung.barButtonItemGiangDay_ItemClick(sender as QLyGiangDay, null);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Sửa thông tin không thành công");
                    }
                }
            }
        }
        private void buttonHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridLookUpEditMaGV_EditValueChanged(object sender, EventArgs e)
        {
            var edit = sender as GridLookUpEdit;

            DataRow dr = (edit.Properties.GetRowByKeyValue(edit.EditValue) as DataRowView).Row;
            giangday_new.Magv = dr["MaGiaoVien"].ToString();
            giangday_new.Hotengv = dr["HoTenGV"].ToString();
            tbhotengv.Text = giangday_new.Hotengv;
            flag_gv = true;
        }

        private void gridLookUpEditmalop_EditValueChanged(object sender, EventArgs e)
        {
            var edit = sender as GridLookUpEdit;

            DataRow dr = (edit.Properties.GetRowByKeyValue(edit.EditValue) as DataRowView).Row;
            giangday_new.Malop = dr["MaLop"].ToString();
            giangday_new.Tenlop = dr["TenLop"].ToString();
            tbtenlop.Text = giangday_new.Tenlop;
            flag_lop = true;
            
        }

        private void gridLookUpEditmamonhoc_EditValueChanged(object sender, EventArgs e)
        {
            var edit = sender as GridLookUpEdit;

            DataRow dr = (edit.Properties.GetRowByKeyValue(edit.EditValue) as DataRowView).Row;
            giangday_new.Mamonhoc = dr["MaMonHoc"].ToString();
            giangday_new.Tenmonhoc = dr["TenMonHoc"].ToString();
            giangday_new.Sotiet = Convert.ToInt32(dr["SoTiet"]);
            tbTenMonHoc.Text = giangday_new.Tenmonhoc;
            tbSoTiet.Text = giangday_new.Sotiet.ToString();
            flag_monhoc = true;
            
        }

        private void TTChiTietGiangDay_Load(object sender, EventArgs e)
        {
            List<string> list_magv = Program.giangDaySql.LayDSGV(gridLookUpEditMaGV);
            List<string> list_malop = Program.giangDaySql.LayDSLop(gridLookUpEditmalop);
            List<string> list_mamonhoc = Program.giangDaySql.LayDSMonHoc(gridLookUpEditmamonhoc);
            if(Program.opt==2)
            {
                HienThongTinLenEditValue(gridLookUpEditMaGV, list_magv, Program.giangDay.Magv);
                HienThongTinLenEditValue(gridLookUpEditmalop, list_malop, Program.giangDay.Malop);
                HienThongTinLenEditValue(gridLookUpEditmamonhoc, list_mamonhoc, Program.giangDay.Mamonhoc);
                tbhotengv.Text = Program.giangDay.Hotengv;
                tbtenlop.Text = Program.giangDay.Tenlop;
                tbTenMonHoc.Text = Program.giangDay.Tenmonhoc;
                tbSoTiet.Text = Program.giangDay.Sotiet.ToString();
            }    
        }

        private void HienThongTinLenEditValue(GridLookUpEdit grid, List<string> list, string ma)
        {
            int index = list.BinarySearch(ma);
            grid.EditValue = grid.Properties.GetKeyValue(index);
        }

    }
}