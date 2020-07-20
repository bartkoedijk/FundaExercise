using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using CSharpFunctionalExtensions;
using Funda.Connectors.FundaAPI.Models;

namespace Funda.Connectors.FundaAPI
{
    public interface IFundaConnector
    {
        Task<Result<ResultOverview>> GetHousesAmsterdamAsync(CancellationToken cancellationToken);
        Task<Result<ResultOverview>> GetHousesWithGardenAmsterdamAsync(CancellationToken cancellationToken);
    }
}