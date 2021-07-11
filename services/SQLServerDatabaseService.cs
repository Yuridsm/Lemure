using System;
using System.Collections.Generic;
using System.Text;
using lemure.interfaces;

namespace lemure.services
{
    class SQLServerDatabaseService : IDatabase
    {
        public void delete()
        {
            Console.WriteLine("SQL Server...");
            Console.WriteLine("Deleting 1 row");
        }

        public void insert()
        {
            Console.WriteLine("SQL Server...");
            Console.WriteLine("Inserting 1 row");
        }

        public void select()
        {
            Console.WriteLine("SQL Server...");
            Console.WriteLine("Selecting 1 row");
        }

        public void update()
        {
            Console.WriteLine("SQL Server...");
            Console.WriteLine("Updating 1 row");
        }
    }
}
