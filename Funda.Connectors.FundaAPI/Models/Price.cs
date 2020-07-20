using Newtonsoft.Json;

namespace Funda.Connectors.FundaAPI.Models
{
    public class Prijs
    {
        [JsonProperty("GeenExtraKosten")]
        public bool GeenExtraKosten { get; set; }

        [JsonProperty("HuurAbbreviation")]
        public string HuurAbbreviation { get; set; }

        [JsonProperty("Huurprijs")]
        public object Huurprijs { get; set; }

        [JsonProperty("HuurprijsOpAanvraag")]
        public string HuurprijsOpAanvraag { get; set; }

        [JsonProperty("HuurprijsTot")]
        public object HuurprijsTot { get; set; }

        [JsonProperty("KoopAbbreviation")]
        public string KoopAbbreviation { get; set; }

        [JsonProperty("Koopprijs")]
        public long Koopprijs { get; set; }

        [JsonProperty("KoopprijsOpAanvraag")]
        public string KoopprijsOpAanvraag { get; set; }

        [JsonProperty("KoopprijsTot")]
        public long KoopprijsTot { get; set; }

        [JsonProperty("OriginelePrijs")]
        public object OriginelePrijs { get; set; }

        [JsonProperty("VeilingText")]
        public string VeilingText { get; set; }
    }
}