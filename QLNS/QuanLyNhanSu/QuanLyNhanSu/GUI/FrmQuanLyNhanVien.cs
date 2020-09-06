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
    public partial class FrmQuanLyNhanVien : Form
    {
        BindingSource list = new BindingSource();
        public FrmQuanLyNhanVien()
        {
            InitializeComponent();
            dgrQuanLyNhanVien.DataSource = list;
            dtpNgaySinh.DateTime = DateTime.Now;
            LoadNhanVien();
            LoadcboChucVu();
            LoadcboPhongBan();
            AddNhanVienBinding();
        }
        void LoadNhanVien()
        {
            list.DataSource = NhanVienDAO.LoadNhanVien();
        }
        void LoadcboPhongBan()
        {
            cboDonVi.DataSource = PhongBanDAO.LoadPhongBan();
            cboDonVi.DisplayMember = "TEN";
            cboDonVi.ValueMember = "PHONGBANID";
        }
        void LoadcboChucVu()
        {
            cboChucVu.DataSource = ChucVuDAO.LoadChucVu();
            cboChucVu.DisplayMember = "TEN";
            cboChucVu.ValueMember = "CHUCVUID";
        }
        void AddNhanVienBinding()
        {
            txbHoTen.DataBindings.Add(new Binding("Text", dgrQuanLyNhanVien.DataSource, "HOTEN", true, DataSourceUpdateMode.Never));
            txbBiDanh.DataBindings.Add(new Binding("Text", dgrQuanLyNhanVien.DataSource, "BIDANH", true, DataSourceUpdateMode.Never));
            txbDiaChi.DataBindings.Add(new Binding("Text", dgrQuanLyNhanVien.DataSource, "DIACHI", true, DataSourceUpdateMode.Never));
            txbEmail.DataBindings.Add(new Binding("Text", dgrQuanLyNhanVien.DataSource, "EMAIL", true, DataSourceUpdateMode.Never));
            txbMaSoThua.DataBindings.Add(new Binding("Text", dgrQuanLyNhanVien.DataSource, "MASOTHUE", true, DataSourceUpdateMode.Never));
            txbSoDienThoai.DataBindings.Add(new Binding("Text", dgrQuanLyNhanVien.DataSource, "SDT", true, DataSourceUpdateMode.Never));
            txbSoTaiKhoan.DataBindings.Add(new Binding("Text", dgrQuanLyNhanVien.DataSource, "SOTKNGANHANG", true, DataSourceUpdateMode.Never));
            cboChucVu.DataBindings.Add(new Binding("SelectedValue", dgrQuanLyNhanVien.DataSource, "CHUCVUID", true, DataSourceUpdateMode.Never));
            cboDonVi.DataBindings.Add(new Binding("SelectedValue", dgrQuanLyNhanVien.DataSource, "PHONGBANID", true, DataSourceUpdateMode.Never));
            cboGioiTinh.DataBindings.Add(new Binding("SelectedIndex", dgrQuanLyNhanVien.DataSource, "GIOITINH", true, DataSourceUpdateMode.Never));
            dtpNgaySinh.DataBindings.Add(new Binding("DateTime", dgrQuanLyNhanVien.DataSource, "NGAYSINH", true, DataSourceUpdateMode.Never));
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string hoten = txbHoTen.Text;
                string bidanh = txbBiDanh.Text;
                string diachi = txbDiaChi.Text;
                DateTime ngaysinh = dtpNgaySinh.DateTime;
                string masothue = txbMaSoThua.Text;
                int gioitinh = cboGioiTinh.SelectedIndex;
                string sotknganhang = txbSoTaiKhoan.Text;
                string sdt = txbSoDienThoai.Text;
                string email = txbEmail.Text;
                int chucvuid = (int)cboChucVu.SelectedValue;
                int phongbanid = (int)cboDonVi.SelectedValue;
                if (NhanVienDAO.InsertNhanVien(hoten, bidanh, diachi, ngaysinh, masothue, gioitinh, sotknganhang, sdt, email, chucvuid, phongbanid) == 1)
                    MessageBox.Show("thành công");
                else
                    MessageBox.Show("thất bại");
            }
            catch
            {
                return;
            }
            LoadNhanVien();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                int nhanvienid = Convert.ToInt32(grvQuanLyNhanVien.GetFocusedDataRow()["NHANVIENID"].ToString());
                string hoten = txbHoTen.Text;
                string bidanh = txbBiDanh.Text;
                string diachi = txbDiaChi.Text;
                DateTime ngaysinh = dtpNgaySinh.DateTime;
                string masothue = txbMaSoThua.Text;
                int gioitinh = cboGioiTinh.SelectedIndex;
                string sotknganhang = txbSoTaiKhoan.Text;
                string sdt = txbSoDienThoai.Text;
                string email = txbEmail.Text;
                int chucvuid = (int)cboChucVu.SelectedValue;
                int phongbanid = (int)cboDonVi.SelectedValue;
                if (NhanVienDAO.UpdateNhanVien(nhanvienid, hoten, bidanh, diachi, ngaysinh, masothue, gioitinh, sotknganhang, sdt, email, chucvuid, phongbanid) == 1)
                    MessageBox.Show("thành công");
                else
                    MessageBox.Show("thất bại");
            }
            catch
            {
                return;
            }
            LoadNhanVien();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int nhanvienid = Convert.ToInt32(grvQuanLyNhanVien.GetFocusedDataRow()["NHANVIENID"].ToString());
                if (NhanVienDAO.DeleteNhanVien(nhanvienid) == 1)
                    MessageBox.Show("thành công");
                else
                    MessageBox.Show("thất bại");
            }
            catch
            {
                return;
            }
            LoadNhanVien();
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
                dgrQuanLyNhanVien.ExportToXls(FileName);
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
