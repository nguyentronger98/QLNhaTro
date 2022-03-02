namespace DOAN_TOTNGHIEP
{
    partial class frmDSHopDongDaKetThuc
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ql_nhatroDataSet1 = new DOAN_TOTNGHIEP.ql_nhatroDataSet();
            this.dgvHD = new System.Windows.Forms.DataGridView();
            this.MAHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HOTENNT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYSINHNT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOIDKHK1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMNDNT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYCAPCMNDNT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOICAPCMNDNT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SDTNT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIACHITHUE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENPHONG1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ql_nhatroDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHD)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.952286F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.04771F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1083, 524);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1077, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH HỢP ĐỒNG ĐÃ KẾT THÚC";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvHD);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1077, 457);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách hợp đồng đã kết thúc";
            // 
            // ql_nhatroDataSet1
            // 
            this.ql_nhatroDataSet1.DataSetName = "ql_nhatroDataSet";
            this.ql_nhatroDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dgvHD
            // 
            this.dgvHD.AllowUserToAddRows = false;
            this.dgvHD.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvHD.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHD.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvHD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.NOIDKHK1,
            this.CMNDNT,
            this.NGAYCAPCMNDNT,
            this.NOICAPCMNDNT,
            this.SDTNT,
            this.DIACHITHUE,
            this.TENPHONG1,
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
            this.MAPHONG});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvHD.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvHD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHD.EnableHeadersVisualStyles = false;
            this.dgvHD.Location = new System.Drawing.Point(3, 22);
            this.dgvHD.Name = "dgvHD";
            this.dgvHD.ReadOnly = true;
            this.dgvHD.Size = new System.Drawing.Size(1071, 432);
            this.dgvHD.TabIndex = 5;
            // 
            // MAHD
            // 
            this.MAHD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.MAHD.DataPropertyName = "MAHD";
            this.MAHD.HeaderText = "Mã HD";
            this.MAHD.Name = "MAHD";
            this.MAHD.ReadOnly = true;
            this.MAHD.Width = 89;
            // 
            // NGAYHD
            // 
            this.NGAYHD.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NGAYHD.DataPropertyName = "NGAYHD";
            this.NGAYHD.HeaderText = "Ngày HD";
            this.NGAYHD.Name = "NGAYHD";
            this.NGAYHD.ReadOnly = true;
            this.NGAYHD.Width = 105;
            // 
            // HOTENNT
            // 
            this.HOTENNT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.HOTENNT.DataPropertyName = "HOTENNT";
            this.HOTENNT.HeaderText = "Họ Tên";
            this.HOTENNT.Name = "HOTENNT";
            this.HOTENNT.ReadOnly = true;
            this.HOTENNT.Width = 92;
            // 
            // NGAYSINHNT
            // 
            this.NGAYSINHNT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.NGAYSINHNT.DataPropertyName = "NGAYSINHNT";
            this.NGAYSINHNT.HeaderText = "Ngày sinh";
            this.NGAYSINHNT.Name = "NGAYSINHNT";
            this.NGAYSINHNT.ReadOnly = true;
            this.NGAYSINHNT.Width = 112;
            // 
            // NOIDKHK1
            // 
            this.NOIDKHK1.DataPropertyName = "NOIDKHK";
            this.NOIDKHK1.HeaderText = "Nơi DKHK";
            this.NOIDKHK1.Name = "NOIDKHK1";
            this.NOIDKHK1.ReadOnly = true;
            this.NOIDKHK1.Visible = false;
            // 
            // CMNDNT
            // 
            this.CMNDNT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.CMNDNT.DataPropertyName = "CMNDNT";
            this.CMNDNT.HeaderText = "CMND";
            this.CMNDNT.Name = "CMNDNT";
            this.CMNDNT.ReadOnly = true;
            this.CMNDNT.Width = 85;
            // 
            // NGAYCAPCMNDNT
            // 
            this.NGAYCAPCMNDNT.DataPropertyName = "NGAYCAPCMNDNT";
            this.NGAYCAPCMNDNT.HeaderText = "Ngày Cấp CMND";
            this.NGAYCAPCMNDNT.Name = "NGAYCAPCMNDNT";
            this.NGAYCAPCMNDNT.ReadOnly = true;
            // 
            // NOICAPCMNDNT
            // 
            this.NOICAPCMNDNT.DataPropertyName = "NOICAPCMNDNT";
            this.NOICAPCMNDNT.HeaderText = "Nơi cấp CMND";
            this.NOICAPCMNDNT.Name = "NOICAPCMNDNT";
            this.NOICAPCMNDNT.ReadOnly = true;
            // 
            // SDTNT
            // 
            this.SDTNT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.SDTNT.DataPropertyName = "SDTNT";
            this.SDTNT.HeaderText = "SĐT";
            this.SDTNT.Name = "SDTNT";
            this.SDTNT.ReadOnly = true;
            this.SDTNT.Width = 69;
            // 
            // DIACHITHUE
            // 
            this.DIACHITHUE.DataPropertyName = "DIACHITHUE";
            this.DIACHITHUE.HeaderText = "Địa chỉ thuê";
            this.DIACHITHUE.Name = "DIACHITHUE";
            this.DIACHITHUE.ReadOnly = true;
            // 
            // TENPHONG1
            // 
            this.TENPHONG1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TENPHONG1.DataPropertyName = "TENPHONG";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Red;
            this.TENPHONG1.DefaultCellStyle = dataGridViewCellStyle3;
            this.TENPHONG1.HeaderText = "Phòng";
            this.TENPHONG1.Name = "TENPHONG1";
            this.TENPHONG1.ReadOnly = true;
            this.TENPHONG1.Width = 85;
            // 
            // GIATHUE
            // 
            this.GIATHUE.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.GIATHUE.DataPropertyName = "GIATHUE";
            this.GIATHUE.HeaderText = "Giá Thuê";
            this.GIATHUE.Name = "GIATHUE";
            this.GIATHUE.ReadOnly = true;
            this.GIATHUE.Width = 98;
            // 
            // HINHTHUCTHANHTOAN
            // 
            this.HINHTHUCTHANHTOAN.DataPropertyName = "HINHTHUCTHANHTOAN";
            this.HINHTHUCTHANHTOAN.HeaderText = "Hình thức thanh toán";
            this.HINHTHUCTHANHTOAN.Name = "HINHTHUCTHANHTOAN";
            this.HINHTHUCTHANHTOAN.ReadOnly = true;
            // 
            // TIENCOC
            // 
            this.TIENCOC.DataPropertyName = "TIENCOC";
            this.TIENCOC.HeaderText = "Tiền Cọc";
            this.TIENCOC.Name = "TIENCOC";
            this.TIENCOC.ReadOnly = true;
            // 
            // TIENDIEN
            // 
            this.TIENDIEN.DataPropertyName = "TIENDIEN";
            this.TIENDIEN.HeaderText = "Tiền Điện";
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
            this.NGAYBATDAU.HeaderText = "Ngày BĐ";
            this.NGAYBATDAU.Name = "NGAYBATDAU";
            this.NGAYBATDAU.ReadOnly = true;
            this.NGAYBATDAU.Visible = false;
            // 
            // NGAYKETTHUC
            // 
            this.NGAYKETTHUC.DataPropertyName = "NGAYKETTHUC";
            this.NGAYKETTHUC.HeaderText = "Ngày KT";
            this.NGAYKETTHUC.Name = "NGAYKETTHUC";
            this.NGAYKETTHUC.ReadOnly = true;
            this.NGAYKETTHUC.Visible = false;
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
            this.TINHTRANG.Visible = false;
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
            // frmDSHopDongDaKetThuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 524);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmDSHopDongDaKetThuc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách hợp đồng đã kết thúc";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDSHopDongDaKetThuc_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ql_nhatroDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private ql_nhatroDataSet ql_nhatroDataSet1;
        private System.Windows.Forms.DataGridView dgvHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOTENNT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYSINHNT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOIDKHK1;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMNDNT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYCAPCMNDNT;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOICAPCMNDNT;
        private System.Windows.Forms.DataGridViewTextBoxColumn SDTNT;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIACHITHUE;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENPHONG1;
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
    }
}