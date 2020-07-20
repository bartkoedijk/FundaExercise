using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Funda.Api.Services;
using Funda.Connectors.FundaAPI;
using Funda.Connectors.FundaAPI.Models;
using Moq;
using NUnit.Framework;
using Stashbox.Mocking.Moq;
using System.Linq;
using FluentAssertions;

namespace Funda.Tests.UnitTests
{
    public class FundaServiceTests
    {
        [Test]
        public async Task GivenGetTopTenEstateAgents()
        {
            var resultOverview = GetResultOverview();
            using var stash = StashMoq.Create(verifyAll: true);

            SetupEnvironmentGetEstateAgents(stash, resultOverview);

            var service =  stash.Get<FundaService>();

            var result = await service.TopTenEstateAgents(CancellationToken.None);

            result.IsSuccess.Should().BeTrue();
            result.Value.Values.Should().HaveCount(resultOverview.Huizen.Count);
        }

        private static void SetupEnvironmentGetEstateAgents(StashMoq stash, ResultOverview resultOverview)
        {
            stash.Mock<IFundaConnector>().Setup(c =>
                c.GetHousesAmsterdamAsync(CancellationToken.None)).ReturnsAsync(resultOverview);
        }

        private static ResultOverview GetResultOverview()
        {
            return new ResultOverview
            {
                Huizen = new List<Huis>
                {
                    new Huis
                    {
                        MakelaarNaam = "FRIS Woningmakelaars Amsterdam"
                    },
                    new Huis
                    {
                        MakelaarNaam = "Heeren Makelaars"
                    }
                }
            };
        }
    }
}