using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PenjualanHewanTernak.Model;
using System.Data;

namespace PenjualanHewanTernak.DataAccess
{
    class PosMutasiStokListDAO
    {
        #region Constructor
        public PosMutasiStokListDAO()
        {

        }
        #endregion

        #region Method
        internal void ShowList(PosMutasiStokList list)
        {
            string sql = "SELECT [noRef], " +
                        "[isPemasukan], " +
                        "[Keterangan], " +
                        "[Stat] " +                       
                        "FROM [Systernakdb].[dbo].[POS_MUTASI_STOK]";

            DataSet dataSet = DataProvider.GetDataSet(sql);

            //Create variable for dataset table
            DataTable itemTabel = dataSet.Tables[0];

            PosMutasiStokItem nextItem = null;

            foreach (DataRow parentRow in itemTabel.Rows)
            {
                nextItem = new PosMutasiStokItem();
                nextItem.NoRef = parentRow["NoRef"].ToString();
                nextItem.IsPemasukan = Convert.ToBoolean(parentRow["IsPemasukan"]);
                nextItem.Keterangan = parentRow["Keterangan"].ToString();
                nextItem.Stat = Convert.ToBoolean(parentRow["Stat"]);

                list.Add(nextItem);
            }
            dataSet.Dispose();
        }
    }
        #endregion
}

