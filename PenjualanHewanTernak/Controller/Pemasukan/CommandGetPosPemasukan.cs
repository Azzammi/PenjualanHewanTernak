using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PenjualanHewanTernak.Model;

namespace PenjualanHewanTernak.Controller.Pemasukan
{
    class CommandGetPosPemasukan : Command
    {
        #region Constructor
        public CommandGetPosPemasukan()
        {

        }
        #endregion

        #region Method
        public override object Execute()
        {
            posPemasukaList list = new posPemasukaList();
            return list;
        }
        #endregion
    }
}
