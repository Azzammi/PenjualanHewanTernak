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
        //MutasiStokItem m_Item;
        #endregion

        #region Constructor
        public CommandInsertMutasi()
        {
            
        }
        #endregion

        #region Method
        public override object Execute()
        {
            MutasiStokItem m_Item = new MutasiStokItem(true);
            return m_Item;
        }
        #endregion
    }
}
