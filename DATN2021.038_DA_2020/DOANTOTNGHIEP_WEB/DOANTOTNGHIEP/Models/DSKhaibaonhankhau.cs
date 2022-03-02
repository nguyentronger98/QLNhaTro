using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DOANTOTNGHIEP.Models
{
    public class DSKhaibaonhankhau
    {
        public List<khaibaonhankhau> lstkhaibao;
        public DSKhaibaonhankhau()
        { }
        public DSKhaibaonhankhau(string strsel)
        {
            KetNoi k = new KetNoi();
            SqlDataAdapter da = new SqlDataAdapter(strsel,k.con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            lstkhaibao = dt.AsEnumerable().Select(x => new khaibaonhankhau
            {
                MA = int.Parse((x["MA"]).ToString()),
                HOTEN = (x["HOTEN"].ToString()),
                HOTENKHAC = (x["HOTENKHAC"].ToString()),
                HINHTHE = x["HINHTHE"].ToString(),
                NGAYSINH = DateTime.Parse(x["NGAYSINH"].ToString()),
                GIOITINH = x["GIOITINH"].ToString(),
                NOISINH = x["NOISINH"].ToString(),
                NGUYENQUAN = x["NGUYENQUAN"].ToString(),
                DANTOC = x["DANTOC"].ToString(),
                TONGIAO = x["TONGIAO"].ToString(),
                QUOCTICH = x["QUOCTICH"].ToString(),
                CMNDSO = x["CMNDSO"].ToString(),
                HOCHIEUSO = x["HOCHIEUSO"].ToString(),
                NOITHUONGTRU = x["NOITHUONGTRU"].ToString(),
                DIACHIHIENTAI = x["DIACHIHIENTAI"].ToString(),
                HOCVAN = x["HOCVAN"].ToString(),
                CHUYENMON = x["CHUYENMON"].ToString(),
                TIENGDANTOC = x["TIENGDANTOC"].ToString(),
                NGOAINGU = x["NGOAINGU"].ToString(),
                NGHENGHIEPNOILAMVIEC = x["NGHENGHIEPNOILAMVIEC"].ToString(),
                NGAYDENNGAY1 = x["NGAYDENNGAY1"].ToString(),
                DIACHI1 = x["DIACHI1"].ToString(),
                NNNLV1 = x["NNNLV1"].ToString(),
                NGAYDENNGAY2 = x["NGAYDENNGAY2"].ToString(),
                DIACHI2 = x["DIACHI2"].ToString(),
                NNNLV2 = x["NNNLV2"].ToString(),
                NGAYDENNGAY3 = x["NGAYDENNGAY3"].ToString(),
                DIACHI3 = x["DIACHI3"].ToString(),
                NNNLV3 = x["NNNLV3"].ToString(),
                NGAYDENNGAY4 = x["NGAYDENNGAY4"].ToString(),
                DIACHI4 = x["DIACHI4"].ToString(),
                NNNLV4 = x["NNNLV4"].ToString(),
                NGAYDENNGAY5 = x["NGAYDENNGAY5"].ToString(),
                DIACHI5 = x["DIACHI5"].ToString(),
                NNNLV5 = x["NNNLV5"].ToString(),
                TIENAN = x["TIENAN"].ToString(),
                HOTENGD1 = x["HOTENGD1"].ToString(),
                NGAYSINHGD1 = x["NGAYSINHGD1"].ToString(),
                GIOITINHGD1 = x["GIOITINHGD1"].ToString(),
                QUANHEGD1 = x["QUANHEGD1"].ToString(),
                NGHENGHIEPGD1 = x["NGHENGHIEPGD1"].ToString(),
                DIACHIGD1 = x["DIACHIGD1"].ToString(),
                HOTENGD2 = x["HOTENGD2"].ToString(),
                NGAYSINHGD2 = x["NGAYSINHGD2"].ToString(),
                GIOITINHGD2 = x["GIOITINHGD2"].ToString(),
                QUANHEGD2 = x["QUANHEGD2"].ToString(),
                NGHENGHIEPGD2 = x["NGHENGHIEPGD2"].ToString(),
                DIACHIGD2 = x["DIACHIGD2"].ToString(),
                HOTENGD3 = x["HOTENGD3"].ToString(),
                NGAYSINHGD3 = x["NGAYSINHGD3"].ToString(),
                GIOITINHGD3 = x["GIOITINHGD3"].ToString(),
                QUANHEGD3 = x["QUANHEGD3"].ToString(),
                NGHENGHIEPGD3 = x["NGHENGHIEPGD3"].ToString(),
                DIACHIGD3 = x["DIACHIGD3"].ToString(),
                HOTENGD4 = x["HOTENGD4"].ToString(),
                NGAYSINHGD4 = x["NGAYSINHGD4"].ToString(),
                GIOITINHGD4 = x["GIOITINHGD4"].ToString(),
                QUANHEGD4 = x["QUANHEGD4"].ToString(),
                NGHENGHIEPGD4 = x["NGHENGHIEPGD4"].ToString(),
                DIACHIGD4 = x["DIACHIGD4"].ToString(),
                HOTENGD5 = x["HOTENGD5"].ToString(),
                NGAYSINHGD5 = x["NGAYSINHGD5"].ToString(),
                GIOITINHGD5 = x["GIOITINHGD5"].ToString(),
                QUANHEGD5 = x["QUANHEGD5"].ToString(),
                NGHENGHIEPGD5 = x["NGHENGHIEPGD5"].ToString(),
                DIACHIGD5 = x["DIACHIGD5"].ToString(),
                HOTENGD6 = x["HOTENGD6"].ToString(),
                NGAYSINHGD6 = x["NGAYSINHGD6"].ToString(),
                GIOITINHGD6 = x["GIOITINHGD6"].ToString(),
                QUANHEGD6 = x["QUANHEGD6"].ToString(),
                NGHENGHIEPGD6 = x["NGHENGHIEPGD6"].ToString(),
                DIACHIGD6 = x["DIACHIGD6"].ToString(),
                HINHCMNDTRUOC = x["HINHCMNDTRUOC"].ToString(),
                HINHCMNDSAU = x["HINHCMNDSAU"].ToString(),
                MAHD = x["MAHD"].ToString(),
                TINHTRANG = bool.Parse(x["TINHTRANG"].ToString())
            }).ToList();
        }
    }
}