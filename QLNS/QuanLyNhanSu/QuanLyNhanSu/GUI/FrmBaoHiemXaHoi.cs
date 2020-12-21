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
    public partial class FrmBaoHiemXaHoi : Form
    {
        BindingSource list = new BindingSource();
        public FrmBaoHiemXaHoi()
        {
            InitializeComponent();
            dtpNgayNop.DateTime = DateTime.Now;
            dgrBaoHiemXH.DataSource = list;
            LoadBaoHiemXaHoi();
            LoadcboNhanVien();
            AddBindingBaoHiemXaHoi();
        }
        void LoadBaoHiemXaHoi()
        {
            list.DataSource = BaoHiemXaHoiDAO.LoadBaoHiemXaHoi();
        }
        void LoadcboNhanVien()
        {
            cboNhanVien.DataSource = NhanVienDAO.LoadCboNhanVien();
            cboNhanVien.ValueMember = "NHANVIENID";
            cboNhanVien.DisplayMember = "HOTEN";
        }
        void AddBindingBaoHiemXaHoi()
        {
            cboNhanVien.DataBindings.Add(new Binding("SelectedValue", dgrBaoHiemXH.DataSource, "NHANVIENID", true, DataSourceUpdateMode.Never));
            txbSoTien.DataBindings.Add(new Binding("Text", dgrBaoHiemXH.DataSource, "SOTIEN", true, DataSourceUpdateMode.Never));
            dtpNgayNop.DataBindings.Add(new Binding("DateTime", dgrBaoHiemXH.DataSource, "NGAYNOP", true, DataSourceUpdateMode.Never));
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                int idnv = (int)cboNhanVien.SelectedValue;
                int sotien = Convert.ToInt32(txbSoTien.Text);
                DateTime ngaynop = dtpNgayNop.DateTime;
                if (BaoHiemXaHoiDAO.InsertBaoHiemXaHoi(idnv, sotien, ngaynop) == 1)
                    MessageBox.Show("Thành công");
                else
                    MessageBox.Show("Thất bại");
            }
            catch
            {
                return;
            }
            LoadBaoHiemXaHoi();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                int idbh = Convert.ToInt32(grvBaoHiemXH.GetFocusedDataRow()["BAOHIEMXAHOIID"].ToString());
                int idnv = (int)cboNhanVien.SelectedValue;
                int sotien = Convert.ToInt32(txbSoTien.Text);
                DateTime ngaynop = dtpNgayNop.DateTime;
                if (BaoHiemXaHoiDAO.UpdateBaoHiemXaHoi(idbh, idnv, sotien, ngaynop) == 1)
                    MessageBox.Show("Thành công");
                else
                    MessageBox.Show("Thất bại");
            }
            catch
            {
                return;
            }
            LoadBaoHiemXaHoi();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int idbh = Convert.ToInt32(grvBaoHiemXH.GetFocusedDataRow()["BAOHIEMXAHOIID"].ToString());
                if (BaoHiemXaHoiDAO.DeleteBaoHiemXaHoi(idbh) == 1)
                    MessageBox.Show("Thành công");
                else
                    MessageBox.Show("Thất bại");
            }
            catch
            {
                return;
            }
            LoadBaoHiemXaHoi();
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
