using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace WindowsFormsApplication2
{
    public partial class TraCuuKhachHang : Form
    {
        public DataTable dt1;
        public TraCuuKhachHang()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KhachHangXL x = new KhachHangXL();
            dt1= x.TraCuuKhachHang(tb_tenKH.Text, tb_diachi.Text);
            dgvKH.DataSource = dt1;
            dgvKH.Columns[0].ReadOnly = true;
            dgvKH.Columns[0].Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            KhachHangXL x = new KhachHangXL();

            SqlDataAdapter da = new SqlDataAdapter();
            da = x.TraCuuKhachHang_DA(tb_tenKH.Text, tb_diachi.Text);
            SqlCommandBuilder b = new SqlCommandBuilder(da);
            da.Update(dt1);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
