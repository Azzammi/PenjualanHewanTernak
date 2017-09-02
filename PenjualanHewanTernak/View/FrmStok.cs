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
using PenjualanHewanTernak.Controller.Stok;
using PenjualanHewanTernak.Model;

namespace PenjualanHewanTernak.View
{
    public partial class FrmStok : Form
    {
        #region Declaration
        AppController m_AppController;
        StockList m_StockList;
        #endregion

        public FrmStok()
        {
            InitializeComponent();
        }

        private void FrmStok_Load(object sender, EventArgs e)
        {
            //Initialize Controller
            m_AppController = new AppController();

            /* Note that the DataProvider class is static, so it doesn't
             * get instantiated. */

            //Get Mutasi Stok List
            CommandGetStok getStok = new CommandGetStok();
            m_StockList = (StockList)m_AppController.ExecuteCommand(getStok);

            //Bind to datasource
            stockItemBindingSource.DataSource = m_StockList;     
        }
    }
}
