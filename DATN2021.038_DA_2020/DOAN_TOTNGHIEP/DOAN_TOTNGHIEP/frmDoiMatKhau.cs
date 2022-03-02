using DOAN_TOTNGHIEP.DAO;
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
    public partial class frmDoiMatKhau : Form
    {
        public frmDoiMatKhau()
        {
            InitializeComponent();
        }

        private void frmDoiMatKhau_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(txtmkcu.Text == "")
                {
                    MessageBox.Show("Không được bỏ trống!!");
                    txtmkcu.Focus();
                    return;
                }
                if (txtmkmoi.Text == "")
                {
                    MessageBox.Show("Không được bỏ trống!!");
                    txtmkmoi.Focus();
                    return;
                }
                if (txtnlmk.Text == "")
                {
                    MessageBox.Show("Không được bỏ trống!!");
                    txtnlmk.Focus();
                    return;
                }
                if (txtmkmoi.Text != txtnlmk.Text)
                {
                    MessageBox.Show("Nhập lại mật khẩu không khớp");
                    txtnlmk.Focus();
                    return;
                }
                if (DangNhapDAO.Instance.KiemTraTaiKhoan(frmDangNhap.LuuThongTin.tendn, txtmkcu.Text.Trim()) == true)
                {
                    DangNhapDAO.Instance.DoiMatKhau(frmDangNhap.LuuThongTin.tendn, txtmkmoi.Text.Trim());
                    MessageBox.Show("Đổi mật khẩu thành công");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Mật khẩu cũ không khớp. Vui lòng thử lại");
                    txtmkcu.Focus();
                    return;
                }
            }
            catch
            { MessageBox.Show("Lỗi !!"); }
        }
    }
}
