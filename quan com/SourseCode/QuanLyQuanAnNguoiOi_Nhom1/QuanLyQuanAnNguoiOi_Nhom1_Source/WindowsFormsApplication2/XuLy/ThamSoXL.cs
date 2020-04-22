using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

class ThamSoXL
{
    int TuoiMin, TuoiMax, SoLuongTonMin, NghiToiDa;
    double NghiKhongLyDo, DiTre;
    public ThamSoXL()
    {

    }
    //Lay ra Tham So
    public DataTable LayThamSo()
    {
        string sql = "select * from Tb_ThamSo";
        return
             ConnectToDB.TruyVan_TraVe_DataTable(sql);
    }
}