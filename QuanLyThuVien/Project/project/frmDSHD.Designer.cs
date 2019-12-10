namespace project
{
    partial class frmDSHD
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtID_HoaDon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtID_KhachHang = new System.Windows.Forms.TextBox();
            this.pn = new System.Windows.Forms.Panel();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.pnTxt = new System.Windows.Forms.Panel();
            this.cbTEN_KHACHHANG = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pnTxt2 = new System.Windows.Forms.Panel();
            this.cbTEN_SANPHAM = new System.Windows.Forms.ComboBox();
            this.txtID_CTHD = new System.Windows.Forms.TextBox();
            this.txtDONGIA = new System.Windows.Forms.TextBox();
            this.txtID_SANPHAM = new System.Windows.Forms.TextBox();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.btnIn = new System.Windows.Forms.Button();
            this.pn.SuspendLayout();
            this.pnTxt.SuspendLayout();
            this.pnTxt2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(368, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "ID_HOADON";
            // 
            // txtID_HoaDon
            // 
            this.txtID_HoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID_HoaDon.Location = new System.Drawing.Point(3, 4);
            this.txtID_HoaDon.Name = "txtID_HoaDon";
            this.txtID_HoaDon.Size = new System.Drawing.Size(256, 26);
            this.txtID_HoaDon.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(368, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "ID_KHACHHANG";
            // 
            // txtID_KhachHang
            // 
            this.txtID_KhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID_KhachHang.Location = new System.Drawing.Point(3, 48);
            this.txtID_KhachHang.Name = "txtID_KhachHang";
            this.txtID_KhachHang.ReadOnly = true;
            this.txtID_KhachHang.Size = new System.Drawing.Size(256, 26);
            this.txtID_KhachHang.TabIndex = 15;
            // 
            // pn
            // 
            this.pn.Controls.Add(this.btnThem);
            this.pn.Controls.Add(this.btnSua);
            this.pn.Controls.Add(this.btnXoa);
            this.pn.Location = new System.Drawing.Point(469, 447);
            this.pn.Name = "pn";
            this.pn.Size = new System.Drawing.Size(351, 41);
            this.pn.TabIndex = 25;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(5, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(101, 29);
            this.btnThem.TabIndex = 20;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(247, 3);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(101, 29);
            this.btnSua.TabIndex = 22;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(127, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(101, 29);
            this.btnXoa.TabIndex = 23;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnQuayLai
            // 
            this.btnQuayLai.Location = new System.Drawing.Point(509, 533);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(101, 29);
            this.btnQuayLai.TabIndex = 19;
            this.btnQuayLai.Text = "Quay lại";
            this.btnQuayLai.UseVisualStyleBackColor = true;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(671, 533);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(101, 29);
            this.btnThoat.TabIndex = 21;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // pnTxt
            // 
            this.pnTxt.Controls.Add(this.cbTEN_KHACHHANG);
            this.pnTxt.Controls.Add(this.txtID_HoaDon);
            this.pnTxt.Controls.Add(this.txtID_KhachHang);
            this.pnTxt.Location = new System.Drawing.Point(526, 12);
            this.pnTxt.Name = "pnTxt";
            this.pnTxt.Size = new System.Drawing.Size(265, 127);
            this.pnTxt.TabIndex = 26;
            // 
            // cbTEN_KHACHHANG
            // 
            this.cbTEN_KHACHHANG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTEN_KHACHHANG.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTEN_KHACHHANG.FormattingEnabled = true;
            this.cbTEN_KHACHHANG.Location = new System.Drawing.Point(3, 94);
            this.cbTEN_KHACHHANG.Name = "cbTEN_KHACHHANG";
            this.cbTEN_KHACHHANG.Size = new System.Drawing.Size(256, 28);
            this.cbTEN_KHACHHANG.TabIndex = 32;
            this.cbTEN_KHACHHANG.SelectedIndexChanged += new System.EventHandler(this.cbTEN_KHACHHANG_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(368, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "TEN_KHACHHANG";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(368, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "NGAYMUA";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(529, 151);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(256, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // pnTxt2
            // 
            this.pnTxt2.Controls.Add(this.cbTEN_SANPHAM);
            this.pnTxt2.Controls.Add(this.txtID_CTHD);
            this.pnTxt2.Controls.Add(this.txtDONGIA);
            this.pnTxt2.Controls.Add(this.txtID_SANPHAM);
            this.pnTxt2.Controls.Add(this.txtSL);
            this.pnTxt2.Location = new System.Drawing.Point(574, 189);
            this.pnTxt2.Name = "pnTxt2";
            this.pnTxt2.Size = new System.Drawing.Size(180, 195);
            this.pnTxt2.TabIndex = 63;
            // 
            // cbTEN_SANPHAM
            // 
            this.cbTEN_SANPHAM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTEN_SANPHAM.FormattingEnabled = true;
            this.cbTEN_SANPHAM.Location = new System.Drawing.Point(3, 88);
            this.cbTEN_SANPHAM.Name = "cbTEN_SANPHAM";
            this.cbTEN_SANPHAM.Size = new System.Drawing.Size(171, 21);
            this.cbTEN_SANPHAM.TabIndex = 32;
            this.cbTEN_SANPHAM.SelectedIndexChanged += new System.EventHandler(this.cbTEN_SANPHAM_SelectedIndexChanged);
            // 
            // txtID_CTHD
            // 
            this.txtID_CTHD.Location = new System.Drawing.Point(3, 3);
            this.txtID_CTHD.Name = "txtID_CTHD";
            this.txtID_CTHD.Size = new System.Drawing.Size(171, 20);
            this.txtID_CTHD.TabIndex = 30;
            // 
            // txtDONGIA
            // 
            this.txtDONGIA.Location = new System.Drawing.Point(3, 130);
            this.txtDONGIA.Name = "txtDONGIA";
            this.txtDONGIA.ReadOnly = true;
            this.txtDONGIA.Size = new System.Drawing.Size(171, 20);
            this.txtDONGIA.TabIndex = 30;
            // 
            // txtID_SANPHAM
            // 
            this.txtID_SANPHAM.Location = new System.Drawing.Point(3, 48);
            this.txtID_SANPHAM.Name = "txtID_SANPHAM";
            this.txtID_SANPHAM.ReadOnly = true;
            this.txtID_SANPHAM.Size = new System.Drawing.Size(171, 20);
            this.txtID_SANPHAM.TabIndex = 30;
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(3, 167);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(171, 20);
            this.txtSL.TabIndex = 30;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(479, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 60;
            this.label5.Text = "DONGIA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(479, 359);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 61;
            this.label6.Text = "SL";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(479, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 62;
            this.label7.Text = "TEN_SANPHAM";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(479, 240);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 13);
            this.label8.TabIndex = 58;
            this.label8.Text = "ID_SANPHAM";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(479, 201);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(54, 13);
            this.label.TabIndex = 59;
            this.label.Text = "ID_CTHD";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(2, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(330, 256);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dataGridView1_RowStateChanged);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(2, 287);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(330, 285);
            this.dataGridView2.TabIndex = 38;
            this.dataGridView2.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dataGridView2_RowStateChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(414, 401);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(142, 31);
            this.label9.TabIndex = 61;
            this.label9.Text = "Thành tiền";
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThanhTien.Location = new System.Drawing.Point(577, 398);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.ReadOnly = true;
            this.txtThanhTien.Size = new System.Drawing.Size(171, 38);
            this.txtThanhTien.TabIndex = 30;
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(754, 403);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(54, 29);
            this.btnIn.TabIndex = 64;
            this.btnIn.Text = "In";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // frmDSHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 600);
            this.ControlBox = false;
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.pnTxt2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtThanhTien);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.pnTxt);
            this.Controls.Add(this.pn);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmDSHD";
            this.Text = "frmDSHD";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDSHD_FormClosing);
            this.pn.ResumeLayout(false);
            this.pnTxt.ResumeLayout(false);
            this.pnTxt.PerformLayout();
            this.pnTxt2.ResumeLayout(false);
            this.pnTxt2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID_HoaDon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtID_KhachHang;
        private System.Windows.Forms.Panel pn;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Panel pnTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel pnTxt2;
        private System.Windows.Forms.TextBox txtID_CTHD;
        private System.Windows.Forms.TextBox txtDONGIA;
        private System.Windows.Forms.TextBox txtID_SANPHAM;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ComboBox cbTEN_SANPHAM;
        private System.Windows.Forms.ComboBox cbTEN_KHACHHANG;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnIn;
    }
}