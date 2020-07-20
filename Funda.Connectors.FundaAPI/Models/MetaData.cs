using Newtonsoft.Json;

namespace Funda.Connectors.FundaAPI.Models
{
    public class Metadata
    {
        [JsonProperty("ObjectType")]
        public string ObjectType { get; set; }

        [JsonProperty("Omschrijving")]
        public string Omschrijving { get; set; }

        [JsonProperty("Titel")]
        public string Titel { get; set; }
    }
}