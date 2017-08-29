using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PenjualanHewanTernak.Model;
using System.Data;

namespace PenjualanHewanTernak.DataAccess
{
    class PosPemasukanListDAO
    {
        #region Constructor
        public PosPemasukanListDAO()
        {
            
        }
        #endregion

        #region Method
        internal void ShowList(posPemasukaList list)
        {
            string sql = "SELECT [REF],[KETERANGAN],[STAT] FROM [SysTernakDB].[dbo].[POS_PEMASUKAN]";

            DataSet dataSet = DataProvider.GetDataSet(sql);

            //Create variable for dataset table
            DataTable itemTabel = dataSet.Tables[0];

            posPemasukanItem nextItem = null;

            foreach (DataRow parentRow in itemTabel.Rows)
            {
                nextItem = new posPemasukanItem();
                nextItem.Ref = parentRow["Ref"].ToString();
                nextItem.Keterangan = parentRow["Keterangan"].ToString();
                nextItem.Stat = Convert.ToBoolean(parentRow["Stat"]);            

                list.Add(nextItem);
            }
            dataSet.Dispose();
        }
        #endregion
    }
}
