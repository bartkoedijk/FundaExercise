using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using CSharpFunctionalExtensions;

namespace Funda.Api.Services
{
    public interface IFundaService
    {
        Task<Result<Dictionary<string, int>>> TopTenEstateAgents(CancellationToken cancellationToken);
        Task<Result<Dictionary<string, int>>> TopTenEstateAgentsWithGarden(CancellationToken cancellationToken);
    }
}