using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace LTUD_QLTV
{
    public partial class QuanLyMuonSach : Form
    {
        KetNoiDatabase kn = new KetNoiDatabase();
        bool ktra = true;

        public QuanLyMuonSach()
        {
            InitializeComponent();
        }

        private void loadDSMuonSach()
        {
            kn.loadMuonSach(this.dgvDLMuonSach);
        }

        private void QuanLyMuonSach_Load(object sender, EventArgs e)
        {
            loadDSMuonSach();
            kn.loadMaKH(this.cbxMaKHMuon);
            kn.loadMaSachTV(this.cbxMaSachMuon);
           
        }
        private void resetText()
        {
            txtMaMS.ResetText();
            cbxMaKHMuon.ResetText();
            txtTenKHMuon.ResetText();
            txtTenSachM.ResetText();
            txtTimKiemMuon.ResetText();
            dtpNgayHenTra.ResetText();
            dtpNgayMuon.ResetText();
            cbxMaSachMuon.ResetText();
            cbxTimKiemMuon.ResetText();
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            ktra = true;
            //LÀM SẠCH Ô
            resetText();
            // ẨN
            btnSuaMuon.Enabled = false;
            btnThemMuon.Enabled = false;
            btnXoaMuon.Enabled = false;
            //HIỂN THỊ
            btnLuuMuon.Enabled = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //Bạn có muốn xóa không
            if (MessageBox.Show("Bạn có muốn xóa dữ liệu mượn sách mã " + txtMaMS.Text + "?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                kn.removeTacGia(txtMaMS.Text); //XOA
                loadDSMuonSach(); //UPDATE

            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            ktra = false;
            // ẨN
            btnSuaMuon.Enabled = false;
            btnThemMuon.Enabled = false;
            btnXoaMuon.Enabled = false;
            //HIỂN THỊ
            btnLuuMuon.Enabled = true;

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtMaMS.Text.Trim() != "")
            {
                if (ktra)
                {
                    kn.addMuonSach(txtMaMS.Text, cbxMaKHMuon.Text, txtTenKHMuon.Text, cbxMaSachMuon.Text, txtTenSachM.Text, dtpNgayMuon.Text, dtpNgayHenTra.Text); //THÊM
                    loadDSMuonSach(); //UPDATE DL
                    MessageBox.Show("Thêm thành công!"); //THONG BÁO - NÚT
                    //Ẩn nút
                    btnThemMuon.Enabled = true;
                    btnXoaMuon.Enabled = true;
                    btnSuaMuon.Enabled = true;
                    //Hiện thị
                    btnLuuMuon.Enabled = false;
                    resetText();

                }
                else
                {
                    kn.updateMuonSach(txtMaMS.Text, cbxMaKHMuon.Text, txtTenKHMuon.Text, cbxMaSachMuon.Text, txtTenSachM.Text, dtpNgayMuon.Text, dtpNgayHenTra.Text);
                    loadDSMuonSach();
                    MessageBox.Show("Sửa thành công!");
                    //Ẩn nút
                    btnThemMuon.Enabled = true;
                    btnXoaMuon.Enabled = true;
                    btnSuaMuon.Enabled = true;
                    //Hiện thị
                    btnLuuMuon.Enabled = false;
                    txtMaMS.ReadOnly = false;
                    resetText();

                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            kn.timKiemMuonSach(cbxTimKiemMuon.Text, txtTimKiemMuon.Text, dgvDLMuonSach);
            resetText();

        }

        private void dgvDLMuonSach_Click(object sender, EventArgs e)
        {
            txtMaMS.Text = dgvDLMuonSach.CurrentRow.Cells[0].Value.ToString();
            cbxMaKHMuon.Text = dgvDLMuonSach.CurrentRow.Cells[1].Value.ToString();
            txtTenKHMuon.Text = dgvDLMuonSach.CurrentRow.Cells[2].Value.ToString();
            cbxMaSachMuon.Text = dgvDLMuonSach.CurrentRow.Cells[3].Value.ToString();
            txtTenSachM.Text = dgvDLMuonSach.CurrentRow.Cells[4].Value.ToString();
            dtpNgayMuon.Text = dgvDLMuonSach.CurrentRow.Cells[5].Value.ToString();
            dtpNgayHenTra.Text = dgvDLMuonSach.CurrentRow.Cells[6].Value.ToString();
        }

        private void QuanLyMuonSach_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r =
                MessageBox.Show("Bạn có muốn thoát?", "Thông báo",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtMaMS.Text == null && txtTenKHMuon.Text == null && txtTenSachM.Text == null
                    && cbxMaKHMuon.Text == null && cbxMaSachMuon.Text == null 
                    && dtpNgayMuon.Text == null && dtpNgayHenTra.Text == null)
                {
                    MessageBox.Show("Nhập dữ liệu còn trống!");
                }
                else
                {
                    FileStream fs = new FileStream(@"D:\LTUD_QLTV\PhieuMuon\" + txtMaMS.Text + ".txt", FileMode.Append);

                    StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);

                    sw.WriteLine("\tPHIẾU MƯỢN");
                    sw.WriteLine("Mã phiếu mượn: " + txtMaMS.Text);
                    sw.WriteLine("Tên bạn đọc: " + txtTenKHMuon.Text);
                    sw.WriteLine("Tên sách: " + txtTenSachM.Text);
                    sw.WriteLine("Ngày mượn: " + dtpNgayMuon.Text);
                    sw.WriteLine("Ngày trả: " + dtpNgayHenTra.Text);
                    sw.WriteLine("----------------------------\n");
                    sw.Flush();
                    sw.Close();
                    MessageBox.Show("\tPHIẾU MƯỢN\n"+
                        "Mã phiếu mượn: " + txtMaMS.Text + "\n"+
                        "Tên bạn đọc: " + txtTenKHMuon.Text + "\n" +
                        "Tên sách: " + txtTenSachM.Text + "\n" +
                        "Ngày mượn: " + dtpNgayMuon.Text +"\n"+
                        "Ngày trả: " + dtpNgayHenTra.Text);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi " + ex);
            }
        }
    }
}
