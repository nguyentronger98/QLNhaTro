using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN_TOTNGHIEP.DAO
{
    public class DataProvider
    {
        private string ketnoi = @"Data Source=DESKTOP-A71C3Q3\SQLEXPRESS;Initial Catalog=ql_nhatro;User ID=sa;Password=sql2014";
        private static DataProvider instance;

        public static DataProvider Instance
        {
            get { if (instance == null) instance = new DataProvider(); return DataProvider.instance; }
            private set { DataProvider.instance = value; }
        }
        private SqlConnection Con;

        public SqlConnection Con1
        {
            get { return Con; }
            set { Con = value; }
        }
        public DataProvider()
        {
            Con = new SqlConnection(ketnoi);
        }
        public void OpenConnection()
        {
            if (Con.State == ConnectionState.Closed)
                Con.Open();

        }
        public void ClosedConnection()
        {
            if (Con.State == ConnectionState.Open)
                Con.Close();
        }
        public void disposeConnection()
        {
            if (Con.State == ConnectionState.Open)
                Con.Close();
            Con.Dispose();
        }
        public DataTable ExecuteQuery(string sql)
        {
            DataTable dt = new DataTable();
            OpenConnection();
            SqlCommand cmd = new SqlCommand(sql, Con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }
        public DataTable GetData(string sql)
        {
            DataTable dt = new DataTable();
            OpenConnection();
            SqlDataAdapter da = new SqlDataAdapter(sql,Con);
            da.Fill(dt);
            return dt;
        }
        public SqlDataReader getReader(string sql)
        {
            SqlCommand cmd;
            OpenConnection();
            cmd = new SqlCommand(sql);
            cmd.Connection = Con;
            return cmd.ExecuteReader();
        }
        public void ExecuteNonQuery(string sql)
        {
            OpenConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sql;
            cmd.Connection = Con;
            cmd.ExecuteNonQuery();
            ClosedConnection();
        }
    }
}
