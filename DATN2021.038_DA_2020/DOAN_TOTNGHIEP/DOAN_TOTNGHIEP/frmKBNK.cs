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

namespace DOAN_TOTNGHIEP
{
    public partial class frmKBNK : Form
    {
        public frmKBNK()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void windowsUIButtonPanel1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("dsfgdfg");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
                    }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
                    }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmKBNK_Load(object sender, EventArgs e)
        {
            DataProvider da = new DataProvider();
            string sql = "select * from phong";
            dataGridView2.DataSource = da.ExecuteQuery(sql);
        }
    }
}
