using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PenjualanHewanTernak.Model;

namespace PenjualanHewanTernak.Controller.Pemasukan
{
    class CommandInsertPosPemasukan : Command
    {
        #region Constructor
        public CommandInsertPosPemasukan() { }
        #endregion

        #region Method
        public override object Execute()
        {
            posPemasukanItem data = new posPemasukanItem(true);
            return data;
        }
        #endregion
    }
}
