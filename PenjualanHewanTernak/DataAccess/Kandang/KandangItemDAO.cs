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
    class KandangItemDAO
    {
        #region Declarations
        private static string m_ConnectionString;
        #endregion

        #region Constructor
        public KandangItemDAO()
        {
            m_ConnectionString = Settings.Default.ConnectionString;
        }
        #endregion

        #region Methods
        internal void CreateDatabaseRecord(KandangItem newKandang)
        {
            string sql = "INSERT INTO KANDANG (KodeKandang, Keterangan, Stat) " +
                        "VALUES(@code,@ket,@stat)";
            AddOrDeleteDatabaseRecord(sql, newKandang);
        }

        internal void UpdateDatabaseRecord(KandangItem updateKandang)
        {
            string sql = "UPDATE KANDANG SET " +
                        "Keterangan = @ket, " +
                        "Stat = @stat " +
                        "WHERE KodeKandang = @code";
            AddOrDeleteDatabaseRecord(sql, updateKandang);
        }

        internal void DeleteDatabaseRecord(string KodeKandang)
        {
            string sql = "Delete From Kandang Where KodeKandang = @code";
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

        protected void AddOrDeleteDatabaseRecord(string sql, KandangItem item)
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
                command.Parameters.AddWithValue("@code", item.KodeKandang);
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
