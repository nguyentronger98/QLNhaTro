using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN_TOTNGHIEP.DTO
{
    public class DatCoc
    {
        public DatCoc(string macoc, string ngaydat, string hoten, string sdt, string diachi, double tiencoc, string maphong)
        {
            this.MACOC = macoc;
            this.NGAYDAT = ngaydat;
            this.HOTEN = hoten;
            this.SDT = sdt;
            this.DIACHI = diachi;
            this.TIENCOC = tiencoc;
            this.MAPHONG = maphong;
        }
        public DatCoc(DataRow row)
        {
            this.MACOC = row["MACOC"].ToString();
            this.NGAYDAT = DateTime.Parse(row["NGAYDAT"].ToString()).ToShortDateString();
            this.HOTEN = row["HOTEN"].ToString();
            this.SDT = row["SDT"].ToString();
            this.DIACHI = row["DIACHI"].ToString();
            this.TIENCOC = double.Parse(row["TIENCOC"].ToString());
            this.MAPHONG = row["MAPHONG"].ToString();
            this.TINHTRANG = bool.Parse(row["TINHTRANG"].ToString());
            this.TENPHONG = row["TENPHONG"].ToString();
        }
        private string _MACOC;

        public string MACOC
        {
            get { return _MACOC; }
            set { _MACOC = value; }
        }
        private string _NGAYDAT;

        public string NGAYDAT
        {
            get { return _NGAYDAT; }
            set { _NGAYDAT = value; }
        }
        private string _HOTEN;

        public string HOTEN
        {
            get { return _HOTEN; }
            set { _HOTEN = value; }
        }
        private string _SDT;

        public string SDT
        {
            get { return _SDT; }
            set { _SDT = value; }
        }
        private string _DIACHI;

        public string DIACHI
        {
            get { return _DIACHI; }
            set { _DIACHI = value; }
        }
        private double _TIENCOC;

        public double TIENCOC
        {
            get { return _TIENCOC; }
            set { _TIENCOC = value; }
        }
        private string _MAPHONG;

        public string MAPHONG
        {
            get { return _MAPHONG; }
            set { _MAPHONG = value; }
        }
        private bool _TINHTRANG;

        public bool TINHTRANG
        {
            get { return _TINHTRANG; }
            set { _TINHTRANG = value; }
        }
        private string _TENPHONG;

        public string TENPHONG
        {
            get { return _TENPHONG; }
            set { _TENPHONG = value; }
        }
    }
}
