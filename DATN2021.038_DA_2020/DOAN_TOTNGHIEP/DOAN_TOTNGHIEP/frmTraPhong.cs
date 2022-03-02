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
    public partial class frmTraPhong : Form
    {
        public frmTraPhong()
        {
            InitializeComponent();
        }

        private void frmTraPhong_Load(object sender, EventArgs e)
        {
            cboPhong.DataSource = PhongTroDAO.Instance.loadPhongTroListAll().Where(t => t.TINHTRANG == "có người").ToList();
            cboPhong.DisplayMember = "TENPHONG";
            cboPhong.ValueMember = "MAPHONG";
            cboPhong.SelectedIndex = -1;
            cboPhong.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboPhong.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void btnTraP_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn muốn trả phòng này?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                try
                {
                    string maphong = cboPhong.SelectedValue.ToString();
                    string mahd = HopDongDAO.Instance.loadHopList().FirstOrDefault(t => t.MAPHONG == maphong && t.TINHTRANG == true).MAHD;
                    KhachTroDAO.Instance.TraPhong(mahd);
                    HopDongDAO.Instance.KetThucHopDong(mahd);
                    PhongTroDAO.Instance.SuaTinhTrangPhong(maphong, "trống");
                    cboPhong.DataSource = PhongTroDAO.Instance.loadPhongTroListAll().Where(t => t.TINHTRANG == "có người").ToList();
                    MessageBox.Show("Thành công");
                    this.Close();
                    return;
                }
                catch
                { MessageBox.Show("Lỗi hệ thống !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
        }

    }
}
