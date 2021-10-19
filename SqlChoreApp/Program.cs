using System;
using System.Data.SqlClient;

namespace SqlChoreApp
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection ChoreDBConnection = ConnectToDB.connect();

            TableCreator.CreateTable(ChoreDBConnection);

            CrudOperations.CreateChore(ChoreDBConnection, "Dishes", "Fred");
            CrudOperations.CreateChore(ChoreDBConnection, "Trash", "George");
            CrudOperations.CreateChore(ChoreDBConnection, "Mop the floor", "Lambert");
            

            CrudOperations.UpdateChore(ChoreDBConnection);

            CrudOperations.DeleteChore(ChoreDBConnection);

            CrudOperations.ReadChores(ChoreDBConnection);

            DisconnectFromDB.Disconnect(ChoreDBConnection);
        }
    }
}
