using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace LTUD_QLTV
{
    public partial class DangKy : Form
    {
        KetNoiDatabase kn = new KetNoiDatabase();
        public DangKy()
        {
            InitializeComponent();

        }


        private void cbkHienThiMK_CheckedChanged(object sender, EventArgs e)
        {
           
        }
       
        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (txtTenTK.Text.Trim() != "")
            {
                
                    kn.addTaiKhoan(txtTenTK.Text, txtMatKhauTK.Text, txtNhapLaiMK.Text); //THÊM
                    MessageBox.Show("Đăng ký thành công!"); //THONG BÁO - NÚT
                  

                
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbxHTMKhau_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxHTMKhau.Checked)
            {

                txtMatKhauTK.PasswordChar = '\0';
                txtNhapLaiMK.PasswordChar = '\0';
            }
            else
            {

                txtMatKhauTK.PasswordChar = '*';
                txtNhapLaiMK.PasswordChar = '*';
            }
        }

        private void DangKy_Load(object sender, EventArgs e)
        {
            txtMatKhauTK.PasswordChar = '*';
            txtNhapLaiMK.PasswordChar = '*';
        }

        private void DangKy_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r =
                MessageBox.Show("Bạn có muốn thoát?", "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }
    }
}
