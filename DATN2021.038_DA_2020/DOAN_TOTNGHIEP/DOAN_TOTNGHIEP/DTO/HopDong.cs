using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN_TOTNGHIEP.DTO
{
    public class HopDong
    {
        public HopDong()
        {

        }
        public HopDong(DataRow row)
        {
            this.MAHD = row["MAHD"].ToString();
            this.NGAYHD = (DateTime)row["NGAYHD"];
            this.HOTENNT = row["HOTENNT"].ToString();
            this.NGAYSINHNT = (DateTime)row["NGAYSINHNT"];
            this.NOIDKHK = row["NOIDKHK"].ToString();
            this.CMNDNT = row["CMNDNT"].ToString();
            this.NGAYCAPCMNDNT = row["NGAYCAPCMNDNT"].ToString();
            this.NOICAPCMNDNT = row["NOICAPCMNDNT"].ToString();
            this.SDTNT = row["SDTNT"].ToString();
            this.DIACHITHUE = row["DIACHITHUE"].ToString();
            this.GIATHUE = float.Parse(row["GIATHUE"].ToString());
            this.HINHTHUCTHANHTOAN = row["HINHTHUCTHANHTOAN"].ToString();
            this.TIENDIEN = float.Parse(row["TIENDIEN"].ToString());
            this.TIENNUOC = float.Parse(row["TIENNUOC"].ToString());
            this.NGAYBATDAU = (DateTime)row["NGAYBATDAU"];
            this.NGAYKETTHUC = (DateTime)row["NGAYKETTHUC"];
            this.SONGUOIO = int.Parse(row["SONGUOIO"].ToString());
            this.MATKHAU = row["MATKHAU"].ToString();
            this.TINHTRANG = bool.Parse(row["TINHTRANG"].ToString());
            this.GHICHU = row["GHICHU"].ToString();
            this.MACT = row["MACT"].ToString();
            this.MAPHONG = row["MAPHONG"].ToString();
            this.TENPHONG = row["TENPHONG"].ToString();
            this.TIENCOC = double.Parse(row["TIENCOC"].ToString());
        }
        private string _MAHD;

        public string MAHD
        {
            get { return _MAHD; }
            set { _MAHD = value; }
        }
        private DateTime _NGAYHD;

        public DateTime NGAYHD
        {
            get { return _NGAYHD; }
            set { _NGAYHD = value; }
        }
        private string _HOTENNT;

        public string HOTENNT
        {
            get { return _HOTENNT; }
            set { _HOTENNT = value; }
        }
        private DateTime _NGAYSINHNT;

        public DateTime NGAYSINHNT
        {
            get { return _NGAYSINHNT; }
            set { _NGAYSINHNT = value; }
        }
        private string _NOIDKHK;

        public string NOIDKHK
        {
            get { return _NOIDKHK; }
            set { _NOIDKHK = value; }
        }
        private string _CMNDNT;

        public string CMNDNT
        {
            get { return _CMNDNT; }
            set { _CMNDNT = value; }
        }
        private string _NGAYCAPCMNDNT;

        public string NGAYCAPCMNDNT
        {
            get { return _NGAYCAPCMNDNT; }
            set { _NGAYCAPCMNDNT = value; }
        }
        private string _NOICAPCMNDNT;

        public string NOICAPCMNDNT
        {
            get { return _NOICAPCMNDNT; }
            set { _NOICAPCMNDNT = value; }
        }
        private string _SDTNT;

        public string SDTNT
        {
            get { return _SDTNT; }
            set { _SDTNT = value; }
        }
        private string _DIACHITHUE;

        public string DIACHITHUE
        {
            get { return _DIACHITHUE; }
            set { _DIACHITHUE = value; }
        }
        private double _GIATHUE;

        public double GIATHUE
        {
            get { return _GIATHUE; }
            set { _GIATHUE = value; }
        }
        private string _HINHTHUCTHANHTOAN;

        public string HINHTHUCTHANHTOAN
        {
            get { return _HINHTHUCTHANHTOAN; }
            set { _HINHTHUCTHANHTOAN = value; }
        }
        private double _TIENCOC;

        public double TIENCOC
        {
            get { return _TIENCOC; }
            set { _TIENCOC = value; }
        }
        private double _TIENDIEN;

        public double TIENDIEN
        {
            get { return _TIENDIEN; }
            set { _TIENDIEN = value; }
        }
        private double _TIENNUOC;

        public double TIENNUOC
        {
            get { return _TIENNUOC; }
            set { _TIENNUOC = value; }
        }
        private DateTime _NGAYBATDAU;

        public DateTime NGAYBATDAU
        {
            get { return _NGAYBATDAU; }
            set { _NGAYBATDAU = value; }
        }
        private DateTime _NGAYKETTHUC;

        public DateTime NGAYKETTHUC
        {
            get { return _NGAYKETTHUC; }
            set { _NGAYKETTHUC = value; }
        }
        private int _SONGUOIO;

        public int SONGUOIO
        {
            get { return _SONGUOIO; }
            set { _SONGUOIO = value; }
        }
        private string _MATKHAU;

        public string MATKHAU
        {
            get { return _MATKHAU; }
            set { _MATKHAU = value; }
        }
        private bool _TINHTRANG;

        public bool TINHTRANG
        {
            get { return _TINHTRANG; }
            set { _TINHTRANG = value; }
        }
        private string _GHICHU;

        public string GHICHU
        {
            get { return _GHICHU; }
            set { _GHICHU = value; }
        }
        private string _MACT;

        public string MACT
        {
            get { return _MACT; }
            set { _MACT = value; }
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

    }
}
