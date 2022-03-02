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
    public partial class frmReportThayDoiNhanKhau : Form
    {
        string mahd;
        public frmReportThayDoiNhanKhau(string mahd)
        {
            this.mahd = mahd;
            InitializeComponent();
        }

        private void frmReportThayDoiNhanKhau_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ql_nhatroDataSet.THAYDOINHANKHAU' table. You can move, or remove it, as needed.
            if (mahd == "")
            {
                this.tHAYDOINHANKHAUTableAdapter1.Fill(this.ql_nhatroDataSet.THAYDOINHANKHAU);

                this.reportViewer1.RefreshReport();
                this.reportViewer1.RefreshReport();
            }
            else
            {
                // TODO: This line of code loads data into the 'ql_nhatroDataSet.khaibaonhankhau' table. You can move, or remove it, as needed.
                this.tHAYDOINHANKHAUTableAdapter1.FillBy(this.ql_nhatroDataSet.THAYDOINHANKHAU, mahd);

                this.reportViewer1.RefreshReport();
                this.reportViewer1.RefreshReport();
            }
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
