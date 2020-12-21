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
    public partial class FrmThongTinGiaDinh : Form
    {
        BindingSource list = new BindingSource();
        public FrmThongTinGiaDinh()
        {
            InitializeComponent();
            dgrGiaDinh.DataSource = list;
            LoadcboNhanVien();
            LoadcboChucVu();
            AddThanNhanBinding();
        }
        void LoadThanhNhan(int idnv)
        {
            list.DataSource = ThanNhanDAO.LoadThanNha(idnv);
        }
        void LoadcboNhanVien()
        {
            cboNhanVien.DataSource = NhanVienDAO.LoadCboNhanVien();
            cboNhanVien.DisplayMember = "HOTEN";
            cboNhanVien.ValueMember = "NHANVIENID";
        }
        void LoadcboChucVu()
        {
            cboChucVu.DataSource = ChucVuDAO.LoadChucVu();
            cboChucVu.DisplayMember = "TEN";
            cboChucVu.ValueMember = "CHUCVUID";
        }
        void AddThanNhanBinding()
        {
            txbHoTen.DataBindings.Add(new Binding("Text", dgrGiaDinh.DataSource, "HOTEN", true, DataSourceUpdateMode.Never));
            cboChucVu.DataBindings.Add(new Binding("SelectedValue", dgrGiaDinh.DataSource, "CHUCVUID", true, DataSourceUpdateMode.Never));
            cboGioiTinh.DataBindings.Add(new Binding("SelectedIndex", dgrGiaDinh.DataSource, "GIOITINH", true, DataSourceUpdateMode.Never));
        }

        private void cboNhanVien_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                int idnv = (int)cboNhanVien.SelectedValue;
                LoadThanhNhan(idnv);
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
                string hoten = txbHoTen.Text;
                int gioitinh = cboGioiTinh.SelectedIndex;
                int chucvu = (int)cboChucVu.SelectedValue;
                if (ThanNhanDAO.InsertThanNhan(idnv, hoten, gioitinh, chucvu) == 1)
                    MessageBox.Show("thành công");
                else
                    MessageBox.Show("thất bại");
                LoadThanhNhan(idnv);
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
                int idtn = Convert.ToInt32(grvGiaDinh.GetFocusedDataRow()["THANNHANID"].ToString());
                int idnv = (int)cboNhanVien.SelectedValue;
                string hoten = txbHoTen.Text;
                int gioitinh = cboGioiTinh.SelectedIndex;
                int chucvu = (int)cboChucVu.SelectedValue;
                if (ThanNhanDAO.UpdateThanNhan(idtn, idnv, hoten, gioitinh, chucvu) == 1)
                    MessageBox.Show("thành công");
                else
                    MessageBox.Show("thất bại");
                LoadThanhNhan(idnv);
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
                int idtn = Convert.ToInt32(grvGiaDinh.GetFocusedDataRow()["THANNHANID"].ToString());
                int idnv = (int)cboNhanVien.SelectedValue;
                if (ThanNhanDAO.DeleteThanNhan(idtn) == 1)
                    MessageBox.Show("thành công");
                else
                    MessageBox.Show("thất bại");
                LoadThanhNhan(idnv);
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
                dgrGiaDinh.ExportToXls(FileName);
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
