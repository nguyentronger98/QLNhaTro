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
    public partial class frmReportDatCoc : Form
    {
        string macoc;
        public frmReportDatCoc(string macoc)
        {
            this.macoc = macoc;
            InitializeComponent();
        }

        private void frmReportDatCoc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'ql_nhatroDataSet.datcoc' table. You can move, or remove it, as needed.
            this.dATCOCTableAdapter1.Fill(this.ql_nhatroDataSet.DATCOC,macoc);

            this.reportViewer1.RefreshReport();
        }
    }
}
