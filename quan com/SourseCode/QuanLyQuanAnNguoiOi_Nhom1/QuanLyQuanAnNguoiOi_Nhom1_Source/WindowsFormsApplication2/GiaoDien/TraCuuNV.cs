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
    public partial class TraCuuNV : Form
    {
        public TraCuuNV()
        {
            InitializeComponent();
        }

        private void TraCuuNV_Load(object sender, EventArgs e)
        {
            //Lay ve danh sach loai nhan vien
            LoaiNhanVienXL LoaiNV = new LoaiNhanVienXL();
            DataTable DT_LoaiNV = LoaiNV.LayDanhSachLoaiNV();
            //Add vao combobox
            cb_LoaiNV.Items.Add("Chon");
            cb_LoaiNV.DataSource = DT_LoaiNV;
            cb_LoaiNV.DisplayMember = "TenLoaiNV";
            cb_LoaiNV.ValueMember = "MaLoaiNV";

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void bt_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(cb_LoaiNV.Enabled==false)
            {
                cb_LoaiNV.Enabled = true;
            }
            else
            {
                cb_LoaiNV.Enabled = false;
            }
        }
        private int TachNam(string NgaySinh)
        {
            string Nam = NgaySinh.Substring(6, 4);
            return Convert.ToInt16(Nam);
        }        
        private void bt_Tim_Click(object sender, EventArgs e)
        {                        
            NhanVienXL NhanVien = new NhanVienXL();            
            DataTable DT_DSNhanVien;
            if(cb_LoaiNV.Enabled==true)
                DT_DSNhanVien = NhanVien.TraCuuNhanVien(cb_LoaiNV.SelectedValue.ToString(), txt_TheoTen.Text);
            else
                DT_DSNhanVien = NhanVien.TraCuuNhanVien("", txt_TheoTen.Text);             
            //DataTable DT_DSNhanVien = NhanVien.TraCuuNhanVien("", txt_TheoTen.Text);
            //Tim theo tuoi
            if(txt_TuoiTu.Text.CompareTo("")!=0 && txt_TuoiDen.Text.CompareTo("")!=0)
            {
                if(Convert.ToInt16(txt_TuoiTu.Text)>Convert.ToInt16(txt_TuoiDen.Text))
                {
                    MessageBox.Show("Giá trị tuổi không hợp lệ, Hệ thông sẽ loại bỏ giá trị tìm kiếm theo tuổi.");
                }
                else
                {
                    //Tinh tuoi => nam
                    String ToDay = DateTime.Now.ToString();
                    int NamTu = TachNam(ToDay) - Convert.ToInt16(txt_TuoiTu.Text);
                    int NamDen = TachNam(ToDay) - Convert.ToInt16(txt_TuoiDen.Text);
                    MessageBox.Show(NamTu.ToString() + ":" + NamDen.ToString());
                    //Xoa cac row co do tuoi khong nam trong khoang nay
                    int k = DT_DSNhanVien.Rows.Count;
                    for (int i = 0; i < k; i++)
                    {
                        if (TachNam(DT_DSNhanVien.Rows[i][2].ToString()) > NamTu || TachNam(DT_DSNhanVien.Rows[i][2].ToString()) < NamDen)
                        {
                            //MessageBox.Show(DT_DSNhanVien.Rows[i][2].ToString());
                            DT_DSNhanVien.Rows.RemoveAt(i);
                            i = 0;
                            k--;
                        }
                    }
                }                
            }                        
            //Clear GirdView              
            if (grid_KetQua.Rows.Count > 1)
            {
                int k = grid_KetQua.Rows.Count;
                for (int i = 0; i < k; i++)
                {
                    grid_KetQua.Rows.RemoveAt(0);
                    i = 0;
                    k--;
                }
            }                     
            for (int i = 0; i < DT_DSNhanVien.Rows.Count; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                for (int j = 0; j < DT_DSNhanVien.Columns.Count; j++)
                {
                    DataGridViewCell col = new DataGridViewTextBoxCell();
                    col.Value = DT_DSNhanVien.Rows[i][j].ToString();
                    row.Cells.Add(col);
                }
                grid_KetQua.Rows.Add(row);
                
            }                        
        }
    }
}
