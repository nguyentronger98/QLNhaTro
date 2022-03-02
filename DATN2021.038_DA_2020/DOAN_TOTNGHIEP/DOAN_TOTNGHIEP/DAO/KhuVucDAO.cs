using DOAN_TOTNGHIEP.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN_TOTNGHIEP.DAO
{
    public class KhuVucDAO
    {
        private static KhuVucDAO instance;

        public static KhuVucDAO Instance
        {
            get { if (instance == null) instance = new KhuVucDAO(); return KhuVucDAO.instance; }
            set { KhuVucDAO.instance = value; }
        }
        private KhuVucDAO() { }
        public List<KhuVuc> loadKhuVucList()
        {
            List<KhuVuc> lst = new List<KhuVuc>();
            string sql = "select * from KHUVUC";
            DataTable dt = DataProvider.Instance.ExecuteQuery(sql);
            foreach (DataRow item in dt.Rows)
            {
                KhuVuc pt = new KhuVuc(item);
                lst.Add(pt);
            }
            return lst;
        }
        public string LayMaKV()
        {
            string sql = "select TOP 1 MAKV from KHUVUC order by MAKV DESC";
            SqlDataReader dr = DataProvider.Instance.getReader(sql);
            string ma = "";
            while (dr.Read())
            {
                ma = dr["MAKV"].ToString();
            }
            dr.Close();
            return ma;
        }
        public void Them(string makv, string tenkv)
        {
            string sql = "insert into KHUVUC values(N'" + makv + "',N'" + tenkv + "')";
            DataProvider.Instance.ExecuteNonQuery(sql);
        }
        public void Xoa(string makv)
        {
            string sql = "delete from KHUVUC where MAKV=N'" + makv + "'";
            DataProvider.Instance.ExecuteNonQuery(sql);
        }
        public void Sua(string makv, string tenkv)
        {
            string sql = "update KHUVUC set TENKV=N'" + tenkv + "' where MAKV=N'" + makv + "'";
            DataProvider.Instance.ExecuteNonQuery(sql);
        }
        public List<KhuVuc> TimKiem(string tenkv)
        {
            string sql = "select * from KHUVUC where TENKV LIKE '%" + tenkv + "%'";
            List<KhuVuc> lst = new List<KhuVuc>();
            DataTable dt = DataProvider.Instance.ExecuteQuery(sql);
            foreach (DataRow item in dt.Rows)
            {
                KhuVuc pt = new KhuVuc(item);
                lst.Add(pt);
            }
            return lst;
        }
    }
}
