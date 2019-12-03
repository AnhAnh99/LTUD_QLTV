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
    public partial class GiaoDien : Form
    {
        public GiaoDien()
        {
            InitializeComponent();
        }
  
        private void dangKyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DangKy dangKy = new DangKy();
            dangKy.ShowDialog();
            dangKy.Close();
        }

        private void loaiSachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoaiSach loaiSach = new LoaiSach();
            loaiSach.ShowDialog();
            loaiSach.Close();
        }

        private void muonSachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyMuonSach quanLyMuonSach = new QuanLyMuonSach();
            quanLyMuonSach.ShowDialog();
            quanLyMuonSach.Close();
        }

        private void nhanVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLyNhanVien quanLyNhanVien = new QuanLyNhanVien();
            quanLyNhanVien.ShowDialog();
            quanLyNhanVien.Close();
        }

        private void sachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuanLySach quanLySach = new QuanLySach();
            quanLySach.ShowDialog();
            quanLySach.Close();

        }

        private void tacGiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TacGia tacGia = new TacGia();
            tacGia.ShowDialog();
            tacGia.Close();
        }

        private void theKhachHangoolStripMenuItem_Click(object sender, EventArgs e)
        {

            TheKhachHang theKhachHang = new TheKhachHang();
            theKhachHang.ShowDialog();
            theKhachHang.Close();
        }

        private void traSachToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TraSach traSach = new TraSach();
            traSach.ShowDialog();
            traSach.Close();
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void GiaoDien_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r =
                MessageBox.Show("Bạn có muốn thoát?", "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void GiaoDien_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

     
    }
}
