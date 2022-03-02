using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DOANTOTNGHIEP.Models
{
    public class ListDistrict
    {
        public List<District> lstdis;
        public ListDistrict()
        { }
        public ListDistrict(string strsel)
        {
            KetNoi k = new KetNoi();
            SqlDataAdapter da = new SqlDataAdapter(strsel, k.con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            lstdis = dt.AsEnumerable().Select(x => new District
            {
                id_huyen = int.Parse(x["id"].ToString()),
                name = (x["_name"].ToString()),
                prefix = (x["_prefix"].ToString()),
                province_id = int.Parse(x["_province_id"].ToString())
            }).ToList();
        }
    }
}