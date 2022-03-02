using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN_TOTNGHIEP.DTO
{
    public class PhongTro
    {
        public PhongTro(string maphong, string tenphong, double giaphong, int songuoi, string tinhtrang, string makv)
        {
            this.MAPHONG = maphong;
            this.TENPHONG = tenphong;
            this.GIAPHONG = giaphong;
            this.SONGUOI = songuoi;
            this.TINHTRANG = tinhtrang;
            this.MAKV = makv;
        }
        public PhongTro(DataRow row)
        {
            this.MAPHONG = row["MAPHONG"].ToString();
            this.TENPHONG = row["TENPHONG"].ToString();
            this.GIAPHONG = double.Parse(row["GIAPHONG"].ToString());
            this.TINHTRANG = row["TINHTRANG"].ToString();
            this.SONGUOI = (int)row["SONGUOI"];
            this.MAKV = row["MAKV"].ToString();
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
        private double _GIAPHONG;

        public double GIAPHONG
        {
            get { return _GIAPHONG; }
            set { _GIAPHONG = value; }
        }
        private int _SONGUOI;

        public int SONGUOI
        {
            get { return _SONGUOI; }
            set { _SONGUOI = value; }
        }
        private string _TINHTRANG;

        public string TINHTRANG
        {
            get { return _TINHTRANG; }
            set { _TINHTRANG = value; }
        }
        private string _MAKV;

        public string MAKV
        {
            get { return _MAKV; }
            set { _MAKV = value; }
        }
    }
}
