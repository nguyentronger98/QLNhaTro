namespace DOAN_TOTNGHIEP
{
    partial class UCNguoi
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
            this.iconHinh = new FontAwesome.Sharp.IconPictureBox();
            this.lblTen = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblGT = new System.Windows.Forms.Label();
            this.lblNoiSinh = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.iconHinh)).BeginInit();
            this.SuspendLayout();
            // 
            // iconHinh
            // 
            this.iconHinh.BackColor = System.Drawing.Color.Khaki;
            this.iconHinh.BackgroundImage = global::DOAN_TOTNGHIEP.Properties.Resources.agreement_32px;
            this.iconHinh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.iconHinh.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconHinh.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconHinh.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconHinh.IconSize = 186;
            this.iconHinh.Location = new System.Drawing.Point(21, 0);
            this.iconHinh.Name = "iconHinh";
            this.iconHinh.Size = new System.Drawing.Size(191, 186);
            this.iconHinh.TabIndex = 0;
            this.iconHinh.TabStop = false;
            // 
            // lblTen
            // 
            this.lblTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTen.Location = new System.Drawing.Point(3, 189);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(229, 29);
            this.lblTen.TabIndex = 1;
            this.lblTen.Text = "HUỲNH NGỌC TRÍ";
            this.lblTen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgaySinh.Location = new System.Drawing.Point(67, 218);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(100, 23);
            this.lblNgaySinh.TabIndex = 2;
            this.lblNgaySinh.Text = "07/03/1999";
            this.lblNgaySinh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblGT
            // 
            this.lblGT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGT.Location = new System.Drawing.Point(67, 241);
            this.lblGT.Name = "lblGT";
            this.lblGT.Size = new System.Drawing.Size(100, 23);
            this.lblGT.TabIndex = 3;
            this.lblGT.Text = "Nam";
            this.lblGT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblNoiSinh
            // 
            this.lblNoiSinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNoiSinh.Location = new System.Drawing.Point(67, 264);
            this.lblNoiSinh.Name = "lblNoiSinh";
            this.lblNoiSinh.Size = new System.Drawing.Size(100, 23);
            this.lblNoiSinh.TabIndex = 4;
            this.lblNoiSinh.Text = "Tây Ninh";
            this.lblNoiSinh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UCNguoi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblNoiSinh);
            this.Controls.Add(this.lblGT);
            this.Controls.Add(this.lblNgaySinh);
            this.Controls.Add(this.lblTen);
            this.Controls.Add(this.iconHinh);
            this.Name = "UCNguoi";
            this.Size = new System.Drawing.Size(236, 343);
            ((System.ComponentModel.ISupportInitialize)(this.iconHinh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox iconHinh;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblGT;
        private System.Windows.Forms.Label lblNoiSinh;
    }
}
