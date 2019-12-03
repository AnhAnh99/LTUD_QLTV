namespace LTUD_QLTV
{
    partial class DangKy
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
            this.btnDangKy = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.lblTenTaiKhoan = new System.Windows.Forms.Label();
            this.lblMatKhauTK = new System.Windows.Forms.Label();
            this.txtTenTK = new System.Windows.Forms.TextBox();
            this.txtNhapLaiMK = new System.Windows.Forms.TextBox();
            this.lblNhapLaiMK = new System.Windows.Forms.Label();
            this.txtMatKhauTK = new System.Windows.Forms.TextBox();
            this.lblTDDăngKy = new System.Windows.Forms.Label();
            this.cbxHTMKhau = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnDangKy
            // 
            this.btnDangKy.Location = new System.Drawing.Point(81, 196);
            this.btnDangKy.Name = "btnDangKy";
            this.btnDangKy.Size = new System.Drawing.Size(75, 23);
            this.btnDangKy.TabIndex = 0;
            this.btnDangKy.Text = "Đăng ký";
            this.btnDangKy.UseVisualStyleBackColor = true;
            this.btnDangKy.Click += new System.EventHandler(this.btnDangKy_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(224, 196);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 0;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // lblTenTaiKhoan
            // 
            this.lblTenTaiKhoan.AutoSize = true;
            this.lblTenTaiKhoan.Location = new System.Drawing.Point(31, 52);
            this.lblTenTaiKhoan.Name = "lblTenTaiKhoan";
            this.lblTenTaiKhoan.Size = new System.Drawing.Size(73, 13);
            this.lblTenTaiKhoan.TabIndex = 1;
            this.lblTenTaiKhoan.Text = "Tên tài khoản";
            // 
            // lblMatKhauTK
            // 
            this.lblMatKhauTK.AutoSize = true;
            this.lblMatKhauTK.Location = new System.Drawing.Point(31, 100);
            this.lblMatKhauTK.Name = "lblMatKhauTK";
            this.lblMatKhauTK.Size = new System.Drawing.Size(52, 13);
            this.lblMatKhauTK.TabIndex = 1;
            this.lblMatKhauTK.Text = "Mật khẩu";
            // 
            // txtTenTK
            // 
            this.txtTenTK.Location = new System.Drawing.Point(143, 52);
            this.txtTenTK.Name = "txtTenTK";
            this.txtTenTK.Size = new System.Drawing.Size(181, 20);
            this.txtTenTK.TabIndex = 2;
            // 
            // txtNhapLaiMK
            // 
            this.txtNhapLaiMK.Location = new System.Drawing.Point(143, 140);
            this.txtNhapLaiMK.Name = "txtNhapLaiMK";
            this.txtNhapLaiMK.Size = new System.Drawing.Size(181, 20);
            this.txtNhapLaiMK.TabIndex = 2;
            // 
            // lblNhapLaiMK
            // 
            this.lblNhapLaiMK.AutoSize = true;
            this.lblNhapLaiMK.Location = new System.Drawing.Point(31, 140);
            this.lblNhapLaiMK.Name = "lblNhapLaiMK";
            this.lblNhapLaiMK.Size = new System.Drawing.Size(93, 13);
            this.lblNhapLaiMK.TabIndex = 1;
            this.lblNhapLaiMK.Text = "Nhập lại mật khẩu";
            // 
            // txtMatKhauTK
            // 
            this.txtMatKhauTK.Location = new System.Drawing.Point(143, 97);
            this.txtMatKhauTK.Name = "txtMatKhauTK";
            this.txtMatKhauTK.Size = new System.Drawing.Size(181, 20);
            this.txtMatKhauTK.TabIndex = 2;
            // 
            // lblTDDăngKy
            // 
            this.lblTDDăngKy.AutoSize = true;
            this.lblTDDăngKy.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTDDăngKy.Location = new System.Drawing.Point(77, 9);
            this.lblTDDăngKy.Name = "lblTDDăngKy";
            this.lblTDDăngKy.Size = new System.Drawing.Size(232, 24);
            this.lblTDDăngKy.TabIndex = 1;
            this.lblTDDăngKy.Text = "ĐĂNG KÝ TÀI KHOẢN";
            // 
            // cbxHTMKhau
            // 
            this.cbxHTMKhau.AutoSize = true;
            this.cbxHTMKhau.Location = new System.Drawing.Point(219, 173);
            this.cbxHTMKhau.Name = "cbxHTMKhau";
            this.cbxHTMKhau.Size = new System.Drawing.Size(109, 17);
            this.cbxHTMKhau.TabIndex = 3;
            this.cbxHTMKhau.Text = "Hiện thị mật khẩu";
            this.cbxHTMKhau.UseVisualStyleBackColor = true;
            this.cbxHTMKhau.CheckedChanged += new System.EventHandler(this.cbxHTMKhau_CheckedChanged);
            // 
            // DangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(402, 259);
            this.Controls.Add(this.cbxHTMKhau);
            this.Controls.Add(this.txtMatKhauTK);
            this.Controls.Add(this.txtNhapLaiMK);
            this.Controls.Add(this.txtTenTK);
            this.Controls.Add(this.lblNhapLaiMK);
            this.Controls.Add(this.lblMatKhauTK);
            this.Controls.Add(this.lblTDDăngKy);
            this.Controls.Add(this.lblTenTaiKhoan);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnDangKy);
            this.Name = "DangKy";
            this.Text = "DangKy";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DangKy_FormClosing);
            this.Load += new System.EventHandler(this.DangKy_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDangKy;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label lblTenTaiKhoan;
        private System.Windows.Forms.Label lblMatKhauTK;
        private System.Windows.Forms.TextBox txtTenTK;
        private System.Windows.Forms.TextBox txtNhapLaiMK;
        private System.Windows.Forms.Label lblNhapLaiMK;
        private System.Windows.Forms.TextBox txtMatKhauTK;
        private System.Windows.Forms.Label lblTDDăngKy;
        private System.Windows.Forms.CheckBox cbxHTMKhau;
    }
}