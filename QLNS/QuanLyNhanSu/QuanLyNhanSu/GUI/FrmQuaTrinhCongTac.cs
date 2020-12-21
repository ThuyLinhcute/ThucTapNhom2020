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
    public partial class FrmQuaTrinhCongTac : Form
    {
        BindingSource list = new BindingSource();
        public FrmQuaTrinhCongTac()
        {
            InitializeComponent();
            dgrQuaTrinhCongTac.DataSource = list;
            dtpBatDau.DateTime = DateTime.Now;
            dtpKetThuc.DateTime = DateTime.Now;
            LoadcboNhanVien();
            AddQuaTrinhCongTacBinding();
        }
        void LoadQuaTrinhCongTac(int idnv)
        {
            list.DataSource = QuaTrinhCongTacDAO.LoadQuaTrinhCongTac(idnv);
        }
        void LoadcboNhanVien()
        {
            cboQuaTrinhCongTac.DataSource = NhanVienDAO.LoadCboNhanVien();
            cboQuaTrinhCongTac.DisplayMember = "HOTEN";
            cboQuaTrinhCongTac.ValueMember = "NHANVIENID";
        }
        void AddQuaTrinhCongTacBinding()
        {
            dtpBatDau.DataBindings.Add(new Binding("DateTime", dgrQuaTrinhCongTac.DataSource, "THOIGIANBATDAU", true, DataSourceUpdateMode.Never));
            dtpKetThuc.DataBindings.Add(new Binding("DateTime", dgrQuaTrinhCongTac.DataSource, "THOIGIANKETTHUC", true, DataSourceUpdateMode.Never));
            txbNoiDung.DataBindings.Add(new Binding("Text", dgrQuaTrinhCongTac.DataSource, "NOIDUNGCONGTAC", true, DataSourceUpdateMode.Never));
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                int idnv = (int)cboQuaTrinhCongTac.SelectedValue;
                DateTime tgbatdau = dtpBatDau.DateTime;
                DateTime tgketthuc = dtpKetThuc.DateTime;
                string noidung = txbNoiDung.Text;
                if (QuaTrinhCongTacDAO.InsertQTCT(idnv, tgbatdau, tgketthuc, noidung) == 1)
                    MessageBox.Show("thành công");
                else
                    MessageBox.Show("thất bại");
                LoadQuaTrinhCongTac(idnv);
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
                int idquatrinh = Convert.ToInt32(grvQuaTrinhCongTac.GetFocusedDataRow()["QUATRINHCONGTACID"].ToString());
                int idnv = (int)cboQuaTrinhCongTac.SelectedValue;
                DateTime tgbatdau = dtpBatDau.DateTime;
                DateTime tgketthuc = dtpKetThuc.DateTime;
                string noidung = txbNoiDung.Text;
                if (QuaTrinhCongTacDAO.UpdateQTCT(idquatrinh, idnv, tgbatdau, tgketthuc, noidung) == 1)
                    MessageBox.Show("thành công");
                else
                    MessageBox.Show("thất bại");
                LoadQuaTrinhCongTac(idnv);
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
                int idnv = (int)cboQuaTrinhCongTac.SelectedValue;
                int idquatrinh = Convert.ToInt32(grvQuaTrinhCongTac.GetFocusedDataRow()["QUATRINHCONGTACID"].ToString());
                if (QuaTrinhCongTacDAO.DeleteQTCT(idquatrinh) == 1)
                    MessageBox.Show("thành công");
                else
                    MessageBox.Show("thất bại");
                LoadQuaTrinhCongTac(idnv);
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
                dgrQuaTrinhCongTac.ExportToXls(FileName);
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

        private void cboQuaTrinhCongTac_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                int idnv = (int)cboQuaTrinhCongTac.SelectedValue;
                LoadQuaTrinhCongTac(idnv);
            }
            catch
            {
                return;
            }
        }
    }
}
