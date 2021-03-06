using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Funda.Connectors.FundaAPI.Models
{
    public class House
    {
        [JsonProperty("AangebodenSindsTekst")]
        public string AangebodenSindsTekst { get; set; }

        [JsonProperty("AanmeldDatum")]
        public string AanmeldDatum { get; set; }

        [JsonProperty("AantalBeschikbaar")]
        public object AantalBeschikbaar { get; set; }

        [JsonProperty("AantalKamers")]
        public long AantalKamers { get; set; }

        [JsonProperty("AantalKavels")]
        public object AantalKavels { get; set; }

        [JsonProperty("Aanvaarding")]
        public string Aanvaarding { get; set; }

        [JsonProperty("Adres")]
        public string Adres { get; set; }

        [JsonProperty("Afstand")]
        public long Afstand { get; set; }

        [JsonProperty("BronCode")]
        public string BronCode { get; set; }

        [JsonProperty("ChildrenObjects")]
        public List<object> ChildrenObjects { get; set; }

        [JsonProperty("DatumAanvaarding")]
        public object DatumAanvaarding { get; set; }

        [JsonProperty("DatumOndertekeningAkte")]
        public object DatumOndertekeningAkte { get; set; }

        [JsonProperty("Foto")]
        public Uri Foto { get; set; }

        [JsonProperty("FotoLarge")]
        public Uri FotoLarge { get; set; }

        [JsonProperty("FotoLargest")]
        public Uri FotoLargest { get; set; }

        [JsonProperty("FotoMedium")]
        public Uri FotoMedium { get; set; }

        [JsonProperty("FotoSecure")]
        public Uri FotoSecure { get; set; }

        [JsonProperty("GewijzigdDatum")]
        public object GewijzigdDatum { get; set; }

        [JsonProperty("GlobalId")]
        public long GlobalId { get; set; }

        [JsonProperty("GroupByObjectType")]
        public Guid GroupByObjectType { get; set; }

        [JsonProperty("Heeft360GradenFoto")]
        public bool Heeft360GradenFoto { get; set; }

        [JsonProperty("HeeftBrochure")]
        public bool HeeftBrochure { get; set; }

        [JsonProperty("HeeftOpenhuizenTopper")]
        public bool HeeftOpenhuizenTopper { get; set; }

        [JsonProperty("HeeftOverbruggingsgrarantie")]
        public bool HeeftOverbruggingsgrarantie { get; set; }

        [JsonProperty("HeeftPlattegrond")]
        public bool HeeftPlattegrond { get; set; }

        [JsonProperty("HeeftTophuis")]
        public bool HeeftTophuis { get; set; }

        [JsonProperty("HeeftVeiling")]
        public bool HeeftVeiling { get; set; }

        [JsonProperty("HeeftVideo")]
        public bool HeeftVideo { get; set; }

        [JsonProperty("HuurPrijsTot")]
        public object HuurPrijsTot { get; set; }

        [JsonProperty("Huurprijs")]
        public object Huurprijs { get; set; }

        [JsonProperty("HuurprijsFormaat")]
        public object HuurprijsFormaat { get; set; }

        [JsonProperty("Id")]
        public Guid Id { get; set; }

        [JsonProperty("InUnitsVanaf")]
        public object InUnitsVanaf { get; set; }

        [JsonProperty("IndProjectObjectType")]
        public bool IndProjectObjectType { get; set; }

        [JsonProperty("IndTransactieMakelaarTonen")]
        public object IndTransactieMakelaarTonen { get; set; }

        [JsonProperty("IsSearchable")]
        public bool IsSearchable { get; set; }

        [JsonProperty("IsVerhuurd")]
        public bool IsVerhuurd { get; set; }

        [JsonProperty("IsVerkocht")]
        public bool IsVerkocht { get; set; }

        [JsonProperty("IsVerkochtOfVerhuurd")]
        public bool IsVerkochtOfVerhuurd { get; set; }

        [JsonProperty("Koopprijs")]
        public long Koopprijs { get; set; }

        [JsonProperty("KoopprijsFormaat")]
        public string KoopprijsFormaat { get; set; }

        [JsonProperty("KoopprijsTot")]
        public long KoopprijsTot { get; set; }

        [JsonProperty("MakelaarId")]
        public long MakelaarId { get; set; }

        [JsonProperty("MakelaarNaam")]
        public string MakelaarNaam { get; set; }

        [JsonProperty("MobileURL")]
        public Uri MobileUrl { get; set; }

        [JsonProperty("Note")]
        public object Note { get; set; }

        [JsonProperty("OpenHuis")]
        public List<object> OpenHuis { get; set; }

        [JsonProperty("Oppervlakte")]
        public long Oppervlakte { get; set; }

        [JsonProperty("Perceeloppervlakte")]
        public long Perceeloppervlakte { get; set; }

        [JsonProperty("Postcode")]
        public string Postcode { get; set; }

        [JsonProperty("Prijs")]
        public Prijs Prijs { get; set; }

        [JsonProperty("PrijsGeformatteerdHtml")]
        public string PrijsGeformatteerdHtml { get; set; }

        [JsonProperty("PrijsGeformatteerdTextHuur")]
        public string PrijsGeformatteerdTextHuur { get; set; }

        [JsonProperty("PrijsGeformatteerdTextKoop")]
        public string PrijsGeformatteerdTextKoop { get; set; }

        [JsonProperty("Producten")]
        public List<string> Producten { get; set; }

        [JsonProperty("Project")]
        public Project Project { get; set; }

        [JsonProperty("ProjectNaam")]
        public object ProjectNaam { get; set; }

        [JsonProperty("PromoLabel")]
        public PromoLabel PromoLabel { get; set; }

        [JsonProperty("PublicatieDatum")]
        public string PublicatieDatum { get; set; }

        [JsonProperty("PublicatieStatus")]
        public long PublicatieStatus { get; set; }

        [JsonProperty("SavedDate")]
        public object SavedDate { get; set; }

        [JsonProperty("Soort-aanbod")]
        public string SoortAanbod { get; set; }

        [JsonProperty("SoortAanbod")]
        public long ObjectSoortAanbod { get; set; }

        [JsonProperty("StartOplevering")]
        public object StartOplevering { get; set; }

        [JsonProperty("TimeAgoText")]
        public object TimeAgoText { get; set; }

        [JsonProperty("TransactieAfmeldDatum")]
        public object TransactieAfmeldDatum { get; set; }

        [JsonProperty("TransactieMakelaarId")]
        public object TransactieMakelaarId { get; set; }

        [JsonProperty("TransactieMakelaarNaam")]
        public object TransactieMakelaarNaam { get; set; }

        [JsonProperty("TypeProject")]
        public long TypeProject { get; set; }

        [JsonProperty("URL")]
        public Uri Url { get; set; }

        [JsonProperty("VerkoopStatus")]
        public string VerkoopStatus { get; set; }

        [JsonProperty("WGS84_X")]
        public double Wgs84X { get; set; }

        [JsonProperty("WGS84_Y")]
        public double Wgs84Y { get; set; }

        [JsonProperty("WoonOppervlakteTot")]
        public long WoonOppervlakteTot { get; set; }

        [JsonProperty("Woonoppervlakte")]
        public long Woonoppervlakte { get; set; }

        [JsonProperty("Woonplaats")]
        public string Woonplaats { get; set; }

        [JsonProperty("ZoekType")]
        public List<long> ZoekType { get; set; }
    }
}