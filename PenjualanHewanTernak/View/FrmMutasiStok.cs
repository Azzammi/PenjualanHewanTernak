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
using PenjualanHewanTernak.Controller.MutasiStok;
using PenjualanHewanTernak.Controller.Kandang;
using PenjualanHewanTernak.Controller.Cattle;
using PenjualanHewanTernak.Model;

namespace PenjualanHewanTernak.View
{
    public partial class FrmMutasiStok : Form
    {
        #region Declaration
        AppController m_AppController;
        MutasiStokList m_MutasiList;
        PosMutasiStokList m_PosMutasiList;
        KandangList m_KandangList;
        CattleList m_CattleList;

        #endregion


        public FrmMutasiStok()
        {
            InitializeComponent();
            //
            // status event changed
            //
            this.statusChanged += new FormStatusChangedEventHandler(this.StatusChanged);
        }

        private void FrmMutasiStok_Load(object sender, EventArgs e)
        {
            //Initialize Controller
            m_AppController = new AppController();

            /* Note that the DataProvider class is static, so it doesn't
             * get instantiated. */

            //Get Mutasi Stok List
            CommandGetMutasiStok getMutasi = new CommandGetMutasiStok();
            m_MutasiList = (MutasiStokList)m_AppController.ExecuteCommand(getMutasi);

            //Get PosMutasiStok List
            CommandGetPosMutasiStok getPosMutasi = new CommandGetPosMutasiStok();
            m_PosMutasiList = (PosMutasiStokList)m_AppController.ExecuteCommand(getPosMutasi);

            //Get Kandang List
            CommandGetKandang getKandang = new CommandGetKandang();
            m_KandangList = (KandangList)m_AppController.ExecuteCommand(getKandang);

            //Get Cattle
            CommandGetCattle getCattle = new CommandGetCattle();
            m_CattleList = (CattleList)m_AppController.ExecuteCommand(getCattle);

            //Bind to datasource
            mutasiStokItemBindingSource.DataSource = m_MutasiList;
            posMutasiStokItemBindingSource.DataSource = m_PosMutasiList;
            kandangItemBindingSource.DataSource = m_KandangList;
            cattleItemBindingSource.DataSource = m_CattleList;            
        }

        //This was called in Form Designer in IsNewRow Properties
        protected void OnStatusChanged(FormStatusChangedEventArgs e)
        {
            //Report change
            statusChanged?.Invoke(this, e);
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            mutasiStokItemBindingSource.AddNew();
            IsNewRow = Status.addNewMode;
        }

        //Method on the form side
        private void StatusChanged(object sender, FormStatusChangedEventArgs e)
        {
            if(e.FormStatus == Status.addNewMode)
            {
                AddBtn.Enabled = false;
                DeleteBtn.Enabled = false;
            }
            else if(e.FormStatus == Status.editMode)
            {
                AddBtn.Enabled = true;
                DeleteBtn.Enabled = true;
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            IsNewRow = Status.editMode;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                masukTextBox.Visible = true;
                masukLabel.Visible = true;
                keluarTextBox.Visible = false;
                keluarLabel.Visible = false;
            }
            else
            {
                masukTextBox.Visible = false;
                masukLabel.Visible = false;
                keluarTextBox.Visible = true;
                keluarLabel.Visible = true;
            }
        }

        private void keluarTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }
    }

}
