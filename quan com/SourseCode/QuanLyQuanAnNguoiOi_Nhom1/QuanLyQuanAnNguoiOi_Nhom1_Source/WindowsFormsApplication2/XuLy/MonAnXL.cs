using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Data.SqlClient;

    public class MonAnXL
    {
        public string maMonAn { get; set; }
        public string tenMonAn { get; set; }
        public float DonGia { get; set; }
        public MonAnXL()
        {
            this.DonGia = 0;
        }
        public MonAnXL(string MaMA, string TenMA, float dongia)
        {
            this.maMonAn = MaMA;
            this.tenMonAn = TenMA;
            this.DonGia = dongia;
        }
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
        public bool ThemMonAn()
        {
            //Them vao co so du lieu            
            string sql = "insert into Tb_MonAn (MaMonAn,TenMonAn,DonGia) values (@MaMA,@TenMA,@Gia)";
            SqlParameter[] thamso = {       new SqlParameter("@MaMA",this.maMonAn),
                                            new SqlParameter("@TenMA",this.tenMonAn),
                                            new SqlParameter("@Gia",this.DonGia)
                                    };
            ConnectToDB.Truyvan_Xuly_co_Thamso(sql, thamso);
            return true;
        }
        //Truy van lay ra bang mon an
        public string GiaMonAn(string MaMA)
        {
            string sql = "select DonGia from Tb_MonAn where MaMonAn='" + MaMA + "'";
            DataTable dt = ConnectToDB.TruyVan_TraVe_DataTable(sql);
            return dt.Rows[0][0].ToString();
        }
        //Lay ra thong tin mon an
        public DataTable DanhSachMonAn()
        {
            string sql = "select * from Tb_MonAn";
            return ConnectToDB.TruyVan_TraVe_DataTable(sql);
        }
        public string TimMaMA(string tenMA)
        {
            string sql = "select MaMonAn from Tb_MonAn where TenMonAn='" + tenMA + "'";
            DataTable dt = ConnectToDB.TruyVan_TraVe_DataTable(sql);
            return dt.Rows[0][0].ToString();
        }
        
        public DataTable TraCuuMonAn(String tenMA, String maxcost, String mincost)
        {
            if (tenMA == "")
            {
                if (maxcost == "" || int.Parse(maxcost) == 0)
                {
                    MessageBox.Show("Nhập lại giá muốn tìm");
                    return null;
                }
                else
                {
                    string sql = "select TenMonAn,DonGia from Tb_MonAn where DonGia between '" + mincost + "' and '" + maxcost + "'";
                    DataTable dt = ConnectToDB.TruyVan_TraVe_DataTable(sql);
                    return dt;
                }

            }
            else
            {
                if (maxcost == "" || int.Parse(maxcost) == 0)
                {
                    if (mincost == "" || int.Parse(mincost) == 0)
                    {
                        string sql = "";
                        sql = "select TenMonAn,DonGia from Tb_MonAn where TenMonAn='" + tenMA + "'";
                        DataTable dt = ConnectToDB.TruyVan_TraVe_DataTable(sql);
                        //MessageBox.Show(dt.Rows[0][0].ToString());
                        return dt;
                    }
                    else
                    {
                        MessageBox.Show("Nhập lại giá muốn tìm kiếm");
                        return null;
                    }
                }
                else
                {
                    string sql = "";
                    sql = "select * from (select TenMonAn,DonGia from Tb_MonAn where TenMonAn='" + tenMA + "') AS tam where tam.DonGia between '" + mincost + "' and '" + maxcost + "'";
                    DataTable dt = ConnectToDB.TruyVan_TraVe_DataTable(sql);
                    //MessageBox.Show(dt.Rows[0][0].ToString());
                    return dt;
                }
            }
            return null;
        }
    }