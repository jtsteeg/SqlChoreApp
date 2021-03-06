using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SqlChoreApp
{
    class TableCreator
    {

        static public void CreateTable(SqlConnection currentConnection)
        {
            Console.Write("Dropping and creating database 'ChoreDB' ... ");
            String sql = "DROP DATABASE IF EXISTS [ChoreDB]; CREATE DATABASE [ChoreDB]";
            using (SqlCommand command = new SqlCommand(sql, currentConnection))
            {
                command.ExecuteNonQuery();
                Console.WriteLine("Done.");
            }

            Console.Write("Creating sample table with data, press any key to continue...");
            Console.ReadKey(true);
            StringBuilder sb = new StringBuilder();
            sb.Append("USE ChoreDB; ");
            sb.Append("CREATE TABLE Chores ( ");
            sb.Append(" ChoreId INT IDENTITY(1,1) NOT NULL PRIMARY KEY, ");
            sb.Append(" ChoreName NVARCHAR(MAX), ");
            sb.Append(" ChoreAssignment NVARCHAR(MAX) ");
            sb.Append("); ");
            sql = sb.ToString();
            using (SqlCommand command = new SqlCommand(sql, currentConnection))
            {
                command.ExecuteNonQuery();
                Console.WriteLine("Done.");
            }
        }
    }
}
