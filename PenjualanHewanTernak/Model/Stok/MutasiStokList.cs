using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FSCollections;
using PenjualanHewanTernak.DataAccess;

namespace PenjualanHewanTernak.Model
{
    class MutasiStokList : FSBindingList<MutasiStokItem>
    {
        #region Constructor
        public MutasiStokList()
        {
            MutasiStokListDAO dao = new MutasiStokListDAO();
            dao.ShowList(this);
        }
        #endregion
    }
}
