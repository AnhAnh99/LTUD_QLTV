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
    public partial class DangNhap : Form
    {
        KetNoiDatabase kn = new KetNoiDatabase();
        public DangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            kn.dangNhap(txtTenDN.Text, txtMatKhauDN.Text);
            
        }

        private void cbkHienThiMK_CheckedChanged(object sender, EventArgs e)
        {
            if(cbkHienThiMK.Checked)
            {
                txtTenDN.PasswordChar = '\0';
                txtMatKhauDN.PasswordChar = '\0';
            }
            else
            {
                txtTenDN.PasswordChar = '\0';
                txtMatKhauDN.PasswordChar = '*';
            }
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            txtMatKhauDN.PasswordChar = '*';
           
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DangNhap_FormClosing(object sender, FormClosingEventArgs e)
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
