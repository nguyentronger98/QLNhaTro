using System.Data;
using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DOANTOTNGHIEP.Models
{
    public class DSPhong
    {
        public List<phong> lstphong;
        public DSPhong()
        { }
        public DSPhong(string strsel)
        {
            KetNoi k = new KetNoi();
            SqlDataAdapter da = new SqlDataAdapter(strsel, k.con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            lstphong = dt.AsEnumerable().Select(x => new phong
            {
                MAPHONG = (x["MAPHONG"]).ToString(),
                TENPHONG = (x["TENPHONG"].ToString())
            }).ToList();
        }
    }
}