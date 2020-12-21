using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu.DAO
{
    public partial class FrmQuanLyChucVu : Form
    {
        BindingSource list = new BindingSource();
        public FrmQuanLyChucVu()
        {
            InitializeComponent();
            dgrQuanLyChucVu.DataSource = list;
            LoadChucVu();
            AddChucVuBinding();
        }
        void LoadChucVu()
        {
            list.DataSource = ChucVuDAO.LoadChucVu();
        }
        void AddChucVuBinding()
        {
            txbTenChucVu.DataBindings.Add(new Binding("Text", dgrQuanLyChucVu.DataSource, "TEN", true, DataSourceUpdateMode.Never));
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string tencv = txbTenChucVu.Text;

            if (ChucVuDAO.InsertChucVu(tencv) == 1)
            {
                MessageBox.Show("Thành công");
            }
            else
                MessageBox.Show("Thất bại");
            LoadChucVu();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int idcv = Convert.ToInt32(grvQuanLyChucVu.GetFocusedDataRow()["CHUCVUID"].ToString());
            string tencv = txbTenChucVu.Text;

            if (ChucVuDAO.UpdateChucVu(idcv, tencv) == 1)
            {
                MessageBox.Show("Thành công");
            }
            else
                MessageBox.Show("Thất bại");
            LoadChucVu();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int idcv = Convert.ToInt32(grvQuanLyChucVu.GetFocusedDataRow()["CHUCVUID"].ToString());

            if (ChucVuDAO.DeleteChucVu(idcv) == 1)
            {
                MessageBox.Show("Thành công");
            }
            else
                MessageBox.Show("Thất bại");
            LoadChucVu();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmQuanLyChucVu_Load(object sender, EventArgs e)
        {

        }
    }
}
