namespace DOAN_TOTNGHIEP
{
    partial class frmDSKhachDaRoiTro
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
            this.groupDSKhach = new System.Windows.Forms.GroupBox();
            this.dgvKhachTro = new System.Windows.Forms.DataGridView();
            this.MA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HOTEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAYSINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIOITINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOISINH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGUYENQUAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DANTOC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TONGIAO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUOCTICH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CMND = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HOCHIEUSO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOITHUONGTRU = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIACHIHIENTAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGHENGHIEPNOILAMVIEC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TINHTRANG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HINHTHE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CHUPHONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAPHONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENPHONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupDSKhach.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachTro)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupDSKhach, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.46377F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.53623F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(688, 345);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(682, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH SÁCH KHÁCH TRỌ ĐÃ RỜI TRỌ";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupDSKhach
            // 
            this.groupDSKhach.Controls.Add(this.dgvKhachTro);
            this.groupDSKhach.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupDSKhach.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupDSKhach.Location = new System.Drawing.Point(3, 46);
            this.groupDSKhach.Name = "groupDSKhach";
            this.groupDSKhach.Size = new System.Drawing.Size(682, 296);
            this.groupDSKhach.TabIndex = 1;
            this.groupDSKhach.TabStop = false;
            this.groupDSKhach.Text = "Danh sách Khách";
            // 
            // dgvKhachTro
            // 
            this.dgvKhachTro.AllowUserToAddRows = false;
            this.dgvKhachTro.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvKhachTro.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvKhachTro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvKhachTro.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvKhachTro.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKhachTro.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvKhachTro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKhachTro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MA,
            this.HOTEN,
            this.NGAYSINH,
            this.GIOITINH,
            this.NOISINH,
            this.NGUYENQUAN,
            this.DANTOC,
            this.TONGIAO,
            this.QUOCTICH,
            this.CMND,
            this.HOCHIEUSO,
            this.NOITHUONGTRU,
            this.DIACHIHIENTAI,
            this.NGHENGHIEPNOILAMVIEC,
            this.TINHTRANG,
            this.HINHTHE,
            this.CHUPHONG,
            this.MAHD,
            this.MAPHONG,
            this.TENPHONG});
            this.dgvKhachTro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKhachTro.EnableHeadersVisualStyles = false;
            this.dgvKhachTro.Location = new System.Drawing.Point(3, 17);
            this.dgvKhachTro.Name = "dgvKhachTro";
            this.dgvKhachTro.ReadOnly = true;
            this.dgvKhachTro.Size = new System.Drawing.Size(676, 276);
            this.dgvKhachTro.TabIndex = 1;
            this.dgvKhachTro.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvKhach_CellMouseClick);
            // 
            // MA
            // 
            this.MA.DataPropertyName = "MAKT";
            this.MA.HeaderText = "Mã";
            this.MA.Name = "MA";
            this.MA.ReadOnly = true;
            this.MA.Visible = false;
            // 
            // HOTEN
            // 
            this.HOTEN.DataPropertyName = "HOTEN";
            this.HOTEN.HeaderText = "Họ tên";
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.ReadOnly = true;
            // 
            // NGAYSINH
            // 
            this.NGAYSINH.DataPropertyName = "NGAYSINH";
            this.NGAYSINH.HeaderText = "Ngày sinh";
            this.NGAYSINH.Name = "NGAYSINH";
            this.NGAYSINH.ReadOnly = true;
            // 
            // GIOITINH
            // 
            this.GIOITINH.DataPropertyName = "GIOITINH";
            this.GIOITINH.HeaderText = "Giới tính";
            this.GIOITINH.Name = "GIOITINH";
            this.GIOITINH.ReadOnly = true;
            // 
            // NOISINH
            // 
            this.NOISINH.DataPropertyName = "NOISINH";
            this.NOISINH.HeaderText = "Nơi sinh";
            this.NOISINH.Name = "NOISINH";
            this.NOISINH.ReadOnly = true;
            // 
            // NGUYENQUAN
            // 
            this.NGUYENQUAN.DataPropertyName = "NGUYENQUAN";
            this.NGUYENQUAN.HeaderText = "Nguyên quán";
            this.NGUYENQUAN.Name = "NGUYENQUAN";
            this.NGUYENQUAN.ReadOnly = true;
            // 
            // DANTOC
            // 
            this.DANTOC.DataPropertyName = "DANTOC";
            this.DANTOC.HeaderText = "Dân tộc";
            this.DANTOC.Name = "DANTOC";
            this.DANTOC.ReadOnly = true;
            // 
            // TONGIAO
            // 
            this.TONGIAO.DataPropertyName = "TONGIAO";
            this.TONGIAO.HeaderText = "Tôn giáo";
            this.TONGIAO.Name = "TONGIAO";
            this.TONGIAO.ReadOnly = true;
            // 
            // QUOCTICH
            // 
            this.QUOCTICH.DataPropertyName = "QUOCTICH";
            this.QUOCTICH.HeaderText = "Quốc tịch";
            this.QUOCTICH.Name = "QUOCTICH";
            this.QUOCTICH.ReadOnly = true;
            // 
            // CMND
            // 
            this.CMND.DataPropertyName = "CMND";
            this.CMND.HeaderText = "CMND";
            this.CMND.Name = "CMND";
            this.CMND.ReadOnly = true;
            // 
            // HOCHIEUSO
            // 
            this.HOCHIEUSO.DataPropertyName = "HOCHIEUSO";
            this.HOCHIEUSO.HeaderText = "Hộ chiếu";
            this.HOCHIEUSO.Name = "HOCHIEUSO";
            this.HOCHIEUSO.ReadOnly = true;
            // 
            // NOITHUONGTRU
            // 
            this.NOITHUONGTRU.DataPropertyName = "NOITHUONGTRU";
            this.NOITHUONGTRU.HeaderText = "Nơi thường trú";
            this.NOITHUONGTRU.Name = "NOITHUONGTRU";
            this.NOITHUONGTRU.ReadOnly = true;
            // 
            // DIACHIHIENTAI
            // 
            this.DIACHIHIENTAI.DataPropertyName = "DIACHIHIENTAI";
            this.DIACHIHIENTAI.HeaderText = "Địa chỉ hiện tại";
            this.DIACHIHIENTAI.Name = "DIACHIHIENTAI";
            this.DIACHIHIENTAI.ReadOnly = true;
            // 
            // NGHENGHIEPNOILAMVIEC
            // 
            this.NGHENGHIEPNOILAMVIEC.DataPropertyName = "NGHENGHIEPNOILAMVIEC";
            this.NGHENGHIEPNOILAMVIEC.HeaderText = "Nghề nghiệp - nơi làm việc";
            this.NGHENGHIEPNOILAMVIEC.Name = "NGHENGHIEPNOILAMVIEC";
            this.NGHENGHIEPNOILAMVIEC.ReadOnly = true;
            // 
            // TINHTRANG
            // 
            this.TINHTRANG.DataPropertyName = "TINHTRANG";
            this.TINHTRANG.HeaderText = "Tình trạng";
            this.TINHTRANG.Name = "TINHTRANG";
            this.TINHTRANG.ReadOnly = true;
            this.TINHTRANG.Visible = false;
            // 
            // HINHTHE
            // 
            this.HINHTHE.DataPropertyName = "HINHTHE";
            this.HINHTHE.HeaderText = "Hình";
            this.HINHTHE.Name = "HINHTHE";
            this.HINHTHE.ReadOnly = true;
            this.HINHTHE.Visible = false;
            // 
            // CHUPHONG
            // 
            this.CHUPHONG.DataPropertyName = "CHUPHONG";
            this.CHUPHONG.HeaderText = "Chủ phòng";
            this.CHUPHONG.Name = "CHUPHONG";
            this.CHUPHONG.ReadOnly = true;
            this.CHUPHONG.Visible = false;
            // 
            // MAHD
            // 
            this.MAHD.DataPropertyName = "MAHD";
            this.MAHD.HeaderText = "Mã Hợp Đồng";
            this.MAHD.Name = "MAHD";
            this.MAHD.ReadOnly = true;
            this.MAHD.Visible = false;
            // 
            // MAPHONG
            // 
            this.MAPHONG.DataPropertyName = "MAPHONG";
            this.MAPHONG.HeaderText = "Mã Phòng";
            this.MAPHONG.Name = "MAPHONG";
            this.MAPHONG.ReadOnly = true;
            this.MAPHONG.Visible = false;
            // 
            // TENPHONG
            // 
            this.TENPHONG.DataPropertyName = "TENPHONG";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Red;
            this.TENPHONG.DefaultCellStyle = dataGridViewCellStyle3;
            this.TENPHONG.HeaderText = "Phòng";
            this.TENPHONG.Name = "TENPHONG";
            this.TENPHONG.ReadOnly = true;
            // 
            // frmDSKhachDaRoiTro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 345);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmDSKhachDaRoiTro";
            this.Text = "DANH SÁCH KHÁCH TRỌ ĐÃ RỜI TRỌ";
            this.Load += new System.EventHandler(this.frmDSKhachDaRoiTro_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupDSKhach.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKhachTro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupDSKhach;
        private System.Windows.Forms.DataGridView dgvKhachTro;
        private System.Windows.Forms.DataGridViewTextBoxColumn MA;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOTEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAYSINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIOITINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOISINH;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGUYENQUAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn DANTOC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TONGIAO;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUOCTICH;
        private System.Windows.Forms.DataGridViewTextBoxColumn CMND;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOCHIEUSO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOITHUONGTRU;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIACHIHIENTAI;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGHENGHIEPNOILAMVIEC;
        private System.Windows.Forms.DataGridViewTextBoxColumn TINHTRANG;
        private System.Windows.Forms.DataGridViewTextBoxColumn HINHTHE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CHUPHONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAPHONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENPHONG;
    }
}