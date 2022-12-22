using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Polly.web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            /*
            services.AddHttpClient("errorApiClient", c =>
            {
                c.BaseAddress = new Uri("http://localhost:39696/");
            });
            */
            /*
            services.AddHttpClient("errorApiClient", c =>
            {
                c.BaseAddress = new Uri("http://localhost:39696/");
            }).AddTransientHttpErrorPolicy(policy => policy.WaitAndRetryAsync(new[]
            {
                TimeSpan.FromSeconds(1),
                TimeSpan.FromSeconds(5),
                TimeSpan.FromSeconds(10)
            }));
            */
            services.AddHttpClient("errorApi", c =>
            {
                c.BaseAddress = new Uri("http://localhost:39696/");
            }).AddTransientHttpErrorPolicy(p => p.CircuitBreakerAsync(2, TimeSpan.FromMinutes(1)));
        }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
