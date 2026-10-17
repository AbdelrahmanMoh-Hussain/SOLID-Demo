namespace WithSOLID.DependencyInversion
{
    internal class SQLiteDatabaseConnector : IDatabaseConnector
    {
        public void Connect()
        {
            Console.WriteLine("Connecting to SQLite Database...");
        }
    }
}
