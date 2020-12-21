﻿using System;
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
    public partial class Nhacungcap : UserControl
    {
        Nhacungcap_SQL ncc = new Nhacungcap_SQL();
        public Nhacungcap()
        {
            InitializeComponent();
            ncc.bangDuLieu = dataGridView1;
        }
        private void Nhacungcap_Load(object sender, EventArgs e)
        {
            ncc.ViewAll();
        }
        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            txtNCCID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtTenNCC.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtDiachi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtDienthoai.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }
        private void txtDienthoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
                e.Handled = true;
        }


        #region Handle button
        int luu = 0;
        public void ResetText1()
        {
            List<TextBox> lst = new List<TextBox>()
            {
                txtDiachi,txtDienthoai,txtEmail,txtNCCID,txtTenNCC,txtTKDiachi,txtTKTenNCC
            };
            foreach (var item in lst)
                item.ResetText();
            txtTenNCC.Focus();
        }
        public void Start()
        {
            ResetText1();
            luu = 0;
            btnSua.BackColor = Color.LightGray;
            btnThem.BackColor = Color.LightGray;
            btnXoa.BackColor = Color.LightGray;
            btnHuy.BackColor = Color.LightGray;
            btnLuu.BackColor = Color.LightGray;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnThem.Enabled = true;
            txtTKDiachi.Enabled = true;
            txtTKTenNCC.Enabled = true;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            luu = 1;
            btnThem.Enabled = false;
            btnThem.BackColor = Color.LightBlue;
            btnXoa.Enabled = false;
            btnSua.Enabled = false;
            ResetText1();
            txtTKDiachi.Enabled = false;
            txtTKTenNCC.Enabled = false;
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtNCCID.Text == "")
                MessageBox.Show("Chọn một nhà cung cấp để sửa.", "Lỗi");
            else
            {
                luu = 2;
                txtNCCID.Focus();
                btnSua.BackColor = Color.LightBlue;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                btnThem.Enabled = false;
                txtTKDiachi.Enabled = false;
                txtTKTenNCC.Enabled = false;
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            luu = 0;
            if (txtNCCID.Text == "")
                MessageBox.Show("Chọn một nhà cung cấp để xóa.", "Lỗi");
            else
            {
                int res = ncc.Delete(int.Parse(txtNCCID.Text));
                if (res == 1)
                    MessageBox.Show("Nhà cung cấp này đã tồn tại trong một phiếu nhập");
                else
                {

                    DialogResult dr;
                    dr = MessageBox.Show("Xóa dữ liệu nhà cung cấp", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    if (dr == DialogResult.OK)
                    {
                        ncc.Delete(int.Parse(txtNCCID.Text));
                        MessageBox.Show("Xóa thành công");
                        ncc.ViewAll();

                    }
                }
            }
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            Start();
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (luu == 1)
            {
                try
                {
                    if (txtTenNCC.Text == "" | txtDiachi.Text == "" | txtDienthoai.Text == "" | txtEmail.Text == "")
                    MessageBox.Show("Nhập đầy đủ thông tin sản phẩm.", "Lỗi");
                if (!UserUtilizes.IsValidEmail(txtEmail.Text) && txtEmail.Text != "")
                {
                    throw new Exception("Hãy nhập một email hợp lệ");
                }

                if (!UserUtilizes.IsPhoneNumber(txtDienthoai.Text) && txtDienthoai.Text != "")
                {
                    throw new Exception("Hãy nhập vào số điện thoại đúng");
                }
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
                return;
            }
                
            ncc.Add(txtTenNCC.Text, txtDiachi.Text, txtDienthoai.Text, txtEmail.Text);
            MessageBox.Show("Thêm thành công");
            ncc.ViewAll();
            Start();
                
            }
            else if (luu == 2)
            {
                try
                {
                    if (txtTenNCC.Text == "" | txtDiachi.Text == "" | txtDienthoai.Text == "" | txtEmail.Text == "")
                    MessageBox.Show("Nhập đầy đủ thông tin nhà cung cấp.", "Lỗi");
                    if (!UserUtilizes.IsValidEmail(txtEmail.Text) && txtEmail.Text != "")
                    {
                        throw new Exception("Hãy nhập một email hợp lệ");
                    }

                    if (!UserUtilizes.IsPhoneNumber(txtDienthoai.Text) && txtDienthoai.Text != "")
                    {
                        throw new Exception("Hãy nhập vào số điện thoại đúng");
                    }
                }
                catch (Exception ex)
                {
                    XtraMessageBox.Show(ex.Message);
                    return;
                }

                ncc.Update(int.Parse(txtNCCID.Text), txtTenNCC.Text, txtDiachi.Text, txtDienthoai.Text, txtEmail.Text);
                    MessageBox.Show("Sửa thành công");
                    ncc.ViewAll();
                    Start();
                
            }
        }

        #endregion

        private void Text_Changed(object sender, EventArgs e)
        {
            ncc.timKiem(txtTKTenNCC.Text, txtTKDiachi.Text);
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtNCCID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtTenNCC.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtDiachi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtDienthoai.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }
    }
}
