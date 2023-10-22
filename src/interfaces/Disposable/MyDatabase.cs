using System;

namespace lemure.interfaces.Disposable;

public class MyDatabase : IDisposable
{
	private string _connectionString;
	public MyDatabase(string connectionString)
	{
		_connectionString = connectionString;
	}

	public void GetOnDatabase()
	{
		Console.WriteLine("Connecting to the Database by means of {0}", this._connectionString);
		Console.WriteLine("Getting data...");
	}

	public void Dispose()
	{
		Console.WriteLine("Close my connection by dispose method.");
	}
}
