using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PenjualanHewanTernak.Model;

namespace PenjualanHewanTernak.Controller.Jenis
{
    class CommandGetJenis : Command
    {
        #region Declaration

        #endregion

        #region Methods
        public override object Execute()
        {
            JenisList list = new JenisList();
            return list;
        }
        #endregion
    }
}
