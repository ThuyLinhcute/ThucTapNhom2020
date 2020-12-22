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
    public partial class FrmThongKeNhanVienSapNghiHuu : Form
    {
        public FrmThongKeNhanVienSapNghiHuu()
        {
            InitializeComponent();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            if (rbtnNhanVienSapNghiHuu.Checked == true)
                dgrThongKeSinhNhat.DataSource = ThongKeDAO.ThongKeNghiHuu(DateTime.Now);
            else
                dgrThongKeSinhNhat.DataSource = ThongKeDAO.ThongKeNVMoi(DateTime.Now);
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            // SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            // saveFileDialog1.Filter = "Excel |*.xls";
            // saveFileDialog1.Title = "Save an Excel File";
            // saveFileDialog1.ShowDialog();

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

        private void rbtnNhanVienMoi_CheckedChanged(object sender, EventArgs e)
        {

        }

          private void FrmThongKeNhanVienSapNghiHuu_Load(object sender, EventArgs e)
          {

          }
     }
}
