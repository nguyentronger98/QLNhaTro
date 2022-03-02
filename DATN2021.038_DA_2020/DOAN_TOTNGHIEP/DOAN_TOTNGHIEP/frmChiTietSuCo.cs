using DOAN_TOTNGHIEP.DAO;
using DOAN_TOTNGHIEP.DTO;
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
    public partial class frmChiTietSuCo : Form
    {
        string ma, tenphong;
        public frmChiTietSuCo(string ma,string tenphong)
        {
            this.ma = ma;
            this.tenphong = tenphong;
            InitializeComponent();
        }

        private void frmChiTietSuCo_Load(object sender, EventArgs e)
        {
            SuCo sc = SuCoDAO.Instance.loadDSSuCo().SingleOrDefault(t => t.MA == ma);
            lblTen.Text = sc.TIEUDE;
            lblNoiDung.Text = "NỘI DUNG: " + sc.NOIDUNG;
            lblTieuDe.Text = "CHI TIẾT SỰ CỐ PHÒNG " + sc.TENPHONG;

        }
    }
}
