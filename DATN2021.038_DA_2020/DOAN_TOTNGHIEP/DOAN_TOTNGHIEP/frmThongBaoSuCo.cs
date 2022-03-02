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
    public partial class frmThongBaoSuCo : Form
    {
        public frmThongBaoSuCo()
        {
            InitializeComponent();
        }

        private void frmThongBaoSuCo_Load(object sender, EventArgs e)
        {
            dgvSuCo.DataSource = SuCoDAO.Instance.loadDSSuCo().Where(t => t.TINHTRANG == false).ToList();
        }

        private void dtTimKiem_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                string ngay = dtTimKiem.Text;
                dgvSuCo.DataSource = SuCoDAO.Instance.TimKiem(dtTimKiem.Text).Where(t => t.TINHTRANG == false).ToList();
            }
            catch
            { MessageBox.Show("Lỗi!!!"); }
        }

        private void dgvSuCo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string ma = dgvSuCo.Rows[e.RowIndex].Cells["MA"].Value.ToString();
            string tenphong = dgvSuCo.Rows[e.RowIndex].Cells["TENPHONG"].Value.ToString();
            frmChiTietSuCo frm = new frmChiTietSuCo(ma, tenphong);
            frm.ShowDialog();
        }
    }
}
