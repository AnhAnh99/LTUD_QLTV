namespace project
{
    partial class frmDSPN
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtID_PhieuNhap = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pn = new System.Windows.Forms.Panel();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnQuayLai = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.pnTxt2 = new System.Windows.Forms.Panel();
            this.cbTEN_SANPHAM = new System.Windows.Forms.ComboBox();
            this.txtID_SANPHAM = new System.Windows.Forms.TextBox();
            this.txtID_CTPN = new System.Windows.Forms.TextBox();
            this.txtDONGIA = new System.Windows.Forms.TextBox();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pnTxt = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pn.SuspendLayout();
            this.pnTxt2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.pnTxt.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(330, 256);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dataGridView1_RowStateChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(354, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID_PHIEUNHAP";
            // 
            // txtID_PhieuNhap
            // 
            this.txtID_PhieuNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID_PhieuNhap.Location = new System.Drawing.Point(3, 3);
            this.txtID_PhieuNhap.Name = "txtID_PhieuNhap";
            this.txtID_PhieuNhap.Size = new System.Drawing.Size(251, 26);
            this.txtID_PhieuNhap.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(354, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "NGAYNHAP";
            // 
            // pn
            // 
            this.pn.Controls.Add(this.btnThem);
            this.pn.Controls.Add(this.btnSua);
            this.pn.Controls.Add(this.btnXoa);
            this.pn.Location = new System.Drawing.Point(437, 450);
            this.pn.Name = "pn";
            this.pn.Size = new System.Drawing.Size(351, 49);
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
            this.btnQuayLai.Location = new System.Drawing.Point(473, 542);
            this.btnQuayLai.Name = "btnQuayLai";
            this.btnQuayLai.Size = new System.Drawing.Size(101, 29);
            this.btnQuayLai.TabIndex = 19;
            this.btnQuayLai.Text = "Quay lại";
            this.btnQuayLai.UseVisualStyleBackColor = true;
            this.btnQuayLai.Click += new System.EventHandler(this.btnQuayLai_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(633, 542);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(101, 29);
            this.btnThoat.TabIndex = 21;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // pnTxt2
            // 
            this.pnTxt2.Controls.Add(this.cbTEN_SANPHAM);
            this.pnTxt2.Controls.Add(this.txtID_SANPHAM);
            this.pnTxt2.Controls.Add(this.txtID_CTPN);
            this.pnTxt2.Controls.Add(this.txtDONGIA);
            this.pnTxt2.Controls.Add(this.txtSL);
            this.pnTxt2.Location = new System.Drawing.Point(554, 155);
            this.pnTxt2.Name = "pnTxt2";
            this.pnTxt2.Size = new System.Drawing.Size(180, 200);
            this.pnTxt2.TabIndex = 37;
            // 
            // cbTEN_SANPHAM
            // 
            this.cbTEN_SANPHAM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTEN_SANPHAM.FormattingEnabled = true;
            this.cbTEN_SANPHAM.Location = new System.Drawing.Point(3, 85);
            this.cbTEN_SANPHAM.Name = "cbTEN_SANPHAM";
            this.cbTEN_SANPHAM.Size = new System.Drawing.Size(171, 21);
            this.cbTEN_SANPHAM.TabIndex = 32;
            this.cbTEN_SANPHAM.SelectedIndexChanged += new System.EventHandler(this.cbTEN_SANPHAM_SelectedIndexChanged);
            // 
            // txtID_SANPHAM
            // 
            this.txtID_SANPHAM.Location = new System.Drawing.Point(3, 43);
            this.txtID_SANPHAM.Name = "txtID_SANPHAM";
            this.txtID_SANPHAM.ReadOnly = true;
            this.txtID_SANPHAM.Size = new System.Drawing.Size(171, 20);
            this.txtID_SANPHAM.TabIndex = 31;
            // 
            // txtID_CTPN
            // 
            this.txtID_CTPN.Location = new System.Drawing.Point(3, 3);
            this.txtID_CTPN.Name = "txtID_CTPN";
            this.txtID_CTPN.ReadOnly = true;
            this.txtID_CTPN.Size = new System.Drawing.Size(171, 20);
            this.txtID_CTPN.TabIndex = 30;
            // 
            // txtDONGIA
            // 
            this.txtDONGIA.Location = new System.Drawing.Point(3, 128);
            this.txtDONGIA.Name = "txtDONGIA";
            this.txtDONGIA.ReadOnly = true;
            this.txtDONGIA.Size = new System.Drawing.Size(174, 20);
            this.txtDONGIA.TabIndex = 30;
            // 
            // txtSL
            // 
            this.txtSL.Location = new System.Drawing.Point(3, 169);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(171, 20);
            this.txtSL.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(466, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "DONGIA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(466, 327);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 35;
            this.label2.Text = "SL";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(461, 243);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "TEN_SANPHAM";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(460, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "ID_SANPHAM";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(460, 167);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(53, 13);
            this.label.TabIndex = 34;
            this.label.Text = "ID_CTPN";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 286);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(330, 285);
            this.dataGridView2.TabIndex = 38;
            this.dataGridView2.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dataGridView2_RowStateChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "d/M/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(511, 89);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(251, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // pnTxt
            // 
            this.pnTxt.Controls.Add(this.txtID_PhieuNhap);
            this.pnTxt.Location = new System.Drawing.Point(508, 22);
            this.pnTxt.Name = "pnTxt";
            this.pnTxt.Size = new System.Drawing.Size(260, 42);
            this.pnTxt.TabIndex = 26;
            // 
            // frmDSPN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 605);
            this.ControlBox = false;
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.pnTxt2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label);
            this.Controls.Add(this.pnTxt);
            this.Controls.Add(this.pn);
            this.Controls.Add(this.btnQuayLai);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmDSPN";
            this.Text = "frmDSPN";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDSPN_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pn.ResumeLayout(false);
            this.pnTxt2.ResumeLayout(false);
            this.pnTxt2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.pnTxt.ResumeLayout(false);
            this.pnTxt.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtID_PhieuNhap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pn;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnQuayLai;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Panel pnTxt2;
        private System.Windows.Forms.TextBox txtID_CTPN;
        private System.Windows.Forms.TextBox txtDONGIA;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.ComboBox cbTEN_SANPHAM;
        private System.Windows.Forms.TextBox txtID_SANPHAM;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel pnTxt;
    }
}