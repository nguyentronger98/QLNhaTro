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
    public partial class frmDSHopDongDaKetThuc : Form
    {
        public frmDSHopDongDaKetThuc()
        {
            InitializeComponent();
        }

        private void frmDSHopDongDaKetThuc_Load(object sender, EventArgs e)
        {
            dgvHD.DataSource = HopDongDAO.Instance.loadHopList().Where(t => t.TINHTRANG == false).ToList();
        }
    }
}
