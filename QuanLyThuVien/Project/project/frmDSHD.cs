//Nguyen Thanh Khiem
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Globalization;
using System.IO;
namespace project
{
    public partial class frmDSHD : Form
    {
        public static int login = 0;
        private static frmDSHD formDSHD = null;
        public static frmDSHD tao()
        {
            //Kiem tra form dang mo
            if (formDSHD == null || formDSHD.IsDisposed)
                formDSHD = new frmDSHD();
            //Phân quyền
            if (login == 0)
            {
                formDSHD.cbTEN_KHACHHANG.Enabled = false;
                formDSHD.cbTEN_SANPHAM.Enabled = false;
                formDSHD.dateTimePicker1.Enabled = false;
                formDSHD.txtSL.ReadOnly = true;
                formDSHD.txtID_HoaDon.ReadOnly = true;
                formDSHD.txtID_CTHD.ReadOnly = true;

                foreach (Control ctr in formDSHD.pn.Controls)
                    ctr.Enabled = false;
            }
            else
            {
                formDSHD.cbTEN_KHACHHANG.Enabled = true;
                formDSHD.cbTEN_SANPHAM.Enabled = true;
                formDSHD.dateTimePicker1.Enabled = true;
                formDSHD.txtSL.ReadOnly = false;
                formDSHD.txtID_HoaDon.ReadOnly = false;
                formDSHD.txtID_CTHD.ReadOnly = false;

                foreach (Control ctr in formDSHD.pn.Controls)
                    ctr.Enabled = true;
            }
            //Lay du lieu tu DB
            load();
            formDSHD.MdiParent = frmMenu.tao();
            return formDSHD;
        }

        /// <summary>
        /// lấy dữ liệu từ DB
        /// </summary>
        static void load()
        {
            DataTable DSHD = DB.tableTruyVan(@"SELECT ID_HOADON, KH.ID_KHACHHANG, TEN_KHACHHANG, NGAYMUA
                                               FROM HOADON HD JOIN KHACHHANG KH ON HD.ID_KHACHHANG = KH.ID_KHACHHANG");
            formDSHD.dataGridView1.DataSource = DSHD;
            DataTable DS_TEN_SANPHAM = DB.tableTruyVan(@"SELECT TEN_SANPHAM FROM SANPHAM");
            formDSHD.cbTEN_SANPHAM.DataSource = DS_TEN_SANPHAM;
            formDSHD.cbTEN_SANPHAM.DisplayMember = "TEN_SANPHAM";
            formDSHD.dataGridView1.Rows[0].Selected = true;
            try
            {
                formDSHD.cbTEN_SANPHAM.SelectedIndex = formDSHD.cbTEN_SANPHAM.FindStringExact(formDSHD.dataGridView2.SelectedRows[0].Cells["TEN_SANPHAM"].Value.ToString());
            }
            catch
            {
                formDSHD.txtID_SANPHAM.Text = formDSHD.txtDONGIA.Text = "";
                formDSHD.cbTEN_SANPHAM.SelectedIndex = -1;
            }
            if (login == 3)
            {
                formDSHD.btnSua.Enabled = formDSHD.btnXoa.Enabled = false;
                formDSHD.btnThem.Enabled = true;
            }
        }
        public frmDSHD()
        {
            InitializeComponent();
        }

        private void frmDSHD_FormClosing(object sender, FormClosingEventArgs e)
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
                    btnThem.Enabled = false;
                    btnXoa.Enabled = true;
                    btnSua.Enabled = true;
                }
                txtID_HoaDon.ReadOnly = true;
                if (login != 0)
                    dateTimePicker1.Enabled = true;
                txtID_HoaDon.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                txtID_KhachHang.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                DataTable DS_TEN_KHACHHANG = DB.tableTruyVan(@"SELECT TEN_KHACHHANG FROM KHACHHANG");
                cbTEN_KHACHHANG.DataSource = DS_TEN_KHACHHANG;
                cbTEN_KHACHHANG.DisplayMember = "TEN_KHACHHANG";
                cbTEN_KHACHHANG.SelectedIndex = cbTEN_KHACHHANG.FindStringExact(dataGridView1.SelectedRows[0].Cells[2].Value.ToString());
                string sNgay = dataGridView1.SelectedRows[0].Cells[3].Value.ToString().Substring(0, dataGridView1.SelectedRows[0].Cells[3].Value.ToString().Length - 12);
                string[] sTachNgay = sNgay.Split(new string[] { "/" }, StringSplitOptions.RemoveEmptyEntries);
                dateTimePicker1.Value = new DateTime(int.Parse(sTachNgay[2]), int.Parse(sTachNgay[1]), int.Parse(sTachNgay[0]));
                double dThanhTien = 0;
                DataTable TinhTien = DB.tableTruyVan(@"SELECT DONGIA, SL
                                                       FROM HOADON HD JOIN CTHD ON HD.ID_HOADON = CTHD.ID_HOADON JOIN SANPHAM SP ON SP.ID_SANPHAM = CTHD.ID_SANPHAM
                                                       WHERE HD.ID_HOADON = " + txtID_HoaDon.Text);
                for (int i = 0; i < TinhTien.Rows.Count; i++)
                    dThanhTien += double.Parse(TinhTien.Rows[i]["DONGIA"].ToString()) * double.Parse(TinhTien.Rows[i]["SL"].ToString());
                txtThanhTien.Text = dThanhTien.ToString();
                DataTable DSCTHD = DB.tableTruyVan(@"SELECT ID_CTHD, CTHD.ID_SANPHAM, TEN_SANPHAM, DONGIA, SL
                                                     FROM CTHD JOIN SANPHAM SP ON CTHD.ID_SANPHAM = SP.ID_SANPHAM JOIN HOADON HD ON HD.ID_HOADON = CTHD.ID_HOADON
                                                     WHERE HD.ID_HOADON = " + dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                dataGridView2.DataSource = DSCTHD;
                dataGridView2.Rows[0].Selected = true;
            }
            catch
            {
                if (login != 0)
                {
                    txtID_HoaDon.ReadOnly = false;
                    btnThem.Enabled = true;
                    btnXoa.Enabled = false;
                    btnSua.Enabled = false;
                    txtID_CTHD.ReadOnly = false;
                }
                cbTEN_KHACHHANG.SelectedIndex = -1;
                foreach (Control ctr in pnTxt.Controls)
                {
                    ctr.Text = "";
                    dataGridView2.DataSource = null;
                }
                txtThanhTien.Text = "";
            }
        }
        //đưa dữ liệu lên textbox khi nhấp vào row
        private void dataGridView2_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            try
            {
                if (login != 0)
                {
                    btnThem.Enabled = false;
                    btnSua.Enabled = true;
                }
                txtID_CTHD.ReadOnly = true;

                txtID_CTHD.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
                txtID_SANPHAM.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
                txtDONGIA.Text = dataGridView2.SelectedRows[0].Cells[3].Value.ToString();
                txtSL.Text = dataGridView2.SelectedRows[0].Cells[4].Value.ToString();
                cbTEN_SANPHAM.SelectedIndex = cbTEN_SANPHAM.FindStringExact(dataGridView2.SelectedRows[0].Cells[2].Value.ToString());
            }
            catch
            {
                if (login != 0)
                {
                    txtID_CTHD.ReadOnly = false;
                    btnThem.Enabled = true;
                    btnSua.Enabled = false;
                }
                cbTEN_SANPHAM.SelectedIndex = -1;
                foreach (Control ctr in pnTxt2.Controls)
                    ctr.Text = "";
            }
        }

        private void cbTEN_SANPHAM_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataRowView drv = (DataRowView)cbTEN_SANPHAM.SelectedValue;
                DataTable SP = DB.tableTruyVan(@"SELECT * FROM SANPHAM WHERE TEN_SANPHAM LIKE '" + drv[0].ToString() + "'");
                txtID_SANPHAM.Text = SP.Rows[0]["ID_SANPHAM"].ToString();
                txtDONGIA.Text = SP.Rows[0]["DONGIA"].ToString();
            }
            catch { }
        }

        private void cbTEN_KHACHHANG_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataRowView drv = (DataRowView)cbTEN_KHACHHANG.SelectedValue;
                DataTable SP = DB.tableTruyVan(@"SELECT * FROM KHACHHANG WHERE TEN_KHACHHANG LIKE '" + drv[0].ToString() + "'");
                txtID_KhachHang.Text = SP.Rows[0]["ID_KHACHHANG"].ToString();
            }
            catch { }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
                    nTest = 1;
                    break;
                }
            }
            //Kiểm tra textbox trống
            foreach (Control ctr in pnTxt2.Controls)
            {
                if (ctr.Text == "")
                {
                    nTest = 1;
                    break;
                }
            }
            if (nTest == 1)
                MessageBox.Show("Hãy nhập đầy đủ thông tin");
            //ID không được có chữ
            foreach (char c in txtID_HoaDon.Text)
            {
                if (!char.IsDigit(c))
                {
                    MessageBox.Show("ID không được có chữ");
                    txtID_HoaDon.Text = "";
                    nTest = 2;
                    break;
                }
            }
            //IDCT không được có chữ
            foreach (char c in txtID_CTHD.Text)
            {
                if (!char.IsDigit(c))
                {
                    MessageBox.Show("IDCT không được có chữ");
                    txtID_CTHD.Text = "";
                    nTest = 2;
                    break;
                }
            }
            //ID_CT bị trùng
            if (nTest != 2)
            {
                try
                {
                    int idct = int.Parse(DB.tableTruyVan("SELECT COUNT(ID_CTHD) FROM CTHD WHERE ID_CTHD = " + txtID_CTHD.Text).Rows[0][0].ToString());
                    if (idct != 0)
                    {
                        MessageBox.Show("ID_CTHD bị trùng");
                        nTest = 1;
                        txtID_CTHD.Text = "";
                    }
                }
                catch { }
            }
            //SL không được có chữ
            foreach (char c in txtSL.Text)
            {
                if (!char.IsDigit(c))
                {
                    MessageBox.Show("SL không được có chữ");
                    nTest = 1;
                    txtSL.Text = "";
                    return;
                }
            }
            //Nếu có lỗi thì return
            if (nTest != 0)
                return;
            //Kiểm tra ID tồn tại
            int nTT = 0;
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                if (dataGridView1.Rows[i].Cells["ID_HOADON"].Value.ToString() == txtID_HoaDon.Text)
                {
                    nTT = 1;
                    break;
                }
            }
            //Nếu ID không tồn tại thì thêm mới
            if (nTT == 0)
            {
                string sNgay = dateTimePicker1.Value.ToString().Substring(0, dateTimePicker1.Value.ToString().Length - 12);
                DB.tableTruyVan(string.Format("set dateformat dmy; EXEC SP_THEMHOADON {0}, {1}, '{2}'", txtID_HoaDon.Text, txtID_KhachHang.Text, sNgay));
            }
            //Thêm CT
            DB.tableTruyVan(string.Format("EXEC SP_THEMCTHD {0}, {1}, {2}, {3}", txtID_CTHD.Text, txtID_HoaDon.Text, txtID_SANPHAM.Text, txtSL.Text));
            load();
            MessageBox.Show("Thêm thành công");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Xác nhận xóa", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;
                DB.tableTruyVan("EXEC SP_XOACTHD " + txtID_CTHD.Text);
                load();
                MessageBox.Show("Xóa thành công");
            }
            catch
            {
                try
                {
                    DB.tableTruyVan(@"DELETE FROM CTHD
                                      WHERE CTHD.ID_HOADON = " + txtID_HoaDon.Text);
                    DB.tableTruyVan("EXEC SP_XOAHOADON " + txtID_HoaDon.Text);
                    load();
                    MessageBox.Show("Xóa thành công");
                }
                catch
                {
                    MessageBox.Show("Thao tác không hợp lệ");
                }
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
                    nTest = 1;
                    break;
                }
            }
            //Kiểm tra textbox trống
            foreach (Control ctr in pnTxt2.Controls)
            {
                if (ctr.Text == "")
                {
                    nTest = 1;
                    break;
                }
            }
            if (nTest == 1)
                MessageBox.Show("Hãy nhập đầy đủ thông tin");
            //SL không được có chữ
            foreach (char c in txtSL.Text)
            {
                if (!char.IsDigit(c))
                {
                    MessageBox.Show("SL không được có chữ");
                    nTest = 1;
                    txtSL.Text = "";
                    return;
                }
            }
            //Nếu có lỗi thì return
            if (nTest != 0)
                return;
            //sửa
            string sNgay = dateTimePicker1.Value.ToString().Substring(0, dateTimePicker1.Value.ToString().Length - 12);
            DB.tableTruyVan(string.Format("set dateformat dmy; EXEC SP_SUAHOADON {0}, {1}, '{2}'", txtID_HoaDon.Text, txtID_KhachHang.Text, sNgay));
            DB.tableTruyVan(string.Format("EXEC SP_SUACTHD {0}, {1}, {2}", txtID_CTHD.Text, txtID_SANPHAM.Text, txtSL.Text));
            load();
            MessageBox.Show("Sửa thành công");
        }
        private void btnIn_Click(object sender, EventArgs e)
        {
            try
            {
                
                StreamWriter sw = new StreamWriter(txtID_HoaDon.Text + ".txt");
                sw.WriteLine("IDHD: " + txtID_HoaDon.Text);
                DataRowView d = (DataRowView)cbTEN_KHACHHANG.SelectedValue;
                sw.WriteLine("Tên khách hàng: " + d[0].ToString());
                string sNgay = dateTimePicker1.Value.ToString().Substring(0, dateTimePicker1.Value.ToString().Length - 12);
                sw.WriteLine("Ngày mua: " + sNgay);
                sw.WriteLine(string.Format("\t{0,-10}{1,-20}{2,-10}{3,-10}", "STT", "Tên sản phẩm", "Đơn giá", "SL"));
                for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
                {
                    string r = string.Format("\t{0,-10}{1,-20}{2,-10}{3,-10}", dataGridView2.Rows[i].Cells["ID_CTHD"].Value.ToString(), dataGridView2.Rows[i].Cells["TEN_SANPHAM"].Value.ToString(), dataGridView2.Rows[i].Cells["DONGIA"].Value.ToString(), dataGridView2.Rows[i].Cells["SL"].Value.ToString());
                    sw.WriteLine(r);
                }
                sw.WriteLine("\t Tổng tiền: " + txtThanhTien.Text);
                sw.Close();
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn hóa đơn");
            }
        }
    }
}