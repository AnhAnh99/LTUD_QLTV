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
namespace project
{
    public partial class frmDSPN : Form
    {
        public static int login = 0;
        private static frmDSPN formDSPN = null;
        public static frmDSPN tao()
        {
            //Kiem tra form dang mo
            if (formDSPN == null || formDSPN.IsDisposed)
                formDSPN = new frmDSPN();
            //Phân quyền
            if (login == 0)
            {
                formDSPN.cbTEN_SANPHAM.Enabled = false;
                formDSPN.dateTimePicker1.Enabled = false;
                formDSPN.txtSL.ReadOnly = true;
                formDSPN.txtID_PhieuNhap.ReadOnly = true;
                formDSPN.txtID_CTPN.ReadOnly = true;
                formDSPN.txtID_CTPN.ReadOnly = true;

                foreach (Control ctr in formDSPN.pn.Controls)
                    ctr.Enabled = false;
            }
            else
            {
                formDSPN.cbTEN_SANPHAM.Enabled = true;
                formDSPN.dateTimePicker1.Enabled = true;
                formDSPN.txtSL.ReadOnly = false;
                formDSPN.txtID_CTPN.ReadOnly = false;

                foreach (Control ctr in formDSPN.pn.Controls)
                    ctr.Enabled = true;
            }
            //Lay du lieu tu DB
            load();
            //
            formDSPN.MdiParent = frmMenu.tao();
            return formDSPN;
        }
        /// <summary>
        /// lấy dữ liệu từ DB
        /// </summary>
        static void load()
        {
            DataTable DSPN = DB.tableTruyVan(@"EXEC SP_DSPN");
            formDSPN.dataGridView1.DataSource = DSPN;
            DataTable DS_TEN_SANPHAM = DB.tableTruyVan(@"SELECT TEN_SANPHAM FROM SANPHAM");
            formDSPN.cbTEN_SANPHAM.DataSource = DS_TEN_SANPHAM;
            formDSPN.cbTEN_SANPHAM.DisplayMember = "TEN_SANPHAM";
            formDSPN.dataGridView1.Rows[0].Selected = true;
            try
            {
                formDSPN.cbTEN_SANPHAM.SelectedIndex = formDSPN.cbTEN_SANPHAM.FindStringExact(formDSPN.dataGridView2.SelectedRows[0].Cells["TEN_SANPHAM"].Value.ToString());
            }
            catch
            {
                formDSPN.txtID_SANPHAM.Text = formDSPN.txtDONGIA.Text = "";
                formDSPN.cbTEN_SANPHAM.SelectedIndex = -1;
            }
        }
        public frmDSPN()
        {
            InitializeComponent();
        }

        private void frmDSPN_FormClosing(object sender, FormClosingEventArgs e)
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
                txtID_PhieuNhap.ReadOnly = true;

                if (login != 0)
                    dateTimePicker1.Enabled = true;
                string sNgay = dataGridView1.SelectedRows[0].Cells["NGAYNHAP"].Value.ToString().Substring(0, dataGridView1.SelectedRows[0].Cells["NGAYNHAP"].Value.ToString().Length - 12);
                string[] sTachNgay = sNgay.Split(new string[] { "/" }, StringSplitOptions.RemoveEmptyEntries);
                dateTimePicker1.Value = new DateTime(int.Parse(sTachNgay[2]), int.Parse(sTachNgay[1]), int.Parse(sTachNgay[0]));
                txtID_PhieuNhap.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                DataTable DSCTPN = DB.tableTruyVan(@"SELECT ID_CTPN, CTPN.ID_SANPHAM, TEN_SANPHAM, DONGIA, SL
                                                 FROM CTPN JOIN SANPHAM SP ON CTPN.ID_SANPHAM = SP.ID_SANPHAM JOIN PHIEUNHAPKHO PNK ON PNK.ID_PHIEUNHAPKHO = CTPN.ID_PHIEUNHAPKHO
                                                 WHERE PNK.ID_PHIEUNHAPKHO = " + dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                dataGridView2.DataSource = DSCTPN;
                dataGridView2.Rows[0].Selected = true;
            }
            catch
            {
                if (login != 0)
                {
                    txtID_PhieuNhap.ReadOnly = false;
                    btnThem.Enabled = true;
                    btnXoa.Enabled = false;
                    btnSua.Enabled = false;
                    txtID_CTPN.ReadOnly = false;
                }
                foreach (Control ctr in pnTxt.Controls)
                {
                    ctr.Text = "";
                    dataGridView2.DataSource = null;
                }
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
                txtID_CTPN.ReadOnly = true;

                txtID_CTPN.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
                txtID_SANPHAM.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
                txtDONGIA.Text = dataGridView2.SelectedRows[0].Cells[3].Value.ToString();
                txtSL.Text = dataGridView2.SelectedRows[0].Cells[4].Value.ToString();
                cbTEN_SANPHAM.SelectedIndex = cbTEN_SANPHAM.FindStringExact(dataGridView2.SelectedRows[0].Cells[2].Value.ToString());
            }
            catch
            {
                if (login != 0)
                {
                    txtID_CTPN.ReadOnly = false;
                    btnThem.Enabled = true;
                    btnSua.Enabled = false;
                }
                foreach (Control ctr in pnTxt2.Controls)
                    ctr.Text = "";
                cbTEN_SANPHAM.SelectedIndex = -1;
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
            foreach (char c in txtID_PhieuNhap.Text)
            {
                if (!char.IsDigit(c))
                {
                    MessageBox.Show("ID không được có chữ");
                    txtID_PhieuNhap.Text = "";
                    nTest = 2;
                    break;
                }
            }
            //IDCT không được có chữ
            foreach (char c in txtID_CTPN.Text)
            {
                if (!char.IsDigit(c))
                {
                    MessageBox.Show("IDCT không được có chữ");
                    txtID_CTPN.Text = "";
                    nTest = 2;
                    break;
                }
            }
            //ID_CTPN bị trùng
            if (nTest != 2)
            {
                try
                {
                    int idct = int.Parse(DB.tableTruyVan("SELECT COUNT(ID_CTPN) FROM CTPN WHERE ID_CTPN = " + txtID_CTPN.Text).Rows[0][0].ToString());
                    if (idct != 0)
                    {
                        MessageBox.Show("ID_CTPN bị trùng");
                        nTest = 1;
                        txtID_CTPN.Text = "";
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
                if (dataGridView1.Rows[i].Cells["ID_PHIEUNHAPKHO"].Value.ToString() == txtID_PhieuNhap.Text)
                {
                    nTT = 1;
                    break;
                }
            }
            //Nếu ID không tồn tại thì thêm mới
            if (nTT == 0)
            {
                string sNgay = dateTimePicker1.Value.ToString().Substring(0, dateTimePicker1.Value.ToString().Length - 12);
                DB.tableTruyVan(string.Format("set dateformat dmy; EXEC SP_THEMPHIEUNHAP {0}, '{1}'", txtID_PhieuNhap.Text, sNgay));
            }
            //Thêm CT
            DB.tableTruyVan(string.Format("EXEC SP_THEMCTPN {0}, {1}, {2}, {3}", txtID_CTPN.Text, txtID_PhieuNhap.Text, txtID_SANPHAM.Text, txtSL.Text));
            load();
            MessageBox.Show("Thêm thành công");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Xác nhận xóa", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;
                DB.tableTruyVan("EXEC SP_XOACTPN " + txtID_CTPN.Text);
                load();
                MessageBox.Show("Xóa thành công");
            }
            catch
            {
                try
                {
                    DB.tableTruyVan(@"DELETE FROM CTPN
                                  WHERE CTPN.ID_PHIEUNHAPKHO = " + txtID_PhieuNhap.Text);
                    DB.tableTruyVan("EXEC SP_XOAPHIEUNHAP " + txtID_PhieuNhap.Text);
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
            DB.tableTruyVan(string.Format("set dateformat dmy; EXEC SP_SUAPHIEUNHAP {0}, '{1}'", txtID_PhieuNhap.Text, sNgay));
            DB.tableTruyVan(string.Format("EXEC SP_SUACTPN {0}, {1}, {2}", txtID_CTPN.Text, txtID_SANPHAM.Text, txtSL.Text));
            load();
            MessageBox.Show("Sửa thành công");
        }
    }
}