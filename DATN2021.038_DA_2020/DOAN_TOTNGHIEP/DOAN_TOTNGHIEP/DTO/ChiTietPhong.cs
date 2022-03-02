using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN_TOTNGHIEP.DTO
{
    public class ChiTietPhong
    {
        public ChiTietPhong(string maphong,string tenphong, string matb, string tentb, int sl)
        {
            this.MAPHONG = maphong;
            this.TENPHONG = tenphong;
            this.MATB = matb;
            this.TENTB = tentb;
            this.SOLUONG = sl;
        }
        public ChiTietPhong() { }
        public ChiTietPhong(DataRow row)
        {
            this.MAPHONG = row["MAPHONG"].ToString();
            this.TENPHONG = row["TENPHONG"].ToString();
            this.MATB = row["MATB"].ToString();
            this.TENTB = row["TENTB"].ToString();
            this.SOLUONG = int.Parse(row["SOLUONG"].ToString());
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
        private string _MATB;

        public string MATB
        {
            get { return _MATB; }
            set { _MATB = value; }
        }
        private string _TENTB;

        public string TENTB
        {
            get { return _TENTB; }
            set { _TENTB = value; }
        }
        private int _SOLUONG;

        public int SOLUONG
        {
            get { return _SOLUONG; }
            set { _SOLUONG = value; }
        }
    }
}
