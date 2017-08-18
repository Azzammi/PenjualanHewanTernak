using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PenjualanHewanTernak.Model;

namespace PenjualanHewanTernak.Controller.Customer
{
    class CommandGetCustomer : Command
    {
        #region Declarations

        #endregion
        #region Constructor
        public CommandGetCustomer()
        {

        }
        #endregion

        #region Method
        public override object Execute()
        {
            CustomerList list = new CustomerList();
            return list;
        }
        #endregion
    }
}
