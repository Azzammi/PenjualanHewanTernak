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
using PenjualanHewanTernak.Controller.Harga;
using PenjualanHewanTernak.Controller.Cattle;
using PenjualanHewanTernak.Controller.Grade;
using PenjualanHewanTernak.Model;

namespace PenjualanHewanTernak.View
{
    public partial class FrmHarga : Form
    {
        #region Declarations
        AppController m_AppController;
        HargaList m_ItemList;
        GradeList m_GradeList;
        CattleList m_CattleList;
        bool isNewRecord;
        #endregion
        public FrmHarga()
        {
            InitializeComponent();
        }

        private void FrmHarga_Load(object sender, EventArgs e)
        {
            //Initialize Controller
            m_AppController = new AppController();

            /* Note that the DataProvider class is static, so it doesn't
             * get instantiated. */

            //Get Group Harga List
            CommandGetHarga getItem = new CommandGetHarga();
            m_ItemList = (HargaList)m_AppController.ExecuteCommand(getItem);

            //Get Grade List
            CommandGetGrade getGrade = new CommandGetGrade();
            m_GradeList = (GradeList)m_AppController.ExecuteCommand(getGrade);

            //Get Cattle List
            CommandGetCattle getCattle = new CommandGetCattle();
            m_CattleList = (CattleList)m_AppController.ExecuteCommand(getCattle);

            //Bind to datasource
            hargaItemBindingSource.DataSource = m_ItemList;
            gradeItemBindingSource.DataSource = m_GradeList;
            cattleItemBindingSource.DataSource = m_CattleList;
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            isNewRecord = true;
            hargaItemBindingSource.AddNew();
            kodeGradeComboBox.Focus();                
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (m_ItemList == null) return;

            HargaItem m_item = (HargaItem)hargaItemBindingSource.Current;      

            if (m_item == null) return;

            if (isNewRecord)
            {
                CommandInsertHarga createItem = new CommandInsertHarga(m_item);
                HargaItem newItem = (HargaItem)m_AppController.ExecuteCommand(createItem);
            }
            else if (!isNewRecord)
            {
                CommandUpdateHarga updateItem = new CommandUpdateHarga(m_item);
                HargaItem changeItem = (HargaItem)m_AppController.ExecuteCommand(updateItem);
            }

            isNewRecord = false;
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (m_ItemList == null) return;

            HargaItem m_item = (HargaItem)hargaItemBindingSource.Current;
            if (m_item == null) return;

            // Confirm Delete
            var pesan = MessageBox.Show("Apakah Anda Yakin Ingin Menghapus ? ", "Penghapusan", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (pesan == DialogResult.Yes)
            {               
                CommandDeleteHarga deleteItem = new CommandDeleteHarga(m_ItemList, m_item);
                m_AppController.ExecuteCommand(deleteItem);                 
            }
        }

        private void gantiHargaBtn_Click(object sender, EventArgs e)
        {
            if (m_ItemList == null) return;

            HargaItem m_item = (HargaItem)hargaItemBindingSource.Current;
            if (m_item == null) return;

            var pesan = MessageBox.Show("Apakah Anda Yakin Ingin Mengganti Harga ? ", "Ganti Harga", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (pesan == DialogResult.Yes)
            {
                //CommandGantiHarga gantiharga = new CommandGantiHarga(m_item);
                //HargaItem newHarga = (HargaItem)m_AppController.ExecuteCommand(gantiharga);
                beforePriceTextBox.Text = currentPriceTextBox.Text;
                beforePriceDateDateTimePicker.Value = currentPriceDateDateTimePicker.Value;
                currentPriceTextBox.Text = "0";
                currentPriceDateDateTimePicker.Value = DateTime.Now;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(kodeHewanComboBox.SelectedValue.ToString());
            //kodeHewanComboBox.DataBindings.Add("SelectedValue", cattleItemBindingSource, "KodeHewan");

        }
    }
}
