using QuanLyNhanSu.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu.GUI
{
    public partial class FrmKhenThuongKiLuat : Form
    {
        BindingSource list = new BindingSource();
        public FrmKhenThuongKiLuat()
        {
            InitializeComponent();
            dtpThoiGian.DateTime = DateTime.Now;
            dgrKTKL.DataSource = list;
            LoadCboNhanVien();
            AddKTKLNhanVien();
        }
        void LoadKhenThuongKyLuat(int idnv)
        {
            list.DataSource = KhenThuongKyLuatDAO.LoadKhenThuongKyLuat(idnv);
        }
        void LoadCboNhanVien()
        {
            cboNhanVien.DataSource = NhanVienDAO.LoadCboNhanVien();
            cboNhanVien.ValueMember = "NHANVIENID";
            cboNhanVien.DisplayMember = "HOTEN";
        }
        void AddKTKLNhanVien()
        {
            cboKTKL.DataBindings.Add(new Binding("SelectedIndex", dgrKTKL.DataSource, "HINHTHUC", true, DataSourceUpdateMode.Never));
            txbNoiDung.DataBindings.Add(new Binding("Text", dgrKTKL.DataSource, "NOIDUNG", true, DataSourceUpdateMode.Never));
            dtpThoiGian.DataBindings.Add(new Binding("DateTime", dgrKTKL.DataSource, "THOIGIAN", true, DataSourceUpdateMode.Never));
        }

        private void cboNhanVien_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                int idnv = (int)cboNhanVien.SelectedValue;
                LoadKhenThuongKyLuat(idnv);
            }
            catch
            {
                return;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                int idnv = (int)cboNhanVien.SelectedValue;
                int hinhthuc = cboKTKL.SelectedIndex;
                string noidung = txbNoiDung.Text;
                DateTime thoigian = dtpThoiGian.DateTime;
                if (KhenThuongKyLuatDAO.InsertKTKL(idnv, hinhthuc, noidung, thoigian) == 1)
                    MessageBox.Show("Thành công");
                else
                    MessageBox.Show("Thất bại");
                LoadKhenThuongKyLuat(idnv);
            }
            catch
            {
                return;
            }
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                int idktkl = Convert.ToInt32(grvKTKL.GetFocusedDataRow()["KHENTHUONGKYLUATID"].ToString());
                int idnv = (int)cboNhanVien.SelectedValue;
                int hinhthuc = cboKTKL.SelectedIndex;
                string noidung = txbNoiDung.Text;
                DateTime thoigian = dtpThoiGian.DateTime;
                if (KhenThuongKyLuatDAO.UpdateKTKL(idktkl, idnv, hinhthuc, noidung, thoigian) == 1)
                    MessageBox.Show("Thành công");
                else
                    MessageBox.Show("Thất bại");
                LoadKhenThuongKyLuat(idnv);
            }
            catch
            {
                return;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int idktkl = Convert.ToInt32(grvKTKL.GetFocusedDataRow()["KHENTHUONGKYLUATID"].ToString());
                int idnv = (int)cboNhanVien.SelectedValue;
                if (KhenThuongKyLuatDAO.DeleteKTKL(idktkl) == 1)
                    MessageBox.Show("Thành công");
                else
                    MessageBox.Show("Thất bại");
                LoadKhenThuongKyLuat(idnv);
            }
            catch
            {
                return;
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Excel |*.xls";
            saveFileDialog1.Title = "Save an Excel File";
            saveFileDialog1.ShowDialog();

            string FileName = saveFileDialog1.FileName.ToString();
            try
            {
                dgrKTKL.ExportToXls(FileName);
                MessageBox.Show("Xuất file excel thành công");
            }
            catch
            {
                MessageBox.Show("Vui lòng đóng file cần ghi lại để quá trình ghi thành công");
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
