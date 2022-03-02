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
    public partial class frmReportKhaiBaoNhanKhau : Form
    {
        string mahd;
        public frmReportKhaiBaoNhanKhau(string mahd)
        {
            this.mahd = mahd;
            InitializeComponent();
        }

        private void frmReportKhaiBaoNhanKhau_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ql_nhatroDataSet.KHACHTRO' table. You can move, or remove it, as needed.
            if (mahd == "")
            {
                this.kHACHTROTableAdapter.Fill(this.ql_nhatroDataSet.KHACHTRO);

                this.reportViewer1.RefreshReport();
                this.reportViewer1.RefreshReport();
            }
            else
            {
                // TODO: This line of code loads data into the 'ql_nhatroDataSet.khaibaonhankhau' table. You can move, or remove it, as needed.
                this.kHACHTROTableAdapter.FillBy(this.ql_nhatroDataSet.KHACHTRO, mahd);

                this.reportViewer1.RefreshReport();
                this.reportViewer1.RefreshReport();
            }
            this.reportViewer1.RefreshReport();
        }
    }
}
