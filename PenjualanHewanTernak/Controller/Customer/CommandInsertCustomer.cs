using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PenjualanHewanTernak.Model;

namespace PenjualanHewanTernak.Controller.Customer
{
    class CommandInsertCustomer : Command
    {
        #region Declaration
    
        #endregion

        #region Constructor
        public CommandInsertCustomer()
        {
          
        }
        #endregion

        #region Method
        public override object Execute()
        {
            CustomerItem item = new CustomerItem(true);
            return item;
        }
        #endregion
    }
}
