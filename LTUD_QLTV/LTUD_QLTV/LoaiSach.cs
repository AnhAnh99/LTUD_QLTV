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
    public partial class LoaiSach : Form
    {
        KetNoiDatabase kn = new KetNoiDatabase();
        bool ktra = true;
        public LoaiSach()
        {
            InitializeComponent();
        }
        private void loadLoaiSach()
        {
            kn.loadLoaiSach(this.dgvDLLoaiSach);
        }
        private void LoaiSach_Load(object sender, EventArgs e)
        {
            loadLoaiSach();
        }

        private void btnThemLS_Click(object sender, EventArgs e)
        {
            ktra = true;
            //LÀM SẠCH Ô
            txtMaLS.Text = "";
            txtTenLS.Text = "";
            txtMaLS.Focus();
            // ẨN
            btnSuaLS.Enabled = false;
            btnThemLS.Enabled = false;
            btnXoaLS.Enabled = false;
            //HIỂN THỊ
            btnLuuLS.Enabled = true;
        }

        private void btnXoaLS_Click(object sender, EventArgs e)
        {
            //Bạn có muốn xóa không
            if (MessageBox.Show("Bạn có muốn xóa loại sách mã " + txtMaLS.Text + "?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                kn.removeLoaiSach(txtMaLS.Text); //XOA
                loadLoaiSach(); //UPDATE

            }
        }

        private void btnSuaLS_Click(object sender, EventArgs e)
        {

            ktra = false;
            // ẨN
            btnSuaLS.Enabled = false;
            btnThemLS.Enabled = false;
            btnXoaLS.Enabled = false;
            //HIỂN THỊ
            btnLuuLS.Enabled = true;
            txtMaLS.ReadOnly = true;
        }

        private void btnLuuLS_Click(object sender, EventArgs e)
        {
            if (txtMaLS.Text.Trim() != "")
            {
                if (ktra)
                {
                    kn.addLoaiSach(txtMaLS.Text, txtTenLS.Text); //THÊM
                    loadLoaiSach(); //UPDATE DL
                    MessageBox.Show("Thêm thành công!"); //THONG BÁO - NÚT
                    // ẨN
                    btnSuaLS.Enabled = true;
                    btnThemLS.Enabled = true;
                    btnXoaLS.Enabled = true;
                    //HIỂN THỊ
                    btnLuuLS.Enabled = false;

                }
                else
                {
                    kn.updateLoaiSach(txtMaLS.Text, txtTenLS.Text);
                    loadLoaiSach();
                    MessageBox.Show("Sửa thành công!");
                    // ẨN
                    btnSuaLS.Enabled = true;
                    btnThemLS.Enabled = true;
                    btnXoaLS.Enabled = true;
                    //HIỂN THỊ
                    btnLuuLS.Enabled = false;
                    txtMaLS.ReadOnly = false;

                }
            }
        }

        private void btnThoatLS_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnTKiemLS_Click(object sender, EventArgs e)
        {

            kn.timKiemLoaiSach(cbxTKiemLS.Text, txtTKiemLS.Text, dgvDLLoaiSach);
        }

        private void dgvDLLoaiSach_Click(object sender, EventArgs e)
        {
            txtMaLS.Text = dgvDLLoaiSach.CurrentRow.Cells[0].Value.ToString();
            txtTenLS.Text = dgvDLLoaiSach.CurrentRow.Cells[1].Value.ToString();
        }

        private void LoaiSach_FormClosing(object sender, FormClosingEventArgs e)
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
