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
    class ChildrenItemDAO
    {
        #region Declarations
        public static string m_ConnectionString;
        #endregion

        #region Constructor
        public ChildrenItemDAO()
        {
            m_ConnectionString = Settings.Default.ConnectionString;
        }
        #endregion

        #region Methods
        internal void CreateDatabaseRecord(ChildrenItem newChildren, string kodeCust)
        {
            string sql = string.Format("INSERT INTO CHILDREN" +
                         "(KodeAnak, KodeCust) " +
                         "OUTPUT INSERTED.KodeAnak " +
                         "VALUES('{0}','{1}')", "CHLD" + DataProvider.GenerateNumber("CHILDREN","KodeAnak"), kodeCust);

            //Execute The Query
            string newRecordID = DataProvider.ExecuteScalar(sql);

            //Set Record ID of the new Object
            newChildren.Kodeanak = newRecordID;
        }
        internal void UpdateDatabaseRecord(ChildrenItem updateChildren)
        {
            StringBuilder SqlQuery = new StringBuilder("UPDATE CHILDREN SET ");
            SqlQuery.Append(String.Format("Nama = '{0}' ,", updateChildren.Nama));
            SqlQuery.Append(String.Format("NamaAyah = '{0}', ", updateChildren.NamaAyah));
            SqlQuery.Append(String.Format("NamaIbu = '{0}', ", updateChildren.NamaIbu));
            SqlQuery.Append(String.Format("JenisKelamin = '{0}', ", updateChildren.JenisKelamin));
            SqlQuery.Append(String.Format("TglLahir = '{0}', ", updateChildren.TglLahir));
            SqlQuery.Append(String.Format("TempatLahir = '{0}' ", updateChildren.TempatLahir));
            SqlQuery.Append(String.Format("WHERE KodeAnak = '{0}'", updateChildren.Kodeanak));

            //Execute Query
            DataProvider.ExecuteNonQuery(SqlQuery.ToString());
        }
        internal void DeleteDatabaseRecord(string Kode)
        {
            string sql = "Delete From Children Where KodeAnak = @code";
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
                command.Parameters.AddWithValue("@code", Kode);

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
        protected void AddOrUpdateDatabaseRecord(string sql, ChildrenItem ItemMaster)
        {
            //try
            //{
            //    //Create and open a connection
            //    SqlConnection connection = new SqlConnection(m_ConnectionString);
            //    connection.Open();

            //    //create and configure a command
            //    SqlCommand command = new SqlCommand(sql, connection);

            //    //Adding value through parameter
            //    command.CommandType = System.Data.CommandType.Text;
            //    command.Parameters.Clear();
            //    command.Parameters.AddWithValue("@code", ItemMaster.KodeCust);
            //    command.Parameters.AddWithValue("@codeCust", ItemMaster.NamaCust);
            //    command.Parameters.AddWithValue("@alamat", ItemMaster.Alamat);
            //    command.Parameters.AddWithValue("@nama", ItemMaster.Email);
            //    command.Parameters.AddWithValue("@namaAyah", ItemMaster.Telepon);
            //    command.Parameters.AddWithValue("@namaIbu", ItemMaster.TglMasuk);
            //    command.Parameters.AddWithValue("@jenisKelamin", ItemMaster.IsDiscount);
            //    command.Parameters.AddWithValue("@tglLahir", ItemMaster.IsPercent);
            //    command.Parameters.AddWithValue("@tempatLahir", ItemMaster.Diskon);                

            //    //execute the command
            //    command.ExecuteNonQuery();

            //    //Close and dispose
            //    command.Dispose();
            //    connection.Close();
            //    connection.Dispose();

            //}
            //catch (SqlException ex)
            //{
            //    MessageBox.Show(ex.Message.ToString());
            //}
        }
        #endregion
    }
}
