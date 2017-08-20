using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PenjualanHewanTernak.Model;
using System.Data;

namespace PenjualanHewanTernak.DataAccess
{
    class KandangListDAO
    {
        #region Constructor
        public KandangListDAO()
        {

        }
        #endregion

        #region Method
        internal void ShowList(KandangList list)
        {
            string sql = "SELECT [KodeKandang],[Keterangan],[Stat] FROM [Systernakdb].[dbo].[KANDANG]";

            DataSet dataSet = DataProvider.GetDataSet(sql);

            //Create variable for dataset table
            DataTable itemTabel = dataSet.Tables[0];

            KandangItem nextItem = null;

            foreach (DataRow parentRow in itemTabel.Rows)
            {
                nextItem = new KandangItem();
                nextItem.KodeKandang = parentRow["KodeKandang"].ToString();
                nextItem.Keterangan = parentRow["Keterangan"].ToString();
                nextItem.Stat = Convert.ToBoolean(parentRow["stat"]);

                list.Add(nextItem);
            }
            dataSet.Dispose();
        }
        #endregion
    }
}
