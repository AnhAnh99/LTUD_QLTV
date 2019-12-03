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
    public partial class TheKhachHang : Form
    {
        KetNoiDatabase kn = new KetNoiDatabase();
        bool ktra = true;
        public TheKhachHang()
        {
            InitializeComponent();
        }
        private void LoadDSKhachHang()
        {
            kn.loadKhachHang(this.dgvDLKhachHang);
        }
        private void TheKhachHang_Load(object sender, EventArgs e)
        {
            LoadDSKhachHang();
        }
        private void resetText()
        {
            txtMaKH.ResetText();     
            txtTenKH.ResetText(); 
            txtSoDTKH.ResetText(); 
            txtDiaChiKH.ResetText(); 
            txtTKiemKH.ResetText();
            cbxTKiemKH.ResetText();
            dtpNgayDK.ResetText();
            dtpNgayHH.ResetText();
        }

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            ktra = true;
            //LÀM SẠCH Ô
            txtMaKH.Text = "";
            txtTenKH.Text = "";
            txtSoDTKH.Text = "";
            txtDiaChiKH.Text = "";
            txtMaKH.Focus();
            // ẨN
            btnSuaKH.Enabled = false;
            btnThemKH.Enabled = false;
            btnXoaKH.Enabled = false;
            //HIỂN THỊ
            btnLuuKH.Enabled = true;
        }

        private void btnXoaKH_Click(object sender, EventArgs e)
        {
            //Bạn có muốn xóa không
            if (MessageBox.Show("Bạn có muốn xóa khách hàng mã " + txtMaKH.Text + "?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                kn.removeKhachHang(txtMaKH.Text); //XOA
                LoadDSKhachHang(); //UPDATE

            }
        }

        private void btnSuaKH_Click(object sender, EventArgs e)
        {
            ktra = false;
            // ẨN
            btnSuaKH.Enabled = false;
            btnThemKH.Enabled = false;
            btnXoaKH.Enabled = false;
            //HIỂN THỊ
            btnLuuKH.Enabled = true;
            txtMaKH.ReadOnly = true;
        }

        private void btnLuuKH_Click(object sender, EventArgs e)
        {
            if (txtMaKH.Text.Trim() != "")
            {
                if (ktra)
                {
                    kn.addKhachHang(txtMaKH.Text, txtTenKH.Text, txtSoDTKH.Text, txtDiaChiKH.Text, dtpNgayDK.Text, dtpNgayHH.Text); //THÊM
                    LoadDSKhachHang(); //UPDATE DL
                    MessageBox.Show("Thêm thành công!"); //THONG BÁO - NÚT
                    //Ẩn nút
                    btnSuaKH.Enabled = true;
                    btnThemKH.Enabled = true;
                    btnXoaKH.Enabled = true;
                    //Hiện thị
                    btnLuuKH.Enabled = false;
                    resetText();
                }
                else
                {
                    kn.updateKhachHang(txtMaKH.Text, txtTenKH.Text, txtSoDTKH.Text, txtDiaChiKH.Text, dtpNgayDK.Text, dtpNgayHH.Text);
                    LoadDSKhachHang();
                    MessageBox.Show("Sửa thành công!");
                    //Ẩn nút
                    btnSuaKH.Enabled = true;
                    btnThemKH.Enabled = true;
                    btnXoaKH.Enabled = true;
                    //Hiện thị
                    btnLuuKH.Enabled = false;
                    txtMaKH.ReadOnly = false;
                    resetText();
                }
            }
        }

        private void btnThoatKH_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void dgvDLKhachHang_Click(object sender, EventArgs e)
        {
            txtMaKH.Text = dgvDLKhachHang.CurrentRow.Cells[0].Value.ToString();
            txtTenKH.Text = dgvDLKhachHang.CurrentRow.Cells[1].Value.ToString();
            txtSoDTKH.Text = dgvDLKhachHang.CurrentRow.Cells[2].Value.ToString();
            txtDiaChiKH.Text = dgvDLKhachHang.CurrentRow.Cells[3].Value.ToString();
            dtpNgayDK.Text = dgvDLKhachHang.CurrentRow.Cells[4].Value.ToString();
            dtpNgayHH.Text = dgvDLKhachHang.CurrentRow.Cells[5].Value.ToString();
        }

        private void btnTimKiemKH_Click(object sender, EventArgs e)
        {
            kn.timKiemKhachHang(cbxTKiemKH.Text, txtTKiemKH.Text, dgvDLKhachHang);
            resetText();
        }

        private void TheKhachHang_FormClosing(object sender, FormClosingEventArgs e)
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
