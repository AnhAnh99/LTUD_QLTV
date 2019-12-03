namespace LTUD_QLTV
{
    partial class LoaiSach
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
            this.btnThemLS = new System.Windows.Forms.Button();
            this.lblTenLS = new System.Windows.Forms.Label();
            this.lblTieuDeLS = new System.Windows.Forms.Label();
            this.lblMaLS = new System.Windows.Forms.Label();
            this.txtMaLS = new System.Windows.Forms.TextBox();
            this.txtTenLS = new System.Windows.Forms.TextBox();
            this.btnSuaLS = new System.Windows.Forms.Button();
            this.btnThoatLS = new System.Windows.Forms.Button();
            this.btnLuuLS = new System.Windows.Forms.Button();
            this.btnXoaLS = new System.Windows.Forms.Button();
            this.dgvDLLoaiSach = new System.Windows.Forms.DataGridView();
            this.MaLoaiSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenLoaiSach = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTKiemLS = new System.Windows.Forms.TextBox();
            this.cbxTKiemLS = new System.Windows.Forms.ComboBox();
            this.btnTKiemLS = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDLLoaiSach)).BeginInit();
            this.SuspendLayout();
            // 
            // btnThemLS
            // 
            this.btnThemLS.Location = new System.Drawing.Point(25, 154);
            this.btnThemLS.Name = "btnThemLS";
            this.btnThemLS.Size = new System.Drawing.Size(75, 23);
            this.btnThemLS.TabIndex = 0;
            this.btnThemLS.Text = "Thêm";
            this.btnThemLS.UseVisualStyleBackColor = true;
            this.btnThemLS.Click += new System.EventHandler(this.btnThemLS_Click);
            // 
            // lblTenLS
            // 
            this.lblTenLS.AutoSize = true;
            this.lblTenLS.Location = new System.Drawing.Point(22, 107);
            this.lblTenLS.Name = "lblTenLS";
            this.lblTenLS.Size = new System.Drawing.Size(71, 13);
            this.lblTenLS.TabIndex = 1;
            this.lblTenLS.Text = "Tên loại sách";
            // 
            // lblTieuDeLS
            // 
            this.lblTieuDeLS.AutoSize = true;
            this.lblTieuDeLS.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTieuDeLS.Location = new System.Drawing.Point(132, 9);
            this.lblTieuDeLS.Name = "lblTieuDeLS";
            this.lblTieuDeLS.Size = new System.Drawing.Size(225, 24);
            this.lblTieuDeLS.TabIndex = 1;
            this.lblTieuDeLS.Text = "QUẢN LÝ LOẠI SÁCH";
            // 
            // lblMaLS
            // 
            this.lblMaLS.AutoSize = true;
            this.lblMaLS.Location = new System.Drawing.Point(22, 75);
            this.lblMaLS.Name = "lblMaLS";
            this.lblMaLS.Size = new System.Drawing.Size(67, 13);
            this.lblMaLS.TabIndex = 1;
            this.lblMaLS.Text = "Mã loại sách";
            // 
            // txtMaLS
            // 
            this.txtMaLS.Location = new System.Drawing.Point(117, 68);
            this.txtMaLS.Name = "txtMaLS";
            this.txtMaLS.Size = new System.Drawing.Size(200, 20);
            this.txtMaLS.TabIndex = 2;
            // 
            // txtTenLS
            // 
            this.txtTenLS.Location = new System.Drawing.Point(117, 100);
            this.txtTenLS.Name = "txtTenLS";
            this.txtTenLS.Size = new System.Drawing.Size(200, 20);
            this.txtTenLS.TabIndex = 2;
            // 
            // btnSuaLS
            // 
            this.btnSuaLS.Location = new System.Drawing.Point(213, 154);
            this.btnSuaLS.Name = "btnSuaLS";
            this.btnSuaLS.Size = new System.Drawing.Size(75, 23);
            this.btnSuaLS.TabIndex = 0;
            this.btnSuaLS.Text = "Sửa";
            this.btnSuaLS.UseVisualStyleBackColor = true;
            this.btnSuaLS.Click += new System.EventHandler(this.btnSuaLS_Click);
            // 
            // btnThoatLS
            // 
            this.btnThoatLS.Location = new System.Drawing.Point(407, 154);
            this.btnThoatLS.Name = "btnThoatLS";
            this.btnThoatLS.Size = new System.Drawing.Size(75, 23);
            this.btnThoatLS.TabIndex = 3;
            this.btnThoatLS.Text = "Thoát";
            this.btnThoatLS.UseVisualStyleBackColor = true;
            this.btnThoatLS.Click += new System.EventHandler(this.btnThoatLS_Click);
            // 
            // btnLuuLS
            // 
            this.btnLuuLS.Location = new System.Drawing.Point(309, 154);
            this.btnLuuLS.Name = "btnLuuLS";
            this.btnLuuLS.Size = new System.Drawing.Size(75, 23);
            this.btnLuuLS.TabIndex = 4;
            this.btnLuuLS.Text = "Lưu";
            this.btnLuuLS.UseVisualStyleBackColor = true;
            this.btnLuuLS.Click += new System.EventHandler(this.btnLuuLS_Click);
            // 
            // btnXoaLS
            // 
            this.btnXoaLS.Location = new System.Drawing.Point(117, 154);
            this.btnXoaLS.Name = "btnXoaLS";
            this.btnXoaLS.Size = new System.Drawing.Size(75, 23);
            this.btnXoaLS.TabIndex = 5;
            this.btnXoaLS.Text = "Xóa";
            this.btnXoaLS.UseVisualStyleBackColor = true;
            this.btnXoaLS.Click += new System.EventHandler(this.btnXoaLS_Click);
            // 
            // dgvDLLoaiSach
            // 
            this.dgvDLLoaiSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDLLoaiSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLoaiSach,
            this.TenLoaiSach});
            this.dgvDLLoaiSach.Location = new System.Drawing.Point(31, 241);
            this.dgvDLLoaiSach.Name = "dgvDLLoaiSach";
            this.dgvDLLoaiSach.Size = new System.Drawing.Size(439, 205);
            this.dgvDLLoaiSach.TabIndex = 6;
            this.dgvDLLoaiSach.Click += new System.EventHandler(this.dgvDLLoaiSach_Click);
            // 
            // MaLoaiSach
            // 
            this.MaLoaiSach.DataPropertyName = "MaLoaiSach";
            this.MaLoaiSach.HeaderText = "Mã loại sách";
            this.MaLoaiSach.Name = "MaLoaiSach";
            this.MaLoaiSach.Width = 200;
            // 
            // TenLoaiSach
            // 
            this.TenLoaiSach.DataPropertyName = "TenLoaiSach";
            this.TenLoaiSach.HeaderText = "Tên loại sách";
            this.TenLoaiSach.Name = "TenLoaiSach";
            this.TenLoaiSach.Width = 200;
            // 
            // txtTKiemLS
            // 
            this.txtTKiemLS.Location = new System.Drawing.Point(96, 198);
            this.txtTKiemLS.Name = "txtTKiemLS";
            this.txtTKiemLS.Size = new System.Drawing.Size(200, 20);
            this.txtTKiemLS.TabIndex = 2;
            // 
            // cbxTKiemLS
            // 
            this.cbxTKiemLS.FormattingEnabled = true;
            this.cbxTKiemLS.Items.AddRange(new object[] {
            "MaLoaiSach",
            "TenLoaiSach"});
            this.cbxTKiemLS.Location = new System.Drawing.Point(309, 197);
            this.cbxTKiemLS.Name = "cbxTKiemLS";
            this.cbxTKiemLS.Size = new System.Drawing.Size(73, 21);
            this.cbxTKiemLS.TabIndex = 7;
            // 
            // btnTKiemLS
            // 
            this.btnTKiemLS.Location = new System.Drawing.Point(395, 195);
            this.btnTKiemLS.Name = "btnTKiemLS";
            this.btnTKiemLS.Size = new System.Drawing.Size(75, 23);
            this.btnTKiemLS.TabIndex = 0;
            this.btnTKiemLS.Text = "Tìm kiếm";
            this.btnTKiemLS.UseVisualStyleBackColor = true;
            this.btnTKiemLS.Click += new System.EventHandler(this.btnTKiemLS_Click);
            // 
            // LoaiSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(509, 458);
            this.Controls.Add(this.cbxTKiemLS);
            this.Controls.Add(this.dgvDLLoaiSach);
            this.Controls.Add(this.btnXoaLS);
            this.Controls.Add(this.btnLuuLS);
            this.Controls.Add(this.btnThoatLS);
            this.Controls.Add(this.txtTenLS);
            this.Controls.Add(this.txtTKiemLS);
            this.Controls.Add(this.txtMaLS);
            this.Controls.Add(this.lblTieuDeLS);
            this.Controls.Add(this.lblMaLS);
            this.Controls.Add(this.lblTenLS);
            this.Controls.Add(this.btnTKiemLS);
            this.Controls.Add(this.btnSuaLS);
            this.Controls.Add(this.btnThemLS);
            this.Name = "LoaiSach";
            this.Text = "LoaiSach";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoaiSach_FormClosing);
            this.Load += new System.EventHandler(this.LoaiSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDLLoaiSach)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnThemLS;
        private System.Windows.Forms.Label lblTenLS;
        private System.Windows.Forms.Label lblTieuDeLS;
        private System.Windows.Forms.Label lblMaLS;
        private System.Windows.Forms.TextBox txtMaLS;
        private System.Windows.Forms.TextBox txtTenLS;
        private System.Windows.Forms.Button btnSuaLS;
        private System.Windows.Forms.Button btnThoatLS;
        private System.Windows.Forms.Button btnLuuLS;
        private System.Windows.Forms.Button btnXoaLS;
        private System.Windows.Forms.DataGridView dgvDLLoaiSach;
        private System.Windows.Forms.TextBox txtTKiemLS;
        private System.Windows.Forms.ComboBox cbxTKiemLS;
        private System.Windows.Forms.Button btnTKiemLS;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLoaiSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenLoaiSach;
    }
}