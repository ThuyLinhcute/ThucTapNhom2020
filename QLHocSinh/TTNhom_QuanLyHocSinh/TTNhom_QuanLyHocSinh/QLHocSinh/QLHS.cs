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
    public partial class QLHS : DevExpress.XtraEditors.XtraForm
    {
        
        public QLHS()
        {
            InitializeComponent();
        }

        private void buttonThem_Click(object sender, EventArgs e)
        {
            Program.opt = 1; 
            ThongTinChiTietHS themHS = new ThongTinChiTietHS();
            themHS.ShowDialog();
        }

        private void buttonSua_Click(object sender, EventArgs e)
        {
            Program.opt = 2;
            ThongTinChiTietHS themHS = new ThongTinChiTietHS();
            themHS.ShowDialog();
        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn xoá thông tin này", "Question message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                bool kq = Program.hocSinhSql.Xoa_HS(Convert.ToInt32(textBoxmahs.Text));
                if(kq) // xoa thanh cong
                {
                    DialogResult result2 = MessageBox.Show("Xoá thông tin thành công", "Notice message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (result2 == DialogResult.OK)
                    {
                        //Program.quanLyChung.barButtonItemQLHocSinh_ItemClick(null, null);
                    }
                }   
            }
        }

        private void buttonThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void QLHS_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        public void LoadData()
        {
            Program.hocSinhSql = new Object.HocSinhSql();
            Program.hocSinhSql.LayDSHocSinh(dataGridViewDSHocSinh, searchLookUpEdittimkiemhocsinh);
        }    
        private void getDataFromDgvIntoTextBox(TextBox tb, int row, string column)
        {
            tb.Text = dataGridViewDSHocSinh.Rows[row].Cells[column].Value.ToString();
        }

        private void dataGridViewDSHocSinh_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            int numrow;
            numrow = e.RowIndex;
            getDataFromDgvIntoTextBox(textBoxmahs, numrow, "MaHocSinh");
            getDataFromDgvIntoTextBox(textBoxhotenhs, numrow, "HoTenHS");
            getDataFromDgvIntoTextBox(textBoxmalop, numrow, "MaLop");
            object obj = dataGridViewDSHocSinh.Rows[numrow].Cells["NgaySinh"].Value;
            DateTime dateTime = (DateTime)obj;
            textBoxngaysinh.Text = dateTime.ToString("dd/MM/yyyy");
            getDataFromDgvIntoTextBox(textBoxhotenphuhuynh, numrow, "HoTenPhuHuynh");
            getDataFromDgvIntoTextBox(textBoxsdtphuhuynh, numrow, "SDTPhuHuynh");
            getDataFromDgvIntoTextBox(textBoxdiachi, numrow, "DiaChi");
            getDataFromDgvIntoTextBox(textBoxdantoc, numrow, "DanToc");
            getDataFromDgvIntoTextBox(textBoxgioitinh, numrow, "GioiTinh");
            getDataFromDgvIntoTextBox(textBoxnamnhaphoc, numrow, "NamNhapHoc");
            Program.hs = new HocSinh(Convert.ToInt32(textBoxmahs.Text),textBoxmalop.Text,textBoxhotenhs.Text,dateTime,textBoxdiachi.Text,textBoxgioitinh.Text,
                textBoxdantoc.Text,textBoxhotenphuhuynh.Text,textBoxsdtphuhuynh.Text,Convert.ToInt32(textBoxnamnhaphoc.Text));
        }

        private void dataGridViewDSHocSinh_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dataGridViewDSHocSinh.Rows[e.RowIndex].Cells["STT"].Value = e.RowIndex + 1;
        }

        private void searchLookUpEdittimkiemhocsinh_EditValueChanged(object sender, EventArgs e)
        {
            searchLookUpEdittimkiemhocsinh.Text = "";
            var view = searchLookUpEdittimkiemhocsinh.Properties.View;
            int row = view.FocusedRowHandle;
            string fnMaHocSinh = "MaHocSinh";
            string fnMaLop = "MaLop";
            string fnHoTenHS = "HoTenHS";
            string fnNgaySinh = "NgaySinh";
            string fnDiaChi = "DiaChi";
            string fnGioiTinh = "GioiTinh";
            string fnDanToc = "DanToc";
            string fnHoTenPhuHuynh = "HoTenPhuHuynh";
            string fnSDTPhuHuynh = "SDTPhuHuynh";
            string fnNamNhapHoc = "NamNhapHoc";

            object valueMaHocSinh = view.GetRowCellValue(row, fnMaHocSinh);
            object valueMaLop = view.GetRowCellValue(row, fnMaLop);
            object valueHoTenHS = view.GetRowCellValue(row, fnHoTenHS);
            object valueNgaySinh = view.GetRowCellValue(row, fnNgaySinh);
            object valueDiaChi = view.GetRowCellValue(row, fnDiaChi);
            object valueGioiTinh = view.GetRowCellValue(row, fnGioiTinh);
            object valueDanToc = view.GetRowCellValue(row, fnDanToc);
            object valueHoTenPhuHuynh = view.GetRowCellValue(row, fnHoTenPhuHuynh);
            object valueSDTPhuHuynh = view.GetRowCellValue(row, fnSDTPhuHuynh);
            object valueNamNhapHoc = view.GetRowCellValue(row, fnNamNhapHoc);

            textBoxmahs.Text = valueMaHocSinh.ToString();
            textBoxmalop.Text = valueMaLop.ToString();
            textBoxhotenhs.Text = valueHoTenHS.ToString();
            textBoxngaysinh.Text = valueNgaySinh.ToString();
            textBoxdiachi.Text = valueDiaChi.ToString();
            textBoxgioitinh.Text = valueGioiTinh.ToString();
            textBoxdantoc.Text = valueDanToc.ToString();
            textBoxhotenphuhuynh.Text = valueHoTenPhuHuynh.ToString();
            textBoxsdtphuhuynh.Text = valueSDTPhuHuynh.ToString();
            textBoxnamnhaphoc.Text = valueNamNhapHoc.ToString();
        }
    }
}