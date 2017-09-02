using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PenjualanHewanTernak.Model;

namespace PenjualanHewanTernak.Controller.Stok
{
    class CommandGetStok : Command
    {
        #region Constructor
        public CommandGetStok()
        {

        }
        #endregion

        #region Method
        public override object Execute()
        {
            StockList list = new StockList();
            return list;
        }
        #endregion
    }
}
