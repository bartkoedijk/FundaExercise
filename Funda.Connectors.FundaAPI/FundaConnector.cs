using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using CSharpFunctionalExtensions;
using Funda.Connectors.FundaAPI.Models;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace Funda.Connectors.FundaAPI
{
    public class FundaConnector : IFundaConnector
    {
        private readonly HttpClient _httpClient;
        private readonly ILogger<FundaConnector> _logger;

        public FundaConnector(HttpClient httpClient, ILogger<FundaConnector> logger)
        {
            _httpClient = httpClient;
            _logger = logger;
        }

        public async Task<Result<ResultOverview>> GetHousesAmsterdamAsync(CancellationToken cancellationToken)
        {
            var result = new ResultOverview();
            var taskList = new List<Task<ResultOverview>>();
            const int size = 25;

            var endpointOne = GetBuyHousesAmsterdamEndpoint(1, size);
            var responseOne = await FetchResultOverview(endpointOne, cancellationToken);
            result.Huizen = responseOne.Huizen;
            
            var amount = Math.Ceiling(responseOne.TotaalAantalObjecten / (double) size);
            for (var i = 2; i < amount; i++)
            {
                var endpoint = GetBuyHousesAmsterdamEndpoint(page: i, size);
                var task = FetchResultOverview(endpoint, cancellationToken);
                taskList.Add(task);
            }
            
            try
            {
                var overviews = await Task.WhenAll(taskList);
                foreach (var overview in overviews)
                {
                    if (overview == null)
                        continue;
                    result.Huizen = result.Huizen == null
                        ? overview.Huizen
                        : result.Huizen.Concat(overview.Huizen).ToList();
                }
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return Result.Failure<ResultOverview>(e.Message);
            }

            return result;
        }


        public async Task<Result<ResultOverview>> GetHousesWithGardenAmsterdamAsync(CancellationToken cancellationToken)
        {
            var result = new ResultOverview();
            var taskList = new List<Task<ResultOverview>>();
            const int size = 25;

            var endpointOne = GetBuyHousesAmsterdamWithGardenEndpoint(1, size);
            var responseOne = await FetchResultOverview(endpointOne, cancellationToken);
            result.Huizen = responseOne.Huizen;
            
            var amount = Math.Ceiling(responseOne.TotaalAantalObjecten / (double) size);
            for (var i = 2; i < amount; i++)
            {
                var endpoint = GetBuyHousesAmsterdamWithGardenEndpoint(page: i, size);
                var task = FetchResultOverview(endpoint, cancellationToken);
                taskList.Add(task);
            }
            
            try
            {
                var overviews = await Task.WhenAll(taskList);
                foreach (var overview in overviews)
                {
                    if (overview == null)
                        continue;
                    result.Huizen = result.Huizen == null
                        ? overview.Huizen
                        : result.Huizen.Concat(overview.Huizen).ToList();
                }
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return Result.Failure<ResultOverview>(e.Message);
            }

            return result;
        }


        private async Task<ResultOverview> FetchResultOverview(string endpoint, CancellationToken cancellationToken)
        {
            try
            {
                var response = await _httpClient.GetAsync(endpoint, cancellationToken);

                if (!response.IsSuccessStatusCode)
                    throw new Exception($"Couldn't fetch users because of: {response.StatusCode}");

                await Task.Delay(1600, cancellationToken); //1.6 seconds (100 requests / 60sec)

                var responseBody = await response.Content.ReadAsStringAsync();
                var resultOverview = JsonConvert.DeserializeObject<ResultOverview>(responseBody,
                    new JsonSerializerSettings
                    {
                        NullValueHandling = NullValueHandling.Ignore
                    });

                return resultOverview;
            }
            catch (Exception e)
            {
                _logger.LogError(e.Message);
                return null;
            }
        }

        private static string GetBuyHousesAmsterdamEndpoint(int page, int size) => $"?type=koop&zo=/amsterdam/&page={page}&pagesize={size}";
        private static string GetBuyHousesAmsterdamWithGardenEndpoint(int page, int size) => $"?type=koop&zo=/amsterdam/tuin/&page={page}&pagesize={size}";
        
    }
}