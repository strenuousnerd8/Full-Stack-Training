using Consul;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;

namespace User_Management.Config
{
    public static class ServiceRegistryAppExtension
    {
        public static IServiceCollection AddConsulConfig(this IServiceCollection services, ConfigurationSetting _configurationSetting)
        {
            string ConsulAddress = "http://localhost:8500";



            services.AddSingleton<IConsulClient, ConsulClient>(p => new ConsulClient(consulConfig =>
            {
                consulConfig.Address = new Uri(ConsulAddress);
            }));
            return services;
        }

        public static IApplicationBuilder UseConsul(this IApplicationBuilder app, ConfigurationSetting _configurationSetting)
        {
            var consulClient = app.ApplicationServices.GetRequiredService<IConsulClient>();
            var logger = app.ApplicationServices.GetRequiredService<ILoggerFactory>().CreateLogger("AppExtensions");
            var lifetime = app.ApplicationServices.GetRequiredService<IApplicationLifetime>();



            var registration = new AgentServiceRegistration()
            {
                ID = "UserManagement",
                Name = "User Management",
                Address = "localhost",
                Port = 60001
            };



            logger.LogInformation("Registering with Consul");
            consulClient.Agent.ServiceDeregister(registration.ID).ConfigureAwait(true);
            consulClient.Agent.ServiceRegister(registration).ConfigureAwait(true);



            lifetime.ApplicationStopping.Register(() =>
            {
                logger.LogInformation("Unregistering from Consul");
            });



            return app;
        }

    }
}