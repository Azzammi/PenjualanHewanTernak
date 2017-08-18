using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PenjualanHewanTernak.Model;

namespace PenjualanHewanTernak.Controller.Harga
{
    class CommandGetHarga : Command
    {
        #region Constructor
        public CommandGetHarga() { }
        #endregion

        #region Methods
        public override object Execute()
        {
            HargaList list = new HargaList();
            return list;
        }
        #endregion
    }
}
