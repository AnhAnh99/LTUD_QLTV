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
    public partial class frmDSPX : Form
    {
        public static int login = 0;
        private static frmDSPX formDSPX = null;
        public static frmDSPX tao()
        {
            //Kiem tra form dang mo
            if (formDSPX == null || formDSPX.IsDisposed)
                formDSPX = new frmDSPX();
            //Phân quyền
            if (login == 0)
            {
                formDSPX.cbTEN_SANPHAM.Enabled = false;
                formDSPX.dateTimePicker1.Enabled = false;
                formDSPX.txtSL.ReadOnly = true;
                formDSPX.txtID_PhieuXuat.ReadOnly = true;
                formDSPX.txtID_CTPX.ReadOnly = true;

                foreach (Control ctr in formDSPX.pn.Controls)
                    ctr.Enabled = false;
            }
            else
            {
                formDSPX.cbTEN_SANPHAM.Enabled = true;
                formDSPX.dateTimePicker1.Enabled = true;
                formDSPX.txtSL.ReadOnly = false;

                foreach (Control ctr in formDSPX.pn.Controls)
                    ctr.Enabled = true;
            }
            //Lay du lieu tu DB
            load();
            //
            formDSPX.dataGridView1.Rows[0].Selected = true;
            formDSPX.MdiParent = frmMenu.tao();
            return formDSPX;
        }
        /// <summary>
        /// lấy dữ liệu từ DB
        /// </summary>
        static void load()
        {
            DataTable DSPX = DB.tableTruyVan("EXEC SP_DSPX");
            formDSPX.dataGridView1.DataSource = DSPX;
            DataTable DS_TEN_SANPHAM = DB.tableTruyVan(@"SELECT TEN_SANPHAM FROM SANPHAM");
            formDSPX.cbTEN_SANPHAM.DataSource = DS_TEN_SANPHAM;
            formDSPX.cbTEN_SANPHAM.DisplayMember = "TEN_SANPHAM";
            formDSPX.dataGridView1.Rows[0].Selected = true;
            try
            {
                formDSPX.cbTEN_SANPHAM.SelectedIndex = formDSPX.cbTEN_SANPHAM.FindStringExact(formDSPX.dataGridView2.SelectedRows[0].Cells["TEN_SANPHAM"].Value.ToString());
            }
            catch
            {
                formDSPX.txtID_SANPHAM.Text = formDSPX.txtDONGIA.Text = "";
                formDSPX.cbTEN_SANPHAM.SelectedIndex = -1;
            }
        }
        public frmDSPX()
        {
            InitializeComponent();
        }

        private void frmDSPX_FormClosing(object sender, FormClosingEventArgs e)
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
                txtID_PhieuXuat.ReadOnly = true;
                if (login != 0)
                    dateTimePicker1.Enabled = true;
                string sNgay = dataGridView1.SelectedRows[0].Cells["NGAYXUAT"].Value.ToString().Substring(0, dataGridView1.SelectedRows[0].Cells["NGAYXUAT"].Value.ToString().Length - 12);
                string[] sTachNgay = sNgay.Split(new string[] { "/" }, StringSplitOptions.RemoveEmptyEntries);
                dateTimePicker1.Value = new DateTime(int.Parse(sTachNgay[2]), int.Parse(sTachNgay[1]), int.Parse(sTachNgay[0]));
                txtID_PhieuXuat.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                DataTable DSCTPX = DB.tableTruyVan(@"SELECT ID_CTPX, CTPX.ID_SANPHAM, TEN_SANPHAM, DONGIA, SL
                                                 FROM CTPX JOIN SANPHAM SP ON CTPX.ID_SANPHAM = SP.ID_SANPHAM JOIN PHIEUXUATKHO PXK ON PXK.ID_PHIEUXUATKHO = CTPX.ID_PHIEUXUATKHO
                                                 WHERE PXK.ID_PHIEUXUATKHO = " + dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                dataGridView2.DataSource = DSCTPX;
                dataGridView2.Rows[0].Selected = true;
            }
            catch
            {
                if (login != 0)
                {
                    txtID_PhieuXuat.ReadOnly = false;
                    btnThem.Enabled = true;
                    btnXoa.Enabled = false;
                    btnSua.Enabled = false;
                    txtID_CTPX.ReadOnly = false;
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
                txtID_CTPX.ReadOnly = true;

                txtID_CTPX.Text = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
                txtID_SANPHAM.Text = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
                txtDONGIA.Text = dataGridView2.SelectedRows[0].Cells[3].Value.ToString();
                txtSL.Text = dataGridView2.SelectedRows[0].Cells[4].Value.ToString();
                cbTEN_SANPHAM.SelectedIndex = cbTEN_SANPHAM.FindStringExact(dataGridView2.SelectedRows[0].Cells[2].Value.ToString());
            }
            catch
            {
                if (login != 0)
                {
                    txtID_CTPX.ReadOnly = false;
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
            foreach (char c in txtID_PhieuXuat.Text)
            {
                if (!char.IsDigit(c))
                {
                    MessageBox.Show("ID không được có chữ");
                    txtID_PhieuXuat.Text = "";
                    nTest = 2;
                    break;
                }
            }
            //IDCT không được có chữ
            foreach (char c in txtID_CTPX.Text)
            {
                if (!char.IsDigit(c))
                {
                    MessageBox.Show("IDCT không được có chữ");
                    txtID_CTPX.Text = "";
                    nTest = 2;
                    break;
                }
            }
            //ID_CTPN bị trùng
            if (nTest != 2)
            {
                try
                {
                    int idct = int.Parse(DB.tableTruyVan("SELECT COUNT(ID_CTPX) FROM CTPX WHERE ID_CTPX = " + txtID_CTPX.Text).Rows[0][0].ToString());
                    if (idct != 0)
                    {
                        MessageBox.Show("ID_CTPN bị trùng");
                        nTest = 1;
                        txtID_CTPX.Text = "";
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
                if (dataGridView1.Rows[i].Cells["ID_PHIEUXUATKHO"].Value.ToString() == txtID_PhieuXuat.Text)
                {
                    nTT = 1;
                    break;
                }
            }
            //Nếu ID không tồn tại thì thêm mới
            if (nTT == 0)
            {
                string sNgay = dateTimePicker1.Value.ToString().Substring(0, dateTimePicker1.Value.ToString().Length - 12);
                DB.tableTruyVan(string.Format("set dateformat dmy; EXEC SP_THEMPHIEUXUAT {0}, '{1}'", txtID_PhieuXuat.Text, sNgay));
            }
            //Thêm CT
            DB.tableTruyVan(string.Format("EXEC SP_THEMCTPX {0}, {1}, {2}, {3}", txtID_CTPX.Text, txtID_PhieuXuat.Text, txtID_SANPHAM.Text, txtSL.Text));
            load();
            MessageBox.Show("Thêm thành công");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Xác nhận xóa", "Thông báo", MessageBoxButtons.YesNo) == DialogResult.No)
                    return;
                DB.tableTruyVan("EXEC SP_XOACTPX " + txtID_CTPX.Text);
                load();
                MessageBox.Show("Xóa thành công");
            }
            catch
            {
                try
                {
                    DB.tableTruyVan(@"DELETE FROM CTPX
                                  WHERE CTPX.ID_PHIEUXUATKHO = " + txtID_PhieuXuat.Text);
                    DB.tableTruyVan("EXEC SP_XOAPHIEUXUAT " + txtID_PhieuXuat.Text);
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
            DB.tableTruyVan(string.Format("set dateformat dmy; EXEC SP_SUAPHIEUXUAT {0}, '{1}'", txtID_PhieuXuat.Text, sNgay));
            DB.tableTruyVan(string.Format("EXEC SP_SUACTPX {0}, {1}, {2}", txtID_CTPX.Text, txtID_SANPHAM.Text, txtSL.Text));
            load();
            MessageBox.Show("Sửa thành công");
        }

    }
}
