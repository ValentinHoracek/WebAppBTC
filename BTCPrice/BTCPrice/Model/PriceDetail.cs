namespace BTCPrice.Model
{
    public class PriceDetail
    {
        public long Id { get; set; }
        public decimal? PriceEUR { get; set; }
        public decimal? PriceCZK { get; set; }

        public DateTimeOffset Time { get; set; }
        public string Note { get; set; } = string.Empty;

        public string TimeString
        {
            get => Time.ToString("O"); // "O" is a round-trip format
            set
            {
                if (DateTimeOffset.TryParse(value, out var dto))
                {
                    Time = dto;
                }
                else
                {
                    // Handle parsing error (e.g., set a validation error)
                }
            }
        }
    }
}
