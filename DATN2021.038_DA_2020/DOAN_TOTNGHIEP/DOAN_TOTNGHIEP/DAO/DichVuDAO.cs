using DOAN_TOTNGHIEP.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN_TOTNGHIEP.DAO
{
    public class DichVuDAO
    {
        private static DichVuDAO instance;

        public static DichVuDAO Instance
        {
            get { if (instance == null) instance = new DichVuDAO(); return DichVuDAO.instance; }
            set { DichVuDAO.instance = value; }
        }
        private DichVuDAO() { }
        public List<DichVu> loadDichVu()
        {
            List<DichVu> lst = new List<DichVu>();
            string sql = "select * from DICHVU";
            DataTable dt = DataProvider.Instance.ExecuteQuery(sql);
            foreach (DataRow item in dt.Rows)
            {
                DichVu pt = new DichVu(item);
                lst.Add(pt);
            }
            return lst;
        }
    }
}
