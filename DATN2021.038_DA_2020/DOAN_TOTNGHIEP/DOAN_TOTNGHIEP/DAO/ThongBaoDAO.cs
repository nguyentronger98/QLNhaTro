using DOAN_TOTNGHIEP.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN_TOTNGHIEP.DAO
{
    public class ThongBaoDAO
    {
        private static ThongBaoDAO instance;

        public static ThongBaoDAO Instance
        {
            get { if (instance == null) instance = new ThongBaoDAO(); return ThongBaoDAO.instance; }
            set { ThongBaoDAO.instance = value; }
        }
        private ThongBaoDAO() { }
        public List<ThongBao> loadThongBao()
        {
            List<ThongBao> lst = new List<ThongBao>();
            string sql = "select * from THONGBAO";
            DataTable dt = DataProvider.Instance.ExecuteQuery(sql);
            foreach (DataRow item in dt.Rows)
            {
                ThongBao pt = new ThongBao(item);
                lst.Add(pt);
            }
            return lst;
        }
        public void Them(string tentieude, string ngay,string noidung,string mact)
        {
            string sql = "insert into THONGBAO(TIEUDE,NGAYDANG,NOIDUNG,MACT) values(N'" + tentieude + "',N'" + String.Format("{0:yyyy/MM/dd}", DateTime.Parse(ngay)) + "',N'" + noidung + "',N'"+mact+"')";
            DataProvider.Instance.ExecuteNonQuery(sql);
        }
        public void Xoa(string ma)
        {
            string sql = "delete from THONGBAO where MA=N'" + ma + "'";
            DataProvider.Instance.ExecuteNonQuery(sql);
        }
        public void Sua(string ma,string tentieude, string ngay, string noidung)
        {
            string sql = "update THONGBAO set TIEUDE=N'" + tentieude + "',NGAYDANG=N'" + String.Format("{0:yyyy/MM/dd}", DateTime.Parse(ngay)) + "',NOIDUNG=N'" + noidung + "' where MA=N'" + ma + "'";
            DataProvider.Instance.ExecuteNonQuery(sql);
        }
        public List<ThongBao> TimKiem(string ten)
        {
            string sql = "select * from THONGBAO where TIEUDE LIKE '%" + ten + "%'";
            List<ThongBao> lst = new List<ThongBao>();
            DataTable dt = DataProvider.Instance.ExecuteQuery(sql);
            foreach (DataRow item in dt.Rows)
            {
                ThongBao pt = new ThongBao(item);
                lst.Add(pt);
            }
            return lst;
        }
    }
}
