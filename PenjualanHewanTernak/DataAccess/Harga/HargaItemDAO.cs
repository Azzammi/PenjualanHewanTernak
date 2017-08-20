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
    class HargaItemDAO
    {
        #region Declarations
        private static string m_ConnectionString;
        #endregion

        #region Constructor
        public HargaItemDAO()
        {
            m_ConnectionString = Settings.Default.ConnectionString;
        }
        #endregion

        #region Methods

        internal void CreateDatabaseRecord(HargaItem newHarga)
        {
            string sql = "INSERT INTO PRIC (KodeGrade, KodeHewan, beforePriceDate, beforePrice, currentPriceDate, currentPrice, stat)" +
                         " VALUES (@codeGrade, @codeHewan, @beforeDate, @beforePrice, @currentDate, @currentPrice, @stat)";
            AddorUpdateRecord(sql, newHarga);
        }

        internal void UpdateDatabaseRecord(HargaItem updateHarga)
        {
            string sql = "UPDATE PRIC SET " +
                        "beforePriceDate = @beforeDate, " +
                        "beforePrice = @beforePrice, " +
                        "currentPriceDate = @currentDate, " +
                        "currentPrice = @currentPrice, " +
                        "stat     = @stat " +                        
                        "WHERE KodeGrade = @codeGrade and KodeHewan = @codeHewan; ";
            AddorUpdateRecord(sql, updateHarga);

        }

        internal void DeleteDatabaseRecord(string gradeCode, string cattleCode)
        {
            string sql = "Delete From Harga Where KodeGrade = @codeGrade and KodeHewan = @code";
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
                command.Parameters.AddWithValue("@codeGrade", gradeCode);
                command.Parameters.AddWithValue("@code", cattleCode);

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

        internal void UbahHarga (HargaItem changeHarga)
        {
            changeHarga.BeforePrice = changeHarga.CurrentPrice;
            changeHarga.BeforePriceDate = changeHarga.BeforePriceDate;

            changeHarga.CurrentPrice = 0;
            changeHarga.CurrentPriceDate = DateTime.Now;
        }
        protected void AddorUpdateRecord(string sql, HargaItem ItemMaster)
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
                command.Parameters.AddWithValue("@codeGrade", ItemMaster.KodeGrade);
                command.Parameters.AddWithValue("@codeHewan", ItemMaster.KodeHewan);
                command.Parameters.AddWithValue("@beforeDate", ItemMaster.BeforePriceDate);
                command.Parameters.AddWithValue("@beforePrice", ItemMaster.BeforePrice);
                command.Parameters.AddWithValue("@currentDate", ItemMaster.CurrentPriceDate);
                command.Parameters.AddWithValue("@currentPrice", ItemMaster.CurrentPrice);
                command.Parameters.AddWithValue("@stat", ItemMaster.Stat);

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
