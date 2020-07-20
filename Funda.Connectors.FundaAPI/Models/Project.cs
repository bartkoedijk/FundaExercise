using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Funda.Connectors.FundaAPI.Models
{
    public  class Project
    {
        [JsonProperty("AantalKamersTotEnMet")]
        public object AantalKamersTotEnMet { get; set; }

        [JsonProperty("AantalKamersVan")]
        public object AantalKamersVan { get; set; }

        [JsonProperty("AantalKavels")]
        public object AantalKavels { get; set; }

        [JsonProperty("Adres")]
        public object Adres { get; set; }

        [JsonProperty("FriendlyUrl")]
        public object FriendlyUrl { get; set; }

        [JsonProperty("GewijzigdDatum")]
        public object GewijzigdDatum { get; set; }

        [JsonProperty("GlobalId")]
        public object GlobalId { get; set; }

        [JsonProperty("HoofdFoto")]
        public string HoofdFoto { get; set; }

        [JsonProperty("IndIpix")]
        public bool IndIpix { get; set; }

        [JsonProperty("IndPDF")]
        public bool IndPdf { get; set; }

        [JsonProperty("IndPlattegrond")]
        public bool IndPlattegrond { get; set; }

        [JsonProperty("IndTop")]
        public bool IndTop { get; set; }

        [JsonProperty("IndVideo")]
        public bool IndVideo { get; set; }

        [JsonProperty("InternalId")]
        public Guid InternalId { get; set; }

        [JsonProperty("MaxWoonoppervlakte")]
        public object MaxWoonoppervlakte { get; set; }

        [JsonProperty("MinWoonoppervlakte")]
        public object MinWoonoppervlakte { get; set; }

        [JsonProperty("Naam")]
        public object Naam { get; set; }

        [JsonProperty("Omschrijving")]
        public object Omschrijving { get; set; }

        [JsonProperty("OpenHuizen")]
        public List<object> OpenHuizen { get; set; }

        [JsonProperty("Plaats")]
        public object Plaats { get; set; }

        [JsonProperty("Prijs")]
        public object Prijs { get; set; }

        [JsonProperty("PrijsGeformatteerd")]
        public object PrijsGeformatteerd { get; set; }

        [JsonProperty("PublicatieDatum")]
        public object PublicatieDatum { get; set; }

        [JsonProperty("Type")]
        public long Type { get; set; }

        [JsonProperty("Woningtypen")]
        public object Woningtypen { get; set; }
    }
}