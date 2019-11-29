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
            resetText();
            loadBanDoc();
            MessageBox.Show("Thêm thành công!");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            conn.suaBD(txtMaBanDoc.Text, txtTenBanDoc.Text, txtDiaChi.Text, txtSoDienThoai.Text, dtpNgayMuon.Text, dtpNgayHetHan.Text);
            resetText();
            loadBanDoc();
            MessageBox.Show("Sửa thành công!");
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa " + txtMaBanDoc.Text + " ?", "Thông báo",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                conn.xoaBD(txtMaBanDoc.Text);
                resetText();
                loadBanDoc();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string ma = txtMaBanDoc.Text;
            string ten = txtTenBanDoc.Text = string.Empty;
            string sdt = txtSoDienThoai.Text = string.Empty;
            string dc = txtDiaChi.Text = string.Empty;
            string ngaymuon = dtpNgayMuon.Text = string.Empty;
            string ngaytra = dtpNgayHetHan.Text = string.Empty;
            if (ma != string.Empty)
            {
                dvgBanDoc.DataSource = conn.timKiemBD(txtMaBanDoc.Text);
                resetText();
            }
            else
            {
                MessageBox.Show("Phải nhập dữ liệu trước khi tìm kiếm!");
            }
        }

        private void BanDoc_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r =
                MessageBox.Show("Bạn có muốn thoát?", "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }
        public void resetText()
        {
            txtMaBanDoc.ResetText();
            txtTenBanDoc.ResetText();
            txtDiaChi.ResetText();
            dtpNgayMuon.ResetText();
            dtpNgayHetHan.ResetText();
            txtSoDienThoai.ResetText();           
        }

        private void dvgBanDoc_Click(object sender, EventArgs e)
        {
            txtMaBanDoc.Text = dvgBanDoc.CurrentRow.Cells[0].Value.ToString();
            txtTenBanDoc.Text = dvgBanDoc.CurrentRow.Cells[1].Value.ToString();
            txtSoDienThoai.Text = dvgBanDoc.CurrentRow.Cells[2].Value.ToString();
            txtDiaChi.Text = dvgBanDoc.CurrentRow.Cells[3].Value.ToString();
            dtpNgayMuon.Text = dvgBanDoc.CurrentRow.Cells[4].Value.ToString();
            dtpNgayHetHan.Text = dvgBanDoc.CurrentRow.Cells[5].Value.ToString();
           
        }
    }
}
