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
    public partial class frmReportCamKet : Form
    {
        string mahd;
        public frmReportCamKet(string mahd)
        {
            this.mahd = mahd;
            InitializeComponent();
        }

        private void frmReportCamKet_Load(object sender, EventArgs e)
        {
            if (mahd != "")
            {
                this.hOPDONGTableAdapter1.FillBy(this.ql_nhatroDataSet.HOPDONG, mahd);
                // TODO: This line of code loads data into the 'ql_nhatroDataSet.hopdong' table. You can move, or remove it, as needed.
                this.reportViewer1.RefreshReport();
                this.reportViewer1.RefreshReport();
                this.reportViewer1.RefreshReport();
                this.reportViewer1.RefreshReport();
            }
            else
            {
                // TODO: This line of code loads data into the 'ql_nhatroDataSet.HOPDONG' table. You can move, or remove it, as needed.
                this.hOPDONGTableAdapter1.Fill(this.ql_nhatroDataSet.HOPDONG);
                // TODO: This line of code loads data into the 'ql_nhatroDataSet.hopdong' table. You can move, or remove it, as needed.
                this.reportViewer1.RefreshReport();
                this.reportViewer1.RefreshReport();
                this.reportViewer1.RefreshReport();
                this.reportViewer1.RefreshReport();
            }
        }
    }
}
