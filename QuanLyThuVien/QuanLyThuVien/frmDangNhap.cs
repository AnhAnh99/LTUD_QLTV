using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class frmDangNhap : Form
    {
        connectDB conn = new connectDB();
        public frmDangNhap()
        {
            InitializeComponent();
            txtMatKhau.PasswordChar = '*';
        }
        public bool checkInput()
        {
            if (string.IsNullOrWhiteSpace(txtTenDangNhap.Text))
            {
                MessageBox.Show("Bạn chưa nhập tên người dùng", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenDangNhap.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtMatKhau.Text))
            {
                MessageBox.Show("Bạn chưa nhập mật khẩu", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatKhau.Focus();
                return false;
            }

            return true;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (checkInput())
            {
                DataTable listNhanVien = conn.loadNhanVien();
                foreach (DataRow row in listNhanVien.Rows)
                {
                    string ma = row["MaNhanVien"].ToString().ToUpper();

                    if (txtTenDangNhap.Text.ToUpper().Equals(ma)
                        && txtMatKhau.Text.ToUpper().Equals(ma))
                    {
                        this.Hide();
                        string tenNhanVien = row["TenNhanVien"].ToString();
                        frmMain main = new frmMain();
                        main.ShowDialog();
                    }
                }

                lblMessage.Visible = true;
                lblMessage.Text = "Bạn nhập sai tên người dùng hoặc mật khẩu";
            }
        }

        private void frmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r =
               MessageBox.Show("Bạn có muốn thoát?", "Thông báo",
               MessageBoxButtons.YesNo,
               MessageBoxIcon.Question,
               MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
