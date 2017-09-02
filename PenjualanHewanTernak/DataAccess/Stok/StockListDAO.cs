using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PenjualanHewanTernak.Model;
using System.Data;

namespace PenjualanHewanTernak.DataAccess
{
    class StockListDAO
    {
        #region Constructor
        public StockListDAO() { }
        #endregion

        #region Method
        internal void ShowList(StockList list)
        {
            string sql = "SELECT [KodeGudang],[KodeHewan],[Keterangan],[stokAkhir] FROM [SysTernakDB].[dbo].[STOK]";

            DataSet dataSet = DataProvider.GetDataSet(sql);

            //Create variable for dataset table
            DataTable itemTabel = dataSet.Tables[0];

            StockItem nextItem = null;

            foreach (DataRow parentRow in itemTabel.Rows)
            {
                nextItem = new StockItem();
                nextItem.KodeGudang = parentRow["KodeGudang"].ToString();
                nextItem.KodeHewan = parentRow["KodeHewan"].ToString();
                nextItem.Keterangan = parentRow["Keterangan"].ToString();
                nextItem.Stok = Convert.ToInt32(parentRow["StokAkhir"]);

                list.Add(nextItem);
            }
            dataSet.Dispose();
        }
        #endregion
    }
}
