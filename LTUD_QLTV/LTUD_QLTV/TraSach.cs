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

    public partial class TraSach : Form
    {
        KetNoiDatabase kn = new KetNoiDatabase();
        bool ktra = true;
        public TraSach()
        {
            InitializeComponent();
        }
        private void tinhTienPhat()
        {
            double phiPhat = 0;
            // Ngay Tre hen
            DateTime ngaymuon = Convert.ToDateTime(dtpNgayHenTra.Text);
            DateTime ngaytra = Convert.ToDateTime(dtpNgayTra.Text);
            TimeSpan Time = ngaytra - ngaymuon;
            int TongSoNgay = Time.Days;
            //Tinh phi Phat
            phiPhat = TongSoNgay * 5000;
            txtPhiPhat.Text = phiPhat.ToString();
        }
        private void loadDSTraSach()
        {
            kn.loadTraSach(this.dgvDLTraSach);
        }
        private void btnThemTra_Click(object sender, EventArgs e)
        {
            ktra = true;
            //LÀM SẠCH Ô
            txtMaTraSach.Text = "";
            txtMaMuonSach.Text = "";
            txtNguoiTra.Text = "";
            txtTenSach.Text = "";
            txtPhiPhat.Text = "";
            txtMaMuonSach.Focus();
             

            // ẨN
            btnSuaTra.Enabled = false;
            btnThemTra.Enabled = false;
            btnXoaTra.Enabled = false;
            //HIỂN THỊ
            btnLuuTra.Enabled = true;
        }

        private void btnXoaTra_Click(object sender, EventArgs e)
        {
            
            //Bạn có muốn xóa không
            if (MessageBox.Show("Bạn có muốn xóa dữ liệu trả sách mã " + txtMaTraSach.Text + "?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                kn.removeTraSach(txtMaTraSach.Text); //XOA
                loadDSTraSach(); //UPDATE


            }
        }

        private void btnSuaTra_Click(object sender, EventArgs e)
        {
            ktra = false;
            btnSuaTra.Enabled = false;
            btnThemTra.Enabled = false;
            btnXoaTra.Enabled = false;
            //HIỂN THỊ
            btnLuuTra.Enabled = true;
            txtMaMuonSach.ReadOnly = true;
        }

        private void btLuuTra_Click(object sender, EventArgs e)
        {
            if (txtMaTraSach.Text.Trim() != "")
            {
                if (ktra)
                {
                    kn.addTraSach(txtMaTraSach.Text, txtMaMuonSach.Text, txtNguoiTra.Text, txtTenSach.Text, dtpNgayHenTra.Text, dtpNgayTra.Text,  Convert.ToDouble(txtPhiPhat.Text)); //THÊM
                  
                    loadDSTraSach(); //UPDATE DL
                    MessageBox.Show("Thêm thành công!"); //THONG BÁO - NÚT
                                                         //Ẩn nút
                    btnSuaTra.Enabled = true;
                    btnThemTra.Enabled = true;
                    btnXoaTra.Enabled = true;
                    //Hiện thị
                    btnLuuTra.Enabled = false;

                }
                else
                {
                    kn.updateTraSach(txtMaTraSach.Text, txtMaMuonSach.Text, txtNguoiTra.Text, txtTenSach.Text, dtpNgayHenTra.Text, dtpNgayTra.Text, Convert.ToDouble(txtPhiPhat.Text)); //THÊM
                   // tinhTienPhat();
                    loadDSTraSach();
                    MessageBox.Show("Sửa thành công!");
                    btnSuaTra.Enabled = true;
                    btnThemTra.Enabled = true;
                    btnXoaTra.Enabled = true;
                    //Hiện thị
                    btnLuuTra.Enabled = false;
                    txtMaMuonSach.ReadOnly = false;

                }
            }
        }

       

        private void btnTimKiemTra_Click(object sender, EventArgs e)
        {
            kn.timKiemTraSach(cbxTimKiemTra.Text, txtTimKiemTra.Text, dgvDLTraSach);
        }

        private void TraSach_Load(object sender, EventArgs e)
        {
            kn.loadTraSach(this.dgvDLTraSach);
            //txtPhiPhat.Enabled = false;
        }

        private void dgvDLTraSach_Click(object sender, EventArgs e)
        {
           
            txtMaTraSach.Text = dgvDLTraSach.CurrentRow.Cells[0].Value.ToString();
            txtMaMuonSach.Text = dgvDLTraSach.CurrentRow.Cells[1].Value.ToString();
            txtNguoiTra.Text = dgvDLTraSach.CurrentRow.Cells[2].Value.ToString();
            txtTenSach.Text = dgvDLTraSach.CurrentRow.Cells[3].Value.ToString();
            dtpNgayHenTra.Text = dgvDLTraSach.CurrentRow.Cells[4].Value.ToString();
            dtpNgayTra.Text = dgvDLTraSach.CurrentRow.Cells[5].Value.ToString();
            txtPhiPhat.Text = dgvDLTraSach.CurrentRow.Cells[6].Value.ToString();
        }

        private void btnThoatTraSach_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btntinh_Click(object sender, EventArgs e)
        {
            int phiPhat;
            // Ngay Tre hen
            DateTime ngaymuon = Convert.ToDateTime(dtpNgayHenTra.Text);
            DateTime ngaytra = Convert.ToDateTime(dtpNgayTra.Text);
            TimeSpan Time = ngaytra - ngaymuon;
            int TongSoNgay = Time.Days;
            //Tinh phi Phat
            if (TongSoNgay > 7)
            {
                phiPhat = (TongSoNgay-7) * 5000;
                txtPhiPhat.Text = phiPhat.ToString();
            }
        }

        private void TraSach_FormClosing(object sender, FormClosingEventArgs e)
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
