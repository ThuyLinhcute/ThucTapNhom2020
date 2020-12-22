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
    public partial class QLGV : DevExpress.XtraEditors.XtraForm
    {
        public QLGV()
        {
            InitializeComponent();
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            Program.opt = 1;
            ThongTinChiTietGV thongTinChiTietGV = new ThongTinChiTietGV();
            thongTinChiTietGV.ShowDialog();
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            Program.opt = 2;
            ThongTinChiTietGV thongTinChiTietGV = new ThongTinChiTietGV();
            thongTinChiTietGV.ShowDialog();
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn xoá thông tin này", "Question message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                bool kq = Program.giaoVienSql.Xoa_GV(textBoxmagv.Text);
                if (kq) // xoa thanh cong
                {
                    DialogResult result2 = MessageBox.Show("Xoá thông tin thành công", "Notice message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (result2 == DialogResult.OK)
                    {
                        this.Close();
                        Program.qLGV = new QLGV();
                        Program.qLGV.Refresh();
                        Program.quanLyChung.barButtonItemGiaoVien_ItemClick(sender as QLGV, null);
                    }
                }
            }
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void QLGV_Load(object sender, EventArgs e)
        {
            LoadDataGV();
        }

        public void LoadDataGV()
        {
            Program.giaoVienSql = new Object.GiaoVienSql();
            Program.giaoVienSql.LayDSGiaoVien(dataGridViewDSGiaoVien, searchLookUpEdittimkiemgiaovien);
        }
        private void getDataFromDgvIntoTextBox(TextBox tb, int row, string column)
        {
            tb.Text = dataGridViewDSGiaoVien.Rows[row].Cells[column].Value.ToString();
        }

        private void dataGridViewDSGiaoVien_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            getDataFromDgvIntoTextBox(textBoxmagv, numrow, "MaGiaoVien");
            getDataFromDgvIntoTextBox(textBoxhotengv, numrow, "HoTenGV");
            object obj = dataGridViewDSGiaoVien.Rows[numrow].Cells["NgaySinh"].Value;
            DateTime NS = (DateTime)obj;
            textBoxngaysinh.Text = NS.ToString("dd/MM/yyyy");
            getDataFromDgvIntoTextBox(textBoxgioitinh, numrow, "GioiTinh");
            getDataFromDgvIntoTextBox(textBoxdiachi, numrow, "DiaChi");
            getDataFromDgvIntoTextBox(textBoxluong, numrow, "Luong");
            object obj2 = dataGridViewDSGiaoVien.Rows[numrow].Cells["NgayVaoLam"].Value;
            DateTime NVL = (DateTime)obj2;
            textBoxngayvaolam.Text = NVL.ToString("dd/MM/yyyy");
            getDataFromDgvIntoTextBox(textBoxchucvu, numrow, "ChucVu");
            Program.gv = new GiaoVien(textBoxmagv.Text, textBoxhotengv.Text, textBoxgioitinh.Text, NS, textBoxdiachi.Text,
                Convert.ToInt32(textBoxluong.Text), NVL, textBoxchucvu.Text);
        }

        private void dataGridViewDSGiaoVien_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dataGridViewDSGiaoVien.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }

        private void searchLookUpEdittimkiemgiaovien_EditValueChanged(object sender, EventArgs e)
        {
            searchLookUpEdittimkiemgiaovien.Text = "";
            var view = searchLookUpEdittimkiemgiaovien.Properties.View;
            int row = view.FocusedRowHandle;
            string fNMaGiaoVien = "MaGiaoVien";
            string fnHoTenGV = "HoTenGV";
            string fnGioiTinh = "GioiTinh";
            string fnNgaySinh = "NgaySinh";
            string fnDiaChi = "DiaChi";
            string fnLuong = "Luong";
            string fnNgayVaoLam = "NgayVaoLam";
            string fnChucVu = "ChucVu";

            object valueMaGiaoVien = view.GetRowCellValue(row, fNMaGiaoVien);
            object valueHoTenGV = view.GetRowCellValue(row, fnHoTenGV);
            object valueGioiTinh = view.GetRowCellValue(row, fnGioiTinh);
            object valueNgaySinh = view.GetRowCellValue(row, fnNgaySinh);
            object valueDiaChi = view.GetRowCellValue(row, fnDiaChi);
            object valueLuong = view.GetRowCellValue(row, fnLuong);
            object valueNgayVaoLam = view.GetRowCellValue(row, fnNgayVaoLam);
            object valueChucVu = view.GetRowCellValue(row, fnChucVu);

            textBoxmagv.Text = valueMaGiaoVien.ToString();
            textBoxhotengv.Text = valueHoTenGV.ToString();
            textBoxgioitinh.Text = valueGioiTinh.ToString();
            textBoxngaysinh.Text = valueNgaySinh.ToString();
            textBoxdiachi.Text = valueDiaChi.ToString();
            textBoxluong.Text = valueLuong.ToString();
            textBoxngayvaolam.Text = valueNgayVaoLam.ToString();
            textBoxchucvu.Text = valueChucVu.ToString();
        }
    }
}