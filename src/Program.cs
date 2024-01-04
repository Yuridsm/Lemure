using System;
using System.IO;
using System.Threading.Tasks;
using lemure.OptionalObject;
using Lemure.Caching;
using Lemure.CQRS;
using Lemure.Delegates;
using Lemure.DesignPatterns.Iterator;
using Lemure.Infrastructure;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;

namespace Lemure;

public static class Program
{
    public static async Task Main(string[] args)
    {
        //using IHost host = CreateHostBuilder(args).Build();
        //using var scope = host.Services.CreateScope();
        //var services = scope.ServiceProvider;

        //var configuration = services.GetRequiredService<IConfiguration>();
        //Log.Logger = new LoggerConfiguration()
        //    .ReadFrom.Configuration(configuration)
        //    .CreateLogger();

        //var testCQRS = services.GetRequiredService<TestCQRS>();

        //await testCQRS.Run();

        //Log.CloseAndFlush();
        // new IteratorClient().Run();
        FuncStudy.Execute();
    }

    static IHostBuilder CreateHostBuilder(string[] args)
    {
        return Host.CreateDefaultBuilder()
            .ConfigureHostConfiguration(host =>
            {
                host.SetBasePath(Directory.GetCurrentDirectory());
                host.AddJsonFile("appsettings.json", true, true);
                host.AddCommandLine(args);
            })
            .ConfigureServices((_, services) =>
            {
                services.AddMemoryCache();
                services.AddTransient<PerformanceNoCaching>();
                services.AddTransient<DatabaseEmployee>();
                services.AddTransient<TestCQRS>();
                services.AddSingleton<IBookmarkRepository, BookmarkRepository>();
                services.AddCQRSLayerServices();
            });
    }
}
