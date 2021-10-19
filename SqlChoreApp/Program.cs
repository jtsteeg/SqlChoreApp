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

            CrudOperations.CreateChore(ChoreDBConnection);

            CrudOperations.UpdateChore(ChoreDBConnection);

            CrudOperations.DeleteChore(ChoreDBConnection);

            CrudOperations.ReadChores(ChoreDBConnection);


            DisconnectFromDB.Disconnect(ChoreDBConnection);
        }
    }
}
