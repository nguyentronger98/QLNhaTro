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
    public partial class frmCamKet : Form
    {
        public frmCamKet()
        {
            InitializeComponent();
        }

        private void frmCamKet_Load(object sender, EventArgs e)
        {
            cboPhong.DataSource = PhongTroDAO.Instance.loadPhongTroListAll().Where(t => t.TINHTRANG == "có người").ToList();
            cboPhong.DisplayMember = "TENPHONG";
            cboPhong.ValueMember = "MAPHONG";
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            frmReportCamKet frm = new frmReportCamKet("");
            frm.ShowDialog();
        }

        private void btnInPhong_Click(object sender, EventArgs e)
        {
            string mahd = HopDongDAO.Instance.loadHopList().FirstOrDefault(t => t.MAPHONG == cboPhong.SelectedValue.ToString()).MAHD;
            frmReportCamKet frm = new frmReportCamKet(mahd);
            frm.ShowDialog();
        }
    }
}
