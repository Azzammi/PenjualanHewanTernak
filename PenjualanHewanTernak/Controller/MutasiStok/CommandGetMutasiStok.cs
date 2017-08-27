using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PenjualanHewanTernak.Model;

namespace PenjualanHewanTernak.Controller.MutasiStok
{
    class CommandGetMutasiStok : Command
    {
        #region Constructor
        public CommandGetMutasiStok() { }
        #endregion

        #region Method
        public override object Execute()
        {
            MutasiStokList list = new MutasiStokList();
            return list;
        }
        #endregion
    }
}
