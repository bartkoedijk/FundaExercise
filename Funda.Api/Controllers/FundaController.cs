using System.Threading;
using System.Threading.Tasks;
using Funda.Api.Constants;
using Funda.Api.Services;
using Microsoft.AspNetCore.Mvc;

namespace Funda.Api.Controllers
{
    [ApiController]
    [ApiVersion(ProjectConstants.Version)]
    [Route("api/v{version:apiVersion}/[controller]")]
    // [Route("[controller]")]
    public class FundaController : ControllerBase
    {
        private readonly IFundaService _fundaService;

        public FundaController(IFundaService fundaService)
        {
            _fundaService = fundaService;
        }

        [HttpGet("EstateAgents")]
        public async Task<IActionResult> TopTenEstateAgents(CancellationToken cancellationToken)
        {
           var result = await _fundaService.TopTenEstateAgents(cancellationToken);
           if (result.IsFailure)
               return BadRequest(result.Error);
           return Ok(result.Value);
        }
        
        [HttpGet("Gardens")]
        public async Task<IActionResult> TopTenMakelaarsWithGarden(CancellationToken cancellationToken)
        {
            var result = await _fundaService.TopTenEstateAgentsWithGarden(cancellationToken);
            if (result.IsFailure)
                return BadRequest(result.Error);
            return Ok(result.Value);
        }
    }
}