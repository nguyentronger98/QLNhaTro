namespace DOAN_TOTNGHIEP
{
    partial class frmThongBaoSuCo
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
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.dtTimKiem = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvSuCo = new System.Windows.Forms.DataGridView();
            this.MA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENPHONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIEUDE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGAY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOIDUNG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MAPHONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TINHTRANG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuCo)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.22099F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.944752F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.83425F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(806, 362);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "THÔNG BÁO SỰ SỐ HƯ HỎNG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.dtTimKiem, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 39);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(800, 30);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(260, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tìm Kiếm";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // dtTimKiem
            // 
            this.dtTimKiem.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtTimKiem.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTimKiem.Location = new System.Drawing.Point(269, 5);
            this.dtTimKiem.Name = "dtTimKiem";
            this.dtTimKiem.Size = new System.Drawing.Size(260, 22);
            this.dtTimKiem.TabIndex = 1;
            this.dtTimKiem.ValueChanged += new System.EventHandler(this.dtTimKiem_ValueChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvSuCo);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 284);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DANH SÁCH SỰ CỐ CHƯA KHẮC PHỤC";
            // 
            // dgvSuCo
            // 
            this.dgvSuCo.AllowUserToAddRows = false;
            this.dgvSuCo.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvSuCo.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSuCo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSuCo.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvSuCo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSuCo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSuCo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSuCo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MA,
            this.TENPHONG,
            this.TIEUDE,
            this.NGAY,
            this.NOIDUNG,
            this.MAPHONG,
            this.TINHTRANG});
            this.dgvSuCo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSuCo.EnableHeadersVisualStyles = false;
            this.dgvSuCo.Location = new System.Drawing.Point(3, 16);
            this.dgvSuCo.Name = "dgvSuCo";
            this.dgvSuCo.ReadOnly = true;
            this.dgvSuCo.Size = new System.Drawing.Size(794, 265);
            this.dgvSuCo.TabIndex = 0;
            this.dgvSuCo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSuCo_CellClick);
            // 
            // MA
            // 
            this.MA.DataPropertyName = "MA";
            this.MA.HeaderText = "Mã";
            this.MA.Name = "MA";
            this.MA.ReadOnly = true;
            this.MA.Visible = false;
            // 
            // TENPHONG
            // 
            this.TENPHONG.DataPropertyName = "TENPHONG";
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Red;
            this.TENPHONG.DefaultCellStyle = dataGridViewCellStyle3;
            this.TENPHONG.HeaderText = "Phòng";
            this.TENPHONG.Name = "TENPHONG";
            this.TENPHONG.ReadOnly = true;
            // 
            // TIEUDE
            // 
            this.TIEUDE.DataPropertyName = "TIEUDE";
            this.TIEUDE.HeaderText = "Tiêu đề";
            this.TIEUDE.Name = "TIEUDE";
            this.TIEUDE.ReadOnly = true;
            // 
            // NGAY
            // 
            this.NGAY.DataPropertyName = "NGAY";
            this.NGAY.HeaderText = "Ngày báo";
            this.NGAY.Name = "NGAY";
            this.NGAY.ReadOnly = true;
            // 
            // NOIDUNG
            // 
            this.NOIDUNG.DataPropertyName = "NOIDUNG";
            this.NOIDUNG.HeaderText = "Nội dung";
            this.NOIDUNG.Name = "NOIDUNG";
            this.NOIDUNG.ReadOnly = true;
            // 
            // MAPHONG
            // 
            this.MAPHONG.DataPropertyName = "MAPHONG";
            this.MAPHONG.HeaderText = "Mã phòng";
            this.MAPHONG.Name = "MAPHONG";
            this.MAPHONG.ReadOnly = true;
            this.MAPHONG.Visible = false;
            // 
            // TINHTRANG
            // 
            this.TINHTRANG.DataPropertyName = "TINHTRANG";
            this.TINHTRANG.HeaderText = "Tình Trạng";
            this.TINHTRANG.Name = "TINHTRANG";
            this.TINHTRANG.ReadOnly = true;
            this.TINHTRANG.Visible = false;
            // 
            // frmThongBaoSuCo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 362);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frmThongBaoSuCo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "THÔNG BÁO SỰ CỐ HƯ HỎNG";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmThongBaoSuCo_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuCo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvSuCo;
        private System.Windows.Forms.DataGridViewTextBoxColumn MA;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENPHONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn TIEUDE;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGAY;
        private System.Windows.Forms.DataGridViewTextBoxColumn NOIDUNG;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAPHONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn TINHTRANG;
        private System.Windows.Forms.DateTimePicker dtTimKiem;
    }
}