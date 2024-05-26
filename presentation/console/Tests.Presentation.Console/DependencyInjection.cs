using System;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Tests.Presentation.Console.HostedServices;
using Tests.Infrastructure;


namespace Tests.Presentation.Console
{
    public static class DependencyInjection
    {
        public static async Task StartApplication(string[]? args){
            HostApplicationBuilder builder = Host.CreateApplicationBuilder(args);

            builder.Services.AddInfrastructure();
            builder.Services.AddHostedServiceWorker();


            IHost host = builder.Build();

            await host.RunAsync();
        }

        public static IServiceCollection AddHostedServiceWorker(this IServiceCollection services)
        {
            services.AddHostedService<HostedServiceWorker>();
            return services;
        }
    }
}