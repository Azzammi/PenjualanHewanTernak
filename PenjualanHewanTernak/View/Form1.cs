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
using PenjualanHewanTernak.Controller.Cattle;
using PenjualanHewanTernak.Controller.Jenis;
using PenjualanHewanTernak.Controller.Grade;
using PenjualanHewanTernak.Model;

namespace PenjualanHewanTernak.View
{
    public partial class Form1 : Form
    {
        #region Declarations
        AppController m_AppController;
        CattleList m_ItemList;
        JenisList m_JenisList;
        GradeList m_GradeList;

        bool isNewRecord = false;
        bool isAddRow = false;
        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Initialize Controller
            m_AppController = new AppController();

            /* Note that the DataProvider class is static, so it doesn't
             * get instantiated. */

            //Get Group Harga List
            CommandGetCattle getItem = new CommandGetCattle();
            m_ItemList = (CattleList)m_AppController.ExecuteCommand(getItem);

            //Get Jenis Combobox Data
            CommandGetJenis getJenis = new CommandGetJenis();
            m_JenisList = (JenisList)m_AppController.ExecuteCommand(getJenis);

            //Get Grade Combobox Data
            CommandGetGrade getGrade = new CommandGetGrade();
            m_GradeList = (GradeList)m_AppController.ExecuteCommand(getGrade);

            //Bind to datasource
            cattleItemBindingSource.DataSource = m_ItemList;
            jenisItemBindingSource.DataSource = m_JenisList;
            gradeItemBindingSource.DataSource = m_GradeList;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            isNewRecord = true;
            cattleItemBindingSource.AddNew();
            cattleItemDataGridView.Focus();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            cattleItemDataGridView.EndEdit();

            if (m_ItemList == null) return;

            CattleItem m_item = (CattleItem)cattleItemBindingSource.Current;
            if (m_item == null) return;

            if (isNewRecord)
            {
                CommandInsertCattle createItem = new CommandInsertCattle(m_item);
                CattleItem newItem = (CattleItem)m_AppController.ExecuteCommand(createItem);
            }
            else if (!isNewRecord)
            {
                CommandUpdateCattle updateItem = new CommandUpdateCattle(m_item);
                CattleItem changeItem = (CattleItem)m_AppController.ExecuteCommand(updateItem);
            }

            isNewRecord = false;
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            // Confirm Delete
            var pesan = MessageBox.Show("Apakah Anda Yakin Ingin Menghapus ? ", "Penghapusan", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (pesan == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in cattleItemDataGridView.SelectedRows)
                {
                    CattleItem item = row.DataBoundItem as CattleItem;
                    if (item != null)
                    {
                        CommandDeleteCattle deleteItem = new CommandDeleteCattle(m_ItemList, item);
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
