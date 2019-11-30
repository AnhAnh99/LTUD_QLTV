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
    public partial class frmMuonSach : Form
    {
        connectDB conn = new connectDB();
        frmPhieuMuon pm = new frmPhieuMuon();
        public frmMuonSach()
        {
            InitializeComponent();        
        }

        private void btnThemChiTietHoaDon_Click(object sender, EventArgs e)
        {
            conn.themPM(txtMaPM.Text, txtMaBD.Text, txtTenBD.Text, txtMaSach.Text, txttenSach.Text, dtpNgayMuon.Text,dtpNgayTra.Text); //THÊM
            pm.loadPM();
            MessageBox.Show("Thêm thành công!");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMuonSach_FormClosing(object sender, FormClosingEventArgs e)
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
