using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DOANTOTNGHIEP.Models
{
    public class DSThietBi
    {
        public List<ThietBi> lstthietbi;
        public DSThietBi()
        { }
        public DSThietBi(string strsel)
        {
            KetNoi k = new KetNoi();
            SqlDataAdapter da = new SqlDataAdapter(strsel, k.con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            lstthietbi = dt.AsEnumerable().Select(x => new ThietBi
            {
                MATB = (x["MATB"]).ToString(),
                TENTB = (x["TENTB"].ToString()),
                SOLUONG = int.Parse(x["SOLUONG"].ToString()),
                MAPHONG = (x["MAPHONG"].ToString())
            }).ToList();
        }
    }
}