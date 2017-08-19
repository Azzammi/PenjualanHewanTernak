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
using PenjualanHewanTernak.Controller.Kandang;
using PenjualanHewanTernak.Model;

namespace PenjualanHewanTernak.View
{
    public partial class FrmKandang : Form
    {
        #region Declaration
        AppController m_AppController;
        KandangList m_KandangList;
        bool isNewRecord = false;
        #endregion

        public FrmKandang()
        {
            InitializeComponent();
        }

        private void FrmKandang_Load(object sender, EventArgs e)
        {
            //Initiate Controller
            m_AppController = new AppController();

            //Get Data Kandang
            CommandGetKandang getKandang = new CommandGetKandang();
            m_KandangList = (KandangList)m_AppController.ExecuteCommand(getKandang);

            kandangItemBindingSource.DataSource = m_KandangList;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            isNewRecord = true;
            kandangItemBindingSource.AddNew();
            kandangItemDataGridView.Focus();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (m_KandangList == null) return;

            KandangItem m_item = (KandangItem)kandangItemBindingSource.Current;

            if (m_item == null) return;

            if (isNewRecord)
            {
                CommandInsertKandang createItem = new CommandInsertKandang(m_item);
                KandangItem newItem = (KandangItem)m_AppController.ExecuteCommand(createItem);
            }
            else if (!isNewRecord)
            {
                CommandUpdateKandang updateItem = new CommandUpdateKandang(m_item);
                KandangItem changeItem = (KandangItem)m_AppController.ExecuteCommand(updateItem);
            }

            isNewRecord = false;
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            // Confirm Delete
            var pesan = MessageBox.Show("Apakah Anda Yakin Ingin Menghapus ? ", "Penghapusan", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (pesan == DialogResult.Yes)
            {

                foreach (DataGridViewRow row in kandangItemDataGridView.SelectedRows)
                {
                    KandangItem item = row.DataBoundItem as KandangItem;
                    if (item != null)
                    {
                        CommandDeleteKandang deleteItem = new CommandDeleteKandang(m_KandangList, item);
                        m_AppController.ExecuteCommand(deleteItem);
                    }

                }
            }
        }
    }
}
