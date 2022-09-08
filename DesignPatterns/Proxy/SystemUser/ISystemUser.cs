using System.Collections.Generic;

namespace Lemure.DesignPatterns.Proxy.SystemUser
{
    public interface ISystemUser
    {
        string UserName { get; }
        string FirstName { get; }
        IEnumerable<Address> GetAddressWithProxy();
        IEnumerable<Address> GetAddressNoProxy();
    }
}
