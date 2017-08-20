using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PenjualanHewanTernak.Model;

namespace PenjualanHewanTernak.Controller.PosMutasiStok
{
    class CommandGetPosMutasiStok : Command
    {
        #region Declaration
       
        #endregion

        #region Constructor
        public CommandGetPosMutasiStok() { }
        #endregion

        #region Methos
        public override object Execute()
        {
            PosMutasiStokList list = new PosMutasiStokList();
            return list;
        }
        #endregion
    }
}
