using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PenjualanHewanTernak.Model;

namespace PenjualanHewanTernak.Controller.PosMutasiStok
{
    class CommandDeletePosMutasiStok : Command
    {
        #region Declaration
        PosMutasiStokList m_List;
        PosMutasiStokItem m_Item;
        #endregion

        #region Constructor
        public CommandDeletePosMutasiStok(PosMutasiStokList list, PosMutasiStokItem item)
        {
            m_List = list;
            m_Item = item;
        }
        #endregion

        #region Method
        public override object Execute()
        {
            m_Item.DeleteDatabaseRecord();
            m_List.Remove(m_Item);
            return null;
        }
        #endregion
    }
}
