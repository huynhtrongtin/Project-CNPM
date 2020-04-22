using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

    public class LoaiNhanVienXL
    {
        string MaLoaiNV, TenLoaiNV;
        float LuongCB;
        public LoaiNhanVienXL()
        {
            this.MaLoaiNV = "";
            this.TenLoaiNV = "";
            this.LuongCB = 0;
        }
        public LoaiNhanVienXL(string MaLoaiNV,string TenLoaiNV,float LuongCB)
        {
            this.MaLoaiNV = MaLoaiNV;
            this.TenLoaiNV = TenLoaiNV;
            this.LuongCB = LuongCB;
        }
        //Truy van lay ra bang Loai Nhan Vien
        public DataTable LayDanhSachLoaiNV(){
            string sql = "select * from Tb_LoaiNhanVien";
            return ConnectToDB.TruyVan_TraVe_DataTable(sql);
        }
        //Lay ra loai nhan vien 
        public DataTable LayThongTinLoaiNV(string MaLoaiNV)
        {
            string sql="select * from Tb_LoaiNhanVien where MaLoaiNV='"+MaLoaiNV+"'";
            return ConnectToDB.TruyVan_TraVe_DataTable(sql);
        }
    }
