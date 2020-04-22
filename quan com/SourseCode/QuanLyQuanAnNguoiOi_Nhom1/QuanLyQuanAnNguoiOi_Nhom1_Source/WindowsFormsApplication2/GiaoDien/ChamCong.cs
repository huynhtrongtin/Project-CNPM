using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace WindowsFormsApplication2
{
    public partial class ChamCong : Form
    {
        public ChamCong()
        {
            InitializeComponent();
        }

        private void ChamCong_Load(object sender, EventArgs e)
        {            
            
            /*
            string s = "";
            for (int i = 1; i < 32; i++)
            {
                s += "["+i+"]=N'\"+this.N"+i+"+\"',";
            }
            MessageBox.Show(s);
             */
            //Khoi tao nam hien tai
            txt_Nam.Text = TachNam(DateTime.Now.ToString()).ToString();
            //Thang hien tai
            //MessageBox.Show(DateTime.Now.ToString());
            cb_Thang.SelectedIndex = DateTime.Now.Month-1;           
        }
        private int TachNam(string Ngay)
        {
            string Nam = Ngay.Substring(6, 4);
            return Convert.ToInt16(Nam);
        }
        private int TachThang(string Ngay)
        {
            string Nam = Ngay.Substring(0, 2);
            return Convert.ToInt16(Nam);
        }
        private void bt_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_Huy_Click(object sender, EventArgs e)
        {

        }

        private void bt_Tim_Click(object sender, EventArgs e)
        {
            //
            //Clear GirdView              
            if (grid_BangChamCong.Rows.Count > 1)
            {
                int k = grid_BangChamCong.Rows.Count;
                for (int i = 0; i < k; i++)
                {
                    grid_BangChamCong.Rows.RemoveAt(0);
                    i = 0;
                    k--;
                }
            }
            //So cot loai bo            
            int SoCotDu = grid_BangChamCong.Columns.Count - (DateTime.DaysInMonth(Convert.ToInt16(txt_Nam.Text), Convert.ToInt16(cb_Thang.SelectedIndex + 1)) + 1);            
            int SoCot = grid_BangChamCong.Columns.Count;
            for (int i = SoCot - 1; i >= SoCot - SoCotDu; i--)
            {
                grid_BangChamCong.Columns.RemoveAt(i);                
            }
            //So cot fai them vao
            if(SoCotDu<0)
            {
                SoCotDu *= (-1);
                for (int i = SoCot+1; i <= SoCot + SoCotDu; i++)
                {
                    DataGridViewComboBoxColumn col = new DataGridViewComboBoxColumn();                    
                    col.HeaderText = (i-1).ToString();
                    col.Items.AddRange(new object[] {   "Không",
                                                        "Vắng",
                                                        "Đi Trễ"});
                    col.Width = 50;
                    grid_BangChamCong.Columns.Add(col);
                }
            }
            //
            NhanVienXL NhanVien = new NhanVienXL();
            DataTable DT_DSNhanVien = NhanVien.TraCuuNhanVien("", txt_TenNV.Text);            
            //MessageBox.Show(DT_DSNhanVien.Rows.Count.ToString());
            for (int i = 0; i < DT_DSNhanVien.Rows.Count; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                DataGridViewCell col = new DataGridViewTextBoxCell();
                col.Value = DT_DSNhanVien.Rows[i][1].ToString();
                row.Cells.Add(col);               
                grid_BangChamCong.Rows.Add(row);
            }
            //Tim kiem ung voi thanh vien do + thang + nam da co cham cong chua, co thi them thong tin san~ co trong csdl vao
            //
            //Kiem tra xem thanh vien nay o thang va nam nhap vao da duoc cham cong chua, neu roi thi update
            for (int i = 0; i < grid_BangChamCong.Rows.Count - 1; i++)
            {
                string MaNV = NhanVien.TimMaNV(grid_BangChamCong.Rows[i].Cells[0].Value.ToString());
                int Thang = (cb_Thang.SelectedIndex + 1);
                int Nam = Convert.ToInt16(txt_Nam.Text);
                ChamCongXL ChamCong = new ChamCongXL();
                DataTable DT_KTraChamCong = ChamCong.LayRaChamCongThanhVien(MaNV, Thang, Nam);
                if (DT_KTraChamCong.Rows.Count != 0)
                {
                    //Lay ra bang cham cong ung voi MCC cua thanh vien nay
                    DataTable tb_ChiTiet = ChiTietBangChamCongXL.layBangChamCong(DT_KTraChamCong.Rows[0][0].ToString());
                    for(int j=1;j<grid_BangChamCong.Columns.Count;j++)
                    {
                        //Neu la rong~ => Không
                        if(tb_ChiTiet.Rows[0][j].ToString().Equals(""))
                            grid_BangChamCong.Rows[i].Cells[j].Value = "Không";
                        else
                            grid_BangChamCong.Rows[i].Cells[j].Value = tb_ChiTiet.Rows[0][j].ToString();
                        
                    }
                }
            }
        }

        private void bt_Luu_Click(object sender, EventArgs e)
        {            
            NhanVienXL NhanVien = new NhanVienXL();
            //MessageBox.Show(grid_BangChamCong.Rows.Count.ToString());
            for(int i=0;i<grid_BangChamCong.Rows.Count-1;i++)
            {
                //Chi Tiet Cham Cong
                ChiTietBangChamCongXL ChiTietChamCong;
                string MaChamCong = "";
                string MaNV = NhanVien.TimMaNV(grid_BangChamCong.Rows[i].Cells[0].Value.ToString());
                int Thang = (cb_Thang.SelectedIndex + 1);
                int Nam = Convert.ToInt16(txt_Nam.Text);
                //Tinh so ngay nghi  --- Tinh so ngay di lam tre
                int SoNgayNghi=0, SoNgayDiLamTre=0;
                List<String> DSNgay = new List<String>();
                for (int k = 1; k < 32; k++)
                {
                    DSNgay.Add("");
                }
                //MessageBox.Show(DSNgay.Count.ToString());
                for (int j = 1; j < grid_BangChamCong.Columns.Count; j++)
                {   
                    if (grid_BangChamCong.Rows[i].Cells[j].Value != null)
                    {
                        if (grid_BangChamCong.Rows[i].Cells[j].Value.ToString().CompareTo("Vắng") == 0)
                            SoNgayNghi++;
                        if (grid_BangChamCong.Rows[i].Cells[j].Value.ToString().CompareTo("Đi Trễ") == 0)
                            SoNgayDiLamTre++;
                        DSNgay[j - 1] = grid_BangChamCong.Rows[i].Cells[j].Value.ToString();
                    }
                    else
                    {
                        DSNgay[j - 1] = "";
                    }
                }
                //Them hoac update vao bang cham cong
                ChamCongXL ChamCong;
                //Kiem tra xem thanh vien nay o thang va nam nhap vao da duoc cham cong chua, neu roi thi update
                ChamCong = new ChamCongXL();
                DataTable DT_KTraChamCong = ChamCong.LayRaChamCongThanhVien(MaNV, Thang, Nam);          
                //Neu chua co cham co cho thang va nam nay thi tao moi va them
                if (DT_KTraChamCong.Rows.Count == 0)
                {
                    MaChamCong = ConnectToDB.SinhMaChamCong();
                    ChamCong = new ChamCongXL(MaChamCong, MaNV, Thang, Nam, SoNgayNghi, SoNgayDiLamTre);
                    ChamCong.ThemChamCong();
                    //Them vao bang chi tiet cham cong
                    ChiTietChamCong = new ChiTietBangChamCongXL(MaChamCong, DSNgay[0], DSNgay[1], DSNgay[2], DSNgay[3], DSNgay[4], DSNgay[5], DSNgay[6], DSNgay[7], DSNgay[8], DSNgay[9], DSNgay[10], DSNgay[11], DSNgay[12], DSNgay[13], DSNgay[14], DSNgay[15], DSNgay[16], DSNgay[17], DSNgay[18], DSNgay[19], DSNgay[20], DSNgay[21], DSNgay[22], DSNgay[23], DSNgay[24], DSNgay[25], DSNgay[26], DSNgay[27], DSNgay[28], DSNgay[29], DSNgay[30]);
                    ChiTietChamCong.ThemChiTietChamCong();   
                }
                else
                {                    
                    ChamCong = new ChamCongXL(DT_KTraChamCong.Rows[0][0].ToString(), MaNV, Thang, Nam, SoNgayNghi, SoNgayDiLamTre);
                    ChamCong.UpDateChamCong();
                    //Update bang chi tiet cham cong
                    ChiTietChamCong = new ChiTietBangChamCongXL(DT_KTraChamCong.Rows[0][0].ToString(), DSNgay[0], DSNgay[1], DSNgay[2], DSNgay[3], DSNgay[4], DSNgay[5], DSNgay[6], DSNgay[7], DSNgay[8], DSNgay[9], DSNgay[10], DSNgay[11], DSNgay[12], DSNgay[13], DSNgay[14], DSNgay[15], DSNgay[16], DSNgay[17], DSNgay[18], DSNgay[19], DSNgay[20], DSNgay[21], DSNgay[22], DSNgay[23], DSNgay[24], DSNgay[25], DSNgay[26], DSNgay[27], DSNgay[28], DSNgay[29], DSNgay[30]);
                    ChiTietChamCong.CapNhat();
                }                                             
            }            
        }
    }
}
