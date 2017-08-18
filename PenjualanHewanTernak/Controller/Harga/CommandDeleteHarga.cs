using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PenjualanHewanTernak.Model;
namespace PenjualanHewanTernak.Controller.Harga
{
    class CommandDeleteHarga : Command
    {
        #region Declaration
        HargaList m_List;
        HargaItem m_Item;
        #endregion

        #region Constructor
        public CommandDeleteHarga(HargaList list, HargaItem item)
        {
            m_List = list;
            m_Item = item;
        }
        #endregion

        #region Methods
        public override object Execute()
        {
            m_Item.DeleteDatabaseRecord();
            m_List.Remove(m_Item);
            return null;
        }
        #endregion
    }
}
