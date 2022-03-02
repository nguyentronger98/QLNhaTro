namespace DOAN_TOTNGHIEP
{
    partial class frmDSHopDongSapHetHan
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvHD = new System.Windows.Forms.DataGridView();
            this.MAHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HOTENNT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYSINHNT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOIDKHK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMNDNT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYCAPCMNDNT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOICAPCMNDNT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDTNT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIACHITHUE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIATHUE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HINHTHUCTHANHTOAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIENCOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIENDIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIENNUOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYBATDAU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYKETTHUC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SONGUOIO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MATKHAU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TINHTRANG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GHICHU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MACT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAPHONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENPHONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHD)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvHD, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.47541F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.52459F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(785, 445);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(779, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH HỢP ĐỒNG SẮP HẾT HẠN";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvHD
            // 
            this.dgvHD.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvHD.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHD.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MAHD,
            this.NGAYHD,
            this.HOTENNT,
            this.NGAYSINHNT,
            this.NOIDKHK,
            this.CMNDNT,
            this.NGAYCAPCMNDNT,
            this.NOICAPCMNDNT,
            this.SDTNT,
            this.DIACHITHUE,
            this.GIATHUE,
            this.HINHTHUCTHANHTOAN,
            this.TIENCOC,
            this.TIENDIEN,
            this.TIENNUOC,
            this.NGAYBATDAU,
            this.NGAYKETTHUC,
            this.SONGUOIO,
            this.MATKHAU,
            this.TINHTRANG,
            this.GHICHU,
            this.MACT,
            this.MAPHONG,
            this.TENPHONG});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHD.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHD.EnableHeadersVisualStyles = false;
            this.dgvHD.Location = new System.Drawing.Point(3, 54);
            this.dgvHD.Name = "dgvHD";
            this.dgvHD.ReadOnly = true;
            this.dgvHD.Size = new System.Drawing.Size(779, 388);
            this.dgvHD.TabIndex = 1;
            this.dgvHD.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHD_CellContentClick);
            // 
            // MAHD
            // 
            this.MAHD.DataPropertyName = "MAHD";
            this.MAHD.HeaderText = "Mã HD";
            this.MAHD.Name = "MAHD";
            this.MAHD.ReadOnly = true;
            // 
            // NGAYHD
            // 
            this.NGAYHD.DataPropertyName = "NGAYHD";
            this.NGAYHD.HeaderText = "Ngày HD";
            this.NGAYHD.Name = "NGAYHD";
            this.NGAYHD.ReadOnly = true;
            // 
            // HOTENNT
            // 
            this.HOTENNT.DataPropertyName = "HOTENNT";
            this.HOTENNT.HeaderText = "Họ tên";
            this.HOTENNT.Name = "HOTENNT";
            this.HOTENNT.ReadOnly = true;
            // 
            // NGAYSINHNT
            // 
            this.NGAYSINHNT.DataPropertyName = "NGAYSINHNT";
            this.NGAYSINHNT.HeaderText = "Ngày sinh";
            this.NGAYSINHNT.Name = "NGAYSINHNT";
            this.NGAYSINHNT.ReadOnly = true;
            // 
            // NOIDKHK
            // 
            this.NOIDKHK.DataPropertyName = "NOIDKHK";
            this.NOIDKHK.HeaderText = "Nơi DKHK";
            this.NOIDKHK.Name = "NOIDKHK";
            this.NOIDKHK.ReadOnly = true;
            // 
            // CMNDNT
            // 
            this.CMNDNT.DataPropertyName = "CMNDNT";
            this.CMNDNT.HeaderText = "CMND";
            this.CMNDNT.Name = "CMNDNT";
            this.CMNDNT.ReadOnly = true;
            // 
            // NGAYCAPCMNDNT
            // 
            this.NGAYCAPCMNDNT.DataPropertyName = "NGAYCAPCMNDNT";
            this.NGAYCAPCMNDNT.HeaderText = "Ngày cấp CMND";
            this.NGAYCAPCMNDNT.Name = "NGAYCAPCMNDNT";
            this.NGAYCAPCMNDNT.ReadOnly = true;
            this.NGAYCAPCMNDNT.Visible = false;
            // 
            // NOICAPCMNDNT
            // 
            this.NOICAPCMNDNT.DataPropertyName = "NOICAPCMNDNT";
            this.NOICAPCMNDNT.HeaderText = "Nơi cấp CMND";
            this.NOICAPCMNDNT.Name = "NOICAPCMNDNT";
            this.NOICAPCMNDNT.ReadOnly = true;
            this.NOICAPCMNDNT.Visible = false;
            // 
            // SDTNT
            // 
            this.SDTNT.DataPropertyName = "SDTNT";
            this.SDTNT.HeaderText = "SĐT";
            this.SDTNT.Name = "SDTNT";
            this.SDTNT.ReadOnly = true;
            // 
            // DIACHITHUE
            // 
            this.DIACHITHUE.DataPropertyName = "DIACHITHUE";
            this.DIACHITHUE.HeaderText = "Địa chỉ thuê";
            this.DIACHITHUE.Name = "DIACHITHUE";
            this.DIACHITHUE.ReadOnly = true;
            // 
            // GIATHUE
            // 
            this.GIATHUE.DataPropertyName = "GIATHUE";
            this.GIATHUE.HeaderText = "Giá thuê";
            this.GIATHUE.Name = "GIATHUE";
            this.GIATHUE.ReadOnly = true;
            // 
            // HINHTHUCTHANHTOAN
            // 
            this.HINHTHUCTHANHTOAN.DataPropertyName = "HINHTHUCTHANHTOAN";
            this.HINHTHUCTHANHTOAN.HeaderText = "Hình thức TT";
            this.HINHTHUCTHANHTOAN.Name = "HINHTHUCTHANHTOAN";
            this.HINHTHUCTHANHTOAN.ReadOnly = true;
            // 
            // TIENCOC
            // 
            this.TIENCOC.DataPropertyName = "TIENCOC";
            this.TIENCOC.HeaderText = "Tiền cọc";
            this.TIENCOC.Name = "TIENCOC";
            this.TIENCOC.ReadOnly = true;
            // 
            // TIENDIEN
            // 
            this.TIENDIEN.DataPropertyName = "TIENDIEN";
            this.TIENDIEN.HeaderText = "Tiền điện";
            this.TIENDIEN.Name = "TIENDIEN";
            this.TIENDIEN.ReadOnly = true;
            this.TIENDIEN.Visible = false;
            // 
            // TIENNUOC
            // 
            this.TIENNUOC.DataPropertyName = "TIENNUOC";
            this.TIENNUOC.HeaderText = "Tiền nước";
            this.TIENNUOC.Name = "TIENNUOC";
            this.TIENNUOC.ReadOnly = true;
            this.TIENNUOC.Visible = false;
            // 
            // NGAYBATDAU
            // 
            this.NGAYBATDAU.DataPropertyName = "NGAYBATDAU";
            this.NGAYBATDAU.HeaderText = "Ngày bắt đầu";
            this.NGAYBATDAU.Name = "NGAYBATDAU";
            this.NGAYBATDAU.ReadOnly = true;
            // 
            // NGAYKETTHUC
            // 
            this.NGAYKETTHUC.DataPropertyName = "NGAYKETTHUC";
            this.NGAYKETTHUC.HeaderText = "Ngày kết thúc";
            this.NGAYKETTHUC.Name = "NGAYKETTHUC";
            this.NGAYKETTHUC.ReadOnly = true;
            // 
            // SONGUOIO
            // 
            this.SONGUOIO.DataPropertyName = "SONGUOIO";
            this.SONGUOIO.HeaderText = "Số người ở";
            this.SONGUOIO.Name = "SONGUOIO";
            this.SONGUOIO.ReadOnly = true;
            // 
            // MATKHAU
            // 
            this.MATKHAU.DataPropertyName = "MATKHAU";
            this.MATKHAU.HeaderText = "Mật khẩu";
            this.MATKHAU.Name = "MATKHAU";
            this.MATKHAU.ReadOnly = true;
            this.MATKHAU.Visible = false;
            // 
            // TINHTRANG
            // 
            this.TINHTRANG.DataPropertyName = "TINHTRANG";
            this.TINHTRANG.HeaderText = "Tình trạng";
            this.TINHTRANG.Name = "TINHTRANG";
            this.TINHTRANG.ReadOnly = true;
            // 
            // GHICHU
            // 
            this.GHICHU.DataPropertyName = "GHICHU";
            this.GHICHU.HeaderText = "Ghi chú";
            this.GHICHU.Name = "GHICHU";
            this.GHICHU.ReadOnly = true;
            this.GHICHU.Visible = false;
            // 
            // MACT
            // 
            this.MACT.DataPropertyName = "MACT";
            this.MACT.HeaderText = "Mã CT";
            this.MACT.Name = "MACT";
            this.MACT.ReadOnly = true;
            this.MACT.Visible = false;
            // 
            // MAPHONG
            // 
            this.MAPHONG.DataPropertyName = "MAPHONG";
            this.MAPHONG.HeaderText = "Mã phòng";
            this.MAPHONG.Name = "MAPHONG";
            this.MAPHONG.ReadOnly = true;
            // 
            // TENPHONG
            // 
            this.TENPHONG.DataPropertyName = "TENPHONG";
            this.TENPHONG.HeaderText = "Tên phòng";
            this.TENPHONG.Name = "TENPHONG";
            this.TENPHONG.ReadOnly = true;
            // 
            // frmDSHopDongSapHetHan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 445);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmDSHopDongSapHetHan";
            this.Text = "DANH SÁCH HỢP ĐỒNG SẮP HẾT HẠN";
            this.Load += new System.EventHandler(this.frmDSHopDongSapHetHan_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOTENNT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYSINHNT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOIDKHK;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMNDNT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYCAPCMNDNT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOICAPCMNDNT;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDTNT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIACHITHUE;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIATHUE;
        private System.Windows.Forms.DataGridViewTextBoxColumn HINHTHUCTHANHTOAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIENCOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIENDIEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIENNUOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYBATDAU;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYKETTHUC;
        private System.Windows.Forms.DataGridViewTextBoxColumn SONGUOIO;
        private System.Windows.Forms.DataGridViewTextBoxColumn MATKHAU;
        private System.Windows.Forms.DataGridViewTextBoxColumn TINHTRANG;
        private System.Windows.Forms.DataGridViewTextBoxColumn GHICHU;
        private System.Windows.Forms.DataGridViewTextBoxColumn MACT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAPHONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENPHONG;
    }
}