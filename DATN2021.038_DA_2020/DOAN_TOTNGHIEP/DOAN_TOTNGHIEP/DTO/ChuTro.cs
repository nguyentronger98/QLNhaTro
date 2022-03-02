using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN_TOTNGHIEP.DTO
{
    public class ChuTro
    {
        public ChuTro()
        {

        }
        public ChuTro(string mact, string hoten, string cmnd, string sdt, string diachi, DateTime ngaysinh, string noicapcmnd)
        {
            this.MACT = mact;
            this.HOTEN = hoten;
            this.CMND = cmnd;
            this.SDT = sdt;
            this.DIACHI = diachi;
            this.NGAYSINH = ngaysinh;
            this.NOICAPCMND = noicapcmnd;
        }
        public ChuTro(DataRow row)
        {
            this.MACT = row["MACT"].ToString();
            this.HOTEN = row["HOTEN"].ToString();
            this.CMND = row["CMND"].ToString();
            this.SDT = row["SDT"].ToString();
            this.DIACHI = row["DIACHI"].ToString();
            this.NGAYSINH = DateTime.Parse(row["NGAYSINH"].ToString());
            this.NOICAPCMND = row["NOICAPCMND"].ToString();
        }
        private string _MACT;

        public string MACT
        {
            get { return _MACT; }
            set { _MACT = value; }
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
        private DateTime _NGAYSINH;

        public DateTime NGAYSINH
        {
            get { return _NGAYSINH; }
            set { _NGAYSINH = value; }
        }
        private string _NOICAPCMND;

        public string NOICAPCMND
        {
            get { return _NOICAPCMND; }
            set { _NOICAPCMND = value; }
        }
    }
}
