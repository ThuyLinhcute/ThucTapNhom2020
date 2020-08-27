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

namespace TTNhom_QuanLyHocSinh.QLGiangDay
{
    public partial class QLDiem : DevExpress.XtraEditors.XtraForm
    {
        private bool flag_lop = false;
        private bool flag_monhoc = false;
        private string malop;
        
        public QLDiem()
        {
            InitializeComponent();
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonNhapDiem_Click(object sender, EventArgs e)
        {
            Program.opt = 1;
            TTChiTietDiem lop_diem = new TTChiTietDiem();
            lop_diem.ShowDialog();
        }

        private void buttonSuaDiem_Click(object sender, EventArgs e)
        {
            Program.opt = 2;
            TTChiTietDiem lop_diem = new TTChiTietDiem();
            lop_diem.ShowDialog();
        }

        private void gridLookUpEditlop_EditValueChanged(object sender, EventArgs e)
        {
            var edit = sender as GridLookUpEdit;

            DataRow dr = (edit.Properties.GetRowByKeyValue(edit.EditValue) as DataRowView).Row;
            malop = dr["MaLop"].ToString();
            flag_lop = true;
            if (flag_lop == true && flag_monhoc == true)
            {
                Program.diemSql.LayDSDiem(dataGridViewdshocsinhlop, searchLookUpEdittimkiemlop, malop, Program.mamonhoc);
                searchLookUpEdittimkiemlop.ReadOnly = false;
            }
        }

        private void gridLookUpEditmonhoc_EditValueChanged(object sender, EventArgs e)
        {
            var edit = sender as GridLookUpEdit;

            DataRow dr = (edit.Properties.GetRowByKeyValue(edit.EditValue) as DataRowView).Row;
            Program.mamonhoc = dr["MaMonHoc"].ToString();
            flag_monhoc = true;
            if(flag_lop== true && flag_monhoc == true)
            {
                Program.diemSql.LayDSDiem(dataGridViewdshocsinhlop, searchLookUpEdittimkiemlop, malop, Program.mamonhoc);
                searchLookUpEdittimkiemlop.ReadOnly = false;
            }    
        }

        private void QLDiem_Load(object sender, EventArgs e)
        {
            List<string> list_malop = Program.diemSql.LayDSLop(gridLookUpEditlop);
            List<string> list_mamonhoc = Program.diemSql.LayDSMonHoc(gridLookUpEditmonhoc);
        }

        private void getDataFromDgvIntoTextBox(TextBox tb, int row, string column)
        {
            tb.Text = dataGridViewdshocsinhlop.Rows[row].Cells[column].Value.ToString();
        }

        private void dataGridViewdshocsinhlop_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            getDataFromDgvIntoTextBox(textBoxmahs, numrow, "MaHocSinh");
            getDataFromDgvIntoTextBox(textBoxhotenhs, numrow, "HoTenHS");
            object obj = dataGridViewdshocsinhlop.Rows[numrow].Cells["NgaySinh"].Value;
            DateTime dateTime = (DateTime)obj;
            textBoxngaysinh.Text = dateTime.ToString("dd/MM/yyyy");
            getDataFromDgvIntoTextBox(textBoxgioitinh, numrow, "GioiTinh");
            getDataFromDgvIntoTextBox(textBoxdiemmieng, numrow, "DiemMieng");
            getDataFromDgvIntoTextBox(textBoxdiem15phut, numrow, "Diem15Phut");
            getDataFromDgvIntoTextBox(textBoxdiem1tiet, numrow, "Diem1Tiet");
            getDataFromDgvIntoTextBox(textBoxdiemhk, numrow, "DiemHocKi");
            getDataFromDgvIntoTextBox(textBoxdtbmon, numrow, "DiemTrungBinhMon");
            Program.diem = new Object.Diem(Convert.ToInt32(textBoxmahs.Text), textBoxhotenhs.Text,textBoxngaysinh.Text,textBoxgioitinh.Text,
                Program.mamonhoc, Convert.ToDouble(textBoxdiemmieng.Text), Convert.ToDouble(textBoxdiem15phut.Text), 
                Convert.ToDouble(textBoxdiem1tiet.Text), Convert.ToDouble(textBoxdiemhk.Text), Convert.ToDouble(textBoxdtbmon.Text));
        }

        private void dataGridViewdshocsinhlop_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dataGridViewdshocsinhlop.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }

        private void searchLookUpEdittimkiemlop_EditValueChanged(object sender, EventArgs e)
        {
            searchLookUpEdittimkiemlop.Text = "";
            var view = searchLookUpEdittimkiemlop.Properties.View;
            int row = view.FocusedRowHandle;
            object valueMaHocSinh = view.GetRowCellValue(row, "MaHocSinh");
            object valueHoTenHS = view.GetRowCellValue(row, "HoTenHS");
            object valueNgaySinh = view.GetRowCellValue(row, "NgaySinh");
            object valueGioiTinh = view.GetRowCellValue(row, "GioiTinh");
            object valueDiemMieng = view.GetRowCellValue(row, "DiemMieng");
            object valueDiem15Phut = view.GetRowCellValue(row, "Diem15Phut");
            object valueDiem1Tiet = view.GetRowCellValue(row, "Diem1Tiet");
            object valueDiemHocKi = view.GetRowCellValue(row, "DiemHocKi");
            object valueDiemTrungBinhMon = view.GetRowCellValue(row, "DiemTrungBinhMon");

            textBoxmahs.Text = valueMaHocSinh.ToString();
            textBoxhotenhs.Text = valueHoTenHS.ToString();
            textBoxngaysinh.Text = valueNgaySinh.ToString();
            textBoxgioitinh.Text = valueGioiTinh.ToString();
            textBoxdiemmieng.Text = valueDiemMieng.ToString();
            textBoxdiem15phut.Text = valueDiem15Phut.ToString();
            textBoxdiem1tiet.Text = valueDiem1Tiet.ToString();
            textBoxdiemhk.Text = valueDiemHocKi.ToString();
            textBoxdtbmon.Text = valueDiemTrungBinhMon.ToString();

        }
    }
}