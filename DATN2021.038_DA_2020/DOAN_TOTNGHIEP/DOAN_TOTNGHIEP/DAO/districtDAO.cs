using DOAN_TOTNGHIEP.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN_TOTNGHIEP.DAO
{
    public class districtDAO
    {
        private static districtDAO instance;

        public static districtDAO Instance
        {
            get { if (instance == null) instance = new districtDAO(); return districtDAO.instance; }
            set { districtDAO.instance = value; }
        }
        private districtDAO() { }
        public List<district> loadHuyen(string ma)
        {
            List<district> lst = new List<district>();
            string sql = "select * from district where _province_id ='" + ma + "'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(sql);
            foreach (DataRow item in dt.Rows)
            {
                district pt = new district(item);
                lst.Add(pt);
            }
            return lst;
        }
    }
}
