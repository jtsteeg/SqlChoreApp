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

            CrudOperations.DeleteChore(ChoreDBConnection);


            DisconnectFromDB.Disconnect(ChoreDBConnection);
        }
    }
}
