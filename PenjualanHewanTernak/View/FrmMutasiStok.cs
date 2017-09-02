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

        //int bindingPosition;
        //Status formStatus;
        #endregion

        #region Constructor
        public FrmMutasiStok()
        {
            InitializeComponent();
            //
            // status event changed added
            //
            this.statusChanged += new FormStatusChangedEventHandler(this.StatusChanged);

            //Load the list and put it to bindingsource
            this.FrmMutasiStok_Load();

            //Set the crud status
            IsNewRow = Status.NewRecord;
        }
        public FrmMutasiStok(int bindingIndexer)
        {
            InitializeComponent();
            //
            // status event changed added
            //
            this.statusChanged += new FormStatusChangedEventHandler(this.StatusChanged);

            //Load the list and put it to binding source
            this.FrmMutasiStok_Load();

            //Set the crud status
            IsNewRow = Status.OnEditMode;

            //Set the index of bindingSource
            mutasiStokItemBindingSource.Position = bindingIndexer;
        }
        #endregion


        private void FrmMutasiStok_Load()
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
            IsNewRow = Status.NewRecord;
        }

        //Method on the form side
        private void StatusChanged(object sender, FormStatusChangedEventArgs e)
        {            
            switch (e.FormStatus)
            {
                case Status.Init:                    
                    SaveBtn.Enabled = false;
                    break;
                case Status.OnEditMode:                    
                    SaveBtn.Enabled = true;
                    break;
                case Status.NewRecord:
                    mutasiStokItemBindingSource.AddNew();               
                    SaveBtn.Enabled = true;
                    break;
                default:
                    break;
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (m_MutasiList == null) return;

            MutasiStokItem parent = (MutasiStokItem)mutasiStokItemBindingSource.Current;
            if (parent == null) return;

            CommandUpdateMutasiStok changeMutasi = new CommandUpdateMutasiStok(parent, checkBox1.Checked);
            m_AppController.ExecuteCommand(changeMutasi);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
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

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            switch (IsNewRow)
            {
                case Status.Init:
                    break;
                case Status.OnEditMode:
                    break;
                case Status.Ready:
                    break;
                case Status.NewRecord:
                    
                    break;
                default:
                    break;
            }
        }
        
        private void FrmMutasiStok_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void mutasiStokItemBindingSource_AddingNew(object sender, AddingNewEventArgs e)
        {
            if (m_MutasiList == null) return;

            CommandInsertMutasi createMutasi = new CommandInsertMutasi();
            MutasiStokItem newMutasi = (MutasiStokItem)m_AppController.ExecuteCommand(createMutasi);

            e.NewObject = newMutasi;
        }

        private void FrmMutasiStok_Load(object sender, EventArgs e)
        {

        }
    }

}
