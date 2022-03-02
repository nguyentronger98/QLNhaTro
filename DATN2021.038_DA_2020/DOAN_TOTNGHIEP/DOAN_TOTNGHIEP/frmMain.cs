using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using DOAN_TOTNGHIEP.DAO;
using DOAN_TOTNGHIEP.DTO;
using DevExpress.XtraNavBar;

namespace DOAN_TOTNGHIEP
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        string mact;
        public frmMain(string mact)
        {
            this.mact = mact;
            InitializeComponent();
        }
        private Form KiemTraTonTai(Type ptype)
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == ptype)
                {
                    return f;
                }
            }
            return null;
        }
        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadKhuVuc();
            ThongBao();
        }
        public void ThongBao()
        {
            List<HopDong> lsthd = HopDongDAO.Instance.loadHopList().Where(t => t.TINHTRANG == true).ToList();
            if (lsthd != null)
            {
                string thongbao1 = "";
                foreach (var a in lsthd)
                {
                    TimeSpan ngay = a.NGAYKETTHUC.Date - DateTime.Now.Date;
                    int songay = ngay.Days;
                    if (songay < 30)
                    {
                        thongbao1 = "Hợp đồng " + a.MAHD + " sắp hết hạn\n";
                    }
                }
                if (thongbao1 != "")
                {
                    MessageBox.Show(thongbao1, "Thông báo");
                }
            }
        }
        public void LoadKhuVuc()
        {
            navDSKhuVuc.ItemLinks.Clear();
            List<KhuVuc> lstphong = KhuVucDAO.Instance.loadKhuVucList();
            foreach (KhuVuc item in lstphong)
            {
                NavBarItem pt = new NavBarItem();
                pt.Caption = item.TENKV;
                pt.Appearance.ForeColor = System.Drawing.Color.Black;
                pt.Tag = item;
                pt.Appearance.Font = new System.Drawing.Font("Times New Roman", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
                pt.ImageOptions.SmallImage = global::DOAN_TOTNGHIEP.Properties.Resources.parking_and_1st_floor_32px;
                pt.AppearanceHotTracked.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                pt.AppearanceHotTracked.ForeColor = System.Drawing.Color.Red;
                pt.AppearanceHotTracked.Options.UseBackColor = true;
                pt.AppearanceHotTracked.Options.UseBorderColor = true;
                pt.AppearanceHotTracked.Options.UseFont = true;
                pt.AppearanceHotTracked.Options.UseForeColor = true;
                navDSKhuVuc.ItemLinks.Add(pt);
                pt.LinkClicked += pt_LinkClicked;
            }
        }

        void pt_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            string ma = ((sender as NavBarItem).Tag as KhuVuc).MAKV;
            string tenkv = ((sender as NavBarItem).Tag as KhuVuc).TENKV;
            Form frm = KiemTraTonTai(typeof(frmDSPhong));
            if (frm != null)
            {
                frm.Close();
                frmDSPhong f = new frmDSPhong(ma,tenkv,mact);
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                frmDSPhong f = new frmDSPhong(ma,tenkv,mact);
                f.MdiParent = this;
                f.Show();
            }
        }

        private void nacKhaiBaoNhanKhau_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            frmKhaiBaoNhanKhau frm = new frmKhaiBaoNhanKhau();
            frm.ShowDialog();
        }

        private void btnLapHopDong_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmLapHopDongThuePhong frm = new frmLapHopDongThuePhong("","",mact);
            frm.ShowDialog();
        }

        private void navQLKhuVuc_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            Form frm = KiemTraTonTai(typeof(frmQLKhuVuc));
            if (frm != null)
            {
                frm.Close();
                frmQLKhuVuc f = new frmQLKhuVuc();
                f.MdiParent = this;
                f.Show();
                LoadKhuVuc();
            }
            else
            {
                frmQLKhuVuc f = new frmQLKhuVuc();
                f.MdiParent = this;
                f.Show();
                LoadKhuVuc();
            }
        }

        private void navQLPhong_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            Form frm = KiemTraTonTai(typeof(frmQLPhong));
            if (frm != null)
            {
                frm.Close();
                frmQLPhong f = new frmQLPhong();
                f.MdiParent = this;
                f.Show();
            }
            else
            {
                frmQLPhong f = new frmQLPhong();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnQLKhuVuc_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = KiemTraTonTai(typeof(frmQLKhuVuc));
            if (frm != null)
            {
                return;
            }
            else
            {
                frmQLKhuVuc f = new frmQLKhuVuc();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnQLPhong_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = KiemTraTonTai(typeof(frmQLPhong));
            if (frm != null)
            {
                return;
            }
            else
            {
                frmQLPhong f = new frmQLPhong();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnQLThietbi_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = KiemTraTonTai(typeof(frmQLThietBi));
            if (frm != null)
            {
                return;
            }
            else
            {
                frmQLThietBi f = new frmQLThietBi();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnThemTB_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = KiemTraTonTai(typeof(frmThemThietBi));
            if (frm != null)
            {
                return;
            }
            else
            {
                frmThemThietBi f = new frmThemThietBi();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void itemThayDoiNK_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            frmThayDoiNhanKhau frm = new frmThayDoiNhanKhau();
            frm.ShowDialog();
        }

        private void btnDatCoc_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmDatCoc frm = new frmDatCoc();
            frm.ShowDialog();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            try
            {
                List<DatCoc> lst = DatCocDAO.Instance.loadDatCoc().Where(t => t.TINHTRANG == true).ToList();
                if (lst != null)
                {
                    string thongbao = "";
                    foreach (var item in lst)
                    {
                        TimeSpan ngay = DateTime.Now.Date - DateTime.Parse(item.NGAYDAT).Date;
                        int songay = ngay.Days;
                        if (songay > 7)
                        {
                            DatCocDAO.Instance.SuaTinhTrangCoc(item.MACOC);
                            PhongTroDAO.Instance.SuaTinhTrangPhong(item.MAPHONG, "trống");
                            thongbao += "Phiếu cọc " + item.MACOC + " ." + "Tên người cọc: " + item.HOTEN + " đã hết hạn.\n";
                        }
                    }
                    if (thongbao != "")
                    {
                        MessageBox.Show(thongbao, "Thông báo");
                    }
                    else
                    {
                    }
                }
            }
            catch
            { }
        }

        private void itemThongKe_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            Form frm = KiemTraTonTai(typeof(frmThongKe));
            if (frm != null)
            {
                return;
            }
            else
            {
                frmThongKe f = new frmThongKe();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnThongKe_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = KiemTraTonTai(typeof(frmThongKe));
            if (frm != null)
            {
                return;
            }
            else
            {
                frmThongKe f = new frmThongKe();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDoiPhong_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmChuyenPhong frm = new frmChuyenPhong();
            frm.ShowDialog();
            frmMain_Load(sender, e);
        }

        private void itemDSHopDongSapHH_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            Form frm = KiemTraTonTai(typeof(frmDSHopDongSapHetHan));
            if (frm != null)
            {
                return;
            }
            else
            {
                frmDSHopDongSapHetHan f = new frmDSHopDongSapHetHan();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnTraPhong_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmTraPhong frm = new frmTraPhong();
            frm.ShowDialog();
            frmMain_Load(sender,e);
        }

        private void btnDSKhachRoiTro_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = KiemTraTonTai(typeof(frmDSKhachDaRoiTro));
            if (frm != null)
            {
                return;
            }
            else
            {
                frmDSKhachDaRoiTro f = new frmDSKhachDaRoiTro();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnDSHDSapHetHan_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = KiemTraTonTai(typeof(frmDSHopDongSapHetHan));
            if (frm != null)
            {
                return;
            }
            else
            {
                frmDSHopDongSapHetHan f = new frmDSHopDongSapHetHan();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnQLThongBao_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmQLThongBao frm = new frmQLThongBao(mact);
            frm.ShowDialog();
        }

        private void btnQLQuyDinh_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmQLQuyDinh frm = new frmQLQuyDinh(mact);
            frm.ShowDialog();
        }

        private void itemCamKet_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            frmCamKet frm = new frmCamKet();
            frm.ShowDialog();
        }

        private void itemSoDKTamTru_LinkClicked(object sender, NavBarLinkEventArgs e)
        {
            frmReportDKTamTru frm = new frmReportDKTamTru();
            frm.ShowDialog();
        }

        private void btnQLKhachTro_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = KiemTraTonTai(typeof(frmQLKhachTro));
            if (frm != null)
            {
                return;
            }
            else
            {
                frmQLKhachTro f = new frmQLKhachTro();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnHDKetThuc_ItemClick(object sender, ItemClickEventArgs e)
        {
            Form frm = KiemTraTonTai(typeof(frmDSHopDongDaKetThuc));
            if (frm != null)
            {
                return;
            }
            else
            {
                frmDSHopDongDaKetThuc f = new frmDSHopDongDaKetThuc();
                f.MdiParent = this;
                f.Show();
            }
        }

        private void btnQLSuCo_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmThongBaoSuCo frm = new frmThongBaoSuCo();
            frm.ShowDialog();
        }

        private void btnDoiMatKhau_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmDoiMatKhau frm = new frmDoiMatKhau();
            frm.ShowDialog();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn đăng xuất tài khoản ?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question,MessageBoxDefaultButton.Button2)!=DialogResult.No)
            {
                Application.Exit();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btnDangXuat_ItemClick(object sender, ItemClickEventArgs e)
        {
            this.Close();
        }
    }
}