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
    public partial class FrmQuanLyPhongBan : Form
    {
        BindingSource list = new BindingSource();
        public FrmQuanLyPhongBan()
        {
            InitializeComponent();
            dgrPhongBan.DataSource = list;
            LoadPhongBan();
            AddBindingPhongBan();
        }
        void LoadPhongBan()
        {
            list.DataSource = PhongBanDAO.LoadPhongBan();
        }
        void AddBindingPhongBan()
        {
            txbTenPhogBan.DataBindings.Add(new Binding("Text", dgrPhongBan.DataSource, "TEN", true, DataSourceUpdateMode.Never));
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string tenpb = txbTenPhogBan.Text;

            if (PhongBanDAO.InsertPhongBan(tenpb) == 1)
            {
                MessageBox.Show("Thành Công");
            }
            else
                MessageBox.Show("Thất Bại");
            LoadPhongBan();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int idpb = Convert.ToInt32(grvPhongBan.GetFocusedDataRow()["PHONGBANID"].ToString());
            string tenpb = txbTenPhogBan.Text;

            if (PhongBanDAO.UpdatePhongBan(idpb, tenpb) == 1)
            {
                MessageBox.Show("Thành Công");
            }
            else
                MessageBox.Show("Thất Bại");
            LoadPhongBan();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int idpb = Convert.ToInt32(grvPhongBan.GetFocusedDataRow()["PHONGBANID"].ToString());

            if (PhongBanDAO.DeletePhongBan(idpb) == 1)
            {
                MessageBox.Show("Thành Công");
            }
            else
                MessageBox.Show("Thất Bại");
            LoadPhongBan();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
