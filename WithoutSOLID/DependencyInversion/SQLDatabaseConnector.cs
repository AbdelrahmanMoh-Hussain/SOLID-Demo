using System;
using System.Collections.Generic;
using System.Text;

namespace WithoutSOLID.DependencyInversion
{
    internal class SQLDatabaseConnector
    {
        public void Connect()
        {
            Console.WriteLine("Connecting to SQL Database...");
        }
    }
}
