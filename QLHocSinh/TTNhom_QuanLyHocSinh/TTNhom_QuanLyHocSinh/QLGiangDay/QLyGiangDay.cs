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
    public partial class QLyGiangDay : DevExpress.XtraEditors.XtraForm
    {
        public QLyGiangDay()
        {
            InitializeComponent();
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            Program.opt = 1;
            TTChiTietGiangDay tTChiTietGiangDay = new TTChiTietGiangDay();
            tTChiTietGiangDay.ShowDialog();
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            Program.opt = 2;
            TTChiTietGiangDay tTChiTietGiangDay = new TTChiTietGiangDay();
            tTChiTietGiangDay.ShowDialog();
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn xoá thông tin này", "Question message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                bool kq = Program.giangDaySql.Xoa_GD(Program.giangDay);
                if (kq) // xoa thanh cong
                {
                    DialogResult result2 = MessageBox.Show("Xoá thông tin thành công", "Notice message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (result2 == DialogResult.OK)
                    {
                        this.Close();
                        Program.qLyGiangDay = new QLyGiangDay();
                        Program.qLyGiangDay.Refresh();
                        Program.quanLyChung.barButtonItemGiangDay_ItemClick(sender as QLyGiangDay, null);
                    }
                }
            }
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GiangDay_Load(object sender, EventArgs e)
        {
            LoadDataGD();
        }

        public void LoadDataGD()
        {
            Program.giangDaySql = new GiangDaySql();
            Program.giangDaySql.LayDSGiangDay(dataGridViewDSGiangDay, searchLookUpEdittimkiemgd);
        }
        private void getDataFromDgvIntoTextBox(TextBox tb, int row, string column)
        {
            tb.Text = dataGridViewDSGiangDay.Rows[row].Cells[column].Value.ToString();
        }
        private void dataGridViewDSGiangDay_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            getDataFromDgvIntoTextBox(textBoxmagv, numrow, "MaGiaoVien");
            getDataFromDgvIntoTextBox(textBoxhotengv, numrow, "HoTenGV");
            getDataFromDgvIntoTextBox(textBoxmalop, numrow, "MaLop");
            getDataFromDgvIntoTextBox(textBoxtenlop, numrow, "TenLop");
            getDataFromDgvIntoTextBox(textBoxmamonhoc, numrow, "MaMonHoc");
            getDataFromDgvIntoTextBox(textBoxmonhoc, numrow, "TenMonHoc");
            getDataFromDgvIntoTextBox(textBoxsotiet, numrow, "SoTiet");
            Program.giangDay = new GiangDay(textBoxmagv.Text, textBoxhotengv.Text,textBoxmalop.Text, textBoxtenlop.Text,textBoxmamonhoc.Text,
                textBoxmonhoc.Text, Convert.ToInt32(textBoxsotiet.Text));
        }

        private void dataGridViewDSGiangDay_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dataGridViewDSGiangDay.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }

        private void searchLookUpEdittimkiemgd_EditValueChanged(object sender, EventArgs e)
        {
            searchLookUpEdittimkiemgd.Text = "";
            var view = searchLookUpEdittimkiemgd.Properties.View;
            int row = view.FocusedRowHandle;
            string fNMaGiaoVien = "MaGiaoVien";
            string fnHoTenGV = "HoTenGV";
            string fnMaLop = "MaLop";
            string fnTenLop = "TenLop";
            string fnMaMonHoc = "MaMonHoc";
            string fnTenMonHoc = "TenMonHoc";
            string fnSoTiet = "SoTiet";

            object valueMaGiaoVien = view.GetRowCellValue(row, fNMaGiaoVien);
            object valueHoTenGV = view.GetRowCellValue(row, fnHoTenGV);
            object valueMaLop = view.GetRowCellValue(row, fnMaLop);
            object valueTenLop = view.GetRowCellValue(row, fnTenLop);
            object valueMaMonHoc = view.GetRowCellValue(row, fnMaMonHoc);
            object valueTenMonHoc = view.GetRowCellValue(row, fnTenMonHoc);
            object valueSoTiet = view.GetRowCellValue(row, fnSoTiet);

            textBoxmagv.Text = valueMaGiaoVien.ToString();
            textBoxhotengv.Text = valueHoTenGV.ToString();
            textBoxmalop.Text = valueMaLop.ToString();
            textBoxtenlop.Text = valueTenLop.ToString();
            textBoxmamonhoc.Text = valueMaMonHoc.ToString();
            textBoxmonhoc.Text = valueTenMonHoc.ToString();
            textBoxsotiet.Text = valueSoTiet.ToString();
        }
    }
}