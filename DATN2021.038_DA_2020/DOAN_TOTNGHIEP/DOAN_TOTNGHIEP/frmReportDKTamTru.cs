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
    public partial class frmReportDKTamTru : Form
    {
        public frmReportDKTamTru()
        {
            InitializeComponent();
        }

        private void frmReportDKTamTru_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ql_nhatroDataSet.KHACHTRO' table. You can move, or remove it, as needed.
            this.kHACHTROTableAdapter.Fill(this.ql_nhatroDataSet.KHACHTRO);
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
