using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SqlChoreApp
{
    class DisconnectFromDB
    {

        static public void Disconnect(SqlConnection currentConnection)
        {
            Console.WriteLine("All done. Press any key to finish...");
            Console.ReadKey(true);
            currentConnection.Close();
            Console.WriteLine("Disconnected.");
        }
    }
}
