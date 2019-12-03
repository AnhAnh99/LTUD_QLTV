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
    public partial class QuanLyNhanVien : Form
    {
        KetNoiDatabase kn = new KetNoiDatabase();
        bool ktra = true;
        public QuanLyNhanVien()
        {
            InitializeComponent();
        }
        public void loadDSNhanVien()
        {
            kn.loadNhanVien(this.dgvDLNhanVien);
        }
        private void QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            loadDSNhanVien();
        }

        private void dgvDLNhanVien_Click(object sender, EventArgs e)
        {
            txtMaNV.Text = dgvDLNhanVien.CurrentRow.Cells[0].Value.ToString();
            txtTenNV.Text = dgvDLNhanVien.CurrentRow.Cells[1].Value.ToString();
            cbxChucVu.SelectedValue = dgvDLNhanVien.CurrentRow.Cells[2].Value.ToString();
            txtSDT.Text = dgvDLNhanVien.CurrentRow.Cells[3].Value.ToString();
            txtDiaChi.Text = dgvDLNhanVien.CurrentRow.Cells[4].Value.ToString();


        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            ktra = true;
            //LÀM SẠCH Ô
            txtMaNV.Text = "";
            txtTenNV.Text = "";
            cbxChucVu.Text = "";
            txtSDT.Text = "";
            txtDiaChi.Text = "";
            txtMaNV.Focus();
            // ẨN
            btnSuaNV.Enabled = false;
            btnThemNV.Enabled = false;
            btnXoaNV.Enabled = false;
            //HIỂN THỊ
            btnLuuNV.Enabled = true;
        }

        private void btnLuuNV_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text.Trim() != "")
            {
                if (ktra)
                {
                    kn.themNhanVien(txtMaNV.Text, txtTenNV.Text, cbxChucVu.Text, txtSDT.Text, txtDiaChi.Text); //THÊM
                    loadDSNhanVien(); //UPDATE DL
                    MessageBox.Show("Thêm thành công!"); //THONG BÁO - NÚT
                    btnThemNV.Enabled = true;
                    btnXoaNV.Enabled = true;
                    btnSuaNV.Enabled = true;
                    btnLuuNV.Enabled = false;

                }
                else
                {
                    kn.suaNhanVien(txtMaNV.Text, txtTenNV.Text, cbxChucVu.Text, txtSDT.Text, txtDiaChi.Text);
                    loadDSNhanVien();
                    MessageBox.Show("Sửa thành công!");
                    //HIỆN THỊ ĐỂ CHỌN CHỨC NĂNG
                    btnThemNV.Enabled = true;
                    btnXoaNV.Enabled = true;
                    btnSuaNV.Enabled = true;
                    // ẦN ĐI
                    btnLuuNV.Enabled = false;
                    txtMaNV.ReadOnly = false;

                }
            }
        }

        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            ktra = false;
            txtTenNV.Focus();
            // ẨN
            btnSuaNV.Enabled = false;
            btnThemNV.Enabled = false;
            btnXoaNV.Enabled = false;
            //HIỂN THỊ
            btnLuuNV.Enabled = true;
            txtMaNV.ReadOnly = true;

        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            //Bạn có muốn xóa không
            if (MessageBox.Show("Bạn có muốn xóa nhân viên mã " + txtMaNV.Text + "?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                kn.xoaNhanVien(txtMaNV.Text); //XOA
                loadDSNhanVien(); //UPDATE

            }
        }

        private void btnTimKiemNV_Click(object sender, EventArgs e)
        {
            kn.timKiemNhanVien(cbxTimKiemNV.Text, txtTimKiemNV.Text, dgvDLNhanVien);
        }

        private void cbxTimKiemNV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnThoatNV_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void QuanLyNhanVien_FormClosing(object sender, FormClosingEventArgs e)
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
