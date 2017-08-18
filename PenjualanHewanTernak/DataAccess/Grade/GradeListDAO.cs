using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PenjualanHewanTernak.Model;
using System.Data;

namespace PenjualanHewanTernak.DataAccess
{
    class GradeListDAO
    {
        #region Constructor
        public GradeListDAO()
        {

        }
        #endregion

        #region Methods
        internal void ShowList(GradeList list)
        {
            string sql = "SELECT [KodeGrade],[Ket],[Stat] FROM [Systernakdb].[dbo].[GRADE]";

            DataSet dataSet = DataProvider.GetDataSet(sql);

            //Create variable for dataset table
            DataTable itemTabel = dataSet.Tables[0];

            GradeItem nextItem = null;

            foreach (DataRow parentRow in itemTabel.Rows)
            {
                nextItem = new GradeItem();
                nextItem.KodeGrade = parentRow["KodeGrade"].ToString();
                nextItem.Keterangan = parentRow["Ket"].ToString();
                nextItem.Stat = Convert.ToBoolean(parentRow["stat"]);

                list.Add(nextItem);
            }
            dataSet.Dispose();
        }
        #endregion
    }
}
