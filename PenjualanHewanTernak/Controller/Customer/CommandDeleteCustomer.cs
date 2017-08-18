using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PenjualanHewanTernak.Model;

namespace PenjualanHewanTernak.Controller.Customer
{
    class CommandDeleteCustomer : Command
    {
        #region Declaration
        CustomerList m_Customer;
        CustomerItem m_CustomerToDelete;
        #endregion

        #region Constructor
        public CommandDeleteCustomer()
        {

        }

        public CommandDeleteCustomer(CustomerList list, CustomerItem item)
        {
            m_Customer = list;
            m_CustomerToDelete = item;
        }
        #endregion

        #region Method
        public override object Execute()
        {
            m_CustomerToDelete.DeleteItem();
            m_CustomerToDelete.DeleteDatabaseRecord();
            m_Customer.Remove(m_CustomerToDelete);
            return null;
        }
        #endregion
    }
}
