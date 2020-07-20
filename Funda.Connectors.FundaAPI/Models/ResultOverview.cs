using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Funda.Connectors.FundaAPI.Models
{
    public class ResultOverview
    {
        [JsonProperty("AccountStatus")]
        public long AccountStatus { get; set; }

        [JsonProperty("EmailNotConfirmed")]
        public bool EmailNotConfirmed { get; set; }

        [JsonProperty("ValidationFailed")]
        public bool ValidationFailed { get; set; }

        [JsonProperty("ValidationReport")]
        public object ValidationReport { get; set; }

        [JsonProperty("Website")]
        public long Website { get; set; }

        [JsonProperty("Metadata")]
        public Metadata Metadata { get; set; }

        [JsonProperty("Objects")]
        public List<Huis> Huizen { get; set; }

        [JsonProperty("Paging")]
        public Paging Paging { get; set; }

        [JsonProperty("TotaalAantalObjecten")]
        public long TotaalAantalObjecten { get; set; }
    }
}