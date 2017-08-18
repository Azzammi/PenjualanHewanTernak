using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PenjualanHewanTernak.Model;

namespace PenjualanHewanTernak.Controller.Cattle
{
    public class CommandGetCattle : Command
    {
        #region Constructor
        public CommandGetCattle() { }
        #endregion

        #region Methods
        public override object Execute()
        {
            CattleList list = new CattleList();
            return list;
        }
        #endregion
    }
}
