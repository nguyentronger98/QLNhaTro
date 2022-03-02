using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DOAN_TOTNGHIEP.DTO;
using System.Data;
using System.Data.SqlClient;

namespace DOAN_TOTNGHIEP.DAO
{
    public class PhongTroDAO
    {
        private static PhongTroDAO instance;

        public static PhongTroDAO Instance
        {
            get { if (instance == null) instance = new PhongTroDAO(); return PhongTroDAO.instance; }
            set { PhongTroDAO.instance = value; }
        }
        private PhongTroDAO() { }
        public List<PhongTro> loadPhongTroList(string ma)
        {
            List<PhongTro> lst = new List<PhongTro>();
            string sql = "select * from PHONG where MAKV=N'" + ma + "'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(sql);
            foreach (DataRow item in dt.Rows)
            {
                PhongTro pt = new PhongTro(item);
                lst.Add(pt);
            }
            return lst;
        }
        public string LayMaPhong()
        {
            string sql = "select TOP 1 MAPHONG from PHONG order by MAPHONG DESC";
            SqlDataReader dr = DataProvider.Instance.getReader(sql);
            string ma = "";
            while (dr.Read())
            {
                ma = dr["MAPHONG"].ToString();
            }
            dr.Close();
            return ma;
        }
        public void Them(string maphong, string tenphong, double giaphong, int songuoi, string makv)
        {
            string sql = "insert into PHONG values(N'" + maphong + "',N'" + tenphong + "',N'" + giaphong + "',N'" + songuoi + "',N'trống',N'" + makv + "')";
            DataProvider.Instance.ExecuteNonQuery(sql);
        }
        public void Sua(string maphong, string tenphong, double giaphong, int songuoi, string makv)
        {
            string sql = "update PHONG set TENPHONG=N'" + tenphong + "',GIAPHONG=N'" + giaphong + "',SONGUOI=N'" + songuoi + "',TINHTRANG=N'trống',MAKV=N'" + makv + "' where MAPHONG=N'" + maphong + "'";
            DataProvider.Instance.ExecuteNonQuery(sql);
        }
        public void Xoa(string maphong)
        {
            string sql = "delete from PHONG where MAPHONG=N'" + maphong + "'";
            DataProvider.Instance.ExecuteNonQuery(sql);
        }
        public List<PhongTro> loadPhongTroListAll()
        {
            List<PhongTro> lst = new List<PhongTro>();
            string sql = "select * from PHONG";
            DataTable dt = DataProvider.Instance.ExecuteQuery(sql);
            foreach (DataRow item in dt.Rows)
            {
                PhongTro pt = new PhongTro(item);
                lst.Add(pt);
            }
            return lst;
        }
        public void SuaTinhTrangPhong(string maphong, string tinhtrang)
        {
            string sql = "Update PHONG set TINHTRANG = N'" + tinhtrang + "' where MAPHONG=N'" + maphong + "'";
            DataProvider.Instance.ExecuteNonQuery(sql);
        }
        public void ChuyenPhong(string mahd, string maphong)
        {
            string sql = "update HOPDONG set MAPHONG=N'" + maphong + "' where MAHD=N'" + mahd + "'";
            DataProvider.Instance.ExecuteNonQuery(sql);
        }
        public List<PhongTro> TimKiem(string ten)
        {
            List<PhongTro> lst = new List<PhongTro>();
            string sql = "select * from HOPDONG where TENPHONG LIKE '%" + ten + "%'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(sql);
            foreach (DataRow item in dt.Rows)
            {
                PhongTro pt = new PhongTro(item);
                lst.Add(pt);
            }
            return lst;
        }
    }
}
