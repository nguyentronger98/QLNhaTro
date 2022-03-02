namespace DOAN_TOTNGHIEP
{
    partial class UCDV
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlMau = new System.Windows.Forms.Panel();
            this.lblTenDV = new System.Windows.Forms.Label();
            this.lblGiaDV = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnlMau
            // 
            this.pnlMau.BackColor = System.Drawing.Color.Blue;
            this.pnlMau.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMau.Location = new System.Drawing.Point(0, 0);
            this.pnlMau.Name = "pnlMau";
            this.pnlMau.Size = new System.Drawing.Size(17, 145);
            this.pnlMau.TabIndex = 0;
            // 
            // lblTenDV
            // 
            this.lblTenDV.AutoSize = true;
            this.lblTenDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenDV.ForeColor = System.Drawing.Color.Blue;
            this.lblTenDV.Location = new System.Drawing.Point(45, 41);
            this.lblTenDV.Name = "lblTenDV";
            this.lblTenDV.Size = new System.Drawing.Size(64, 24);
            this.lblTenDV.TabIndex = 1;
            this.lblTenDV.Text = "ĐIỆN ";
            // 
            // lblGiaDV
            // 
            this.lblGiaDV.AutoSize = true;
            this.lblGiaDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaDV.Location = new System.Drawing.Point(44, 89);
            this.lblGiaDV.Name = "lblGiaDV";
            this.lblGiaDV.Size = new System.Drawing.Size(64, 25);
            this.lblGiaDV.TabIndex = 2;
            this.lblGiaDV.Text = "3500";
            // 
            // UCDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblGiaDV);
            this.Controls.Add(this.lblTenDV);
            this.Controls.Add(this.pnlMau);
            this.Name = "UCDV";
            this.Size = new System.Drawing.Size(263, 145);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMau;
        private System.Windows.Forms.Label lblTenDV;
        private System.Windows.Forms.Label lblGiaDV;
    }
}
