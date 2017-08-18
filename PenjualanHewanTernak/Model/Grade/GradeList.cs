using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FSCollections;
using PenjualanHewanTernak.DataAccess;

namespace PenjualanHewanTernak.Model
{
    public class GradeList : FSBindingList<GradeItem>
    {
        #region Constructor
        public GradeList()
        {
            GradeListDAO dao = new GradeListDAO();
            dao.ShowList(this);
        }
        #endregion
    }
}
