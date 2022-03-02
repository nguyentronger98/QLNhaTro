using DOAN_TOTNGHIEP.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN_TOTNGHIEP.DAO
{
    public class DangKyDAO
    {
        private static DangKyDAO instance;

        public static DangKyDAO Instance
        {
            get { if (instance == null) instance = new DangKyDAO(); return DangKyDAO.instance; }
            set { DangKyDAO.instance = value; }
        }
        private DangKyDAO() { }
        public List<DangKy> loadDSDangKyTro()
        {
            List<DangKy> lst = new List<DangKy>();
            string sql = "select * from DANGKY";
            DataTable dt = DataProvider.Instance.ExecuteQuery(sql);
            foreach (DataRow item in dt.Rows)
            {
                DangKy pt = new DangKy(item);
                lst.Add(pt);
            }
            return lst;
        }
    }
}
