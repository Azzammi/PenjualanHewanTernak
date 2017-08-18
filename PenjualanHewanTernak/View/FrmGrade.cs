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
using PenjualanHewanTernak.Controller.Grade;
using PenjualanHewanTernak.Model;

namespace PenjualanHewanTernak.View
{
    public partial class FrmGrade : Form
    {
        #region Declarations
        AppController m_AppController;
        GradeList m_ItemList;
        bool isNewRecord = false;
        #endregion

        #region Constructor
        public FrmGrade()
        {
            InitializeComponent();
        }
        #endregion

        private void AddBtn_Click(object sender, EventArgs e)
        {
            isNewRecord = true;
            gradeItemBindingSource.AddNew();
            gradeItemDataGridView.Focus();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (m_ItemList == null) return;

            GradeItem m_item = (GradeItem)gradeItemBindingSource.Current;

            if (m_item == null) return;

            if (isNewRecord)
            {
                CommandInsertGrade createItem = new CommandInsertGrade(m_item);
                GradeItem newItem = (GradeItem)m_AppController.ExecuteCommand(createItem);
            }
            else if (!isNewRecord)
            {
                CommandUpdateGrade updateItem = new CommandUpdateGrade(m_item);
                GradeItem changeItem = (GradeItem)m_AppController.ExecuteCommand(updateItem);
            }

            isNewRecord = false;
        }

        private void FrmGrade_Load(object sender, EventArgs e)
        {
            //Initialize Controller
            m_AppController = new AppController();

            /* Note that the DataProvider class is static, so it doesn't
             * get instantiated. */

            //Get Group Harga List
            CommandGetGrade getItem = new CommandGetGrade();
            m_ItemList = (GradeList)m_AppController.ExecuteCommand(getItem);

            //Bind to datasource
            gradeItemBindingSource.DataSource = m_ItemList;
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            // Confirm Delete
            var pesan = MessageBox.Show("Apakah Anda Yakin Ingin Menghapus ? ", "Penghapusan", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (pesan == DialogResult.Yes)
            {              

                foreach (DataGridViewRow row in gradeItemDataGridView.SelectedRows)
                {
                    GradeItem item = row.DataBoundItem as GradeItem;
                    if(item != null)
                    {
                        CommandDeleteGrade deleteItem = new CommandDeleteGrade(m_ItemList, item);
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
