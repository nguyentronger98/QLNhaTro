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
    public partial class frmKhaiBaoNhanKhau : Form
    {
        public frmKhaiBaoNhanKhau()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnInPhong_Click(object sender, EventArgs e)
        {
            frmReportKhaiBaoNhanKhau frm = new frmReportKhaiBaoNhanKhau(cboPhong.SelectedValue.ToString());
            frm.ShowDialog();
        }

        private void frmKhaiBaoNhanKhau_Load(object sender, EventArgs e)
        {
            cboPhong.DataSource = PhongTroDAO.Instance.loadPhongTroListAll().Where(t=>t.TINHTRANG=="có người").ToList();
            cboPhong.DisplayMember = "TENPHONG";
            cboPhong.ValueMember = "MAPHONG";
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            frmReportKhaiBaoNhanKhau frm = new frmReportKhaiBaoNhanKhau("");
            frm.ShowDialog();
        }
    }
}
