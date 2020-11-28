using System;
using LeanringWithMosh.Controllers;
using LeanringWithMosh.services;

namespace LeanringWithMosh
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            OracleDatabaseService oracle = new OracleDatabaseService();
            MySQLDatabaseService mysql = new MySQLDatabaseService();
            PostegreSQLDatabaseService postegresql = new PostegreSQLDatabaseService();
            MongoDbDatabaseService mongodb = new MongoDbDatabaseService();
            Db2DatabaseService db2 = new Db2DatabaseService();
            SQLServerDatabaseService sqlServer = new SQLServerDatabaseService();


            CustomerController customer = new CustomerController(postegresql);
            customer.getRepository().select();
        }
    }
}
