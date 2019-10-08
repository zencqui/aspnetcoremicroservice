using System;
using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace ServiceBusPublisher
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            services.AddIntegrationServices(Configuration)
                .AddEventBus(Configuration)
                .AddAutofac()
                .AddLogging(config => config.AddConsole());

            var container = new ContainerBuilder();
            container.Populate(services);

            return  new AutofacServiceProvider(container.Build());
        }
    }
}