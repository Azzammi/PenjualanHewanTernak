using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PenjualanHewanTernak.Model;

namespace PenjualanHewanTernak.Controller.Pengeluaran
{
    class CommandInsertPosPengeluaran : Command
    {
        #region Constructor
        public CommandInsertPosPengeluaran() { }
        #endregion

        #region Method
        public override object Execute()
        {
            posPengeluaranItem item = new posPengeluaranItem(true);
            return item;
        }
        #endregion
    }
}
