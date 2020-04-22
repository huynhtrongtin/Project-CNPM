using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

class ChiTietBangChamCongXL
{
    public string MaBangChamCong, N1, N2, N3, N4, N5, N6, N7, N8, N9, N10, N11, N12, N13, N14, N15, N16, N17, N18, N19, N20, N21, N22, N23, N24, N25, N26, N27, N28, N29, N30, N31;
    //Khoi tao
    public ChiTietBangChamCongXL(string MaBangChamCong,string N1,string N2,string N3,string N4,string N5,string N6,string N7,string N8,string N9,string N10,string N11,string N12,string N13,string N14,string N15,string N16,string N17,string N18,string N19,string N20,string N21,string N22,string N23,string N24,string N25,string N26,string N27,string N28,string N29,string N30,string N31)
    {
        this.MaBangChamCong = MaBangChamCong;
        this.N1=N1;
        this.N2=N2;
        this.N3=N3;
        this.N4=N4;
        this.N5=N5;
        this.N6=N6;
        this.N7=N7;
        this.N8=N8;
        this.N9=N9;
        this.N10=N10;
        this.N11=N11;
        this.N12=N12;
        this.N13=N13;
        this.N14=N14;
        this.N15=N15;
        this.N16=N16;
        this.N17=N17;
        this.N18=N18;
        this.N19=N19;
        this.N20=N20;
        this.N21=N21;
        this.N22=N22;
        this.N23=N23;
        this.N24=N24;
        this.N25=N25;
        this.N26=N26;
        this.N27=N27;
        this.N28=N28;
        this.N29=N29;
        this.N30=N30;
        this.N31=N31;
    }
    //Them chi tiet cham cong
    public bool ThemChiTietChamCong()
    {
        //string sql = "insert into Tb_ChiTietBangChamCong (MaBangChamCong,[1],[2],[3],[4],[5],[6],[7],[8],[9],[10],[11],[12],[13],[14],[15],[16],[17],[18],[19],[20],[21],[22],[23],[24],[25],[26],[27],[28],[29],[30],[31]) values (@MaBangChamCong,@[1],@[2],@[3],@[4],@[5],@[6],@[7],@[8],@[9],@[10],@[11],@[12],@[13],@[14],@[15],@[16],@[17],@[18],@[19],@[20],@[21],@[22],@[23],@[24],@[25],@[26],@[27],@[28],@[29],@[30],@[31])";
        SqlParameter[] thamso = {   new SqlParameter("@MaBangChamCong",this.MaBangChamCong),
                                    new SqlParameter("@[1]",this.N1),
                                    new SqlParameter("@[2]",this.N2),
                                    new SqlParameter("@[3]",this.N3),
                                    new SqlParameter("@[4]",this.N4),
                                    new SqlParameter("@[5]",this.N5),
                                    new SqlParameter("@[6]",this.N6),
                                    new SqlParameter("@[7]",this.N7),
                                    new SqlParameter("@[8]",this.N8),
                                    new SqlParameter("@[9]",this.N9),
                                    new SqlParameter("@[10]",this.N10),
                                    new SqlParameter("@[11]",this.N11),
                                    new SqlParameter("@[12]",this.N12),
                                    new SqlParameter("@[13]",this.N13),
                                    new SqlParameter("@[14]",this.N14),
                                    new SqlParameter("@[15]",this.N15),
                                    new SqlParameter("@[16]",this.N16),
                                    new SqlParameter("@[17]",this.N17),
                                    new SqlParameter("@[18]",this.N18),
                                    new SqlParameter("@[19]",this.N19),
                                    new SqlParameter("@[20]",this.N20),
                                    new SqlParameter("@[21]",this.N21),
                                    new SqlParameter("@[22]",this.N22),
                                    new SqlParameter("@[23]",this.N23),
                                    new SqlParameter("@[24]",this.N24),
                                    new SqlParameter("@[25]",this.N25),
                                    new SqlParameter("@[26]",this.N26),
                                    new SqlParameter("@[27]",this.N27),
                                    new SqlParameter("@[28]",this.N28),
                                    new SqlParameter("@[29]",this.N29),
                                    new SqlParameter("@[30]",this.N30),
                                    new SqlParameter("@[31]",this.N31)};
        string sql = "insert into Tb_ChiTietBangChamCong (MaBangChamCong,[1],[2],[3],[4],[5],[6],[7],[8],[9],[10],[11],[12],[13],[14],[15],[16],[17],[18],[19],[20],[21],[22],[23],[24],[25],[26],[27],[28],[29],[30],[31]) values ('" + this.MaBangChamCong + "',N'" + this.N1 + "',N'" + this.N2 + "',N'" + this.N3 + "',N'" + this.N4 + "',N'" + this.N5 + "',N'" + this.N6 + "',N'" + this.N7 + "',N'" + this.N8 + "',N'" + this.N9 + "',N'" + this.N10 + "',N'" + this.N11 + "',N'" + this.N12 + "',N'" + this.N13 + "',N'" + this.N14 + "',N'" + this.N15 + "',N'" + this.N16 + "',N'" + this.N17 + "',N'" + this.N18 + "',N'" + this.N19 + "',N'" + this.N20 + "',N'" + this.N21 + "',N'" + this.N22 + "',N'" + this.N23 + "',N'" + this.N24 + "',N'" + this.N25 + "',N'" + this.N26 + "',N'" + this.N27 + "',N'" + this.N28 + "',N'" + this.N29 + "',N'" + this.N30 + "',N'" + this.N31 + "')";
        //string sql = "insert into Tb_ChiTietBangChamCong (MaBangChamCong,[1],[2],[3],[4],[5],[6],[7],[8],[9],[10],[11],[12],[13],[14],[15],[16],[17],[18],[19],[20],[21],[22],[23],[24],[25],[26],[27],[28],[29],[30],[31]) values ('MCC001','abc','abc','abc','abc','abc','abc','abc','abc','abc','abc','abc','abc','abc','abc','abc','abc','abc','abc','abc','abc','abc','abc','abc','abc','abc','abc','abc','abc','abc','abc','abc')";
        
        //ConnectToDB.Truyvan_Xuly_co_Thamso(sql, thamso);
        ConnectToDB.TruyVan_XuLy(sql);
        return true;
    }
    //Cap nhat
    public bool CapNhat()
    {
        string sql = "update Tb_ChiTietBangChamCong set [1]=N'"+this.N1+"',[2]=N'"+this.N2+"',[3]=N'"+this.N3+"',[4]=N'"+this.N4+"',[5]=N'"+this.N5+"',[6]=N'"+this.N6+"',[7]=N'"+this.N7+"',[8]=N'"+this.N8+"',[9]=N'"+this.N9+"',[10]=N'"+this.N10+"',[11]=N'"+this.N11+"',[12]=N'"+this.N12+"',[13]=N'"+this.N13+"',[14]=N'"+this.N14+"',[15]=N'"+this.N15+"',[16]=N'"+this.N16+"',[17]=N'"+this.N17+"',[18]=N'"+this.N18+"',[19]=N'"+this.N19+"',[20]=N'"+this.N20+"',[21]=N'"+this.N21+"',[22]=N'"+this.N22+"',[23]=N'"+this.N23+"',[24]=N'"+this.N24+"',[25]=N'"+this.N25+"',[26]=N'"+this.N26+"',[27]=N'"+this.N27+"',[28]=N'"+this.N28+"',[29]=N'"+this.N29+"',[30]=N'"+this.N30+"',[31]=N'"+this.N31+"'"+" where MaBangChamCong='"+this.MaBangChamCong +"'";
        ConnectToDB.TruyVan_XuLy(sql);
        return true;
    }
    //Lay ra bang cham cong ung voi ma cham cong
    public static DataTable layBangChamCong(string MaBangChamCong)
    {
        string sql = "select * from Tb_ChiTietBangChamCong where MaBangChamCong='" + MaBangChamCong + "'";
        DataTable tb = ConnectToDB.TruyVan_TraVe_DataTable(sql);
        return tb;
    }
}
