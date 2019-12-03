namespace LTUD_QLTV
{
    partial class QuanLySach
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLySach));
            this.lblMaSach = new System.Windows.Forms.Label();
            this.lblTenSach = new System.Windows.Forms.Label();
            this.lblTacGia = new System.Windows.Forms.Label();
            this.lblLoaiSach = new System.Windows.Forms.Label();
            this.pbxHinhSach = new System.Windows.Forms.PictureBox();
            this.lblTieuDeSach = new System.Windows.Forms.Label();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.txtMaSach = new System.Windows.Forms.TextBox();
            this.cbxTacGia = new System.Windows.Forms.ComboBox();
            this.cbxLoaiSach = new System.Windows.Forms.ComboBox();
            this.dgvDLSach = new System.Windows.Forms.DataGridView();
            this.MaSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HinhAnh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddTG = new System.Windows.Forms.Button();
            this.btnAddLoaiSach = new System.Windows.Forms.Button();
            this.btnThemSach = new System.Windows.Forms.Button();
            this.btnXoaSach = new System.Windows.Forms.Button();
            this.btnSuaSach = new System.Windows.Forms.Button();
            this.btnLuuSach = new System.Windows.Forms.Button();
            this.btnThoatSach = new System.Windows.Forms.Button();
            this.txtTimKiemSach = new System.Windows.Forms.TextBox();
            this.cbxLoaiTimKiem = new System.Windows.Forms.ComboBox();
            this.bnTimKiemSach = new System.Windows.Forms.Button();
            this.btnChonHinhSach = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtHinhSach = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbxHinhSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDLSach)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMaSach
            // 
            this.lblMaSach.AutoSize = true;
            this.lblMaSach.Location = new System.Drawing.Point(22, 71);
            this.lblMaSach.Name = "lblMaSach";
            this.lblMaSach.Size = new System.Drawing.Size(48, 13);
            this.lblMaSach.TabIndex = 0;
            this.lblMaSach.Text = "Mã sách";
            // 
            // lblTenSach
            // 
            this.lblTenSach.AutoSize = true;
            this.lblTenSach.Location = new System.Drawing.Point(25, 110);
            this.lblTenSach.Name = "lblTenSach";
            this.lblTenSach.Size = new System.Drawing.Size(54, 13);
            this.lblTenSach.TabIndex = 1;
            this.lblTenSach.Text = "Tên Sách";
            // 
            // lblTacGia
            // 
            this.lblTacGia.AutoSize = true;
            this.lblTacGia.Location = new System.Drawing.Point(320, 70);
            this.lblTacGia.Name = "lblTacGia";
            this.lblTacGia.Size = new System.Drawing.Size(43, 13);
            this.lblTacGia.TabIndex = 2;
            this.lblTacGia.Text = "Tác giả";
            // 
            // lblLoaiSach
            // 
            this.lblLoaiSach.AutoSize = true;
            this.lblLoaiSach.Location = new System.Drawing.Point(323, 110);
            this.lblLoaiSach.Name = "lblLoaiSach";
            this.lblLoaiSach.Size = new System.Drawing.Size(53, 13);
            this.lblLoaiSach.TabIndex = 3;
            this.lblLoaiSach.Text = "Loại sách";
            // 
            // pbxHinhSach
            // 
            this.pbxHinhSach.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbxHinhSach.BackgroundImage")));
            this.pbxHinhSach.Location = new System.Drawing.Point(688, 12);
            this.pbxHinhSach.Name = "pbxHinhSach";
            this.pbxHinhSach.Size = new System.Drawing.Size(100, 129);
            this.pbxHinhSach.TabIndex = 4;
            this.pbxHinhSach.TabStop = false;
            // 
            // lblTieuDeSach
            // 
            this.lblTieuDeSach.AutoSize = true;
            this.lblTieuDeSach.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDeSach.Location = new System.Drawing.Point(280, 9);
            this.lblTieuDeSach.Name = "lblTieuDeSach";
            this.lblTieuDeSach.Size = new System.Drawing.Size(168, 24);
            this.lblTieuDeSach.TabIndex = 5;
            this.lblTieuDeSach.Text = "QUẢN LÝ SÁCH";
            // 
            // txtTenSach
            // 
            this.txtTenSach.Location = new System.Drawing.Point(100, 103);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(196, 20);
            this.txtTenSach.TabIndex = 6;
            // 
            // txtMaSach
            // 
            this.txtMaSach.Location = new System.Drawing.Point(100, 68);
            this.txtMaSach.Name = "txtMaSach";
            this.txtMaSach.Size = new System.Drawing.Size(196, 20);
            this.txtMaSach.TabIndex = 6;
            // 
            // cbxTacGia
            // 
            this.cbxTacGia.FormattingEnabled = true;
            this.cbxTacGia.Location = new System.Drawing.Point(394, 63);
            this.cbxTacGia.Name = "cbxTacGia";
            this.cbxTacGia.Size = new System.Drawing.Size(159, 21);
            this.cbxTacGia.TabIndex = 7;
            // 
            // cbxLoaiSach
            // 
            this.cbxLoaiSach.FormattingEnabled = true;
            this.cbxLoaiSach.Location = new System.Drawing.Point(394, 103);
            this.cbxLoaiSach.Name = "cbxLoaiSach";
            this.cbxLoaiSach.Size = new System.Drawing.Size(159, 21);
            this.cbxLoaiSach.TabIndex = 7;
            // 
            // dgvDLSach
            // 
            this.dgvDLSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDLSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSach,
            this.TenSach,
            this.TacGia,
            this.HinhAnh,
            this.LoaiSach});
            this.dgvDLSach.Location = new System.Drawing.Point(22, 223);
            this.dgvDLSach.Name = "dgvDLSach";
            this.dgvDLSach.Size = new System.Drawing.Size(766, 216);
            this.dgvDLSach.TabIndex = 8;
            this.dgvDLSach.Click += new System.EventHandler(this.dgvDLSach_Click);
            // 
            // MaSach
            // 
            this.MaSach.DataPropertyName = "MaSach";
            this.MaSach.HeaderText = "Mã Sách";
            this.MaSach.Name = "MaSach";
            // 
            // TenSach
            // 
            this.TenSach.DataPropertyName = "TenSach";
            this.TenSach.HeaderText = "Tên Sách";
            this.TenSach.Name = "TenSach";
            this.TenSach.Width = 150;
            // 
            // TacGia
            // 
            this.TacGia.DataPropertyName = "TacGia";
            this.TacGia.HeaderText = "Tác Gỉa";
            this.TacGia.Name = "TacGia";
            this.TacGia.Width = 150;
            // 
            // HinhAnh
            // 
            this.HinhAnh.DataPropertyName = "AnhSach";
            this.HinhAnh.HeaderText = "Hình Ảnh";
            this.HinhAnh.Name = "HinhAnh";
            this.HinhAnh.Width = 200;
            // 
            // LoaiSach
            // 
            this.LoaiSach.DataPropertyName = "LoaiSach";
            this.LoaiSach.HeaderText = "Loại Sách";
            this.LoaiSach.Name = "LoaiSach";
            this.LoaiSach.Width = 150;
            // 
            // btnAddTG
            // 
            this.btnAddTG.Location = new System.Drawing.Point(572, 59);
            this.btnAddTG.Name = "btnAddTG";
            this.btnAddTG.Size = new System.Drawing.Size(90, 23);
            this.btnAddTG.TabIndex = 9;
            this.btnAddTG.Text = "Thêm tác giả";
            this.btnAddTG.UseVisualStyleBackColor = true;
            this.btnAddTG.Click += new System.EventHandler(this.btnAddTG_Click);
            // 
            // btnAddLoaiSach
            // 
            this.btnAddLoaiSach.Location = new System.Drawing.Point(572, 103);
            this.btnAddLoaiSach.Name = "btnAddLoaiSach";
            this.btnAddLoaiSach.Size = new System.Drawing.Size(90, 23);
            this.btnAddLoaiSach.TabIndex = 9;
            this.btnAddLoaiSach.Text = "Thêm loại sách";
            this.btnAddLoaiSach.UseVisualStyleBackColor = true;
            this.btnAddLoaiSach.Click += new System.EventHandler(this.btnAddLoaiSach_Click);
            // 
            // btnThemSach
            // 
            this.btnThemSach.Location = new System.Drawing.Point(19, 143);
            this.btnThemSach.Name = "btnThemSach";
            this.btnThemSach.Size = new System.Drawing.Size(75, 23);
            this.btnThemSach.TabIndex = 9;
            this.btnThemSach.Text = "Thêm";
            this.btnThemSach.UseVisualStyleBackColor = true;
            this.btnThemSach.Click += new System.EventHandler(this.btnThemSach_Click);
            // 
            // btnXoaSach
            // 
            this.btnXoaSach.Location = new System.Drawing.Point(100, 143);
            this.btnXoaSach.Name = "btnXoaSach";
            this.btnXoaSach.Size = new System.Drawing.Size(75, 23);
            this.btnXoaSach.TabIndex = 9;
            this.btnXoaSach.Text = "Xóa";
            this.btnXoaSach.UseVisualStyleBackColor = true;
            this.btnXoaSach.Click += new System.EventHandler(this.btnXoaSach_Click);
            // 
            // btnSuaSach
            // 
            this.btnSuaSach.Location = new System.Drawing.Point(181, 143);
            this.btnSuaSach.Name = "btnSuaSach";
            this.btnSuaSach.Size = new System.Drawing.Size(75, 23);
            this.btnSuaSach.TabIndex = 9;
            this.btnSuaSach.Text = "Sửa";
            this.btnSuaSach.UseVisualStyleBackColor = true;
            this.btnSuaSach.Click += new System.EventHandler(this.btnSuaSach_Click);
            // 
            // btnLuuSach
            // 
            this.btnLuuSach.Location = new System.Drawing.Point(262, 143);
            this.btnLuuSach.Name = "btnLuuSach";
            this.btnLuuSach.Size = new System.Drawing.Size(75, 23);
            this.btnLuuSach.TabIndex = 9;
            this.btnLuuSach.Text = "Lưu";
            this.btnLuuSach.UseVisualStyleBackColor = true;
            this.btnLuuSach.Click += new System.EventHandler(this.btnLuuSach_Click);
            // 
            // btnThoatSach
            // 
            this.btnThoatSach.Location = new System.Drawing.Point(343, 143);
            this.btnThoatSach.Name = "btnThoatSach";
            this.btnThoatSach.Size = new System.Drawing.Size(75, 23);
            this.btnThoatSach.TabIndex = 9;
            this.btnThoatSach.Text = "Thoát";
            this.btnThoatSach.UseVisualStyleBackColor = true;
            this.btnThoatSach.Click += new System.EventHandler(this.btnThoatSach_Click);
            // 
            // txtTimKiemSach
            // 
            this.txtTimKiemSach.Location = new System.Drawing.Point(343, 184);
            this.txtTimKiemSach.Name = "txtTimKiemSach";
            this.txtTimKiemSach.Size = new System.Drawing.Size(196, 20);
            this.txtTimKiemSach.TabIndex = 6;
            // 
            // cbxLoaiTimKiem
            // 
            this.cbxLoaiTimKiem.FormattingEnabled = true;
            this.cbxLoaiTimKiem.Items.AddRange(new object[] {
            "MaSach",
            "TenSach",
            "TacGia",
            "LoaiSach"});
            this.cbxLoaiTimKiem.Location = new System.Drawing.Point(545, 184);
            this.cbxLoaiTimKiem.Name = "cbxLoaiTimKiem";
            this.cbxLoaiTimKiem.Size = new System.Drawing.Size(78, 21);
            this.cbxLoaiTimKiem.TabIndex = 7;
            // 
            // bnTimKiemSach
            // 
            this.bnTimKiemSach.Location = new System.Drawing.Point(639, 184);
            this.bnTimKiemSach.Name = "bnTimKiemSach";
            this.bnTimKiemSach.Size = new System.Drawing.Size(75, 23);
            this.bnTimKiemSach.TabIndex = 9;
            this.bnTimKiemSach.Text = "Tìm kiếm";
            this.bnTimKiemSach.UseVisualStyleBackColor = true;
            this.bnTimKiemSach.Click += new System.EventHandler(this.bnTimKiemSach_Click);
            // 
            // btnChonHinhSach
            // 
            this.btnChonHinhSach.Location = new System.Drawing.Point(688, 147);
            this.btnChonHinhSach.Name = "btnChonHinhSach";
            this.btnChonHinhSach.Size = new System.Drawing.Size(100, 23);
            this.btnChonHinhSach.TabIndex = 9;
            this.btnChonHinhSach.Text = "Chọn Hình";
            this.btnChonHinhSach.UseVisualStyleBackColor = true;
            this.btnChonHinhSach.Click += new System.EventHandler(this.btnChonHinhSach_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtHinhSach
            // 
            this.txtHinhSach.Location = new System.Drawing.Point(117, 184);
            this.txtHinhSach.Name = "txtHinhSach";
            this.txtHinhSach.Size = new System.Drawing.Size(100, 20);
            this.txtHinhSach.TabIndex = 10;
            // 
            // QuanLySach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.txtHinhSach);
            this.Controls.Add(this.btnThoatSach);
            this.Controls.Add(this.btnLuuSach);
            this.Controls.Add(this.btnSuaSach);
            this.Controls.Add(this.btnXoaSach);
            this.Controls.Add(this.btnThemSach);
            this.Controls.Add(this.btnChonHinhSach);
            this.Controls.Add(this.bnTimKiemSach);
            this.Controls.Add(this.btnAddLoaiSach);
            this.Controls.Add(this.btnAddTG);
            this.Controls.Add(this.dgvDLSach);
            this.Controls.Add(this.cbxLoaiTimKiem);
            this.Controls.Add(this.cbxLoaiSach);
            this.Controls.Add(this.cbxTacGia);
            this.Controls.Add(this.txtMaSach);
            this.Controls.Add(this.txtTimKiemSach);
            this.Controls.Add(this.txtTenSach);
            this.Controls.Add(this.lblTieuDeSach);
            this.Controls.Add(this.pbxHinhSach);
            this.Controls.Add(this.lblLoaiSach);
            this.Controls.Add(this.lblTacGia);
            this.Controls.Add(this.lblTenSach);
            this.Controls.Add(this.lblMaSach);
            this.Name = "QuanLySach";
            this.Text = "QuanLySach";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QuanLySach_FormClosing);
            this.Load += new System.EventHandler(this.QuanLySach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxHinhSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDLSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaSach;
        private System.Windows.Forms.Label lblTenSach;
        private System.Windows.Forms.Label lblTacGia;
        private System.Windows.Forms.Label lblLoaiSach;
        private System.Windows.Forms.PictureBox pbxHinhSach;
        private System.Windows.Forms.Label lblTieuDeSach;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.TextBox txtMaSach;
        private System.Windows.Forms.ComboBox cbxTacGia;
        private System.Windows.Forms.ComboBox cbxLoaiSach;
        private System.Windows.Forms.DataGridView dgvDLSach;
        private System.Windows.Forms.Button btnAddTG;
        private System.Windows.Forms.Button btnAddLoaiSach;
        private System.Windows.Forms.Button btnThemSach;
        private System.Windows.Forms.Button btnXoaSach;
        private System.Windows.Forms.Button btnSuaSach;
        private System.Windows.Forms.Button btnLuuSach;
        private System.Windows.Forms.Button btnThoatSach;
        private System.Windows.Forms.TextBox txtTimKiemSach;
        private System.Windows.Forms.ComboBox cbxLoaiTimKiem;
        private System.Windows.Forms.Button bnTimKiemSach;
        private System.Windows.Forms.Button btnChonHinhSach;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox txtHinhSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn HinhAnh;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiSach;
    }
}