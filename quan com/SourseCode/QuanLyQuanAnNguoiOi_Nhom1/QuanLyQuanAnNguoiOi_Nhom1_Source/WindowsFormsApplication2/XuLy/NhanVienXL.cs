using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Data.SqlClient;


    public class NhanVienXL
    {
        //string MaNV, TenNV, NgaySinh, QueQuan, MaLoaiNV, DiaChi, SoDT;
        public string MaNV { get; set; }
        public string TenNV { get; set; }
        public string NgaySinh { get; set; }
        public string QueQuan { get; set; }
        public string MaLoaiNV { get; set; }
        public string DiaChi { get; set; }
        public string SoDT { get; set; }
        public NhanVienXL()
        {

        }
        public NhanVienXL(string MaNV, string TenNV, string NgaySinh, string QueQuan, string MaLoaiNV, string DiaChi, string SoDT)
        {
            this.MaNV = MaNV;
            this.TenNV = TenNV;
            this.NgaySinh = NgaySinh;
            this.QueQuan = QueQuan;
            this.MaLoaiNV = MaLoaiNV;
            this.DiaChi = DiaChi;
            this.SoDT = SoDT;
        }
        //Kiem tra ten dang nhap va mat khau
        public bool KiemTraDangNhap(String TenDangNhap, String MatKhau)
        {
            bool kq = false;
            string sql = "select * from Tb_Users where UserName='" + TenDangNhap + "' and Password='" + MatKhau + "'";
            DataTable dt = ConnectToDB.TruyVan_TraVe_DataTable(sql);
            if (dt.Rows.Count > 0)
            {
                kq = true;
            }
            else
            {
                kq = false;
            }
            return kq;
        }
        //Them Nhan VIen
        public bool ThemNhanVien(){
            //Them vao co so du lieu            
            string sql = "insert into Tb_ThongTinNhanVien (MaNV,TenNV,NgaySinh,QueQuan,MaLoaiNV,DiaChi,SoDT) values (@MaNV,@TenNV,@NgaySinh,@QueQuan,@MaLoaiNV,@DiaChi,@SoDT)";
            SqlParameter[] thamso = {   new SqlParameter("@MaNV",this.MaNV),
                                            new SqlParameter("@TenNV",this.TenNV),
                                            new SqlParameter("@NgaySinh",this.NgaySinh),
                                            new SqlParameter("@QueQuan",this.QueQuan),
                                            new SqlParameter("@MaLoaiNV",this.MaLoaiNV),
                                            new SqlParameter("@DiaChi",this.DiaChi),
                                            new SqlParameter("@SoDT",this.SoDT)};
            ConnectToDB.Truyvan_Xuly_co_Thamso(sql, thamso);
            return true;
        }
        //Tra cuu nhan vien
        public DataTable TraCuuNhanVien(string LoaiNV,string TenTV)
        {
            string sql="";
            if(LoaiNV.CompareTo("")!=0 && TenTV.CompareTo("")!=0)
                sql = "select * from Tb_ThongTinNhanVien where MaLoaiNV=@MaLoaiNV AND TenNV LIKE @TenNV";
            else
            {
                if(LoaiNV.CompareTo("")!=0)
                    sql = "select * from Tb_ThongTinNhanVien where MaLoaiNV=@MaLoaiNV";
                else
                    sql = "select * from Tb_ThongTinNhanVien where TenNV LIKE @TenNV";
            }
            SqlParameter[] thamso = {   new SqlParameter("@MaLoaiNV",LoaiNV),
                                        new SqlParameter("@TenNV","%"+TenTV+"%")
                                        };
            DataTable DT_DSNhanVien = ConnectToDB.Truyvan_TraVe_Table_co_Thamso(sql, thamso);
            return DT_DSNhanVien;
        }
        //Tim MaNV Theo ten NV
        public string TimMaNV(string TenNV)
        {
            string sql = "select MaNV from Tb_ThongTinNhanVien where TenNV='" + TenNV + "'";
            DataTable dt = ConnectToDB.TruyVan_TraVe_DataTable(sql);
            return dt.Rows[0][0].ToString();
        }
        //Tim MaLoaiNV theo MaNhanVien
        public string TimMaLoaiNV(string MaNV)
        {
            string sql="select MaLoaiNV from Tb_ThongTinNhanVien where MaNV='"+MaNV+"'";
            DataTable dt = ConnectToDB.TruyVan_TraVe_DataTable(sql);
            return dt.Rows[0][0].ToString();
        }
    }

