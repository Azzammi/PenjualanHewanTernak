using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FSCollections;
using PenjualanHewanTernak.DataAccess;

namespace PenjualanHewanTernak.Model
{
    public class JenisList : FSBindingList<JenisItem>
    {
        #region Constructor
        public JenisList()
        {
            JenisListDAO dao = new JenisListDAO();
            dao.ShowList(this);
        }
        #endregion
    }
}
