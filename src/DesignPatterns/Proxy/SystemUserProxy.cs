using System.Collections.Generic;
using Lemure.DesignPatterns.Proxy.SystemUser;

namespace Lemure.DesignPatterns.Proxy;

public class SystemUserProxy : ISystemUser
{
	private ISystemUser _realUser = null;
	private IEnumerable<Address> _address = null;

	public string UserName { get; }
	public string FirstName { get; }

	public SystemUserProxy(string username, string firstname)
	{
		UserName = username;
		FirstName = firstname;
	}

	private ISystemUser CreateUser()
	{
		if (_realUser is null)
		{
			// You should be using Inversion of Depedency
			_realUser = new AdminUser("Yuri Administrator", "yuribh");
		}

		return _realUser;
	}

	public IEnumerable<Address> GetAddressWithProxy()
	{
		_realUser = CreateUser();

		if (_address is null)
			_address = _realUser.GetAddressWithProxy();

		return _address;
	}

	public IEnumerable<Address> GetAddressNoProxy()
	{
		_realUser = CreateUser();

		return _realUser.GetAddressNoProxy();
	}
}
