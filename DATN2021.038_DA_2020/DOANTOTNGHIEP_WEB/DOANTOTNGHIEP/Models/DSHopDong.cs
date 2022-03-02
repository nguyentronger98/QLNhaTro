using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DOANTOTNGHIEP.Models
{
    public class DSHopDong
    {
        public List<hopdong> lsthopdong;
        public DSHopDong()
        { }
        public DSHopDong(string strsel)
        {
            KetNoi k = new KetNoi();
            SqlDataAdapter da = new SqlDataAdapter(strsel, k.con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            lsthopdong = dt.AsEnumerable().Select(x => new hopdong
            {
                MAHD = (x["MAHD"]).ToString(),
                MATKHAU = (x["MATKHAU"].ToString()),
                HOTENNT = (x["HOTENNT"].ToString()),
                SONGUOIO = int.Parse(x["SONGUOIO"].ToString()),
                MAPHONG = (x["MAPHONG"].ToString()),
                NGAYSINHNT = DateTime.Parse(x["NGAYSINHNT"].ToString()),
                NOIDKHK = x["NOIDKHK"].ToString(),
                SDTNT = x["SDTNT"].ToString(),
                DIACHITHUE = x["DIACHITHUE"].ToString(),
                GIATHUE = float.Parse(x["GIATHUE"].ToString()),
                TIENCOC = float.Parse(x["TIENCOC"].ToString()),
                TIENDIEN = float.Parse(x["TIENDIEN"].ToString()),
                TIENNUOC = float.Parse(x["TIENNUOC"].ToString()),
                NGAYBATDAU = DateTime.Parse(x["NGAYBATDAU"].ToString()),
                NGAYKETTHUC = DateTime.Parse(x["NGAYKETTHUC"].ToString()),
                EMAIL = (x["EMAIL"].ToString())
            }).ToList();
        }
    }
}