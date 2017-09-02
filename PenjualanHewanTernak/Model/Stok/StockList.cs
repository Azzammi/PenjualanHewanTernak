using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FSCollections;
using PenjualanHewanTernak.DataAccess;

namespace PenjualanHewanTernak.Model
{
    class StockList : FSBindingList<StockItem>
    {
        #region Constructor
        public StockList()
        {
            StockListDAO dao = new StockListDAO();
            dao.ShowList(this);
        }
        #endregion
    }
}
