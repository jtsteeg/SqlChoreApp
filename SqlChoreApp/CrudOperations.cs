using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SqlChoreApp
{
    class CrudOperations
    {

        static public void UpdateChore(SqlConnection currentConnection)
        {
           
        }

        static public void DeleteChore(SqlConnection currentConnection)
        {
            String choreToDelete = "Dishes";
            Console.Write("Deleting chore '" + choreToDelete + "', press any key to continue...");
            Console.ReadKey(true);
            StringBuilder sb = new StringBuilder();
            sb.Clear();
            sb.Append("DELETE FROM Chores WHERE ChoreName = @name;");
            String sqlCommand = sb.ToString();
            using (SqlCommand command = new SqlCommand(sqlCommand, currentConnection))
            {
                command.Parameters.AddWithValue("@name", choreToDelete);
                int rowsAffected = command.ExecuteNonQuery();
                Console.WriteLine(rowsAffected + " row(s) deleted");
            }
        }


    }
}
