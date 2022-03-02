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
    public partial class frmDSKhachDaRoiTro : Form
    {
        public frmDSKhachDaRoiTro()
        {
            InitializeComponent();
        }

        private void frmDSKhachDaRoiTro_Load(object sender, EventArgs e)
        {
            dgvKhachTro.DataSource = KhachTroDAO.Instance.DSKhachTro().Where(t => t.TINHTRANG == false).ToList();
        }

        private void dgvKhach_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void dgvKhach_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                string makhach = dgvKhachTro.Rows[e.RowIndex].Cells["MA"].Value.ToString();
                frmCTKhachRoiKhoi frm = new frmCTKhachRoiKhoi(makhach);
                frm.ShowDialog();
                dgvKhachTro.DataSource = KhachTroDAO.Instance.DSKhachTro().Where(t => t.TINHTRANG == false).ToList();
            }
            catch
            { }
        }
    }
}
