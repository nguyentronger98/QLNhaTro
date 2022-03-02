using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DOANTOTNGHIEP.Models
{
    public class DSHoaDon
    {
         public List<HoaDon> lstHD;
        public DSHoaDon()
        { }
        public DSHoaDon(string strsel)
        {
            KetNoi k = new KetNoi();
            SqlDataAdapter da = new SqlDataAdapter(strsel,k.con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            lstHD = dt.AsEnumerable().Select(x => new HoaDon
            {
                MAHD = (x["MaHD"]).ToString(),
                MAPHONG = (x["MAPHONG"].ToString()),
                NGAYHD = (x["Ngay"].ToString()),
                DATHANHTOAN =bool.Parse(x["DaThanhToan"].ToString()),
                TIENPHONG = (x["TienPhong"].ToString()),

            }).ToList();
        }
    }
}