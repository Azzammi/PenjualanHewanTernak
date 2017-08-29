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
    class MutasiStokDAO 
    {
        #region Declaration
        private static string m_ConnectionString;
        private static bool isPenguranganStok;
        #endregion

        #region Constructor
        public MutasiStokDAO()
        {
            m_ConnectionString = Settings.Default.ConnectionString;
        }
       
        /// <summary>
        /// 
        /// </summary>
        /// <param name="isPengurangStok">if the value is set to true it will make a stock decrement</param>
        public MutasiStokDAO(bool isStokDikurangi)
        {
            m_ConnectionString = Settings.Default.ConnectionString;
            isPenguranganStok = isStokDikurangi;
        }
        #endregion

        #region Methods
        internal void CreateDatabaseRecord(MutasiStokItem newMutasi)
        {
            string sql = null;
            if(isPenguranganStok != true)
            {
                sql = "INSERT INTO MUTASI_STOK" +
                        "(Keterangan) " +
                        "OUTPUT INSERTED.NoTransaksi " +
                        "VALUES('STOK MASUK')";
            }
            else
            {
                sql = "INSERT INTO MUTASI_STOK" +
                        "(Keterangan) " +
                        "OUTPUT INSERTED.NoTransaksi " +
                        "VALUES('STOK KELUAR')";
            }

            //Execute the query
            int newRecordID = (int)DataProvider.ExecuteScalar(sql);

            //Return the value
            newMutasi.NomorTransaksi = newRecordID;            
        }
        //This Method was deprecated for security and valid data reason
        internal void UpdateDatabaseRecord(MutasiStokItem updateMutasi)
        {
            //string sql;
            //if(isPenguranganStok != true)
            //{
            //    sql = "UPDATE MUTASI_STOK SET";
            //}
        }
        internal void DeleteDatabaseRecord(int nomorTransaksi)
        {
            string sql = "Delete From MUTASI_STOK Where NoTransaksi = @code";
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
                command.Parameters.AddWithValue("@code", nomorTransaksi);

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

        protected void AddOrUpdateDatabaseRecord(string sql, MutasiStokItem itemMaster)
        {
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
                command.Parameters.AddWithValue("@noRef", itemMaster.NoRef);
                command.Parameters.AddWithValue("@tanggal", itemMaster.TglTransaksi);
                command.Parameters.AddWithValue("@kodeGudang", itemMaster.KodeKandang);
                command.Parameters.AddWithValue("@kodebarang", itemMaster.KodeHewan);
                command.Parameters.AddWithValue("@ket", itemMaster.Keterangan);

                if(isPenguranganStok != true)
                {
                    command.Parameters.AddWithValue("@perubahanStok", itemMaster.Masuk);
                    AddStock(itemMaster);
                }
                else
                {
                    command.Parameters.AddWithValue("@perubahanStok", itemMaster.Keluar);
                    DecrementStock(itemMaster);
                }                

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
        protected void AddStock(MutasiStokItem addStock)
        {
            try
            {
                //Create and open a connection
                SqlConnection connection = new SqlConnection(m_ConnectionString);
                connection.Open();

                //create and configure a command
                SqlCommand command = new SqlCommand("SP_TAMBAH_STOCK", connection);

                //Adding value through parameter
                command.CommandType = System.Data.CommandType.Text;
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@kodeKandang", addStock.KodeKandang);
                command.Parameters.AddWithValue("@kodeHewan", addStock.KodeHewan);
                command.Parameters.AddWithValue("@jumlah", addStock.Masuk);
                     
                
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
        protected void DecrementStock(MutasiStokItem deleteStock)
        {
            try
            {
                //Create and open a connection
                SqlConnection connection = new SqlConnection(m_ConnectionString);
                connection.Open();

                //create and configure a command
                SqlCommand command = new SqlCommand("SP_KURANGI_STOK", connection);

                //Adding value through parameter
                command.CommandType = System.Data.CommandType.StoredProcedure;               

                command.Parameters.AddWithValue("@kodeKandang", deleteStock.KodeKandang);
                command.Parameters.AddWithValue("@kodeHewan", deleteStock.KodeHewan);
                command.Parameters.AddWithValue("@jumlah", deleteStock.Keluar);


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
        #endregion
    }
}
