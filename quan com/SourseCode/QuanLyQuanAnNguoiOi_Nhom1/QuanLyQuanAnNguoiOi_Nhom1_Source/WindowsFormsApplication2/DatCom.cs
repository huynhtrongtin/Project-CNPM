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
    public partial class DatCom : Form
    {
        public DatCom()
        {
            InitializeComponent();
        }

        private void DatCom_Load(object sender, EventArgs e)
        {
            //Lay danh sach mon an
            MonAnXL MA = new MonAnXL();
            DataTable DT_MA = MA.DanhSachMonAn();
            //them vao combobox
            cb_MonAn.DataSource = DT_MA;
            cb_MonAn.ValueMember = "MaMonAn";
            cb_MonAn.DisplayMember = "TenMonAn";
            //lay danh sach khach hang
            KhachHangXL KhHang = new KhachHangXL();
            DataTable DT_KhHang = KhHang.DanhSachKH();

        }

        private void bt_ThemMoi_Click(object sender, EventArgs e)
        {
            bt_Luu.Enabled = true;
            bt_huy.Enabled = true;
            
            txt_TenKH.Enabled = true;
            txt_DC.Enabled = true;
            txt_SDT.Enabled = true;
            Grid_DatMon.Enabled = true;

            dtime_NgayDat.Enabled = true;
            dtime_NgayNhan.Enabled = true;

            txt_TenKH.Text = "";
            txt_DC.Text = "";
            txt_SDT.Text = "";
            if (Grid_DatMon.Rows.Count > 1)
            {
                int k = Grid_DatMon.Rows.Count;
                for (int i = 0; i < k; i++)
                {
                    Grid_DatMon.Rows.RemoveAt(0);
                    i = 0;
                    k--;
                }
            }
        }

        private void bt_Luu_Click(object sender, EventArgs e)
        {
            string maKH = ConnectToDB.SinhMaKhachHang();
            if (txt_TenKH.Text.CompareTo("") == 0)
            {
                MessageBox.Show("Xin nhập thông tin khách hàng!");
                bt_Luu.Enabled = true;
                bt_huy.Enabled = true;
                 
            }
            else
            {
                KhachHangXL KhHang = new KhachHangXL(maKH, txt_TenKH.Text, txt_DC.Text, txt_SDT.Text);
                bool kq = KhHang.ThemKhachHang();
                if (kq == true)
                {
                    txt_TenKH.Enabled = false;
                    txt_DC.Enabled = false;
                    txt_SDT.Enabled = false;
                    bt_Luu.Enabled = false;
                    bt_huy.Enabled = false;
                }
                 
            }
            for (int i = 0; i < Grid_DatMon.Rows.Count - 1; i++)
            {
                if (Grid_DatMon.Rows[i].Cells[0] == null || Grid_DatMon.Rows[i].Cells[1].Value == null)
                {
                    MessageBox.Show("Thiếu thông tin đặt hàng");
                    bt_Luu.Enabled = true;
                    bt_huy.Enabled = true;
                }
                else
                {
                    string mMA = Grid_DatMon.Rows[i].Cells[0].Value.ToString();
                    MonAnXL GMA = new MonAnXL();
                    int GiaMA = Convert.ToInt32(GMA.GiaMonAn(mMA));
                    float giaMA = Convert.ToInt32(Grid_DatMon.Rows[i].Cells[1].Value) * GiaMA;
                    Grid_DatMon.Rows[i].Cells[2].Value = giaMA;
                    //MessageBox.Show(Convert.ToString(giaMA));
                    DatComXL DatCom = new DatComXL(maKH, dtime_NgayDat.Text, dtime_NgayNhan.Text, mMA, Convert.ToInt32(Grid_DatMon.Rows[i].Cells[1].Value), giaMA);
                    bool kq = DatCom.ThemVaoDonDH();
                    if (kq == true)
                    {
                        MessageBox.Show("Đặt Món Ăn Thành Công!");
                        dtime_NgayDat.Enabled = false;
                        dtime_NgayNhan.Enabled = false;
                        Grid_DatMon.Enabled = false;
                        
                    }
                    
                }
            }
            
            
             
        }

        private void bt_huy_Click(object sender, EventArgs e)
        {
            txt_TenKH.Text = "";
            txt_DC.Text = "";
            txt_SDT.Text = "";
            if (Grid_DatMon.Rows.Count > 1)
            {
                int k = Grid_DatMon.Rows.Count;
                for (int i = 0; i < k; i++)
                {
                    Grid_DatMon.Rows.RemoveAt(0);
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
