using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PenjualanHewanTernak.Model;

namespace PenjualanHewanTernak.Controller.Kandang
{
    class CommandGetKandang : Command
    {
        #region Constructor
        public CommandGetKandang() { }
        #endregion

        #region Methods
        public override object Execute()
        {
            KandangList list = new KandangList();
            return list;
        }
        #endregion
    }
}
