using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using BanHangSieuTHi.Class;


namespace BanHangSieuTHi.Edit
{
    public partial class frmHangHoa : Form
    {
        public frmHangHoa(ArrayList arHH)
        {
            InitializeComponent();
            if (arHH.Count > 0)
            {
                Ma.Text = arHH[0].ToString();
                Ten.Text = arHH[1].ToString();
                DonVi.Text = arHH[2].ToString();
                TenNhaSX.Text = arHH[3].ToString();
                GiaDeNghi.Text = arHH[4].ToString();
                sqlQuery truyVanDL = new sqlQuery();
                DataTable dt = truyVanDL.LayDuLieu("select * from LOAIHANG");
                ArrayList arLH = new ArrayList();

                foreach (DataRow row in dt.Rows)
                {
                    if (row["MaLoai"].Equals(arHH[5].ToString()))
                    {
                        arLH.Insert(0, row["DienGiai"]);
                    }
                    else
                    {
                        arLH.Add(row["DienGiai"]);
                    }
                }

                Loai.DataSource = arLH;
                SoLuong.Text = arHH[6].ToString();
            }
            

        }

        private void frmHangHoa_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlQuery truyVan = new sqlQuery();
            DataTable dt = truyVan.LayDuLieu("select * from LOAIHANG where DienGiai = N'"+Loai.Text+"'");
            Object MaLoai = "";
            foreach (DataRow row in dt.Rows)
            {
                MaLoai = row["MaLoai"];
            }

            string query = "UPDATE HANGHOA SET TenHang=N'" + Ten.Text + "', DonVi=N'" + DonVi.Text + "', TenNhaSX=N'" + TenNhaSX.Text + "', GiaDeNghi=" +  GiaDeNghi.Text +", MaLoai='" + MaLoai + "', SoLuongSP=" + SoLuong.Text +
                            " WHERE MaHang='" + Ma.Text + "'";
            
            truyVan.ExecuteNoneQuery(query);

            
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you ok?", "Delete", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                string query = "DELETE HANGHOA WHERE MaHang='" + Ma.Text + "'";
                sqlQuery truyVan = new sqlQuery();
                truyVan.ExecuteNoneQuery(query);
                Close();
                //MessageBox.Show("Xong em rồi!");
            }
        }
    }
}
