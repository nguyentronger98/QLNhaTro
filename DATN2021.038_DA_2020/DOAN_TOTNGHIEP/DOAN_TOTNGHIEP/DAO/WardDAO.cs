using DOAN_TOTNGHIEP.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN_TOTNGHIEP.DAO
{
    public class WardDAO
    {
        private static WardDAO instance;

        public static WardDAO Instance
        {
            get { if (instance == null) instance = new WardDAO(); return WardDAO.instance; }
            set { WardDAO.instance = value; }
        }
        private WardDAO() { }
        public List<Ward> loadXa(string ma)
        {
            List<Ward> lst = new List<Ward>();
            string sql = "select * from ward where _district_id ='" + ma + "'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(sql);
            foreach (DataRow item in dt.Rows)
            {
                Ward pt = new Ward(item);
                lst.Add(pt);
            }
            return lst;
        }
    }
}
