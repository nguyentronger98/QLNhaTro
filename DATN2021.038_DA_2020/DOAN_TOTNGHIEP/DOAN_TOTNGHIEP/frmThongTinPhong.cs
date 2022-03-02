using DOAN_TOTNGHIEP.DAO;
using DOAN_TOTNGHIEP.DTO;
using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOAN_TOTNGHIEP
{
    public partial class frmThongTinPhong : Form
    {
        string maphong, tenphong, mahd;
        public frmThongTinPhong(string maphong, string tenphong)
        {
            this.maphong = maphong;
            this.tenphong = tenphong;
            InitializeComponent();
        }

        private void frmThongTinPhong_Load(object sender, EventArgs e)
        {
            this.Text = "THÔNG TIN PHÒNG " + tenphong;
            mahd = HopDongDAO.Instance.loadHopList().FirstOrDefault(t => t.MAPHONG == maphong).MAHD;
            loadNguoiO();
            //loadDichVu();
            dgvTB.DataSource = ChiTietPhongDAO.Instance.loadDSCTPhong().Where(t => t.MAPHONG == maphong).ToList();
        }
        public void loadDichVu()
        {
            dgvDV.DataSource = DichVu_PhongDAO.Instance.loadDVTheoPhong(maphong);
        }
        public void loadNguoiO()
        {
            dgvKhachTro.DataSource = KhachTroDAO.Instance.DSKhachTro().Where(t => t.MAHD == mahd && t.TINHTRANG == true).ToList();
            //pnlNguoi.Controls.Clear();
            //List<KhachTro> lst = KhachTroDAO.Instance.DSKhachTro().Where(t => t.MAHD == mahd && t.TINHTRANG == true).ToList();
            //foreach (KhachTro item in lst)
            //{
            //    UserControl UC = new UserControl();
            //    IconPictureBox iconHinh = new IconPictureBox();
            //    Label lblTen = new Label();
            //    Label lblNgaySinh = new Label();
            //    Label lblGT = new Label();
            //    Label lblNoiSinh = new Label();
            //    IconButton btnCT = new IconButton();

            //    this.SuspendLayout();
            //    // 
            //    // iconHinh
            //    // 
            //    iconHinh.BackColor = System.Drawing.SystemColors.Control;
            //    string hinh = item.HINHTHE;
            //    if (hinh != "")
            //    {
            //        iconHinh.BackgroundImage = Image.FromFile(@"D:\DOANTOTNGHIEP\DOANTOTNGHIEP_WEB\DOANTOTNGHIEP\Hinh\" + item.HINHTHE);
            //    }
            //    iconHinh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            //    iconHinh.ForeColor = System.Drawing.SystemColors.ControlText;
            //    iconHinh.IconColor = System.Drawing.SystemColors.ControlText;
            //    iconHinh.IconSize = 186;
            //    iconHinh.Location = new System.Drawing.Point(21, 0);
            //    iconHinh.Name = "iconHinh";
            //    iconHinh.Size = new System.Drawing.Size(191, 178);
            //    iconHinh.TabIndex = 0;
            //    iconHinh.TabStop = false;
            //    // 
            //    // lblTen
            //    // 
            //    lblTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //    lblTen.Location = new System.Drawing.Point(3, 189);
            //    lblTen.Name = "lblTen";
            //    lblTen.Size = new System.Drawing.Size(229, 29);
            //    lblTen.ForeColor = Color.Black;
            //    lblTen.TabIndex = 1;
            //    lblTen.Text = item.HOTEN;
            //    lblTen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //    // 
            //    // lblNgaySinh
            //    // 
            //    lblNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //    lblNgaySinh.Location = new System.Drawing.Point(67, 218);
            //    lblNgaySinh.Name = "lblNgaySinh";
            //    lblNgaySinh.Size = new System.Drawing.Size(100, 23);
            //    lblNgaySinh.ForeColor =  Color.Black;
            //    lblNgaySinh.TabIndex = 2;
            //    lblNgaySinh.Text = item.NGAYSINH;
            //    lblNgaySinh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //    // 
            //    // lblGT
            //    // 
            //    lblGT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //    lblGT.Location = new System.Drawing.Point(67, 241);
            //    lblGT.Name = "lblGT";
            //    lblGT.Size = new System.Drawing.Size(100, 23);
            //    lblGT.ForeColor = Color.Black;
            //    lblGT.TabIndex = 3;
            //    lblGT.Text = item.GIOITINH;
            //    lblGT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //    // 
            //    // lblNoiSinh
            //    // 
            //    lblNoiSinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //    lblNoiSinh.Location = new System.Drawing.Point(67, 264);
            //    lblNoiSinh.Name = "lblNoiSinh";
            //    lblNoiSinh.Size = new System.Drawing.Size(100, 23);
            //    lblNoiSinh.ForeColor = Color.Black;
            //    lblNoiSinh.TabIndex = 4;
            //    lblNoiSinh.Text = item.NOISINH;
            //    lblNoiSinh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //    // 
            //    // iconButton1
            //    // 
            //    btnCT.BackColor = System.Drawing.Color.RoyalBlue;
            //    btnCT.FlatAppearance.BorderSize = 0;
            //    btnCT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            //    btnCT.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            //    btnCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            //    btnCT.ForeColor = System.Drawing.Color.White;
            //    btnCT.IconColor = System.Drawing.Color.White;
            //    btnCT.IconSize = 20;
            //    btnCT.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            //    btnCT.Location = new System.Drawing.Point(69, 290);
            //    btnCT.Name = "iconButton1";
            //    btnCT.Rotation = 0D;
            //    btnCT.Size = new System.Drawing.Size(98, 45);
            //    btnCT.TabIndex = 5;
            //    btnCT.Text = "Chi tiết";
            //    btnCT.UseVisualStyleBackColor = false;
            //    // 
            //    // UCNguoi
            //    // 
            //    btnCT.Tag = item;
            //    AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            //    AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            //    UC.BackColor = System.Drawing.Color.White;
            //    UC.Controls.Add(btnCT);
            //    UC.Controls.Add(lblNoiSinh);
            //    UC.Controls.Add(lblGT);
            //    UC.Controls.Add(lblNgaySinh);
            //    UC.Controls.Add(lblTen);
            //    UC.Controls.Add(iconHinh);
            //    UC.Size = new System.Drawing.Size(236, 343);
            //    ((System.ComponentModel.ISupportInitialize)(iconHinh)).EndInit();
            //    UC.ResumeLayout(false);
            //    pnlNguoi.Controls.Add(UC);
            //    btnCT.Click += btnCT_Click;

            //}
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            frmReportKhaiBaoNhanKhau frm = new frmReportKhaiBaoNhanKhau(mahd);
            frm.ShowDialog();
        }

        private void dgvKhach_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvKhachTro_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                string makhach = dgvKhachTro.Rows[e.RowIndex].Cells["MA"].Value.ToString();
                frmChiTietKhachTro frm = new frmChiTietKhachTro(makhach,tenphong);
                frm.ShowDialog();
                loadNguoiO();
            }
            catch
            { }
        }
    }
}
