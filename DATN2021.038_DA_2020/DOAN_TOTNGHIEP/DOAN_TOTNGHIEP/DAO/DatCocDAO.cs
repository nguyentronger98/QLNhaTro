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
    public class DatCocDAO
    {
        private static DatCocDAO instance;

        public static DatCocDAO Instance
        {
            get { if (instance == null) instance = new DatCocDAO(); return DatCocDAO.instance; }
            set { DatCocDAO.instance = value; }
        }
        private DatCocDAO() { }
        public List<DatCoc> loadDatCoc()
        {
            List<DatCoc> lst = new List<DatCoc>();
            string sql = "select * from DATCOC dc, PHONG p where dc.MAPHONG = p.MAPHONG";
            DataTable dt = DataProvider.Instance.ExecuteQuery(sql);
            foreach (DataRow item in dt.Rows)
            {
                DatCoc pt = new DatCoc(item);
                lst.Add(pt);
            }
            return lst;
        }
        public string LayMaCoc()
        {
            string sql = "select TOP 1 MACOC from DATCOC order by MAPHONG DESC";
            SqlDataReader dr = DataProvider.Instance.getReader(sql);
            string ma = "";
            while (dr.Read())
            {
                ma = dr["MACOC"].ToString();
            }
            dr.Close();
            return ma;
        }
        public void Them(string macoc, string ngaydat, string hoten, string sdt, string diachi, double tiencoc, string maphong)
        {
            string sql = "insert into DATCOC values(N'" + macoc + "',N'" + hoten + "',N'" + sdt + "',N'" + String.Format("{0:yyyy/MM/dd}", DateTime.Parse(ngaydat)) + "',N'" + diachi + "',N'" + tiencoc + "','True',N'" + maphong + "')";
            DataProvider.Instance.ExecuteNonQuery(sql);
        }
        public void Sua(string macoc, string ngaydat, string hoten, string sdt, string diachi, double tiencoc)
        {
            string sql = "update DATCOC set NGAYDAT=N'" + String.Format("{0:yyyy/MM/dd}", DateTime.Parse(ngaydat)) + "',HOTEN=N'" + hoten + "',SDT=N'" + sdt + "',DIACHI=N'" + diachi + "',TIENCOC=N'" + tiencoc + "' where MACOC=N'" + macoc + "'";
            DataProvider.Instance.ExecuteNonQuery(sql);
        }
        public void Xoa(string macoc)
        {
            string sql = "delete from DATCOC where MACOC=N'" + macoc + "'";
            DataProvider.Instance.ExecuteNonQuery(sql);
        }
        public void SuaTinhTrangCoc(string ma)
        {
            string sql = "update DATCOC set TINHTRANG='0' where MACOC=N'" + ma + "'";
            DataProvider.Instance.ExecuteNonQuery(sql);
        }
        //public List<PhongTro> TimKiem(string ten)
        //{
        //    List<PhongTro> lst = new List<PhongTro>();
        //    string sql = "select * from phong where TENPHONG LIKE '%" + ten + "%'";
        //    DataTable dt = DataProvider.Instance.ExecuteQuery(sql);
        //    foreach (DataRow item in dt.Rows)
        //    {
        //        PhongTro pt = new PhongTro(item);
        //        lst.Add(pt);
        //    }
        //    return lst;
        //}
    }
}
