namespace DOAN_TOTNGHIEP
{
    partial class frmReportDatCoc
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
            this.dATCOCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dATCOCTableAdapter1 = new DOAN_TOTNGHIEP.ql_nhatroDataSetTableAdapters.DATCOCTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ql_nhatroDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dATCOCBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.dATCOCBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DOAN_TOTNGHIEP.ReportDatCoc.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(595, 477);
            this.reportViewer1.TabIndex = 0;
            // 
            // ql_nhatroDataSet
            // 
            this.ql_nhatroDataSet.DataSetName = "ql_nhatroDataSet";
            this.ql_nhatroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dATCOCBindingSource
            // 
            this.dATCOCBindingSource.DataMember = "DATCOC";
            this.dATCOCBindingSource.DataSource = this.ql_nhatroDataSet;
            // 
            // dATCOCTableAdapter1
            // 
            this.dATCOCTableAdapter1.ClearBeforeFill = true;
            // 
            // frmReportDatCoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 477);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReportDatCoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report Đặt cọc";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmReportDatCoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ql_nhatroDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dATCOCBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dATCOCBindingSource;
        private ql_nhatroDataSet ql_nhatroDataSet;
        private ql_nhatroDataSetTableAdapters.DATCOCTableAdapter dATCOCTableAdapter1;
    }
}