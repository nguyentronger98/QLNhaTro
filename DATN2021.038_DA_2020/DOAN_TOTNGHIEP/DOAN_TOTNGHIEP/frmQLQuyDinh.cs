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
    public partial class frmQLQuyDinh : Form
    {
        bool themmoi;
        string ma;
        string mact;
        public frmQLQuyDinh(string mact)
        {
            this.mact = mact;
            InitializeComponent();
        }

        private void frmQLQuyDinh_Load(object sender, EventArgs e)
        {
            dgvQD.DataSource = QuyDinhDAO.Instance.loadQuyDinh();
            block();
        }
        private void block()
        {
            txtND.Enabled = false;
            dtNgay.Enabled = false;

            btnXoa.Enabled = false;
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnLuu.Enabled = false;
        }
        private void unblock()
        {
            txtND.Enabled = true;
            dtNgay.Enabled = true;

            btnXoa.Enabled = true;
            btnThem.Enabled = false;
            btnSua.Enabled = true;
            btnLuu.Enabled = true;
        }
        private void Reset_Text()
        {
            txtND.ResetText();
            dtNgay.ResetText();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            unblock();
            Reset_Text();
            txtND.Focus();
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            themmoi = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            themmoi = false;
            unblock();
            txtND.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa dữ liệu này?", "Chú Ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    DatCoc pt = DatCocDAO.Instance.loadDatCoc().FirstOrDefault(t=>t.MACOC==ma);
                    QuyDinhDAO.Instance.Xoa(ma);
                    MessageBox.Show("Đã Xóa Thành Công", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvQD.DataSource = QuyDinhDAO.Instance.loadQuyDinh();
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
                if (dtNgay.Text != "")
                {
                    if (txtND.Text != "")
                    {
                        if (themmoi == true)
                        {
                            try
                            {
                                QuyDinhDAO.Instance.Them(dtNgay.Text, txtND.Text,mact);

                                block();
                                dgvQD.DataSource = QuyDinhDAO.Instance.loadQuyDinh();
                                MessageBox.Show("Đã Lưu Thành Công", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.ToString(), "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        else
                            try
                            {
                                QuyDinhDAO.Instance.Sua(ma, dtNgay.Text, txtND.Text);

                                MessageBox.Show("Đã Sửa Thành Công Thành Công", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.ToString(), "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        block();
                        dgvQD.DataSource = QuyDinhDAO.Instance.loadQuyDinh();
                    }
                    else
                    {
                        MessageBox.Show("Nội dung không được để trống", "Chú Ý", MessageBoxButtons.OK);
                        txtND.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Bạn phải chọn ngày đăng", "Chú Ý", MessageBoxButtons.OK);
                    dtNgay.Select();
                }
        }

        private void dgvQD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int dong = e.RowIndex;
                ma = dgvQD.Rows[dong].Cells[0].Value.ToString();
                dtNgay.Text = dgvQD.Rows[dong].Cells[1].Value.ToString();
                txtND.Text = dgvQD.Rows[dong].Cells[2].Value.ToString();

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
                    dgvQD.DataSource = QuyDinhDAO.Instance.loadQuyDinh();
                }
                else
                {
                    dgvQD.DataSource = QuyDinhDAO.Instance.TimKiem(txtTimKiem.Text);
                }
            }
            catch
            {
                return;
            }
        }
    }
}
