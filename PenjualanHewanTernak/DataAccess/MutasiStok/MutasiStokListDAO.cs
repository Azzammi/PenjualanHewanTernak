using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PenjualanHewanTernak.Model;
using System.Data;

namespace PenjualanHewanTernak.DataAccess
{
    class MutasiStokListDAO
    {
        #region Constructor
        public MutasiStokListDAO() { }
        #endregion

        #region Method
        internal void ShowList(MutasiStokList list)
        {
            string sql = "SELECT [NoRef],[TglTransaksi],[KodeGudang],[KodeBarang],[Keterangan],[StokAwal],[Masuk],[Keluar],[NoTransaksi] FROM [SysTernakDB].[dbo].[MUTASI_STOK]";

            DataSet dataSet = DataProvider.GetDataSet(sql);

            //Create variable for dataset table
            DataTable itemTabel = dataSet.Tables[0];

            MutasiStokItem nextItem = null;

            foreach (DataRow parentRow in itemTabel.Rows)
            {
                nextItem = new MutasiStokItem();                
                nextItem.NoRef = parentRow["noRef"].ToString();
                nextItem.TglTransaksi = Convert.ToDateTime(parentRow["tglTransaksi"]);
                nextItem.KodeKandang = parentRow["KodeGudang"].ToString();
                nextItem.KodeHewan = parentRow["KodeBarang"].ToString();           
                nextItem.StokAwal = Convert.ToInt32(parentRow["StokAwal"]);
                nextItem.Masuk = Convert.ToInt32(parentRow["masuk"]);
                nextItem.Keluar = Convert.ToInt32(parentRow["keluar"]);                
                nextItem.Keterangan = parentRow["keterangan"].ToString();
                nextItem.NomorTransaksi = Convert.ToInt32(parentRow["noTransaksi"]);

                list.Add(nextItem);
            }
            dataSet.Dispose();
        }
        #endregion
    }
}
