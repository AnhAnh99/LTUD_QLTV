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
    public partial class frmMenu : Form
    {
        public static string taiKhoan = "";
        public static int login = -1;
        private static frmMenu menu = null;
        //nếu form chưa được tạo hoặc đã bị đóng thì tạo mới
        public static frmMenu tao()
        {
            if (menu == null || menu.IsDisposed)
                menu = new frmMenu();
            //phân quyền
            switch (login)
            {
                case 0:
                    menu.menuStrip1.Items[1].Enabled = true;
                    menu.menuStrip1.Items[2].Enabled = false;
                    menu.dangNhapToolStripMenuItem.Visible = false;
                    menu.dangXuatToolStripMenuItem.Visible = true;
                    menu.heThongToolStripMenuItem.Text = taiKhoan;
                    break;
                case 1:
                    menu.menuStrip1.Items[1].Enabled = false;
                    menu.menuStrip1.Items[2].Enabled = true;
                    menu.dangNhapToolStripMenuItem.Visible = false;
                    menu.dangXuatToolStripMenuItem.Visible = true;
                    menu.heThongToolStripMenuItem.Text = taiKhoan;
                    break;
                default:
                    menu.menuStrip1.Items[1].Enabled = false;
                    menu.menuStrip1.Items[2].Enabled = false;
                    menu.dangNhapToolStripMenuItem.Visible = true;
                    menu.dangXuatToolStripMenuItem.Visible = false;
                    menu.heThongToolStripMenuItem.Text = "Hệ thống";
                    break;
            }
            return menu;
        }
        public frmMenu()
        {
            InitializeComponent();
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát?", "Cảnh báo thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                Close();
        }

        private void đangNhapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDangNhap.tao().Show();
        }

        private void dangXuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn đăng xuất?", "Cảnh báo đăng xuất", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                login = -1;
                frmMenu.tao().Show();
            }
        }

        private void sanPhamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDSSP.login = 0;
            frmDSSP.tao().Show();
        }

        private void sanPhamToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmDSSP.login = 0;
            frmDSSP.tao().Show();
        }

        private void sảnPhẩmToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmDSSP.login = 1;
            frmDSSP.tao().Show();
        }

        private void khachHangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDSKH.login = 0;
            frmDSKH.tao().Show();
        }

        private void khachHangToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmDSKH.login = 0;
            frmDSKH.tao().Show();
        }

        private void kháchHàngToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmDSKH.login = 1;
            frmDSKH.tao().Show();
        }

        private void phieuNhapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDSPN.login = 0;
            frmDSPN.tao().Show();
        }

        private void phiếuNhậpToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmDSPN.login = 1;
            frmDSPN.tao().Show();
        }

        private void phieuXuatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDSPX.login = 0;
            frmDSPX.tao().Show();
        }

        private void phiếuXuấtToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmDSPX.login = 1;
            frmDSPX.tao().Show();
        }

        private void hoaĐonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDSHD.login = 0;
            frmDSHD.tao().Show();
        }

        private void hoaĐonToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmDSHD.login = 0;
            frmDSHD.tao().Show();
        }

        private void hóaĐơnToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmDSHD.login = 1;
            frmDSHD.tao().Show();
        }

        private void taoHoaDonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDSHD.login = 3;
            frmDSHD.tao().Show();
        }
    }
}
