namespace BTCPrice.Model
{
    public class PriceDetail
    {
        public long Id { get; set; }
        public decimal? PriceEUR { get; set; }
        public decimal? PriceCZK { get; set; }

        public DateTimeOffset Time { get; set; }
        public string Note { get; set; }

    }
}
