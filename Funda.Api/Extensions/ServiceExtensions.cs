using Funda.Api.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Funda.Api.Extensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddAndConfigureServices(this IServiceCollection services)
        {
            services.AddScoped<IFundaService, FundaService>();
            return services;
        }
    }
}