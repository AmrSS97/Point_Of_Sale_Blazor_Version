using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Serilog;

namespace WebAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            string environment = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

            if (environment != null)
            {
                IConfigurationRoot config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false)
                .AddJsonFile($"appsettings.{environment}.json", optional: true)
                .Build();
                int port = config.GetValue<int>("port");
                IHostBuilder host = Host.CreateDefaultBuilder(args)
               .ConfigureLogging((hostingContext, config) => { config.ClearProviders(); })
               .ConfigureWebHostDefaults(webBuilder =>
               {
                   webBuilder.ConfigureKestrel(options =>
                   {
                       // Set properties and call methods on options
                       options.Limits.MaxConcurrentConnections = 100;
                       options.Limits.MaxConcurrentUpgradedConnections = 100;
                       options.Limits.MinRequestBodyDataRate = new MinDataRate(bytesPerSecond: 100,
                           gracePeriod: TimeSpan.FromSeconds(10));
                       options.Limits.MinResponseDataRate = new MinDataRate(bytesPerSecond: 100,
                           gracePeriod: TimeSpan.FromSeconds(10));
                       options.Limits.MaxRequestBodySize = null;
                       options.Listen(IPAddress.Any, port);
                   });
                   webBuilder.UseStartup<Startup>();
               }).UseSerilog();

                return host;
            }
            else
            {
                Console.WriteLine("Fatal error: environment not found!");
                Environment.Exit(-1);
                return null;
            }
        }
    }
}
