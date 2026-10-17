using System;
using System.Collections.Generic;
using System.Text;

namespace WithoutSOLID.DependencyInversion
{
    internal class ApplicationLogic
    {
        private SQLDatabaseConnector sQLDatabaseConnector = new SQLDatabaseConnector(); // Violates the Dependency Inversion Principle (DIP) because it depends on a low-level module (SQLDatabaseConnector) instead of an abstraction.

        public void PerformDatabaseOperation()
        {
            sQLDatabaseConnector.Connect();
            // Perform database operations
        }
    }
}
