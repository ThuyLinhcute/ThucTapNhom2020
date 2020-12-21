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
    public partial class FrmBangCap : Form
    {
        BindingSource list = new BindingSource();
        public FrmBangCap()
        {
            InitializeComponent();
            dtpThoiGian.DateTime = DateTime.Now;
            dgrBangCap.DataSource = list;
            LoadcboNhanVien();
            AddBangCapBinding();
        }
        void LoadBangCap(int idnv)
        {
            list.DataSource = BangCapDAO.LoadBangCap(idnv);
        }
        void LoadcboNhanVien()
        {
            cboBangCap.DataSource = NhanVienDAO.LoadCboNhanVien();
            cboBangCap.DisplayMember = "HOTEN";
            cboBangCap.ValueMember = "NHANVIENID";
        }
        void AddBangCapBinding()
        {
            dtpThoiGian.DataBindings.Add(new Binding("DateTime", dgrBangCap.DataSource, "THOIGIAN", true, DataSourceUpdateMode.Never));
            txbBangCap.DataBindings.Add(new Binding("Text", dgrBangCap.DataSource, "CHITIETBANGCAP", true, DataSourceUpdateMode.Never));
            txbTrinhDoHocvan.DataBindings.Add(new Binding("Text", dgrBangCap.DataSource, "TRINHDOHOCVAN", true, DataSourceUpdateMode.Never));
        }

        private void cboBangCap_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                int idnv = (int)cboBangCap.SelectedValue;
                LoadBangCap(idnv);
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
                int idnv = (int)cboBangCap.SelectedValue;
                string trinhdohocvan = txbTrinhDoHocvan.Text;
                DateTime thoigian = dtpThoiGian.DateTime;
                string chitiet = txbBangCap.Text;
                if (BangCapDAO.InsertBangCap(idnv, trinhdohocvan, thoigian, chitiet) == 1)
                    MessageBox.Show("thành công");
                else
                    MessageBox.Show("thất bại");
                LoadBangCap(idnv);
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
                int idbangcap = Convert.ToInt32(grvBangCap.GetFocusedDataRow()["BANGCAPID"].ToString());
                int idnv = (int)cboBangCap.SelectedValue;
                string trinhdohocvan = txbTrinhDoHocvan.Text;
                DateTime thoigian = dtpThoiGian.DateTime;
                string chitiet = txbBangCap.Text;
                if (BangCapDAO.UpdateBangCap(idbangcap, idnv, trinhdohocvan, thoigian, chitiet) == 1)
                    MessageBox.Show("thành công");
                else
                    MessageBox.Show("thất bại");
                LoadBangCap(idnv);
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
                int idbangcap = Convert.ToInt32(grvBangCap.GetFocusedDataRow()["BANGCAPID"].ToString());
                int idnv = (int)cboBangCap.SelectedValue;
                if (BangCapDAO.DeleteBangCap(idbangcap) == 1)
                    MessageBox.Show("thành công");
                else
                    MessageBox.Show("thất bại");
                LoadBangCap(idnv);
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
                dgrBangCap.ExportToXls(FileName);
                MessageBox.Show("Xuất file excel thành công");
            }
            catch
            {
                MessageBox.Show("Vui lòng đóng file cần ghi lại để quá trình ghi thành công");
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
