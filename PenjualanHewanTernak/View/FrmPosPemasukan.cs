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
using PenjualanHewanTernak.Controller.Pemasukan;

namespace PenjualanHewanTernak.View
{
    public partial class FrmPosPemasukan : Form
    {
        #region Declarations
        AppController m_AppController;
        posPemasukaList m_ItemList;

        #endregion

        public FrmPosPemasukan()
        {
            InitializeComponent();
        }

        private void FrmPosPemasukan_Load(object sender, EventArgs e)
        {
            //Initialize Controller
            m_AppController = new AppController();

            /* Note that the DataProvider class is static, so it doesn't
             * get instantiated. */

            //Get Group Harga List
            CommandGetPosPemasukan getItem = new CommandGetPosPemasukan();
            m_ItemList = (posPemasukaList)m_AppController.ExecuteCommand(getItem);

            //Bind to datasource
            posPemasukanItemBindingSource.DataSource = m_ItemList;
        }

        private void posPemasukanItemBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            //if list is null then do nothing
            if (m_ItemList == null) return;

            //Initialize Command object
            CommandInsertPosPemasukan createPosPemasukan = new CommandInsertPosPemasukan();
            posPemasukanItem newPosPemasukan = (posPemasukanItem)m_AppController.ExecuteCommand(createPosPemasukan);

            //Return the new item
            e.NewObject = newPosPemasukan;
        }

        private void posPemasukanItemBindingSource_ListChanged(object sender, ListChangedEventArgs e)
        {
            /* This event will be called several times during form initialization.
             * We don't want to do anything with it until the runtime author
             * list has been passed in. */

            // Exit if no parent
            if (m_ItemList == null) return;

            // Get the item affected
            int index = e.NewIndex;
            posPemasukanItem changedItem = null;
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
                    CommandUpdatePosPemasukan updatePosPemasukan = new CommandUpdatePosPemasukan(changedItem);
                    m_AppController.ExecuteCommand(updatePosPemasukan);
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

                foreach (DataGridViewRow row in posPemasukanItemDataGridView.SelectedRows)
                {
                    posPemasukanItem item = row.DataBoundItem as posPemasukanItem;
                    if (item != null)
                    {
                        CommandDeletePosPemasukan deleteItem = new CommandDeletePosPemasukan(m_ItemList, item);
                        m_AppController.ExecuteCommand(deleteItem);
                    }

                }
            }
        }
    }
}
