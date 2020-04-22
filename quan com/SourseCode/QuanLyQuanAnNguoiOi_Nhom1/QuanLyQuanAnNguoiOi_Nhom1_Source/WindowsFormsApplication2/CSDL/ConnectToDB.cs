using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;

using System.Xml.Linq;
using System.Data.SqlClient;
using System.Net;
using System.Net.Mail;

/// <summary>
/// Summary description for ConnectToDB
/// </summary>
public class ConnectToDB
{
	public ConnectToDB()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public static SqlConnection taoketnoi()
    {
        string chuoi = "Data Source=(local)\\SQLEXPRESS;Initial Catalog=DB_QuanComNguoiOi;Integrated Security=True";

        SqlConnection con = new SqlConnection(chuoi);
        con.Open();
        return con;
    }
    public static DataTable TruyVan_TraVe_DataTable(string strSQL)
    {
        SqlConnection con = taoketnoi();
        SqlDataAdapter da = new SqlDataAdapter(strSQL, con);
        DataTable dt = new DataTable();
        da.Fill(dt);
        return dt;
    }
    public static int TruyVan_XuLy(string strSQL)
    {
        try
        {
            SqlConnection con = taoketnoi();
            SqlCommand cmd = new SqlCommand(strSQL, con);
            int sodong = cmd.ExecuteNonQuery();
            return sodong;
        }
        catch (Exception e)
        {
            return -1;
        }
    }    
    public static int Truyvan_Xuly_co_Thamso(string strSQL, SqlParameter[] thamso)
    {
        try
        {
            SqlConnection con = taoketnoi();
            SqlCommand cmd = new SqlCommand(strSQL, con);
            for (int i = 0; i < thamso.Length; i++)
            {
                cmd.Parameters.Add(thamso[i]);
            }
            int sodong = cmd.ExecuteNonQuery();
            return sodong;

        }
        catch (Exception e)
        {
            return -1;
        }

    }
    public static DataTable Truyvan_TraVe_Table_co_Thamso(string strSQL, SqlParameter[] thamso)
    {
        try
        {
            SqlConnection con = taoketnoi();
            SqlCommand cmd = new SqlCommand(strSQL, con);
            for (int i = 0; i < thamso.Length; i++)
            {
                cmd.Parameters.Add(thamso[i]);
            }
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }
        catch (Exception e)
        {
            return null;
        }

    }

    public static SqlDataAdapter Truyvan_TraVe_DataAdapter_co_Thamso(string strSQL, SqlParameter[] thamso)
    {
        try
        {
            SqlConnection con = taoketnoi();
            SqlCommand cmd = new SqlCommand(strSQL, con);
            for (int i = 0; i < thamso.Length; i++)
            {
                cmd.Parameters.Add(thamso[i]);
            }
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            return da;
        }
        catch (Exception e)
        {
            return null;
        }

    }

    public static string tao_chuoi_so_ngaunhien(int chieudai)
    {
        string randomStr = "";
        int[] myIntArray = new int[chieudai];
        int x;
        //That is to create the random # and add it to our string
        Random autoRand = new Random();
        for (x = 0; x < chieudai; x++)
        {
            myIntArray[x] = System.Convert.ToInt32(autoRand.Next(0, 9));
            randomStr += (myIntArray[x].ToString());
        }
        return randomStr;
    }
    public static string SinhMaNhanVien()
    {
        string ma = "";
        string sql = "SELECT MaNV FROM Tb_ThongTinNhanVien ORDER BY MaNV DESC";
        DataTable dt = ConnectToDB.TruyVan_TraVe_DataTable(sql);
        if (dt.Rows.Count == 0)
            return "NV001";
        string temp = dt.Rows[0][0].ToString();
        //Lay ve ID hien tai
        //temp = temp.Substring(4,3);
        int i = int.Parse(temp.Substring(2, 3));
        i += 1;
        int so = 3;//So luong sach toi da, vi du: 3 chu so
        String so0 = "";
        for (int j = 1; j <= so; j++)
        {
            if (i.ToString().Length == j)
            {
                for (int k = 0; k < so - j; k++)
                    so0 += "0";
                break;
            }
        }
        ma = "NV" + so0 + i.ToString();
        return ma;
    }
    public static string SinhMaMonAn()
    {
        string ma = "";
        string sql = "SELECT MaMonAn FROM Tb_MonAn ORDER BY MaMonAn DESC";
        DataTable dt = ConnectToDB.TruyVan_TraVe_DataTable(sql);
        if (dt.Rows.Count == 0)
            return "MMA001";
        string temp = dt.Rows[0][0].ToString();
        //Lay ve ID hien tai
        //temp = temp.Substring(4,3);
        int i = int.Parse(temp.Substring(3, 3));
        i += 1;
        int so = 3;//So luong sach toi da, vi du: 3 chu so
        String so0 = "";
        for (int j = 1; j <= so; j++)
        {
            if (i.ToString().Length == j)
            {
                for (int k = 0; k < so - j; k++)
                    so0 += "0";
                break;
            }
        }
        ma = "MMA" + so0 + i.ToString();
        return ma;
    }

    public static string SinhMaKhachHang()
    {
        string ma = "";
        string sql = "SELECT MaKH FROM Tb_KhachHang ORDER BY MaKH DESC";
        DataTable dt = ConnectToDB.TruyVan_TraVe_DataTable(sql);
        if (dt.Rows.Count == 0)
            return "KH001";
        string temp = dt.Rows[0][0].ToString();
        //Lay ve ID hien tai
        //temp = temp.Substring(4,3);
        int i = int.Parse(temp.Substring(2, 3));
        i += 1;
        int so = 3;//So luong sach toi da, vi du: 3 chu so
        String so0 = "";
        for (int j = 1; j <= so; j++)
        {
            if (i.ToString().Length == j)
            {
                for (int k = 0; k < so - j; k++)
                    so0 += "0";
                break;
            }
        }
        ma = "KH" + so0 + i.ToString();
        return ma;
    }
    public static string SinhMaHoaDonNhapKho()
    {
        string ma = "";
        string sql = "SELECT MaHDNK FROM Tb_HoaDonNhapKho ORDER BY MaHDNK DESC";
        DataTable dt = ConnectToDB.TruyVan_TraVe_DataTable(sql);
        if (dt.Rows.Count == 0)
            return "HDNK001";
        string temp = dt.Rows[0][0].ToString();
        //Lay ve ID hien tai
        //temp = temp.Substring(4,3);
        int i = int.Parse(temp.Substring(4, 3));
        i += 1;
        int so = 3;//So luong sach toi da, vi du: 3 chu so
        String so0 = "";
        for (int j = 1; j <= so; j++)
        {
            if (i.ToString().Length == j)
            {
                for (int k = 0; k < so - j; k++)
                    so0 += "0";
                break;
            }
        }
        ma = "HDNK" + so0 + i.ToString();
        return ma;
    }
    public static string SinhMaHoaDonXuatKho()
    {
        string ma = "";
        string sql = "SELECT MaHDXK FROM Tb_HoaDonXuatKho ORDER BY MaHDXK DESC";
        DataTable dt = ConnectToDB.TruyVan_TraVe_DataTable(sql);
        if (dt.Rows.Count == 0)
            return "HDXK001";
        string temp = dt.Rows[0][0].ToString();
        //Lay ve ID hien tai
        //temp = temp.Substring(4,3);
        int i = int.Parse(temp.Substring(4, 3));
        i += 1;
        int so = 3;//So luong sach toi da, vi du: 3 chu so
        String so0 = "";
        for (int j = 1; j <= so; j++)
        {
            if (i.ToString().Length == j)
            {
                for (int k = 0; k < so - j; k++)
                    so0 += "0";
                break;
            }
        }
        ma = "HDXK" + so0 + i.ToString();
        return ma;
    }
    public static string SinhMaThucPham()
    {
        string ma = "";
        string sql = "SELECT MaThucPham FROM Tb_ThucPhamTonKho ORDER BY MaThucPham DESC";
        DataTable dt = ConnectToDB.TruyVan_TraVe_DataTable(sql);
        if (dt.Rows.Count == 0)
            return "TP001";
        string temp = dt.Rows[0][0].ToString();
        //Lay ve ID hien tai
        //temp = temp.Substring(4,3);
        int i = int.Parse(temp.Substring(2, 3));
        i += 1;
        int so = 3;//So luong sach toi da, vi du: 3 chu so
        String so0 = "";
        for (int j = 1; j <= so; j++)
        {
            if (i.ToString().Length == j)
            {
                for (int k = 0; k < so - j; k++)
                    so0 += "0";
                break;
            }
        }
        ma = "TP" + so0 + i.ToString();
        return ma;
    }
    public static string SinhMaChamCong()
    {
        string ma = "";
        string sql = "SELECT MaChamCong FROM Tb_ChamCong ORDER BY MaChamCong DESC";
        DataTable dt = ConnectToDB.TruyVan_TraVe_DataTable(sql);
        if (dt.Rows.Count == 0)
            return "MCC001";
        string temp = dt.Rows[0][0].ToString();
        //Lay ve ID hien tai
        //temp = temp.Substring(4,3);
        int i = int.Parse(temp.Substring(3, 3));
        i += 1;
        int so = 3;//So luong sach toi da, vi du: 3 chu so
        String so0 = "";
        for (int j = 1; j <= so; j++)
        {
            if (i.ToString().Length == j)
            {
                for (int k = 0; k < so - j; k++)
                    so0 += "0";
                break;
            }
        }
        ma = "MCC" + so0 + i.ToString();
        return ma;
    }
}