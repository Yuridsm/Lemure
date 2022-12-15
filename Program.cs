using System;
using Lemure.Logging;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Serilog.Sinks.Elasticsearch;
using Serilog;
using Lemure.Invariants;
using Lemure.DesignPatterns.FluentInterface;

namespace Lemure
{
    public class Program
    {
        private static readonly ILoggerFactory _loggerFactory;

        #region GetConfigurationFromAppSettings
        public static void SetupLogging()
        {
            Log.Logger = new LoggerConfiguration()
                .Enrich.FromLogContext()
                .WriteTo.Elasticsearch(new ElasticsearchSinkOptions(new Uri(GetObervabilitySetting().ElasticSearchURL))
                {
                    AutoRegisterTemplate = true
                })
                .CreateLogger();
        }

        public static Settings GetObervabilitySetting()
        {
            IConfiguration configuration = Config.Run();

            Settings settings = configuration.GetRequiredSection("Settings").Get<Settings>();

            return settings;
        }
        #endregion

        public static void Main(string[] args)
        {
            //var configuration = new ConfigurationBuilder()
            //    .AddJsonFile("appsettings.json")
            //    .Build();

            //Log.Logger = new LoggerConfiguration()
            //    .ReadFrom.Configuration(configuration)
            //    .WriteTo.Console()
            //    .WriteTo.MySQL("server=localhost;uid=root;pwd=fagote123;database=logging;")
            //    .CreateLogger();

            //try
            //{
            //    Log.Information("Application Starting Up");

            //    for (int i = 0; i < 1_000_000; i++)
            //    {
            //        if (i % 2 == 1)
            //            Log.Fatal("Erro fatal;");
            //        else
            //        {
            //            Log.Information("Info fatal;");
            //        }
            //    }

            //    CreateHostBuilder(args).Build().Run();
            //}
            //catch (Exception ex)
            //{
            //    Log.Fatal(ex, "The Application Failed to start correctly.");
            //}
            //finally
            //{
            //    Log.CloseAndFlush();
            //}

            //Client.Run();
            var car = Bambobi.Create("Amarelo", 4);
        }

        private static void RunSomething(int id)
        {
            if(id >= 10 && id <= 15 )
                return;
        }

        public static void LoopIt()
        {
            for(int i = 0; i < 50; i++)
            {
                RunSomething(i);
                Console.WriteLine($"Running at {i}");
            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args);
        }
    }
}
