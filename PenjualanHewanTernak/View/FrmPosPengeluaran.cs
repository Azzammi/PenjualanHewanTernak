using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PenjualanHewanTernak.Model;
using PenjualanHewanTernak.Controller;
using PenjualanHewanTernak.Controller.Pengeluaran;

namespace PenjualanHewanTernak.View
{
    public partial class FrmPosPengeluaran : Form
    {
        #region Declarations
        AppController m_AppController;
        PosPengeluaranList m_ItemList;
        
        #endregion

        public FrmPosPengeluaran()
        {
            InitializeComponent();
        }

        private void FrmPosPengeluaran_Load(object sender, EventArgs e)
        {
            //Initialize Controller
            m_AppController = new AppController();

            /* Note that the DataProvider class is static, so it doesn't
             * get instantiated. */

            //Get Group Harga List
            CommandGetPosPengeluaran getItem = new CommandGetPosPengeluaran();
            m_ItemList = (PosPengeluaranList)m_AppController.ExecuteCommand(getItem);

            //Bind to datasource
            posPengeluaranItemBindingSource.DataSource = m_ItemList;
        }

        private void posPengeluaranItemBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            //if list is null then do nothing
            if (m_ItemList == null) return;

            //Initialize Command object
            CommandInsertPosPengeluaran createPosPengeluaran = new CommandInsertPosPengeluaran();
            posPengeluaranItem newPosPengeluaran = (posPengeluaranItem)m_AppController.ExecuteCommand(createPosPengeluaran);

            //Return the new item
            e.NewObject = newPosPengeluaran;
        }

        private void posPengeluaranItemBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            /* This event will be called several times during form initialization.
             * We don't want to do anything with it until the runtime author
             * list has been passed in. */

            // Exit if no parent
            if (m_ItemList == null) return;

            // Get the item affected
            int index = e.NewIndex;
            posPengeluaranItem changedItem = null;
            if ((index > -1) && (index < m_ItemList.Count))
            {
                changedItem = m_ItemList[index];
            }

            // Get the type of change that occured
            ListChangedType changeType = e.ListChangedType;

            /* We only need to respond to two types of changes here; updates
             * and moves. Adds are handled by bindingSourceAuthors_AddingNew(),
             * and deletes are handled by menuItemBooksDelete_Click(). */

            // Dispatch a change handler
            switch (changeType)
            {
                case ListChangedType.ItemChanged:
                    CommandUpdatePosPengeluaran updatePosPengeluaran = new CommandUpdatePosPengeluaran(changedItem);
                    m_AppController.ExecuteCommand(updatePosPengeluaran);
                    break;

                case ListChangedType.ItemMoved:
                    // Not supported in this app
                    break;
            }
        }

        private void deletesRecordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Confirm Delete
            var pesan = MessageBox.Show("Apakah Anda Yakin Ingin Menghapus ? ", "Penghapusan", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (pesan == DialogResult.Yes)
            {

                foreach (DataGridViewRow row in posPengeluaranItemDataGridView.SelectedRows)
                {
                    posPengeluaranItem item = row.DataBoundItem as posPengeluaranItem;
                    if (item != null)
                    {
                        CommandDeletePosPengeluaran deleteItem = new CommandDeletePosPengeluaran(m_ItemList, item);
                        m_AppController.ExecuteCommand(deleteItem);
                    }

                }
            }
        }
    }
}
