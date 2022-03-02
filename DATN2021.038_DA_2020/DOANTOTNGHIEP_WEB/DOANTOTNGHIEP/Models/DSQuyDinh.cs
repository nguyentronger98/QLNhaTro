using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DOANTOTNGHIEP.Models
{
    public class DSQuyDinh
    {
        public List<QuyDinh> lst;
        public DSQuyDinh()
        { }
        public DSQuyDinh(string strsel)
        {
            KetNoi k = new KetNoi();
            SqlDataAdapter da = new SqlDataAdapter(strsel, k.con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            lst = dt.AsEnumerable().Select(x => new QuyDinh
            {
                MA = (x["MA"]).ToString(),
                NOIDUNG = (x["NOIDUNG"].ToString())
            }).ToList();
        }
    }
}