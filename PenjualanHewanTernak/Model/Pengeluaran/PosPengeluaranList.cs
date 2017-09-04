using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FSCollections;
using PenjualanHewanTernak.DataAccess;

namespace PenjualanHewanTernak.Model
{
    public class PosPengeluaranList : FSBindingList<posPengeluaranItem>
    {
        #region Constructor
        public PosPengeluaranList()
        {
            PosPengeluaranListDAO dao = new PosPengeluaranListDAO();
            dao.ShowList(this);
        }
        #endregion
    }
}
