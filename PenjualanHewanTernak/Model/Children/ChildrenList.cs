using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FSCollections;
using PenjualanHewanTernak.DataAccess;

namespace PenjualanHewanTernak.Model
{
    public class ChildrenList : FSBindingList<ChildrenItem>
    {
        #region Methods
        internal void ClearAll()
        {
            //Delete Database Record
            foreach(ChildrenItem item in this)
            {
                item.DeleteDatabaseRecord();
            }
            /* We call BindingList<T>.ClearItems, instead of Clear(),
          * because it raises the ListChanged event. Bound controls
          * in the UI will respond by updating themselves. */

            // Clear list
            ClearItems();
        }

        internal void DeleteChildren(string KodeAnak)
        {
            //Find Children to Delete
            ChildrenItem childrenToDelete = null;
            foreach(ChildrenItem item in this)
            {
                if(item.Kodeanak == KodeAnak)
                {
                    childrenToDelete = item;
                    break;
                }
            }
        }
        #endregion
    }
}
