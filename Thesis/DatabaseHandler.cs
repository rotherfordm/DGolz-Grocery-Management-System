using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Thesis
{
    public static class DatabaseHandler
    {
        private static String ServerName = @"HEATZROG\TEW_SQLEXPRESS";

        private static SqlConnection sqlConnection;

        public static SqlConnection GetNewConnection()
        {
            try
            {
                sqlConnection = new SqlConnection("Data Source='" + ServerName + "'; Initial Catalog = DGOLZMART; Integrated Security = True");
            }
            catch (SqlException e)
            {
                System.Windows.Forms.MessageBox.Show("Error: " + e.ToString());
            }
            return sqlConnection;
        }

        public static String GetServerName()
        {
            return ServerName;
        }

    }
}
