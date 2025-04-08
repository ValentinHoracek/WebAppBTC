using BTCPrice.Model;

namespace BTCPrice.Services
{
    public class CoindeskService
    {
        private readonly HttpClient _httpClient;

        public CoindeskService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<CoindeskResponse> GetBTCEURAsync()
        {
            try
            {
                return await _httpClient.GetFromJsonAsync<CoindeskResponse>("https://data-api.coindesk.com/spot/v1/latest/tick?market=coinbase&instruments=BTC-EUR");
            }
            catch (Exception ex)
            {
                // Handle potential errors (logging, displaying a message, etc.)
                Console.WriteLine($"Error fetching data: {ex.Message}");
                return null;
            }
        }
    }
}
