namespace DOAN_TOTNGHIEP
{
    partial class frmReportCamKet
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
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.hOPDONGTableAdapter1 = new DOAN_TOTNGHIEP.ql_nhatroDataSetTableAdapters.HOPDONGTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ql_nhatroDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.bindingSource1;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "DOAN_TOTNGHIEP.ReportCamKet.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(556, 394);
            this.reportViewer1.TabIndex = 0;
            // 
            // ql_nhatroDataSet
            // 
            this.ql_nhatroDataSet.DataSetName = "ql_nhatroDataSet";
            this.ql_nhatroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataMember = "HOPDONG";
            this.bindingSource1.DataSource = this.ql_nhatroDataSet;
            // 
            // hOPDONGTableAdapter1
            // 
            this.hOPDONGTableAdapter1.ClearBeforeFill = true;
            // 
            // frmReportCamKet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 394);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frmReportCamKet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cam Kết";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmReportCamKet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ql_nhatroDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource hopdongBindingSource;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private ql_nhatroDataSet ql_nhatroDataSet;
        private System.Windows.Forms.BindingSource bindingSource1;
        private ql_nhatroDataSetTableAdapters.HOPDONGTableAdapter hOPDONGTableAdapter1;


    }
}