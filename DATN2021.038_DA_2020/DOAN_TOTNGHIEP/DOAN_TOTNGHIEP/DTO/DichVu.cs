using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN_TOTNGHIEP.DTO
{
    public class DichVu
    {
        public DichVu(DataRow row)
        {
            this.MADV = row["MaDV"].ToString();
            this.TENDV = (row["TenDV"].ToString());
            this.GIADV = int.Parse(row["GiaDV"].ToString());
            this.BATBUOC = bool.Parse(row["BatBuoc"].ToString());
        }
        private string _MADV;

        public string MADV
        {
            get { return _MADV; }
            set { _MADV = value; }
        }
        private string _TENDV;

        public string TENDV
        {
            get { return _TENDV; }
            set { _TENDV = value; }
        }
        private int _GIADV;

        public int GIADV
        {
            get { return _GIADV; }
            set { _GIADV = value; }
        }
        private bool _BATBUOC;

        public bool BATBUOC
        {
            get { return _BATBUOC; }
            set { _BATBUOC = value; }
        }
    }
}
