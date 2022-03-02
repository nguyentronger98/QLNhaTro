using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN_TOTNGHIEP.DTO
{
    public class DichVu_Phong
    {
        public DichVu_Phong(DataRow row)
        {
            this.MADV = row["MaDV"].ToString();
            this.MAPHONG = row["MAPHONG"].ToString();
            this.TENDV = row["TenDV"].ToString();
            this.GIADV = row["GiaDV"].ToString();
            this.NGAY = row["Ngay"].ToString();
        }
        private string _MADV;

        public string MADV
        {
            get { return _MADV; }
            set { _MADV = value; }
        }
        private string _MAPHONG;

        public string MAPHONG
        {
            get { return _MAPHONG; }
            set { _MAPHONG = value; }
        }
        private string _TENDV;

        public string TENDV
        {
            get { return _TENDV; }
            set { _TENDV = value; }
        }
        private string _GIADV;

        public string GIADV
        {
            get { return _GIADV; }
            set { _GIADV = value; }
        }
        private string _NGAY;

        public string NGAY
        {
            get { return _NGAY; }
            set { _NGAY = value; }
        }
    }
}
