using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PenjualanHewanTernak.Model;
using System.Data;

namespace PenjualanHewanTernak.DataAccess
{
    class CattleListDAO
    {
        #region Constructor
        public CattleListDAO()
        {

        }
        #endregion

        #region Methods
        internal void ShowList(CattleList list)
        {
            string sql = "SELECT [KodeHewan],[NamaHewan],[KodeGrade],[kodeJenis],[Sort],[Berat],[jenis_kelamin] FROM [Systernakdb].[dbo].[CATTLE]";

            DataSet dataSet = DataProvider.GetDataSet(sql);

            //Create variable for dataset table
            DataTable itemTabel = dataSet.Tables[0];

            CattleItem nextItem = null;

            foreach (DataRow parentRow in itemTabel.Rows)
            {
                nextItem = new CattleItem();
                nextItem.KodeHewan = parentRow["KodeHewan"].ToString();
                nextItem.NamaHewan = parentRow["NamaHewan"].ToString();
                nextItem.KodeGrade = parentRow["KodeGrade"].ToString();
                nextItem.KodeJenis = parentRow["KodeJenis"].ToString();
                nextItem.Sort = parentRow["Sort"].ToString();
                nextItem.Berat = Convert.ToInt32(parentRow["Berat"]);
                nextItem.JenisKelamain = parentRow["jenis_kelamin"].ToString();

                list.Add(nextItem);
            }
            dataSet.Dispose();
        }
        #endregion
    }
}
