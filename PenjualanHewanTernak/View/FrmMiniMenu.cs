using System;
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
    }
}
