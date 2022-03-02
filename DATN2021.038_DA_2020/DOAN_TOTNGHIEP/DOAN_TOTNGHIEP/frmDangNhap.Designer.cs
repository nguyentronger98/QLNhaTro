namespace DOAN_TOTNGHIEP
{
    partial class frmDangNhap
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
            this.txtpass = new System.Windows.Forms.TextBox();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.btnDN = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconpass = new FontAwesome.Sharp.IconPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconuser = new FontAwesome.Sharp.IconPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconpass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconuser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtpass
            // 
            this.txtpass.BackColor = System.Drawing.SystemColors.Control;
            this.txtpass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpass.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtpass.Location = new System.Drawing.Point(93, 253);
            this.txtpass.Multiline = true;
            this.txtpass.Name = "txtpass";
            this.txtpass.PasswordChar = '*';
            this.txtpass.Size = new System.Drawing.Size(276, 29);
            this.txtpass.TabIndex = 17;
            this.txtpass.Text = "admin";
            this.txtpass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtuser
            // 
            this.txtuser.BackColor = System.Drawing.SystemColors.Control;
            this.txtuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtuser.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.txtuser.Location = new System.Drawing.Point(93, 194);
            this.txtuser.Multiline = true;
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(276, 29);
            this.txtuser.TabIndex = 16;
            this.txtuser.Text = "admin";
            this.txtuser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnDN
            // 
            this.btnDN.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDN.FlatAppearance.BorderSize = 0;
            this.btnDN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDN.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDN.ForeColor = System.Drawing.Color.White;
            this.btnDN.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnDN.IconColor = System.Drawing.Color.Black;
            this.btnDN.IconSize = 16;
            this.btnDN.Location = new System.Drawing.Point(71, 323);
            this.btnDN.Name = "btnDN";
            this.btnDN.Rotation = 0D;
            this.btnDN.Size = new System.Drawing.Size(286, 53);
            this.btnDN.TabIndex = 15;
            this.btnDN.Text = "Đăng Nhập";
            this.btnDN.UseVisualStyleBackColor = false;
            this.btnDN.Click += new System.EventHandler(this.btnDN_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel2.Location = new System.Drawing.Point(54, 284);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(315, 1);
            this.panel2.TabIndex = 14;
            // 
            // iconpass
            // 
            this.iconpass.BackColor = System.Drawing.SystemColors.Control;
            this.iconpass.ForeColor = System.Drawing.SystemColors.Highlight;
            this.iconpass.IconChar = FontAwesome.Sharp.IconChar.Unlock;
            this.iconpass.IconColor = System.Drawing.SystemColors.Highlight;
            this.iconpass.Location = new System.Drawing.Point(54, 250);
            this.iconpass.Name = "iconpass";
            this.iconpass.Size = new System.Drawing.Size(32, 32);
            this.iconpass.TabIndex = 13;
            this.iconpass.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Location = new System.Drawing.Point(54, 225);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(315, 1);
            this.panel1.TabIndex = 12;
            // 
            // iconuser
            // 
            this.iconuser.BackColor = System.Drawing.SystemColors.Control;
            this.iconuser.ForeColor = System.Drawing.SystemColors.Highlight;
            this.iconuser.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconuser.IconColor = System.Drawing.SystemColors.Highlight;
            this.iconuser.Location = new System.Drawing.Point(55, 191);
            this.iconuser.Name = "iconuser";
            this.iconuser.Size = new System.Drawing.Size(32, 32);
            this.iconuser.TabIndex = 11;
            this.iconuser.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(110, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 37);
            this.label1.TabIndex = 10;
            this.label1.Text = "ĐĂNG NHẬP";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Key;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.MenuHighlight;
            this.iconPictureBox1.IconSize = 94;
            this.iconPictureBox1.Location = new System.Drawing.Point(167, 27);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(102, 94);
            this.iconPictureBox1.TabIndex = 9;
            this.iconPictureBox1.TabStop = false;
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 403);
            this.Controls.Add(this.txtpass);
            this.Controls.Add(this.txtuser);
            this.Controls.Add(this.btnDN);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.iconpass);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.iconuser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iconPictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng nhập";
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconpass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconuser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtpass;
        private System.Windows.Forms.TextBox txtuser;
        private FontAwesome.Sharp.IconButton btnDN;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconPictureBox iconpass;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconuser;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}