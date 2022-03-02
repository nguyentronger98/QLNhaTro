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
    public partial class frmChuyenPhong : Form
    {
        public frmChuyenPhong()
        {
            InitializeComponent();
        }

        private void frmChuyenPhong_Load(object sender, EventArgs e)
        {
            cboPhongA.DataSource = PhongTroDAO.Instance.loadPhongTroListAll().Where(t => t.TINHTRANG == "có người").ToList();
            cboPhongA.DisplayMember = "TENPHONG";
            cboPhongA.ValueMember = "MAPHONG";
            cboPhongB.DataSource = PhongTroDAO.Instance.loadPhongTroListAll().Where(t => t.TINHTRANG == "trống").ToList();
            cboPhongB.DisplayMember = "TENPHONG";
            cboPhongB.ValueMember = "MAPHONG";
        }

        private void btnChuyen_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboPhongA.Text == "")
                {
                    MessageBox.Show("Hãy chọn phòng bạn đang ở ");
                    cboPhongA.Select();
                    return;
                }
                if (cboPhongB.Text == "")
                {
                    MessageBox.Show("Hãy chọn phòng muốn chuyển ");
                    cboPhongB.Select();
                    return;
                }
                string mahd = HopDongDAO.Instance.loadHopList().FirstOrDefault(t=>t.MAPHONG == cboPhongA.SelectedValue.ToString() && t.TINHTRANG==true).MAHD;
                PhongTroDAO.Instance.ChuyenPhong(mahd, cboPhongB.SelectedValue.ToString());
                PhongTroDAO.Instance.SuaTinhTrangPhong(cboPhongA.SelectedValue.ToString(), "trống");
                PhongTroDAO.Instance.SuaTinhTrangPhong(cboPhongB.SelectedValue.ToString(), "có người");
                MessageBox.Show("Thành công");
                this.Close();
            }
            catch
            {
                MessageBox.Show("Lỗi hệ thống !!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
