using DOAN_TOTNGHIEP.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN_TOTNGHIEP.DAO
{
    public class ChuTroDAO
    {
        private static ChuTroDAO instance;

        public static ChuTroDAO Instance
        {
            get { if (instance == null) instance = new ChuTroDAO(); return ChuTroDAO.instance; }
            set { ChuTroDAO.instance = value; }
        }
        private ChuTroDAO() { }
        public List<ChuTro> loadDSCT()
        {
            List<ChuTro> lst = new List<ChuTro>();
            string sql = "select * from CHUTRO";
            DataTable dt = DataProvider.Instance.ExecuteQuery(sql);
            foreach (DataRow item in dt.Rows)
            {
                ChuTro pt = new ChuTro(item);
                lst.Add(pt);
            }
            return lst;
        }
        //public ChuTro ThongTinCT(string ma)
        //{
        //    string sql = "select * from chutro where MACT='" + ma + "'";
        //    DataTable dt = DataProvider.Instance.ExecuteQuery(sql);
        //    ChuTro ct;
        //    if (dt.Rows.Count > 0)
        //    {
        //        ct = new ChuTro(dt.Rows[0]);
        //    }
        //    return ct.;
        //}
    }
}
