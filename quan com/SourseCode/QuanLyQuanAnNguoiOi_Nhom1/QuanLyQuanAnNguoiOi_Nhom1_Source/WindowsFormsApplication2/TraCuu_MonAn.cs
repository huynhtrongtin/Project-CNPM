using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class TraCuu_MonAn : Form
    {
        public TraCuu_MonAn()
        {
            InitializeComponent();
        }

        private void TraCuu_MonAn_Load(object sender, EventArgs e)
        {
            DataTable dt = ConnectToDB.TruyVan_TraVe_DataTable("select * from Tb_MonAn");
            cb_MonAn.Items.Add("Chon");
            cb_MonAn.DataSource = dt;

            cb_MonAn.DisplayMember = "TenMonAn";
            cb_MonAn.ValueMember = "MaMonAn";


        }

        private void Grid_KQ_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bt_Tim_Click(object sender, EventArgs e)
        {
            MonAnXL m = new MonAnXL();
            Grid_KQ.DataSource= m.TraCuuMonAn(cb_MonAn.Text, tb_giaDen.Text, tb_giaTu.Text);
            //MessageBox.Show(cb_MonAn.Text);
        }

        private void txt_giaTu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar <= 57 && (int)e.KeyChar >= 48 | (int)e.KeyChar == 8 | (int)e.KeyChar == 13)
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("Chỉ nhập số!!!", "Error", MessageBoxButtons.OK);
                e.Handled = true;
            }
        }
        private void txt_giaDen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar <= 57 && (int)e.KeyChar >= 48 | (int)e.KeyChar == 8 | (int)e.KeyChar == 13)
            {
                e.Handled = false;
            }
            else
            {
                MessageBox.Show("Chỉ nhập số!!!", "Error", MessageBoxButtons.OK);
                e.Handled = true;
            }
        }
    }
}
