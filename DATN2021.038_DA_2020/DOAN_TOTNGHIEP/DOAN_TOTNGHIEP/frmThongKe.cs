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
    public partial class frmThongKe : Form
    {
        public frmThongKe()
        {
            InitializeComponent();
        }

        private void frmThongKe_Load(object sender, EventArgs e)
        {
            DataTable tbl = new DataTable();
            tbl.Columns.Add("Tên", typeof(string));
            tbl.Columns.Add("Số lượng", typeof(string));
            dgvThongKe.DataSource = tbl;
            tbl.Rows.Add("Tổng số lầu", KhuVucDAO.Instance.loadKhuVucList().Count.ToString());
            tbl.Rows.Add("Tổng số phòng", PhongTroDAO.Instance.loadPhongTroListAll().Count.ToString());
            tbl.Rows.Add("Tổng số người đang ở", KhachTroDAO.Instance.DSKhachTro().Where(t=>t.TINHTRANG==true).ToList().Count.ToString());
            tbl.Rows.Add("Tổng số Nam", KhachTroDAO.Instance.DSKhachTro().Where(t => t.GIOITINH.Trim() == "Nam").ToList().Count.ToString());
            tbl.Rows.Add("Tổng số Nữ", KhachTroDAO.Instance.DSKhachTro().Where(t => t.GIOITINH.Trim() == "Nữ").ToList().Count.ToString());
            tbl.Rows.Add("Tổng số người trong độ tuổi lao động", KhachTroDAO.Instance.DSKhachTro().Where(t => (int.Parse(DateTime.Now.Year.ToString()) - int.Parse(DateTime.Parse(t.NGAYSINH).Year.ToString())) >= 15 && (int.Parse(DateTime.Now.Year.ToString()) - int.Parse(DateTime.Parse(t.NGAYSINH).Year.ToString())) <= 60).ToList().Count.ToString());
            tbl.Rows.Add("Tổng số người trên độ tuổi lao động", KhachTroDAO.Instance.DSKhachTro().Where(t => (int.Parse(DateTime.Now.Year.ToString()) - int.Parse(DateTime.Parse(t.NGAYSINH).Year.ToString())) > 60).ToList().Count.ToString());
            tbl.Rows.Add("Tổng số người dưới độ tuổi lao động", KhachTroDAO.Instance.DSKhachTro().Where(t => (int.Parse(DateTime.Now.Year.ToString()) - int.Parse(DateTime.Parse(t.NGAYSINH).Year.ToString())) < 15).ToList().Count.ToString());
        }

        private void dgvThongKe_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex == 2)
                {

                }
            }
            catch
            {
            }
        }
    }
}
