namespace DOAN_TOTNGHIEP
{
    partial class frmReportDKTamTru
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ql_nhatroDataSet = new DOAN_TOTNGHIEP.ql_nhatroDataSet();
            this.kHACHTROBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kHACHTROTableAdapter = new DOAN_TOTNGHIEP.ql_nhatroDataSetTableAdapters.KHACHTROTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ql_nhatroDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHTROBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.kHACHTROBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DOAN_TOTNGHIEP.ReportDKTamTru.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(699, 312);
            this.reportViewer1.TabIndex = 0;
            // 
            // ql_nhatroDataSet
            // 
            this.ql_nhatroDataSet.DataSetName = "ql_nhatroDataSet";
            this.ql_nhatroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kHACHTROBindingSource
            // 
            this.kHACHTROBindingSource.DataMember = "KHACHTRO";
            this.kHACHTROBindingSource.DataSource = this.ql_nhatroDataSet;
            // 
            // kHACHTROTableAdapter
            // 
            this.kHACHTROTableAdapter.ClearBeforeFill = true;
            // 
            // frmReportDKTamTru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 312);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReportDKTamTru";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmReportDKTamTru";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmReportDKTamTru_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ql_nhatroDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kHACHTROBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource khaibaonhankhauBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private ql_nhatroDataSet ql_nhatroDataSet;
        private System.Windows.Forms.BindingSource kHACHTROBindingSource;
        private ql_nhatroDataSetTableAdapters.KHACHTROTableAdapter kHACHTROTableAdapter;
    }
}