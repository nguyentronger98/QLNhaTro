using DOAN_TOTNGHIEP.DTO;
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
    public class ThietBiDAO
    {
        private static ThietBiDAO instance;

        public static ThietBiDAO Instance
        {
            get { if (instance == null) instance = new ThietBiDAO(); return ThietBiDAO.instance; }
            set { ThietBiDAO.instance = value; }
        }
        private ThietBiDAO() { }
        public List<ThietBi> loadDSThietBi()
        {
            List<ThietBi> lst = new List<ThietBi>();
            string sql = "select * from THIETBI";
            DataTable dt = DataProvider.Instance.ExecuteQuery(sql);
            foreach (DataRow item in dt.Rows)
            {
                ThietBi pt = new ThietBi(item);
                lst.Add(pt);
            }
            return lst;
        }
        public string LayMa()
        {
            string sql = "select TOP 1 MATB from THIETBI order by MATB DESC";
            SqlDataReader dr = DataProvider.Instance.getReader(sql);
            string ma = "";
            while (dr.Read())
            {
                ma = dr["MATB"].ToString();
            }
            dr.Close();
            return ma;
        }
        public void Them(string ma, string ten)
        {
            string sql = "insert into THIETBI values(N'" + ma + "',N'" + ten + "')";
            DataProvider.Instance.ExecuteNonQuery(sql);
        }
        public void Xoa(string ma)
        {
            string sql = "delete from THIETBI where MATB=N'" + ma + "'";
            DataProvider.Instance.ExecuteNonQuery(sql);
        }
        public void Sua(string ma, string ten)
        {
            string sql = "update THIETBI set TENTB=N'" + ten + "' where MATB=N'" + ma + "'";
            DataProvider.Instance.ExecuteNonQuery(sql);
        }
        public List<ThietBi> TimKiem(string tenkv)
        {
            string sql = "select * from THIETBI where TENTB LIKE '%" + tenkv + "%'";
            List<ThietBi> lst = new List<ThietBi>();
            DataTable dt = DataProvider.Instance.ExecuteQuery(sql);
            foreach (DataRow item in dt.Rows)
            {
                ThietBi pt = new ThietBi(item);
                lst.Add(pt);
            }
            return lst;
        }
    }
}
