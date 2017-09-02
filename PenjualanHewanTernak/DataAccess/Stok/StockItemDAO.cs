using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PenjualanHewanTernak.Model;
using PenjualanHewanTernak.Properties;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PenjualanHewanTernak.DataAccess
{
    class StockItemDAO
    {
        #region Declarations
        private static string m_ConnectionString;
        #endregion

        #region Constructor
        public StockItemDAO()
        {
            m_ConnectionString = Settings.Default.ConnectionString;
        }
        #endregion

        #region Methods
        internal void CreateDatabaseRecord(StockItem newStock)
        {
            string sql = "INSERT INTO STOK (KodeGudang, KodeHewan, Keterangan, StokAkhir) " +
                        "VALUES(@codeGudang, @codeHewan, @ket, @stokAkhir)";
            try
            {
                //Create and open a connection
                SqlConnection connection = new SqlConnection(m_ConnectionString);
                connection.Open();

                //create and configure a command
                SqlCommand command = new SqlCommand(sql, connection);

                //Adding value through parameter
                command.CommandType = System.Data.CommandType.Text;
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@codeGudang", newStock.KodeGudang);
                command.Parameters.AddWithValue("@codeHewan", newStock.KodeHewan);
                command.Parameters.AddWithValue("@ket", newStock.Keterangan);
                command.Parameters.AddWithValue("@stokAkhir", newStock.Stok);

                //execute the command
                command.ExecuteNonQuery();

                //Close and dispose
                command.Dispose();
                connection.Close();
                connection.Dispose();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        internal void UpdateDatabaseRecord(StockItem updateStock,int jumlah, bool isPenambahan)
        {
            string sql = null;
            if (isPenambahan)
            {
                sql = "EXEC SP_TAMBAH_STOCK " +
                      "@KodeKandang = '" + updateStock.KodeGudang + "', " +
                      "@KodeHewan = '" + updateStock.KodeHewan + "', " + 
                      "@jumlah = '" + jumlah + "'";
            }
            else
            {
                sql = "EXEC SP_KURANGI_STOCK " +
                       "@KodeKandang = '" + updateStock.KodeGudang + "', " +
                       "@KodeHewan = '" + updateStock.KodeHewan + "', " +
                       "@jumlah = '" + jumlah + "'";
            }

            try
            {
                //Create and open a connection
                SqlConnection connection = new SqlConnection(m_ConnectionString);
                connection.Open();

                //create and configure a command
                SqlCommand command = new SqlCommand(sql, connection);

                //Adding value through parameter
                command.CommandType = System.Data.CommandType.StoredProcedure;
                //command.Parameters.Clear();
                //command.Parameters.AddWithValue("@codeGudang", newStock.KodeGudang);
                //command.Parameters.AddWithValue("@codeHewan", newStock.KodeHewan);
                //command.Parameters.AddWithValue("@ket", newStock.Keterangan);
                //command.Parameters.AddWithValue("@stokAkhir", newStock.Stok);

                //execute the command
                command.ExecuteNonQuery();

                //Close and dispose
                command.Dispose();
                connection.Close();
                connection.Dispose();

            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        internal void DeleteDatabaseRecord(string KodeKandang)
        {
            //string sql = "Delete From MUTASI_STOK Where NoRef = @code";
            //try
            //{
            //    //Create and open a connection
            //    SqlConnection connection = new SqlConnection(m_ConnectionString);
            //    connection.Open();

            //    //create and configure a command
            //    SqlCommand command = new SqlCommand(sql, connection);

            //    //Adding value through parameter
            //    command.CommandType = System.Data.CommandType.Text;
            //    command.Parameters.Clear();
            //    command.Parameters.AddWithValue("@code", KodeKandang);

            //    //execute the command
            //    command.ExecuteNonQuery();

            //    //Close and dispose
            //    command.Dispose();
            //    connection.Close();
            //    connection.Dispose();

            //}
            //catch (SqlException ex)
            //{
            //    MessageBox.Show(ex.Message.ToString());
            //}
        }
        
        #endregion
    }
}
