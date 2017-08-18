using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PenjualanHewanTernak.Model;
using System.Data;

namespace PenjualanHewanTernak.DataAccess
{
    class HargaListDAO
    {
        #region Constructor
        public HargaListDAO()
        {

        }
        #endregion

        #region Methods
        internal void ShowList(HargaList list)
        {
            string sql = "SELECT [KodeGrade], " +
                        "[KodeHewan], " +
                        "[BeforePriceDate], " +
                        "[BeforePrice], " +
                        "[CurrentPriceDate], " +
                        "[CurrentPrice], " +
                        "[Stat] " +
                        "FROM [Systernakdb].[dbo].[PRIC]";

            DataSet dataSet = DataProvider.GetDataSet(sql);

            //Create variable for dataset table
            DataTable itemTabel = dataSet.Tables[0];

            HargaItem nextItem = null;

            foreach (DataRow parentRow in itemTabel.Rows)
            {
                nextItem = new HargaItem();
                nextItem.KodeGrade = parentRow["KodeGrade"].ToString();
                nextItem.KodeHewan = parentRow["KodeHewan"].ToString();
                nextItem.BeforePriceDate = Convert.ToDateTime(parentRow["BeforePriceDate"].ToString());
                nextItem.BeforePrice = Convert.ToDecimal(parentRow["BeforePrice"].ToString());
                nextItem.CurrentPriceDate = Convert.ToDateTime(parentRow["CurrentPriceDate"].ToString());
                nextItem.CurrentPrice = Convert.ToDecimal(parentRow["CurrentPrice"]);
                nextItem.Stat = Convert.ToBoolean(parentRow["Stat"]);

                list.Add(nextItem);
            }
            dataSet.Dispose();
        }
        #endregion
    }
}
