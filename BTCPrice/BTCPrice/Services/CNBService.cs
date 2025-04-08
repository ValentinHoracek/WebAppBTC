namespace BTCPrice.Services
{
    public class CNBService
    {
        private readonly HttpClient _httpClient;
        private const string CNBApiUrl = "https://www.cnb.cz/cs/financni-trhy/devizovy-trh/kurzy-devizoveho-trhu/kurzy-devizoveho-trhu/denni_kurz.txt";

        public CNBService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<decimal?> GetCzkEurPrice()
        {
            try
            {
                var response = await _httpClient.GetStringAsync(CNBApiUrl);
                if (!string.IsNullOrEmpty(response))
                {
                    // CNB provides data in a fixed-width format. We need to parse it.

                    string[] lines = response.Split(new[] { "\n", "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

                    // Look for the line containing EUR
                    foreach (var line in lines)
                    {
                        if (line.Contains("EUR|"))
                        {
                            string[] parts = line.Split('|');

                            if (parts.Length > 4 && parts[2].Trim() == "1" && decimal.TryParse(parts[4].Trim(), out decimal price))
                            {
                                return price;
                            }
                        }
                    }
                }
                return null; // EUR not found or parsing failed
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching CZK/EUR price from CNB: {ex.Message}");
                return null;
            }
        }
    }
}
