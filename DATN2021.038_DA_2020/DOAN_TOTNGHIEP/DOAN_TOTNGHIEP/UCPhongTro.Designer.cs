namespace DOAN_TOTNGHIEP
{
    partial class UCPhongTro
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
            this.lblTenPhong = new System.Windows.Forms.Label();
            this.lblSLNguoi = new System.Windows.Forms.Label();
            this.icon = new FontAwesome.Sharp.IconPictureBox();
            this.lbltinhtrang = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTenPhong
            // 
            this.lblTenPhong.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTenPhong.ForeColor = System.Drawing.Color.Black;
            this.lblTenPhong.Location = new System.Drawing.Point(16, 153);
            this.lblTenPhong.Name = "lblTenPhong";
            this.lblTenPhong.Size = new System.Drawing.Size(167, 26);
            this.lblTenPhong.TabIndex = 1;
            this.lblTenPhong.Text = "101";
            this.lblTenPhong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblSLNguoi
            // 
            this.lblSLNguoi.AutoSize = true;
            this.lblSLNguoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSLNguoi.ForeColor = System.Drawing.Color.Black;
            this.lblSLNguoi.Location = new System.Drawing.Point(3, 0);
            this.lblSLNguoi.Name = "lblSLNguoi";
            this.lblSLNguoi.Size = new System.Drawing.Size(0, 16);
            this.lblSLNguoi.TabIndex = 2;
            // 
            // icon
            // 
            this.icon.BackColor = System.Drawing.Color.Transparent;
            this.icon.ForeColor = System.Drawing.Color.Black;
            this.icon.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.icon.IconColor = System.Drawing.Color.Black;
            this.icon.IconSize = 130;
            this.icon.Location = new System.Drawing.Point(21, 20);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(142, 130);
            this.icon.TabIndex = 3;
            this.icon.TabStop = false;
            // 
            // lbltinhtrang
            // 
            this.lbltinhtrang.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltinhtrang.ForeColor = System.Drawing.Color.Black;
            this.lbltinhtrang.Location = new System.Drawing.Point(49, 127);
            this.lbltinhtrang.Name = "lbltinhtrang";
            this.lbltinhtrang.Size = new System.Drawing.Size(113, 23);
            this.lbltinhtrang.TabIndex = 4;
            this.lbltinhtrang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UCPhongTro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lime;
            this.Controls.Add(this.lbltinhtrang);
            this.Controls.Add(this.icon);
            this.Controls.Add(this.lblSLNguoi);
            this.Controls.Add(this.lblTenPhong);
            this.Name = "UCPhongTro";
            this.Size = new System.Drawing.Size(201, 185);
            this.Load += new System.EventHandler(this.UCPhongTro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTenPhong;
        private System.Windows.Forms.Label lblSLNguoi;
        private FontAwesome.Sharp.IconPictureBox icon;
        private System.Windows.Forms.Label lbltinhtrang;
    }
}
