using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PenjualanHewanTernak.Model;

namespace PenjualanHewanTernak.Controller.MutasiStok
{
    class CommandInsertMutasi : Command
    {
        #region Declaration
        MutasiStokItem m_Item;
        #endregion

        #region Constructor
        public CommandInsertMutasi(MutasiStokItem item)
        {
            m_Item = item;
        }
        #endregion

        #region Method
        public override object Execute()
        {
            m_Item.CreateDatabaseRecord();
            return m_Item;
        }
        #endregion
    }
}
