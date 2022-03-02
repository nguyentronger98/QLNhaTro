using DOAN_TOTNGHIEP.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN_TOTNGHIEP.DAO
{
    public class provinceDAO
    {
        private static provinceDAO instance;

        public static provinceDAO Instance
        {
            get { if (instance == null) instance = new provinceDAO(); return provinceDAO.instance; }
            set { provinceDAO.instance = value; }
        }
        private provinceDAO() { }
        public List<province> loadTinh()
        {
            List<province> lst = new List<province>();
            string sql = "select * from province";
            DataTable dt = DataProvider.Instance.ExecuteQuery(sql);
            foreach (DataRow item in dt.Rows)
            {
                province pt = new province(item);
                lst.Add(pt);
            }
            return lst;
        }
    }
}
