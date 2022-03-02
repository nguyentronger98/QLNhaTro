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
    public partial class frmThemThietBi : Form
    {
        bool themmoi;
        public frmThemThietBi()
        {
            InitializeComponent();
        }

        private void frmThemThietBi_Load(object sender, EventArgs e)
        {
            cboPhong.DataSource = PhongTroDAO.Instance.loadPhongTroListAll();
            cboPhong.DisplayMember = "TENPHONG";
            cboPhong.ValueMember = "MAPHONG";
            cboPhong.SelectedIndex = -1;
            cboThietBi.DataSource = ThietBiDAO.Instance.loadDSThietBi();
            cboThietBi.DisplayMember = "TENTB";
            cboThietBi.ValueMember = "MATB";
            cboThietBi.SelectedIndex = -1;
            dgvTB.DataSource = ChiTietPhongDAO.Instance.loadDSCTPhong();
            locktext();
        }
        public void locktext()
        {
            txtSL.Enabled = false;
            cboPhong.Enabled = false;
            cboThietBi.Enabled = false;


            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }
        public void un_locktext()
        {
            txtSL.Enabled = true;
            cboPhong.Enabled = true;
            cboThietBi.Enabled = true;

            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }
        public void setnull()
        {
            cboPhong.SelectedIndex = -1;
            cboThietBi.SelectedIndex = -1;
            txtSL.ResetText();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            themmoi = true;
            un_locktext();
            cboPhong.Enabled = true;
            cboThietBi.Enabled = true;
            setnull();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            themmoi = false;
            un_locktext();
            cboPhong.Enabled = false;
            cboThietBi.Enabled = false;
            txtSL.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa dữ liệu này?", "Chú Ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    ChiTietPhongDAO.Instance.Xoa(cboPhong.SelectedValue.ToString(),cboThietBi.SelectedValue.ToString());
                    MessageBox.Show("Đã Xóa Thành Công", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvTB.DataSource = ThietBiDAO.Instance.loadDSThietBi();
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
            if (cboPhong.Text != "")
            {
                if (cboThietBi.Text != "")
                {
                    if (themmoi == true)
                    {
                        try
                        {
                            if (ChiTietPhongDAO.Instance.KTraTonTai(cboPhong.SelectedValue.ToString(), cboThietBi.SelectedValue.ToString()) == false)
                            {
                                ChiTietPhongDAO.Instance.Them(cboPhong.SelectedValue.ToString(), cboThietBi.SelectedValue.ToString(), int.Parse(txtSL.Value.ToString()));

                                locktext();
                                dgvTB.DataSource = ChiTietPhongDAO.Instance.loadDSCTPhong();
                                MessageBox.Show("Đã Lưu Thành Công", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Thiết bị này đã tồn tại trong phòng này rồi !!", "Thông báo");
                                return;
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString(), "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                        try
                        {
                            ChiTietPhongDAO.Instance.Sua(cboPhong.SelectedValue.ToString(), cboThietBi.SelectedValue.ToString(), int.Parse(txtSL.Value.ToString()));

                            MessageBox.Show("Đã Sửa Thành Công Thành Công", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString(), "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    cboPhong.Enabled = true;
                    cboThietBi.Enabled = true;
                    locktext();
                    dgvTB.DataSource = ChiTietPhongDAO.Instance.loadDSCTPhong();
                }
                else
                {
                    MessageBox.Show("Mã thiết bị Không được để trống", "Chú Ý", MessageBoxButtons.OK);
                    cboThietBi.Focus();
                }
            }
            else
            {
                MessageBox.Show("Mã phòng Không được để trống", "Chú Ý", MessageBoxButtons.OK);
                cboPhong.Focus();
            }
        }

        private void dgvTB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int dong = e.RowIndex;
                cboPhong.SelectedValue = dgvTB.Rows[dong].Cells[0].Value.ToString();
                cboThietBi.SelectedValue = dgvTB.Rows[dong].Cells[2].Value.ToString();
                txtSL.Value = decimal.Parse(dgvTB.Rows[dong].Cells[4].Value.ToString());

                locktext();
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
            catch
            {
                return;
            }
        }
    }
}
