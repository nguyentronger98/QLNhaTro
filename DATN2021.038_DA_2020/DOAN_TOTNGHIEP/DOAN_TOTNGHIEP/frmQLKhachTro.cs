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
    public partial class frmQLKhachTro : Form
    {
        public frmQLKhachTro()
        {
            InitializeComponent();
        }

        private void frmQLKhachTro_Load(object sender, EventArgs e)
        {
            dgvKhachTro.DataSource = KhachTroDAO.Instance.DSKhachTro().Where(t => t.TINHTRANG == true).ToList();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtTimKiem.Text == ""||txtTimKiem.Text ==null)
                {
                    dgvKhachTro.DataSource = KhachTroDAO.Instance.DSKhachTro().Where(t => t.TINHTRANG == true).ToList();
                }
                else
                {
                    dgvKhachTro.DataSource = KhachTroDAO.Instance.TimKiem(txtTimKiem.Text.Trim());
                }
            }
            catch
            { return; }
        }

        private void dgvKhachTro_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                string makt = dgvKhachTro.Rows[e.RowIndex].Cells["MA"].Value.ToString();
                string tenphong = dgvKhachTro.Rows[e.RowIndex].Cells["TENPHONG"].Value.ToString();
                frmChiTietKhachTro frm = new frmChiTietKhachTro(makt,tenphong);
                frm.ShowDialog();
            }
            catch
            { }
        }
    }
}
