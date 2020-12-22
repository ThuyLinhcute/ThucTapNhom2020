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

namespace BanHangSieuTHi.Add
{
    public partial class frmHangHoa : Form
    {
        public frmHangHoa(ArrayList arHH)
        {
            InitializeComponent();
            if (arHH.Count == 0)
            {
                sqlQuery truyVanDL = new sqlQuery();
                DataTable dt = truyVanDL.LayDuLieu("select * from LOAIHANG");
                ArrayList arLH = new ArrayList();
                foreach (DataRow row in dt.Rows)
                {
                    arLH.Add(row["DienGiai"]);
                }
                Loai.DataSource = arLH;

                DataTable dtHH = truyVanDL.LayDuLieu("select * from HANGHOA order by MaHang desc");
                string MaHang = "";
                foreach (DataRow row in dtHH.Rows)
                {
                    MaHang = row["MaHang"].ToString();
                    int k = MaHang.IndexOf("h");
                    int t = int.Parse(MaHang.Substring(k+1))+1;
                    Ma.Text = "h" + t;
                    break;
                }
                
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmHangHoa_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sqlQuery truyVan = new sqlQuery();
            DataTable dt = truyVan.LayDuLieu("select * from LOAIHANG where DienGiai = N'" + Loai.Text + "'");
            Object MaLoai = "";
            foreach (DataRow row in dt.Rows)
            {
                MaLoai = row["MaLoai"];
            }

            string query = "insert into HANGHOA values('" + Ma.Text + "','" + Ten.Text + "','" + DonVi.Text + "','" + TenNhaSX.Text + "'," + GiaDeNghi.Text + ",'" + MaLoai + "'," + SoLuong.Text + ")";

            truyVan.ExecuteNoneQuery(query);


            Close();
        }
    }
}
