﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PenjualanHewanTernak.Properties;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PenjualanHewanTernak.DataAccess
{
    public static class ConnectionProvider
    {
        #region Declarations
        static string m_ConnectionString;
        #endregion

        #region Constructor
        static ConnectionProvider()
        {
            m_ConnectionString = Settings.Default.ConnectionString;
        }
        #endregion

        #region Methods
        public static SqlConnection Open()
        {
            try
            {
                SqlConnection koneksi = new SqlConnection(m_ConnectionString);
                koneksi.Open();

                return koneksi;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message.ToString());
                return null;
            }
        }
        #endregion
    }
}
