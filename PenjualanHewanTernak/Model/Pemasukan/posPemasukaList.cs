using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FSCollections;
using PenjualanHewanTernak.DataAccess;

namespace PenjualanHewanTernak.Model
{
    public class posPemasukaList : FSBindingList<posPemasukanItem>
    {
        #region Constructor
        public posPemasukaList()
        {
            PosPemasukanListDAO dao = new PosPemasukanListDAO();
            dao.ShowList(this);
        }
        #endregion
    }
}
