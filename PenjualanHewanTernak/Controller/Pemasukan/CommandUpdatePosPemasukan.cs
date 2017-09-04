using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PenjualanHewanTernak.Model;

namespace PenjualanHewanTernak.Controller.Pemasukan
{
    class CommandUpdatePosPemasukan : Command
    {
        #region Declaration
        posPemasukanItem m_Item;
        #endregion

        #region Constructor
        public CommandUpdatePosPemasukan(posPemasukanItem item)
        {
            m_Item = item;
        }
        #endregion

        #region Method
        public override object Execute()
        {
            m_Item.UpdateDatabaseRecord();
            return m_Item;
        }
        #endregion
    }
}
