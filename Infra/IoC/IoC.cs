using System;

namespace lemure.Infra.IoC
{
    public class IoC
    {
        public static void GetMain()
        {
            User user = new User(new OracleDatabase());
            user.Add("This is some data");
        }

        public interface Database
        {
            public void Persist(string data);
        }

        public class User
        {
            Database database;
            public User(Database db)
            {
                this.database = db;
            }

            public void Add(string data)
            {
                database.Persist(data);
            }
        }

        public class MySqlDatabase : Database
        {
            public void Persist(string data)
            {
                Console.WriteLine("Mysql has persisted");
            }
        }

        public class OracleDatabase : Database
        {
            public void Persist(string data)
            {
                Console.WriteLine("Oracle has persisted");
            }
        }
    }
}
