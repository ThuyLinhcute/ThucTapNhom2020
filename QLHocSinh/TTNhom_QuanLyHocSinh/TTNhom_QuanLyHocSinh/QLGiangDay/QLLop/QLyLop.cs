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

namespace TTNhom_QuanLyHocSinh.QLGiangDay.QLLop
{
    public partial class QLyLop : DevExpress.XtraEditors.XtraForm
    {
        public QLyLop()
        {
            InitializeComponent();
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            Program.opt = 1;
            TTChiTietLop ttlop = new TTChiTietLop();
            ttlop.ShowDialog();
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            Program.opt = 2;
            TTChiTietLop ttlop = new TTChiTietLop();
            ttlop.ShowDialog();
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void QLyLop_Load(object sender, EventArgs e)
        {
            LoadDataLop();
        }

        public void LoadDataLop()
        {
            Program.lopSql = new Object.LopSql();
            Program.lopSql.LayDSLop(dataGridViewDSLop, searchLookUpEdittimkiemlop);
        }

        private void getDataFromDgvIntoTextBox(TextBox tb, int row, string column)
        {
            tb.Text = dataGridViewDSLop.Rows[row].Cells[column].Value.ToString();
        }

        private void dataGridViewDSLop_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            getDataFromDgvIntoTextBox(textBoxmagv, numrow, "MaGiaoVien");
            getDataFromDgvIntoTextBox(textBoxhotengv, numrow, "HoTenGV");
            getDataFromDgvIntoTextBox(textBoxmalop, numrow, "MaLop");
            getDataFromDgvIntoTextBox(textBoxtenlop, numrow, "TenLop");
            getDataFromDgvIntoTextBox(textboxsiso, numrow, "SiSo");
            Program.lop = new Object.Lop(textBoxmalop.Text, textBoxtenlop.Text, textBoxmagv.Text, textBoxhotengv.Text, Convert.ToInt32(textboxsiso.Text));
        }

        private void dataGridViewDSLop_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dataGridViewDSLop.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }

        private void searchLookUpEdittimkiemlop_EditValueChanged(object sender, EventArgs e)
        {
            searchLookUpEdittimkiemlop.Text = "";
            var view = searchLookUpEdittimkiemlop.Properties.View;
            int row = view.FocusedRowHandle;
            string fNMaGiaoVien = "MaGiaoVien";
            string fnHoTenGV = "HoTenGV";
            string fnMaLop = "MaLop";
            string fnTenLop = "TenLop";
            string fnSiSo = "SiSo";

            object valueMaGiaoVien = view.GetRowCellValue(row, fNMaGiaoVien);
            object valueHoTenGV = view.GetRowCellValue(row, fnHoTenGV);
            object valueMaLop = view.GetRowCellValue(row, fnMaLop);
            object valueTenLop = view.GetRowCellValue(row, fnTenLop);
            object valueSiSo = view.GetRowCellValue(row, fnSiSo);

            textBoxmagv.Text = valueMaGiaoVien.ToString();
            textBoxhotengv.Text = valueHoTenGV.ToString();
            textBoxmalop.Text = valueMaLop.ToString();
            textBoxtenlop.Text = valueTenLop.ToString();
            textboxsiso.Text = valueSiSo.ToString();
        }
    }
}