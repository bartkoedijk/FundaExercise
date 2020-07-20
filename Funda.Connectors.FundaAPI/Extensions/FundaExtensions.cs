using System;
using Microsoft.Extensions.DependencyInjection;

namespace Funda.Connectors.FundaAPI.Extensions
{
    public static class FundaExtensions
    {
        public static IServiceCollection AddAndConfigureFundaApi(this IServiceCollection services)
        {
            services.AddScoped<IFundaConnector, FundaConnector>();
            var key = Environment.GetEnvironmentVariable("FundaKey");
            
            services.AddHttpClient<IFundaConnector, FundaConnector>("Funda", client =>
            {
                client.BaseAddress = new Uri($"http://partnerapi.funda.nl/feeds/Aanbod.svc/json/{key}");
            } );
            return services;
        }
    }
}