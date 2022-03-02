using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN_TOTNGHIEP.DTO
{
    public class DangKy
    {
        public DangKy(DataRow row)
        {
            this.MA = row["MA"].ToString();
            this.HOTEN = row["HOTEN"].ToString();
            this.NGAYSINH = row["NGAYSINH"].ToString();
            this.CMND = row["CMND"].ToString();
            this.SDT = row["SDT"].ToString();
        }
        private string _MA;

        public string MA
        {
            get { return _MA; }
            set { _MA = value; }
        }
        private string _HOTEN;

        public string HOTEN
        {
            get { return _HOTEN; }
            set { _HOTEN = value; }
        }
        private string _NGAYSINH;

        public string NGAYSINH
        {
            get { return _NGAYSINH; }
            set { _NGAYSINH = value; }
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
    }
}
