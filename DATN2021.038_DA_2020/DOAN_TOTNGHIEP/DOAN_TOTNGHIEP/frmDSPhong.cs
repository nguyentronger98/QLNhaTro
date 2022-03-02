using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DOAN_TOTNGHIEP.DAO;
using DOAN_TOTNGHIEP.DTO;

namespace DOAN_TOTNGHIEP
{
    public partial class frmDSPhong : Form
    {
        string ma;
        string tenkv, mact;
        string maphong, tenphong;
        public frmDSPhong(string ma, string tenkv,string mact)
        {
            this.ma = ma;
            this.tenkv = tenkv;
            this.mact = mact;
            InitializeComponent();
        }

        private void frmDSPhong_Load(object sender, EventArgs e)
        {
            this.Text = "DANH SÁCH PHÒNG " + tenkv;
            LoadPhongTro();
        }
        public void LoadPhongTro()
        {
            pnldsphong.Controls.Clear();
            List<PhongTro> lstphong = PhongTroDAO.Instance.loadPhongTroList(ma);
            foreach (PhongTro item in lstphong)
            {
                UCPhongTro pt = new UCPhongTro();
                pt.Tenphong = "Phòng " + item.TENPHONG;
                string mahd = "";
                try
                {
                    mahd = HopDongDAO.Instance.loadHopList().FirstOrDefault(t => t.MAPHONG == item.MAPHONG).MAHD;
                }
                catch
                { }
                int sl = KhachTroDAO.Instance.DSKhachTro().Where(t => t.MAHD == mahd && t.TINHTRANG==true).ToList().Count;
                if (sl <= 0)
                {
                    pt.SLNguoi = "";
                }
                else
                {
                    pt.SLNguoi = "Số người ở: "+ sl.ToString();
                }
                pt.TINHTRANG = item.TINHTRANG;
                pt.Tag = item;
                pnldsphong.Controls.Add(pt);
                if (item.TINHTRANG == "có người")
                {
                    pt.BackColor = Color.Red;
                }
                else if (item.TINHTRANG == "đã đặt cọc")
                {
                    //int s = DatCocDAO.Instance.loadDatCoc().Where(t=>t.MAPHONG == item.MAPHONG).ToList().Count;
                    //if (s > 0)
                    //{
                    pt.BackColor = Color.Yellow;

                }
                else
                {
                    pt.BackColor = Color.Green;
                }
                pt.Click += pt_Click;
                pt.MouseClick += new MouseEventHandler(pt_MouseClick);
            }
        }

        void pt_MouseClick(object sender, MouseEventArgs e)
        {
            string tt = ((sender as UCPhongTro).Tag as PhongTro).TINHTRANG;
            maphong = ((sender as UCPhongTro).Tag as PhongTro).MAPHONG;
            tenphong = ((sender as UCPhongTro).Tag as PhongTro).TENPHONG;
            UCPhongTro pt = sender as UCPhongTro;
            ContextMenuStrip menu = new System.Windows.Forms.ContextMenuStrip();
            if (e.Button == MouseButtons.Left)
            {
                if (tt == "trống"||tt=="đã đặt cọc")
                {
                    menu.Items.Add("Lập hợp đồng").Name = "laphopdong";
                }
                else
                {
                    frmThongTinPhong frm = new frmThongTinPhong(maphong, tenphong);
                    frm.ShowDialog();
                }
            }
            else
            {
            }
            menu.Show(pt, new Point(e.X, e.Y));
            menu.ItemClicked += new ToolStripItemClickedEventHandler(menu_ItemClicked);
        }

        private void menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            switch (e.ClickedItem.Name.ToString())
            {
                case "laphopdong":
                    frmLapHopDongThuePhong frm = new frmLapHopDongThuePhong(maphong,tenphong,mact);
                    frm.ShowDialog();
                    LoadPhongTro();
                    break;
            }
        }

        void pt_Click(object sender, EventArgs e)
        {
            string MaNuoc = ((sender as UCPhongTro).Tag as PhongTro).MAPHONG;
        }
    }
}
