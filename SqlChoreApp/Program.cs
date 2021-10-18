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


            DisconnectFromDB.Disconnect(ChoreDBConnection);
        }
    }
}
