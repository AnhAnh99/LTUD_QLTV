namespace LTUD_QLTV
{
    partial class TacGia
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
            this.lblMaTG = new System.Windows.Forms.Label();
            this.lblTenTG = new System.Windows.Forms.Label();
            this.lblDiaChiTG = new System.Windows.Forms.Label();
            this.lblTieuDeTG = new System.Windows.Forms.Label();
            this.txtTenTG = new System.Windows.Forms.TextBox();
            this.txtMaTG = new System.Windows.Forms.TextBox();
            this.txtDiaChiTG = new System.Windows.Forms.TextBox();
            this.dgvDLTacGia = new System.Windows.Forms.DataGridView();
            this.MaTacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenTacGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTKiemTG = new System.Windows.Forms.TextBox();
            this.btnThemTG = new System.Windows.Forms.Button();
            this.btnXoaTG = new System.Windows.Forms.Button();
            this.btnLuuTG = new System.Windows.Forms.Button();
            this.btnTKiemTG = new System.Windows.Forms.Button();
            this.btnSuaTG = new System.Windows.Forms.Button();
            this.cbxTimKiemTG = new System.Windows.Forms.ComboBox();
            this.btnThoatTG = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDLTacGia)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMaTG
            // 
            this.lblMaTG.AutoSize = true;
            this.lblMaTG.Location = new System.Drawing.Point(45, 62);
            this.lblMaTG.Name = "lblMaTG";
            this.lblMaTG.Size = new System.Drawing.Size(57, 13);
            this.lblMaTG.TabIndex = 0;
            this.lblMaTG.Text = "Mã tác giả";
            // 
            // lblTenTG
            // 
            this.lblTenTG.AutoSize = true;
            this.lblTenTG.Location = new System.Drawing.Point(45, 103);
            this.lblTenTG.Name = "lblTenTG";
            this.lblTenTG.Size = new System.Drawing.Size(61, 13);
            this.lblTenTG.TabIndex = 0;
            this.lblTenTG.Text = "Tên tác giả";
            // 
            // lblDiaChiTG
            // 
            this.lblDiaChiTG.AutoSize = true;
            this.lblDiaChiTG.Location = new System.Drawing.Point(378, 62);
            this.lblDiaChiTG.Name = "lblDiaChiTG";
            this.lblDiaChiTG.Size = new System.Drawing.Size(40, 13);
            this.lblDiaChiTG.TabIndex = 0;
            this.lblDiaChiTG.Text = "Địa chỉ";
            // 
            // lblTieuDeTG
            // 
            this.lblTieuDeTG.AutoSize = true;
            this.lblTieuDeTG.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDeTG.Location = new System.Drawing.Point(286, 9);
            this.lblTieuDeTG.Name = "lblTieuDeTG";
            this.lblTieuDeTG.Size = new System.Drawing.Size(196, 24);
            this.lblTieuDeTG.TabIndex = 1;
            this.lblTieuDeTG.Text = "QUẢN LÝ TÁC GIẢ";
            // 
            // txtTenTG
            // 
            this.txtTenTG.Location = new System.Drawing.Point(115, 96);
            this.txtTenTG.Name = "txtTenTG";
            this.txtTenTG.Size = new System.Drawing.Size(197, 20);
            this.txtTenTG.TabIndex = 2;
            // 
            // txtMaTG
            // 
            this.txtMaTG.Location = new System.Drawing.Point(115, 59);
            this.txtMaTG.Name = "txtMaTG";
            this.txtMaTG.Size = new System.Drawing.Size(197, 20);
            this.txtMaTG.TabIndex = 2;
            // 
            // txtDiaChiTG
            // 
            this.txtDiaChiTG.Location = new System.Drawing.Point(446, 55);
            this.txtDiaChiTG.Name = "txtDiaChiTG";
            this.txtDiaChiTG.Size = new System.Drawing.Size(197, 20);
            this.txtDiaChiTG.TabIndex = 2;
            // 
            // dgvDLTacGia
            // 
            this.dgvDLTacGia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDLTacGia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaTacGia,
            this.TenTacGia,
            this.DiaChi});
            this.dgvDLTacGia.Location = new System.Drawing.Point(75, 189);
            this.dgvDLTacGia.Name = "dgvDLTacGia";
            this.dgvDLTacGia.Size = new System.Drawing.Size(513, 150);
            this.dgvDLTacGia.TabIndex = 3;
            this.dgvDLTacGia.Click += new System.EventHandler(this.dgvDLTacGia_Click);
            // 
            // MaTacGia
            // 
            this.MaTacGia.DataPropertyName = "MaTacGia";
            this.MaTacGia.HeaderText = "Mã tác giả";
            this.MaTacGia.Name = "MaTacGia";
            // 
            // TenTacGia
            // 
            this.TenTacGia.DataPropertyName = "TenTacGia";
            this.TenTacGia.HeaderText = "Tên tác giả";
            this.TenTacGia.Name = "TenTacGia";
            this.TenTacGia.Width = 170;
            // 
            // DiaChi
            // 
            this.DiaChi.DataPropertyName = "DiaChiTG";
            this.DiaChi.HeaderText = "Địa chỉ";
            this.DiaChi.Name = "DiaChi";
            this.DiaChi.Width = 200;
            // 
            // txtTKiemTG
            // 
            this.txtTKiemTG.Location = new System.Drawing.Point(203, 149);
            this.txtTKiemTG.Name = "txtTKiemTG";
            this.txtTKiemTG.Size = new System.Drawing.Size(197, 20);
            this.txtTKiemTG.TabIndex = 2;
            // 
            // btnThemTG
            // 
            this.btnThemTG.Location = new System.Drawing.Point(612, 217);
            this.btnThemTG.Name = "btnThemTG";
            this.btnThemTG.Size = new System.Drawing.Size(75, 23);
            this.btnThemTG.TabIndex = 4;
            this.btnThemTG.Text = "Thêm";
            this.btnThemTG.UseVisualStyleBackColor = true;
            this.btnThemTG.Click += new System.EventHandler(this.btnThemTG_Click);
            // 
            // btnXoaTG
            // 
            this.btnXoaTG.Location = new System.Drawing.Point(693, 217);
            this.btnXoaTG.Name = "btnXoaTG";
            this.btnXoaTG.Size = new System.Drawing.Size(75, 23);
            this.btnXoaTG.TabIndex = 4;
            this.btnXoaTG.Text = "Xóa";
            this.btnXoaTG.UseVisualStyleBackColor = true;
            this.btnXoaTG.Click += new System.EventHandler(this.btnXoaTG_Click);
            // 
            // btnLuuTG
            // 
            this.btnLuuTG.Location = new System.Drawing.Point(693, 246);
            this.btnLuuTG.Name = "btnLuuTG";
            this.btnLuuTG.Size = new System.Drawing.Size(75, 23);
            this.btnLuuTG.TabIndex = 4;
            this.btnLuuTG.Text = "Lưu";
            this.btnLuuTG.UseVisualStyleBackColor = true;
            this.btnLuuTG.Click += new System.EventHandler(this.btnLuuTG_Click);
            // 
            // btnTKiemTG
            // 
            this.btnTKiemTG.Location = new System.Drawing.Point(488, 146);
            this.btnTKiemTG.Name = "btnTKiemTG";
            this.btnTKiemTG.Size = new System.Drawing.Size(75, 23);
            this.btnTKiemTG.TabIndex = 4;
            this.btnTKiemTG.Text = "Tìm kiếm";
            this.btnTKiemTG.UseVisualStyleBackColor = true;
            this.btnTKiemTG.Click += new System.EventHandler(this.btnTKiemTG_Click);
            // 
            // btnSuaTG
            // 
            this.btnSuaTG.Location = new System.Drawing.Point(612, 246);
            this.btnSuaTG.Name = "btnSuaTG";
            this.btnSuaTG.Size = new System.Drawing.Size(75, 23);
            this.btnSuaTG.TabIndex = 4;
            this.btnSuaTG.Text = "Sửa";
            this.btnSuaTG.UseVisualStyleBackColor = true;
            this.btnSuaTG.Click += new System.EventHandler(this.btnSuaTG_Click);
            // 
            // cbxTimKiemTG
            // 
            this.cbxTimKiemTG.FormattingEnabled = true;
            this.cbxTimKiemTG.Items.AddRange(new object[] {
            "MaTacGia",
            "TenTacGia",
            "DiaChiTG"});
            this.cbxTimKiemTG.Location = new System.Drawing.Point(406, 148);
            this.cbxTimKiemTG.Name = "cbxTimKiemTG";
            this.cbxTimKiemTG.Size = new System.Drawing.Size(76, 21);
            this.cbxTimKiemTG.TabIndex = 5;
            // 
            // btnThoatTG
            // 
            this.btnThoatTG.Location = new System.Drawing.Point(652, 275);
            this.btnThoatTG.Name = "btnThoatTG";
            this.btnThoatTG.Size = new System.Drawing.Size(75, 23);
            this.btnThoatTG.TabIndex = 4;
            this.btnThoatTG.Text = "Thoát";
            this.btnThoatTG.UseVisualStyleBackColor = true;
            this.btnThoatTG.Click += new System.EventHandler(this.btnThoatTG_Click);
            // 
            // TacGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(781, 342);
            this.Controls.Add(this.cbxTimKiemTG);
            this.Controls.Add(this.btnThoatTG);
            this.Controls.Add(this.btnSuaTG);
            this.Controls.Add(this.btnTKiemTG);
            this.Controls.Add(this.btnLuuTG);
            this.Controls.Add(this.btnXoaTG);
            this.Controls.Add(this.btnThemTG);
            this.Controls.Add(this.dgvDLTacGia);
            this.Controls.Add(this.txtMaTG);
            this.Controls.Add(this.txtDiaChiTG);
            this.Controls.Add(this.txtTKiemTG);
            this.Controls.Add(this.txtTenTG);
            this.Controls.Add(this.lblTieuDeTG);
            this.Controls.Add(this.lblDiaChiTG);
            this.Controls.Add(this.lblTenTG);
            this.Controls.Add(this.lblMaTG);
            this.Name = "TacGia";
            this.Text = "TacGia";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TacGia_FormClosing);
            this.Load += new System.EventHandler(this.TacGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDLTacGia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMaTG;
        private System.Windows.Forms.Label lblTenTG;
        private System.Windows.Forms.Label lblDiaChiTG;
        private System.Windows.Forms.Label lblTieuDeTG;
        private System.Windows.Forms.TextBox txtTenTG;
        private System.Windows.Forms.TextBox txtMaTG;
        private System.Windows.Forms.TextBox txtDiaChiTG;
        private System.Windows.Forms.DataGridView dgvDLTacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaTacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenTacGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
        private System.Windows.Forms.TextBox txtTKiemTG;
        private System.Windows.Forms.Button btnThemTG;
        private System.Windows.Forms.Button btnXoaTG;
        private System.Windows.Forms.Button btnLuuTG;
        private System.Windows.Forms.Button btnTKiemTG;
        private System.Windows.Forms.Button btnSuaTG;
        private System.Windows.Forms.ComboBox cbxTimKiemTG;
        private System.Windows.Forms.Button btnThoatTG;
    }
}