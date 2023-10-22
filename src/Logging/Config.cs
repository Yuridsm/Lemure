using Microsoft.Extensions.Configuration;

namespace Lemure.Logging;

public static class Config
{
	public static IConfiguration Run()
	{
		IConfiguration configuration = new ConfigurationBuilder()
			.AddJsonFile("appsettings.json")
			.AddEnvironmentVariables()
			.Build();

		return configuration;
	}
}
