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
    class PosMutasiStokItemDAO
    {
        #region Declarations
        private static string m_ConnectionString;
        #endregion

        #region Constructor
        public PosMutasiStokItemDAO()
        {
            m_ConnectionString = Settings.Default.ConnectionString;
        }
        #endregion

        #region Methods
        internal void CreateDatabaseRecord(PosMutasiStokItem newMutasi)
        {
            string sql = "INSERT INTO MUTASI_STOK (NoRef, isPemasukan, Keterangan, Stat) " +
                        "VALUES(@code,@isPemasukan,@ket,@stat)";
            AddOrUpdateDatabaseRecord(sql, newMutasi);
        }

        internal void UpdateDatabaseRecord(PosMutasiStokItem updateKandang)
        {
            string sql = "UPDATE MUTASI_STOK SET " +
                        "isPemasukan = @isPemasukan, " +
                        "Keterangan = @ket, " +
                        "Stat = @stat " +
                        "WHERE NoRef = @code";
            AddOrUpdateDatabaseRecord(sql, updateKandang);
        }

        internal void DeleteDatabaseRecord(string KodeKandang)
        {
            string sql = "Delete From MUTASI_STOK Where NoRef = @code";
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
                command.Parameters.AddWithValue("@code", KodeKandang);

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

        protected void AddOrUpdateDatabaseRecord(string sql, PosMutasiStokItem item)
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
                command.Parameters.AddWithValue("@code", item.NoRef);
                command.Parameters.AddWithValue("@isPemasukan", item.IsPemasukan);
                command.Parameters.AddWithValue("@ket", item.Keterangan);
                command.Parameters.AddWithValue("@stat", item.Stat);

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
