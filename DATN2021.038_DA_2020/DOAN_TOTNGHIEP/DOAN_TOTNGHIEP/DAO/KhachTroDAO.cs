using DOAN_TOTNGHIEP.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN_TOTNGHIEP.DAO
{
    public class KhachTroDAO
    {
        private static KhachTroDAO instance;

        public static KhachTroDAO Instance
        {
            get { if (instance == null) instance = new KhachTroDAO(); return KhachTroDAO.instance; }
            set { KhachTroDAO.instance = value; }
        }
        private KhachTroDAO() { }
        public List<KhachTro> DSKhachTro()
        {
            List<KhachTro> lst = new List<KhachTro>();
            string sql = "SELECT nk.MA,nk.HOTEN,nk.NGAYSINH, nk.GIOITINH, nk.NOISINH,nk.NGUYENQUAN,nk.DANTOC,nk.TONGIAO,nk.QUOCTICH,nk.CMNDSO,nk.HOCHIEUSO,nk.NOITHUONGTRU,nk.DIACHIHIENTAI,nk.NGHENGHIEPNOILAMVIEC,nk.TINHTRANG,nk.MAHD,nk.HINHTHE,nk.CHUPHONG,hd.MAPHONG,p.TENPHONG FROM KHACHTRO nk, HOPDONG hd, PHONG p where nk.MAHD = hd.MAHD and hd.MAPHONG = p.MAPHONG";
            DataTable dt = DataProvider.Instance.ExecuteQuery(sql);
            foreach (DataRow item in dt.Rows)
            {
                KhachTro pt = new KhachTro(item);
                lst.Add(pt);
            }
            return lst;
        }
        public void RoiPhong(string ma)
        {
            string sql = "update KHACHTRO set TINHTRANG = 'False' where MA =N'" + ma + "'";
            DataProvider.Instance.ExecuteNonQuery(sql);
        }
        public void TraPhong(string mahd)
        {
            string sql = "update KHACHTRO set TINHTRANG = 'False' where MAHD =N'" + mahd + "'";
            DataProvider.Instance.ExecuteNonQuery(sql);
        }
        //public string LayMaKT()
        //{
        //string sql = "select MAKT from khachtro order by MAKT DESC LIMIT 1";
        //string ma = "";
        //using (MySqlDataReader reader = DataProvider.Instance.getReader(sql))
        //{
        //    // Kiểm tra có kết quả trả về
        //    if (reader.HasRows)
        //    {
        //        // Đọc từng dòng kết quả cho đế hết
        //        while (reader.Read())
        //        {
        //            ma = reader[0].ToString();
        //        }
        //    }
        //}
        //return ma;
        //}
        public void Them(string hoten, string ngaysinh, string noithuongtru, string cmnd, string mahd,string sdt, string email)
        {
            string sql = "Insert into KHACHTRO(HOTEN,NGAYSINH,NOITHUONGTRU,CMNDSO,MAHD,TINHTRANG,SDT,EMAIL,CHUPHONG) values(N'" + hoten + "',N'" + String.Format("{0:yyyy/MM/dd}", DateTime.Parse(ngaysinh)) + "',N'" + noithuongtru + "',N'" + cmnd + "',N'" + mahd + "','True',N'" + sdt + "',N'" + email + "','True')";
            DataProvider.Instance.ExecuteNonQuery(sql);
        }
        public void CapNhatChuPhong(string makt, string chuphong)
        {
            string sql = "update KHACHTRO set CHUPHONG =N'" + chuphong + "' where MA =N'" + makt + "'";
            DataProvider.Instance.ExecuteNonQuery(sql);
        }
        public bool KtraSLNguoiO(string mahd)
        {
            int kq = DSKhachTro().Where(t => t.MAHD == mahd && t.TINHTRANG == true).ToList().Count;
            int hd = HopDongDAO.Instance.loadHopList().FirstOrDefault(t=>t.MAHD == mahd && t.TINHTRANG == true).SONGUOIO;
            if (kq >= hd)
                return true;
            return false;
        }
        public void TiepTucTro(string makhach, string mahd)
        {
            string sql = "update KHACHTRO set MAHD =N'" + mahd + "', TINHTRANG ='True' where MA=N'" + makhach + "'";
            DataProvider.Instance.ExecuteNonQuery(sql);
        }
        public List<KhachTro> TimKiem(string tenkhach)
        {
            string sql = "SELECT nk.MA,nk.HOTEN,nk.NGAYSINH, nk.GIOITINH, nk.NOISINH,nk.NGUYENQUAN,nk.DANTOC,nk.TONGIAO,nk.QUOCTICH,nk.CMNDSO,nk.HOCHIEUSO,nk.NOITHUONGTRU,nk.DIACHIHIENTAI,nk.NGHENGHIEPNOILAMVIEC,nk.TINHTRANG,nk.MAHD,nk.HINHTHE,nk.CHUPHONG,hd.MAPHONG,p.TENPHONG FROM KHACHTRO nk, HOPDONG hd, PHONG p where nk.MAHD = hd.MAHD and hd.MAPHONG = p.MAPHONG and nk.HOTEN LIKE '%" + tenkhach + "%'";
            List<KhachTro> lst = new List<KhachTro>();
            DataTable dt = DataProvider.Instance.ExecuteQuery(sql);
            foreach (DataRow item in dt.Rows)
            {
                KhachTro pt = new KhachTro(item);
                lst.Add(pt);
            }
            return lst;
        }
        public bool KtraChuPhong(string makhach, string mahd)
        {
            int kq = DSKhachTro().Where(t => t.MAKT == makhach && t.MAHD == mahd && t.CHUPHONG==true && t.TINHTRANG == true).ToList().Count;
            if (kq > 0)
                return true;
            return false;
        }
        //public void Xoa(string makt)
        //{
        //    string sql = "delete from khachtro where MAKT='" + makt + "'";
        //    DataProvider.Instance.ExecuteNonQuery(sql);
        //}
        //public void Sua(string makt, string hoten, string cmnd, string noicapcmnd, string ngaysinh, string noithuongtru, string sdt, bool trangthai, string maphong)
        //{
        //    string sql = "Update hopdong set HOTEN='" + hoten + "',CMND='" + cmnd + "',NOICAPCMND='" + noicapcmnd + "',NGAYSINH='" + ngaysinh + "',NOITHUONGTRU='" + noithuongtru + "',SDT='" + sdt + "',TRANGTHAI='" + trangthai + "',MAPHONG='" + maphong + "' where MAKT='" + makt + "'";
        //    DataProvider.Instance.ExecuteNonQuery(sql);
        //}
    }
}
