using Newtonsoft.Json;
using System.Xml;

namespace CryptoProject.Models
{
    public class CryptoModel
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        [JsonProperty("current_price")]
        public decimal CurrentPrice { get; set; }

        [JsonProperty("total_volume")]
        public decimal TotalVolume { get; set; }

        [JsonProperty("market_cap")]
        public long MarketCap { get; set; }

        [JsonProperty("market_cap_rank")]
        public int MarketCapRank { get; set; }

        [JsonProperty("price_change_percentage_1h_in_currency")]
        public decimal PriceChange1h { get; set; }

        [JsonProperty("price_change_percentage_24h_in_currency")]
        public decimal PriceChange24h { get; set; }

        [JsonProperty("price_change_percentage_7d_in_currency")]
        public decimal PriceChange7d { get; set; }

    }
}
