using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOAN_TOTNGHIEP
{
    public partial class UCPhongTro : UserControl
    {
        public UCPhongTro()
        {
            InitializeComponent();
        }
        #region Properties
        private string _tenphong;

        public string Tenphong
        {
            get { return _tenphong; }
            set { _tenphong = value; lblTenPhong.Text = value; }
        }
        private string _SLNguoi;

        public string SLNguoi
        {
            get { return _SLNguoi; }
            set { _SLNguoi = value; lblSLNguoi.Text = value; }
        }
        private string _TINHTRANG;

        public string TINHTRANG
        {
            get { return _TINHTRANG; }
            set { _TINHTRANG = value; lbltinhtrang.Text = value; }
        }
        private Color _color;

        public Color Color
        {
            get { return _color; }
            set { _color = value; lblTenPhong.ForeColor = value ; lblSLNguoi.BackColor = value; lbltinhtrang.BackColor = value; }
        }
        #endregion

        private void UCPhongTro_Load(object sender, EventArgs e)
        {

        }
    }
}
