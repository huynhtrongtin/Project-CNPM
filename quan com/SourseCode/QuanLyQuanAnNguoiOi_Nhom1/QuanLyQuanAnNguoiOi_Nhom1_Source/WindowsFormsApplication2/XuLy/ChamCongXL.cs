using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;


class ChamCongXL
{
    public string MaChamCong, MaNV;
    public int Thang, Nam, SoNgayNghi, SoNgayDiLamTre;
    //Ham khoi tao
    public ChamCongXL()
    {
        
    }
    public ChamCongXL(string MaChamCong,string MaNV,int Thang,int Nam,int SoNgayNghi,int SoNgayDiLamTre)
    {
        this.MaChamCong = MaChamCong;
        this.MaNV = MaNV;
        this.SoNgayDiLamTre = SoNgayDiLamTre;
        this.SoNgayNghi = SoNgayNghi;
        this.Thang = Thang;
        this.Nam = Nam;
    }
    //Them vao bang cham cong
    public bool ThemChamCong()
    {
        string sql = "insert into Tb_ChamCong (MaChamCong,MaNV,Thang,Nam,SoNgayNghi,SoNgayLamTre) values (@MaChamCong,@MaNV,@Thang,@Nam,@SoNgayNghi,@SoNgayLamTre)";
        SqlParameter[] thamso = {   new SqlParameter("@MaChamCong",this.MaChamCong),
                                    new SqlParameter("@MaNV",this.MaNV),
                                    new SqlParameter("@Thang",this.Thang),
                                    new SqlParameter("@Nam",this.Nam),
                                    new SqlParameter("@SoNgayNghi",this.SoNgayNghi),
                                    new SqlParameter("@SoNgayLamTre",this.SoNgayDiLamTre)};

        ConnectToDB.Truyvan_Xuly_co_Thamso(sql, thamso);
        return true;
    }
    //Update ban cham cong
    public bool UpDateChamCong()
    {       
        string sql = "update Tb_ChamCong set SoNgayNghi="+this.SoNgayNghi+" , SoNgayLamTre="+this.SoNgayDiLamTre+" where MaNV='"+this.MaNV+"' AND Thang="+this.Thang+" AND Nam="+this.Nam;        
        ConnectToDB.TruyVan_XuLy(sql);
        return true;
    }
    //Truy Van Lay ra thanh vien cham cong vao thang nam
    public DataTable LayRaChamCongThanhVien(string MaNV,int Thang,int Nam)
    {
        string sql = "select * from Tb_ChamCong where MaNV=@MaNV AND Thang=@Thang AND Nam=@Nam";
        SqlParameter[] thamso ={    new SqlParameter("@MaNV",MaNV),                                    
                                    new SqlParameter("@Thang",Thang),
                                    new SqlParameter("@Nam",Nam)};
        return ConnectToDB.Truyvan_TraVe_Table_co_Thamso(sql, thamso);
    }
    //Truy van lay ra danh sach nam trong bang cham cong
    public DataTable LayRaNam()
    {
        string sql = "select DISTINCT Nam from Tb_ChamCong";
        DataTable dt = ConnectToDB.TruyVan_TraVe_DataTable(sql);
        return dt;
    }
    //Truy van lay ra danh sach thang ung voi nam
    public DataTable LayRaThang(string Nam)
    {
        string sql = "select DISTINCT Thang from Tb_ChamCong where Nam='"+Nam+"'";
        DataTable dt = ConnectToDB.TruyVan_TraVe_DataTable(sql);
        return dt;
    }
}
