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
    public partial class frmLapHopDongThuePhong : Form
    {
        string ma, tenphong, mact;
        string noidkhk;
        bool themmoi;
        public frmLapHopDongThuePhong(string ma, string tenphong, string mact)
        {
            this.ma = ma;
            this.tenphong = tenphong;
            this.mact = mact;
            InitializeComponent();
        }
        public string MaHDTuDong()
        {
            string kq = "";
            if (HopDongDAO.Instance.LayMaHD() == "")
            {
                kq = "HD00000001";
            }
            else
            {
                int so = int.Parse(HopDongDAO.Instance.LayMaHD().Remove(0, 2));

                so = so + 1;
                if (so < 10)
                {
                    kq = "HD" + "0000000";
                }
                else if (so < 100)
                {
                    kq = "HD" + "000000";
                }
                else if (so < 1000)
                {
                    kq = "HD" + "00000";
                }
                else if (so < 10000)
                {
                    kq = "HD" + "0000";
                }
                else if (so < 100000)
                {
                    kq = "HD" + "000";
                }
                else if (so < 1000000)
                {
                    kq = "HD" + "00";
                }
                else if (so < 10000000)
                {
                    kq = "HD" + "0";
                }
                else
                {
                    kq = "HD";
                }
                kq = kq + so.ToString();
            }
            return kq;
        }
        private void frmLapHopDongThuePhong_Load(object sender, EventArgs e)
        {
            this.Text = "HỢP ĐỒNG THUÊ PHÒNG " + tenphong;
            label1.Text = "HỢP ĐỒNG THUÊ PHÒNG " + tenphong;
            //cboHoTen.DataSource = DangKyDAO.Instance.loadDSDangKyTro();
            //cboHoTen.DisplayMember = "HOTEN";
            //cboHoTen.ValueMember = "MA";
            cboHoTen.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboHoTen.AutoCompleteSource = AutoCompleteSource.ListItems;
            cboPhong.DataSource = PhongTroDAO.Instance.loadPhongTroListAll().Where(t=>t.TINHTRANG!="có người").ToList();
            cboPhong.DisplayMember = "TENPHONG";
            cboPhong.ValueMember = "MAPHONG";
            cboPhong.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboPhong.AutoCompleteSource = AutoCompleteSource.ListItems;
            dgvHD.DataSource = HopDongDAO.Instance.loadHopList().Where(t=>t.TINHTRANG==true).ToList();
            block();
            cboPhong.SelectedValue = ma;
            btnLuu.Enabled = false;
            btnSua.Enabled = false;
            btnInHD.Enabled = false;
            btnInCamKet.Enabled = false;
        }
        public string ChonHinhThucTT()
        {
            string hinhthuctt = null;
            if (rdTienMat.Checked)
            {
                hinhthuctt = "Tiền mặt";
            }
            if (rdCK.Checked)
            {
                txtTaiKhoan.Enabled = true;
                hinhthuctt = "Chuyển khoản số tài khoản: " + txtTaiKhoan.Text;
            }
            else
            {
                txtTaiKhoan.Enabled = false;
            }
            if (rdMOMO.Checked)
            {
                txtTaiKhoan.Enabled = true;
                hinhthuctt = "Chuyển qua MOMO: " + txtTaiKhoan.Text;
            }
            else
            {
                txtTaiKhoan.Enabled = false;
            }
            return hinhthuctt;
        }
        private void btnInHD_Click(object sender, EventArgs e)
        {
            try
            {
                string hotenA = cboHoTen.Text;
                string ngaysinhA = txtNgaySinhA.Text;
                string noidkhkA = txtNoiDKHK.Text;
                string cmndA = txtCMNDA.Text;
                string ngaycapA = txtNgayCapA.Text;
                string noicapA = txtNoiCapCMND.Text;
                string sdtA = txtSDTA.Text;
                string email = txtEmail.Text;
                string diachichothue = txtDiaChiChoThue.Text;
                string giathue = txtGiaThue.Text;
                string hinhthuctt = ChonHinhThucTT();
                string tiendien = txtDien.Text;
                string tiennuoc = txtNuoc.Text;
                string songuoio = cboSLNguoi.Text;
                string tiencoc = txtTienCoc.Text;
                string tienwifi = txtWifi.Text;
                string ngaybd = dtNgayBD.Text;
                string ngaykt = "";
                if (cboThoiHan.Text == "6")
                {
                    ngaykt = DateTime.Parse(dtNgayBD.Text).AddMonths(6).ToShortDateString();
                }
                if (cboThoiHan.Text == "12")
                {
                    ngaykt = DateTime.Parse(dtNgayBD.Text).AddMonths(12).ToShortDateString();
                }
                if (cboThoiHan.Text == "18")
                {
                    ngaykt = DateTime.Parse(dtNgayBD.Text).AddMonths(18).ToShortDateString();
                }
                if (cboThoiHan.Text == "24")
                {
                    ngaykt = DateTime.Parse(dtNgayBD.Text).AddMonths(24).ToShortDateString();
                }
                if (cboThoiHan.Text == "36")
                {
                    ngaykt = DateTime.Parse(dtNgayBD.Text).AddMonths(26).ToShortDateString();
                }
                ChuTro ct = ChuTroDAO.Instance.loadDSCT().FirstOrDefault(t => t.MACT == mact);

                WordExport w = new WordExport();
                w.QuyetDinhKhenThuong(ct.HOTEN, ct.NGAYSINH.ToShortDateString(), ct.DIACHI, ct.CMND, ct.NGAYSINH.ToShortDateString(), ct.NOICAPCMND, ct.SDT, hotenA, ngaysinhA, noidkhkA, cmndA, ngaycapA, noicapA, sdtA, diachichothue, giathue, hinhthuctt, tiendien, tiennuoc, tiencoc, ngaybd, ngaykt);
            }
            catch { MessageBox.Show("Lỗi hệ thống !!"); }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click_1(object sender, EventArgs e)
        {

            txtMAHD.ReadOnly = false;
            txtMAHD.Text = MaHDTuDong();
            //PhongTro pt = PhongTroDAO.Instance.loadPhongTroListAll().SingleOrDefault(t=>t.MAPHONG == cboPhong.SelectedValue.ToString());
            ClearText();
            //txtGiaThue.Text = pt.GIAPHONG.ToString();
            unblock();
            themmoi = true;
            btnSua.Enabled = false;
            //btnXoa.Enabled = false;
            btnLuu.Enabled = true;
        }
        public void ClearText()
        {
            cboHoTen.ResetText();
            txtNgayCapA.Text = "";
            txtNgaySinhA.Text = "";
            txtNoiCapCMND.ResetText();
            txtCMNDA.ResetText();
            txtSDTA.ResetText();
            txtDiaChiChoThue.ResetText();
            txtTaiKhoan.ResetText();
            txtGiaThue.ResetText();
            txtTienCoc.ResetText();
            cboPhong.SelectedIndex = -1;
            //txtTienDien.ResetText();
            //txtTienNuoc.ResetText();
            dtNgayBD.Text = "";
            cboThoiHan.Text = "";
            cboHoTen.Focus();
        }
        public void unblock()
        {
            cboPhong.Enabled = true;
            cboHoTen.Enabled = true;
            txtNgayCapA.Enabled = true;
            txtNgaySinhA.Enabled = true;
            txtNoiCapCMND.Enabled = true;
            txtCMNDA.Enabled = true;
            txtSDTA.Enabled = true;
            txtDiaChiChoThue.Enabled = true;
            rdTienMat.Enabled = true;
            rdCK.Enabled = true;
            rdMOMO.Enabled = true;
            txtTaiKhoan.Enabled = false;
            txtGiaThue.Enabled = true;
            txtTienCoc.Enabled = true;
            cboSLNguoi.Enabled = true;
            //txtTienDien.Enabled = true;
            //txtTienNuoc.Enabled = true;
            dtNgayBD.Enabled = true;
            cboThoiHan.Enabled = true;
            txtNoiDKHK.Enabled = true;
            ckGiaThue.Enabled = true;
            txtEmail.Enabled = true;
            ckDien.Enabled = true;
            ckDien.Checked = true;
            txtDien.Enabled = true;
            ckNuoc.Enabled = true;
            ckNuoc.Checked = true;
            txtNuoc.Enabled = true;
            ckWifi.Enabled = true;
            txtWifi.Enabled = true;
            //ckTienDien.Enabled = true;
            //ckTienNuoc.Enabled = true;
        }
        public void block()
        {
            cboPhong.Enabled = false;
            cboHoTen.Enabled = false;
            txtNgayCapA.Enabled = false;
            txtNgaySinhA.Enabled = false;
            txtNoiCapCMND.Enabled = false;
            txtCMNDA.Enabled = false;
            txtSDTA.Enabled = false;
            txtDiaChiChoThue.Enabled = false;
            rdTienMat.Enabled = false;
            rdCK.Enabled = false;
            rdMOMO.Enabled = false;
            txtNoiDKHK.Enabled = false;
            txtTaiKhoan.Enabled = false;
            txtGiaThue.Enabled = false;
            txtTienCoc.Enabled = false;
            cboSLNguoi.Enabled = false;
            //txtTienDien.Enabled = false;
            //txtTienNuoc.Enabled = false;
            dtNgayBD.Enabled = false;
            cboThoiHan.Enabled = false;
            
            ckGiaThue.Enabled = false;
            txtEmail.Enabled = false;
            ckDien.Enabled = false;
            txtDien.Enabled = false;
            ckNuoc.Enabled = false;
            txtNuoc.Enabled = false;
            ckWifi.Enabled = false;
            txtWifi.Enabled = false;
            //ckTienDien.Enabled = false;
            //ckTienNuoc.Enabled = false;
        }

        private void tableLayoutPanel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                string hotenA = cboHoTen.Text;
                string ngaysinhA = txtNgaySinhA.Text;
                string noidkhkA = txtNoiDKHK.Text;
                string cmndA = txtCMNDA.Text;
                string ngaycapA = txtNgayCapA.Text;
                string noicapA = txtNoiCapCMND.Text;
                string sdtA = txtSDTA.Text;
                string email = txtEmail.Text;
                string diachichothue = txtDiaChiChoThue.Text;
                string giathue = txtGiaThue.Text;
                string hinhthuctt = ChonHinhThucTT();
                string tiendien = txtDien.Text;
                string tiennuoc = txtNuoc.Text;
                string songuoio = cboSLNguoi.Text;
                string tiencoc = txtTienCoc.Text;
                string tienwifi = txtWifi.Text;
                string ngaybd = dtNgayBD.Text;
                string ngaykt = "";
                if (cboThoiHan.Text == "6")
                {
                    ngaykt = DateTime.Parse(dtNgayBD.Text).AddMonths(6).ToShortDateString();
                }
                if (cboThoiHan.Text == "12")
                {
                    ngaykt = DateTime.Parse(dtNgayBD.Text).AddMonths(12).ToShortDateString();
                }
                if (cboThoiHan.Text == "18")
                {
                    ngaykt = DateTime.Parse(dtNgayBD.Text).AddMonths(18).ToShortDateString();
                }
                if (cboThoiHan.Text == "24")
                {
                    ngaykt = DateTime.Parse(dtNgayBD.Text).AddMonths(24).ToShortDateString();
                }
                if (cboThoiHan.Text == "36")
                {
                    ngaykt = DateTime.Parse(dtNgayBD.Text).AddMonths(26).ToShortDateString();
                }

                if (cboHoTen.Text == "")
                {
                    MessageBox.Show("Hãy nhâp họ và tên");
                    cboHoTen.Focus();
                    return;
                }
                if (txtNgaySinhA.Text == "")
                {
                    MessageBox.Show("Hãy chọn ngày sinh");
                    txtNgaySinhA.Focus();
                    return;
                }
                if (txtNoiDKHK.Text == "")
                {
                    MessageBox.Show("Hãy nhập nơi đăng ký hộ khẩu!!");
                    txtNoiDKHK.Focus();
                    return;
                }
                
                if (txtCMNDA.Text == "")
                {
                    MessageBox.Show("Hãy nhâp CMND");
                    txtCMNDA.Focus();
                    return;
                }
                if (txtNgayCapA.Text == "")
                {
                    MessageBox.Show("Hãy chọn ngày cấp CMND");
                    txtNgayCapA.Focus();
                    return;
                }
                if (txtNoiCapCMND.Text == "")
                {
                    MessageBox.Show("Hãy nhâp nơi cấp CMND");
                    txtNoiCapCMND.Focus();
                    return;
                }
                if (txtSDTA.Text == "")
                {
                    MessageBox.Show("Hãy nhâp số điên thoại bên A");
                    txtSDTA.Focus();
                    return;
                }
                if (txtDiaChiChoThue.Text == "")
                {
                    MessageBox.Show("Hãy nhâp địa chỉ cho thuê");
                    txtDiaChiChoThue.Focus();
                    return;
                }
                if (txtGiaThue.Text == "")
                {
                    MessageBox.Show("Hãy nhâp giá thuê");
                    txtGiaThue.Focus();
                    return;
                }
                if (cboSLNguoi.Text == "")
                {
                    MessageBox.Show("Hãy chọn số lượng người ở");
                    cboSLNguoi.Select();
                    return;
                }
                //if (txtHinhThucTT.Text == "")
                //{
                //    MessageBox.Show("Hãy nhâp hình thức thanh toán");
                //    txtHinhThucTT.Focus();
                //    return;
                //}
                //if (txtTienDien.Text == "")
                //{
                //    MessageBox.Show("Hãy nhâp tiền điện");
                //    txtTienDien.Focus();
                //    return;
                //}
                //if (txtTienNuoc.Text == "")
                //{
                //    MessageBox.Show("Hãy nhâp Tiền nước");
                //    txtTienNuoc.Focus();
                //    return;
                //}
                if (txtTienCoc.Text == "")
                {
                    MessageBox.Show("Hãy nhâp tiền đặt cọc");
                    txtTienCoc.Focus();
                    return;
                }
                if (dtNgayBD.Text == "")
                {
                    MessageBox.Show("Hãy nhâp ngày bắt đầu hợp đồng");
                    dtNgayBD.Focus();
                    return;
                }
                if (dtNgayBD.Text == "")
                {
                    MessageBox.Show("Hãy nhâp ngày kết thúc hợp đồng");
                    dtNgayBD.Focus();
                    return;
                }
                if (themmoi == true)
                {
                    HopDongDAO.Instance.ThemHopDong(txtMAHD.Text, DateTime.Today.ToShortDateString(), hotenA, ngaysinhA, noidkhkA, cmndA, ngaycapA, noicapA,email, sdtA, diachichothue, double.Parse(giathue), hinhthuctt, double.Parse(tiencoc), double.Parse(tiendien), double.Parse(tiennuoc), ngaybd, ngaykt, int.Parse(songuoio), "123", "True","",cboPhong.SelectedValue.ToString(),mact);
                    KhachTroDAO.Instance.Them(hotenA, ngaysinhA, noidkhk, cmndA, txtMAHD.Text,sdtA,email);
                    MessageBox.Show("Thành công ");
                    PhongTroDAO.Instance.SuaTinhTrangPhong(cboPhong.SelectedValue.ToString(), "có người");
                    dgvHD.DataSource = HopDongDAO.Instance.loadHopList();
                    block();
                }
                else
                {
                    HopDongDAO.Instance.Sua(txtMAHD.Text, hotenA, ngaysinhA, noidkhkA, cmndA, ngaycapA, noicapA,email, sdtA, ngaykt, int.Parse(songuoio));
                    MessageBox.Show("Cập nhật thành công !!");
                    dgvHD.DataSource = HopDongDAO.Instance.loadHopList();
                }
            }
            catch
            { MessageBox.Show("Lỗi!!"); }
        }

        private void cboHuyen_Click(object sender, EventArgs e)
        {
            
        }

        private void cboXa_Click(object sender, EventArgs e)
        {
            
        }

        private void cboTinh_Click(object sender, EventArgs e)
        {
            
        }
        string ngaykt = "";
        private void dgvHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int row = e.RowIndex;
                txtMAHD.Text = dgvHD.Rows[row].Cells["MAHD"].Value.ToString();
                cboHoTen.Text = dgvHD.Rows[row].Cells["HOTENNT"].Value.ToString();
                txtNgaySinhA.Value = DateTime.Parse(dgvHD.Rows[row].Cells["NGAYSINHNT"].Value.ToString());
                txtNoiDKHK.Text = dgvHD.Rows[row].Cells[5].Value.ToString();
                txtCMNDA.Text = dgvHD.Rows[row].Cells["CMNDNT"].Value.ToString();
                txtNgayCapA.Value = DateTime.Parse(dgvHD.Rows[row].Cells["NGAYCAPCMNDNT"].Value.ToString());
                txtNoiCapCMND.Text = dgvHD.Rows[row].Cells["NOICAPCMNDNT"].Value.ToString();
                txtSDTA.Text = dgvHD.Rows[row].Cells["SDTNT"].Value.ToString();
                txtDiaChiChoThue.Text = dgvHD.Rows[row].Cells["DIACHITHUE"].Value.ToString();
                //txtHinhThucTT.Text = dgvHD.Rows[row].Cells[11].Value.ToString();
                txtGiaThue.Text = dgvHD.Rows[row].Cells[10].Value.ToString();
                txtTienCoc.Text = dgvHD.Rows[row].Cells["TIENCOC"].Value.ToString();
                cboSLNguoi.Text = dgvHD.Rows[row].Cells["SONGUOIO"].Value.ToString();
                cboPhong.Text = dgvHD.Rows[row].Cells["TENPHONG1"].Value.ToString();
                //txtTienDien.Text = dgvHD.Rows[row].Cells[12].Value.ToString();
                //txtTienNuoc.Text = dgvHD.Rows[row].Cells[13].Value.ToString();
                dtNgayBD.Value = DateTime.Parse(dgvHD.Rows[row].Cells["NGAYBATDAU"].Value.ToString());
                TimeSpan thang = (DateTime.Parse(dgvHD.Rows[row].Cells["NGAYKETTHUC"].Value.ToString()).Date - DateTime.Parse(dgvHD.Rows[row].Cells["NGAYBATDAU"].Value.ToString()).Date);
                int sothang = thang.Days / 30;
                cboThoiHan.Text = sothang.ToString();
                
                ngaykt = dgvHD.Rows[row].Cells[15].Value.ToString();
                btnLuu.Enabled = false;
                //btnXoa.Enabled = true;
                btnSua.Enabled = true;
                btnInHD.Enabled = true;
                btnInCamKet.Enabled = true;
            }
            catch
            { return; }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            txtGiaThue.ReadOnly = false;
        }

        private void ckGiaThue_CheckedChanged(object sender, EventArgs e)
        {
            if (ckGiaThue.Checked)
            {
                txtGiaThue.Enabled = false;
            }
            else
            {
                txtGiaThue.Enabled = true;
            }
        }

        private void ckTienDien_CheckedChanged(object sender, EventArgs e)
        {
            //if (ckTienDien.Checked)
            //{
            //    txtTienDien.Enabled = false;
            //}
            //else
            //{
            //    txtTienDien.Enabled = true;
            //}
        }

        private void ckTienNuoc_CheckedChanged(object sender, EventArgs e)
        {
            //if (ckTienNuoc.Checked)
            //{
            //    txtTienNuoc.Enabled = false;
            //}
            //else
            //{
            //    txtTienNuoc.Enabled = true;
            //}
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                PhongTro pt = PhongTroDAO.Instance.loadPhongTroListAll().SingleOrDefault(t => t.MAPHONG == cboPhong.SelectedValue.ToString());
                txtGiaThue.Text = pt.GIAPHONG.ToString();
            }
            catch
            { }
        }

        private void txtNoiCapA_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    txtNoiCapA.BindingContext = this.BindingContext;
            //    txtNoiCapA.DisplayMember = "name";
            //    txtNoiCapA.ValueMember = "_id";
            //    txtNoiCapA.DataSource = provinceDAO.Instance.loadTinh();
            //}
            //catch

            //{ return; }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //if (MessageBox.Show("Xóa dữ liệu này?", "Chú Ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            //{
            //    try
            //    {
            //        HopDongDAO.Instance.Xoa(txtMAHD.Text);
            //        MessageBox.Show("Đã Xóa Thành Công", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //        dgvHD.DataSource = HopDongDAO.Instance.loadHopList();
            //        //setnull();
            //        //locktext();
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message, "Lỗi");
            //    }
            //}
        }

        private void rdTienMat_CheckedChanged(object sender, EventArgs e)
        {
            txtTaiKhoan.Enabled = false;
        }

        private void rdCK_CheckedChanged(object sender, EventArgs e)
        {
            txtTaiKhoan.Enabled = true;
            txtTaiKhoan.Focus();
        }

        private void rdMOMO_CheckedChanged(object sender, EventArgs e)
        {
            txtTaiKhoan.Enabled = true;
            txtTaiKhoan.Focus();
        }

        private void cboHoTen_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DangKy dk = DangKyDAO.Instance.loadDSDangKyTro().FirstOrDefault(t=>t.MA==cboHoTen.SelectedValue.ToString());
                txtCMNDA.Text = dk.CMND;
                txtSDTA.Text = dk.SDT;
                txtNgaySinhA.Value = DateTime.Parse(dk.NGAYSINH);
            }
            catch
            { }
        }

        private void rdTienMat_CheckedChanged_1(object sender, EventArgs e)
        {
            txtTaiKhoan.ResetText();
            txtTaiKhoan.Enabled = false;
        }

        private void rdCK_CheckedChanged_1(object sender, EventArgs e)
        {
            txtTaiKhoan.ResetText();
            txtTaiKhoan.Enabled = true;
            txtTaiKhoan.Focus();
        }

        private void rdMOMO_CheckedChanged_1(object sender, EventArgs e)
        {
            txtTaiKhoan.ResetText();
            txtTaiKhoan.Enabled = true;
            txtTaiKhoan.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            unblock();
            btnSua.Enabled = false;
            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            txtDiaChiChoThue.Enabled = false;
            rdCK.Enabled = false;
            rdTienMat.Enabled = false;
            rdMOMO.Enabled = false;
            txtTaiKhoan.Enabled = false;
            dtNgayBD.Enabled = false;
            txtGiaThue.Enabled = false;
            txtTienCoc.Enabled = false;
            themmoi = false;
            
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void ckDien_CheckedChanged(object sender, EventArgs e)
        {
            if (ckDien.Checked)
            {
                txtDien.ReadOnly = true;
            }
            else
            {
                txtDien.ReadOnly = false;
            }
        }

        private void ckNuoc_CheckedChanged(object sender, EventArgs e)
        {
            if (ckNuoc.Checked)
            {
                txtNuoc.ReadOnly = true;
            }
            else
            {
                txtNuoc.ReadOnly = false;
            }
        }

        private void ckWifi_CheckedChanged(object sender, EventArgs e)
        {
            if (ckWifi.Checked)
            {
                txtWifi.ReadOnly = true;
            }
            else
            {
                txtWifi.ReadOnly = false;
            }
        }

        private void btnInCamKet_Click(object sender, EventArgs e)
        {
            frmReportCamKet frm = new frmReportCamKet(txtMAHD.Text);
            frm.ShowDialog();
        }

        private void txtSDTA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCMNDA_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
