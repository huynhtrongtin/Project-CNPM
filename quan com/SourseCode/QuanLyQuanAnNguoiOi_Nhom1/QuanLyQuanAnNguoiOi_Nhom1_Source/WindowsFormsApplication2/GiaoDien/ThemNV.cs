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
    public partial class ThemNV_ : Form
    {
        public ThemNV_()
        {
            InitializeComponent();
        }

        private void ThemNV__Load(object sender, EventArgs e)
        {
            //Lay ve danh sach loai nhan vien
            LoaiNhanVienXL LoaiNV = new LoaiNhanVienXL();
            DataTable DT_LoaiNV = LoaiNV.LayDanhSachLoaiNV();
            //Add vao combobox
            cb_LoaiNhanVien.DataSource = DT_LoaiNV;
            cb_LoaiNhanVien.DisplayMember = "TenLoaiNV";
            cb_LoaiNhanVien.ValueMember = "MaLoaiNV";

        }

        private void bt_ThemMoi_Click(object sender, EventArgs e)
        {
            bt_Luu.Enabled = true;
            bt_Huy.Enabled = true;
            txt_TenNV.Enabled = true;
            txt_SoDienThoai.Enabled = true;
            txt_QueQuan.Enabled = true;
            txt_DiaChi.Enabled = true;
            cb_LoaiNhanVien.Enabled = true;
            dt_NgaySinh.Enabled = true;

            txt_DiaChi.Text = "";
            txt_QueQuan.Text = "";
            txt_SoDienThoai.Text = "";
            txt_TenNV.Text = "";
        }

        private void bt_Luu_Click(object sender, EventArgs e)
        {
            bt_Luu.Enabled = false;
            bt_Huy.Enabled = false;
            txt_TenNV.Enabled = false;
            txt_SoDienThoai.Enabled = false;
            txt_QueQuan.Enabled = false;
            txt_DiaChi.Enabled = false;
            cb_LoaiNhanVien.Enabled = false;
            dt_NgaySinh.Enabled = false;
            //Kiem tra du lieu nhap vao
            if (txt_TenNV.Text.CompareTo("") == 0 || txt_SoDienThoai.Text.CompareTo("") == 0 || txt_QueQuan.Text.CompareTo("") == 0 || txt_DiaChi.Text.CompareTo("") == 0)
            {
                MessageBox.Show("Hãy Nhập Đầy Đủ Thông Tin");
            }
            else
            {
                //Them vao co so du lieu
                string MaNV = ConnectToDB.SinhMaNhanVien();
                NhanVienXL NhanVien = new NhanVienXL(MaNV, txt_TenNV.Text, dt_NgaySinh.Text, txt_QueQuan.Text, cb_LoaiNhanVien.SelectedValue.ToString(), txt_DiaChi.Text, txt_SoDienThoai.Text);
                bool kq = NhanVien.ThemNhanVien();
                if(kq==true)
                    MessageBox.Show("Thêm thành công");
            }
        }

        private void bt_Huy_Click(object sender, EventArgs e)
        {
            txt_DiaChi.Text = "";
            txt_QueQuan.Text = "";
            txt_SoDienThoai.Text = "";
            txt_TenNV.Text = "";
        }

        private void bt_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }        
    }
}
