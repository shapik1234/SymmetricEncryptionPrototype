using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using com.rusanu.dataconnectiondialog;

namespace FileStoragePOC
{
    internal static class DataServerHelper
    {
        internal static SqlConnection EstablishConnection()
        {
            var connection = new SqlConnection
                (ConfigurationManager.ConnectionStrings["CurrentConnection"].ConnectionString);
            return connection;
        }

        internal static SqlConnectionStringBuilder ChangeConnection(SqlConnection connection)
        {
            var dlg = new DataConnectionDialog(new SqlConnectionStringBuilder());
            if (DialogResult.OK == dlg.ShowDialog())
            {
                using (connection = EstablishConnection())
                {
                    connection.Open();
                    var appSettingsHelper = new AppSettingsHelper();
                    appSettingsHelper.SaveConnectionString("CurrentConnection",
                        $"Data Source={dlg.ConnectionStringBuilder.DataSource};" +
                        $"Initial Catalog={dlg.ConnectionStringBuilder.InitialCatalog};" +
                        $"User ID={dlg.ConnectionStringBuilder.UserID}," +
                        $"Password={dlg.ConnectionStringBuilder.Password};");
                    return dlg.ConnectionStringBuilder;
                }
            }
            return dlg.ConnectionStringBuilder;
        }

        internal static List<string> GetDatabaseNames(SqlConnection connection)
        {
            var databasesList = new List<string>();

            var cmd = new SqlCommand
            {
                CommandType = CommandType.StoredProcedure,
                CommandText = "sp_databases",
                Connection = EstablishConnection()
            };
            cmd.Connection.Open();
            var reader = cmd.ExecuteReader();
            using (connection)
            {
                while (reader.Read())
                {
                    databasesList.Add(reader["DATABASE_NAME"].ToString());
                }
            }
            return databasesList;
        }
    }
}