using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN_TOTNGHIEP.DTO
{
    public class DangNhap
    {
        public DangNhap(DataRow row)
        {
            this.MAID = row["MAID"].ToString();
            this.MATKHAU = row["MATKHAU"].ToString();
            this.QUYEN = row["QUYEN"].ToString();
            this.TINHTRANG = bool.Parse(row["TINHTRANG"].ToString());
            this.MACT = row["MACT"].ToString();
        }
        private string _MAID;

        public string MAID
        {
            get { return _MAID; }
            set { _MAID = value; }
        }
        private string _MATKHAU;

        public string MATKHAU
        {
            get { return _MATKHAU; }
            set { _MATKHAU = value; }
        }
        private string _QUYEN;

        public string QUYEN
        {
            get { return _QUYEN; }
            set { _QUYEN = value; }
        }
        private bool _TINHTRANG;

        public bool TINHTRANG
        {
            get { return _TINHTRANG; }
            set { _TINHTRANG = value; }
        }
        private string _MACT;

        public string MACT
        {
            get { return _MACT; }
            set { _MACT = value; }
        }
    }
}
