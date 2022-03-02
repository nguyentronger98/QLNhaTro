using DOAN_TOTNGHIEP.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN_TOTNGHIEP.DAO
{
    public class DichVu_PhongDAO
    {
        private static DichVu_PhongDAO instance;

        public static DichVu_PhongDAO Instance
        {
            get { if (instance == null) instance = new DichVu_PhongDAO(); return DichVu_PhongDAO.instance; }
            set { DichVu_PhongDAO.instance = value; }
        }
        private DichVu_PhongDAO() { }
        public List<DichVu_Phong> loadDVTheoPhong(string ma)
        {
            List<DichVu_Phong> lst = new List<DichVu_Phong>();
            string sql = "select * from DICHVU_PHONG dvp, DICHVU dv where dvp.MaDV = dv.MaDV and MAPHONG='" + ma + "'";
            DataTable dt = DataProvider.Instance.ExecuteQuery(sql);
            foreach (DataRow item in dt.Rows)
            {
                DichVu_Phong pt = new DichVu_Phong(item);
                lst.Add(pt);
            }
            return lst;
        }
    }
}
