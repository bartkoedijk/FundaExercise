using Newtonsoft.Json;

namespace Funda.Connectors.FundaAPI.Models
{
    public class Paging
    {
        [JsonProperty("AantalPaginas")]
        public long AantalPaginas { get; set; }

        [JsonProperty("HuidigePagina")]
        public long HuidigePagina { get; set; }

        [JsonProperty("VolgendeUrl")]
        public string VolgendeUrl { get; set; }

        [JsonProperty("VorigeUrl")]
        public object VorigeUrl { get; set; }
    }
}