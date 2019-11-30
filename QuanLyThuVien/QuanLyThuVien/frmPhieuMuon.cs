using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class frmPhieuMuon : Form
    {
        connectDB conn = new connectDB();
        public frmPhieuMuon()
        {
            InitializeComponent();
        }
        public void loadPM()
        {
            conn.loadPM(this.dgvPM);
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            frmMuonSach ms = new frmMuonSach();
            ms.ShowDialog();
        }

        private void frmPhieuMuon_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r =
                MessageBox.Show("Bạn có muốn thoát?", "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void frmPhieuMuon_Load(object sender, EventArgs e)
        {
            loadPM();
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {
            conn.themPM(txtMaPM.Text, txtMaBD.Text, txtTenBD.Text, txtMaSach.Text, txttenSach.Text, dtpNgayMuon.Text, dtpNgayTra.Text); //THÊM
            loadPM();
            resetText();
            MessageBox.Show("Thêm thành công!");
        }
        public void resetText()
        {
            txtMaBD.ResetText();
            txtMaPM.ResetText();
            txtMaSach.ResetText();
            txtTenBD.ResetText();
            txttenSach.ResetText();
            txtNhanVien.ResetText();
            dtpNgayTra.ResetText();
            dtpNgayMuon.ResetText();
        }

        private void dgvPM_Click(object sender, EventArgs e)
        {
            txtMaPM.Text = dgvPM.CurrentRow.Cells[0].Value.ToString();
            txtMaSach.Text = dgvPM.CurrentRow.Cells[3].Value.ToString();
            txttenSach.Text = dgvPM.CurrentRow.Cells[4].Value.ToString();
            txtMaBD.Text = dgvPM.CurrentRow.Cells[1].Value.ToString();
            txtTenBD.Text = dgvPM.CurrentRow.Cells[2].Value.ToString();
            dtpNgayMuon.Text = dgvPM.CurrentRow.Cells[6].Value.ToString();
            dtpNgayTra.Text = dgvPM.CurrentRow.Cells[5].Value.ToString();


        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            conn.suaPM(txtMaPM.Text, txtMaBD.Text, txtTenBD.Text, txtMaSach.Text, txttenSach.Text, dtpNgayMuon.Text, dtpNgayTra.Text); //THÊM
            resetText();
            loadPM();
            MessageBox.Show("Sửa thành công!");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa " + txtMaPM.Text + " ?", "Thông báo",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                conn.xoaBD(txtMaPM.Text);
                resetText();
                loadPM();
            }
        }

        private void btnInHoaDon_Click(object sender, EventArgs e)
        {
            try
            {
               
                if (txtMaPM.Text == null && txtMaBD.Text == null && txtTenBD.Text == null
                    && txtMaSach.Text == null && txttenSach.Text == null && txtNhanVien.Text == null
                    && dtpNgayMuon.Text == null && dtpNgayTra.Text == null)
                {
                    MessageBox.Show("Nhập dữ liệu còn trống!");
                }             
                else
                {
                    FileStream fs = new FileStream(@"E:\QuanLyThuVien\PhieuMuon\" + txtMaPM.Text + ".txt", FileMode.Append);

                    StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);

                    sw.WriteLine("PHIẾU MƯỢN");
                    sw.WriteLine("Mã phiếu mượn: " + txtMaPM.Text);
                    sw.WriteLine("Mã bạn đọc: " + txtMaBD.Text);
                    sw.WriteLine("Tên bạn đọc: " + txtTenBD.Text);
                    sw.WriteLine("Mã sách: " + txtMaSach.Text);
                    sw.WriteLine("Tên sách: " + txttenSach.Text);
                    sw.WriteLine("Ngày mượn: " + dtpNgayMuon.Text);
                    sw.WriteLine("Ngày trả: " + dtpNgayTra.Text);
                    sw.WriteLine("Nhân viên: " + txtNhanVien.Text);
                    sw.WriteLine("----------------------------\n");
                    sw.Flush();
                    sw.Close();
                   
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi "+ ex);
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
