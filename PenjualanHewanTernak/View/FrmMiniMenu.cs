﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PenjualanHewanTernak.View
{
    public partial class FrmMiniMenu : Form
    {
        public FrmMiniMenu()
        {
            InitializeComponent();
        }

        private void hEWANToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.ShowDialog();
        }

        private void jENISToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmJenis form = new FrmJenis();
            form.ShowDialog();
        }

        private void gRADEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGrade form = new FrmGrade();
            form.ShowDialog();
        }

        private void FrmMiniMenu_Load(object sender, EventArgs e)
        {

        }

        private void hargaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmHarga form = new FrmHarga();
            form.ShowDialog();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCustomer form = new FrmCustomer();
            form.ShowDialog();
        }

        private void kandangToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmKandang form = new FrmKandang();
            form.ShowDialog();
        }

        private void posMutasiStokToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPosMutasiStok form = new FrmPosMutasiStok();
            form.ShowDialog();
        }

        private void mutasiStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMutasiStok form = new FrmMutasiStok();
            form.ShowDialog();
        }

        private void viewMutasiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmViewMutasiStok form = new FrmViewMutasiStok();
            form.Show(); 
        }

        private void stockToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmStok form = new FrmStok();
            form.ShowDialog();
        }

        private void posPemasukanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPosPemasukan form = new FrmPosPemasukan();
            form.ShowDialog();
        }

        private void posPengeluaranToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPosPengeluaran form = new FrmPosPengeluaran();
            form.ShowDialog();
        }
    }
}
