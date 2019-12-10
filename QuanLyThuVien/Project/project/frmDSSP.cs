//Le Duc Dung
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace project
{
    public partial class frmDSSP : Form
    {
        public static int login = 0;
        private static frmDSSP formDSSP = null;
        public static frmDSSP tao()
        {
            //Kiem tra form dang mo
            if (formDSSP == null || formDSSP.IsDisposed)
                formDSSP = new frmDSSP();   
            //Phân quyền
            if (login == 0)
            {
                foreach (TextBox txt in formDSSP.pnTxt.Controls)
                    txt.ReadOnly = true;
                foreach (Button btn in formDSSP.pn.Controls)
                    btn.Enabled = false;
            }
            else
            {
                foreach (TextBox txt in formDSSP.pnTxt.Controls)
                    txt.ReadOnly = false;
                foreach (Button btn in formDSSP.pn.Controls)
                    btn.Enabled = true;
            }
            //Lay du lieu tu DB
            load();
            //Khoi tao
            formDSSP.dgvDgv.Rows[0].Selected = true;
            formDSSP.MdiParent = frmMenu.tao();
            return formDSSP;
        }
        /// <summary>
        /// lấy dữ liệu từ DB
        /// </summary>
        static void load()
        {
            DataTable dssp = DB.tableTruyVan("EXEC SP_DSSP");
            formDSSP.dgvDgv.DataSource = dssp;
        }
        public frmDSSP()
        {
            InitializeComponent();
        }

        private void frmDSSP_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát?", "Cảnh báo thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                e.Cancel = true;
        }
//Chức năng nút quay lại
        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            Close();
        }
//Chức năng nút thoát
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
//Chức năng nút thêm
        private void btnThem_Click(object sender, EventArgs e)
        {
            //test case
            int nTest = 0;
            //Kiểm tra textbox trống
            foreach (Control ctr in pnTxt.Controls)
            {
                if (ctr.Text == "")
                {
                    MessageBox.Show("Hãy nhập đầy đủ thông tin"); ////thông báo lỗi
                    nTest = 1;
                    break;
                }
            }
            //ID không được có chữ
            foreach (char c in txtID_SP.Text)
            {
                if (!char.IsDigit(c))
                {
                    MessageBox.Show("ID không được có chữ"); //thông báo lỗi
                    txtID_SP.Text = "";
                    nTest = 1;
                    break;
                }
            }
            //ID bị trùng
            for (int i = 0; i < dgvDgv.Rows.Count - 1; i++)
            {
                if (dgvDgv.Rows[i].Cells["ID_SANPHAM"].Value.ToString() == txtID_SP.Text)
                {
                    MessageBox.Show("ID_SANPHAM bị trùng"); //thông báo lỗi
                    txtID_SP.Text = "";
                    nTest = 1;
                    break;
                }
            }
            //DONGIA không được có chữ
            foreach (char c in txtDonGia.Text)
            {
                if (!char.IsDigit(c))
                {
                    MessageBox.Show("DONGIA không được có chữ"); //thông báo lỗi
                    txtDonGia.Text = "";
                    nTest = 1;
                    break;
                }
            }
            //TONKHO không được có chữ
            foreach (char c in txtTonKho.Text)
            {
                if (!char.IsDigit(c))
                {
                    MessageBox.Show("TONKHO không được có chữ"); //thông báo lỗi
                    txtTonKho.Text = "";
                    nTest = 1;
                    break;
                }
            }
            //Nếu có lỗi thì return
            if (nTest == 1)
                return;
            try
            {
                DB.tableTruyVan(string.Format("EXEC SP_THEMSANPHAM {0}, '{1}', '{2}', {3}, {4}", txtID_SP.Text, txtTen_SanPham.Text, txtDVT.Text, txtDonGia.Text, txtTonKho.Text));
                load();
                MessageBox.Show("Thêm thành công");//thông báo 
            }
            catch
            {
                MessageBox.Show("Thông tin không hợp lệ"); //thông báo lỗi
            }
        }
        //đưa dữ liệu lên textbox khi nhấp vào row
        private void dgvDgv_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            try
            {
                if (login != 0)
                {
                    btnThem.Enabled = false; //không cấp quyền thêm
                    btnXoa.Enabled = true; //cấp quyền xóa
                    btnSua.Enabled = true; //cấp quyền sửa
                }
                txtID_SP.ReadOnly = true; // đọc ID

                txtID_SP.Text = dgvDgv.SelectedRows[0].Cells[0].Value.ToString(); //chọn cột ID
                txtTen_SanPham.Text = dgvDgv.SelectedRows[0].Cells[1].Value.ToString(); //chọn cột Tên
                txtDVT.Text = dgvDgv.SelectedRows[0].Cells[2].Value.ToString(); //chọn cột đơn vị
                txtDonGia.Text = dgvDgv.SelectedRows[0].Cells[3].Value.ToString(); //chọn cột đơn giá
                txtTonKho.Text = dgvDgv.SelectedRows[0].Cells[4].Value.ToString(); // chọn cột tồn kho
            }
            catch
            {
                if(login != 0)
                {
                    txtID_SP.ReadOnly = false; 
                    btnThem.Enabled = true;
                    btnXoa.Enabled = false;
                    btnSua.Enabled = false;

                }
                foreach (Control ctr in pnTxt.Controls)
                {
                    ctr.Text = ""; // rỗng
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Xác nhận xóa", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;
                DB.tableTruyVan("EXEC SP_XOASANPHAM " + txtID_SP.Text);
                load();
                MessageBox.Show("Xóa thành công"); //thông báo lỗi
            }
            catch
            {
                MessageBox.Show("Thao tác không hợp lệ"); //thông báo lỗi
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            //test case
            int nTest = 0;
            //Kiểm tra textbox trống
            foreach (Control ctr in pnTxt.Controls)
            {
                if (ctr.Text == "")
                {
                    MessageBox.Show("Hãy nhập đầy đủ thông tin"); //thông báo lỗi
                    nTest = 1;
                    break;
                }
            }
            //DONGIA không được có chữ
            foreach (char c in txtDonGia.Text)
            {
                if (!char.IsDigit(c))
                {
                    MessageBox.Show("DONGIA không được có chữ"); //thông báo lỗi
                    txtDonGia.Text = "";
                    nTest = 1;
                    break;
                }
            }
            //TONKHO không được có chữ
            foreach (char c in txtTonKho.Text)
            {
                if (!char.IsDigit(c))
                {
                    MessageBox.Show("TONKHO không được có chữ"); //thông báo lỗi
                    txtTonKho.Text = "";
                    nTest = 1;
                    break;
                }
            }
            //Nếu có lỗi thì return
            if (nTest == 1)
                return;
            try
            {
                DB.tableTruyVan(string.Format("EXEC SP_SUASANPHAM {0}, '{1}', {2}, {3}, {4}", txtID_SP.Text, txtTen_SanPham.Text, txtDVT.Text, txtDonGia.Text, txtTonKho.Text));
                load();
                MessageBox.Show("Sửa thành công"); //thông báo 
            }
            catch
            {
                MessageBox.Show("Thao tác không hợp lệ"); //thông báo lỗi
            }      
        }
    }
}
