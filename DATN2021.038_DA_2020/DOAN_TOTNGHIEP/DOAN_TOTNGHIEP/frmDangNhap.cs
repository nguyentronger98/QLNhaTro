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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }
        public class LuuThongTin
        {
            static public string tendn;
        }
        private void btnDN_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtuser.Text == "")
                {
                    MessageBox.Show("User name không được để trống !!");
                    txtuser.Focus();
                    return;
                }
                if (txtpass.Text == "")
                {
                    MessageBox.Show("Password không được để trống !!");
                    txtpass.Focus();
                    return;
                }
                DangNhap dn = DangNhapDAO.Instance.loadDSDangNhap().FirstOrDefault(t => t.MAID.Trim() == txtuser.Text && t.MATKHAU.Trim() == txtpass.Text && t.TINHTRANG==true);
                //int kq = DangNhapDAO.Instance.loadDSDangNhap().Where(t => t.MAID == txtuser.Text && t.MATKHAU == txtpass.Text).ToList().Count;
                if (dn != null)
                {
                    MessageBox.Show("Đăng nhập thành công.");
                    LuuThongTin.tendn = txtuser.Text.Trim();
                    frmMain frm = new frmMain(dn.MACT);
                    frm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Sai tài khoản hoặc mật khẩu");
                    return;
                }
            }
            catch
            { MessageBox.Show("Lỗi kết nối !!","Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
