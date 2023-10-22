using System;
using System.Collections.Generic;
using Lemure.DesignPatterns.Proxy.SystemUser;

namespace Lemure.DesignPatterns.Proxy;

public class Client
{
	public static void ShowMe(IEnumerable<Address> addresses)
	{
		foreach (var address in addresses)
		{
			Console.WriteLine(address);
		}
		Console.WriteLine("\n");
	}

	public static void RunWithProxy()
	{
		var user = new SystemUserProxy("Igor", "igordsm");
		IEnumerable<Address> addresses = null;

		Console.WriteLine("Start............");

		for (int index = 0; index < 10; index++)
		{
			addresses = user.GetAddressWithProxy();
			ShowMe(addresses);
		}
	}

	public static void RunNoProxy()
	{
		var user = new SystemUserProxy("Igor", "igordsm");
		IEnumerable<Address> addresses = null;

		Console.WriteLine("Start............");

		for (int index = 0; index < 10; index++)
		{
			addresses = user.GetAddressNoProxy();
			ShowMe(addresses);
		}
	}
}
