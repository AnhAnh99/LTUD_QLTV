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
    public partial class QuanLySach : Form
    {
        KetNoiDatabase kn = new KetNoiDatabase();

        public QuanLySach()
        {
            InitializeComponent();
        }
        private string imagePath;

        private void loadDLSachTV()
        {
            kn.loadSachThuVien(this.dgvDLSach);
            btnLuuSach.Enabled = false;
        }

        private void QuanLySach_Load(object sender, EventArgs e)
        {
            loadDLSachTV();
            kn.loadTacGia(this.cbxTacGia);
            kn.loadLoaiSachTV(this.cbxLoaiSach);
          
        }

        

        private void btnChonHinhSach_Click(object sender, EventArgs e)
        {

            OpenFileDialog open = new OpenFileDialog();
            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                pbxHinhSach.Image = new Bitmap(open.FileName);
                // image file path  
                pbxHinhSach.Text = open.FileName;
                this.imagePath = open.FileName;
            }
            


        }
        bool ktra = true;
        private void btnThemSach_Click(object sender, EventArgs e)
        {
            ktra = true;
            //LÀM SẠCH Ô
            txtMaSach.Text = "";
            txtTenSach.Text = "";
            cbxTacGia.Text = "";
            cbxLoaiSach.Text = "";
            txtMaSach.Focus();
            // ẨN
            btnSuaSach.Enabled = false;
            btnThemSach.Enabled = false;
            btnXoaSach.Enabled = false;
            //HIỂN THỊ
            btnLuuSach.Enabled = true;
        }

        private void btnXoaSach_Click(object sender, EventArgs e)
        {
            //Bạn có muốn xóa không
            if (MessageBox.Show("Bạn có muốn xóa mã sách " + txtMaSach.Text + "?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                kn.removeSachThuVien(txtMaSach.Text); //XOA
                loadDLSachTV(); //UPDATE
               
            }
        }

        private void btnSuaSach_Click(object sender, EventArgs e)
        {
            ktra = false;
            //K ĐƯỢC SỬA
            txtMaSach.ReadOnly = true;
            //ẨN NÚT
            btnSuaSach.Enabled = false;
            btnThemSach.Enabled = false;
            btnXoaSach.Enabled = false;
            btnLuuSach.Enabled = true;
        }

        private void btnLuuSach_Click(object sender, EventArgs e)
        {
            var anhSach = imagePath;
            if (txtMaSach.Text.Trim() != "")
            {
                if (ktra)
                {
                    kn.addSachThuVien(txtMaSach.Text, txtTenSach.Text, cbxTacGia.Text, anhSach , cbxLoaiSach.Text); //THÊM
                    loadDLSachTV(); //UPDATE DL
                    MessageBox.Show("Thêm thành công!"); //THONG BÁO - NÚT
                    btnThemSach.Enabled = true;
                    btnXoaSach.Enabled = true;
                    btnSuaSach.Enabled = true;
                    btnLuuSach.Enabled = false;
                    
                }
                else
                {
                    kn.updateSachThuVien(txtMaSach.Text, txtTenSach.Text, cbxTacGia.Text, anhSach, cbxLoaiSach.Text);
                    loadDLSachTV();
                    MessageBox.Show("Sửa thành công!");
                    //HIỆN THỊ ĐỂ CHỌN CHỨC NĂNG
                    btnThemSach.Enabled = true;
                    btnXoaSach.Enabled = true;
                    btnSuaSach.Enabled = true;
                    // ẦN ĐI
                    btnLuuSach.Enabled = false;
                    txtMaSach.ReadOnly = false;
                    
                }
            }
        }

        private void btnThoatSach_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnAddTG_Click(object sender, EventArgs e)
        {
            TacGia tg = new TacGia();
            tg.ShowDialog();
        }

        private void btnAddLoaiSach_Click(object sender, EventArgs e)
        {
            LoaiSach lsach = new LoaiSach();
            lsach.ShowDialog();
        }

      

        private void dgvDLSach_Click(object sender, EventArgs e)
        {
            txtMaSach.Text = dgvDLSach.CurrentRow.Cells[0].Value.ToString();
            try
            {
                pbxHinhSach.Image = new Bitmap(dgvDLSach.CurrentRow.Cells[3].Value.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi" + ex);
            }
            txtTenSach.Text = dgvDLSach.CurrentRow.Cells[1].Value.ToString();
            cbxTacGia.SelectedValue = dgvDLSach.CurrentRow.Cells[2].Value.ToString();
            cbxLoaiSach.SelectedValue = dgvDLSach.CurrentRow.Cells[4].Value.ToString();
           
            
        }

        private void bnTimKiemSach_Click(object sender, EventArgs e)
        {
            kn.timKiemSachTV(cbxLoaiTimKiem.Text, txtTimKiemSach.Text, this.dgvDLSach);
        }

        private void QuanLySach_FormClosing(object sender, FormClosingEventArgs e)
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
