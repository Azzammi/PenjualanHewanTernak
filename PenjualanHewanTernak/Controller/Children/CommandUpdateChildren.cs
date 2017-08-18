using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PenjualanHewanTernak.Model;

namespace PenjualanHewanTernak.Controller.Children
{
    class CommandUpdateChildren : Command
    {
        #region Declaration
        ChildrenItem m_Item;
        #endregion

        #region Constructor
        public CommandUpdateChildren(ChildrenItem item)
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
