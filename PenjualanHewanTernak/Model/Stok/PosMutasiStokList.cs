using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FSCollections;
using PenjualanHewanTernak.DataAccess;

namespace PenjualanHewanTernak.Model
{
    class PosMutasiStokList : FSBindingList<PosMutasiStokItem>
    {
        #region Constructor
        public PosMutasiStokList()
        {
            PosMutasiStokListDAO dao = new PosMutasiStokListDAO();
            dao.ShowList();
        }
        #endregion
    }
}
