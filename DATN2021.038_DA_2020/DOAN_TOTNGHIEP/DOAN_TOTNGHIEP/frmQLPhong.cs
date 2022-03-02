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
using DOAN_TOTNGHIEP.ServiceRepository;
using System.Net.Http;
using DOAN_TOTNGHIEP.DTO2;

namespace DOAN_TOTNGHIEP
{
    public partial class frmQLPhong : Form
    {
        Services sv = new Services();
        bool themmoi;
        public frmQLPhong()
        {
            InitializeComponent();
        }

        private void frmQLPhong_Load(object sender, EventArgs e)
        {
            //var response = sv.GetResponse("api/phong/getphong");
            //if (response.IsSuccessStatusCode){
            //    var kq = response.Content.ReadAsAsync<List<PhongTro>>().Result;
            //    dgvPhong.DataSource = kq;
            //}
            dgvPhong.DataSource = PhongTroDAO.Instance.loadPhongTroListAll();
            cboKV.ValueMember = "";
            cboKV.DataSource = KhuVucDAO.Instance.loadKhuVucList();
            cboKV.DisplayMember = "TENKV";
            cboKV.ValueMember = "MAKV";
            string[] songuoi = new string[] {"1","2","3","4","5" };
            cboSoNguoi.DataSource = songuoi;
            locktext();
        }
        public void un_locktext()
        {
            txtMa.Enabled = true;
            txtTen.Enabled = true;
            txtGia.Enabled = true;
            cboSoNguoi.Enabled = true;
            cboKV.Enabled = true;

            btnThem.Enabled = false;
            btnLuu.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }
        public void locktext()
        {
            txtMa.Enabled = false;
            txtTen.Enabled = false;
            txtGia.Enabled = false;
            cboSoNguoi.Enabled = false;
            cboKV.Enabled = false;


            btnThem.Enabled = true;
            btnLuu.Enabled = false;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
        }
        public void setnull()
        {
            txtMa.Text = "";
            txtTen.Text = "";
            txtGia.Text = "";
            cboSoNguoi.SelectedIndex = -1;
            cboKV.SelectedIndex = -1;
        }
        public string MaTuTang()
        {
            string kq = "";
            if (PhongTroDAO.Instance.LayMaPhong() == "")
            {
                kq = "PHONG00001";
            }
            else
            {
                int so = int.Parse(PhongTroDAO.Instance.LayMaPhong().Remove(0, 5));

                so = so + 1;
                if (so < 10)
                {
                    kq = "PHONG" + "0000";
                }
                else if (so < 100)
                {
                    kq = "PHONG" + "000";
                }
                else if (so < 1000)
                {
                    kq = "PHONG" + "00";
                }
                else if (so < 10000)
                {
                    kq = "PHONG" + "0";
                }
                else
                {
                    kq = "PHONG";
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
                    PhongTroDAO.Instance.Xoa(txtMa.Text);
                    MessageBox.Show("Đã Xóa Thành Công", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dgvPhong.DataSource = PhongTroDAO.Instance.loadPhongTroListAll();
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
                    if (txtGia.Text != "")
                    {
                        if (cboSoNguoi.Text != "")
                        {
                            if (cboKV.Text != "")
                            {
                                if (themmoi == true)
                                {
                                    try
                                    {
                                        PhongTroDAO.Instance.Them(txtMa.Text, txtTen.Text, double.Parse(txtGia.Text), int.Parse(cboSoNguoi.Text), cboKV.SelectedValue.ToString());

                                        locktext();
                                        dgvPhong.DataSource = PhongTroDAO.Instance.loadPhongTroListAll();
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
                                        PhongTroDAO.Instance.Sua(txtMa.Text, txtTen.Text, double.Parse(txtGia.Text), int.Parse(cboSoNguoi.Text), cboKV.SelectedValue.ToString());

                                        MessageBox.Show("Đã Sửa Thành Công Thành Công", "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                    catch (Exception ex)
                                    {
                                        MessageBox.Show(ex.ToString(), "Chú Ý", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    }
                                txtMa.Enabled = true;
                                locktext();
                                dgvPhong.DataSource = PhongTroDAO.Instance.loadPhongTroListAll();

                            }
                            else
                            {
                                MessageBox.Show("Khu vực Không được để trống", "Chú Ý", MessageBoxButtons.OK);
                                cboKV.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Số người ở Không được để trống", "Chú Ý", MessageBoxButtons.OK);
                            cboSoNguoi.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Giá phòng Không được để trống", "Chú Ý", MessageBoxButtons.OK);
                        txtGia.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Tên phòng Không được để trống", "Chú Ý", MessageBoxButtons.OK);
                    txtTen.Focus();
                }
            }
            else
            {
                MessageBox.Show("Mã Không được để trống", "Chú Ý", MessageBoxButtons.OK);
                txtMa.Focus();
            }
        }

        private void dgvPhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int dong = e.RowIndex;
                txtMa.Text = dgvPhong.Rows[dong].Cells[0].Value.ToString();
                txtTen.Text = dgvPhong.Rows[dong].Cells[1].Value.ToString();
                txtGia.Text = dgvPhong.Rows[dong].Cells[2].Value.ToString();
                cboSoNguoi.Text = dgvPhong.Rows[dong].Cells[3].Value.ToString();
                cboKV.SelectedValue = dgvPhong.Rows[dong].Cells[5].Value.ToString();


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
                    dgvPhong.DataSource = PhongTroDAO.Instance.TimKiem(txtTimKiem.Text);
                }
                else
                {
                    dgvPhong.DataSource = PhongTroDAO.Instance.loadPhongTroListAll();
                }
            }
            catch
            {
                return;
            }
        }
    }
}
