using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DOANTOTNGHIEP.Models
{
    public class ListWard
    {
        public List<Ward> lstward;
        public ListWard()
        { }
        public ListWard(string strsel)
        {
            KetNoi k = new KetNoi();
            SqlDataAdapter da = new SqlDataAdapter(strsel, k.con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            lstward = dt.AsEnumerable().Select(x => new Ward
            {
                id_xa = int.Parse(x["id"].ToString()),
                name = (x["_name"].ToString()),
                prefix = (x["_prefix"].ToString()),
                id_tinh = int.Parse(x["_province_id"].ToString()),
                id_huyen = int.Parse(x["_district_id"].ToString())
            }).ToList();
        }
    }
}