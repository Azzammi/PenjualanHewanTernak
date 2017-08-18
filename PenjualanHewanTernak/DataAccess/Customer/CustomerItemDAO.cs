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
    class CustomerItemDAO
    {
        #region Declarations
        private static string m_ConnectionString;
        #endregion

        #region Constructor
        public CustomerItemDAO()
        {
            m_ConnectionString = Settings.Default.ConnectionString;
        }
        #endregion

        #region Methods
        internal void CreateDatabaseRecord(CustomerItem newCustomer)
        {
            string sql = string.Format("INSERT INTO CUSTOMER " +
                         "(KodeCust) " +
                         "OUTPUT INSERTED.KodeCust " +
                         " VALUES " +
                         "('{0}') ", "CUST" + DataProvider.GenerateNumber("CUSTOMER","KodeCust"));

            //Execute Query
            string newRecordID = DataProvider.ExecuteScalar(sql);

            //Return Number
            newCustomer.KodeCust = newRecordID;
        }

        internal void UpdateDatabaseRecord(CustomerItem updateCustomer)
        {
            string sql = "UPDATE CUSTOMER SET " +
                         "NamaCust = @name, " +
                         "Alamat = @alamat, " +
                         "Email = @email, " +
                         "Telp = @telp, " +
                         "tgl_Masuk = @tglMasuk, " +
                         "Spesial_Diskon = @spesialDiskon, " +
                         "isPercent = @isPercent, " +
                         "Diskon = @Diskon, " +
                         "Ket = @ket " +
                         "WHERE KodeCust = @code ";
            AddOrUpdateDatabase(sql, updateCustomer);
        }

        internal void DeleteDatabaseRecord(string KodeCustomer)
        {
            string sql = "Delete From CUSTOMER Where KodeCust = @code";
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
                command.Parameters.AddWithValue("@code", KodeCustomer);

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

        protected void AddOrUpdateDatabase(string sql, CustomerItem ItemMaster)
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
                command.Parameters.AddWithValue("@code", ItemMaster.KodeCust);
                command.Parameters.AddWithValue("@name", ItemMaster.NamaCust);
                command.Parameters.AddWithValue("@alamat", ItemMaster.Alamat);
                command.Parameters.AddWithValue("@email", ItemMaster.Email);
                command.Parameters.AddWithValue("@telp", ItemMaster.Telepon);                
                command.Parameters.AddWithValue("@tglMasuk", ItemMaster.TglMasuk);
                command.Parameters.AddWithValue("@spesialDiskon", ItemMaster.IsDiscount);
                command.Parameters.AddWithValue("@isPercent", ItemMaster.IsPercent);
                command.Parameters.AddWithValue("@diskon", ItemMaster.Diskon);
                command.Parameters.AddWithValue("@ket", ItemMaster.Keterangan);

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
