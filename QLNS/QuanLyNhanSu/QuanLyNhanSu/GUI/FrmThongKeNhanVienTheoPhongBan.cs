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
    public partial class FrmThongKeNhanVienTheoPhongBan : Form
    {
        public FrmThongKeNhanVienTheoPhongBan()
        {
            InitializeComponent();
            LoadcboChucVu();
            LoadcboPhongBan();
        }
        void LoadcboPhongBan()
        {
            cboPhongBan.DataSource = PhongBanDAO.LoadPhongBan();
            cboPhongBan.DisplayMember = "TEN";
            cboPhongBan.ValueMember = "PHONGBANID";
        }
        void LoadcboChucVu()
        {
            cboChucVu.DataSource = ChucVuDAO.LoadChucVu();
            cboChucVu.DisplayMember = "TEN";
            cboChucVu.ValueMember = "CHUCVUID";
        }

        private void btnThongKePhongBan_Click(object sender, EventArgs e)
        {
            try
            {
                int idpb = (int)cboPhongBan.SelectedValue;
                dgrThongKeSinhNhat.DataSource = ThongKeDAO.ThongKeNVTheoPhongBan(idpb);
            }
            catch
            {
                return;
            }
        }

        private void btnThongKeChucVu_Click(object sender, EventArgs e)
        {
            try
            {
                int idcv = (int)cboChucVu.SelectedValue;
                dgrThongKeSinhNhat.DataSource = ThongKeDAO.ThongKeNVTheoChucVu(idcv);
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
                dgrThongKeSinhNhat.ExportToXls(FileName);
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
