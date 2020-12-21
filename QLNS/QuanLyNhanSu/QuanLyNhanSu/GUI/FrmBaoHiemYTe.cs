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
    public partial class FrmBaoHiemYTe : Form
    {
        BindingSource list = new BindingSource();
        public FrmBaoHiemYTe()
        {
            InitializeComponent();
            dtpNgayNop.DateTime = DateTime.Now;
            dgrBaoHiemYT.DataSource = list;
            LoadBaoHiemYTe();
            LoadCboNhanVien();
            AddBaoHiemYTeBinding();
        }
        void LoadBaoHiemYTe()
        {
            list.DataSource = BaoHiemYTeDAO.LoadBaoHiemYTe();
        }
        void LoadCboNhanVien()
        {
            cboNhanVien.DataSource = NhanVienDAO.LoadCboNhanVien();
            cboNhanVien.ValueMember = "NHANVIENID";
            cboNhanVien.DisplayMember = "HOTEN";
        }
        void AddBaoHiemYTeBinding()
        {
            cboNhanVien.DataBindings.Add(new Binding("SelectedValue", dgrBaoHiemYT.DataSource, "NHANVIENID", true, DataSourceUpdateMode.Never));
            txbSoThe.DataBindings.Add(new Binding("Text", dgrBaoHiemYT.DataSource, "SOTHE", true, DataSourceUpdateMode.Never));
            dtpNgayNop.DataBindings.Add(new Binding("DateTime", dgrBaoHiemYT.DataSource, "NGAYNOP", true, DataSourceUpdateMode.Never));
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                int idnv = (int)cboNhanVien.SelectedValue;
                string sothe = txbSoThe.Text;
                DateTime ngaynop = dtpNgayNop.DateTime;
                if (BaoHiemYTeDAO.InsertBaoHiemYTe(idnv, sothe, ngaynop) == 1)
                    MessageBox.Show("Thành công");
                else
                    MessageBox.Show("Thất bại");
            }
            catch
            {
                return;
            }
            LoadBaoHiemYTe();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                int idbh = Convert.ToInt32(grvBaoHiemYT.GetFocusedDataRow()["BAOHIEMYTEID"].ToString());
                int idnv = (int)cboNhanVien.SelectedValue;
                string sothe = txbSoThe.Text;
                DateTime ngaynop = dtpNgayNop.DateTime;
                if (BaoHiemYTeDAO.UpdateBaoHiemYTe(idbh, idnv, sothe, ngaynop) == 1)
                    MessageBox.Show("Thành công");
                else
                    MessageBox.Show("Thất bại");
            }
            catch
            {
                return;
            }
            LoadBaoHiemYTe();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                int idbh = Convert.ToInt32(grvBaoHiemYT.GetFocusedDataRow()["BAOHIEMYTEID"].ToString());
                if (BaoHiemYTeDAO.DeleteBaoHiemYTe(idbh) == 1)
                    MessageBox.Show("Thành công");
                else
                    MessageBox.Show("Thất bại");
            }
            catch
            {
                return;
            }
            LoadBaoHiemYTe();
        }

        private void btnXuat_Click(object sender, EventArgs e)  // đóng form
        {
            this.Close();
        }
    }
}
