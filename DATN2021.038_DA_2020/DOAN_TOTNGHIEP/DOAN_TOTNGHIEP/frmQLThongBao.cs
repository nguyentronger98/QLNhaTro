using DOAN_TOTNGHIEP.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOAN_TOTNGHIEP
{
    public partial class frmQLThongBao : Form
    {
        bool themmoi;
        string ma, mact;
        public frmQLThongBao(string mact)
        {
            this.mact = mact;
            InitializeComponent();
        }

        private void frmQLThongBao_Load(object sender, EventArgs e)
        {
            dgvThongBao.DataSource = ThongBaoDAO.Instance.loadThongBao();
            block();
        }
        private void block()
        {
            txtTen.Enabled = false;
            txtND.Enabled = false;
            dtNgay.Enabled = false;

            btnXoa.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnLuu.Enabled = false;
        }
        private void unblock()
        {
            txtTen.Enabled = true;
            txtND.Enabled = true;
            dtNgay.Enabled = true;

            btnXoa.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnLuu.Enabled = true;
        }
        private void Reset_Text()
        {
            txtTen.ResetText();
            txtND.ResetText();
            dtNgay.ResetText();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            unblock();
            Reset_Text();
            txtTen.Focus();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            themmoi = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            themmoi = false;
            unblock();
            txtTen.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa dữ liệu này?", "Chú Ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    ThongBaoDAO.Instance.Xoa(ma);
                    MessageBox.Show("Đã Xóa Thành Công", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvThongBao.DataSource = ThongBaoDAO.Instance.loadThongBao();
                    Reset_Text();
                    block();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi");
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTen.Text != "")
            {
                if (dtNgay.Text != "")
                {
                    if (txtND.Text != "")
                    {
                        if (themmoi == true)
                        {
                            try
                            {
                                ThongBaoDAO.Instance.Them(txtTen.Text, dtNgay.Text, txtND.Text,mact);
                                block();
                                dgvThongBao.DataSource = ThongBaoDAO.Instance.loadThongBao();
                                MessageBox.Show("Đã Lưu Thành Công", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.ToString(), "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                        {
                            try
                            {
                                ThongBaoDAO.Instance.Sua(ma, txtTen.Text, dtNgay.Text, txtND.Text);

                                MessageBox.Show("Đã Sửa Thành Công Thành Công", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.ToString(), "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            block();
                            dgvThongBao.DataSource = ThongBaoDAO.Instance.loadThongBao();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Bạn chưa chọn file", "Chú Ý", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    MessageBox.Show("Nội dung không được để trống", "Chú Ý", MessageBoxButtons.OK);
                    txtND.Focus();
                }
            }
            else
            {
                MessageBox.Show("Tên tieu đề không được để trống", "Chú Ý", MessageBoxButtons.OK);
                txtTen.Focus();
            }
        }

        private void dgvThongBao_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvThongBao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int dong = e.RowIndex;
                ma = dgvThongBao.Rows[dong].Cells[0].Value.ToString();
                txtTen.Text = dgvThongBao.Rows[dong].Cells[1].Value.ToString();
                dtNgay.Text = dgvThongBao.Rows[dong].Cells[2].Value.ToString();
                txtND.Text = dgvThongBao.Rows[dong].Cells[3].Value.ToString();

                block();
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
            }
            catch
            {
                return;
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtTimKiem.Text == "")
                {
                    dgvThongBao.DataSource = ThongBaoDAO.Instance.loadThongBao();
                }
                else
                {
                    dgvThongBao.DataSource = ThongBaoDAO.Instance.TimKiem(txtTimKiem.Text);
                }
            }
            catch
            {
                return;
            }
        }

        private void btnChon_Click(object sender, EventArgs e)
        {

        }
    }
}
