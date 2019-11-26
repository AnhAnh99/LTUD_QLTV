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
    public partial class BanDoc : Form
    {
        connectDB conn = new connectDB();
        public BanDoc()
        {
            InitializeComponent();
        }
        private void loadBanDoc()
        {
            conn.loadBD(this.dvgBanDoc);
        }

        private void BanDoc_Load(object sender, EventArgs e)
        {
            loadBanDoc();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            conn.themBD(txtMaBanDoc.Text, txtTenBanDoc.Text, txtDiaChi.Text, txtSoDienThoai.Text, dtpNgayMuon.Text, dtpNgayHetHan.Text); //THÊM
            loadBanDoc();
            MessageBox.Show("Thêm thành công!");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            conn.suaBD(txtMaBanDoc.Text, txtTenBanDoc.Text, txtDiaChi.Text, txtSoDienThoai.Text, dtpNgayMuon.Text, dtpNgayHetHan.Text);
            loadBanDoc();
            MessageBox.Show("Sửa thành công!");
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa " + txtMaBanDoc.Text + " ?", "Thông báo",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                conn.xoaBD(txtMaBanDoc.Text);
                loadBanDoc();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            conn.timKiemBD(txtMaBanDoc.Text);
            loadBanDoc();
        }
    }
}
