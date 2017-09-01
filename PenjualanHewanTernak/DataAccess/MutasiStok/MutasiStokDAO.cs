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
        #endregion

        #region Constructor
        public MutasiStokDAO()
        {
            m_ConnectionString = Settings.Default.ConnectionString;
        }           
        #endregion

        #region Methods
        internal void CreateDatabaseRecord(MutasiStokItem newMutasi)
        {
            string sql = null;            
            sql = "INSERT INTO MUTASI_STOK" +
                    "(Keterangan, TglTransaksi, StokAwal, Masuk, Keluar) " +
                    "OUTPUT INSERTED.NoTransaksi " +
                    "VALUES('STOK KELUAR','" + DateTime.Now + "', 0, 0, 0)";
            
            //Execute the query
            int newRecordID = Convert.ToInt32(DataProvider.ExecuteScalar(sql));

            //Return the value
            newMutasi.NomorTransaksi = newRecordID;            
        }
        //This Method was deprecated for security and valid data reason
        internal void UpdateDatabaseRecord(MutasiStokItem updateMutasi, bool isAddingStock)
        {
            string sql;
            sql = "UPDATE MUTASI_STOK SET " +
                    "tglTransaksi = @tanggal, " +
                    "noRef = @noRef, " +
                    "kodeGudang = @kodeGudang, " +
                    "kodeBarang = @kodeBarang, " +
                    "Keterangan = @ket, " +
                    "Masuk = @masuk, " +
                    "Keluar = @keluar " +
                    "WHERE noTransaksi = @noTransaksi";

            AddOrUpdateDatabaseRecord(sql, updateMutasi, isAddingStock);
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

        protected void AddOrUpdateDatabaseRecord(string sql, MutasiStokItem itemMaster, bool isAddingStock)
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
                command.Parameters.AddWithValue("@noTransaksi", itemMaster.NomorTransaksi);
                command.Parameters.AddWithValue("@noRef", itemMaster.NoRef);
                command.Parameters.AddWithValue("@tanggal", itemMaster.TglTransaksi);
                command.Parameters.AddWithValue("@kodeGudang", itemMaster.KodeKandang);
                command.Parameters.AddWithValue("@kodeBarang", itemMaster.KodeHewan);
                command.Parameters.AddWithValue("@ket", itemMaster.Keterangan);
                command.Parameters.AddWithValue("@masuk", itemMaster.Masuk);
                command.Parameters.AddWithValue("@keluar", itemMaster.Keluar);

                if(isAddingStock == true)
                {                    
                    AddStock(itemMaster);
                }
                else
                {                    
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
                command.CommandType = System.Data.CommandType.StoredProcedure;
        
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
