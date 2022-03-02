using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DOANTOTNGHIEP.Models;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
using System.IO;
using SpeedSMSAPI;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Net;

namespace DOANTOTNGHIEP.Controllers
{
    public class HomeController : Controller
    {
        string connect = @"Data Source=DESKTOP-A71C3Q3\SQLEXPRESS;Initial Catalog=ql_nhatro;User ID=sa;Password=sql2014";
        // GET: /Home/
        public ActionResult DangXuat()
        {
            @Session["DX"] = null;
            @Session["TK"] = null;
            Session["Taikhoan"] = null;
            if (Session["TK"] == null)
            {
                return RedirectToAction("DangNhap", "Home");
            }
            return RedirectToAction("DangNhap", "Home");
        }
        [HttpGet]
        public ActionResult SuaToKhaiNhanKhau(int id)
        {
            string strsel = "Select * from KHACHTRO";
            DSKhaibaonhankhau ds = new DSKhaibaonhankhau(strsel);

            khaibaonhankhau sp = ds.lstkhaibao.FirstOrDefault(t => t.MA == id);
            @Session["Ma"] = id;
            return View(sp);
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult SuaToKhaiNhanKhau(khaibaonhankhau kbnk, HttpPostedFileBase fileUp, HttpPostedFileBase fileUpCMNDTruoc, HttpPostedFileBase fileUpCMNDSau, FormCollection col)
        {
            using (SqlConnection con = new SqlConnection(connect))
            {
                var hoten = col["hoten"].ToUpper();
                var hotenkhac = col["hotenkhac"].ToUpper();
                var ngaysinh = String.Format("{0:MM/dd/yyyy}", col["ngaysinh"]);

                var gioitinh = col["gioitinh"];
                var noisinh = col["noisinh"];
                var nguyenquan = col["nguyenquan"];
                var dantoc = col["dantoc"];
                var tongiao = col["tongiao"];
                var quoctich = col["quoctich"];
                var cmnd = col["cmnd"];
                var hochieu = col["hochieu"];
                var noithuongtru = col["noithuongtru"];
                var diachihientai = col["diachihientai"];
                var hocvan = col["hocvan"];
                var chuyenmon = col["chuyenmon"];
                var tiengdantoc = col["tiengdantoc"];
                var ngoaingu = col["ngoaingu"];
                var nghenghiepnoilamviec = col["nghenghiepnoilamviec"];

                var ngaydenngay1 = col["ngaydenngay1"];
                var ngaydenngay2 = col["ngaydenngay2"];
                var ngaydenngay3 = col["ngaydenngay3"];
                var ngaydenngay4 = col["ngaydenngay4"];
                var ngaydenngay5 = col["ngaydenngay5"];

                var diachi1 = col["diachi1"];
                var diachi2 = col["diachi2"];
                var diachi3 = col["diachi3"];
                var diachi4 = col["diachi4"];
                var diachi5 = col["diachi5"];

                var nnnlv1 = col["nnnlv1"];
                var nnnlv2 = col["nnnlv2"];
                var nnnlv3 = col["nnnlv3"];
                var nnnlv4 = col["nnnlv4"];
                var nnnlv5 = col["nnnlv5"];

                var tienan = col["tienan"];

                var hotengd1 = col["hotengd1"];
                var hotengd2 = col["hotengd2"];
                var hotengd3 = col["hotengd3"];
                var hotengd4 = col["hotengd4"];
                var hotengd5 = col["hotengd5"];
                var hotengd6 = col["hotengd6"];

                var ngaysinhgd1 = col["ngaysinhgd1"];
                var ngaysinhgd2 = col["ngaysinhgd2"];
                var ngaysinhgd3 = col["ngaysinhgd3"];
                var ngaysinhgd4 = col["ngaysinhgd4"];
                var ngaysinhgd5 = col["ngaysinhgd5"];
                var ngaysinhgd6 = col["ngaysinhgd6"];

                var gioitinhgd1 = col["gioitinhgd1"];
                var gioitinhgd2 = col["gioitinhgd2"];
                var gioitinhgd3 = col["gioitinhgd3"];
                var gioitinhgd4 = col["gioitinhgd4"];
                var gioitinhgd5 = col["gioitinhgd5"];
                var gioitinhgd6 = col["gioitinhgd6"];

                var quanhegd1 = col["quanhegd1"];
                var quanhegd2 = col["quanhegd2"];
                var quanhegd3 = col["quanhegd3"];
                var quanhegd4 = col["quanhegd4"];
                var quanhegd5 = col["quanhegd5"];
                var quanhegd6 = col["quanhegd6"];

                var nghenghiepgd1 = col["nghenghiepgd1"];
                var nghenghiepgd2 = col["nghenghiepgd2"];
                var nghenghiepgd3 = col["nghenghiepgd3"];
                var nghenghiepgd4 = col["nghenghiepgd4"];
                var nghenghiepgd5 = col["nghenghiepgd5"];
                var nghenghiepgd6 = col["nghenghiepgd6"];

                var diachigd1 = col["diachigd1"];
                var diachigd2 = col["diachigd2"];
                var diachigd3 = col["diachigd3"];
                var diachigd4 = col["diachigd4"];
                var diachigd5 = col["diachigd5"];
                var diachigd6 = col["diachigd6"];
                var mahd = @Session["Taikhoan"];

                if (ModelState.IsValid)
                {

                    // lưu tên file
                    var filenameanhthe = Path.GetFileName(fileUp.FileName);
                    var filenamecmndtruoc = Path.GetFileName(fileUpCMNDTruoc.FileName);
                    var filenamecmndsau = Path.GetFileName(fileUpCMNDSau.FileName);
                    // lưu đường dẫn của file
                    var pathanhthe = Path.Combine(Server.MapPath("~/Hinh/"), filenameanhthe);
                    var pathcmndtruoc = Path.Combine(Server.MapPath("~/Hinh/"), filenamecmndtruoc);
                    var pathcmndsau = Path.Combine(Server.MapPath("~/Hinh/"), filenamecmndsau);
                    if (System.IO.File.Exists(pathanhthe))
                    {
                        ViewBag.ThongBao = "Hình ảnh đã tồn tại";
                    }
                    else
                    {
                        fileUp.SaveAs(pathanhthe);
                    }
                    if (System.IO.File.Exists(pathcmndtruoc))
                    {
                        ViewBag.ThongBao = "Hình ảnh đã tồn tại";
                    }
                    else
                    {
                        fileUpCMNDTruoc.SaveAs(pathcmndtruoc);
                    }
                    if (System.IO.File.Exists(pathcmndsau))
                    {
                        ViewBag.ThongBao = "Hình ảnh đã tồn tại";
                    }
                    else
                    {
                        fileUpCMNDSau.SaveAs(pathcmndsau);
                    }

                    con.Open();
                    string ma = @Session["Ma"].ToString();
                    string sql = "Update KHACHTRO set HOTEN=N'"
                        + hoten + "',HOTENKHAC=N'" + hotenkhac + "',NGAYSINH=N'" + ngaysinh + "',GIOITINH=N'" + gioitinh + "',NOISINH=N'" + noisinh + "',NGUYENQUAN=N'" + nguyenquan + "',DANTOC=N'" + dantoc + "',TONGIAO=N'" + tongiao + "',QUOCTICH=N'" + quoctich + "',CMNDSO=N'" + cmnd + "',HOCHIEUSO=N'" + hochieu + "',NOITHUONGTRU=N'" + noithuongtru + "',DIACHIHIENTAI=N'" + diachihientai + "',HOCVAN=N'" + hocvan + "',CHUYENMON=N'" + chuyenmon + "',TIENGDANTOC=N'" + tiengdantoc + "',NGOAINGU=N'" + ngoaingu + "',NGHENGHIEPNOILAMVIEC=N'" + nghenghiepnoilamviec + "',NGAYDENNGAY1=N'"
                        + ngaydenngay1 + "',DIACHI1=N'" + diachi1 + "',NNNLV1=N'" + nnnlv1 + "',NGAYDENNGAY2=N'" + ngaydenngay2 + "',DIACHI2=N'" + diachi2 + "',NNNLV2=N'" + nnnlv2 + "',NGAYDENNGAY3=N'" + ngaydenngay3 + "',DIACHI3=N'" + diachi3 + "',NNNLV3=N'" + nnnlv3 + "',NGAYDENNGAY4=N'" + ngaydenngay4 + "',DIACHI4=N'" + diachi4 + "',NNNLV4=N'" + nnnlv4 + "',NGAYDENNGAY5=N'" + ngaydenngay5 + "',DIACHI5=N'" + diachi5 + "',NNNLV5=N'" + nnnlv5 + "',TIENAN=N'"
                        + tienan + "',HOTENGD1=N'" + hotengd1 + "',NGAYSINHGD1=N'" + ngaysinhgd1 + "',GIOITINHGD1=N'" + gioitinhgd1 + "',QUANHEGD1=N'" + quanhegd1 + "',NGHENGHIEPGD1=N'" + nghenghiepgd1 + "',DIACHIGD1=N'" + diachigd1 + "',HOTENGD2=N'"
                        + hotengd2 + "',NGAYSINHGD2=N'" + ngaysinhgd2 + "',GIOITINHGD2=N'" + gioitinhgd2 + "',QUANHEGD2=N'" + quanhegd2 + "',NGHENGHIEPGD2=N'" + nghenghiepgd2 + "',DIACHIGD2=N'" + diachigd2 + "',HOTENGD3=N'"
                        + hotengd3 + "',NGAYSINHGD3=N'" + ngaysinhgd3 + "',GIOITINHGD3=N'" + gioitinhgd3 + "',QUANHEGD3=N'" + quanhegd3 + "',NGHENGHIEPGD3=N'" + nghenghiepgd3 + "',DIACHIGD3=N'" + diachigd3 + "',HOTENGD4=N'"
                        + hotengd4 + "',NGAYSINHGD4=N'" + ngaysinhgd4 + "',GIOITINHGD4=N'" + gioitinhgd4 + "',QUANHEGD4=N'" + quanhegd4 + "',NGHENGHIEPGD4=N'" + nghenghiepgd4 + "',DIACHIGD4=N'" + diachigd4 + "',HOTENGD5=N'"
                        + hotengd5 + "',NGAYSINHGD5=N'" + ngaysinhgd5 + "',GIOITINHGD5=N'" + gioitinhgd5 + "',QUANHEGD5=N'" + quanhegd5 + "',NGHENGHIEPGD5=N'" + nghenghiepgd5 + "',DIACHIGD5=N'" + diachigd5 + "',HOTENGD6=N'"
                        + hotengd6 + "',NGAYSINHGD6=N'" + ngaysinhgd6 + "',GIOITINHGD6=N'" + gioitinhgd6 + "',QUANHEGD6=N'" + quanhegd6 + "',NGHENGHIEPGD6=N'" + nghenghiepgd6 + "',DIACHIGD6=N'" + diachigd6 + "',HINHTHE=N'" + filenameanhthe + "',HINHCMNDTRUOC=N'" + filenamecmndtruoc + "',HINHCMNDSAU=N'" + filenamecmndsau + "' WHERE MA=N'" + ma + "'";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    return RedirectToAction("Home");
                }
            }

            return View();

        }
        public ActionResult DangNhap()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DangNhap(FormCollection col)
        {
            var tendn = col["uname"];
            var mk = col["pswd"];
            if (tendn.Length <= 2 || tendn.Length > 20)
            {
                ViewBag.Thongbao = "Tên tài khoản phải nằm trong khoản từ 3 - 20 ký tự";
                return View();
            }
            if (mk.Length <= 2 || mk.Length > 15)
            {
                ViewBag.Thongbao = "Mật khẩu phải nằm trong khoản từ 3 - 15 ký tự";
                return View();
            }
            string strsel = "Select * from HOPDONG";
            DSHopDong ds = new DSHopDong(strsel);

            hopdong sp = ds.lsthopdong.FirstOrDefault(t => t.MAHD == tendn && t.MATKHAU == mk);
            if (sp != null)
            {
                @Session["Taikhoan"] = sp.MAHD;
                return RedirectToAction("GuiMaXN", "Home");
            }
            else
            {
                ViewBag.Thongbao = "Tên tài khoản hoặc mật khẩu không đúng";
            }
            return View("DangNhap");
        }
        public ActionResult DSThayDoiNhanKhau()
        {
            if (@Session["TK"] == null)
            {
                return RedirectToAction("DangNhap", "Home");
            }
            string strsel1 = "Select * from THAYDOINHANKHAU where MAHD='" + @Session["Taikhoan"] + "'";
            DSThayDoiNhanKhau ds = new DSThayDoiNhanKhau(strsel1);

            int sl = ds.lstthaydoink.Count;
            if (sl >= 1)
            {
                ViewBag.SLTDNK = "hidden";
            }
            else
            {
                ViewBag.SLTDNK = null;
            }
            return View(ds.lstthaydoink);
        }
        public ActionResult DSKhaiBaoNhanKhau()
        {
            if (@Session["TK"] == null)
            {
                return RedirectToAction("DangNhap", "Home");
            }
            string strsel = "Select * from KHACHTRO where MAHD=N'" + @Session["Taikhoan"] + "' and TINHTRANG='True'";
            DSKhaibaonhankhau ds = new DSKhaibaonhankhau(strsel);
            int sl = ds.lstkhaibao.Count;
            string sql = "Select * from HOPDONG";
            DSHopDong hd = new DSHopDong(sql);

            hopdong sp = hd.lsthopdong.FirstOrDefault(t => t.MAHD == @Session["Taikhoan"].ToString());
            if (sl >= sp.SONGUOIO)
            {
                ViewBag.SLKBNK = "hidden";
            }
            else
            {
                ViewBag.SLKBNK = null;
            }
            return View(ds.lstkhaibao);
        }
        public ActionResult ChiTietPhong()
        {
            if (@Session["TK"] == null)
            {
                return RedirectToAction("DangNhap", "Home");
            }
            string strsel = "Select * from HOPDONG";
            DSHopDong ds = new DSHopDong(strsel);

            hopdong sp = ds.lsthopdong.FirstOrDefault(t => t.MAHD == @Session["Taikhoan"].ToString());
            string sql = "select * from THIETBI,CHITIETPHONG where THIETBI.MATB = CHITIETPHONG.MATB and MAPHONG=N'" + sp.MAPHONG + "'";
            DSThietBi dstb = new DSThietBi(sql);

            return View(dstb.lstthietbi);
        }
        public ActionResult Home()
        {
            if (@Session["TK"] == null)
            {
                return RedirectToAction("DangNhap", "Home");
            }
            string strsel = "Select * from HOPDONG";
            DSHopDong ds = new DSHopDong(strsel);

            hopdong sp = ds.lsthopdong.FirstOrDefault(t => t.MAHD == @Session["Taikhoan"].ToString());
            return View(sp);
        }
        public ActionResult HoanThanh()
        {
            return View();
        }
        public ActionResult HuongDanKhaiBaoNhanKhau()
        {
            if (@Session["TK"] == null)
            {
                return RedirectToAction("DangNhap", "Home");
            }
            return View();
        }
        public ActionResult HuongDanKhaiThayDoiNhanKhau()
        {
            if (@Session["TK"] == null)
            {
                return RedirectToAction("DangNhap", "Home");
            }
            return View();
        }
        [HttpGet]
        public ActionResult KhaiBaoNhanKhau()
        {
            if (@Session["TK"] == null)
            {
                return RedirectToAction("DangNhap", "Home");
            }
            //string str = "select * from province";
            //ListProvince lst = new ListProvince(str);
            //ViewBag.TINH = new SelectList(lst.lstpro.OrderBy(n => n.name), "id", "name");
            return View();
        }
        //public ActionResult GetHuyen(int id_tinh)
        //{
        //    string str = "select * from district where _province_id ='" + id_tinh.ToString() + "'";
        //    ListDistrict lst = new ListDistrict(str);
        //    ViewBag.HUYEN = new SelectList(lst.lstdis, "id_huyen", "name");
        //    return PartialView();
        //}
        //public ActionResult GetXa(int id_huyen)
        //{
        //    string str = "select * from ward where _district_id ='" + id_huyen.ToString() + "'";
        //    ListWard lst = new ListWard(str);
        //    ViewBag.XA = new SelectList(lst.lstward, "id_xa", "name");
        //    return PartialView();
        //}
        //[HttpPost]
        
        [HttpPost]
        public ActionResult KhaiBaoNhanKhau(FormCollection col, HttpPostedFileBase fileUp, HttpPostedFileBase fileUpCMNDTruoc, HttpPostedFileBase fileUpCMNDSau)
        {
            using (SqlConnection con = new SqlConnection(connect))
            {
                var hoten = col["hoten"].ToUpper();
                var hotenkhac = col["hotenkhac"].ToUpper();
                var ngaysinh = String.Format("{0:MM/dd/yyyy}", col["ngaysinh"]);

                var gioitinh = col["gioitinh"];
                var nshuyen = col["nshuyen"];
                var nstinh = col["nstinh"];
                string noisinh = nshuyen + " - " + nstinh;
                var nqhuyen = col["nqhuyen"];
                var nqtinh = col["nqtinh"];
                string nguyenquan = nqhuyen + " - " + nqtinh;
                var dantoc = col["dantoc"];
                var tongiao = col["tongiao"];
                var quoctich = col["quoctich"];
                var cmnd = col["cmnd"];
                var hochieu = col["hochieu"];
                //ListWard lstxa = new ListWard("select * from ward");
                //ListDistrict lsth = new ListDistrict("select * from district");
                //ListProvince lstt = new ListProvince("select * from province");
                //var nttx = lstxa.lstward.SingleOrDefault(t => t.id_xa.ToString() == col["id_xa"]).name;
                //var ntth = lsth.lstdis.SingleOrDefault(t => t.id_huyen.ToString() == col["id_huyen"]).name;
                //var nttt = lstt.lstpro.SingleOrDefault(t => t.id.ToString() == col["id_tinh"]).name;
                //string noithuongtru = nttx + " - " + ntth + " - " + nttt;
                string noithuongtru = col["noithuongtru"];
                var diachihientai = col["diachihientai"];
                var hocvan = col["hocvan"];
                var chuyenmon = col["chuyenmon"];
                var tiengdantoc = col["tiengdantoc"];
                var ngoaingu = col["ngoaingu"];
                var nghenghiepnoilamviec = col["nghenghiepnoilamviec"];

                var ngaydenngay1 = col["ngaydenngay1"];
                var ngaydenngay2 = col["ngaydenngay2"];
                var ngaydenngay3 = col["ngaydenngay3"];
                var ngaydenngay4 = col["ngaydenngay4"];
                var ngaydenngay5 = col["ngaydenngay5"];

                var diachi1 = col["diachi1"];
                var diachi2 = col["diachi2"];
                var diachi3 = col["diachi3"];
                var diachi4 = col["diachi4"];
                var diachi5 = col["diachi5"];

                var nnnlv1 = col["nnnlv1"];
                var nnnlv2 = col["nnnlv2"];
                var nnnlv3 = col["nnnlv3"];
                var nnnlv4 = col["nnnlv4"];
                var nnnlv5 = col["nnnlv5"];

                var tienan = col["tienan"];

                var hotengd1 = col["hotengd1"];
                var hotengd2 = col["hotengd2"];
                var hotengd3 = col["hotengd3"];
                var hotengd4 = col["hotengd4"];
                var hotengd5 = col["hotengd5"];
                var hotengd6 = col["hotengd6"];

                var ngaysinhgd1 = col["ngaysinhgd1"];
                var ngaysinhgd2 = col["ngaysinhgd2"];
                var ngaysinhgd3 = col["ngaysinhgd3"];
                var ngaysinhgd4 = col["ngaysinhgd4"];
                var ngaysinhgd5 = col["ngaysinhgd5"];
                var ngaysinhgd6 = col["ngaysinhgd6"];

                var gioitinhgd1 = col["gioitinhgd1"];
                var gioitinhgd2 = col["gioitinhgd2"];
                var gioitinhgd3 = col["gioitinhgd3"];
                var gioitinhgd4 = col["gioitinhgd4"];
                var gioitinhgd5 = col["gioitinhgd5"];
                var gioitinhgd6 = col["gioitinhgd6"];

                var quanhegd1 = col["quanhegd1"];
                var quanhegd2 = col["quanhegd2"];
                var quanhegd3 = col["quanhegd3"];
                var quanhegd4 = col["quanhegd4"];
                var quanhegd5 = col["quanhegd5"];
                var quanhegd6 = col["quanhegd6"];

                var nghenghiepgd1 = col["nghenghiepgd1"];
                var nghenghiepgd2 = col["nghenghiepgd2"];
                var nghenghiepgd3 = col["nghenghiepgd3"];
                var nghenghiepgd4 = col["nghenghiepgd4"];
                var nghenghiepgd5 = col["nghenghiepgd5"];
                var nghenghiepgd6 = col["nghenghiepgd6"];

                var diachigd1 = col["diachigd1"];
                var diachigd2 = col["diachigd2"];
                var diachigd3 = col["diachigd3"];
                var diachigd4 = col["diachigd4"];
                var diachigd5 = col["diachigd5"];
                var diachigd6 = col["diachigd6"];
                var mahd = @Session["Taikhoan"];
                if (ModelState.IsValid)
                {
                    // lưu tên file
                    var filenameanhthe = Path.GetFileName(fileUp.FileName);
                    var filenamecmndtruoc = Path.GetFileName(fileUpCMNDTruoc.FileName);
                    var filenamecmndsau = Path.GetFileName(fileUpCMNDSau.FileName);
                    // lưu đường dẫn của file
                    var pathanhthe = Path.Combine(Server.MapPath("~/Hinh/"), filenameanhthe);
                    var pathcmndtruoc = Path.Combine(Server.MapPath("~/Hinh/"), filenamecmndtruoc);
                    var pathcmndsau = Path.Combine(Server.MapPath("~/Hinh/"), filenamecmndsau);
                    if (System.IO.File.Exists(pathanhthe))
                    {
                        ViewBag.ThongBao = "Hình ảnh đã tồn tại";
                    }
                    else
                    {
                        fileUp.SaveAs(pathanhthe);
                    }
                    if (System.IO.File.Exists(pathcmndtruoc))
                    {
                        ViewBag.ThongBao = "Hình ảnh đã tồn tại";
                    }
                    else
                    {
                        fileUpCMNDTruoc.SaveAs(pathcmndtruoc);
                    }
                    if (System.IO.File.Exists(pathcmndsau))
                    {
                        ViewBag.ThongBao = "Hình ảnh đã tồn tại";
                    }
                    else
                    {
                        fileUpCMNDSau.SaveAs(pathcmndsau);
                    }
                    con.Open();
                    string sql = "Insert into KHACHTRO(HOTEN,HOTENKHAC,NGAYSINH,GIOITINH,NOISINH,NGUYENQUAN,DANTOC,TONGIAO,QUOCTICH,CMNDSO,HOCHIEUSO,NOITHUONGTRU,DIACHIHIENTAI,HOCVAN,CHUYENMON,TIENGDANTOC,NGOAINGU,NGHENGHIEPNOILAMVIEC," +
                        "NGAYDENNGAY1,DIACHI1,NNNLV1,NGAYDENNGAY2,DIACHI2,NNNLV2,NGAYDENNGAY3,DIACHI3,NNNLV3," +
                        "NGAYDENNGAY4,DIACHI4,NNNLV4,NGAYDENNGAY5,DIACHI5,NNNLV5," +
                        "TIENAN,HOTENGD1,NGAYSINHGD1,GIOITINHGD1,QUANHEGD1,NGHENGHIEPGD1,DIACHIGD1," +
                        "HOTENGD2,NGAYSINHGD2,GIOITINHGD2,QUANHEGD2,NGHENGHIEPGD2,DIACHIGD2," +
                        "HOTENGD3,NGAYSINHGD3,GIOITINHGD3,QUANHEGD3,NGHENGHIEPGD3,DIACHIGD3," +
                        "HOTENGD4,NGAYSINHGD4,GIOITINHGD4,QUANHEGD4,NGHENGHIEPGD4,DIACHIGD4," +
                        "HOTENGD5,NGAYSINHGD5,GIOITINHGD5,QUANHEGD5,NGHENGHIEPGD5,DIACHIGD5," +
                        "HOTENGD6,NGAYSINHGD6,GIOITINHGD6,QUANHEGD6,NGHENGHIEPGD6,DIACHIGD6," +
                        "HINHTHE,MAHD,HINHCMNDTRUOC,HINHCMNDSAU,TINHTRANG,LYDOROIPHONG,CHUPHONG) values(N'"
                        + hoten + "',N'" + hotenkhac + "',N'" + ngaysinh + "',N'" + gioitinh + "',N'" + noisinh + "',N'" + nguyenquan + "',N'" + dantoc + "',N'" + tongiao + "',N'" + quoctich + "',N'" + cmnd + "',N'" + hochieu + "',N'" + noithuongtru + "',N'" + diachihientai + "',N'" + hocvan + "',N'" + chuyenmon + "',N'" + tiengdantoc + "',N'" + ngoaingu + "',N'" + nghenghiepnoilamviec + "',N'"
                        + ngaydenngay1 + "',N'" + diachi1 + "',N'" + nnnlv1 + "',N'" + ngaydenngay2 + "',N'" + diachi2 + "',N'" + nnnlv2 + "',N'" + ngaydenngay3 + "',N'" + diachi3 + "',N'" + nnnlv3 + "',N'" + ngaydenngay4 + "',N'" + diachi4 + "',N'" + nnnlv4 + "',N'" + ngaydenngay5 + "',N'" + diachi5 + "',N'" + nnnlv5 + "',N'"
                        + tienan + "',N'" + hotengd1 + "',N'" + ngaysinhgd1 + "',N'" + gioitinhgd1 + "',N'" + quanhegd1 + "',N'" + nghenghiepgd1 + "',N'" + diachigd1 + "',N'"
                        + hotengd2 + "',N'" + ngaysinhgd2 + "',N'" + gioitinhgd2 + "',N'" + quanhegd2 + "',N'" + nghenghiepgd2 + "',N'" + diachigd2 + "',N'"
                        + hotengd3 + "',N'" + ngaysinhgd3 + "',N'" + gioitinhgd3 + "',N'" + quanhegd3 + "',N'" + nghenghiepgd3 + "',N'" + diachigd3 + "',N'"
                        + hotengd4 + "',N'" + ngaysinhgd4 + "',N'" + gioitinhgd4 + "',N'" + quanhegd4 + "',N'" + nghenghiepgd4 + "',N'" + diachigd4 + "',N'"
                        + hotengd5 + "',N'" + ngaysinhgd5 + "',N'" + gioitinhgd5 + "',N'" + quanhegd5 + "',N'" + nghenghiepgd5 + "',N'" + diachigd5 + "',N'"
                        + hotengd6 + "',N'" + ngaysinhgd6 + "',N'" + gioitinhgd6 + "',N'" + quanhegd6 + "',N'" + nghenghiepgd6 + "',N'" + diachigd6 + "',N'" + filenameanhthe + "',N'" + mahd + "',N'" + filenamecmndtruoc + "',N'" + filenamecmndsau + "',N'True','','False')";
                    SqlCommand cmd = new SqlCommand(sql, con);
                    cmd.ExecuteNonQuery();
                    return RedirectToAction("Home");
                }
                return View();
            }

        }
        public ActionResult ChiTietKhaiBaoNhanKhau(int ma)
        {
            string sql = "select * from KHACHTRO";
            DSKhaibaonhankhau ds = new DSKhaibaonhankhau(sql);
            khaibaonhankhau nk = ds.lstkhaibao.FirstOrDefault(t => t.MA == ma);
            return View(nk);
        }
        [HttpGet]
        public ActionResult ThayDoiNhanKhau()
        {
            if (Session["TK"] == null)
            {
                return RedirectToAction("DangNhap", "Home");
            }
            string sql = "select * from KHACHTRO";
            DSKhaibaonhankhau ds = new DSKhaibaonhankhau(sql);
            return View(ds.lstkhaibao.Where(t => t.MAHD == @Session["Taikhoan"].ToString() && t.TINHTRANG==true).ToList());
        }
        [HttpPost]
        public ActionResult ThayDoiNhanKhau(FormCollection col)
        {
            using (SqlConnection con = new SqlConnection(connect))
            {
                var hotennv = col["hotennv"].ToUpper();
                var gioitinhnv = col["gioitinhnv"];
                var cmndnv = col["cmndnv"];
                var hochieunv = col["hochieunv"];
                var noithuongtrunv = col["noithuongtrunv"];
                var diachihtnv = col["diachihtnv"];
                var sdtnv = col["sdtnv"];
                var hotenntd = col["hotenntd"].ToUpper();
                var gioitinhntd = col["gioitinhntd"];
                var ngaysinhntd = col["ngaysinhntd"];
                var dantocntd = col["dantocntd"];
                var quoctichntd = col["quoctichntd"];
                var cmndntd = col["cmndntd"];
                var hochieuntd = col["hochieuntd"];
                var noisinhntd = col["noisinhntd"];
                var nguyenquanntd = col["nguyenquanntd"];
                var nghenghiepnlvntd = col["nghenghiepnlvntd"];
                var noithuongtruntd = col["noithuongtruntd"];
                var diachihtntd = col["diachihtntd"];
                var sdtntd = col["sdtntd"];
                var hotenchuho = col["hotenchuho"];
                var quanhechuho = col["quanhechuho"];
                var noidung = col["noidung"];

                var hotentd1 = col["hotentd1"];
                var hotentd2 = col["hotentd2"];
                var hotentd3 = col["hotentd3"];
                var hotentd4 = col["hotentd4"];
                var hotentd5 = col["hotentd5"];
                var hotentd6 = col["hotentd6"];

                var ngaysinhtd1 = col["ngaysinhtd1"];
                var ngaysinhtd2 = col["ngaysinhtd2"];
                var ngaysinhtd3 = col["ngaysinhtd3"];
                var ngaysinhtd4 = col["ngaysinhtd4"];
                var ngaysinhtd5 = col["ngaysinhtd5"];
                var ngaysinhtd6 = col["ngaysinhtd6"];

                var gioitinhtd1 = col["gioitinhtd1"];
                var gioitinhtd2 = col["gioitinhtd2"];
                var gioitinhtd3 = col["gioitinhtd3"];
                var gioitinhtd4 = col["gioitinhtd4"];
                var gioitinhtd5 = col["gioitinhtd5"];
                var gioitinhtd6 = col["gioitinhtd6"];

                var noisinhtd1 = col["noisinhtd1"];
                var noisinhtd2 = col["noisinhtd2"];
                var noisinhtd3 = col["noisinhtd3"];
                var noisinhtd4 = col["noisinhtd4"];
                var noisinhtd5 = col["noisinhtd5"];
                var noisinhtd6 = col["noisinhtd6"];

                var nghenghieptd1 = col["nghenghieptd1"];
                var nghenghieptd2 = col["nghenghieptd2"];
                var nghenghieptd3 = col["nghenghieptd3"];
                var nghenghieptd4 = col["nghenghieptd4"];
                var nghenghieptd5 = col["nghenghieptd5"];
                var nghenghieptd6 = col["nghenghieptd6"];

                var dantoctd1 = col["dantoctd1"];
                var dantoctd2 = col["dantoctd2"];
                var dantoctd3 = col["dantoctd3"];
                var dantoctd4 = col["dantoctd4"];
                var dantoctd5 = col["dantoctd5"];
                var dantoctd6 = col["dantoctd6"];

                var quoctichtd1 = col["quoctichtd1"];
                var quoctichtd2 = col["quoctichtd2"];
                var quoctichtd3 = col["quoctichtd3"];
                var quoctichtd4 = col["quoctichtd4"];
                var quoctichtd5 = col["quoctichtd5"];
                var quoctichtd6 = col["quoctichtd6"];

                var cmndtd1 = col["cmndtd1"];
                var cmndtd2 = col["cmndtd2"];
                var cmndtd3 = col["cmndtd3"];
                var cmndtd4 = col["cmndtd4"];
                var cmndtd5 = col["cmndtd5"];
                var cmndtd6 = col["cmndtd6"];

                var quanhetd1 = col["quanhetd1"];
                var quanhetd2 = col["quanhetd2"];
                var quanhetd3 = col["quanhetd3"];
                var quanhetd4 = col["quanhetd4"];
                var quanhetd5 = col["quanhetd5"];
                var quanhetd6 = col["quanhetd6"];

                con.Open();
                string sql = "Insert Into THAYDOINHANKHAU(MAHD,HOTENNV,GIOITINHNV,CMNDSONV,HOCHIEUNV,NOITHUONGTRUNV,DIACHIHTNV,SODTNV,HOTENNTD,GIOITINHNTD,NGAYSINHNTD,DANTOCNTD,QUOCTICHNTD,CMNDSONTD,HOCHIEUNTD,NOISINHNTD,QUEQUANNTD,NGHENGHIEPNLVNTD,NOITHUONGTRUNTD,DIACHIHTNTD,SODTNTD,HOTENCHUHO,QUANHECHUHO,NOIDUNGTHAYDOI"
                    + ",HOTENTD1,NGAYSINHTD1,GIOITINHTD1,NOISINHTD1,NGHENGHIEPTD1,DANTOCTD1,QUOCTICHTD1,CMNDTD1,QUANHETD1"
                    + ",HOTENTD2,NGAYSINHTD2,GIOITINHTD2,NOISINHTD2,NGHENGHIEPTD2,DANTOCTD2,QUOCTICHTD2,CMNDTD2,QUANHETD2"
                    + ",HOTENTD3,NGAYSINHTD3,GIOITINHTD3,NOISINHTD3,NGHENGHIEPTD3,DANTOCTD3,QUOCTICHTD3,CMNDTD3,QUANHETD3"
                    + ",HOTENTD4,NGAYSINHTD4,GIOITINHTD4,NOISINHTD4,NGHENGHIEPTD4,DANTOCTD4,QUOCTICHTD4,CMNDTD4,QUANHETD4) VALUES(N'" + @Session["Taikhoan"].ToString() + "',N'"
                    + hotennv + "',N'" + gioitinhnv + "',N'" + cmndnv + "',N'" + hochieunv + "',N'" + noithuongtrunv + "',N'" + diachihtnv + "',N'" + sdtnv + "',N'"
                    + hotenntd + "',N'" + gioitinhntd + "',N'" + ngaysinhntd + "',N'" + dantocntd + "',N'" + quoctichntd + "',N'" + cmndntd + "',N'" + hochieuntd + "',N'"
                    + noisinhntd + "',N'" + nguyenquanntd + "',N'" + nghenghiepnlvntd + "',N'" + noithuongtruntd + "',N'" + diachihtntd + "',N'"
                    + sdtntd + "',N'" + hotenchuho + "',N'" + quanhechuho + "',N'" + noidung + "',N'"
                    + hotentd1 + "',N'" + ngaysinhtd1 + "',N'" + gioitinhtd1 + "',N'" + noisinhtd1 + "',N'" + nghenghieptd1 + "',N'" + dantoctd1 + "',N'" + quoctichtd1 + "',N'" + cmndtd1 + "',N'" + quanhetd1 + "',N'"
                    + hotentd2 + "',N'" + ngaysinhtd2 + "',N'" + gioitinhtd2 + "',N'" + noisinhtd2 + "',N'" + nghenghieptd2 + "',N'" + dantoctd2 + "',N'" + quoctichtd2 + "',N'" + cmndtd2 + "',N'" + quanhetd2 + "',N'"
                    + hotentd3 + "',N'" + ngaysinhtd3 + "',N'" + gioitinhtd3 + "',N'" + noisinhtd3 + "',N'" + nghenghieptd3 + "',N'" + dantoctd3 + "',N'" + quoctichtd3 + "',N'" + cmndtd3 + "',N'" + quanhetd3 + "',N'"
                    + hotentd4 + "',N'" + ngaysinhtd4 + "',N'" + gioitinhtd4 + "',N'" + noisinhtd4 + "',N'" + nghenghieptd4 + "',N'" + dantoctd4 + "',N'" + quoctichtd4 + "',N'" + cmndtd4 + "',N'" + quanhetd4 + "')";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
            }
            return RedirectToAction("HoanThanh");
        }
        public ActionResult DSHoaDon()
        {
            if (Session["TK"] == null)
            {
                return RedirectToAction("DangNhap", "Home");
            }
            string sql = "select * from HOADON";
            string strsel = "Select * from HOPDONG";
            DSHopDong ds = new DSHopDong(strsel);

            hopdong sp = ds.lsthopdong.FirstOrDefault(t => t.MAHD == @Session["Taikhoan"].ToString());
            DSHoaDon dshd = new DSHoaDon(sql);
            List<HoaDon> hd = dshd.lstHD.Where(t => t.MAPHONG == sp.MAPHONG && t.DATHANHTOAN == true).ToList();
            return View(hd);
        }
        public ActionResult ThongBao()
        {
            if (Session["TK"] == null)
            {
                return RedirectToAction("DangNhap", "Home");
            }
            string sql = "select * from THONGBAO";
            DSThongBao ds = new DSThongBao(sql);

            return PartialView(ds.lst);
        }
        public ActionResult ChiTietThongBao(string id)
        {
            if (Session["TK"] == null)
            {
                return RedirectToAction("DangNhap", "Home");
            }
            string sql = "select * from THONGBAO";
            DSThongBao ds = new DSThongBao(sql);
            return View(ds.lst.FirstOrDefault(t => t.MA == id));
        }
        public ActionResult QuyDinh()
        {
            if (Session["TK"] == null)
            {
                return RedirectToAction("DangNhap", "Home");
            }
            string sql = "select * from QUYDINH";
            DSQuyDinh ds = new DSQuyDinh(sql);
            return View(ds.lst);
        }
        [HttpGet]
        public ActionResult BaoCaoSuCo()
        {
            if (Session["TK"] == null)
            {
                return RedirectToAction("DangNhap", "Home");
            }
            return View();
        }
        [HttpPost]
        public ActionResult BaoCaoSuCo(FormCollection col)
        {
            if (Session["TK"] == null)
            {
                return RedirectToAction("DangNhap", "Home");
            }
            using (SqlConnection con = new SqlConnection(connect))
            {
                var tieude = col["tieude"].ToUpper();
                var noidung = col["noidung"];
                con.Open();
                string sql = "Insert Into SUCO(TIEUDE,NGAY,NOIDUNG,MAPHONG,TINHTRANG) values(N'" + tieude + "',N'" + String.Format("{0:yyyy/MM/dd}", DateTime.Now.Date) + "',N'" + noidung + "',N'"+@Session["MAPHONG"]+"','False')";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
            }
            return RedirectToAction("Home", "Home");
        }
        [HttpGet]
        public ActionResult SuaThayDoiNhanKhau(int ma)
        {
            if (Session["TK"] == null)
            {
                return RedirectToAction("DangNhap", "Home");
            }
            string sql = "select * from THAYDOINHANKHAU";
            DSThayDoiNhanKhau ds = new DSThayDoiNhanKhau(sql);
            @Session["MaTD"] = ma;
            return View(ds.lstthaydoink.SingleOrDefault(t => t.MA == ma));
        }
        [HttpPost]
        public ActionResult SuaThayDoiNhanKhau(FormCollection col)
        {
            using (SqlConnection con = new SqlConnection(connect))
            {
                var hotennv = col["hotennv"].ToUpper();
                var gioitinhnv = col["gioitinhnv"];
                var cmndnv = col["cmndnv"];
                var hochieunv = col["hochieunv"];
                var noithuongtrunv = col["noithuongtrunv"];
                var diachihtnv = col["diachihtnv"];
                var sdtnv = col["sdtnv"];
                var hotenntd = col["hotenntd"].ToUpper();
                var gioitinhntd = col["gioitinhntd"];
                var ngaysinhntd = col["ngaysinhntd"];
                var dantocntd = col["dantocntd"];
                var quoctichntd = col["quoctichntd"];
                var cmndntd = col["cmndntd"];
                var hochieuntd = col["hochieuntd"];
                var noisinhntd = col["noisinhntd"];
                var nguyenquanntd = col["nguyenquanntd"];
                var nghenghiepnlvntd = col["nghenghiepnlvntd"];
                var noithuongtruntd = col["noithuongtruntd"];
                var diachihtntd = col["diachihtntd"];
                var sdtntd = col["sdtntd"];
                var hotenchuho = col["hotenchuho"];
                var quanhechuho = col["quanhechuho"];
                var noidung = col["noidung"];

                var hotentd1 = col["hotentd1"];
                var hotentd2 = col["hotentd2"];
                var hotentd3 = col["hotentd3"];
                var hotentd4 = col["hotentd4"];
                var hotentd5 = col["hotentd5"];
                var hotentd6 = col["hotentd6"];

                var ngaysinhtd1 = col["ngaysinhtd1"];
                var ngaysinhtd2 = col["ngaysinhtd2"];
                var ngaysinhtd3 = col["ngaysinhtd3"];
                var ngaysinhtd4 = col["ngaysinhtd4"];
                var ngaysinhtd5 = col["ngaysinhtd5"];
                var ngaysinhtd6 = col["ngaysinhtd6"];

                var gioitinhtd1 = col["gioitinhtd1"];
                var gioitinhtd2 = col["gioitinhtd2"];
                var gioitinhtd3 = col["gioitinhtd3"];
                var gioitinhtd4 = col["gioitinhtd4"];
                var gioitinhtd5 = col["gioitinhtd5"];
                var gioitinhtd6 = col["gioitinhtd6"];

                var noisinhtd1 = col["noisinhtd1"];
                var noisinhtd2 = col["noisinhtd2"];
                var noisinhtd3 = col["noisinhtd3"];
                var noisinhtd4 = col["noisinhtd4"];
                var noisinhtd5 = col["noisinhtd5"];
                var noisinhtd6 = col["noisinhtd6"];

                var nghenghieptd1 = col["nghenghieptd1"];
                var nghenghieptd2 = col["nghenghieptd2"];
                var nghenghieptd3 = col["nghenghieptd3"];
                var nghenghieptd4 = col["nghenghieptd4"];
                var nghenghieptd5 = col["nghenghieptd5"];
                var nghenghieptd6 = col["nghenghieptd6"];

                var dantoctd1 = col["dantoctd1"];
                var dantoctd2 = col["dantoctd2"];
                var dantoctd3 = col["dantoctd3"];
                var dantoctd4 = col["dantoctd4"];
                var dantoctd5 = col["dantoctd5"];
                var dantoctd6 = col["dantoctd6"];

                var quoctichtd1 = col["quoctichtd1"];
                var quoctichtd2 = col["quoctichtd2"];
                var quoctichtd3 = col["quoctichtd3"];
                var quoctichtd4 = col["quoctichtd4"];
                var quoctichtd5 = col["quoctichtd5"];
                var quoctichtd6 = col["quoctichtd6"];

                var cmndtd1 = col["cmndtd1"];
                var cmndtd2 = col["cmndtd2"];
                var cmndtd3 = col["cmndtd3"];
                var cmndtd4 = col["cmndtd4"];
                var cmndtd5 = col["cmndtd5"];
                var cmndtd6 = col["cmndtd6"];

                var quanhetd1 = col["quanhetd1"];
                var quanhetd2 = col["quanhetd2"];
                var quanhetd3 = col["quanhetd3"];
                var quanhetd4 = col["quanhetd4"];
                var quanhetd5 = col["quanhetd5"];
                var quanhetd6 = col["quanhetd6"];

                con.Open();
                string ma = @Session["MaTD"].ToString();
                string sql = "Update THAYDOINHANKHAU set HOTENNV=N'"
                    + hotennv + "',GIOITINHNV=N'" + gioitinhnv + "',CMNDSONV=N'" + cmndnv + "',HOCHIEUNV=N'" + hochieunv + "',NOITHUONGTRUNV=N'" + noithuongtrunv + "',DIACHIHTNV=N'" + diachihtnv + "',SODTNV=N'" + sdtnv + "',HOTENNTD=N'"
                    + hotenntd + "',GIOITINHNTD=N'" + gioitinhntd + "',NGAYSINHNTD=N'" + ngaysinhntd + "',DANTOCNTD=N'" + dantocntd + "',QUOCTICHNTD=N'" + quoctichntd + "',CMNDSONTD=N'" + cmndntd + "',HOCHIEUNTD=N'" + hochieuntd + "',NOISINHNTD=N'"
                    + noisinhntd + "',QUEQUANNTD=N'" + nguyenquanntd + "',NGHENGHIEPNLVNTD=N'" + nghenghiepnlvntd + "',NOITHUONGTRUNTD=N'" + noithuongtruntd + "',DIACHIHTNTD=N'" + diachihtntd + "',SODTNTD=N'"
                    + sdtntd + "',HOTENCHUHO=N'" + hotenchuho + "',QUANHECHUHO=N'" + quanhechuho + "',NOIDUNGTHAYDOI=N'" + noidung + "',HOTENTD1=N'"
                    + hotentd1 + "',NGAYSINHTD1=N'" + ngaysinhtd1 + "',GIOITINHTD1=N'" + gioitinhtd1 + "',NOISINHTD1=N'" + noisinhtd1 + "',NGHENGHIEPTD1=N'" + nghenghieptd1 + "',DANTOCTD1=N'" + dantoctd1 + "',QUOCTICHTD1=N'" + quoctichtd1 + "',CMNDTD1=N'" + cmndtd1 + "',QUANHETD1=N'" + quanhetd1 + "',HOTENTD2=N'"
                    + hotentd2 + "',NGAYSINHTD2=N'" + ngaysinhtd2 + "',GIOITINHTD2=N'" + gioitinhtd2 + "',NOISINHTD2=N'" + noisinhtd2 + "',NGHENGHIEPTD2=N'" + nghenghieptd2 + "',DANTOCTD2=N'" + dantoctd2 + "',QUOCTICHTD2=N'" + quoctichtd2 + "',CMNDTD2=N'" + cmndtd2 + "',QUANHETD2=N'" + quanhetd2 + "',HOTENTD3=N'"
                    + hotentd3 + "',NGAYSINHTD3=N'" + ngaysinhtd3 + "',GIOITINHTD3=N'" + gioitinhtd3 + "',NOISINHTD3=N'" + noisinhtd3 + "',NGHENGHIEPTD3=N'" + nghenghieptd3 + "',DANTOCTD3=N'" + dantoctd3 + "',QUOCTICHTD3=N'" + quoctichtd3 + "',CMNDTD3=N'" + cmndtd3 + "',QUANHETD3=N'" + quanhetd3 + "',HOTENTD4=N'"
                    + hotentd4 + "',NGAYSINHTD4=N'" + ngaysinhtd4 + "',GIOITINHTD4=N'" + gioitinhtd4 + "',NOISINHTD4=N'" + noisinhtd4 + "',NGHENGHIEPTD4=N'" + nghenghieptd4 + "',DANTOCTD4=N'" + dantoctd4 + "',QUOCTICHTD4=N'" + quoctichtd4 + "',CMNDTD4=N'" + cmndtd4 + "',QUANHETD4=N'" + quanhetd4 + "' where MA = N'" + ma + "'";
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
            }
            return RedirectToAction("HoanThanh");
        }
        [HttpGet]
        public ActionResult GuiMaXN()
        {
            //try
            //{
                Random rd = new Random();
                string ma = rd.Next(1000, 9999).ToString();
                SmtpClient client = new SmtpClient()
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential()
                    {
                        UserName = "huynhngoctri1999@gmail.com",
                        Password = "TriNgocHuynh921@"
                    }
                };
                string strsel = "Select * from HOPDONG";
                DSHopDong ds = new DSHopDong(strsel);
                hopdong sp = ds.lsthopdong.FirstOrDefault(t => t.MAHD == @Session["Taikhoan"].ToString());
                MailAddress FromEmail = new MailAddress("huynhngoctri1999@gmail.com", "Mã xác thực ");
                MailAddress ToEmail = new MailAddress(sp.EMAIL.Trim(), "Some one");
                MailMessage Message = new MailMessage()
                {
                    From = FromEmail,
                    Subject = "Mã Xác Thực Của Bạn",
                    Body = "Mã xác thực của bạn là: " + ma
                };
                Message.To.Add(ToEmail);

                client.Send(Message);
                @Session["MAXN"] = ma;
            //}
            //catch
            //{
            //    ViewBag.Thongbao = "Lỗi hệ thống !!";
            //    return RedirectToAction("DangNhap", "Home");
            //}
            return View();
        }
        [HttpPost]
        public ActionResult GuiMaXN(FormCollection col)
        {
            var ma = col["txtma"];
            if (@Session["MAXN"].ToString() == ma)
            {
                string strsel = "Select * from HOPDONG";
                DSHopDong ds = new DSHopDong(strsel);
                hopdong sp = ds.lsthopdong.FirstOrDefault(t => t.MAHD == @Session["Taikhoan"].ToString());
                string sql = "select * from PHONG";
                DSPhong p = new DSPhong(sql);

                phong phong = p.lstphong.FirstOrDefault(t => t.MAPHONG == sp.MAPHONG);

                @Session["TK"] = sp.HOTENNT;
                @Session["DX"] = "Đăng xuất";
                @Session["DN"] = "";
                Session["Tenphong"] = phong.TENPHONG;
                return RedirectToAction("Home", "Home");
            }
            else
            {
                ViewBag.ThongBao = "Mã xác thực không đúng. Vui lòng kiểm tra lại email";
            }
            return View();
        }
        public ActionResult ThongTinTaiKhoan()
        {
            string strsel = "Select * from HOPDONG";
            DSHopDong ds = new DSHopDong(strsel);
            hopdong sp = ds.lsthopdong.FirstOrDefault(t => t.MAHD == @Session["Taikhoan"].ToString());
            return View(sp);
        }
    }
}
