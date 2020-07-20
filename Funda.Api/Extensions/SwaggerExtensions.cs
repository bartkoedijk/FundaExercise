using System.Collections.Generic;
using Funda.Api.Constants;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace Funda.Api.Extensions
{
    public static class SwaggerExtensions
    {
        public static IServiceCollection AddAndConfigureSwagger(this IServiceCollection services)
        {
            return services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = ProjectConstants.Name,
                    Version = ProjectConstants.Version,
                });

                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    Description = "Add the Bearer token to make requests",
                    Name = "Authorization",
                    In = ParameterLocation.Header,
                    Type = SecuritySchemeType.ApiKey,
                    Scheme = "Bearer"
                });
                c.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type = ReferenceType.SecurityScheme,
                                Id = "Bearer"
                            },
                            Scheme = "oauth2",
                            Name = "Bearer",
                            In = ParameterLocation.Header,
                        },
                        new List<string>()
                    }
                });
            });
        }

        public static IApplicationBuilder UseAndSetSwaggerConfiguration(this IApplicationBuilder app)
        {
            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", ProjectConstants.Name + ProjectConstants.Version);
                c.RoutePrefix = string.Empty; //Set the default page to Swagger
            });

            return app;
        }
    }
}