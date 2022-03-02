using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN_TOTNGHIEP.DTO
{
    public class ThongBao
    {
        public ThongBao(DataRow row)
        {
            this.MA = int.Parse(row["MA"].ToString());
            this.TENTIEUDE = row["TIEUDE"].ToString();
            this.NGAYDANG = row["NGAYDANG"].ToString();
            this.NOIDUNG = row["NOIDUNG"].ToString();
        }
        private int _MA;

        public int MA
        {
            get { return _MA; }
            set { _MA = value; }
        }
        private string _TENTIEUDE;

        public string TENTIEUDE
        {
            get { return _TENTIEUDE; }
            set { _TENTIEUDE = value; }
        }
        private string _NGAYDANG;

        public string NGAYDANG
        {
            get { return _NGAYDANG; }
            set { _NGAYDANG = value; }
        }
        private string _NOIDUNG;

        public string NOIDUNG
        {
            get { return _NOIDUNG; }
            set { _NOIDUNG = value; }
        }


    }
}
