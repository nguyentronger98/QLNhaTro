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
    public partial class frmThayDoiNhanKhau : Form
    {
        public frmThayDoiNhanKhau()
        {
            InitializeComponent();
        }

        private void frmThayDoiNhanKhau_Load(object sender, EventArgs e)
        {
            cboPhong.DataSource = PhongTroDAO.Instance.loadPhongTroListAll().Where(t => t.TINHTRANG == "có người").ToList();
            cboPhong.DisplayMember = "TENPHONG";
            cboPhong.ValueMember = "MAPHONG";
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            frmReportThayDoiNhanKhau frm = new frmReportThayDoiNhanKhau("");
            frm.ShowDialog();
        }

        private void btnInPhong_Click(object sender, EventArgs e)
        {
            string mahd = HopDongDAO.Instance.loadHopList().FirstOrDefault(t => t.MAPHONG == cboPhong.SelectedValue.ToString()).MAHD;
            frmReportThayDoiNhanKhau frm = new frmReportThayDoiNhanKhau(mahd);
            frm.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
