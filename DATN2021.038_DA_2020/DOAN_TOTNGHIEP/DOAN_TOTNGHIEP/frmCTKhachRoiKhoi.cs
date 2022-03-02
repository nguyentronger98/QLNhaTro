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
    public partial class frmCTKhachRoiKhoi : Form
    {
        string makhach;
        public frmCTKhachRoiKhoi(string makhach)
        {
            this.makhach = makhach;
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOTiep_Click(object sender, EventArgs e)
        {
            frmChonPhongO frm = new frmChonPhongO(makhach);
            frm.ShowDialog();
        }

        private void frmCTKhachRoiKhoi_Load(object sender, EventArgs e)
        {
            KhachTro kt = KhachTroDAO.Instance.DSKhachTro().FirstOrDefault(t => t.MAKT == makhach);
            if (kt == null)
            {
                MessageBox.Show("Lỗi hệ thống !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            if (kt.HINHTHE != null)
            {
                try
                {
                    pcHinh.BackgroundImage = Image.FromFile(@"D:\DOANTOTNGHIEP\DOANTOTNGHIEP_WEB\DOANTOTNGHIEP\Hinh\" + kt.HINHTHE);
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
        }
    }
}
