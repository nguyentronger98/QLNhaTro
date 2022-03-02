using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Data;

namespace DOANTOTNGHIEP.Models
{
    public class KetNoi
    {
        string connect = @"Data Source=DESKTOP-A71C3Q3\SQLEXPRESS;Initial Catalog=ql_nhatro;User ID=sa;Password=sql2014";
        public SqlConnection con;
        public KetNoi()
        {
            string strcn = System.Configuration.ConfigurationManager.ConnectionStrings["ql_phongtro"].ConnectionString;
            con = new SqlConnection(strcn);
        }
    }
}