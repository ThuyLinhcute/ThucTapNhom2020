using BanHangSieuTHi.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BanHangSieuTHi
{
    public partial class frmBanHang2 : Form
    {
        public frmBanHang2()
        {
            // InitializeComponent();
            // DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn();
            // buttonColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            // buttonColumn.HeaderText = "Delete";
            // buttonColumn.Name = "button";
            // buttonColumn.Text = "Xóa";
            // buttonColumn.UseColumnTextForButtonValue = true;
            // gvHang.Columns.Add(buttonColumn);
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            
            // sqlQuery truyvan = new sqlQuery();
            // DataTable td = truyvan.LayDuLieu("Select MaHang,TenHang,GiaDeNghi from HANGHOA where MaHang='"+txtboxMaSP.Text+"'");
            
           
            // if (td.Rows.Count > 0)
            // {
            //     int n = gvHang.Rows.Add();
            //     gvHang.Rows[n].Cells[1].Value = td.Rows[0][0].ToString();
            //     gvHang.Rows[n].Cells[2].Value = td.Rows[0][1].ToString();
            //     gvHang.Rows[n].Cells[3].Value = td.Rows[0][2].ToString();
            //     gvHang.Rows[n].Cells[4].Value = "1";
            //     gvHang.Rows[n].Cells[5].Value= td.Rows[0][2].ToString();
            //     for (int i = 0; i < gvHang.Rows.Count; i++)
            //     {
            //         gvHang.Rows[i].Cells[0].Value = i + 1;
            //     } // số thứ tự
            // }
            // else { MessageBox.Show("Mã hàng không hợp lệ !"); };
            // loadLblTien();
        }

        private void gvHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // if(e.ColumnIndex==6 && e.RowIndex >= 0)
            // {
            //     gvHang.Rows.RemoveAt(e.RowIndex);
            //     for (int i = 0; i < gvHang.Rows.Count; i++)
            //     {
            //         gvHang.Rows[i].Cells[0].Value = i + 1;
            //     }
            // }
            // loadLblTien();
            
        }

        private void frmBanHang2_Load(object sender, EventArgs e)
        {
         
        }

        private void loadLblTien()
        {
            // int tongtien=0;
            // for(int i = 0; i < gvHang.Rows.Count; i++)
            // {
            //     tongtien = tongtien + Convert.ToInt16(gvHang.Rows[i].Cells[5].Value.ToString());
            // }
            // lblTongTien.Text = tongtien.ToString();
            // lblTongCong.Text = tongtien.ToString();
        }

        private void btnThuTien_Click(object sender, EventArgs e)
        {
            // if (gvHang.Rows.Count > 0)
            // {
            //     int tongcong = Convert.ToInt16(lblTongCong.Text);
            //     frmCheckOut frm = new frmCheckOut(tongcong, txtboxMaKH.Text);
            //     frm.Show();
            // }
            // else
            // {
            //     MessageBox.Show("Vui lòng chọn sản phẩm mua", "");
            // }
            
        }
    }
}
