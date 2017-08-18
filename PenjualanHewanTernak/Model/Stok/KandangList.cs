using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FSCollections;
using PenjualanHewanTernak.DataAccess;

namespace PenjualanHewanTernak.Model
{
    class KandangList : FSBindingList<KandangItem>
    {
        #region Constructor
        public KandangList()
        {
            KandangListDAO dao = new KandangListDAO();
            dao.ShowList(this);
        }
        #endregion
    }
}
