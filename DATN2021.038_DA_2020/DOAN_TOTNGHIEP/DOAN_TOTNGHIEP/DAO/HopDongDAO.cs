using DOAN_TOTNGHIEP.DTO;
using System.Collections.Generic;
using System.Data;
using System;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN_TOTNGHIEP.DAO
{
    public class HopDongDAO
    {
        DataProvider da = new DataProvider();
        private static HopDongDAO instance;

        public static HopDongDAO Instance
        {
            get { if (instance == null) instance = new HopDongDAO(); return HopDongDAO.instance; }
            set { HopDongDAO.instance = value; }
        }
        private HopDongDAO() { }
        public List<HopDong> loadHopList()
        {
            List<HopDong> lst = new List<HopDong>();
            string sql = "select * from HOPDONG hd,PHONG p where hd.MAPHONG = p.MAPHONG";
            DataTable dt = DataProvider.Instance.ExecuteQuery(sql);
            foreach (DataRow item in dt.Rows)
            {
                HopDong pt = new HopDong(item);
                lst.Add(pt);
            }
            return lst;
        }
        public List<HopDong> DSHDSapHetHan()
        {
            List<HopDong> lst = new List<HopDong>();
            string sql = "select MAHD,NGAYHD,HOTENNT,NGAYSINHNT,NOIDKHK,CMNDNT,SDTNT,DIACHITHUE,GIATHUE,HINHTHUCTHANHTOAN,NGAYBATDAU,NGAYKETTHUC,SONGUOIO,MAPHONG from HOPDONG";
            DataTable dt = DataProvider.Instance.ExecuteQuery(sql);
            foreach (DataRow item in dt.Rows)
            {
                HopDong pt = new HopDong(item);
                lst.Add(pt);
            }
            return lst;
        }
        public string LayMaHD()
        {
            string sql = "select TOP 1 MAHD from HOPDONG order by MAHD DESC";
            SqlDataReader dr = DataProvider.Instance.getReader(sql);
            string ma = "";
            while (dr.Read())
            {
                ma = dr["MAHD"].ToString();
            }
            dr.Close();
            da.ClosedConnection();
            return ma;
        }
        public void ThemHopDong(string mahd, string ngayhd,string hotennt,string ngaysinhnt,string noidkhk, string cmndnt, string ngaycapcmndnt, string noicapcmndnt,string email, string sdtnt, string diachithue, double giathue, string hinhthuctt, double tiencoc, double tiendien, double tiennuoc, string ngaybd, string ngaykt, int songuoio, string matkhau, string tinhtrang, string ghichu, string maphong, string mact)
        {
            string sql = "Insert into HOPDONG values(N'" + mahd + "',N'" + String.Format("{0:yyyy/MM/dd}", DateTime.Parse(ngayhd)) + "',N'" + hotennt + "',N'" + String.Format("{0:yyyy/MM/dd}", DateTime.Parse(ngaysinhnt)) + "',N'" + noidkhk + "',N'" + cmndnt + "',N'" + String.Format("{0:yyyy/MM/dd}", DateTime.Parse(ngaycapcmndnt)) + "',N'" + noicapcmndnt + "',N'"+email+"',N'" + sdtnt + "',N'" + diachithue + "',N'" + giathue + "',N'" + hinhthuctt + "',N'" + tiencoc + "',N'" + tiendien + "',N'" + tiennuoc + "',N'" + String.Format("{0:yyyy/MM/dd}", DateTime.Parse(ngaybd)) + "',N'" + String.Format("{0:yyyy/MM/dd}", DateTime.Parse(ngaykt)) + "',N'" + songuoio + "',N'" + matkhau + "',N'" + tinhtrang + "',N'" + ghichu + "',N'" + mact + "',N'" + maphong + "')";
            DataProvider.Instance.ExecuteNonQuery(sql);
        }
        //public void Xoa(string mahd)
        //{
        //    string sql = "delete from hopdong where MAHD='" + mahd + "'";
        //    DataProvider.Instance.ExecuteNonQuery(sql);
        //}
        public void Sua(string mahd,string hotennt,string ngaysinhnt,string noidkhk, string cmndnt, string ngaycapcmndnt, string noicapcmndnt,string email, string sdtnt, string ngaykt, int songuoio)
        {
            string sql = "Update HOPDONG set HOTENNT=N'" + hotennt + "',NGAYSINHNT=N'" + ngaysinhnt + "',NOIDKHK=N'" + noidkhk + "',CMNDNT=N'" + cmndnt + "',NGAYCAPCMNDNT=N'" + ngaycapcmndnt + "',NOICAPCMNDNT=N'" + noicapcmndnt + "',EMAIL=N'"+email+"',SDTNT=N'" + sdtnt + "',NGAYKETTHUC=N'" + String.Format("{0:yyyy/MM/dd}", DateTime.Parse(ngaykt)) + "',SONGUOIO=N'" + songuoio + "' where MAHD=N'" + mahd + "'";
            DataProvider.Instance.ExecuteNonQuery(sql);
        }
        public void KetThucHopDong(string mahd)
        {
            string sql = "Update HOPDONG set TINHTRANG = 'False' where MAHD='" + mahd + "'";
            DataProvider.Instance.ExecuteNonQuery(sql);
        }
    }
}
