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
    public partial class FrmQuaTrinhHocTap : Form
    {
        BindingSource list = new BindingSource();
        public FrmQuaTrinhHocTap()
        {
            InitializeComponent();
            dgrQuaTrinhHocTap.DataSource = list;
            dtpBatDau.DateTime = DateTime.Now;
            dtpKetThuc.DateTime = DateTime.Now;
            LoadcboNhanVien();
            AddQuaTrinhHocTapBinding();
        }
        void LoadQuaTrinhHocTap(int idnv)
        {
            list.DataSource = QuaTrinhHocTapDAO.LoadQuaTrinhHocTap(idnv);
        }
        void LoadcboNhanVien()
        {
            cboQuaTrinhHocTap.DataSource = NhanVienDAO.LoadCboNhanVien();
            cboQuaTrinhHocTap.DisplayMember = "HOTEN";
            cboQuaTrinhHocTap.ValueMember = "NHANVIENID";
        }
        void AddQuaTrinhHocTapBinding()
        {
            dtpBatDau.DataBindings.Add(new Binding("DateTime", dgrQuaTrinhHocTap.DataSource, "THOIGIANBATDAU", true, DataSourceUpdateMode.Never));
            dtpKetThuc.DataBindings.Add(new Binding("DateTime", dgrQuaTrinhHocTap.DataSource, "THOIGIANKETTHUC", true, DataSourceUpdateMode.Never));
            txbNoiDung.DataBindings.Add(new Binding("Text", dgrQuaTrinhHocTap.DataSource, "NOIDUNGHOCTAP", true, DataSourceUpdateMode.Never));
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                int idnv = (int)cboQuaTrinhHocTap.SelectedValue;
                DateTime tgbatdau = dtpBatDau.DateTime;
                DateTime tgketthuc = dtpKetThuc.DateTime;
                string noidung = txbNoiDung.Text;
                if (QuaTrinhHocTapDAO.InsertQTHT(idnv, tgbatdau, tgketthuc, noidung) == 1)
                    MessageBox.Show("thành công");
                else
                    MessageBox.Show("thất bại");
                LoadQuaTrinhHocTap(idnv);
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
                int idqtht = Convert.ToInt32(grvQuaTrinhhocTap.GetFocusedDataRow()["QUATRINHOCTAPID"].ToString());
                int idnv = (int)cboQuaTrinhHocTap.SelectedValue;
                DateTime tgbatdau = dtpBatDau.DateTime;
                DateTime tgketthuc = dtpKetThuc.DateTime;
                string noidung = txbNoiDung.Text;
                if (QuaTrinhHocTapDAO.UpdateQTHT(idqtht, idnv, tgbatdau, tgketthuc, noidung) == 1)
                    MessageBox.Show("thành công");
                else
                    MessageBox.Show("thất bại");
                LoadQuaTrinhHocTap(idnv);
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
                int idqtht = Convert.ToInt32(grvQuaTrinhhocTap.GetFocusedDataRow()["QUATRINHOCTAPID"].ToString());
                int idnv = (int)cboQuaTrinhHocTap.SelectedValue;
                if (QuaTrinhHocTapDAO.DeleteQTHT(idqtht) == 1)
                    MessageBox.Show("thành công");
                else
                    MessageBox.Show("thất bại");
                LoadQuaTrinhHocTap(idnv);
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

        private void cboQuaTrinhHocTap_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                int idnv = (int)cboQuaTrinhHocTap.SelectedValue;
                LoadQuaTrinhHocTap(idnv);
            }
            catch
            {
                return;
            }
        }
    }
}
