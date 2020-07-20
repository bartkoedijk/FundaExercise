using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Funda.Api.Extensions;
using Funda.Connectors.FundaAPI.Extensions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Funda.Api
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services
                .AddAndConfigureSwagger()
                .AddAndConfigureFundaApi()
                .AddAndConfigureVersioning()
                .AddAndConfigureServices()
                .AddMvc(opts => opts.EnableEndpointRouting = false);

        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app
                .UseAndSetSwaggerConfiguration()
                .UseRouting()
            .UseMvc();
        }
    }
}