using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PenjualanHewanTernak.Model;

namespace PenjualanHewanTernak.Controller.MutasiStok
{
    class CommandUpdateMutasiStok : Command
    {
        #region Declaration        
        bool isDecrementStock;
        MutasiStokItem m_Item;
        #endregion

        #region Constructor
        public CommandUpdateMutasiStok(MutasiStokItem item, bool decrementStock)
        {           
            isDecrementStock = decrementStock;
            m_Item = item;
        }
        #endregion

        #region Method
        public override object Execute()
        {
            m_Item.UpdateDatabaseRecord(isDecrementStock);
            return m_Item;
        }
        #endregion
    }
}
