//Le Duc Dung
//17211TT3619
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
    public partial class frmDSKH : Form
    {
        public static int login = 0;
        private static frmDSKH formDSKH = null;
        public static frmDSKH tao()
        {
            //Kiem tra form dang mo
            if (formDSKH == null || formDSKH.IsDisposed)
                formDSKH = new frmDSKH();
            //Phân quyền
            if (login == 0)
            {
                foreach (TextBox txt in formDSKH.pnTxt.Controls)
                    txt.ReadOnly = true; 
                foreach (Button btn in formDSKH.pn.Controls)
                    btn.Enabled = false;
            }
            else
            {
                foreach (TextBox txt in formDSKH.pnTxt.Controls)
                    txt.ReadOnly = false;
                foreach (Button btn in formDSKH.pn.Controls)
                    btn.Enabled = true;
            }
            //Lay du lieu tu DB
            load();
            //Khoi tao
            formDSKH.dataGridView1.Rows[0].Selected = true;
            formDSKH.MdiParent = frmMenu.tao();
            return formDSKH;
        }
        /// <summary>
        /// lấy dữ liệu từ DB
        /// </summary>
        static void load()
        {
            DataTable dskh = DB.tableTruyVan("EXEC SP_DSKH"); 
            formDSKH.dataGridView1.DataSource = dskh;
        }
        public frmDSKH()
        {
            InitializeComponent();
        }

        private void frmDSKH_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn thoát?", "Cảnh báo thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                e.Cancel = true;
        }
        //đưa dữ liệu lên textbox khi nhấp vào row
        private void dataGridView1_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            try
            {
                if (login != 0)
                {
                    btnThem.Enabled = false; //không cấp quyền thêm
                    btnXoa.Enabled = true; //cấp quyền xóa
                    btnSua.Enabled = true; //cấp quyền sửa
                }
                txtID_KhachHang.ReadOnly = true; //chỉ đọc

                txtID_KhachHang.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString(); //chọn cột ID
                txtTen_KhachHang.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString(); //chọn cột Tên
                txtDiaChi.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString(); //chọn cột địa chỉ
                txtSDT.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString(); //chọn cột sdt
            }
            catch
            {
                if (login != 0)
                {
                    txtID_KhachHang.ReadOnly = false; 
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

        private void btnThem_Click(object sender, EventArgs e)
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
            //ID không được có chữ
            foreach (char c in txtID_KhachHang.Text)
            {
                if (!char.IsDigit(c))
                {
                    MessageBox.Show("ID không được có chữ"); //thông báo lỗi
                    txtID_KhachHang.Text = "";
                    nTest = 1;
                    break;
                }
            }
            //ID bị trùng
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                if (dataGridView1.Rows[i].Cells["ID_KHACHHANG"].Value.ToString() == txtID_KhachHang.Text) 
                {
                    MessageBox.Show("ID_KHACHHANG bị trùng"); //thông báo lỗi
                    txtID_KhachHang.Text = "";
                    nTest = 1;
                    break;
                }
            }
            //SDT không hợp lệ(10 số)
            if (txtSDT.Text.Trim().Length != 10)
            {
                MessageBox.Show("SDT phải có 10 số"); //thông báo lỗi
                txtSDT.Text = "";
                nTest = 1;
            }
            //SDT không được là chữ
            for (int i = 0; i < txtSDT.Text.Trim().Length; i++)
            {
                if (!char.IsDigit(txtSDT.Text.Trim()[i]))
                {
                    MessageBox.Show("SDT không được là chữ"); //thông báo lỗi
                    txtSDT.Text = "";
                    nTest = 1;
                    break;
                }
            }
            //Nếu có lỗi thì return
            if (nTest == 1)
                return;
            try
            {
                DB.tableTruyVan(string.Format("EXEC SP_THEMKHACHHANG {0}, '{1}', '{2}', '{3}'", txtID_KhachHang.Text, txtTen_KhachHang.Text, txtDiaChi.Text, txtSDT.Text));
                load();
                MessageBox.Show("Thêm thành công"); //thông báo lỗi
            }
            catch
            {
                MessageBox.Show("Thông tin không hợp lệ"); //thông báo lỗi
            }
        }
// Chức năng nút Xóa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Xác nhận xóa", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;
                DB.tableTruyVan("EXEC SP_XOAKHACHHANG " + txtID_KhachHang.Text);
                load();
                MessageBox.Show("Xóa thành công"); //thông báo thành công
            }
            catch
            {
                MessageBox.Show("Thao tác không hợp lệ"); //thông báo lỗi
            }
        }
//Chức năng nút sửa
        private void btnSua_Click(object sender, EventArgs e)
        {
            //test case
            int nTest = 0;
            //Kiểm tra textbox trống
            foreach (Control ctr in pnTxt.Controls)
            {
                if (ctr.Text == "")
                {
                    MessageBox.Show("Hãy nhập đầy đủ thông tin");
                    nTest = 1;
                    break;
                }
            }
            //SDT không hợp lệ(10 số)
            if (txtSDT.Text.Trim().Length != 10)
            {
                MessageBox.Show("SDT phải có 10 số"); //thông báo lỗi
                txtSDT.Text = "";
                nTest = 1;
            }
            //SDT không được là chữ
            for (int i = 0; i < txtSDT.Text.Trim().Length; i++)
            {
                if (!char.IsDigit(txtSDT.Text.Trim()[i]))
                {
                    MessageBox.Show("SDT không được là chữ"); //thông báo lỗi
                    txtSDT.Text = "";
                    nTest = 1;
                    break;
                }
            }
            //Nếu có lỗi thì return
            if (nTest == 1)
                return;
            DB.tableTruyVan(string.Format("exec SP_SUAKHACHHANG {0}, '{1}', '{2}', '{3}'", txtID_KhachHang.Text, txtTen_KhachHang.Text, txtDiaChi.Text, txtSDT.Text));
            load();
            MessageBox.Show("Sửa thành công"); //thông báo lỗi
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

        private void btnTim_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable t = DB.tableTruyVan(String.Format("EXEC SP_TIMKHACHHANG '{0}'", txtTimKiem.Text));
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    if (dataGridView1.Rows[i].Cells["TEN_KHACHHANG"].Value.ToString() == t.Rows[0]["TEN_KHACHHANG"].ToString())
                    {
                        dataGridView1.SelectedRows[0].Selected = false;
                        dataGridView1.Rows[i].Selected = true;
                        break;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Không tìm thấy");
            }
        }
    }
}