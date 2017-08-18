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
    class GradeItemDAO
    {
        #region Declarations
        private static string m_ConnectionString;
        #endregion

        #region Constructor
        public GradeItemDAO()
        {
            m_ConnectionString = Settings.Default.ConnectionString;
        }
        #endregion

        #region Methods

        internal void CreateDatabaseRecord(GradeItem newGrade)
        {
            string sql = "INSERT INTO GRADE (KodeGrade,Ket,Stat)" +
                         " VALUES (@code,@ket,@stat)";
            AddorUpdateRecord(sql, newGrade);
        }

        internal void UpdateDatabaseRecord(GradeItem updateGrade)
        {
            string sql = "UPDATE GRADE SET " +
                        "Ket = @ket, " +
                        "stat = @stat " +                        
                        "WHERE KodeGrade = @code ";
            AddorUpdateRecord(sql, updateGrade);

        }

        internal void DeleteDatabaseRecord(string cattleCode)
        {
            string sql = "Delete From Grade Where KodeGrade = @code";
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

        protected void AddorUpdateRecord(string sql, GradeItem ItemMaster)
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
                command.Parameters.AddWithValue("@code", ItemMaster.KodeGrade);
                command.Parameters.AddWithValue("@ket", ItemMaster.Keterangan);
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
