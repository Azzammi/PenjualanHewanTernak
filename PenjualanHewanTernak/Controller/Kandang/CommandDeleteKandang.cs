using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PenjualanHewanTernak.Model;
namespace PenjualanHewanTernak.Controller.Kandang
{
    class CommandDeleteKandang : Command
    {
        #region Declaration
        KandangList m_List;
        KandangItem m_Item;
        #endregion

        #region Constructor
        public CommandDeleteKandang(KandangList list, KandangItem item)
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
