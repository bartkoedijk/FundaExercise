using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CSharpFunctionalExtensions;
using Funda.Connectors.FundaAPI;

namespace Funda.Api.Services
{
    public class FundaService : IFundaService
    {
        private readonly IFundaConnector _fundaConnector;

        public FundaService(IFundaConnector fundaConnector)
        {
            _fundaConnector = fundaConnector;
        }
       
        public async Task<Result<Dictionary<string, int>>> TopTenEstateAgents(CancellationToken cancellationToken)
        {
            var result = await _fundaConnector.GetHousesAmsterdamAsync(cancellationToken);

            if (result.IsFailure)
                return Result.Failure<Dictionary<string,int>>(result.Error);
            try
            {
                return result.Value.Huizen
                    .GroupBy(x => x.MakelaarNaam)
                    .ToDictionary(x => x.Key, x => x.Count())
                    .OrderByDescending(x => x.Value)
                    .Take(10)
                    .ToDictionary(x => x.Key, x => x.Value);
            }
            catch (Exception e)
            {
                return Result.Failure<Dictionary<string,int>>(e.Message);
            }
        }
        
        public async Task<Result<Dictionary<string, int>>> TopTenEstateAgentsWithGarden(CancellationToken cancellationToken)
        {
            var result = await _fundaConnector.GetHousesWithGardenAmsterdamAsync(cancellationToken);

            if (result.IsFailure)
                return Result.Failure<Dictionary<string,int>>(result.Error);
            try
            {
                return result.Value.Huizen
                    .GroupBy(x => x.MakelaarNaam)
                    .ToDictionary(x => x.Key, x => x.Count())
                    .OrderByDescending(x => x.Value)
                    .Take(10)
                    .ToDictionary(x => x.Key, x => x.Value);
            }
            catch (Exception e)
            {
                return Result.Failure<Dictionary<string,int>>(e.Message);
            }
        }
    }
}