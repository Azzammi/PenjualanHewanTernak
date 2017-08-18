using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FSCollections;
using PenjualanHewanTernak.DataAccess;

namespace PenjualanHewanTernak.Model
{
    public class HargaList : FSBindingList<HargaItem>
    {
        #region Constructor
        public HargaList()
        {
            HargaListDAO dao = new HargaListDAO();
            dao.ShowList(this);
        }
        #endregion
    }
}
