using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace Funda.Api.Extensions
{
    public static class VersioningExtensions
    {
        public static IServiceCollection AddAndConfigureVersioning(this IServiceCollection services)
        {
            return services.AddApiVersioning(options =>
            {
                options.ReportApiVersions = true;
                options.AssumeDefaultVersionWhenUnspecified = true;
                options.DefaultApiVersion = new ApiVersion(1, 0);
            });
        } 
    }
}