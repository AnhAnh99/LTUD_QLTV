namespace LTUD_QLTV
{
    partial class TheKhachHang
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
            this.lblTDThe = new System.Windows.Forms.Label();
            this.lblMaKH = new System.Windows.Forms.Label();
            this.lblSDTKH = new System.Windows.Forms.Label();
            this.TenKH = new System.Windows.Forms.Label();
            this.lblDiaChiKH = new System.Windows.Forms.Label();
            this.lblNgayHetHan = new System.Windows.Forms.Label();
            this.lblNgayDangKy = new System.Windows.Forms.Label();
            this.txtMaKH = new System.Windows.Forms.TextBox();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.txtSoDTKH = new System.Windows.Forms.TextBox();
            this.txtDiaChiKH = new System.Windows.Forms.TextBox();
            this.dtpNgayDK = new System.Windows.Forms.DateTimePicker();
            this.dtpNgayHH = new System.Windows.Forms.DateTimePicker();
            this.btnXoaKH = new System.Windows.Forms.Button();
            this.btnThemKH = new System.Windows.Forms.Button();
            this.btnSuaKH = new System.Windows.Forms.Button();
            this.btnLuuKH = new System.Windows.Forms.Button();
            this.btnThoatKH = new System.Windows.Forms.Button();
            this.dgvDLKhachHang = new System.Windows.Forms.DataGridView();
            this.MaKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKhachHang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoDienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayDK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayHetHan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTimKiemKH = new System.Windows.Forms.Button();
            this.txtTKiemKH = new System.Windows.Forms.TextBox();
            this.cbxTKiemKH = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDLKhachHang)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTDThe
            // 
            this.lblTDThe.AutoSize = true;
            this.lblTDThe.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTDThe.Location = new System.Drawing.Point(338, 19);
            this.lblTDThe.Name = "lblTDThe";
            this.lblTDThe.Size = new System.Drawing.Size(400, 31);
            this.lblTDThe.TabIndex = 0;
            this.lblTDThe.Text = "QUẢN LÝ THẺ KHÁCH HÀNG";
            // 
            // lblMaKH
            // 
            this.lblMaKH.AutoSize = true;
            this.lblMaKH.Location = new System.Drawing.Point(112, 145);
            this.lblMaKH.Name = "lblMaKH";
            this.lblMaKH.Size = new System.Drawing.Size(82, 13);
            this.lblMaKH.TabIndex = 0;
            this.lblMaKH.Text = "Mã khách hàng";
            // 
            // lblSDTKH
            // 
            this.lblSDTKH.AutoSize = true;
            this.lblSDTKH.Location = new System.Drawing.Point(112, 215);
            this.lblSDTKH.Name = "lblSDTKH";
            this.lblSDTKH.Size = new System.Drawing.Size(70, 13);
            this.lblSDTKH.TabIndex = 0;
            this.lblSDTKH.Text = "Số điện thoại";
            // 
            // TenKH
            // 
            this.TenKH.AutoSize = true;
            this.TenKH.Location = new System.Drawing.Point(112, 179);
            this.TenKH.Name = "TenKH";
            this.TenKH.Size = new System.Drawing.Size(86, 13);
            this.TenKH.TabIndex = 0;
            this.TenKH.Text = "Tên khách hàng";
            // 
            // lblDiaChiKH
            // 
            this.lblDiaChiKH.AutoSize = true;
            this.lblDiaChiKH.Location = new System.Drawing.Point(495, 145);
            this.lblDiaChiKH.Name = "lblDiaChiKH";
            this.lblDiaChiKH.Size = new System.Drawing.Size(40, 13);
            this.lblDiaChiKH.TabIndex = 0;
            this.lblDiaChiKH.Text = "Địa chỉ";
            // 
            // lblNgayHetHan
            // 
            this.lblNgayHetHan.AutoSize = true;
            this.lblNgayHetHan.Location = new System.Drawing.Point(495, 215);
            this.lblNgayHetHan.Name = "lblNgayHetHan";
            this.lblNgayHetHan.Size = new System.Drawing.Size(71, 13);
            this.lblNgayHetHan.TabIndex = 0;
            this.lblNgayHetHan.Text = "Ngày hết hạn";
            // 
            // lblNgayDangKy
            // 
            this.lblNgayDangKy.AutoSize = true;
            this.lblNgayDangKy.Location = new System.Drawing.Point(495, 179);
            this.lblNgayDangKy.Name = "lblNgayDangKy";
            this.lblNgayDangKy.Size = new System.Drawing.Size(74, 13);
            this.lblNgayDangKy.TabIndex = 0;
            this.lblNgayDangKy.Text = "Ngày đăng ký";
            // 
            // txtMaKH
            // 
            this.txtMaKH.Location = new System.Drawing.Point(216, 138);
            this.txtMaKH.Name = "txtMaKH";
            this.txtMaKH.Size = new System.Drawing.Size(233, 20);
            this.txtMaKH.TabIndex = 1;
            // 
            // txtTenKH
            // 
            this.txtTenKH.Location = new System.Drawing.Point(216, 172);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(233, 20);
            this.txtTenKH.TabIndex = 1;
            // 
            // txtSoDTKH
            // 
            this.txtSoDTKH.Location = new System.Drawing.Point(216, 208);
            this.txtSoDTKH.Name = "txtSoDTKH";
            this.txtSoDTKH.Size = new System.Drawing.Size(233, 20);
            this.txtSoDTKH.TabIndex = 1;
            // 
            // txtDiaChiKH
            // 
            this.txtDiaChiKH.Location = new System.Drawing.Point(592, 138);
            this.txtDiaChiKH.Name = "txtDiaChiKH";
            this.txtDiaChiKH.Size = new System.Drawing.Size(233, 20);
            this.txtDiaChiKH.TabIndex = 1;
            // 
            // dtpNgayDK
            // 
            this.dtpNgayDK.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayDK.Location = new System.Drawing.Point(592, 173);
            this.dtpNgayDK.Name = "dtpNgayDK";
            this.dtpNgayDK.Size = new System.Drawing.Size(233, 20);
            this.dtpNgayDK.TabIndex = 2;
            // 
            // dtpNgayHH
            // 
            this.dtpNgayHH.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNgayHH.Location = new System.Drawing.Point(592, 209);
            this.dtpNgayHH.Name = "dtpNgayHH";
            this.dtpNgayHH.Size = new System.Drawing.Size(233, 20);
            this.dtpNgayHH.TabIndex = 2;
            // 
            // btnXoaKH
            // 
            this.btnXoaKH.Location = new System.Drawing.Point(103, 19);
            this.btnXoaKH.Name = "btnXoaKH";
            this.btnXoaKH.Size = new System.Drawing.Size(75, 23);
            this.btnXoaKH.TabIndex = 3;
            this.btnXoaKH.Text = "Xóa ";
            this.btnXoaKH.UseVisualStyleBackColor = true;
            this.btnXoaKH.Click += new System.EventHandler(this.btnXoaKH_Click);
            // 
            // btnThemKH
            // 
            this.btnThemKH.Location = new System.Drawing.Point(6, 19);
            this.btnThemKH.Name = "btnThemKH";
            this.btnThemKH.Size = new System.Drawing.Size(75, 23);
            this.btnThemKH.TabIndex = 3;
            this.btnThemKH.Text = "Thêm";
            this.btnThemKH.UseVisualStyleBackColor = true;
            this.btnThemKH.Click += new System.EventHandler(this.btnThemKH_Click);
            // 
            // btnSuaKH
            // 
            this.btnSuaKH.Location = new System.Drawing.Point(196, 19);
            this.btnSuaKH.Name = "btnSuaKH";
            this.btnSuaKH.Size = new System.Drawing.Size(75, 23);
            this.btnSuaKH.TabIndex = 3;
            this.btnSuaKH.Text = "Sửa";
            this.btnSuaKH.UseVisualStyleBackColor = true;
            this.btnSuaKH.Click += new System.EventHandler(this.btnSuaKH_Click);
            // 
            // btnLuuKH
            // 
            this.btnLuuKH.Location = new System.Drawing.Point(296, 19);
            this.btnLuuKH.Name = "btnLuuKH";
            this.btnLuuKH.Size = new System.Drawing.Size(75, 23);
            this.btnLuuKH.TabIndex = 3;
            this.btnLuuKH.Text = "Lưu";
            this.btnLuuKH.UseVisualStyleBackColor = true;
            this.btnLuuKH.Click += new System.EventHandler(this.btnLuuKH_Click);
            // 
            // btnThoatKH
            // 
            this.btnThoatKH.Location = new System.Drawing.Point(393, 19);
            this.btnThoatKH.Name = "btnThoatKH";
            this.btnThoatKH.Size = new System.Drawing.Size(75, 23);
            this.btnThoatKH.TabIndex = 3;
            this.btnThoatKH.Text = "Thoát";
            this.btnThoatKH.UseVisualStyleBackColor = true;
            this.btnThoatKH.Click += new System.EventHandler(this.btnThoatKH_Click);
            // 
            // dgvDLKhachHang
            // 
            this.dgvDLKhachHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDLKhachHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKhachHang,
            this.TenKhachHang,
            this.SoDienThoai,
            this.DiaChi,
            this.NgayDK,
            this.NgayHetHan});
            this.dgvDLKhachHang.Location = new System.Drawing.Point(94, 354);
            this.dgvDLKhachHang.Name = "dgvDLKhachHang";
            this.dgvDLKhachHang.Size = new System.Drawing.Size(829, 207);
            this.dgvDLKhachHang.TabIndex = 4;
            this.dgvDLKhachHang.Click += new System.EventHandler(this.dgvDLKhachHang_Click);
            // 
            // MaKhachHang
            // 
            this.MaKhachHang.DataPropertyName = "MaKhachHang";
            this.MaKhachHang.HeaderText = "Mã khách hàng";
            this.MaKhachHang.Name = "MaKhachHang";
            // 
            // TenKhachHang
            // 
            this.TenKhachHang.DataPropertyName = "TenKhachHang";
            this.TenKhachHang.HeaderText = "Tên khách hàng";
            this.TenKhachHang.Name = "TenKhachHang";
            this.TenKhachHang.Width = 170;
            // 
            // SoDienThoai
            // 
            this.SoDienThoai.DataPropertyName = "SoDienThoaiKH";
            this.SoDienThoai.HeaderText = "Số điện thoại";
            this.SoDienThoai.Name = "SoDienThoai";
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChiKH";
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Width = 170;
            // 
            // NgayDK
            // 
            this.NgayDK.DataPropertyName = "NgayDK";
            this.NgayDK.HeaderText = "Ngày đăng ký";
            this.NgayDK.Name = "NgayDK";
            // 
            // NgayHetHan
            // 
            this.NgayHetHan.DataPropertyName = "NgayHetHan";
            this.NgayHetHan.HeaderText = "Ngày hết hạn";
            this.NgayHetHan.Name = "NgayHetHan";
            // 
            // btnTimKiemKH
            // 
            this.btnTimKiemKH.Location = new System.Drawing.Point(367, 19);
            this.btnTimKiemKH.Name = "btnTimKiemKH";
            this.btnTimKiemKH.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiemKH.TabIndex = 3;
            this.btnTimKiemKH.Text = "Tìm kiếm";
            this.btnTimKiemKH.UseVisualStyleBackColor = true;
            this.btnTimKiemKH.Click += new System.EventHandler(this.btnTimKiemKH_Click);
            // 
            // txtTKiemKH
            // 
            this.txtTKiemKH.Location = new System.Drawing.Point(6, 19);
            this.txtTKiemKH.Name = "txtTKiemKH";
            this.txtTKiemKH.Size = new System.Drawing.Size(233, 20);
            this.txtTKiemKH.TabIndex = 1;
            // 
            // cbxTKiemKH
            // 
            this.cbxTKiemKH.FormattingEnabled = true;
            this.cbxTKiemKH.Items.AddRange(new object[] {
            "MaKhachHang",
            "TenKhachHang",
            "SoDienThoaiKH",
            "DiaChiKH",
            "NgayDK",
            "NgayHetHan"});
            this.cbxTKiemKH.Location = new System.Drawing.Point(245, 19);
            this.cbxTKiemKH.Name = "cbxTKiemKH";
            this.cbxTKiemKH.Size = new System.Drawing.Size(105, 21);
            this.cbxTKiemKH.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThemKH);
            this.groupBox1.Controls.Add(this.btnXoaKH);
            this.groupBox1.Controls.Add(this.btnSuaKH);
            this.groupBox1.Controls.Add(this.btnLuuKH);
            this.groupBox1.Controls.Add(this.btnThoatKH);
            this.groupBox1.Location = new System.Drawing.Point(277, 267);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(473, 57);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTKiemKH);
            this.groupBox2.Controls.Add(this.cbxTKiemKH);
            this.groupBox2.Controls.Add(this.btnTimKiemKH);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(277, 61);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(473, 55);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm thông tin";
            // 
            // TheKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(986, 584);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvDLKhachHang);
            this.Controls.Add(this.dtpNgayHH);
            this.Controls.Add(this.dtpNgayDK);
            this.Controls.Add(this.txtDiaChiKH);
            this.Controls.Add(this.txtSoDTKH);
            this.Controls.Add(this.txtTenKH);
            this.Controls.Add(this.txtMaKH);
            this.Controls.Add(this.lblNgayDangKy);
            this.Controls.Add(this.TenKH);
            this.Controls.Add(this.lblNgayHetHan);
            this.Controls.Add(this.lblDiaChiKH);
            this.Controls.Add(this.lblSDTKH);
            this.Controls.Add(this.lblMaKH);
            this.Controls.Add(this.lblTDThe);
            this.Name = "TheKhachHang";
            this.Text = "TheKhachHang";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TheKhachHang_FormClosing);
            this.Load += new System.EventHandler(this.TheKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDLKhachHang)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTDThe;
        private System.Windows.Forms.Label lblMaKH;
        private System.Windows.Forms.Label lblSDTKH;
        private System.Windows.Forms.Label TenKH;
        private System.Windows.Forms.Label lblDiaChiKH;
        private System.Windows.Forms.Label lblNgayHetHan;
        private System.Windows.Forms.Label lblNgayDangKy;
        private System.Windows.Forms.TextBox txtMaKH;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.TextBox txtSoDTKH;
        private System.Windows.Forms.TextBox txtDiaChiKH;
        private System.Windows.Forms.DateTimePicker dtpNgayDK;
        private System.Windows.Forms.DateTimePicker dtpNgayHH;
        private System.Windows.Forms.Button btnXoaKH;
        private System.Windows.Forms.Button btnThemKH;
        private System.Windows.Forms.Button btnSuaKH;
        private System.Windows.Forms.Button btnLuuKH;
        private System.Windows.Forms.Button btnThoatKH;
        private System.Windows.Forms.DataGridView dgvDLKhachHang;
        private System.Windows.Forms.Button btnTimKiemKH;
        private System.Windows.Forms.TextBox txtTKiemKH;
        private System.Windows.Forms.ComboBox cbxTKiemKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKhachHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoDienThoai;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayDK;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayHetHan;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}