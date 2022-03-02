using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DOANTOTNGHIEP.Models
{
    public class ListProvince
    {
        public List<Province> lstpro;
        public ListProvince()
        { }
        public ListProvince(string strsel)
        {
            KetNoi k = new KetNoi();
            SqlDataAdapter da = new SqlDataAdapter(strsel, k.con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            lstpro = dt.AsEnumerable().Select(x => new Province
            {
                id = int.Parse(x["id"].ToString()),
                name = (x["_name"].ToString()),
                code = (x["_code"].ToString())
            }).ToList();
        }
    }
}