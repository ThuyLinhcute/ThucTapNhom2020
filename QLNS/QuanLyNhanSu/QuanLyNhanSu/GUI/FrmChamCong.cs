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
    public partial class FrmChamCong : Form
    {
        BindingSource list = new BindingSource();
        public FrmChamCong()
        {
            InitializeComponent();
            dgrChamCong.DataSource = list;
            dtpNgay.DateTime = DateTime.Now;
            LoadcboNhanVien();
            AddChamCongBinding();
        }
        void LoadcboNhanVien()
        {
            cboNhanVien.DataSource = NhanVienDAO.LoadCboNhanVien();
            cboNhanVien.DisplayMember = "HOTEN";
            cboNhanVien.ValueMember = "NHANVIENID";
        }
        void AddChamCongBinding()
        {
            dtpNgay.DataBindings.Add(new Binding("DateTime", dgrChamCong.DataSource, "NGAY", true, DataSourceUpdateMode.Never));
            cboLoai.DataBindings.Add(new Binding("SelectedIndex", dgrChamCong.DataSource, "LOAI", true, DataSourceUpdateMode.Never));
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                int idnv = (int)cboNhanVien.SelectedValue;
                DateTime ngay = dtpNgay.DateTime;
                int loai = cboLoai.SelectedIndex;
                if (ThongKeDAO.InsertChamCong(idnv, ngay, loai) == 1)
                    MessageBox.Show("thành công");
                else
                    MessageBox.Show("thất bại");
                list.DataSource = ThongKeDAO.LoadChamCong(idnv, cboThang.SelectedIndex + 1);
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
                int idcc = Convert.ToInt32(grvChamCong.GetFocusedDataRow()["CHAMCONGID"].ToString());
                int idnv = (int)cboNhanVien.SelectedValue;
                DateTime ngay = dtpNgay.DateTime;
                int loai = cboLoai.SelectedIndex;
                if (ThongKeDAO.UpdateChamCong(idcc, idnv, ngay, loai) == 1)
                    MessageBox.Show("thành công");
                else
                    MessageBox.Show("thất bại");
                list.DataSource = ThongKeDAO.LoadChamCong(idnv, cboThang.SelectedIndex + 1);
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
                int idcc = Convert.ToInt32(grvChamCong.GetFocusedDataRow()["CHAMCONGID"].ToString());
                int idnv = (int)cboNhanVien.SelectedValue;
                if (ThongKeDAO.DeleteChamCong(idcc) == 1)
                    MessageBox.Show("thành công");
                else
                    MessageBox.Show("thất bại");
                list.DataSource = ThongKeDAO.LoadChamCong(idnv, cboThang.SelectedIndex + 1);
            }
            catch
            {
                return;
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            int idnv = (int)cboNhanVien.SelectedValue;
            int thang = cboThang.SelectedIndex + 1;
            list.DataSource = ThongKeDAO.LoadChamCong(idnv, thang);
        }

        private void cboNhanVien_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                int idnv = (int)cboNhanVien.SelectedValue;
                int thang = cboThang.SelectedIndex + 1;
                list.DataSource = ThongKeDAO.LoadChamCong(idnv, thang);
            }
            catch
            {
                return;
            }
        }
    }
}
