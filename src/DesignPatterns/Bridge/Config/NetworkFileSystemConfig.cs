namespace Lemure.DesignPatterns.Bridge.Config;

public class NetworkFileSystemConfig
{
	public string ServerAddress { get; set; }
	public string Username { get; set; }
	public string Password { get; set; }
}

public class NetworkFileSystemConfigBuilder
{
	private readonly NetworkFileSystemConfig _networkFileSystemConfig = new();

	public NetworkFileSystemConfigBuilder SetServerAddress(string serverAddress)
	{
		_networkFileSystemConfig.ServerAddress = serverAddress;
		return this;
	}

	public NetworkFileSystemConfigBuilder SetUsername(string username)
	{
		_networkFileSystemConfig.Username = username;
		return this;
	}

	public NetworkFileSystemConfigBuilder SetPassword(string password)
	{
		_networkFileSystemConfig.Password = password;
		return this;
	}

	public NetworkFileSystemConfig Build() => _networkFileSystemConfig;
}