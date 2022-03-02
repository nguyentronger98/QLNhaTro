using DOAN_TOTNGHIEP.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN_TOTNGHIEP.DAO
{
    public class QuyDinhDAO
    {
        private static QuyDinhDAO instance;

        public static QuyDinhDAO Instance
        {
            get { if (instance == null) instance = new QuyDinhDAO(); return QuyDinhDAO.instance; }
            set { QuyDinhDAO.instance = value; }
        }
        private QuyDinhDAO() { }
        public List<QuyDinh> loadQuyDinh()
        {
            List<QuyDinh> lst = new List<QuyDinh>();
            string sql = "select * from QUYDINH";
            DataTable dt = DataProvider.Instance.ExecuteQuery(sql);
            foreach (DataRow item in dt.Rows)
            {
                QuyDinh pt = new QuyDinh(item);
                lst.Add(pt);
            }
            return lst;
        }
        public void Them(string ngay,string noidung,string mact)
        {
            string sql = "insert into QUYDINH(NGAY,NOIDUNG,MACT) values(N'" + String.Format("{0:yyyy/MM/dd}", DateTime.Parse(ngay)) + "',N'" + noidung + "',N'"+mact+"')";
            DataProvider.Instance.ExecuteNonQuery(sql);
        }
        public void Xoa(string ma)
        {
            string sql = "delete from QUYDINH where MA=N'" + ma + "'";
            DataProvider.Instance.ExecuteNonQuery(sql);
        }
        public void Sua(string ma, string ngay, string noidung)
        {
            string sql = "update QUYDINH set NGAY=N'" + String.Format("{0:yyyy/MM/dd}", DateTime.Parse(ngay)) + "',NOIDUNG=N'" + noidung + "' where MA=N'" + ma + "'";
            DataProvider.Instance.ExecuteNonQuery(sql);
        }
        public List<QuyDinh> TimKiem(string ten)
        {
            string sql = "select * from QUYDINH where NOIDUNG LIKE '%" + ten + "%'";
            List<QuyDinh> lst = new List<QuyDinh>();
            DataTable dt = DataProvider.Instance.ExecuteQuery(sql);
            foreach (DataRow item in dt.Rows)
            {
                QuyDinh pt = new QuyDinh(item);
                lst.Add(pt);
            }
            return lst;
        }
    }
}
