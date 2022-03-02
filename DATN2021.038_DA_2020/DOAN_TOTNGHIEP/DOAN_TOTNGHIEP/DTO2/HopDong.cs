using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DOAN_TOTNGHIEP.DTO2
{
    public class HopDong
    {
        public string MAHD { get; set; }
        public Nullable<System.DateTime> NGAYHD { get; set; }
        public string HOTENNT { get; set; }
        public Nullable<System.DateTime> NGAYSINHNT { get; set; }
        public string NOIDKHK { get; set; }
        public string CMNDNT { get; set; }
        public Nullable<System.DateTime> NGAYCAPCMNDNT { get; set; }
        public string NOICAPCMNDNT { get; set; }
        public string SDTNT { get; set; }
        public string DIACHITHUE { get; set; }
        public Nullable<double> GIATHUE { get; set; }
        public string HINHTHUCTHANHTOAN { get; set; }
        public Nullable<double> TIENCOC { get; set; }
        public Nullable<double> TIENDIEN { get; set; }
        public Nullable<double> TIENNUOC { get; set; }
        public Nullable<System.DateTime> NGAYBATDAU { get; set; }
        public Nullable<System.DateTime> NGAYKETTHUC { get; set; }
        public Nullable<int> SONGUOIO { get; set; }
        public string MATKHAU { get; set; }
        public Nullable<bool> TINHTRANG { get; set; }
        public string GHICHU { get; set; }
        public string MACT { get; set; }
        public string MAPHONG { get; set; }
    }
}
