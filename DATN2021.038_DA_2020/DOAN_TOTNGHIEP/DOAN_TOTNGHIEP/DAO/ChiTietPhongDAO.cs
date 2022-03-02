using DOAN_TOTNGHIEP.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN_TOTNGHIEP.DAO
{
    public class ChiTietPhongDAO
    {
        private static ChiTietPhongDAO instance;

        public static ChiTietPhongDAO Instance
        {
            get { if (instance == null) instance = new ChiTietPhongDAO(); return ChiTietPhongDAO.instance; }
            set { ChiTietPhongDAO.instance = value; }
        }
        private ChiTietPhongDAO() { }
        public List<ChiTietPhong> loadDSCTPhong()
        {
            List<ChiTietPhong> lst = new List<ChiTietPhong>();
            string sql = "select ct.MAPHONG,p.TENPHONG,ct.MATB,b.TENTB,ct.SOLUONG from CHITIETPHONG ct, PHONG p, THIETBI b where ct.MAPHONG = p.MAPHONG and ct.MATB = b.MATB";
            DataTable dt = DataProvider.Instance.ExecuteQuery(sql);
            foreach (DataRow item in dt.Rows)
            {
                ChiTietPhong pt = new ChiTietPhong(item);
                lst.Add(pt);
            }
            return lst;
        }
        public bool KTraTonTai(string maphong, string matb)
        {
            int kq = loadDSCTPhong().Where(t => t.MAPHONG == maphong && t.MATB == matb).ToList().Count;
            if (kq >= 1)
            {
                return true;
            }
            return false;
        }
        public void Them(string maphong, string matb, int sl)
        {
            string sql = "insert into CHITIETPHONG values(N'" + maphong + "',N'" + matb + "',N'" + sl + "')";
            DataProvider.Instance.ExecuteNonQuery(sql);
        }
        public void Xoa(string maphong, string matb)
        {
            string sql = "delete from CHITIETPHONG where MAPHONG=N'" + maphong + "' and MATB =N'" + matb + "'";
            DataProvider.Instance.ExecuteNonQuery(sql);
        }
        public void Sua(string maphong, string matb, int sl)
        {
            string sql = "update CHITIETPHONG set SOLUONG=N'" + sl + "' where MAPHONG=N'" + maphong + "' and MATB =N'" + matb + "'";
            DataProvider.Instance.ExecuteNonQuery(sql);
        }
        //public List<ThietBi> TimKiem(string tenkv)
        //{
        //    string sql = "select * from thietbi where TENTB LIKE '%" + tenkv + "%'";
        //    List<ThietBi> lst = new List<ThietBi>();
        //    DataTable dt = DataProvider.Instance.ExecuteQuery(sql);
        //    foreach (DataRow item in dt.Rows)
        //    {
        //        ThietBi pt = new ThietBi(item);
        //        lst.Add(pt);
        //    }
        //    return lst;
        //}
    }
}
