using System;
using System.IO;
using System.Threading.Tasks;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;

namespace ServiceBusPublisher
{
    class Program
    {
        public static void Main(string[] args)
        {

            /*
            var host = new HostBuilder()
                .ConfigureAppConfiguration((hostingContext, config) => GetConfiguration())
                .ConfigureServices(services => startup.ConfigureServices(services));
            */

            //IServiceCollection serviceCol = new ServiceCollection();

            //IServiceProvider serviceProvider = serviceCol.BuildServiceProvider();

            //configure console logging
            //serviceProvider.GetService<ILoggerFactory>().AddConsole(LogLevel.Debug);

            //var logger = serviceProvider.GetService<ILoggerFactory>()
            //    .CreateLogger<Program>();

            //var raiseEvent = serviceProvider.GetService<IClientRaiseIntegrationEventService>();

            //raiseEvent.PublishThroughEventBusAsync(new ClientMessageIntegrationEvent());

            //await host.RunConsoleAsync();
        }

        private static IConfiguration GetConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", false, true)
                .AddEnvironmentVariables();

            return builder.Build();
        }
    }
}
