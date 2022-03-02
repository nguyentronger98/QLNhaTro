using DOAN_TOTNGHIEP.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN_TOTNGHIEP.DAO
{
    public class DangNhapDAO
    {
        private static DangNhapDAO instance;

        public static DangNhapDAO Instance
        {
            get { if (instance == null) instance = new DangNhapDAO(); return DangNhapDAO.instance; }
            set { DangNhapDAO.instance = value; }
        }
        private DangNhapDAO() { }
        public List<DangNhap> loadDSDangNhap()
        {
            List<DangNhap> lst = new List<DangNhap>();
            string sql = "select * from DANGNHAP";
            DataTable dt = DataProvider.Instance.ExecuteQuery(sql);
            foreach (DataRow item in dt.Rows)
            {
                DangNhap pt = new DangNhap(item);
                lst.Add(pt);
            }
            return lst;
        }
        public bool KiemTraTaiKhoan(string tentk, string mk)
        {
            DangNhap dn = loadDSDangNhap().SingleOrDefault(t => t.MAID.Trim() == tentk && t.MATKHAU.Trim() == mk);
            if(dn == null)
            {
                return false;
            }
            return true;
        }
        public void DoiMatKhau(string tentk, string matkhaumoi)
        {
            string sql = "Update DANGNHAP set MATKHAU ='" + matkhaumoi + "' where MAID='" + tentk + "'";
            DataProvider.Instance.ExecuteNonQuery(sql);
        }
    }
}
