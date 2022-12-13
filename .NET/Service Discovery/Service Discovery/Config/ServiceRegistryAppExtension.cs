using Consul;
using IApplicationLifetime = Microsoft.Extensions.Hosting.IApplicationLifetime;

namespace Service_Discovery.Config
{
    public static class ServiceRegistryAppExtension
    {
        public static IServiceCollection AddConsulConfig(this IServiceCollection services)
        {
            string ConsulAddress = "http://localhost:8500";

            services.AddSingleton<IConsulClient, ConsulClient>(p => new ConsulClient(consulConfig =>
            {
                consulConfig.Address = new Uri(ConsulAddress);
            }));
            return services;
        }
        
        public static IApplicationBuilder UseConsul(this IApplicationBuilder app)
        {
            var consulClient = app.ApplicationServices.GetRequiredService<IConsulClient>();
            var logger = app.ApplicationServices.GetRequiredService<ILoggerFactory>().CreateLogger("AppExtensions");
            var lifetime = app.ApplicationServices.GetRequiredService<Microsoft.Extensions.Hosting.IHostApplicationLifetime>();

            var registration = new AgentServiceRegistration()
            {
                ID = "ServiceDiscovery",
                Name = "Service Discovery",
                Address = "localhost",
                Port = 60000
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
