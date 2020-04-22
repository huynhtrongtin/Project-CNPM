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
    public partial class TinhLuong : Form
    {
        public TinhLuong()
        {
            InitializeComponent();
        }

        private void TinhLuong_Load(object sender, EventArgs e)
        {
            //Lay ra danh sach nam
            ChamCongXL ChamCong = new ChamCongXL();
            DataTable dt_Nam = ChamCong.LayRaNam();
            //Them vao combobox Nam
            for(int i=0;i<dt_Nam.Rows.Count;i++)
            {
                cb_Nam.Items.Add(dt_Nam.Rows[i][0].ToString());
            }
            cb_Nam.SelectedIndex = 0;
        }
       
        private void bt_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_Tim_Click(object sender, EventArgs e)
        {
            //Clear GirdView              
            if (grid_Luong.Rows.Count > 1)
            {
                int k = grid_Luong.Rows.Count;
                for (int i = 0; i < k; i++)
                {
                    grid_Luong.Rows.RemoveAt(0);
                    i = 0;
                    k--;
                }
            }
            //Tim nhan vien ung voi ten nhap vao
            NhanVienXL NhanVien = new NhanVienXL();
            DataTable DT_DSNhanVien = NhanVien.TraCuuNhanVien("", txt_Ten.Text);
            //Lay ve thang, nam
            int Thang = Convert.ToInt16(cb_Thang.Text);
            int Nam = Convert.ToInt16(cb_Nam.Text);
            //
            for (int i = 0; i < DT_DSNhanVien.Rows.Count; i++)
            {
                //Lay ra ma nhan vien
                string MaNV = DT_DSNhanVien.Rows[i][0].ToString();                
                //Lay ra bang cham cong ung voi nhan vien nay
                ChamCongXL ChamCong = new ChamCongXL();
                DataTable dt = ChamCong.LayRaChamCongThanhVien(MaNV, Thang, Nam);
                if (dt.Rows.Count > 0)
                {
                    //Them thong tin vao grid view
                    DataGridViewRow row = new DataGridViewRow();
                    DataGridViewCell col = new DataGridViewTextBoxCell();
                    //Cot Ten Nhan Vien
                    col.Value = DT_DSNhanVien.Rows[i][1].ToString();
                    row.Cells.Add(col);
                    //Cot So Ngay Nghir
                    col = new DataGridViewTextBoxCell();
                    col.Value = dt.Rows[0][4].ToString();
                    row.Cells.Add(col);
                    //Cot So Ngay Di Tre
                    col = new DataGridViewTextBoxCell();
                    col.Value = dt.Rows[0][5].ToString();
                    row.Cells.Add(col);
                    //Cot luong co ban
                    //Lay ra ma loai nhan vien ung voi ma nhan vien
                    string MaLoaiNV = NhanVien.TimMaLoaiNV(MaNV);
                    //Lay ra Luong co ban
                    LoaiNhanVienXL LoaiNV = new LoaiNhanVienXL();
                    DataTable dt_Luong = LoaiNV.LayThongTinLoaiNV(MaLoaiNV);
                    //
                    col = new DataGridViewTextBoxCell();
                    col.Value = dt_Luong.Rows[0][2].ToString();
                    row.Cells.Add(col);
                    //Cot tong luong
                    //Lay ra tham so
                    ThamSoXL ThamSo = new ThamSoXL();
                    DataTable dt_ThamSo = ThamSo.LayThamSo();
                    //Tinh luong
                    double TongLuong = Convert.ToDouble(dt_Luong.Rows[0][2].ToString()) - Convert.ToDouble(dt.Rows[0][4].ToString()) * Convert.ToDouble(dt_ThamSo.Rows[0][4].ToString()) - Convert.ToDouble(dt.Rows[0][5].ToString()) * Convert.ToDouble(dt_ThamSo.Rows[0][5].ToString());
                    col = new DataGridViewTextBoxCell();
                    col.Value = TongLuong.ToString();
                    row.Cells.Add(col);

                    grid_Luong.Rows.Add(row);
                }
            }
        }

        private void cb_Nam_SelectedIndexChanged(object sender, EventArgs e)
        {
            string Nam = cb_Nam.Text;
            //Lay ra danh sach thang
            ChamCongXL ChamCong= new ChamCongXL();
            DataTable dt_Thang = ChamCong.LayRaThang(Nam);
            for(int i=0;i<dt_Thang.Rows.Count;i++)
            {
                cb_Thang.Items.Add(dt_Thang.Rows[i][0].ToString());
            }
            cb_Thang.SelectedIndex = 0;
        }
    }
}
