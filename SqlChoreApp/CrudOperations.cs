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
        StringBuilder sb = new StringBuilder();

        static public void UpdateChore(SqlConnection currentConnection)
        {
            String userToUpdate = "Lambert";
            Console.Write("Updating the assigned Chore for '" + userToUpdate + "', press any key to continue...");
            Console.ReadKey(true);
            StringBuilder sb = new StringBuilder();
            sb.Clear();
            sb.Append("UPDATE Chores SET ChoreName = N'Laundry' WHERE ChoreAssignment = @name");
            String sqlCommand = sb.ToString();
            using (SqlCommand command = new SqlCommand(sqlCommand, currentConnection))
            {
                command.Parameters.AddWithValue("@name", userToUpdate);
                int rowsAffected = command.ExecuteNonQuery();
                Console.WriteLine(rowsAffected + " row(s) updated");
            }
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

        static public void ReadChores(SqlConnection currentConnection)
        {
            Console.WriteLine("Reading data from Chore table, press any key to continue...");
            Console.ReadKey(true);
            String sqlCommand = "SELECT ChoreID, ChoreName, ChoreAssignment FROM Chores;";
            using (SqlCommand command = new SqlCommand(sqlCommand, currentConnection))
            {

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Console.WriteLine("{0} {1} {2}", reader.GetInt32(0), reader.GetString(1), reader.GetString(2));
                    }
                }
            }
        }


    }
}
