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
    public partial class QL_MonAn : Form
    {
        public QL_MonAn()
        {
            InitializeComponent();
        }

        private void txt_Them_Click(object sender, EventArgs e)
        {
            bt_Luu.Enabled = true;
            bt_Huy.Enabled = true;
            Grid_MonAn.Enabled = true;
            if (Grid_MonAn.Rows.Count > 1)
            {
                int k = Grid_MonAn.Rows.Count;
                for (int i = 0; i < k; i++)
                {
                    Grid_MonAn.Rows.RemoveAt(0);
                    i = 0;
                    k--;
                }
            }

        }

        private void bt_Luu_Click(object sender, EventArgs e)
        {
            bt_Luu.Enabled = false;
            bt_Huy.Enabled = false;
            Grid_MonAn.Enabled = false;
            //kiem tra du lieu nhap vao
            for (int i = 0; i < Grid_MonAn.RowCount - 1; i++)
            {
                if (Grid_MonAn.Rows[i].Cells[0] == null || Grid_MonAn.Rows[i].Cells[1].Value == null)
                {
                    MessageBox.Show("Xin nhập đầy đủ thông tin!");
                }
                else
                {
                    string maMA = ConnectToDB.SinhMaMonAn();
                    MonAnXL monAn = new MonAnXL(maMA,Convert.ToString(Grid_MonAn.Rows[i].Cells[0].Value), Convert.ToSingle(Grid_MonAn.Rows[i].Cells[1].Value));
                    bool kq = monAn.ThemMonAn();
                    if (kq == true)
                        MessageBox.Show("Thêm thành công!");
                }
            }
        }

        private void bt_Huy_Click(object sender, EventArgs e)
        {
            if (Grid_MonAn.Rows.Count > 1)
            {
                int k = Grid_MonAn.Rows.Count;
                for (int i = 0; i < k; i++)
                {
                    Grid_MonAn.Rows.RemoveAt(0);
                    i = 0;
                    k--;
                }
            }
        }

        private void bt_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
