//Tran Trong Qui
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace project
{
    public partial class frmDangNhap : Form
    {
        public static frmDangNhap dangNhap = null;
        public static frmDangNhap tao()
        {
            //nếu form chưa được tạo hoặc đã bị đóng thì tạo mới
            if (dangNhap == null || dangNhap.IsDisposed)
                dangNhap = new frmDangNhap();
            //xóa hết textbox khi tạo form
            foreach (TextBox tb in dangNhap.pnLogin.Controls)
                tb.Text = "";
            //nằm trong form menu
            dangNhap.MdiParent = frmMenu.tao();
            return dangNhap;
        }
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void txtDangNhap_Click(object sender, EventArgs e)
        {
            //kiểm tra các textbox trống
            foreach (Control ctr in pnLogin.Controls)
            {
                if (ctr.Text.Trim() == "")
                {
                    MessageBox.Show("Không được để trống", "Lỗi đăng nhập");
                    return;
                }               
            }
            //lấy mật khẩu từ DB bằng tên tài khoản nhập vào
            string sql = "SELECT MATKHAU, IS_ADMINISTRATOR FROM NGUOIDUNG WHERE TAIKHOAN = '" + txtTenDangNhap.Text + "'";
            try
            {
                DataTable table = DB.tableTruyVan(sql);
                if(txtMatKhau.Text != table.Rows[0][0].ToString())
                {
                    MessageBox.Show("Sai mật khẩu");
                    return;                   
                }
                this.Hide();
                if (table.Rows[0][1].ToString() == "True")
                    frmMenu.login = 1;
                else
                    frmMenu.login = 0;
                frmMenu.taiKhoan = txtTenDangNhap.Text;
                this.Close();
                frmMenu.tao().Show();
            }
            catch
            {
                MessageBox.Show("Không tìm thấy tài khoản phù hợp");
                return;
            }
        }

        private void txtTenDangNhap_Leave(object sender, EventArgs e)
        {
            if (txtTenDangNhap.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(txtTenDangNhap, "Tên đăng nhập không được để trống");
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        private void txtMatKhau_Leave(object sender, EventArgs e)
        {
            if (txtMatKhau.Text.Trim().Length == 0)
            {
                errorProvider1.SetError(txtMatKhau, "Mật khẩu không được để trống");
            }
            else
            {
                errorProvider1.Clear();
            }
        }
    }
}