using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;

namespace Lemure;

public static class Program
{
    public static void Main()
    {
        var configuration = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json", true, true)
            .Build();

        var service = new ServiceCollection();
        service.AddFoo(configuration);

        var provider = service.BuildServiceProvider();

        var controller = new TestController(provider.GetService<IOptions<Baz>>());

        controller.Show();
    }

    public static void AddFoo(this IServiceCollection serviceCollection, IConfiguration configuration)
    {
        serviceCollection.Configure<Baz>(configuration.GetSection("Baz"));
    }
}

public class TestController
{
    private readonly Baz options;

    public TestController(IOptions<Baz> options)
    {
        this.options = options.Value;
    }

    public void Show()
    {
        Console.WriteLine(options.TestXPTO);
        Console.WriteLine(options.DescriptionXPTO);
    }
}

public class Baz
{
    public string TestXPTO { get; set; } = string.Empty;
    public string DescriptionXPTO { get; set; } = string.Empty;
}