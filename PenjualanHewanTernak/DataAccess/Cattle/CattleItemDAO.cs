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
    class CattleItemDAO
    {
        #region Declarations
        private static string m_ConnectionString;
        #endregion

        #region Constructor
        public CattleItemDAO()
        {
            m_ConnectionString = Settings.Default.ConnectionString;
        }
        #endregion

        #region Methods

        internal void CreateDatabaseRecord(CattleItem newCattle)
        {
            string sql = "INSERT INTO CATTLE (KodeHewan,NamaHewan,KodeGrade,KodeJenis,Sort,Berat,Jenis_kelamin)" +
                         " VALUES (@code,@name,@codeGrade,@codeJenis,@sort,@berat,@jenisKelamin)";
            AddorUpdateRecord(sql, newCattle);
        }

        internal void UpdateDatabaseRecord(CattleItem updateCattle)
        {
            string sql = "UPDATE CATTLE SET " +
                        "NamaHewan = @name, " +
                        "KodeGrade = @codeGrade, " +
                        "KodeJenis = @codeJenis, " +
                        "Sort      = @sort, " +
                        "Berat     = @berat, " +
                        "Jenis_kelamin = @jenisKelamin " +
                        "WHERE KodeHewan = @code ";
            AddorUpdateRecord(sql, updateCattle);

        }

        internal void DeleteDatabaseRecord(string cattleCode)
        {
            string sql = "Delete From Cattle Where KodeHewan = @code";
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

        protected void AddorUpdateRecord(string sql, CattleItem ItemMaster)
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
                command.Parameters.AddWithValue("@code", ItemMaster.KodeHewan);
                command.Parameters.AddWithValue("@name", ItemMaster.NamaHewan);
                command.Parameters.AddWithValue("@codeGrade", ItemMaster.KodeGrade);
                command.Parameters.AddWithValue("@codeJenis", ItemMaster.KodeJenis);
                command.Parameters.AddWithValue("@sort", ItemMaster.Sort);
                command.Parameters.AddWithValue("@berat", ItemMaster.Berat);
                command.Parameters.AddWithValue("@jenisKelamin",ItemMaster.JenisKelamain);

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
