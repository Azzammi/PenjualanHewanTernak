using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PenjualanHewanTernak.Controller;
using PenjualanHewanTernak.Controller.MutasiStok;
using PenjualanHewanTernak.Model;

namespace PenjualanHewanTernak.View
{
    public partial class FrmViewMutasiStok : Form
    {
        #region Declaration
        AppController m_AppController;
        MutasiStokList m_MutasiList;        
        #endregion

        public FrmViewMutasiStok()
        {
            InitializeComponent();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            FrmMutasiStok formMutasi = new FrmMutasiStok();
            formMutasi.ShowDialog();
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            FrmMutasiStok formMutasi = new FrmMutasiStok(mutasiStokItemBindingSource.Position);
            formMutasi.ShowDialog();
        }

        private void FrmViewMutasiStok_Load(object sender, EventArgs e)
        {
            //Initialize Controller
            m_AppController = new AppController();

            /* Note that the DataProvider class is static, so it doesn't
             * get instantiated. */

            //Get Mutasi Stok List
            CommandGetMutasiStok getMutasi = new CommandGetMutasiStok();
            m_MutasiList = (MutasiStokList)m_AppController.ExecuteCommand(getMutasi);
            
            //Bind to datasource
            mutasiStokItemBindingSource.DataSource = m_MutasiList;            
        }

        private void mutasiStokItemBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            // Confirm Delete
            var pesan = MessageBox.Show("Apakah Anda Yakin Ingin Menghapus ? ", "Penghapusan", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (pesan == DialogResult.Yes)
            {

                foreach (DataGridViewRow row in mutasiStokItemDataGridView.SelectedRows)
                {
                    MutasiStokItem item = row.DataBoundItem as MutasiStokItem;
                    if (item != null)
                    {
                        CommandDeleteMutasiStok deleteItem = new CommandDeleteMutasiStok(m_MutasiList, item);
                        m_AppController.ExecuteCommand(deleteItem);
                    }

                }
            }
        }
    }
}
