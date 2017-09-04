using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PenjualanHewanTernak.Model;

namespace PenjualanHewanTernak.Controller.Pengeluaran
{
    class CommandDeletePosPengeluaran : Command
    {
        #region Delcaration
        posPengeluaranItem m_Item;
        PosPengeluaranList m_List;
        #endregion

        #region Constructor
        public CommandDeletePosPengeluaran(PosPengeluaranList list, posPengeluaranItem item)
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
