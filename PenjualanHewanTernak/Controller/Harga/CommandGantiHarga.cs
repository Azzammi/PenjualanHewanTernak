using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PenjualanHewanTernak.Model;

namespace PenjualanHewanTernak.Controller.Harga
{
    class CommandGantiHarga : Command
    {
        #region Declaration
        HargaItem m_Item;
        #endregion

        #region Constructor
        public CommandGantiHarga(HargaItem item)
        { 
            m_Item = item;
        }
        #endregion

        #region Methods
        public override object Execute()
        {
            m_Item.GantiHarga();
            return m_Item;
        }
        #endregion
    }
}
