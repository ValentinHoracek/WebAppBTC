using System.Text.Json.Serialization;

namespace BTCPrice.Model
{
    public class CoindeskResponse
    {
        [JsonPropertyName("Data")]
        public DataWrapper Data { get; set; }

        [JsonPropertyName("Err")]
        public object Err { get; set; }
    }
}
