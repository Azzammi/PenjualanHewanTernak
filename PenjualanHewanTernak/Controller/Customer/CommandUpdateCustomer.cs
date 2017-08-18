using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PenjualanHewanTernak.Model;

namespace PenjualanHewanTernak.Controller.Customer
{
    class CommandUpdateCustomer : Command
    {
        #region Declaration
        CustomerItem m_Item;
        #endregion

        #region Constructor
        public CommandUpdateCustomer(CustomerItem item)
        {
            m_Item = item;
        }
        #endregion

        #region Methods
        public override object Execute()
        {
            m_Item.UpdateDatabaseRecord();
            return m_Item;
        }
        #endregion
    }
}
