using DOAN_TOTNGHIEP.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN_TOTNGHIEP.DAO
{
    public class SuCoDAO
    {
        private static SuCoDAO instance;

        public static SuCoDAO Instance
        {
            get { if (instance == null) instance = new SuCoDAO(); return SuCoDAO.instance; }
            set { SuCoDAO.instance = value; }
        }
        private SuCoDAO() { }
        public List<SuCo> loadDSSuCo()
        {
            List<SuCo> lst = new List<SuCo>();
            string sql = "select * from SUCO s,PHONG p where s.MAPHONG = p.MAPHONG";
            DataTable dt = DataProvider.Instance.ExecuteQuery(sql);
            foreach (DataRow item in dt.Rows)
            {
                SuCo pt = new SuCo(item);
                lst.Add(pt);
            }
            return lst;
        }
        public List<SuCo> TimKiem(string ngay)
        {
            List<SuCo> lst = new List<SuCo>();
            string sql = "select * from SUCO s,PHONG p where s.MAPHONG = p.MAPHONG and s.NGAY =N'"+String.Format("{0:yyyy/MM/dd}",DateTime.Parse(ngay))+"'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(sql);
            foreach (DataRow item in dt.Rows)
            {
                SuCo pt = new SuCo(item);
                lst.Add(pt);
            }
            return lst;
        }
    }
}
