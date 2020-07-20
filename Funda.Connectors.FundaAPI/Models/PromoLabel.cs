using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Funda.Connectors.FundaAPI.Models
{
    public class PromoLabel
    {
        [JsonProperty("HasPromotionLabel")]
        public bool HasPromotionLabel { get; set; }

        [JsonProperty("PromotionPhotos")]
        public List<Uri> PromotionPhotos { get; set; }

        [JsonProperty("PromotionPhotosSecure")]
        public List<string> PromotionPhotosSecure { get; set; }

        [JsonProperty("PromotionType")]
        public long PromotionType { get; set; }

        [JsonProperty("RibbonColor")]
        public long RibbonColor { get; set; }

        [JsonProperty("RibbonText")]
        public object RibbonText { get; set; }

        [JsonProperty("Tagline")]
        public string Tagline { get; set; }
    }
}