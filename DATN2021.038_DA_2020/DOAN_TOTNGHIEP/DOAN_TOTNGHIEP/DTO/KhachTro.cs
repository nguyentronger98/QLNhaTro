using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN_TOTNGHIEP.DTO
{
    public class KhachTro
    {
        public KhachTro(DataRow row)
        {
            this.MAKT = row["MA"].ToString();
            this.HOTEN = row["HOTEN"].ToString();
            this.CMND = row["CMNDSO"].ToString();
            this.NGAYSINH = row["NGAYSINH"].ToString();
            this.NOISINH = row["NOISINH"].ToString();
            this.GIOITINH = row["GIOITINH"].ToString();
            this.NOITHUONGTRU = row["NOITHUONGTRU"].ToString();
            this.MAHD = row["MAHD"].ToString();
            this.HINHTHE = row["HINHTHE"].ToString();
            this.DIACHIHIENTAI = row["DIACHIHIENTAI"].ToString();
            this.NGHENGHIEPNOILAMVIEC = row["NGHENGHIEPNOILAMVIEC"].ToString();
            this.TINHTRANG = bool.Parse(row["TINHTRANG"].ToString());
            this.CHUPHONG = bool.Parse(row["CHUPHONG"].ToString());
            this.DANTOC = row["DANTOC"].ToString();
            this.QUOCTICH = row["QUOCTICH"].ToString();
            this.HOCHIEUSO = row["HOCHIEUSO"].ToString();
            this.TONGIAO = row["TONGIAO"].ToString();
            this.NGUYENQUAN = row["NGUYENQUAN"].ToString();
            this.MAPHONG = row["MAPHONG"].ToString();
            this.TENPHONG = row["TENPHONG"].ToString();
        }
        private string _MAPHONG;

        public string MAPHONG
        {
            get { return _MAPHONG; }
            set { _MAPHONG = value; }
        }
        private string _TENPHONG;

        public string TENPHONG
        {
            get { return _TENPHONG; }
            set { _TENPHONG = value; }
        }
        private string _NGUYENQUAN;

        public string NGUYENQUAN
        {
            get { return _NGUYENQUAN; }
            set { _NGUYENQUAN = value; }
        }
        private string _DANTOC;

        public string DANTOC
        {
            get { return _DANTOC; }
            set { _DANTOC = value; }
        }
        private string _TONGIAO;

        public string TONGIAO
        {
            get { return _TONGIAO; }
            set { _TONGIAO = value; }
        }
        private string _QUOCTICH;

        public string QUOCTICH
        {
            get { return _QUOCTICH; }
            set { _QUOCTICH = value; }
        }
        private string _HOCHIEUSO;

        public string HOCHIEUSO
        {
            get { return _HOCHIEUSO; }
            set { _HOCHIEUSO = value; }
        }
        private string _HINHTHE;

        public string HINHTHE
        {
            get { return _HINHTHE; }
            set { _HINHTHE = value; }
        }
        private string _MAKT;

        public string MAKT
        {
            get { return _MAKT; }
            set { _MAKT = value; }
        }
        private string _HOTEN;

        public string HOTEN
        {
            get { return _HOTEN; }
            set { _HOTEN = value; }
        }
        private string _CMND;

        public string CMND
        {
            get { return _CMND; }
            set { _CMND = value; }
        }
        private string _NGAYSINH;

        public string NGAYSINH
        {
            get { return _NGAYSINH; }
            set { _NGAYSINH = value; }
        }
        private string _NOISINH;

        public string NOISINH
        {
            get { return _NOISINH; }
            set { _NOISINH = value; }
        }
        private string _GIOITINH;

        public string GIOITINH
        {
            get { return _GIOITINH; }
            set { _GIOITINH = value; }
        }
        private string _NOITHUONGTRU;

        public string NOITHUONGTRU
        {
            get { return _NOITHUONGTRU; }
            set { _NOITHUONGTRU = value; }
        }
        private string _DIACHIHIENTAI;

        public string DIACHIHIENTAI
        {
            get { return _DIACHIHIENTAI; }
            set { _DIACHIHIENTAI = value; }
        }
        private string _NGHENGHIEPNOILAMVIEC;

        public string NGHENGHIEPNOILAMVIEC
        {
            get { return _NGHENGHIEPNOILAMVIEC; }
            set { _NGHENGHIEPNOILAMVIEC = value; }
        }
        private bool _TINHTRANG;

        public bool TINHTRANG
        {
            get { return _TINHTRANG; }
            set { _TINHTRANG = value; }
        }
        private string _MAHD;

        public string MAHD
        {
            get { return _MAHD; }
            set { _MAHD = value; }
        }
        private bool _CHUPHONG;

        public bool CHUPHONG
        {
            get { return _CHUPHONG; }
            set { _CHUPHONG = value; }
        }

    }
}
