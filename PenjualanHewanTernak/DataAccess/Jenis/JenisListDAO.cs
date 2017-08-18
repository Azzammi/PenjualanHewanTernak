using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PenjualanHewanTernak.Model;
using System.Data;

namespace PenjualanHewanTernak.DataAccess
{
    class JenisListDAO
    {
        #region Constructor
        public JenisListDAO()
        {

        }
        #endregion

        #region Methods
        internal void ShowList(JenisList list)
        {
            string sql = "SELECT [KodeJenis],[Ket],[Stat] FROM [Systernakdb].[dbo].[JENIS]";

            DataSet dataSet = DataProvider.GetDataSet(sql);

            //Create variable for dataset table
            DataTable itemTabel = dataSet.Tables[0];

            JenisItem nextItem = null;

            foreach (DataRow parentRow in itemTabel.Rows)
            {
                nextItem = new JenisItem();
                nextItem.KodeJenis = parentRow["KodeJenis"].ToString();
                nextItem.Keterangan = parentRow["Ket"].ToString();
                nextItem.Stat = Convert.ToBoolean(parentRow["stat"]);

                list.Add(nextItem);
            }
            dataSet.Dispose();
        }
        #endregion
    }
}
