using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DXApplication1.Models;
using DXApplication1.Utilizes;
using DevExpress.XtraEditors;

namespace DXApplication1.Views.User_Control
{
    public partial class Khachhang : UserControl
    {
        Khachhang_SQL kh = new Khachhang_SQL();
        public Khachhang()
        {
            //InitializeComponent();
            //kh.bangDuLieu = dataGridView1;
        }
        private void Khachhang_Load(object sender, EventArgs e)
        {
            kh.ViewAll();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtKHID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtTenKH.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtDiachi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtDienthoai.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }


        #region Handle button
        int luu = 0;
        public void ResetText1()
        {
            //List<TextBox> lst = new List<TextBox>()
            //{
            //    txtKHID,txtTenKH,txtEmail,txtDienthoai,txtDiachi,txtTKDiachi,txtTKTenKH
            //};
            //foreach (var item in lst)
            //    item.ResetText();
            //txtTenKH.Focus();
        }
        public void Start()
        {
            //ResetText1();
            //luu = 0;
            //btnSua.BackColor = Color.LightGray;
            //btnThem.BackColor = Color.LightGray;
            //btnHuy.BackColor = Color.LightGray;
            //btnLuu.BackColor = Color.LightGray;
            //btnXoa.Enabled = true;
            //btnSua.Enabled = true;
            //btnThem.Enabled = true;
            //txtTKDiachi.Enabled = true;
            //txtTKTenKH.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //luu = 1;
            //btnThem.Enabled = false;
            //btnThem.BackColor = Color.LightBlue;
            //btnXoa.Enabled = false;
            //btnSua.Enabled = false;
            //ResetText1();
            //txtTKDiachi.Enabled = false;
            //txtTKTenKH.Enabled = false;
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            //if (txtKHID.Text == "")
            //    MessageBox.Show("Chọn một sản phẩm để sửa.", "Lỗi");
            //else
            //{
            //    luu = 2;
            //    txtTenKH.Focus();
            //    btnSua.BackColor = Color.LightBlue;
            //    btnSua.Enabled = false;
            //    btnXoa.Enabled = false;
            //    btnThem.Enabled = false;
            //    txtTKDiachi.Enabled = false;
            //    txtTKTenKH.Enabled = false;
            //}
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            //luu = 0;
            //int res = kh.Delete(int.Parse(txtKHID.Text));
            //if (txtKHID.Text == "")
            //    MessageBox.Show("Chọn một khách hàng để xóa.", "Lỗi");
            //else if (res == 1)
            //    MessageBox.Show("Khách hàng đã từng thực hiện giao dịch không thể xóa.", "Lỗi");
            //else
            //{
            //    DialogResult dr;
            //    dr = MessageBox.Show("Xóa dữ liệu khách hàng", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            //    if (dr == DialogResult.OK)
            //    {
            //        kh.Delete(int.Parse(txtKHID.Text));
            //        MessageBox.Show("Xóa thành công");
            //        kh.ViewAll();
            //    }
            //}
        }
        private void txtDienthoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            //    e.Handled = true;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Start();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            //if (luu == 1)
            //{
            //    txtKHID.ResetText();
            //    try
            //    {
            //        if (txtTenKH.Text == "" | txtDiachi.Text == "" | txtDienthoai.Text == "" | txtEmail.Text == "")
            //        MessageBox.Show("Nhập đầy đủ thông tin khách hàng.", "Lỗi");
            //        if (!UserUtilizes.IsValidEmail(txtEmail.Text) && txtEmail.Text != "")
            //        {
            //            throw new Exception("Hãy nhập một email hợp lệ");
            //        }

            //        if (!UserUtilizes.IsPhoneNumber(txtDienthoai.Text) && txtDienthoai.Text != "")
            //        {
            //            throw new Exception("Hãy nhập vào số điện thoại đúng");
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        XtraMessageBox.Show(ex.Message);
            //        return;
            //    }

            //    kh.Add(txtTenKH.Text, txtDiachi.Text, txtDienthoai.Text, txtEmail.Text);
            //    MessageBox.Show("Thêm thành công");
            //    kh.ViewAll();
            //    Start();
                
            //}
            //else if (luu == 2)
            //{
            //    try
            //    {
            //        if (txtTenKH.Text == "" | txtDiachi.Text == "" | txtDienthoai.Text == "" | txtEmail.Text == "")
            //            MessageBox.Show("Nhập đầy đủ thông tin sản phẩm.", "Lỗi");
            //        if (!UserUtilizes.IsValidEmail(txtEmail.Text) && txtEmail.Text != "")
            //        {
            //            throw new Exception("Hãy nhập một email hợp lệ");
            //        }

            //        if (!UserUtilizes.IsPhoneNumber(txtDienthoai.Text) && txtDienthoai.Text != "")
            //        {
            //            throw new Exception("Hãy nhập vào số điện thoại đúng");
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        XtraMessageBox.Show(ex.Message);
            //        return;
            //    }
            //    kh.Update(int.Parse(txtKHID.Text), txtTenKH.Text, txtDiachi.Text, txtDienthoai.Text, txtEmail.Text);
            //    MessageBox.Show("Sửa thành công");
            //    kh.ViewAll();
            //    Start();
                
            //}
        }
        #endregion

        private void txtTKTenKH_TextChanged(object sender, EventArgs e)
        {
            kh.timKiem(txtTKTenKH.Text, txtTKDiachi.Text);
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtKHID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtTenKH.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtDiachi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtDienthoai.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
