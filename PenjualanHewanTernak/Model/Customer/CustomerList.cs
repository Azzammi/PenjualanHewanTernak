using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FSCollections;
using PenjualanHewanTernak.DataAccess;

namespace PenjualanHewanTernak.Model
{
    public class CustomerList : FSBindingList<CustomerItem>
    {
        #region Declaration
        private bool isBindingComplete;
        #endregion

        #region Constructor
        public CustomerList()
        {
            CustomerListDAO dao = new CustomerListDAO();
            dao.ShowList(this);

            //IsBindingComplete --- 
            this.IsBindingComplete = dao.IsBindingComplete;
        }
        #endregion

        #region Properties
        public bool IsBindingComplete
        {
            get { return isBindingComplete; }
            set { isBindingComplete = value; }
        }
        #endregion

        #region Method
        internal CustomerItem GetCustomer(string kodeCust)
        {
            foreach(CustomerItem customer in this)
            {
                if(customer.KodeCust == kodeCust)
                {
                    return customer;
                }
            }
            return null;
        }
        #endregion
    }
}
