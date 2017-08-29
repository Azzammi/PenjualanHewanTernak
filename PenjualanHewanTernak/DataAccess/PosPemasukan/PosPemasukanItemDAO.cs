using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PenjualanHewanTernak.Model;
using System.Data.SqlClient;
using PenjualanHewanTernak.Properties;
using System.Windows.Forms;

namespace PenjualanHewanTernak.DataAccess
{
    class PosPemasukanItemDAO
    {
        #region Declaration
        private static string m_ConnectionString;
        #endregion

        #region Constructor
        public PosPemasukanItemDAO()
        {
            m_ConnectionString = Settings.Default.ConnectionString;
        }
        #endregion

        #region Method
        internal void CreateDatabaseRecord(posPemasukanItem newItem)
        {
            string sql = "INSERT INTO POS_PEMASUKAN(REF, KETERANGAN, STAT)" +
                        " OUTPUT INSERTED.REF " +
                        " VALUES('" + newItem.Ref + "','" + newItem.Keterangan + "','" + newItem.Stat + "')";

            //Execute The Query
            string newRecordID = (string)DataProvider.ExecuteScalar(sql);

            //Return the value
            newItem.Ref = newRecordID;
        }
        internal void UpdateDatabaseRecord(posPemasukanItem updateItem)
        {
            string sql = "UPDATE POS_PEMASUKAN SET " +
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
        internal void DeleteDatabaseRecord(string noRef)
        {
            try
            {
                //Create and open a connection
                SqlConnection connection = new SqlConnection(m_ConnectionString);
                connection.Open();

                //create and configure a command
                SqlCommand command = new SqlCommand("DELETE FROM POS_PEMASUKAN WHERE REF = @ref", connection);

                //Adding value through parameter
                command.CommandType = System.Data.CommandType.Text;
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@ref", noRef);

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
