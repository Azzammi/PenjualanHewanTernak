using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PenjualanHewanTernak.Model;

namespace PenjualanHewanTernak.Controller.Pemasukan
{
    class CommandDeletePosPemasukan : Command
    {
        #region Declaration
        posPemasukanItem m_Item;
        posPemasukaList m_List;
        #endregion

        #region Constructtor
        public CommandDeletePosPemasukan(posPemasukaList list, posPemasukanItem item)
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
