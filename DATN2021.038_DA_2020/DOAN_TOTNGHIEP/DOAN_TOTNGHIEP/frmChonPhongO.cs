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
    public partial class frmChonPhongO : Form
    {
        string makhach;
        public frmChonPhongO(string makhach)
        {
            this.makhach = makhach;
            InitializeComponent();
        }

        private void frmChonPhongO_Load(object sender, EventArgs e)
        {
            cboPhong.DataSource = HopDongDAO.Instance.loadHopList();
            cboPhong.DisplayMember = "TENPHONG";
            cboPhong.ValueMember = "MAPHONG";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (KhachTroDAO.Instance.KtraSLNguoiO(HopDongDAO.Instance.loadHopList().FirstOrDefault(t => t.MAPHONG == cboPhong.SelectedValue.ToString() && t.TINHTRANG == true).MAHD) == false)
                {
                    string mahd = HopDongDAO.Instance.loadHopList().FirstOrDefault(t => t.MAPHONG == cboPhong.SelectedValue.ToString() && t.TINHTRANG == true).MAHD;
                    KhachTroDAO.Instance.TiepTucTro(makhach, mahd);
                    MessageBox.Show("Thành công");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Phòng này đã đủ người", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Lỗi hệ thống !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
