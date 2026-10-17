using System;
using System.Collections.Generic;
using System.Text;

namespace WithSOLID.DependencyInversion
{
    internal class SQLDatabaseConnector : IDatabaseConnector
    {
        public void Connect()
        {
            Console.WriteLine("Connecting to SQL Database...");
        }
    }
}
