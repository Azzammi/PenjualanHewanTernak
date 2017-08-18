using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PenjualanHewanTernak.DataAccess;
using FSCollections;

namespace PenjualanHewanTernak.Model
{
    public class CattleList : FSBindingList<CattleItem>
    {
        #region Constructor
        public CattleList()
        {
            //Code to get from dataAccess (dao)
            CattleListDAO dao = new CattleListDAO();
            dao.ShowList(this);
        }
        #endregion
    }
}
