using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PenjualanHewanTernak.Model;

namespace PenjualanHewanTernak.Controller.Children
{
    class CommandInsertChildren : Command
    {
        #region Declaration
        string kodeCust;
        #endregion

        #region Constructor
        public CommandInsertChildren(string kode)
        {
            kodeCust = kode;
        }
        #endregion

        #region Method
        public override object Execute()
        {
            ChildrenItem item = new ChildrenItem(kodeCust);
            return item;
        }
        #endregion
    }
}
