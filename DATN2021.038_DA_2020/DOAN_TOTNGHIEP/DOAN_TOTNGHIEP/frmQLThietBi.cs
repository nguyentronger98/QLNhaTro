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
    public partial class frmQLThietBi : Form
    {
        bool themmoi;
        public frmQLThietBi()
        {
            InitializeComponent();
        }

        private void frmQLThietBi_Load(object sender, EventArgs e)
        {
            dgvTB.DataSource = ThietBiDAO.Instance.loadDSThietBi();
            locktext();
        }
        public void locktext()
        {
            txtMa.Enabled = false;
            txtTen.Enabled = false;


            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }
        public void un_locktext()
        {
            txtMa.Enabled = true;
            txtTen.Enabled = true;

            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }
        public void setnull()
        {
            txtMa.Text = "";
            txtTen.Text = "";
        }
        public string MaTuTang()
        {
            string kq = "";
            if (ThietBiDAO.Instance.LayMa() == "")
            {
                kq = "TB001";
            }
            else
            {
                int so = int.Parse(ThietBiDAO.Instance.LayMa().Remove(0, 2));

                so = so + 1;
                if (so < 10)
                {
                    kq = "TB" + "00";
                }
                else if (so < 100)
                {
                    kq = "TB" + "0";
                }
                else
                {
                    kq = "KV";
                }
                kq = kq + so.ToString();
            }
            return kq;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            themmoi = true;
            un_locktext();
            setnull();
            txtMa.Enabled = true;
            txtTen.Focus();
            txtMa.Text = MaTuTang();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            themmoi = false;
            un_locktext();
            txtMa.Enabled = false;
            txtTen.Focus();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa dữ liệu này?", "Chú Ý", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    ThietBiDAO.Instance.Xoa(txtMa.Text);
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
            if (txtMa.Text != "")
            {
                if (txtTen.Text != "")
                {
                    if (themmoi == true)
                    {
                        try
                        {
                            ThietBiDAO.Instance.Them(txtMa.Text, txtTen.Text);

                            locktext();
                            dgvTB.DataSource = ThietBiDAO.Instance.loadDSThietBi();
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
                            ThietBiDAO.Instance.Sua(txtMa.Text, txtTen.Text);

                            MessageBox.Show("Đã Sửa Thành Công Thành Công", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString(), "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    txtMa.Enabled = true;
                    locktext();
                    dgvTB.DataSource = ThietBiDAO.Instance.loadDSThietBi();
                }
                else
                {
                    MessageBox.Show("Tên Không được để trống", "Chú Ý", MessageBoxButtons.OK);
                    txtTen.Focus();
                }
            }
            else
            {
                MessageBox.Show("Mã Không được để trống", "Chú Ý", MessageBoxButtons.OK);
                txtMa.Focus();
            }
        }

        private void dgvTB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int dong = e.RowIndex;
                txtMa.Text = dgvTB.Rows[dong].Cells[0].Value.ToString();
                txtTen.Text = dgvTB.Rows[dong].Cells[1].Value.ToString();

                locktext();
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
                if (txtTimKiem.Text != "")
                {
                    dgvTB.DataSource = ThietBiDAO.Instance.TimKiem(txtTimKiem.Text);
                }
                else
                {
                    dgvTB.DataSource = ThietBiDAO.Instance.loadDSThietBi();
                }
            }
            catch
            {
                return;
            }
        }
    }
}
