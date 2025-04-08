using System.Text.Json.Serialization;

namespace BTCPrice.Model
{
    public class Data
    {

        [JsonPropertyName("INSTRUMENT")]
        public string Instrument { get; set; }

        [JsonPropertyName("PRICE")]
        public decimal Price { get; set; }

        [JsonPropertyName("PRICE_LAST_UPDATE_TS")]
        public long PriceLastUpdateTs { get; set; }

        public decimal? CzkEurRate { get; set; }

        public decimal? PriceCZK
        {
            get
            {
                return Price * CzkEurRate;
            }
        }
    }
}
