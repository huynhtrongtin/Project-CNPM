using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Data.SqlClient;

    public class KhachHangXL
    {
        public string maKH { get; set; }
        public string tenKH { get; set; }
        public string Dchi { get; set; }
        public string SoDT { get; set; }
        public SqlDataAdapter da;
        public KhachHangXL()
        {

        }
        public KhachHangXL(string MaKH, string TenKH, string DiaChi, string SDT)
        {
            this.maKH=MaKH;
            this.tenKH=TenKH;
            this.Dchi=DiaChi;
            this.SoDT=SDT;
        }

        public bool ThemKhachHang(){
            //Them vao co so du lieu            
            string sql = "insert into Tb_KhachHang (MaKH,TenKH,DChi,SoDT) values (@MaKH,@TenKH,@DChi,@SoDT)";
            SqlParameter[] thamso = {       
                                        new SqlParameter("@MaKH",this.maKH),
                                        new SqlParameter("@TenKH",this.tenKH),
                                        new SqlParameter("@DChi",this.Dchi),
                                        new SqlParameter("@SoDT",this.SoDT)
                                    };
            ConnectToDB.Truyvan_Xuly_co_Thamso(sql, thamso);
            return true;
        }
        //lay danh sach khach hang
        public DataTable DanhSachKH()
        {
            string sql = "select * from Tb_KhachHang";
            return ConnectToDB.TruyVan_TraVe_DataTable(sql);
        }
        //Tim MaKH Theo ten KH
        public bool TimMaKH(string TenKH)
        {
            string sql = "select MaKH from Tb_KhachHang where TenKH='" + TenKH + "'";
            DataTable dt = ConnectToDB.TruyVan_TraVe_DataTable(sql);
            return true;
        }
        public DataTable TraCuuKhachHang(string tenKH, string diachi)
        {
            string sql = "";
            if (tenKH.CompareTo("") != 0 && diachi.CompareTo("") != 0)
                sql = "select * where TenKH LIKE @tenKH AND DChi LIKE @diachi";
            else
            {
                if (tenKH.CompareTo("") != 0)
                    sql = "select * from Tb_KhachHang where TenKH LIKE @tenKH";
                else
                    sql = "select * from Tb_KhachHang where DChi LIKE @diachi";
            }
            SqlParameter[] thamso = {   new SqlParameter("@tenKH","%"+tenKH+"%"),
                                        new SqlParameter("@diachi","%"+diachi+"%")
                                        };
            DataTable d = ConnectToDB.Truyvan_TraVe_Table_co_Thamso(sql, thamso);
            da = ConnectToDB.Truyvan_TraVe_DataAdapter_co_Thamso(sql, thamso);
            return d;
        }
        public SqlDataAdapter TraCuuKhachHang_DA(string tenKH, string diachi)
        {
            string sql = "";
            if (tenKH.CompareTo("") != 0 && diachi.CompareTo("") != 0)
                sql = "select * from Tb_KhachHang where TenKH LIKE @tenKH AND DChi LIKE @diachi";
            else
            {
                if (tenKH.CompareTo("") != 0)
                    sql = "select * from Tb_KhachHang where TenKH LIKE @tenKH";
                else
                    sql = "select * from Tb_KhachHang where DChi LIKE @diachi";
            }
            SqlParameter[] thamso = {   new SqlParameter("@tenKH","%"+tenKH+"%"),
                                        new SqlParameter("@diachi","%"+diachi+"%")
                                        };

            da = ConnectToDB.Truyvan_TraVe_DataAdapter_co_Thamso(sql, thamso);
            return da;
        }
    }