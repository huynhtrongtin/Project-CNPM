using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Data.SqlClient;

    class DatComXL
    {
        public string maKH{get;set;}
        public string ngayDat{get;set;}
        public string ngayNhan{get;set;}
        public string maMonAn{get;set;}
        public int soLuong{get;set;}
        public float donGia{get;set;}
        public DatComXL()
        { 
        }
        public DatComXL(string MaKH, string NgayDat, string NgayNhan, string MaMonAn, int SoLuong, float DonGia)
        {
            this.maKH = MaKH;
            this.ngayDat = NgayDat;
            this.ngayNhan = NgayNhan;
            this.maMonAn = MaMonAn;
            this.soLuong = SoLuong;
            this.donGia = DonGia;
        }
        public bool ThemVaoDonDH()
        {
            //Them vao co so du lieu            
            string sql = "insert into Tb_DonDatHang (MaKH,NgayDat,NgayNhan,MaMonAn,SoLuong,DonGia) values (@MaKH,@NgayDat,@NgayNhan,@MaMonAn,@SoLuong,@DonGia)";
            SqlParameter[] thamso = {  
                                            new SqlParameter("@MaKH",this.maKH),
                                            new SqlParameter("@NgayDat",this.ngayDat),
                                            new SqlParameter("@NgayNhan",this.ngayNhan),
                                            new SqlParameter("@MaMonAn",this.maMonAn),
                                            new SqlParameter("@SoLuong",this.soLuong),
                                            new SqlParameter("@DonGia",this.donGia)};
            ConnectToDB.Truyvan_Xuly_co_Thamso(sql, thamso);
            return true;
        }
    }
