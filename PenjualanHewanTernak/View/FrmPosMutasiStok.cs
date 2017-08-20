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
using PenjualanHewanTernak.Controller.PosMutasiStok;
using PenjualanHewanTernak.Model;

namespace PenjualanHewanTernak.View
{
    public partial class FrmPosMutasiStok : Form
    {
        #region Declaration
        AppController m_AppController;
        PosMutasiStokList m_List;
        bool isNewRecord = false;
        #endregion

        public FrmPosMutasiStok()
        {
            InitializeComponent();
        }

        private void FrmPosMutasiStok_Load(object sender, EventArgs e)
        {
            //Initiate the controller
            m_AppController = new AppController();

            //Get data
            CommandGetPosMutasiStok getList = new CommandGetPosMutasiStok();
            m_List = (PosMutasiStokList)m_AppController.ExecuteCommand(getList);

            posMutasiStokItemBindingSource.DataSource = m_List;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            isNewRecord = true;
            posMutasiStokItemBindingSource.AddNew();
            posMutasiStokItemDataGridView.Focus();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (m_List == null) return;

            PosMutasiStokItem m_item = (PosMutasiStokItem)posMutasiStokItemBindingSource.Current;
            if (m_item == null) return;

            if (isNewRecord)
            {
                CommandInsertPosMutasiStok createItem = new CommandInsertPosMutasiStok(m_item);
                PosMutasiStokItem newItem = (PosMutasiStokItem)m_AppController.ExecuteCommand(createItem);
            }
            else if (!isNewRecord)
            {
                CommandUpdatePosMutasiStok updateItem = new CommandUpdatePosMutasiStok(m_item);
                PosMutasiStokItem changeItem = (PosMutasiStokItem)m_AppController.ExecuteCommand(updateItem);
            }

            isNewRecord = false;
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            // Confirm Delete
            var pesan = MessageBox.Show("Apakah Anda Yakin Ingin Menghapus ? ", "Penghapusan", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (pesan == DialogResult.Yes)
            {

                foreach (DataGridViewRow row in posMutasiStokItemDataGridView.SelectedRows)
                {
                    PosMutasiStokItem item = row.DataBoundItem as PosMutasiStokItem;
                    if (item != null)
                    {
                        CommandDeletePosMutasiStok deleteItem = new CommandDeletePosMutasiStok(m_List, item);
                        m_AppController.ExecuteCommand(deleteItem);
                    }

                }
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            deleteToolStripMenuItem.PerformClick();
        }
    }
}
