using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Lemure.DesignPatterns.Proxy.SystemUser
{
    public class AdminUser : ISystemUser
    {
        public string UserName { get; }
        public string FirstName { get; }

        public AdminUser(string userName, string firstName)
        {
            UserName = userName;
            FirstName = firstName;
        }

        public IEnumerable<Address> GetAddressWithProxy()
        {
            Thread.Sleep(5000);

            return new List<Address>()
                {
                    new Address("Rua A", 1),
                    new Address("Rua B", 2),
                    new Address("Rua C", 3),
                    new Address("Rua D", 4),
                    new Address("Rua E", 5)
                };
        }

        public IEnumerable<Address> GetAddressNoProxy()
        {
            Thread.Sleep(5000);

            return new List<Address>()
                {
                    new Address("Rua A", 1),
                    new Address("Rua B", 2),
                    new Address("Rua C", 3),
                    new Address("Rua D", 4),
                    new Address("Rua E", 5)
                };
        }
    }
}
