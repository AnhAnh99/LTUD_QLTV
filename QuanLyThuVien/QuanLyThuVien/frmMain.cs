﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThuVien
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void thôngTinBạnĐọcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BanDoc bandoc = new BanDoc();
            bandoc.ShowDialog();
        }

        private void thôngTinSáchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSach s = new frmSach();
            s.ShowDialog();
        }

        private void phiếuMượnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPhieuMuon pm = new frmPhieuMuon();
            pm.ShowDialog();
        }
    }
}