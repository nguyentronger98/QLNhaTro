using DOAN_TOTNGHIEP.DAO;
using DOAN_TOTNGHIEP.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOAN_TOTNGHIEP
{
    public partial class frmChiTietKhachTro : Form
    {
        string makhach, tenphong;
        public frmChiTietKhachTro(string ma, string tenphong)
        {
            this.makhach = ma;
            this.tenphong = tenphong;
            InitializeComponent();
        }

        private void frmChiTietKhachTro_Load(object sender, EventArgs e)
        {
            this.Text = "THÔNG TIN KHÁCH TRỌ PHÒNG " + tenphong;
            lblTieuDe.Text = "THÔNG TIN KHÁCH TRỌ PHÒNG " + tenphong;
            KhachTro kt = KhachTroDAO.Instance.DSKhachTro().FirstOrDefault(t => t.MAKT == makhach);
            if (kt == null)
            {
                MessageBox.Show("Lỗi hệ thống !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
                this.Close();
            }
            if (kt.HINHTHE != "")
            {
                try
                {
                    pcHinh.BackgroundImage = Image.FromFile(@"C:\Users\Trong\Desktop\DATN2021.038_DA_2020\DOANTOTNGHIEP_WEB\DOANTOTNGHIEP\Hinh\" + kt.HINHTHE);
                }
                catch
                {
                    MessageBox.Show("Lỗi đường dẫn ảnh!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            lblHoTen.Text = kt.HOTEN;
            lblNgaysinh.Text = kt.NGAYSINH;
            lblGioiTinh.Text = kt.GIOITINH;
            lblNoiSinh.Text = kt.NOISINH;
            lblCMND.Text = kt.CMND;
            lblNoiThuongTru.Text = kt.NOITHUONGTRU;
            lblChoOHT.Text = kt.DIACHIHIENTAI;
            lblNNNLV.Text = kt.NGHENGHIEPNOILAMVIEC;
            ckChuPhong.Enabled = false;
            btnRoi.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;

            if (kt.CHUPHONG == true)
            {
                ckChuPhong.Checked = true;
            }
            else
            {
                ckChuPhong.Checked = false;
            }
        }

        private void btnRoi_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn sử dụng chức năng này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                try
                {
                    if (KhachTroDAO.Instance.KtraChuPhong(makhach, KhachTroDAO.Instance.DSKhachTro().FirstOrDefault(t => t.MAKT == makhach).MAHD) == false)
                    {
                        KhachTroDAO.Instance.RoiPhong(makhach);
                        MessageBox.Show("Thành công ");
                        this.Close();
                    }
                    else
                    {

                    }
                }
                catch
                {
                    MessageBox.Show("Lỗi hệ thống", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ckChuPhong_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ckChuPhong.Enabled = true;
            btnRoi.Enabled = false;
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                string chuphong;
                if (ckChuPhong.Checked)
                {
                    chuphong = "1";
                }
                else
                {
                    chuphong = "0";
                }
                KhachTroDAO.Instance.CapNhatChuPhong(makhach, chuphong);
                MessageBox.Show("Cập nhật thành công");
                ckChuPhong.Enabled = false;
                btnRoi.Enabled = true;
                btnSua.Enabled = true;
                btnLuu.Enabled = false;
                return;
            }
            catch
            {
                MessageBox.Show("Lỗi hệ thống !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
