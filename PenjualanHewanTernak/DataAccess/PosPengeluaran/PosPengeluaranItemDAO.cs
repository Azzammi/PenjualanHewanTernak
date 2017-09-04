using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PenjualanHewanTernak.Model;
using System.Windows.Forms;
using System.Data.SqlClient;
using PenjualanHewanTernak.Properties;

namespace PenjualanHewanTernak.DataAccess
{
    class PosPengeluaranItemDAO
    {
        #region Declaration
        private static string m_ConnectionString;
        #endregion

        #region Constrcutor
        public PosPengeluaranItemDAO()
        {
            m_ConnectionString = Settings.Default.ConnectionString;
        }
        #endregion

        #region Method
        internal void CreateDatabaseRecord(posPengeluaranItem newPengeluaran)
        {
            string sql = "INSERT INTO POS_PENGELUARAN (REF) " +
                         " OUTPUT INSERTED.REF " +
                         " VALUES ('" + "OU" + DataProvider.GenerateNumber("POS_PENGELUARAN", "REF") + "')";

            //Execute Query
            string newRecordID = (string)DataProvider.ExecuteScalar(sql);

            //Return new value
            newPengeluaran.Ref = newRecordID; 
        }
        internal void UpdateDatabaseRecord(posPengeluaranItem updateItem)
        {
            string sql = "UPDATE POS_PENGELUARAN SET " +
                        "KETERANGAN = @ket, " +
                        "Stat = @stat " +
                        "WHERE REF = @ref";
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
                command.Parameters.AddWithValue("@ref", updateItem.Ref);
                command.Parameters.AddWithValue("@ket", updateItem.Keterangan);
                command.Parameters.AddWithValue("@stat", updateItem.Stat);

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
        internal void DeleteDatabaseRecord(string referenceNumber)
        {
            try
            {
                //Create and open a connection
                SqlConnection connection = new SqlConnection(m_ConnectionString);
                connection.Open();

                //create and configure a command
                SqlCommand command = new SqlCommand("DELETE FROM POS_PENGELUARAN WHERE REF = @ref", connection);

                //Adding value through parameter
                command.CommandType = System.Data.CommandType.Text;
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@ref", referenceNumber);

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
