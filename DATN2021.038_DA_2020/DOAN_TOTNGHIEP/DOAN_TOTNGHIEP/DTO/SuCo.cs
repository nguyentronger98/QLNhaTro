using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN_TOTNGHIEP.DTO
{
    public class SuCo
    {
        public SuCo(DataRow row)
        {
            this.MA = row["MA"].ToString();
            this.TIEUDE = row["TIEUDE"].ToString();
            this.NGAY = row["NGAY"].ToString();
            this.NOIDUNG = row["NOIDUNG"].ToString();
            this.MAPHONG = row["MAPHONG"].ToString();
            this.TENPHONG = row["TENPHONG"].ToString();
            this.TINHTRANG = bool.Parse(row["TINHTRANG"].ToString());
        }
        private string _MA;

        public string MA
        {
            get { return _MA; }
            set { _MA = value; }
        }
        private string _TIEUDE;

        public string TIEUDE
        {
            get { return _TIEUDE; }
            set { _TIEUDE = value; }
        }
        private string _NGAY;

        public string NGAY
        {
            get { return _NGAY; }
            set { _NGAY = value; }
        }
        private string _NOIDUNG;

        public string NOIDUNG
        {
            get { return _NOIDUNG; }
            set { _NOIDUNG = value; }
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
        private bool _TINHTRANG;

        public bool TINHTRANG
        {
            get { return _TINHTRANG; }
            set { _TINHTRANG = value; }
        }
    }
}
