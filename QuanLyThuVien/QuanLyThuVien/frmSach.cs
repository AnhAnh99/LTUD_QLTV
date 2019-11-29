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
    public partial class frmSach : Form
    {
        connectDB conn = new connectDB();
        public frmSach()
        {
            InitializeComponent();
        }

        private void loadSach()
        {
            conn.loadSachTV(this.dvgSach);
        }

        private void frmSach_Load(object sender, EventArgs e)
        {
            loadSach();
        }

        OpenFileDialog ofd = new OpenFileDialog();
        private void btnOpen_Click(object sender, EventArgs e)
        {
            ofd.Title = "Open Ịmage";
            ofd.InitialDirectory = @"C:\";
            ofd.Filter = "Image|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                picAnh.Image = Image.FromFile(ofd.FileName);
            }
            txtAnh.Text = Convert.ToString(ofd.FileName);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            conn.themSach(txtMa.Text, txtTen.Text, txtTacGia.Text, cbbLoai.Text, txtAnh.Text); //THÊM
            resetText();
            loadSach();
            MessageBox.Show("Thêm thành công!");
        }
        public void resetText()
        {
            txtMa.ResetText();
            txtTen.ResetText();
            txtTacGia.ResetText();
            cbbLoai.ResetText();
            txtAnh.ResetText();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa " + txtMa.Text + " ?", "Thông báo",
              MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                conn.xoaSach(txtMa.Text);
                resetText();
                loadSach();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            conn.suaSach(txtMa.Text, txtTen.Text, txtTacGia.Text, cbbLoai.Text, txtAnh.Text); //THÊM
            resetText();
            loadSach();
            MessageBox.Show("Sửa thành công!");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSach_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r =
                MessageBox.Show("Bạn có muốn thoát?", "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void dvgSach_Click(object sender, EventArgs e)
        {
            txtMa.Text = dvgSach.CurrentRow.Cells[0].Value.ToString();
            txtTen.Text = dvgSach.CurrentRow.Cells[1].Value.ToString();
            txtTacGia.Text = dvgSach.CurrentRow.Cells[2].Value.ToString();
            cbbLoai.Text = dvgSach.CurrentRow.Cells[4].Value.ToString();
            txtAnh.Text = dvgSach.CurrentRow.Cells[3].Value.ToString();

        }
    }
}
