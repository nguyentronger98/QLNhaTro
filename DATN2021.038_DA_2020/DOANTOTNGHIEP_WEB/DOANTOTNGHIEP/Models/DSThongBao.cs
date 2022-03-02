using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DOANTOTNGHIEP.Models
{
    public class DSThongBao
    {
        public List<ThongBao> lst;
        public DSThongBao()
        { }
        public DSThongBao(string strsel)
        {
            KetNoi k = new KetNoi();
            SqlDataAdapter da = new SqlDataAdapter(strsel, k.con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            lst = dt.AsEnumerable().Select(x => new ThongBao
            {
                MA = (x["MA"]).ToString(),
                TENTIEUDE = (x["TIEUDE"].ToString()),
                NGAYDANG = (x["NGAYDANG"].ToString()),
                NOIDUNG = (x["NOIDUNG"].ToString())

            }).ToList();
        }
    }
}