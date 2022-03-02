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
    public partial class frmDSHopDongSapHetHan : Form
    {
        public frmDSHopDongSapHetHan()
        {
            InitializeComponent();
        }

        private void frmDSHopDongSapHetHan_Load(object sender, EventArgs e)
        {
            dgvHD.DataSource = HopDongDAO.Instance.loadHopList().Where(t => (t.NGAYKETTHUC.Date - DateTime.Now.Date).Days < 30).ToList();
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void dgvHD_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
