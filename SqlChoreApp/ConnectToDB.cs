using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SqlChoreApp
{
    public class ConnectToDB
    {
                   
        static public SqlConnection connect()
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "DESKTOP-0SORUCL\\SQLSERVER2019";
            builder.UserID = "sa";
            builder.Password = "youshouldn'tsavepasswordsasplaintext!1";
            builder.InitialCatalog = "master";
            SqlConnection connection = new SqlConnection(builder.ConnectionString);

            try
            {
                // Connect to SQL
                Console.Write("Connecting to SQL Server ... ");
                    connection.Open();
                    Console.WriteLine("Done.");
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }

            return connection;
        }
    }
}
