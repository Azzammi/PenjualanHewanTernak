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
using PenjualanHewanTernak.Controller.Jenis;
using PenjualanHewanTernak.Model;

namespace PenjualanHewanTernak.View
{
    public partial class FrmJenis : Form
    {
        #region Declarations
        AppController m_AppController;
        JenisList m_ItemList;
        bool isNewRecord = false;
        #endregion

        #region Constructor
        public FrmJenis()
        {
            InitializeComponent();
        }
        #endregion

        private void AddBtn_Click(object sender, EventArgs e)
        {
            isNewRecord = true;
            jenisItemBindingSource.AddNew();
            jenisItemDataGridView.Focus();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            //Finish editing datagridview
            jenisItemDataGridView.EndEdit();

            if (m_ItemList == null) return;

            JenisItem m_item = (JenisItem)jenisItemBindingSource.Current;
            if (m_item == null) return;

            if (isNewRecord)
            {
                CommandInsertJenis createItem = new CommandInsertJenis(m_item);
                JenisItem newItem = (JenisItem)m_AppController.ExecuteCommand(createItem);
            }
            else if (!isNewRecord)
            {
                CommandUpdateJenis updateItem = new CommandUpdateJenis(m_item);
                JenisItem changeItem = (JenisItem)m_AppController.ExecuteCommand(updateItem);
            }

            isNewRecord = false;
        }

        private void FrmJenis_Load(object sender, EventArgs e)
        {
            //Initialize Controller
            m_AppController = new AppController();

            /* Note that the DataProvider class is static, so it doesn't
             * get instantiated. */

            //Get Group Harga List
           CommandGetJenis getItem = new CommandGetJenis();
            m_ItemList = (JenisList)m_AppController.ExecuteCommand(getItem);

            //Bind to datasource
            jenisItemBindingSource.DataSource = m_ItemList;
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            // Confirm Delete
            var pesan = MessageBox.Show("Apakah Anda Yakin Ingin Menghapus ? ", "Penghapusan", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (pesan == DialogResult.Yes)
            {

                foreach (DataGridViewRow row in jenisItemDataGridView.SelectedRows)
                {
                    JenisItem item = row.DataBoundItem as JenisItem;
                    if (item != null)
                    {
                        CommandDeleteJenis deleteItem = new CommandDeleteJenis(m_ItemList, item);
                        m_AppController.ExecuteCommand(deleteItem);
                    }

                }
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteBtn.PerformClick();
        }
    }
}
