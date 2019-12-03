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
    public partial class TacGia : Form
    {
        KetNoiDatabase kn = new KetNoiDatabase();
        bool ktra = true;

        public TacGia()
        {
            InitializeComponent();
        }

        public void loadDSTacGia()
        {
            kn.loadTacGia(this.dgvDLTacGia);
        }
        private void btnThemTG_Click(object sender, EventArgs e)
        {
            ktra = true;
            //LÀM SẠCH Ô
            txtMaTG.Text = "";
            txtTenTG.Text = "";
            txtDiaChiTG.Text = "";
            txtMaTG.Focus();
            // ẨN
            btnSuaTG.Enabled = false;
            btnThemTG.Enabled = false;
            btnXoaTG.Enabled = false;
            //HIỂN THỊ
            btnLuuTG.Enabled = true;
        }

        private void btnXoaTG_Click(object sender, EventArgs e)
        {
            //Bạn có muốn xóa không
            if (MessageBox.Show("Bạn có muốn xóa tác giả mã " + txtMaTG.Text + "?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                kn.removeTacGia(txtMaTG.Text); //XOA
                loadDSTacGia(); //UPDATE

            }
        }

        private void btnSuaTG_Click(object sender, EventArgs e)
        {
            ktra = false;
            // ẨN
            btnSuaTG.Enabled = false;
            btnThemTG.Enabled = false;
            btnXoaTG.Enabled = false;
            //HIỂN THỊ
            btnLuuTG.Enabled = true;
            txtMaTG.ReadOnly = true;
        }

        private void btnLuuTG_Click(object sender, EventArgs e)
        {
            if (txtMaTG.Text.Trim() != "")
            {
                if (ktra)
                {
                    kn.addTacGia(txtMaTG.Text, txtTenTG.Text, txtDiaChiTG.Text); //THÊM
                    loadDSTacGia(); //UPDATE DL
                    MessageBox.Show("Thêm thành công!"); //THONG BÁO - NÚT
                    //Ẩn nút
                    btnThemTG.Enabled = true;
                    btnXoaTG.Enabled = true;
                    btnSuaTG.Enabled = true;
                    //Hiện thị
                    btnLuuTG.Enabled = false;

                }
                else
                {
                    kn.updateTacGia(txtMaTG.Text, txtTenTG.Text, txtDiaChiTG.Text);
                    loadDSTacGia();
                    MessageBox.Show("Sửa thành công!");
                    //Ẩn nút
                    btnThemTG.Enabled = true;
                    btnXoaTG.Enabled = true;
                    btnSuaTG.Enabled = true;
                    //Hiện thị
                    btnLuuTG.Enabled = false;
                    txtMaTG.ReadOnly = false;

                }
            }
        }

        private void btnThoatTG_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnTKiemTG_Click(object sender, EventArgs e)
        {
            kn.timKiemTacGia(cbxTimKiemTG.Text, txtTKiemTG.Text, dgvDLTacGia);
        }

        private void TacGia_Load(object sender, EventArgs e)
        {
            loadDSTacGia();
        }

        private void dgvDLTacGia_Click(object sender, EventArgs e)
        {
            txtMaTG.Text = dgvDLTacGia.CurrentRow.Cells[0].Value.ToString();
            txtTenTG.Text = dgvDLTacGia.CurrentRow.Cells[1].Value.ToString();         
            txtDiaChiTG.Text = dgvDLTacGia.CurrentRow.Cells[2].Value.ToString();
          
        }

        private void TacGia_FormClosing(object sender, FormClosingEventArgs e)
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
