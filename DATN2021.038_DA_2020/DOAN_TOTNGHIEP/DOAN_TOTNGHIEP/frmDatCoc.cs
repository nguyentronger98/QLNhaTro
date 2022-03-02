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
    public partial class frmDatCoc : Form
    {
        bool themmoi;
        public frmDatCoc()
        {
            InitializeComponent();
        }

        private void txtSDT_TextChanged(object sender, EventArgs e)
        {
     
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTienCoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void frmDatCoc_Load(object sender, EventArgs e)
        {
            cboPhong.DataSource = PhongTroDAO.Instance.loadPhongTroListAll().Where(t => t.TINHTRANG == "trống").ToList();
            cboPhong.DisplayMember = "TENPHONG";
            cboPhong.ValueMember = "MAPHONG";
            cboPhong.SelectedIndex = -1;
            dgvTB.DataSource = DatCocDAO.Instance.loadDatCoc();
            locktext();
        }
        public string MaTuTang()
        {
            string kq = "";
            if (DatCocDAO.Instance.LayMaCoc() == "")
            {
                kq = "C0001";
            }
            else
            {
                int so = int.Parse(DatCocDAO.Instance.LayMaCoc().Remove(0, 1));

                so = so + 1;
                if (so < 10)
                {
                    kq = "C" + "000";
                }
                else if (so < 100)
                {
                    kq = "C" + "00";
                }
                else if (so < 1000)
                {
                    kq = "C" + "0";
                }
                else
                {
                    kq = "C";
                }
                kq = kq + so.ToString();
            }
            return kq;
        }
        public void locktext()
        {
            txtMa.Enabled = false;
            cboPhong.Enabled = false;
            dtNgaydat.Enabled = false;
            txtHoTen.Enabled = false;
            txtSDT.Enabled = false;
            txtDiaChi.Enabled = false;
            cboTienCoc.Enabled = false;

            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }
        public void un_locktext()
        {
            txtMa.Enabled = true;
            cboPhong.Enabled = true;
            dtNgaydat.Enabled = true;
            txtHoTen.Enabled = true;
            txtSDT.Enabled = true;
            txtDiaChi.Enabled = true;
            cboTienCoc.Enabled = true;

            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }
        public void setnull()
        {
            cboPhong.SelectedIndex = -1;
            txtMa.ResetText();
            dtNgaydat.ResetText();
            txtHoTen.ResetText();
            txtSDT.ResetText();
            txtDiaChi.ResetText();
            cboTienCoc.ResetText();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            themmoi = true;
            un_locktext();
            setnull();
            txtMa.Text = MaTuTang();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            themmoi = false;
            un_locktext();
            txtMa.Enabled = false;
            txtHoTen.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa dữ liệu này?", "Chú Ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    DatCocDAO.Instance.Xoa(txtMa.Text);
                    MessageBox.Show("Đã Xóa Thành Công", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvTB.DataSource = DatCocDAO.Instance.loadDatCoc();
                    PhongTroDAO.Instance.SuaTinhTrangPhong(maphong,"trống");
                    setnull();
                    locktext();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi");
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMa.Text != "")
            {
                if (dtNgaydat.Text != "")
                {
                    if (txtHoTen.Text != "")
                    {
                        if (txtSDT.Text != "")
                        {
                            if (txtDiaChi.Text != "")
                            {
                                if (cboTienCoc.Text != "")
                                {
                                    if (themmoi == true)
                                    {
                                        try
                                        {
                                            DatCocDAO.Instance.Them(txtMa.Text, dtNgaydat.Text, txtHoTen.Text, txtSDT.Text, txtDiaChi.Text, double.Parse(cboTienCoc.Text), cboPhong.SelectedValue.ToString());

                                            locktext();
                                            dgvTB.DataSource = DatCocDAO.Instance.loadDatCoc();
                                            MessageBox.Show("Đã Lưu Thành Công", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            PhongTroDAO.Instance.SuaTinhTrangPhong(cboPhong.SelectedValue.ToString(), "đã đặt cọc");
                                        }
                                        catch (Exception ex)
                                        {
                                            MessageBox.Show(ex.ToString(), "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        }
                                    }
                                    else
                                        try
                                        {
                                            DatCocDAO.Instance.Sua(txtMa.Text, dtNgaydat.Text, txtHoTen.Text, txtSDT.Text, txtDiaChi.Text, double.Parse(cboTienCoc.Text));

                                            MessageBox.Show("Đã Sửa Thành Công Thành Công", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        }
                                        catch (Exception ex)
                                        {
                                            MessageBox.Show(ex.ToString(), "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        }
                                    locktext();
                                    dgvTB.DataSource = DatCocDAO.Instance.loadDatCoc();
                                }
                                else
                                {
                                    MessageBox.Show("Tiền cọc không được để trống", "Chú Ý", MessageBoxButtons.OK);
                                    cboTienCoc.Focus();
                                }
                            }
                            else
                            {
                                MessageBox.Show("Địa chỉ không được để trống", "Chú Ý", MessageBoxButtons.OK);
                                txtDiaChi.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Số điện thoại không được để trống", "Chú Ý", MessageBoxButtons.OK);
                            txtSDT.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Họ tên không được để trống", "Chú Ý", MessageBoxButtons.OK);
                        txtHoTen.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Bạn phải chọn ngày đặt", "Chú Ý", MessageBoxButtons.OK);
                    dtNgaydat.Focus();
                }
            }
            else
            {
                MessageBox.Show("Mã Không được để trống", "Chú Ý", MessageBoxButtons.OK);
                txtMa.Focus();
            }
        }
        string maphong;
        private void dgvTB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int dong = e.RowIndex;
                txtMa.Text = dgvTB.Rows[dong].Cells[0].Value.ToString();
                dtNgaydat.Value = DateTime.Parse(dgvTB.Rows[dong].Cells[1].Value.ToString());
                txtHoTen.Text = dgvTB.Rows[dong].Cells[2].Value.ToString();
                txtSDT.Text = dgvTB.Rows[dong].Cells[3].Value.ToString();
                txtDiaChi.Text = dgvTB.Rows[dong].Cells[4].Value.ToString();
                cboTienCoc.Text = dgvTB.Rows[dong].Cells[5].Value.ToString();
                maphong = dgvTB.Rows[dong].Cells["MAPHONG1"].Value.ToString();
                locktext();
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
            catch
            {
                return;
            }
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            frmReportDatCoc frm = new frmReportDatCoc(txtMa.Text);
            frm.ShowDialog();
        }
    }
}
