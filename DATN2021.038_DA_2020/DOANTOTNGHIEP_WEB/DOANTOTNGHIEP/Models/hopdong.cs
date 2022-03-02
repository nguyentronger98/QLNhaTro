using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DOANTOTNGHIEP.Models
{
    public class hopdong
    {
        public string MAHD { get; set; }
        public DateTime NGAYHD { get; set; }
        public string HOTENNT { get; set; }
        public DateTime NGAYSINHNT { get; set; }
        public string NOIDKHK { get; set; }
        public string CMNDNT { get; set; }
        public DateTime NGAYCAPCMNDNT { get; set; }
        public string NOICAPCMNDNT { get; set; }
        public string SDTNT { get; set; }
        public string DIACHITHUE { get; set; }
        public float GIATHUE { get; set; }
        public float TIENCOC { get; set; }
        public string HINHTHUCTHANHTOAN { get; set; }
        public float TIENDIEN { get; set; }
        public float TIENNUOC { get; set; }
        public DateTime NGAYBATDAU { get; set; }
        public DateTime NGAYKETTHUC { get; set; }
        public int SONGUOIO { get; set; }
        public string MATKHAU { get; set; }
        public Boolean TINHTRANG { get; set; }
        public string GHICHU { get; set; }
        public string MACT { get; set; }
        public string MAPHONG { get; set; }
        public string EMAIL { get; set; }
    }
}