using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CSharpFunctionalExtensions;
using Funda.Connectors.FundaAPI.Models;
using Newtonsoft.Json;

namespace Funda.Connectors.FundaAPI
{
    public class FundaConnector : IFundaConnector
    {
        private readonly HttpClient _httpClient;
 
        public FundaConnector(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<Result<ResultOverview>> GetHousesAmsterdamAsync(CancellationToken cancellationToken)
        {
            var endpointQuery =
                "?type=koop&zo=/amsterdam";
            
            var response = await _httpClient.GetAsync(endpointQuery, cancellationToken);
           if (!response.IsSuccessStatusCode)
           {
               return Result.Failure<ResultOverview>("Couldn't fetch houses");
           }
           var responseBody =await response.Content.ReadAsStringAsync();

           try
           {
               return JsonConvert.DeserializeObject<ResultOverview>(responseBody);
           }
           catch (Exception e)
           {
               return Result.Failure<ResultOverview>(e.Message);
           }
        }
        
        public async Task<Result<ResultOverview>> GetHousesWithGardenAmsterdamAsync(CancellationToken cancellationToken)
        {
            var endpointQuery =
                "?type=koop&zo=/amsterdam/tuin/";
            
            var response = await _httpClient.GetAsync(endpointQuery, cancellationToken);
            if (!response.IsSuccessStatusCode)
                return Result.Failure<ResultOverview>("Couldn't fetch houses");
            
            var responseBody =await response.Content.ReadAsStringAsync();

            try
            {
                return JsonConvert.DeserializeObject<ResultOverview>(responseBody);
            }
            catch (Exception e)
            {
                return Result.Failure<ResultOverview>(e.Message);
            }
        }
    }
}