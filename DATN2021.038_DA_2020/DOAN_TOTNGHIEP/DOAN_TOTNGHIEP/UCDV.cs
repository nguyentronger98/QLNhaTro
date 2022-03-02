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
    public partial class UCDV : UserControl
    {
        public UCDV()
        {
            InitializeComponent();
        }
        #region Properties
        private string _TENDV;

        public string TENDV
        {
            get { return _TENDV; }
            set { _TENDV = value; lblTenDV.Text = value; }
        }
        private string _GIADV;

        public string GIADV
        {
            get { return _GIADV; }
            set { _GIADV = value; lblGiaDV.Text = value; }
        }
        private Color _Mau;

        public Color Mau
        {
            get { return _Mau; }
            set { _Mau = value; pnlMau.BackColor = value; lblTenDV.ForeColor = value; }
        }
        #endregion
    }
}
