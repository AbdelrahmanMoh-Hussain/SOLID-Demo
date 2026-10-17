using System;
using System.Collections.Generic;
using System.Text;

namespace WithSOLID.DependencyInversion
{
    internal class ApplicationLogic
    {
        IDatabaseConnector _sQLDatabaseConnector;

        public ApplicationLogic(IDatabaseConnector sQLDatabaseConnector)
        {
            _sQLDatabaseConnector = sQLDatabaseConnector;
        }

        public void PerformDatabaseOperation()
        {
            _sQLDatabaseConnector.Connect();
            // Perform database operations
        }
    }
}
