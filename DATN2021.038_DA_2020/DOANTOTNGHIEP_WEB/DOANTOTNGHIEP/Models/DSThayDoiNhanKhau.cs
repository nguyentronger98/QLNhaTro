using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace DOANTOTNGHIEP.Models
{
    public class DSThayDoiNhanKhau
    {
        public List<thaydoinhankhau> lstthaydoink;
        public DSThayDoiNhanKhau()
        { }
        public DSThayDoiNhanKhau(string strsel)
        {
            KetNoi k = new KetNoi();
            SqlDataAdapter da = new SqlDataAdapter(strsel,k.con);
            DataTable dt = new DataTable();
            da.Fill(dt);

            lstthaydoink = dt.AsEnumerable().Select(x => new thaydoinhankhau
            {
                MA = int.Parse((x["MA"]).ToString()),
                HOTENNV = (x["HOTENNV"].ToString()),
                GIOITINHNV = (x["GIOITINHNV"].ToString()),
                CMNDSONV = (x["CMNDSONV"].ToString()),
                HOCHIEUNV = (x["HOCHIEUNV"].ToString()),
                NOITHUONGTRUNV = (x["NOITHUONGTRUNV"].ToString()),
                DIACHIHTNV = (x["DIACHIHTNV"].ToString()),
                SODTNV = (x["SODTNV"].ToString()),
                HOTENNTD = (x["HOTENNTD"].ToString()),
                NGAYSINHNTD = (x["NGAYSINHNTD"].ToString()),
                DANTOCNTD = (x["DANTOCNTD"].ToString()),
                QUOCTICHNTD = (x["QUOCTICHNTD"].ToString()),
                CMNDSONTD = (x["CMNDSONTD"].ToString()),
                HOCHIEUNTD = (x["HOCHIEUNTD"].ToString()),
                NOISINHNTD = (x["NOISINHNTD"].ToString()),
                QUEQUANNTD = (x["QUEQUANNTD"].ToString()),
                NGHENGHIEPNLVNTD = (x["NGHENGHIEPNLVNTD"].ToString()),
                NOITHUONGTRUNTD = (x["NOITHUONGTRUNTD"].ToString()),
                DIACHIHTNTD = (x["DIACHIHTNTD"].ToString()),
                SODTNTD = (x["SODTNTD"].ToString()),
                HOTENCHUHO = (x["HOTENCHUHO"].ToString()),
                QUANHECHUHO = (x["QUANHECHUHO"].ToString()),
                NOIDUNGTHAYDOI = (x["NOIDUNGTHAYDOI"].ToString()),
                HOTENTD1 = (x["HOTENTD1"].ToString()),
                HOTENTD2 = (x["HOTENTD2"].ToString()),
                HOTENTD3 = (x["HOTENTD3"].ToString()),
                HOTENTD4 = (x["HOTENTD4"].ToString()),
                NGAYSINHTD1 = (x["NGAYSINHTD1"].ToString()),
                NGAYSINHTD2 = (x["NGAYSINHTD2"].ToString()),
                NGAYSINHTD3 = (x["NGAYSINHTD3"].ToString()),
                NGAYSINHTD4 = (x["NGAYSINHTD4"].ToString()),
                GIOITINHTD1 = (x["GIOITINHTD1"].ToString()),
                GIOITINHTD2 = (x["GIOITINHTD2"].ToString()),
                GIOITINHTD3 = (x["GIOITINHTD3"].ToString()),
                GIOITINHTD4 = (x["GIOITINHTD4"].ToString()),
                NOISINHTD1 = (x["NOISINHTD1"].ToString()),
                NOISINHTD2 = (x["NOISINHTD2"].ToString()),
                NOISINHTD3 = (x["NOISINHTD3"].ToString()),
                NOISINHTD4 = (x["NOISINHTD4"].ToString()),
                NGHENGHIEPTD1 = (x["NGHENGHIEPTD1"].ToString()),
                NGHENGHIEPTD2 = (x["NGHENGHIEPTD2"].ToString()),
                NGHENGHIEPTD3 = (x["NGHENGHIEPTD3"].ToString()),
                NGHENGHIEPTD4 = (x["NGHENGHIEPTD4"].ToString()),
                DANTOCTD1 = (x["DANTOCTD1"].ToString()),
                DANTOCTD2 = (x["DANTOCTD2"].ToString()),
                DANTOCTD3 = (x["DANTOCTD3"].ToString()),
                DANTOCTD4 = (x["DANTOCTD4"].ToString()),
                QUOCTICHTD1 = (x["QUOCTICHTD1"].ToString()),
                QUOCTICHTD2 = (x["QUOCTICHTD2"].ToString()),
                QUOCTICHTD3 = (x["QUOCTICHTD3"].ToString()),
                QUOCTICHTD4 = (x["QUOCTICHTD4"].ToString()),
                CMNDTD1 = (x["CMNDTD1"].ToString()),
                CMNDTD2 = (x["CMNDTD2"].ToString()),
                CMNDTD3 = (x["CMNDTD3"].ToString()),
                CMNDTD4 = (x["CMNDTD4"].ToString()),
                QUANHETD1 = (x["QUANHETD1"].ToString()),
                QUANHETD2 = (x["QUANHETD2"].ToString()),
                QUANHETD3 = (x["QUANHETD3"].ToString()),
                QUANHETD4 = (x["QUANHETD4"].ToString()),
            }).ToList();
        }
    }
}